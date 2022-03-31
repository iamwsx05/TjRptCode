using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace peDataSys
{
    public partial class xRptTeam : DevExpress.XtraReports.UI.XtraReport
    {
        public xRptTeam()
        {
            InitializeComponent();
        }

        public xRptTeam(EntityReport reprot)//构造函数重载  
        {
            InitializeComponent();
            SetDataBind(reprot);
        }

        private void SetDataBind(EntityReport report)//绑定数据源  
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
