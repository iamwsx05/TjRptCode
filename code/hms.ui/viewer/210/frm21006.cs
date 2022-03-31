using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hms.Ui
{
    public partial class frm21006 : frmBaseMdi
    {
        public frm21006()
        {
            InitializeComponent();
        }

        #region override

        public override void Copy()
        {
            frmPopup2100601 frm = new frmPopup2100601();
            frm.ShowDialog();
        }

        public override void Edit()
        {
            frmPopup2100602 frm = new frmPopup2100602();
            frm.ShowDialog();
        }

        public override void Remind()
        {
            frmPopup2100603 frm = new frmPopup2100603();
            frm.ShowDialog();
        }

        #endregion

        private void frm21006_Load(object sender, EventArgs e)
        {

        }
    }
}
