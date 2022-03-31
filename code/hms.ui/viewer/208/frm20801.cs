using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frm20801 : frmBaseMdi
    {
        public frm20801()
        {
            InitializeComponent();
        }

        #region override

        /// <summary>
        /// 添加
        /// </summary>
        public override void New()
        {
            frmPopup20801 frm = new frmPopup20801(null);
            frm.ShowDialog();
            if (frm.IsRequireRefresh)
            {
                this.RefreshData();
            }
        }

        /// <summary>
        /// 编辑
        /// </summary>
        public override void Edit()
        {
            if (this.gridView1.SelectedRowsCount > 0)
            {
                EntityReportTemplate vo = this.gridView1.GetRow(this.gridView1.GetSelectedRows()[0]) as EntityReportTemplate;
                frmPopup20801 frm = new frmPopup20801(vo);
                frm.ShowDialog();
                if (frm.IsRequireRefresh)
                {
                    this.RefreshData();
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

        }
        /// <summary>
        /// 查询
        /// </summary>
        public override void Search()
        {

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
                    this.gridControl1.DataSource = proxy.Service.GetReportTemplate();
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm20801_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Edit();
        }


        #endregion

       
    }
}
