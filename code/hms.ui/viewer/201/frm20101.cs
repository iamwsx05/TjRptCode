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
    public partial class frm20101 : frmBaseMdi
    {
        public frm20101()
        {
            InitializeComponent();
        }

        #region var/property
        List<EntityClientInfo> lstClientInfo { get; set; }
        #endregion

        #region 
        public override void Search()
        {
            string name = this.txtName.Text;

            if(!string.IsNullOrEmpty(name))
            {
                List<EntityParm> dicParm = new List<EntityParm>();
                dicParm.Add(Function.GetParm("search", name));
                using (ProxyHms proxy = new ProxyHms())
                {
                    this.gridControl.DataSource = proxy.Service.GetClientInfoAndRpt(dicParm);
                }
            }
            else
            {
                this.gridControl.DataSource = this.lstClientInfo;
            }
            this.gridControl.RefreshDataSource();
        }
        #endregion

        #region methods

        #region Init
        internal void Init()
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

        #region RefreshData
        /// <summary>
        /// RefreshData
        /// </summary>
        public override void RefreshData()
        {
            uiHelper.BeginLoading(this);
            this.LoadQnDataSource();
            this.gridControl.DataSource = this.lstClientInfo;
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
            lstClientInfo = null;
            List<EntityParm> dicParm = new List<EntityParm>();
            string beginDate = DateTime.Now.AddDays(-7).ToString("yyyy.MM.dd");
            string endDate = DateTime.Now.ToString("yyyy.MM.dd");
            if (beginDate != string.Empty && endDate != string.Empty)
            {
                dicParm.Add(Function.GetParm("genDate", beginDate + "|" + endDate));
            }
            using (ProxyHms proxy = new ProxyHms())
            {
                lstClientInfo = proxy.Service.GetClientInfoAndRpt(dicParm);
            }
        }
        #endregion

        #endregion

        #region events
        private void frm20101_Load(object sender, EventArgs e)
        {
            using (ProxyHms proxy = new ProxyHms())
            {
                Init();
            }
        }

        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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
