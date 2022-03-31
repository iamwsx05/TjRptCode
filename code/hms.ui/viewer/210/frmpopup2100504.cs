using Common.Controls;
using Common.Entity;
using System;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Hms.Ui
{
    public partial class frmPopup2100504 : frmBasePopup
    {
        public frmPopup2100504()
        {
            InitializeComponent();
        }

        private void cboMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            int days = System.Threading.Thread.CurrentThread.CurrentUICulture.Calendar.GetDaysInMonth(DateTime.Now.Year, this.cboMonths.SelectedIndex + 1);
            this.cboDays.Properties.Items.Clear();
            for (int i = 0; i < days; i++)
            {
                this.cboDays.Properties.Items.Add(string.Format("第{0}天", i + 1));
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
