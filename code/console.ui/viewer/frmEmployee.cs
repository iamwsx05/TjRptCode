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
    /// 职工字典
    /// </summary>
    public partial class frmEmployee : frmBaseMdi
    {
        #region 构造
        /// <summary>
        /// 构造
        /// </summary>
        public frmEmployee()
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
            Controller = new ctlEmployee();
            Controller.SetUI(this);
        }
        #endregion

        #region New
        /// <summary>
        /// New
        /// </summary>
        public override void New()
        {
            ((ctlEmployee)Controller).New();
        }
        #endregion

        #region Del
        /// <summary>
        /// Del
        /// </summary>
        public override void Delete()
        {
            ((ctlEmployee)Controller).Del();
        }
        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        public override void Save()
        {
            ((ctlEmployee)Controller).Save(false);
        }
        #endregion

        #region Refresh
        /// <summary>
        /// Refresh
        /// </summary>
        public override void RefreshData()
        {
            this.colDeptName.Visible = true;
            ((ctlEmployee)Controller).Refresh();
        }
        #endregion

        #endregion

        #region 窗体事件

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            ((ctlEmployee)Controller).Init();
        }

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ValueChanged)
            {
                DialogResult res = DialogBox.Msg("是否保存数据？", MessageBoxIcon.Question, true);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    ((ctlEmployee)Controller).Save(true);
                }
                else if (res == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.isCancelExit = true;
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void gvEmployee_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ((ctlEmployee)Controller).LoadPlus(e.FocusedRowHandle);
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((ctlEmployee)Controller).FindEmp(this.txtFind.Text.Trim());
            }
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            ((ctlEmployee)Controller).NewOperDept();
        }

        private void btnDelDept_Click(object sender, EventArgs e)
        {
            ((ctlEmployee)Controller).DelOperDept();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            ((ctlEmployee)Controller).NewOperRole();
        }

        private void btnDelRole_Click(object sender, EventArgs e)
        {
            ((ctlEmployee)Controller).DelOperRole();
        }

        private void btnDefaultDept_Click(object sender, EventArgs e)
        {
            ((ctlEmployee)Controller).SetDefaultDept();
        }

        private void gvDept_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ((ctlEmployee)Controller).RowCellStyleDept(e);
        }

        #endregion
        
    }
}
