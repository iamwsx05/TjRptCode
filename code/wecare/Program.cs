using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace weCare
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // 是否重新登录
            bool isRelogin = false;
            if (args != null && args.Length == 1)
            {
                isRelogin = args[0].ToLower() == "relogin" ? true : false; 
            }
            if (isRelogin || ProcessNums() == 0)
            {
                string fileDll = string.Empty;
                Assembly objAsm = null;
                Type objType = null;
                Object objFrm = null;
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    // 自动更新.三层.wcf
                    ToolUpdate autoUpdate = new ToolUpdate();
                    if (!autoUpdate.DownLoad())
                    {
                        return;
                    }
                    autoUpdate = null;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Application.Exit();
                } 
                try
                {
                    // 运行模式
                    int intRunningMode = Tool.Int(Tool.ReadLocalSettingValue("Main|runningMode", "value"));
                    // 注册皮肤,用于某些DEV控件在表单书写时的视觉样式
                    DevExpress.UserSkins.BonusSkins.Register();
                    DevExpress.Skins.SkinManager.EnableFormSkins();
                    //fileDll = Application.StartupPath + "\\console.ui.dll";
                    fileDll = Application.StartupPath + "\\rptFunc.dll";

                    objAsm = Assembly.LoadFrom(fileDll);
                    objType = objAsm.GetType("rtpFunc.frmMain");
                    objFrm = objType.InvokeMember(null, System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.CreateInstance, null, null, null);
                    Form frm = objFrm as Form;
                    ((Form)frm).Tag = (intRunningMode < 2 ? 2 : intRunningMode);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        // 1 资料登记; 2 护士站; 3 医生站; 4 费用结算; 5 药房药库; 6 数据中心; 8 客服随访(院后随访); 9 健康管理; 12 病理; 15 健康管理;
                        string strSysModule = frm.Tag.ToString();
                        objType = objAsm.GetType("rtpFunc.frmMain");
                        objFrm = objType.InvokeMember(null, System.Reflection.BindingFlags.DeclaredOnly | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.CreateInstance, null, null, null);
                        (objFrm as Form).Tag = strSysModule;
                        Application.Run(objFrm as Form);
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Application.Exit();
                }
                finally
                {
                    objAsm = null;
                    objType = null;
                    objFrm = null;
                }
            }
            else
            {
                MessageBox.Show("rptFunc.exe 已经在运行...", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region ProcessNums
        /// <summary>
        /// ProcessNums
        /// </summary>
        /// <returns></returns>
        public static int ProcessNums()
        {
            int count = 0;
            System.Diagnostics.Process current = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process process in processes)
            {
                if (process.Id != current.Id && process.ProcessName == current.ProcessName) // 查找相同名称的进程.忽略当前进程 
                {
                    count++;
                }
            }
            return count;
        }
        #endregion

        #region ReadXmlNodes
        /// <summary>
        /// 读取XML片段
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ReadXmlNodes(string xml, string nodeName)
        {
            Dictionary<string, string> dicVal = new Dictionary<string, string>();
            try
            {
                System.Xml.XmlDocument document = new System.Xml.XmlDocument();
                document.LoadXml(xml);
                System.Xml.XmlElement element = document[nodeName];
                document = null;
                if (element != null)
                {
                    foreach (System.Xml.XmlNode node in element.ChildNodes)
                    {
                        if (!dicVal.ContainsKey(node.Name))
                        {
                            dicVal.Add(node.Name, node.InnerText);
                        }
                    }
                }
            }
            catch { }
            return dicVal;
        }
        #endregion

    }
}
