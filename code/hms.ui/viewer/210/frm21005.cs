using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hms.Ui
{
    public partial class frm21005 : frmBaseMdi
    {
        public frm21005()
        {
            InitializeComponent();
        }

        #region new
        /// <summary>
        /// new
        /// </summary>
        public override void New()
        {
            frmPopup2100501 frm = new frmPopup2100501();
            frm.ShowDialog();
            //if (frm.IsRequireRefresh)
            //{
            //    this.RefreshData();
            //    this.ScrollRow(frm.SportItemVo.sId);
            //}
        }
        #endregion

        #region edit
        /// <summary>
        /// edit
        /// </summary>
        public override void Edit()
        {
            frmPopup2100502 frm = new frmPopup2100502();
            frm.ShowDialog();
        }
        #endregion

        #region remind
        /// <summary>
        /// remind
        /// </summary>
        public override void Remind()
        {
            frmPopup2100503 frm = new frmPopup2100503();
            frm.ShowDialog();
        }
        #endregion

    }
}
