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
    /// 科室字典
    /// </summary>
    public partial class frmDepartment : frmBaseMdi
    {
        #region 构造
        /// <summary>
        /// 构造
        /// </summary>
        public frmDepartment()
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
            Controller = new ctlDepartment();
            Controller.SetUI(this);
        }
        #endregion

        #region PauseRedraw/StartRedraw
        /// <summary>
        /// PauseRedraw
        /// </summary>
        public override void PauseRedraw()
        {
            ((ctlDepartment)Controller).PauseRedraw();
        }
        /// <summary>
        /// StartRedraw
        /// </summary>
        public override void StartRedraw()
        {
            ((ctlDepartment)Controller).StartRedraw();
        }
        #endregion

        #region New
        /// <summary>
        /// New
        /// </summary>
        public override void New()
        {
            ((ctlDepartment)Controller).New();
        }
        #endregion

        #region Del
        /// <summary>
        /// Del
        /// </summary>
        public override void Delete()
        {
            ((ctlDepartment)Controller).Del();
        }
        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        public override void Save()
        {
            ((ctlDepartment)Controller).Save(false);
        }
        #endregion

        #region Refresh
        /// <summary>
        /// Refresh
        /// </summary>
        public override void RefreshData()
        {
            ((ctlDepartment)Controller).Refresh();
        }
        #endregion

        #endregion

        #region 窗体事件

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            ((ctlDepartment)Controller).Init();
        }

        private void frmDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.gvRoom.CloseEditor();
            this.gvExpert.CloseEditor();
            if (this.ValueChanged)
            {
                DialogResult res = DialogBox.Msg("是否保存数据？", MessageBoxIcon.Question, true);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    ((ctlDepartment)Controller).Save(true);
                }
                else if (res == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.isCancelExit = true;
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            ((ctlDepartment)Controller).NewRowRoom();
        }

        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            ((ctlDepartment)Controller).DelRowRoom();
        }

        private void btnAddExpert_Click(object sender, EventArgs e)
        {
            ((ctlDepartment)Controller).NewRowExpert();
        }

        private void btnDelExpert_Click(object sender, EventArgs e)
        {
            ((ctlDepartment)Controller).DelRowExpert();
        }
        
        #endregion

    }
}
