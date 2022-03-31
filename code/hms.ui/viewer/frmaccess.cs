using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hms.Ui
{
    /// <summary>
    /// Access
    /// </summary>
    public partial class frmAccess : frmBaseMdi
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frmAccess()
        {
            InitializeComponent();
        }
        #endregion

        #region Method

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        void Init()
        {
            List<string> lst01 = new List<string>() { "客户管理", "我的客户", "类别管理", "家庭管理", "单位管理", "人员管理" };
            List<string> lst02 = new List<string>() { "健康档案", "体检报告", "常规问卷", "单项检查", "就医记录", "用药记录", "健康检测", "其他问卷" };
            List<string> lst03 = new List<string>() { "健康报告", "个人报告", "团体报告" };
            List<string> lst04 = new List<string>() { "健康干预", "创建计划", "待执行计划", "干预记录", "短信平台", "网络电话", "在线交流", "视频语音", "审核任务", "短信记录" };
            List<string> lst05 = new List<string>() { "慢病管理", "高血压管理", "糖尿病管理" };
            List<string> lst06 = new List<string>() { "膳食管理", "膳食原则", "膳食方案", "饮食菜谱模板", "成品菜", "原料库", "中医食疗" };
            List<string> lst07 = new List<string>() { "服务预约", "预约管理", "服务详情", "服务维护", "服务套餐" };
            List<string> lst08 = new List<string>() { "体检维护", "体检报告模板", "体检项目库", "体检项目匹配", "异常库", "组合异常", "异常名称匹配" };
            List<string> lst09 = new List<string>() { "问卷维护", "自定义量表设置", "问卷题库", "危险因素库" };
            List<string> lst10 = new List<string>() { "知识库", "运动库", "短信库", "宣教文章库", "干预方案模板", "干预模板", "评估模型设置" };
            List<string> lst11 = new List<string>() { "统计分析", "精确查询", "体检统计", "问卷统计", "工作量统计" };

            int num = 1;
            int initH = 30;
            int height = 0;
            naviPic picObj = null;
            List<string> lstS = null;
            List<Panel> lstPanel = new List<Panel>() { panel01, panel02, panel03, panel04, panel05, panel06, panel07, panel08, panel09, panel10, panel11 };
            foreach (Panel pnl in lstPanel)
            {
                if (num == 1) lstS = lst01;
                else if (num == 2) lstS = lst02;
                else if (num == 3) lstS = lst03;
                else if (num == 4) lstS = lst04;
                else if (num == 5) lstS = lst05;
                else if (num == 6) lstS = lst06;
                else if (num == 7) lstS = lst07;
                else if (num == 8) lstS = lst08;
                else if (num == 9) lstS = lst09;
                else if (num == 10) lstS = lst10;
                else if (num == 11) lstS = lst11;

                height = initH;
                pnl.Width = 200;
                pnl.Dock = DockStyle.Left;
                int no = 0;
                foreach (string picName in lstS)
                {
                    if (no > 0 && GlobalParm.dicSysMenu.ContainsKey(picName) == false)
                    {
                        continue;
                    }
                    picObj = new naviPic();
                    picObj.Location = new System.Drawing.Point(0, height);
                    picObj.PicName = picName;
                    picObj.IsStyle = no > 0 ? true : false;
                    picObj.pic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.naviPic_MouseDoubleClick);
                    pnl.Controls.Add(picObj);
                    height += picObj.Height + initH;
                    ++no;
                }
                num++;

                if (pnl.Controls.Count == 1) pnl.Visible = false;
            }
        }
        #endregion

        #region naviPic_MouseDoubleClick
        /// <summary>
        /// naviPic_MouseDoubleClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void naviPic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string picName = ((sender as DevExpress.XtraEditors.PictureEdit).Parent as naviPic).PicName;
                if (GlobalParm.dicSysMenu.ContainsKey(picName))
                {
                    object[] parm = new object[1];
                    parm[0] = GlobalParm.dicSysMenu[picName];
                    Form frmMain = this.MdiParent;
                    System.Reflection.MethodInfo objMth = frmMain.GetType().GetMethod("ReflectionByAccVo");
                    objMth.Invoke(frmMain, parm);
                }
                else
                {
                    DialogBox.Msg("系统菜单不存在对应标题");
                }
            }
            catch (Exception ex)
            {
                DialogBox.Msg(ex.Message);
            }
        }
        #endregion

        #endregion

        #region Event

        private void frmAccess_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        #endregion


    }
}
