using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frm20605 : frmBaseMdi
    {
        public frm20605()
        {
            InitializeComponent();
        }

        #region var/propery
        List<EntityDicDientIngredient> lstDicDientIngredient { get; set; }
        List<EntityDicIngredientClassify> lstDicIngredientClassify { get; set; }
        #endregion

        #region override
        /// <summary>
        /// 添加
        /// </summary>
        public override void New()
        {
            frmPopup2060501 frm = new frmPopup2060501();
            frm.ShowDialog();
        }
        /// <summary>
        /// 查询
        /// </summary>
        public override void Search()
        {
            string name = this.txtName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                gcData.DataSource = this.lstDicDientIngredient.FindAll(r => r.names.Contains(name));
                this.gcData.RefreshDataSource();
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        public override void Edit()
        {
            EntityDicDientIngredient vo = GetIngredientRowObject();
            frmPopup2060501 frm = new frmPopup2060501(vo);
            frm.ShowDialog();
            if (frm.IsRequireRefresh)
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
                EntityDicDientIngredient vo = GetIngredientRowObject();
                using (ProxyHms proxy = new ProxyHms())
                {
                    if (proxy.Service.DeleteDicIngredient(vo) > 0)
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
            this.gcIngredientClass.DataSource = this.lstDicIngredientClassify;
            this.gcIngredientClass.RefreshDataSource();
            this.gcData.DataSource = this.lstDicDientIngredient;
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
            lstDicIngredientClassify = null;
            lstDicDientIngredient = null;
            using (ProxyHms proxy = new ProxyHms())
            {
                lstDicIngredientClassify = proxy.Service.GetDicIngredientClassify();
                lstDicDientIngredient = proxy.Service.GetDicDietIngredient();
            }
        }
        #endregion

        #region GetRowObject
        /// <summary>
        /// GetRowObject
        /// </summary>
        /// <returns></returns>
        EntityDicIngredientClassify GetClassRowObject()
        {
            if (this.gvIngredientClass.FocusedRowHandle < 0) return null;
            return this.gvIngredientClass.GetRow(this.gvIngredientClass.FocusedRowHandle) as EntityDicIngredientClassify;
        }
        #endregion

        #region GetIngredientRowObject
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        EntityDicDientIngredient GetIngredientRowObject()
        {
            if (this.gvData.FocusedRowHandle < 0) return null;
            return this.gvData.GetRow(this.gvData.FocusedRowHandle) as EntityDicDientIngredient;
        }
        #endregion

        #endregion

        #region event

        private void frm20605_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void gvIngredientClass_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            EntityDicIngredientClassify classify = GetClassRowObject();
            if (classify != null)
            {
                gcData.DataSource = this.lstDicDientIngredient.FindAll(r => r.lstClassify.Contains(classify.classifyId));
                this.gcData.RefreshDataSource();
            }
        }

        private void gvData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            this.Edit();
        }
        #endregion
    }
}
