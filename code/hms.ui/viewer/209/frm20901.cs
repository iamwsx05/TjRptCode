using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Common.Utils;
using weCare.Core.Utils;

namespace Hms.Ui
{
    /// <summary>
    /// 自定义量表设置
    /// </summary>
    public partial class frm20901 : frmBaseMdi
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frm20901()
        {
            InitializeComponent();
        }
        #endregion

        #region var/property

        /// <summary>
        /// 问卷数据源
        /// </summary>
        List<EntityDicQnMain> dataSourceQN { get; set; }

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
                RefreshData();
            }
            finally
            {
                uiHelper.CloseLoading(this);
            }
        }
        #endregion

        #region ScrollRow
        /// <summary>
        /// ScrollRow
        /// </summary>
        /// <param name="qnId"></param>
        void ScrollRow(decimal qnId)
        {
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                this.gridView.UnselectRow(i);
            }
            for (int i = 0; i < this.gridView.RowCount; i++)
            {
                if ((this.gridView.GetRow(i) as EntityDicQnMain).qnId == qnId)
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
            frmPopup2090101 frm = new frmPopup2090101();
            frm.ShowDialog();
            if (frm.IsRequireRefresh)
            {
                this.RefreshData();
                this.ScrollRow(frm.QnVo.qnId);
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Delete
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
                            if (proxy.Service.DeleteQNnormal((this.gridView.GetRow(i) as EntityDicQnMain).qnId) > 0)
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

        #region Edit
        /// <summary>
        /// Edit
        /// </summary>
        public override void Edit()
        {
            if (this.gridView.SelectedRowsCount > 0)
            {
                EntityDicQnMain mainVo = this.gridView.GetRow(this.gridView.GetSelectedRows()[0]) as EntityDicQnMain;
                if (mainVo.classId == 1)
                {
                    frmPopup2090101 frm = new frmPopup2090101(mainVo);
                    frm.ShowDialog();
                    if (frm.IsRequireRefresh)
                    {
                        this.RefreshData();
                        this.ScrollRow(frm.QnVo.qnId);
                    }
                }
                else if (mainVo.classId == 2)
                {
                    frmPopup2090102 frm = new frmPopup2090102(mainVo);
                    frm.ShowDialog();
                    if (frm.IsRequireRefresh)
                    {
                        this.RefreshData();
                        this.ScrollRow(frm.QnVo.qnId);
                    }
                }
            }
            else
            {
                DialogBox.Msg("请选择要编辑的记录.");
            }
        }
        #endregion

        #region Design
        /// <summary>
        /// Design
        /// </summary>
        public override void Design()
        {
            frmPopup2090102 frm = new frmPopup2090102();
            frm.ShowDialog();
        }
        #endregion

        #region Previous
        /// <summary>
        /// Previous
        /// </summary>
        public override void Previous()
        {
            if (this.gridView.SelectedRowsCount > 0)
            {
                frmPopup2090103 frm = new frmPopup2090103(this.gridView.GetRow(this.gridView.GetSelectedRows()[0]) as EntityDicQnMain);
                frm.ShowDialog();
            }
            else
            {
                DialogBox.Msg("请选择要预览的记录.");
            }
        }
        #endregion

        #region search
        /// <summary>
        /// search
        /// </summary>
        public override void Search()
        {
            DialogBox.Msg("Search");
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
            this.LoadQnDataSource();
            this.gridControl.DataSource = this.dataSourceQN;
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
            dataSourceQN = null;
            using (ProxyEntityFactory proxy = new ProxyEntityFactory())
            {
                dataSourceQN = EntityTools.ConvertToEntityList<EntityDicQnMain>(proxy.Service.SelectFullTable(new EntityDicQnMain()));
            }
        }
        #endregion

        #endregion

        #region event 

        private void frm20901_Load(object sender, EventArgs e)
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

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if ((gridView.GetRow(e.RowHandle) as EntityDicQnMain).status == 1)
            //{
            //    e.Appearance.ForeColor = System.Drawing.Color.Red;
            //}

            if (Function.Int(gridView.GetRowCellValue(e.RowHandle, EntityDicQnMain.Columns.status)) == 0)
            {
                e.Appearance.ForeColor = System.Drawing.Color.Red;
            }
            gridView.Invalidate();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.Edit();
        }


        #endregion

    }
}
