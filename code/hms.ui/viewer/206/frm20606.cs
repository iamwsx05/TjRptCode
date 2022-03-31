using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frm20606 : frmBaseMdi
    {
        public frm20606()
        {
            InitializeComponent();
        }

        #region var/propery
        List<EntityDietTreatment> lstDietTreatment { get; set; }
        #endregion

        #region override
        /// <summary>
        /// 添加
        /// </summary>
        public override void New()
        {
            
        }
        /// <summary>
        /// 查询
        /// </summary>
        public override void Search()
        {
            string name = this.txtName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                gcData.DataSource = this.lstDietTreatment.FindAll(r => r.names.Contains(name));
                this.gcData.RefreshDataSource();
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        public override void Edit()
        {
            //EntityDietTreatment vo = GetRowObject();
            //frmPopup2060501 frm = new frmPopup2060501(vo);
            //frm.ShowDialog();
            //if (frm.IsRequireRefresh)
            //{
            //    RefreshData();
            //    Search();
            //}
        }
        /// <summary>
        /// 删除
        /// </summary>
        public override void Delete()
        {
            //if (this.gvData.SelectedRowsCount > 0)
            //{
            //    if (DialogBox.Msg("是否删除所选行记录？", MessageBoxIcon.Question) != DialogResult.Yes)
            //        return;
            //    EntityDietTreatment vo = GetRowObject();
            //    using (ProxyHms proxy = new ProxyHms())
            //    {
            //        if (proxy.Service.DeleteDicIngredient(vo) > 0)
            //        {
            //            RefreshData();
            //        }
            //    }
            //}
        }
        #endregion

        #region methods
        /// <summary>
        /// 
        /// </summary>
        void Init()
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

        #region RefreshData
        /// <summary>
        /// RefreshData
        /// </summary>
        public override void RefreshData()
        {
            uiHelper.BeginLoading(this);
            this.LoadQnDataSource();
            this.gcData.DataSource = this.lstDietTreatment;
            this.gcData.RefreshDataSource();
            uiHelper.CloseLoading(this);
        }
        #endregion


        #region LoadQnDataSource
        /// <summary>
        /// LoadQnDataSource
        /// </summary>
        void LoadQnDataSource()
        {
            lstDietTreatment = null;
            using (ProxyHms proxy = new ProxyHms())
            {
                lstDietTreatment = proxy.Service.GetDietTreatment();
            }
        }
        #endregion

        #region GetRowObject
        /// <summary>
        /// GetRowObject
        /// </summary>
        /// <returns></returns>
        EntityDietTreatment GetRowObject()
        {
            if (this.gvData.FocusedRowHandle < 0) return null;
            return this.gvData.GetRow(this.gvData.FocusedRowHandle) as EntityDietTreatment;
        }
        #endregion

        #endregion

        #region event

        private void frm20606_Load(object sender, EventArgs e)
        {
            Init();
        }
       

        private void gvData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
