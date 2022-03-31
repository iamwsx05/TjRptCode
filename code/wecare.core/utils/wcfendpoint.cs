using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using weCare.Core.Entity;
using weCare.Core.Itf;

namespace weCare.Core.Utils
{
    /// <summary>
    /// WCF终结点
    /// </summary>
    public class WcfEndpoint
    {
        #region 变量
        /// <summary>
        /// WCF绑定协议
        /// </summary>
        private static System.EnterpriseServices.SharedProperty SPWCFBinding = null;
        /// <summary>
        /// WCF端点地址
        /// </summary>
        private static System.EnterpriseServices.SharedProperty SPWCFEndpointAddr = null;

        /// <summary>
        /// 中间件服务器列表
        /// </summary>
        public static List<string> MiddleServers = new List<string>();

        #endregion

        #region 默认中间层服务器
        /// <summary>
        /// 默认中间层服务器
        /// </summary>
        /// <returns></returns>
        private static string DefaultMidderSvr()
        {
            string strMidderSvc = string.Empty;
            string strFile = Function.AppConfigFile;
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(strFile);

            System.Xml.XmlNodeList nodelist = doc["Main"].GetElementsByTagName("wcfAddress");
            if (nodelist == null || nodelist.Count == 0)
            {
                return strMidderSvc;
            }
            strMidderSvc = (nodelist.Item(0)).Attributes["value"].Value.Trim();
            doc = null;

            return strMidderSvc;
        }
        #endregion

        #region 中间层服务器列表
        /// <summary>
        /// 中间层服务器列表
        /// </summary>
        public static void GetMiddleServers()
        {
            string strFile = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\app.xml";
            List<string> lstSvr = new List<string>();

            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(strFile);

            System.Xml.XmlNodeList nodelist = doc["Main"].GetElementsByTagName("wcfAddress");
            if (nodelist == null || nodelist.Count == 0)
            {
                return;
            }

            for (int i = 0; i < nodelist.Count; i++)
            {
                lstSvr.Add((nodelist.Item(i)).Attributes["value"].Value.Trim());
            }
            doc = null;

            if (lstSvr.Count > 0)
            {
                int[] intSorts = RandomMode.RandomArr(lstSvr.Count);
                if (WcfEndpoint.MiddleServers == null)
                    WcfEndpoint.MiddleServers = new List<string>();
                if (WcfEndpoint.MiddleServers.Count > 0)
                    WcfEndpoint.MiddleServers.Clear();
                for (int i = 0; i < lstSvr.Count; i++)
                {
                    WcfEndpoint.MiddleServers.Add(lstSvr[intSorts[i]]);
                }
            }
        }

        #endregion

        #region 是否允许切换服务器
        /// <summary>
        /// 是否允许切换服务器
        /// </summary>
        public static bool AllowChange
        {
            get
            {
                return (MiddleServers.Count() > 1);
            }
        }
        #endregion

        #region 调整顺序
        /// <summary>
        /// 调整顺序
        /// </summary>
        public static void ChangeServer()
        {
            if (MiddleServers.Count > 1)
            {
                List<string> lstSvrs = MiddleServers.GetRange(1, MiddleServers.Count - 1);
                lock (MiddleServers)
                {
                    MiddleServers.RemoveRange(1, MiddleServers.Count - 1);
                    MiddleServers.InsertRange(0, lstSvrs);
                }
            }
        }
        #endregion

