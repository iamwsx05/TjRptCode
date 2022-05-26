using Common.Controls;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTabbedMdi;
using NavbarWinTest;
using RptFunc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace rtpFunc
{
    public partial class frmMain : frmBase
    {
        public frmMain()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Normal;
            this.AutoScaleMode = AutoScaleMode.None;
        }

        Dictionary<WNavbarGroupItem, string> dicFunc = null;

        internal void Init()
        {
            GlobalAppConfig.RunningMode = Function.Int(this.Tag);
            GlobalAppConfig.AppConfig = GetAppConfig(string.Empty);
            dicFunc = new Dictionary<WNavbarGroupItem, string>();
            var bgc = Color.FromArgb(40, 39, 51);//主背景
            var frc = Color.FromArgb(141, 142, 161);//主前景
            var gexc = Color.FromArgb(47, 46, 60);//组展开背景
            var gcfc = Color.FromArgb(255, 255, 255);//组展开前景 
            var pathFormat = Application.StartupPath + "\\images\\{0}.png";//可以准备两套图标,正常和鼠标滑过

            this.wNavbar1.Items.Clear();
            this.wNavbar1.BackColor = bgc;
            this.wNavbar1.ForeColor = frc;
            this.wNavbar1.CaptionShow = true;//隐藏标题,滚动条未重写颜色不搭.
            wNavbar1.CaptionImage = Image.FromFile(string.Format(pathFormat, "m"));
            wNavbar1.GroupItemClick += new System.EventHandler(this.wNavbar1_GroupItemClick);

            #region 赤坎妇幼

            //WNavbarGroup
            WNavbarGroup navGpZkfy = new WNavbarGroup
            {
                BackColor = bgc,
                ExpandColor = gexc,
                ForeColor = frc,
                MouseOverColor = gexc,
                MouseOverForeColor = gcfc,
                Text = "赤坎妇幼",
                Image = Image.FromFile(string.Format(pathFormat, 3))
            };

            WNavbarGroupItem itemZkfyFun = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,
                
                Text = "功能"
            };

            WNavbarGroupItem itemZkfyReport = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,
                Text = "报表"
            };
            navGpZkfy.Items.AddRange(new WNavbarGroupItem[] { itemZkfyFun, itemZkfyReport });
            #endregion

            #region 信宜人医
            //WNavbarGroup
            WNavbarGroup navGpXy = new WNavbarGroup
            {
                BackColor = bgc,
                ExpandColor = gexc,
                ForeColor = frc,
                MouseOverColor = gexc,
                MouseOverForeColor = gcfc,
                Text = "信宜人医",
                Image = Image.FromFile(string.Format(pathFormat, 3))
            };

            WNavbarGroupItem itemXyFun = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,

                Text = "功能"
            };

            WNavbarGroupItem itemXyReport = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,
                Text = "报表"
            };
            navGpXy.Items.AddRange(new WNavbarGroupItem[] { itemXyFun, itemXyReport });
            #endregion

            #region 大良医院
            WNavbarGroup navGpDlyy = new WNavbarGroup
            {
                BackColor = bgc,
                ExpandColor = gexc,
                ForeColor = frc,
                MouseOverColor = gexc,
                MouseOverForeColor = gcfc,
                Text = "大良医院",
                Image = Image.FromFile(string.Format(pathFormat, 3))
            };

            WNavbarGroupItem itemDlyyFun = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,

                Text = "功能"
            };


            navGpDlyy.Items.AddRange(new WNavbarGroupItem[] { itemDlyyFun });
            #endregion

            #region 杏坛医院
            WNavbarGroup navGpXtyy = new WNavbarGroup
            {
                BackColor = bgc,
                ExpandColor = gexc,
                ForeColor = frc,
                MouseOverColor = gexc,
                MouseOverForeColor = gcfc,
                Text = "报表",
                Image = Image.FromFile(string.Format(pathFormat, 3))
            };

            WNavbarGroupItem itemXtyyFun = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,

                Text = "功能"
            };

            WNavbarGroupItem itemXtyyReport = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,
                Text = "体检报表"
            };


            WNavbarGroupItem itemXtyyZybRpt = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,
                Text = "职业病报表"
            };

            navGpXtyy.Items.AddRange(new WNavbarGroupItem[] { itemXtyyFun, itemXtyyReport, itemXtyyZybRpt });
            #endregion

            #region 陈村医院
            WNavbarGroup navGpCcyy = new WNavbarGroup
            {
                BackColor = bgc,
                ExpandColor = gexc,
                ForeColor = frc,
                MouseOverColor = gexc,
                MouseOverForeColor = gcfc,
                Text = "陈村医院",
                Image = Image.FromFile(string.Format(pathFormat, 3))
            };

            WNavbarGroupItem itemCcyyFun = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,

                Text = "功能"
            };


            navGpCcyy.Items.AddRange(new WNavbarGroupItem[] { itemCcyyFun });
            #endregion

            #region 职检数据上传
            //WNavbarGroup
            WNavbarGroup navGpZyb = new WNavbarGroup
            {
                BackColor = bgc,
                ExpandColor = gexc,
                ForeColor = frc,
                MouseOverColor = gexc,
                MouseOverForeColor = gcfc,
                Text = "职检数据上传",
                Image = Image.FromFile(string.Format(pathFormat, 3))
            };

            WNavbarGroupItem itemZybFun = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,

                Text = "功能"
            };

            WNavbarGroupItem itemZybReport = new WNavbarGroupItem
            {
                BackColor = bgc,
                ForeColor = frc,
                SelectedBackColor = gexc,
                SelectedForeColor = gcfc,
                MouseHoverStyle = WNavbarGroupItem.MouseOverStyle.BackColor,
                Text = "报表"
            };
            navGpZyb.Items.AddRange(new WNavbarGroupItem[] { itemZybFun, itemZybReport });
            #endregion

            navGpZkfy.Visible = false;
            navGpXy.Visible = false;
            navGpDlyy.Visible = false;
            navGpXtyy.Visible = true;
            navGpZyb.Visible = false;
            navGpCcyy.Visible = false;
            itemXtyyFun.Visible = false;

            this.wNavbar1.Items.AddRange(new WNavbarGroup[] { navGpZkfy, navGpXy, navGpDlyy, navGpXtyy, navGpCcyy, navGpZyb });
        }

        #region 本地配置
        /// <summary>
        /// 本地配置
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        List<EntityAppConfig> GetAppConfig(string empNo)
        {
            EntityPC pc = new EntityPC();
            pc.MachineName = Function.LocalHostName();
            pc.IpAddr = Function.LocalIP();
            pc.MacAddr = Function.LocalMac();
            pc.EmpNo = empNo;
            //using (ProxyLogin proxy = new ProxyLogin())
            //{
            //    return proxy.Service.GetAppConfig(pc);
            //}
            List<EntityAppConfig> lstAppConfig = new List<EntityAppConfig>();
            EntityAppConfig vo = new EntityAppConfig();
            vo.Module = "His";
            vo.Name = "ProxyRptFunc";
            vo.Node = "Service";
            vo.Value = "wcf.rptFunc/rptFunc.svc";
            lstAppConfig.Add(vo);
            return lstAppConfig;
        }
        #endregion

        #region 反射入口
        /// <summary>
        /// 反射入口
        /// </summary>
        /// <param name="vo"></param>
        public void ReflectionByAccVo(WNavbarGroupItem gItem, string strFormName)
        {
            Form frm = GetForm(strFormName);

            frm.MdiParent = this;
            // 子窗体的 Text  就是 Tab页中的标题 ,我这里是直接取 navItem中的标题作为 tab页的标题
            frm.Text = gItem.Text;
            // 显示 
            frm.Show();
            // 设置当前 tab页的 图标,我这里也默认取navBar中的Item中的图标
            xtraTabbedMdiManager.Pages[0].Image = gItem.Image;

        }

        public void ReflectionByAccVo2(WNavbarGroupItem gItem, string strFormName)
        {
            LoadForm(strFormName);
        }
        #endregion

        private void wNavbar1_GroupItemClick(object sender, EventArgs e)
        {
            WNavbarGroupItem gItem = sender as WNavbarGroupItem;

            if (gItem.Parent.Text == "赤坎妇幼")
            {
                ReflectionByAccVo2(gItem, "frmZKFY");
            }

            if (gItem.Parent.Text == "信宜人医")
            {
                ReflectionByAccVo2(gItem, "frmXiyi");
            }

            if (gItem.Parent.Text == "大良医院")
            {
                ReflectionByAccVo2(gItem, "frmDLYY");
            }

            if (gItem.Parent.Text == "报表")
            {
                if(gItem.Text == "体检报表")
                    ReflectionByAccVo2(gItem, "frmXtyyRpt");
                else if(gItem.Text == "账务报表")
                    ReflectionByAccVo2(gItem, "frmXtyySfyRpt");
                else if(gItem.Text == "职业病报表")
                    ReflectionByAccVo2(gItem, "frmXtyyZybRpt"); 
            }

            if (gItem.Parent.Text == "职检数据上传")
            {
                ReflectionByAccVo2(gItem, "frmNhpk");
            }

            if (gItem.Parent.Text == "陈村医院")
            {
                ReflectionByAccVo2(gItem, "frmCCYY");
            }
        }


        private Form GetForm(string strFormName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetTypes().Where(item => item.Name.Equals(strFormName)).FirstOrDefault();

            Form frm = assembly.CreateInstance(type.FullName) as Form;
            frm.Name = strFormName;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            return frm;
        }

        internal void LoadForm(string strFormName)
        {
            //Control.ControlCollection ctrls = ribbonControl.Controls;
            //if (ctrls.ContainsKey(strFormName))
            //{
            //    return ctrls[strFormName] as Form;
            //}


            MethodInfo objMth;
            object[] objParams = null;

            //string strPath = Application.StartupPath + "\\" + vo.FuncFile.Trim();
            //string className = vo.FuncCode.Trim();
            //if (className.IndexOf("|") > 0) className = className.Substring(0, className.IndexOf("|"));
            //Assembly objAsm = Assembly.LoadFrom(strPath);
            //object obj = objAsm.CreateInstance(className, true)

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type objType = assembly.GetTypes().Where(item => item.Name.Equals(strFormName)).FirstOrDefault();
            object obj = assembly.CreateInstance(objType.FullName, true);
            objMth = objType.GetMethod("Show", new Type[0]);

            ((Form)obj).AccessibleName = strFormName;
            ((Form)obj).AccessibleDescription = strFormName;
            MakeMdiForm(obj, "Show");
            objMth.Invoke(obj, objParams);
        }

        internal void MakeMdiForm(object obj, string operName)
        {
            Form frm = obj as Form;
            Type objType = obj.GetType();

            if (operName.ToLower() == "showdialog")
            {
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                frm.MdiParent = this;
            }
        }


        private DateTime m_LastClick = System.DateTime.Now;
        private XtraMdiTabPage m_lastPage = null;
        private void xtraTabbedMdiManager1_MouseDown(object sender, MouseEventArgs e)
        {
            XtraMdiTabPage curPage = (sender as XtraTabbedMdiManager).SelectedPage;

            if (e.Button == MouseButtons.Left)
            { 

                DateTime dt = DateTime.Now;
                TimeSpan span = dt.Subtract(m_LastClick);
                if (span.TotalMilliseconds < 300)  //如果两次点击的时间间隔小于300毫秒，则认为是双击
                {
                    if (this.MdiChildren.Length > 1)
                    {

                        // 限制只有在同一个页签上双击才能关闭.(规避两个页签切换时点太快导致意外关闭页签)
                        if (curPage.Equals(m_lastPage))
                        {
                            //if (this.ActiveMdiChild != m_MapForm)
                            //{
                            this.ActiveMdiChild.Close();
                            //}

                        }
                    }
                    m_LastClick = dt.AddMinutes(-1);
                }
                else
                {
                    m_LastClick = dt;
                    m_lastPage = curPage;
                }
            }
        }

        private void ribbonControl1_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            RibbonControl parentRRibbon = sender as RibbonControl;
            RibbonControl childRibbon = e.MergedChild;
            parentRRibbon.StatusBar.MergeStatusBar(childRibbon.StatusBar);
        }

        private void ribbonControl1_UnMerge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            RibbonControl parentRRibbon = sender as RibbonControl;
            parentRRibbon.StatusBar.UnMergeStatusBar();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
