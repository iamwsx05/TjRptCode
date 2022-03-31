using Common.Controls;
using Hms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hms.Ui
{
    public partial class frmPopup2020101 : frmBasePopup
    {
        public frmPopup2020101(EntityDisplayClientRpt _tjReport)
        {
            InitializeComponent();
            tjReport = _tjReport;
        }
        #region var/property
        EntityDisplayClientRpt tjReport { get; set; }
        Dictionary<string, List<EntityTjResult>>  dicTjResult { get; set; }
        List<EntityTjResult> lstXjResult = null;
        List<EntityTjResult> lstTjResult = null;
        EntityTjjljy tjjljy = null;
        #endregion

        #region methods
        void Init()
        {
            if (tjReport == null)
                return;
            lblClientName.Text = tjReport.clientName;
            lblClientNo.Text = tjReport.clientNo;
            lblSex.Text = tjReport.sex;
            lblAge.Text = tjReport.age;
            lblRegDate.Text = tjReport.reportDate;
            lblRegNo.Text = tjReport.reportNo;

            SetData();
        }

        #endregion

        void SetData()
        {
            using (ProxyHms proxy = new ProxyHms())
            {
                dicTjResult = proxy.Service.GetTjResult(tjReport.reportNo, out lstTjResult, out lstXjResult, out tjjljy);
            }
            List<EntityTjResult> lstResult = null;
            int height = 0;
            if (lstXjResult != null)
            {
                foreach(var vo in lstXjResult)
                {
                    lstResult = dicTjResult[vo.itemCode];
                    ucReportItem uc = new ucReportItem(lstResult, vo);
                    uc.Dock = DockStyle.Top;
                    plResult.Controls.Add(uc);
                    height += uc.Height;
                }

                plResult.Height = height + 10;
            }

            if(tjjljy != null)
            {
                this.memResult.Text = tjjljy.results + Environment.NewLine + tjjljy.sumup;
                this.memSugg.Text = tjjljy.suggTage;
            }
        }

        #region events
        private void frmPopup2020101_Load(object sender, EventArgs e)
        {
            Init();
        }
        #endregion
    }
}