        #region WCF绑定协议
        /// <summary>
        /// WCF绑定协议
        /// </summary>
        public static System.ServiceModel.Channels.Binding Binding
        {
            get
            {
                string strBinding = string.Empty;
                try
                {
                    strBinding = SPWCFBinding.Value.ToString();
                }
                catch
                {
                    bool blnGroupExists = false;
                    bool blnPropertyExists = false;

                    PropertyLockMode objLockMode = PropertyLockMode.SetGet;
                    PropertyReleaseMode objReleaseMode = PropertyReleaseMode.Process;

                    SharedPropertyGroupManager objGroupManager = new SharedPropertyGroupManager();
                    SharedPropertyGroup objGroup = objGroupManager.CreatePropertyGroup("WcfBindingGroup", ref objLockMode, ref objReleaseMode, out blnGroupExists);

                    SPWCFBinding = objGroup.CreateProperty("WcfBinding", out blnPropertyExists);

                    strBinding = null;
                    try
                    {
                        strBinding = Function.ReadLocalSettingValue("Main|wcfBinding", "value");
                        if (string.IsNullOrEmpty(strBinding))
                        {
                            strBinding = "1";
                        }
                    }
                    catch
                    {
                        strBinding = "1";
                    }
                    SPWCFBinding.Value = strBinding;
                }

                System.ServiceModel.BasicHttpBinding basicHttpBinding = null;
                System.ServiceModel.WSHttpBinding wsHttpBinding = null;
                System.ServiceModel.NetTcpBinding netTcpBinding = null;
                switch (strBinding)
                {
                    case "1": //不支持事务
                        basicHttpBinding = new System.ServiceModel.BasicHttpBinding();
                        basicHttpBinding.MaxBufferPoolSize = 2147483647;
                        basicHttpBinding.MaxReceivedMessageSize = 2147483647;
                        basicHttpBinding.ReaderQuotas.MaxArrayLength = 2147483647;
                        basicHttpBinding.ReaderQuotas.MaxDepth = 32000;
                        basicHttpBinding.ReaderQuotas.MaxBytesPerRead = 2147483647;
                        basicHttpBinding.ReaderQuotas.MaxStringContentLength = 2147483647;
                        basicHttpBinding.ReceiveTimeout = new TimeSpan(0, 10, 0);
                        basicHttpBinding.UseDefaultWebProxy = false;
                        //目前以：1分钟测试WCF传输性能,以后放开 --＞　放开到10分钟
                        basicHttpBinding.SendTimeout = new TimeSpan(0, 10, 0);
                        return basicHttpBinding;
                    case "2":
                        wsHttpBinding = new System.ServiceModel.WSHttpBinding();
                        wsHttpBinding.MaxBufferPoolSize = 2147483647;
                        wsHttpBinding.MaxReceivedMessageSize = 2147483647;
                        wsHttpBinding.ReaderQuotas.MaxArrayLength = 2147483647;
                        wsHttpBinding.ReaderQuotas.MaxDepth = 32;
                        wsHttpBinding.ReaderQuotas.MaxBytesPerRead = 2147483647;
                        wsHttpBinding.ReaderQuotas.MaxStringContentLength = 2147483647;
                        wsHttpBinding.ReceiveTimeout = new TimeSpan(0, 10, 0);
                        wsHttpBinding.TransactionFlow = true;
                        wsHttpBinding.UseDefaultWebProxy = false;
                        return wsHttpBinding;
                    case "3":
                        netTcpBinding = new System.ServiceModel.NetTcpBinding();
                        netTcpBinding.MaxBufferPoolSize = 2147483647;
                        netTcpBinding.MaxReceivedMessageSize = 2147483647;
                        netTcpBinding.ReaderQuotas.MaxArrayLength = 2147483647;
                        netTcpBinding.Security.Mode = SecurityMode.None;
                        return netTcpBinding;
                    default:
                        basicHttpBinding = new System.ServiceModel.BasicHttpBinding();
                        basicHttpBinding.MaxBufferPoolSize = 2147483647;
                        basicHttpBinding.MaxReceivedMessageSize = 2147483647;
                        basicHttpBinding.ReaderQuotas.MaxArrayLength = 2147483647;
                        basicHttpBinding.ReaderQuotas.MaxDepth = 32;
                        basicHttpBinding.ReaderQuotas.MaxBytesPerRead = 2147483647;
                        basicHttpBinding.ReaderQuotas.MaxStringContentLength = 2147483647;
                        basicHttpBinding.ReceiveTimeout = new TimeSpan(0, 10, 0);
                        basicHttpBinding.UseDefaultWebProxy = false;
                        //目前以：1分钟测试WCF传输性能,以后放开  --＞　放开到10分钟
                        basicHttpBinding.SendTimeout = new TimeSpan(0, 10, 0);
                        return basicHttpBinding;
                }
            }
        }
        #endregion

        #region WCF终结点SVC_基类
        /// <summary>
        /// WCF终结点SVC_基类
        /// </summary>
        /// <param name="proxyName"></param>
        /// <returns></returns>
        public static System.ServiceModel.EndpointAddress CommEndpointAddress(string proxyName)
        {
            return EndpointAddress(proxyName, string.Empty);
        }
        #endregion

        #region WCF终结点SVC_电子病历
        /// <summary>
        /// WCF终结点SVC_电子病历
        /// </summary>
        /// <param name="proxyName"></param>
        /// <returns></returns>
        public static System.ServiceModel.EndpointAddress EmrEndpointAddress(string proxyName)
        {
            return EndpointAddress(proxyName, "emr");
        }
        #endregion

        #region WCF终结点SVC_HIS
        /// <summary>
        /// WCF终结点SVC_HIS
        /// </summary>
        /// <param name="proxyName"></param>
        /// <returns></returns>
        public static System.ServiceModel.EndpointAddress HisEndpointAddress(string proxyName)
        {
            return EndpointAddress(proxyName, "his");
        }
        #endregion

