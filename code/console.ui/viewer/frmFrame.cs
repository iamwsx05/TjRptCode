using Common.Controls;
using Common.Entity;
using Common.Utils;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Console.Ui
{
    /// <summary>
    /// frame
    /// </summary>
    public partial class frmFrame : frmBase
    {
        #region constr
        /// <summary>
        /// constr
        /// </summary>
        public frmFrame()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.AutoScaleMode = AutoScaleMode.None;
        }
        #endregion

        #region Override
        /// <summary>
        /// CreateController
        /// </summary>
        protected override void CreateController()
        {
            base.CreateController();
            Controller = new ctlFrame();
            Controller.SetUI(this);
        }

        #region PauseRedraw/StartRedraw
        /// <summary>
        /// PauseRedraw
        /// </summary>
        public override void PauseRedraw()
        {
            ((ctlFrame)Controller).PauseRedraw();
        }
        /// <summary>
        /// StartRedraw
        /// </summary>
        public override void StartRedraw()
        {
            ((ctlFrame)Controller).StartRedraw();
        }
        #endregion

        #endregion

        #region 方法

        #region ResetToolBar
        /// <summary>
        /// ResetToolBar
        /// </summary>
        public void ResetToolBar(string className, bool isLoad)
        {
            ((ctlFrame)Controller).ResetToolBar(className, isLoad);
        }

        /// <summary>
        /// ResetToolBarUc
        /// </summary>
        /// <param name="ucName"></param>
        public void ResetToolBarUc(string ucName)
        {
            ((ctlFrame)Controller).ResetToolBar(ucName);
        }

        /// <summary>
        /// GetFuncButton
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public List<EntitySysModule> GetFuncButton(string className)
        {
            return ((ctlFrame)Controller).GetFuncButton(className);
        }
        #endregion

        #region 反射入口
        /// <summary>
        /// 反射入口
        /// </summary>
        /// <param name="vo"></param>
        public void ReflectionByAccVo(EntityAccount vo)
        {
            ((ctlFrame)Controller).LoadForm(vo);
        }
        /// <summary>
        /// 反射入口
        /// </summary>
        /// <param name="request"></param>
        public void ReflectionAccess(string request)
        {
            try
            {
                uiHelper.BeginLoading(this);
                Dictionary<string, string> dicKey = Function.ReadXmlNodes(request, "request");
                string strPath = Application.StartupPath + "\\" + dicKey["fileName"].Trim();
                string className = dicKey["className"].Trim();
                if (className.IndexOf("|") > 0) className = className.Substring(0, className.IndexOf("|"));
                Assembly objAsm = Assembly.LoadFrom(strPath);
                object obj = objAsm.CreateInstance(className, true);
                Type objType = obj.GetType();
                MethodInfo objMth;
                string operName = dicKey["operName"];

                int n = 0;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmBaseMdi)
                    {
                        n++;
                    }
                }
                if (n >= 10)
                {
                    DialogBox.Msg("界面设定为最多打开10个，请关闭暂时不需要的界面。", MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(operName)) operName = "Show";
                string strMethod = operName;
                object[] objParams = null;
                int intIndex = strMethod.IndexOf("(");
                if (intIndex != -1) //带参
                {
                    string strParam = strMethod.Substring(intIndex + 1, strMethod.Length - intIndex - 2);
                    objParams = strParam.Split(',');
                    strMethod = strMethod.Substring(0, intIndex);
                    objMth = objType.GetMethod(strMethod);
                }
                else
                {
                    objMth = objType.GetMethod(operName, new Type[0]);
                }
                if (objMth == null)
                {
                    DialogBox.Msg("自动创建模块失败。", MessageBoxIcon.Exclamation, this);
                }
                if (obj is Form)
                {
                    if (!((ctlFrame)Controller).FormExisted(obj.GetType(), operName))
                    {
                        ((ctlFrame)Controller).GetFormFuncButton(className);
                        ((Form)obj).AccessibleName = className;
                        ((Form)obj).AccessibleDescription = dicKey["funcName"];
                        ((ctlFrame)Controller).MakeMdiForm(obj, operName);
                        objMth.Invoke(obj, objParams);
                    }
                }
            }
            catch (Exception ex)
            {
                DialogBox.Msg(ex.Message);
            }
            finally
            {
                uiHelper.CloseLoading(this);
            }
        }
        #endregion

        #endregion

        #region 事件

        private void frmFrame_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            ((ctlFrame)Controller).Init();
        }

        private void frmFrame_Layout(object sender, LayoutEventArgs e)
        {
            ((ctlFrame)Controller).SetCaption(0);
        }

        private void frmFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((ctlFrame)Controller).Halt(e);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            ((ctlFrame)Controller).Halt(null);
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            ((ctlFrame)Controller).SetCaption(1);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ((ctlFrame)Controller).LoadDefaultModule();
        }

        private void bbiNavi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ((ctlFrame)Controller).Navigation();
        }

        private void bbiChangePwd_ItemClick(object sender, ItemClickEventArgs e)
        {
            ((ctlFrame)Controller).ChangePwd();
        }

        private void bbiLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            ((ctlFrame)Controller).Logout();
        }

        private void bbiHalt_ItemClick(object sender, ItemClickEventArgs e)
        {
            ((ctlFrame)Controller).Halt(null);
        }

        private void ribbonControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (((ctlFrame)Controller).isMaximized)
            {
                weCare.Core.Utils.Function.SendMessage(this.Handle);
            }
        }

        private void bsiLoginer_ItemClick(object sender, ItemClickEventArgs e)
        {
            ((ctlFrame)Controller).ChangePwd();
        }

        private void timerExternal_Tick(object sender, EventArgs e)
        {
            this.timerExternal.Enabled = false;
            this.TopMost = false;
        }

        #region DefWndProc

        /// <summary>
        /// WM_COPYDATA
        /// </summary>
        const int WM_COPYDATA = 0x004A;

        /// <summary>
        /// DefWndProc
        /// </summary>
        /// <param name="m"></param>
        //protected override void DefWndProc(ref System.Windows.Forms.Message m)
        //{
        //try
        //{
        //    switch (m.Msg)
        //    {
        //        case 0x004A:    // 处理消息    
        //            {
        //                COPYDATASTRUCT funcCode = new COPYDATASTRUCT();
        //                Type mytype = funcCode.GetType();
        //                funcCode = (COPYDATASTRUCT)m.GetLParam(mytype);
        //                string[] parm = funcCode.lpData.Split(new string[] { "-->" }, StringSplitOptions.None);
        //                this.ExternalWinName = parm[0];
        //                if (parm[1] == "start")
        //                {
        //                    this.IsInit = false;
        //                    if (this.WindowState == FormWindowState.Minimized)
        //                        ((ctlFrame)Controller).SetCaption(1);
        //                    else
        //                        ((ctlFrame)Controller).SetCaption(0);
        //                    if (parm.Length > 2)
        //                    {
        //                        string acctStr = parm[2];
        //                        if (acctStr.IndexOf("|") > 0) acctStr = acctStr.Replace("|", "&");
        //                        EntityAccount accVo = new EntityAccount();
        //                        accVo.FuncCode = acctStr.Split('&')[0];
        //                        accVo.FuncName = acctStr.Split('&')[1];
        //                        accVo.FuncFile = acctStr.Split('&')[2];
        //                        accVo.OperName = acctStr.Split('&')[3];
        //                        ((ctlFrame)Controller).LoadForm(accVo);
        //                    }
        //                }
        //                else if (parm[1] == "end")
        //                {
        //                    this.IsExternalExit = true;
        //                    ((ctlFrame)Controller).Halt(null);
        //                }
        //            }
        //            break;
        //        default:
        //            base.DefWndProc(ref m); // 调用基类函数处理非自定义消息。 
        //            break;
        //    }
        //}
        //catch (Exception ex)
        //{
        //    GC.SuppressFinalize(this);
        //    DialogBox.Msg(ex.Message);
        //}
        //}
        #endregion

        private void bbiColorMixer_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.XtraEditors.ColorWheel.ColorWheelForm frm = new DevExpress.XtraEditors.ColorWheel.ColorWheelForm();
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            if (frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                Color clr = this.defaultLookAndFeel.LookAndFeel.SkinMaskColor;
                if (clr.A == 0 && clr.R == 0 && clr.G == 0 && clr.B == 0)
                {
                    GlobalLogin.SkinMaskColorValue = "";
                }
                else
                {
                    GlobalLogin.SkinMaskColorValue = clr.Name + "|" + clr.A.ToString() + "|" + clr.R.ToString() + "|" + clr.G.ToString() + "|" + clr.B.ToString();
                }
                Function.SetLocalSettingValue("Main|skinMaskColor", "value", GlobalLogin.SkinMaskColorValue);

                Color clr2 = this.defaultLookAndFeel.LookAndFeel.SkinMaskColor2;
                if (clr2.A == 0 && clr2.R == 0 && clr2.G == 0 && clr2.B == 0)
                {
                    GlobalLogin.SkinMaskColorValue2 = "";
                }
                else
                {
                    GlobalLogin.SkinMaskColorValue2 = clr2.Name + "|" + clr2.A.ToString() + "|" + clr2.R.ToString() + "|" + clr2.G.ToString() + "|" + clr2.B.ToString();
                }
                Function.SetLocalSettingValue("Main|skinMaskColor2", "value", GlobalLogin.SkinMaskColorValue2);
            }
        }

        #endregion
                
    }
}
