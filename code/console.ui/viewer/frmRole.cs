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
    /// 角色维护
    /// </summary>
    public partial class frmRole : frmBaseMdi
    {
        #region 构造
        /// <summary>
        /// 构造
        /// </summary>
        public frmRole()
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
            Controller = new ctlRole();
            Controller.SetUI(this);
        }
        #endregion
        
        #region Del
        /// <summary>
        /// Del
        /// </summary>
        public override void Delete()
        {
            ((ctlRole)Controller).Del();
        }
        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        public override void Save()
        {
            ((ctlRole)Controller).Save();
        }
        #endregion

        #region Refresh
        /// <summary>
        /// Refresh
        /// </summary>
        public override void RefreshData()
        {
            ((ctlRole)Controller).Refresh();
        }
        #endregion

        #endregion

        #region 窗体事件

        private void frmRole_Load(object sender, EventArgs e)
        {
            ((ctlRole)Controller).Init();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ((ctlRole)Controller).NewRowRole();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ((ctlRole)Controller).DelRowRole();
        }

        private void gvRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ((ctlRole)Controller).LoadRoleOper(e.FocusedRowHandle);
        }

        private void tvFunction_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            ((ctlRole)Controller).CheckNode(e.Node);
        }

        private void gvRole_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ((ctlRole)Controller).CellValueChanged(e.RowHandle);
        }
        #endregion
        
    }
}
