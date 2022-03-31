using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frm20601 : frmBaseMdi
    {
        public frm20601()
        {
            InitializeComponent();
        }

        #region var/property
        public List<EntityDietPrinciple> data { get; set; }
        #endregion

        #region override

        /// <summary>
        /// 查询
        /// </summary>
        public override void Search()
        {
            if(data != null)
            {
                for (int i = 0; i < this.gridView.RowCount; i++)
                {
                    this.gridView.UnselectRow(i);
                }
                string search = this.txtSearch.Text;
                
                this.gridControl.DataSource = data.FindAll(r => r.principleName.Contains(search) || weCare.Core.Utils.SpellCodeHelper.GetPyCode(r.principleName).ToUpper().Contains(search));
                this.gridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        public override void New()
        {
            frmPopup2060101 frm = new frmPopup2060101();
            frm.ShowDialog();
            if (frm.IsRequireRefresh)
            {
                this.RefreshData();
                this.ScrollRow(frm.dietPrinciple.principleId);
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
            this.gridControl.DataSource = this.data;
            this.gridControl.RefreshDataSource();
            uiHelper.CloseLoading(this);
        }
        #endregion

        /// <summary>
        /// 编辑
        /// </summary>
        public override void Edit()
        {
            if (this.gridView.SelectedRowsCount > 0)
            {
                frmPopup2060101 frm = new frmPopup2060101(this.gridView.GetRow(this.gridView.GetSelectedRows()[0]) as EntityDietPrinciple);
                frm.ShowDialog();
                if (frm.IsRequireRefresh)
                {
                    this.RefreshData();
                    this.ScrollRow(frm.dietPrinciple.principleId);
                }
            }
            else
            {
                DialogBox.Msg("请选择要编辑的记录.");
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        public override void Delete()
        {
            if (this.gridView.SelectedRowsCount > 0)
            {
                if (DialogBox.Msg("是否删除所选行记录？", MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                bool isRequireRefresh = false;
                int affect = -1;
                List<EntityDietPrinciple> delData = new List<EntityDietPrinciple>();
                for (int i = this.gridView.RowCount - 1; i >= 0; i--)
                {
                    if (this.gridView.IsRowSelected(i))
                    {
                        delData.Add((this.gridView.GetRow(i) as EntityDietPrinciple));
                    }
                }

                if(delData.Count > 0)
                {
                    using (ProxyHms proxy = new ProxyHms())
                    {
                        affect = proxy.Service.DeleteDietPrinciple(delData);
                    }

                    if(affect < 0)
                    {
                        DialogBox.Msg("删除记录失败。");
                    }
                    else
                    {
                        isRequireRefresh = true;
                    }    
                }
                if (isRequireRefresh)
                    this.RefreshData();
            }
            else
            {
                DialogBox.Msg("请选择需要删除的记录。");
            }
        }
        #endregion

        #region method

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        void Init()
        {
            try
            {
                uiHelper.BeginLoading(this);
                using (ProxyHms proxy = new ProxyHms())
                {
                    data = proxy.Service.GetDietPrinciple();
                    this.gridControl.DataSource = data;
                }

            }
            finally
            {
                uiHelper.CloseLoading(this);
            }
        }
        #endregion

        #region LoadQnDataSource
        /// <summary>
        /// LoadQnDataSource
        /// </summary>
        void LoadQnDataSource()
        {
            data = null;
            using (ProxyHms proxy = new ProxyHms())
            {
                data = proxy.Service.GetDietPrinciple();
            }
        }
        #endregion

        #region ScrollRow
        /// <summary>
        /// ScrollRow
        /// </summary>
        /// <param name="principleId"></param>
        void ScrollRow(string principleId)
        {
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                this.gridView.UnselectRow(i);
            }
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                if ((this.gridView.GetRow(i) as EntityDietPrinciple).principleId == principleId)
                {
                    this.gridView.FocusedRowHandle = i;
                    this.gridView.SelectRow(i);
                    break;
                }
            }
        }
        #endregion

        #endregion

        #region event
        private void frm20601_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (gridView.IsRowSelected(e.RowHandle))
                    gridView.UnselectRow(e.RowHandle);
                else
                    gridView.SelectRow(e.RowHandle);
            }
        }
        #endregion
    }
}
