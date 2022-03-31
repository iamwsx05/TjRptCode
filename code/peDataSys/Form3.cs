using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace peDataSys
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        xRptTeam xr;
        private void btnReport_Click(object sender, EventArgs e)
        {
            xr.PrintDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            EntityReport report = new EntityReport();
                 
            xr = new xRptTeam(report);
            xr.CreateDocument();//创建报表
            this.documentViewer1.PrintingSystem = xr.PrintingSystem;
        }
    }
}
