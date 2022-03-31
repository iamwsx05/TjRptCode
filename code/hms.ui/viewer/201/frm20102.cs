using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frm20102 : frmBaseMdi
    {
        public frm20102()
        {
            InitializeComponent();
        }
        #region var/property
        List<EntityUserGrade> lstUserGrades { get; set; }
        #endregion

        #region 
        public override void Search()
        {
            string name = this.txtName.Text;

            if (!string.IsNullOrEmpty(name))
            {
                this.gridControl.DataSource = this.lstUserGrades.FindAll(r => r.gradeName.Contains(name));
            }
            else
            {
                this.gridControl.DataSource = this.lstUserGrades;
            }
            this.gridControl.RefreshDataSource();
        }
        #endregion

        #region methods

        #region Init
        internal void Init()
        {
            try
            {
                uiHelper.BeginLoading(this);
                RefreshData();
            }
            finally
            {
                uiHelper.CloseLoading(this);
            }
        }
        #endregion

        #region RefreshData
        /// <summary>
        /// RefreshData
        /// </summary>
        public override void RefreshData()
        {
            uiHelper.BeginLoading(this);
            this.LoadQnDataSource();
            this.gridControl.DataSource = this.lstUserGrades;
            this.gridControl.RefreshDataSource();
            uiHelper.CloseLoading(this);
        }
        #endregion


        #region LoadQnDataSource
        /// <summary>
        /// LoadQnDataSource
        /// </summary>
        void LoadQnDataSource()
        {
            lstUserGrades = null;
            using (ProxyHms proxy = new ProxyHms())
            {
                lstUserGrades = proxy.Service.GetUserGrades();
            }
        }
        #endregion

        #endregion

        #region events
        private void frm20102_Load(object sender, EventArgs e)
        {
            using (ProxyHms proxy = new ProxyHms())
            {
                Init();
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
        #endregion

        
    }
}
