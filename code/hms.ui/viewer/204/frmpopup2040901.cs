using Common.Controls;
using Common.Utils;
using System;
using System.Collections.Generic;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System.Text;
using System.Windows.Forms;
using Hms.Entity;
using System.Data;

namespace Hms.Ui
{
    /// <summary>
    /// 短信查看/重发
    /// </summary>
    public partial class frmPopup2040901 : frmBasePopup
    {
        public frmPopup2040901(int _typeId)
        {
            InitializeComponent();
            if (!DesignMode)
            {
                this.Text = _typeId == 1 ? "查看短信" : "重发短信";
                this.blbiSend.Visibility = _typeId == 1 ? DevExpress.XtraBars.BarItemVisibility.Never : DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        private void frmPopup2040901_Load(object sender, EventArgs e)
        {

        }

        private void blbiSend_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void blbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
