using Common.Controls;
using Common.Entity;
using System;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Hms.Ui
{
    public partial class frmPopup21003 : frmBasePopup
    {
        public frmPopup21003()
        {
            InitializeComponent();
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void blbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
