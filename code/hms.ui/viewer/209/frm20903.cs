using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Utils;
using System.Drawing;

namespace Hms.Ui
{
    /// <summary>
    /// 危险因素
    /// </summary>
    public partial class frm20903 : frmBaseMdi
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frm20903()
        {
            InitializeComponent();
        }
        #endregion

        #region var/property


        #endregion

        #region method

        #region init
        /// <summary>
        /// init
        /// </summary>
        void Init()
        {
            this.RefreshData();
        }
        #endregion

        #region ScrollRow
        /// <summary>
        /// ScrollRow
        /// </summary>
        /// <param name="hId"></param>
        void ScrollRow(decimal hId)
        {
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                this.gridView.UnselectRow(i);
            }
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                if ((this.gridView.GetRow(i) as EntityDicHazards).hId == hId)
                {
                    this.gridView.FocusedRowHandle = i;
                    this.gridView.SelectRow(i);
                    break;
                }
            }
        }
        #endregion

        #region New
        /// <summary>
        /// New
        /// </summary>
        public override void New()
        {
            frmPopup20903 frm = new frmPopup20903();
            frm.ShowDialog();
            if (frm.IsRequireRefresh)
            {
                this.RefreshData();
                this.ScrollRow(frm.HazardsVo.hId);
            }
        }
        #endregion

        #region edit
        /// <summary>
        /// edit
        /// </summary>
        public override void Edit()
        {
            if (this.gridView.SelectedRowsCount > 0)
            {
                frmPopup20903 frm = new frmPopup20903(this.gridView.GetRow(this.gridView.GetSelectedRows()[0]) as EntityDicHazards);
                frm.ShowDialog();
                if (frm.IsRequireRefresh)
                {
                    this.RefreshData();
                    this.ScrollRow(frm.HazardsVo.hId);
                }
            }
            else
            {
                DialogBox.Msg("请选择要编辑的记录.");
            }
        }
        #endregion

        #region delete
        /// <summary>
        /// delete
        /// </summary>
        public override void Delete()
        {
            if (this.gridView.SelectedRowsCount > 0)
            {
                if (DialogBox.Msg("是否删除所选行记录？", MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                bool isRequireRefresh = false;
                for (int i = this.gridView.RowCount - 1; i >= 0; i--)
                {
                    if (this.gridView.IsRowSelected(i))
                    {
                        using (ProxyHms proxy = new ProxyHms())
                        {
                            if (proxy.Service.DeleteHazards((this.gridView.GetRow(i) as EntityDicHazards).hId) > 0)
                            {
                                this.gridView.DeleteRow(i);
                                isRequireRefresh = true;
                            }
                            else
                            {
                                DialogBox.Msg("删除记录失败。");
                                break;
                            }
                        }
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

        #region search
        /// <summary>
        /// search
        /// </summary>
        public override void Search()
        {

        }
        #endregion

        #region export
        /// <summary>
        /// export
        /// </summary>
        public override void Export()
        {
            uiHelper.ExportToXls(this.gridView);
        }
        #endregion

        #region print
        /// <summary>
        /// print
        /// </summary>
        public override void Preview()
        {
            uiHelper.Print(this.gridControl);
        }
        #endregion

        #region RefreshData
        /// <summary>
        /// RefreshData
        /// </summary>
        public override void RefreshData()
        {
            try
            {
                uiHelper.BeginLoading(this);
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    this.gridControl.DataSource = EntityTools.ConvertToEntityList<EntityDicHazards>(proxy.Service.SelectFullTable(new EntityDicHazards()));
                    this.gridControl.RefreshDataSource();
                }
            }
            finally
            {
                uiHelper.CloseLoading(this);
            }
        }
        #endregion

        #endregion

        #region event

        private void frm20903_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Appearance.ForeColor = Color.Gray;
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.Edit();
        }

        #endregion

    }
}
