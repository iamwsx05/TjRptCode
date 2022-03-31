using Common.Controls;
using Common.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using weCare.Core.Entity;

namespace Hms.Ui
{
    /// <summary>
    /// 运动库
    /// </summary>
    public partial class frm21001 : frmBaseMdi
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frm21001()
        {
            InitializeComponent();
        }
        #endregion

        #region var.property

        /// <summary>
        /// 运动模板数据源
        /// </summary>
        List<EntityDicSportItem> dataSourceSportItem { get; set; }

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
        /// <param name="sId"></param>
        void ScrollRow(decimal sId)
        {
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                this.gridView.UnselectRow(i);
            }
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                if ((this.gridView.GetRow(i) as EntityDicSportItem).sId == sId)
                {
                    this.gridView.FocusedRowHandle = i;
                    this.gridView.SelectRow(i);
                    break;
                }
            }
        }
        #endregion

        #region new
        /// <summary>
        /// new
        /// </summary>
        public override void New()
        {
            frmPopup21001 frm = new frmPopup21001(new EntityDicSportItem());
            frm.ShowDialog();
            if (frm.IsRequireRefresh)
            {
                this.RefreshData();
                this.ScrollRow(frm.SportItemVo.sId);
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
                frmPopup21001 frm = new frmPopup21001(this.gridView.GetRow(this.gridView.GetSelectedRows()[0]) as EntityDicSportItem);
                frm.ShowDialog();
                if (frm.IsRequireRefresh)
                {
                    this.RefreshData();
                    this.ScrollRow(frm.SportItemVo.sId);
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
                            if (proxy.Service.DeleteSportItem((this.gridView.GetRow(i) as EntityDicSportItem).sId) > 0)
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
            uiHelper.BeginLoading(this);
            this.LoadSportItem();
            this.gridControl.DataSource = this.dataSourceSportItem;
            this.gridControl.RefreshDataSource();
            uiHelper.CloseLoading(this);
        }
        #endregion

        #region LoadSportItem
        /// <summary>
        /// LoadSportItem
        /// </summary>
        void LoadSportItem()
        {
            dataSourceSportItem = null;
            using (ProxyEntityFactory proxy = new ProxyEntityFactory())
            {
                dataSourceSportItem = EntityTools.ConvertToEntityList<EntityDicSportItem>(proxy.Service.SelectFullTable(new EntityDicSportItem()));
            }
        }
        #endregion

        #endregion

        #region event

        private void frm21001_Load(object sender, EventArgs e)
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