        #region WCF终结点SVC_LIS
        /// <summary>
        /// WCF终结点SVC_LIS
        /// </summary>
        /// <param name="proxyName"></param>
        /// <returns></returns>
        public static System.ServiceModel.EndpointAddress LisEndpointAddress(string proxyName)
        {
            return EndpointAddress(proxyName, "lis");
        }
        #endregion

        #region WCF终结点SVC_HD(血透)
        /// <summary>
        /// WCF终结点SVC_HD(血透)
        /// </summary>
        /// <param name="proxyName"></param>
        /// <returns></returns>
        public static System.ServiceModel.EndpointAddress HdEndpointAddress(string proxyName)
        {
            return EndpointAddress(proxyName, "hd");
        }
        #endregion

        #region WCF终结点SVC_PH(病理)
        /// <summary>
        /// WCF终结点SVC_PH(病理)
        /// </summary>
        /// <param name="proxyName"></param>
        /// <returns></returns>
        public static System.ServiceModel.EndpointAddress PhEndpointAddress(string proxyName)
        {
            return EndpointAddress(proxyName, "ph");
        }
        #endregion

        #region 获取终结点
        /// <summary>
        /// 获取终结点
        /// </summary>
        /// <param name="p_strProxyName"></param>
        /// <returns></returns>
        private static System.ServiceModel.EndpointAddress EndpointAddress(string proxyName, string bizTypeName)
        {
            string strAddr = null;
            EndpointAddress objAddr = null;
            try
            {
                if (MiddleServers == null || MiddleServers.Count == 0)
                {
                    //MiddleServers.Add(DefaultMidderSvr());
                    WcfEndpoint.GetMiddleServers();
                }
                // 地址                
                strAddr = Function.LocalSettingValue("Service", bizTypeName, proxyName);

                // 基类服务
                if (string.IsNullOrEmpty(strAddr))
                {
                    if (proxyName.Equals("ProxyUpdate"))    // 自动更新服务
                    {
                        strAddr = @"wcf.console/update.svc";
                        objAddr = new EndpointAddress(new Uri(Function.GetUpdateXmlValue("wcfAddress") + strAddr));
                    }
                    else
                    {
                        if (proxyName.Equals("ProxyLogin"))
                        {
                            strAddr = @"wcf.console/login.svc";
                        }
                        else if (proxyName.Equals("ProxyCommon"))
                        {
                            strAddr = @"wcf.comm/common.svc";
                        }
                        else if (proxyName.Equals("ProxyEntityFactory"))
                        {
                            strAddr = @"wcf.comm/entityfactory.svc";
                        }
                        objAddr = new EndpointAddress(new Uri(MiddleServers[0] + strAddr));
                        GlobalAppConfig.MidderServerIP = MiddleServers[0];
                    }
                }
                else
                {
                    objAddr = new EndpointAddress(new Uri(MiddleServers[0] + strAddr));
                    GlobalAppConfig.MidderServerIP = MiddleServers[0];
                }
            }
            catch
            {
            }
            finally
            {
                strAddr = null;
            }
            return objAddr;
        }
        #endregion

        #region HisEndpointAddress
        /// <summary>
        /// HisEndpointAddress
        /// </summary>
        /// <param name="ipAddr"></param>
        /// <param name="proxyName"></param>
        /// <returns></returns>
        public static System.ServiceModel.EndpointAddress HisEndpointAddress(string ipAddr, string proxyName)
        {
            return new EndpointAddress(new Uri(ipAddr + Function.LocalSettingValue("Service", "his", proxyName)));
        }
        #endregion

        #region ChannelFactory
        /// <summary>
        /// Fac
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ChannelFactory<T> Fac<T>() where T : IWcf
        {
            ChannelFactory<T> fac = new ChannelFactory<T>(WcfEndpoint.Binding);
            WcfEndpoint.SetClientBehavior(fac);
            return fac;
        }
        #endregion

        #region SetClientBehavior
        /// <summary>
        /// SetClientBehavior
        /// </summary>
        /// <param name="fac"></param>
        private static void SetClientBehavior(ChannelFactory fac)
        {
            if (fac != null)
            {
                foreach (OperationDescription op in fac.Endpoint.Contract.Operations)
                {
                    DataContractSerializerOperationBehavior item = op.Behaviors.Find<DataContractSerializerOperationBehavior>() as DataContractSerializerOperationBehavior;
                    if (item == null)
                    {
                        item = new DataContractSerializerOperationBehavior(op);
                        item.MaxItemsInObjectGraph = 2147483647;
                        op.Behaviors.Add(item);
                    }
                    else
                    {
                        item.MaxItemsInObjectGraph = 2147483647;
                    }
                }
            }
        }

        #endregion
    }
}
