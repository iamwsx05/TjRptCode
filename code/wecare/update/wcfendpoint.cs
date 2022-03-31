using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.EnterpriseServices;

namespace weCare
{
    /// <summary>
    /// WCF终结点
    /// </summary>
    public class WCFEndpoint
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
                        strBinding = Tool.ReadLocalSettingValue("Main|wcfBinding", "value");
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
                        //目前以：1分钟测试WCF传输性能,以后放开
                        //basicHttpBinding.SendTimeout = new TimeSpan(0, 10, 0); 
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
                        //目前以：1分钟测试WCF传输性能,以后放开
                        //basicHttpBinding.SendTimeout = new TimeSpan(0, 10, 0);
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

        #region 获取终结点
        /// <summary>
        /// 获取终结点
        /// </summary>
        /// <param name="p_strProxyName"></param>
        /// <returns></returns>
        private static System.ServiceModel.EndpointAddress EndpointAddress(string proxyName, string bizTypeName)
        {
            string strAddr = @"wcf.console/update.svc";
            EndpointAddress objAddr = new EndpointAddress(new Uri(Tool.GetUpdateXmlValue("wcfAddress") + strAddr));
            return objAddr;
        }
        #endregion

        #region ChannelFactory
        /// <summary>
        /// Fac
        /// </summary>
        /// <returns></returns>
        public static ChannelFactory<ISvcUpdate> Fac<ISvcUpdate>()
        {
            ChannelFactory<ISvcUpdate> fac = new ChannelFactory<ISvcUpdate>(WCFEndpoint.Binding);
            WCFEndpoint.SetClientBehavior(fac);
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
