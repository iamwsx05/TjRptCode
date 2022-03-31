using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;
using weCare.Core.Utils;

namespace Hms.Ui
{
    public partial class frm20201 : frmBaseMdi
    {
        public frm20201()
        {
            InitializeComponent();
        }

        #region var/property
        List<EntityDisplayClientRpt> lstTjReport { get; set; }
        #endregion

        #region override

        public override void Edit()
        {
            EntityDisplayClientRpt report = GetRowObject();
            if (report == null)
                return;
            frmPopup2020101 frm = new frmPopup2020101(report);
            frm.ShowDialog();
        }


        public override void Search()
        {
            string search = this.txtSearch.Text;
            List<EntityParm> dicParm = new List<EntityParm>();
            string beginDate = this.dteBegin.Text.Replace('-', '.') + " 00:00:00";
            string endDate = this.dteEnd.Text.Replace('-','.') + " 23:59:59";
            if (beginDate != string.Empty && endDate != string.Empty)
            {
                dicParm.Add(Function.GetParm("reportDate", beginDate + "|" + endDate));
            }
            if (!string.IsNullOrEmpty(search))
            {
                dicParm.Add(Function.GetParm("search", search));
            }
            using (ProxyHms proxy = new ProxyHms())
            {
                this.gcReport.DataSource = proxy.Service.GetTjReports(dicParm);
            }

            this.gcReport.RefreshDataSource();
        }

        #endregion

        #region methods

        #region Init
        internal void Init()
        {
            try
            {
                uiHelper.BeginLoading(this);
                this.dteBegin.Text = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
                this.dteEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");

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
            this.gcReport.DataSource = this.lstTjReport;
            this.gcReport.RefreshDataSource();
            uiHelper.CloseLoading(this);
        }
        #endregion

        #region LoadQnDataSource
        /// <summary>
        /// LoadQnDataSource
        /// </summary>
        void LoadQnDataSource()
        {
            lstTjReport = null;
            List<EntityParm> dicParm = new List<EntityParm>();
            string beginDate = this.dteBegin.Text + " 00:00:00";
            string endDate = this.dteEnd.Text + " 23:59:59";
            if (beginDate != string.Empty && endDate != string.Empty)
            {
                dicParm.Add(Function.GetParm("reportDate", beginDate + "|" + endDate));
            }
            using (ProxyHms proxy = new ProxyHms())
            {
                lstTjReport = proxy.Service.GetTjReports(dicParm);
            }
        }
        #endregion

        public EntityDisplayClientRpt GetRowObject()
        {
            EntityDisplayClientRpt vo = null;
            if (this.gvReport.FocusedRowHandle >= 0)
                vo = this.gvReport.GetRow(this.gvReport.FocusedRowHandle) as EntityDisplayClientRpt;

            return vo;
        }

        #endregion

        #region events

        private void gvReport_DoubleClick(object sender, EventArgs e)
        {
            this.Edit();
        }

        private void frm20201_Load(object sender, EventArgs e)
        {
            Init();
        }

        #endregion
    }
}
