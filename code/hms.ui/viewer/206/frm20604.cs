using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frm20604 : frmBaseMdi
    {
        public frm20604()
        {
            InitializeComponent();
        }

        #region var/propery
        public List<EntityDisplayDicCaiRecipe> lstCaiRecipe { get; set; }
        public List<EntityDicCai> lstCai { get; set; }
        #endregion

        #region override
        /// <summary>
        /// 添加
        /// </summary>
        public override void New()
        {
            frmPopup2060401 frm = new frmPopup2060401();
            frm.ShowDialog();
        }
        /// <summary>
        /// 查询
        /// </summary>
        public override void Search()
        {
            string name = this.txtName.Text;
            if(!string.IsNullOrEmpty(name))
            {
                gcData.DataSource = this.lstCai.FindAll(r => r.names.Contains(name));
                this.gcData.RefreshDataSource();
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        public override void Edit()
        {
            EntityDicCai caiVo = GetCaiRowObject();
            frmPopup2060401 frm = new frmPopup2060401(caiVo);
            frm.ShowDialog();
            if(frm.IsRequireRefresh)
            {
                RefreshData();
                Search();
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        public override void Delete()
        {
            if (this.gvData.SelectedRowsCount > 0)
            {
                if (DialogBox.Msg("是否删除所选行记录？", MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                EntityDicCai caiVo = GetCaiRowObject();
                using (ProxyHms proxy = new ProxyHms())
                {
                    if(proxy.Service.DeleteDicCai(caiVo) > 0)
                    {
                        RefreshData();
                    }
                }
            }
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
            this.gcCaiRecipe.DataSource = this.lstCaiRecipe;
            this.gcData.RefreshDataSource();
            this.gcData.DataSource = this.lstCai;
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
            lstCaiRecipe = null;
            lstCai = null;
            using (ProxyHms proxy = new ProxyHms())
            {
                lstCaiRecipe = proxy.Service.GetDicCaiRecipe();
                lstCai = proxy.Service.GetDicCai();
            }
        }
        #endregion

        #region GetRowObject
        /// <summary>
        /// GetRowObject
        /// </summary>
        /// <returns></returns>
        EntityDisplayDicCaiRecipe GetRowObject()
        {
            if (this.gvCaiRecipe.FocusedRowHandle < 0) return null;
            return this.gvCaiRecipe.GetRow(this.gvCaiRecipe.FocusedRowHandle) as EntityDisplayDicCaiRecipe;
        }
        #endregion

        #region GetCaiRowObject
        /// <summary>
        /// GetCaiRowObject
        /// </summary>
        /// <returns></returns>
        EntityDicCai GetCaiRowObject()
        {
            if (this.gvData.FocusedRowHandle < 0) return null;
            return this.gvData.GetRow(this.gvData.FocusedRowHandle) as EntityDicCai;
        }
        #endregion

        #endregion

        #region event
        private void frm20604_Load(object sender, EventArgs e)
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

        private void gvCaiRecipe_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            EntityDisplayDicCaiRecipe caiRecipe = GetRowObject();
            if(caiRecipe != null)
            {
                gcData.DataSource = this.lstCai.FindAll(r => r.lstCaiSlaveId.Contains(caiRecipe.caiSlaveId));
                this.gcData.RefreshDataSource();
            }
        }
        
        private void gvData_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (gvData.IsRowSelected(e.RowHandle))
                    gvData.UnselectRow(e.RowHandle);
                else
                    gvData.SelectRow(e.RowHandle);
            }
        }

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            this.Edit();
        }
        #endregion
    }
}
