using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hms.Ui
{
    public partial class frm21003 : frmBaseMdi
    {
        public frm21003()
        {
            InitializeComponent();
        }

        #region new
        /// <summary>
        /// new
        /// </summary>
        public override void New()
        {
            frmPopup21003 frm = new frmPopup21003();
            frm.ShowDialog();
            //if (frm.IsRequireRefresh)
            //{
            //    this.RefreshData();
            //    this.ScrollRow(frm.SportItemVo.sId);
            //}
        }
        #endregion

        private void frm21003_Load(object sender, EventArgs e)
        {

        }
    }
}
