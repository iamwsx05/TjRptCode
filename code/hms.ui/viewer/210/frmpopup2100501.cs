using Common.Controls;
using Common.Entity;
using System;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Hms.Ui
{
    public partial class frmPopup2100501 : frmBasePopup
    {
        public frmPopup2100501()
        {
            InitializeComponent();
        }

        private void blbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
