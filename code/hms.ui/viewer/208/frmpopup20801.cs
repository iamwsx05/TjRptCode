using Common.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Hms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using weCare.Core.Entity;

namespace Hms.Ui
{
    public partial class frmPopup20801 : frmBaseMdi
    {
        public frmPopup20801(EntityReportTemplate _perptTemplate)
        {
            InitializeComponent();
            perptTemplate = _perptTemplate;
        }

        #region var/property
        public bool IsRequireRefresh { get; set; }
        public EntityReportTemplate perptTemplate { get; set; }

        #endregion

        #region method



        /// <summary>
        /// 绑定数据源
        /// </summary>
        private void BindData()
        {
            try
            {
                uiHelper.BeginLoading(this);
                using (ProxyHms proxy = new ProxyHms())
                {
                    this.gcData.DataSource = proxy.Service.GetReportTemplateDetail();
                }

            }
            finally
            {
                uiHelper.CloseLoading(this);
            }
        }


        private bool ClickGridCheckBox(DevExpress.XtraGrid.Views.Grid.GridView gridView, string fieldName, bool currentStatus)
        {
            bool result = false;
            if (gridView != null)
            {
                //禁止排序 
                gridView.ClearSorting();
                gridView.PostEditor();
                detailData.ClearSorting();
                detailData.PostEditor();
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info;
                System.Drawing.Point pt = gridView.GridControl.PointToClient(Control.MousePosition);
                info = gridView.CalcHitInfo(pt);
                if (info.Column != null && info.Column.FieldName == fieldName)
                {
                    for (int i = 0; i < detailData.RowCount; i++)
                    {
                        detailData.SetRowCellValue(i, fieldName, !currentStatus);
                    }
                    return true;
                }
            }
            return result;
        }




        #endregion

        #region event
        private void frmPopup2080101_Load(object sender, EventArgs e)
        {
            if (perptTemplate != null)
            {
                this.Text = "查看报告模板";
            }

            BindData();
        }

        #endregion

        private string chkFileName = "isSelect";
        private void deptChk_Click(object sender, EventArgs e)
        {
            CheckEdit chk = sender as CheckEdit;
            int a = gvData.FocusedRowHandle;
            GridView gvDetatil = (GridView)gvData.GetDetailView(a, gvData.GetVisibleDetailRelationIndex(a));
            if (gvDetatil != null)
            {
                if (chk.CheckState == CheckState.Checked)
                {
                    for (int i = 0; i < gvDetatil.RowCount; i++)
                    {
                        gvDetatil.SetRowCellValue(i, chkFileName, false);
                    }
                }
                else
                {
                    for (int i = 0; i < gvDetatil.RowCount; i++)
                    {
                        gvDetatil.SetRowCellValue(i, chkFileName, true);
                    }
                }

                //if (gvData.GetRowExpanded(a) == false)
                //{
                //    gvData.SetMasterRowExpandedEx(a, gvData.GetVisibleDetailRelationIndex(a), true);
                //}
            }
        }

        private void gvData_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {


        }
    }
}
