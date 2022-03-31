using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class ucReportItem : UserControl
    {
        public ucReportItem(List<EntityTjResult> _lstTjResult, EntityTjResult _xjResult)
        {
            InitializeComponent();
            lstTjResult = _lstTjResult;
            xjResult = _xjResult;
        }

        List<EntityTjResult> lstTjResult { get; set; }
        EntityTjResult xjResult { get; set; }

        private void ucReportItem_Load(object sender, EventArgs e)
        {
            if (lstTjResult == null)
                return;

            if(xjResult != null)
            {
                lblDeptName.Text = xjResult.itemName;
                lblXj.Text = xjResult.itemResult;
            }

            lblDoctName.Text = lstTjResult[0].doctName;
            lblRegDate.Text = lstTjResult[0].regDate;
            this.gcReport.DataSource = lstTjResult;
            this.gcReport.RefreshDataSource();
            this.Height = lstTjResult.Count * 30 + 150;
        }
    }
}
