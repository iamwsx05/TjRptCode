using Common.Controls;
using Common.Entity;
using DevExpress.XtraBars;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Console.Ui
{
    /// <summary>
    /// 报表管理
    /// </summary>
    public partial class frmReport : frmBaseMdi
    {
        #region 构造
        /// <summary>
        /// 构造
        /// </summary>
        public frmReport()
        {
            InitializeComponent();
        }
        #endregion

        #region Override

        #region CreateController
        /// <summary>
        /// CreateController
        /// </summary>
        protected override void CreateController()
        {
            base.CreateController();
            Controller = new ctlReport();
            Controller.SetUI(this);
        }
        #endregion

        #region New
        /// <summary>
        /// New
        /// </summary>
        public override void New()
        {
            ((ctlReport)Controller).New();
        }
        #endregion

        #region Del
        /// <summary>
        /// Del
        /// </summary>
        public override void Delete()
        {
            ((ctlReport)Controller).Delete();
        }
        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        public override void Save()
        {
            ((ctlReport)Controller).Save();
        }
        #endregion

        #region Design
        /// <summary>
        /// Design
        /// </summary>
        public override void Design()
        {
            ((ctlReport)Controller).Design();
        }
        #endregion

        #region Refresh
        /// <summary>
        /// Refresh
        /// </summary>
        public override void RefreshData()
        {
            ((ctlReport)Controller).Refresh();
        }
        #endregion

        #endregion

        #region 事件

        private void frmReport_Load(object sender, EventArgs e)
        {
            ((ctlReport)Controller).Init();
        }

        private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ValueChanged)
            {
                DialogResult res = DialogBox.Msg("是否保存数据？", MessageBoxIcon.Question, true);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    if (((ctlReport)Controller).Save() == false)
                    {
                        this.isCancelExit = true;
                        e.Cancel = true;
                        return;
                    }
                }
                else if (res == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.isCancelExit = true;
                    e.Cancel = true;
                    return;
                }
            }
        }

        #endregion

    }
}
