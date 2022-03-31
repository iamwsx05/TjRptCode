using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hms.Ui
{
    public partial class frm21004 : frmBaseMdi
    {
        public frm21004()
        {
            InitializeComponent();
        }

        #region new
        /// <summary>
        /// new
        /// </summary>
        public override void New()
        {
            frmPopup21004 frm = new frmPopup21004();
            frm.ShowDialog();
            //if (frm.IsRequireRefresh)
            //{
            //    this.RefreshData();
            //    this.ScrollRow(frm.SportItemVo.sId);
            //}
        }
        #endregion

        private void frm21004_Load(object sender, EventArgs e)
        {

        }
    }
}
