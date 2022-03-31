using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hms.Ui
{
    /// <summary>
    /// 短信发送记录
    /// </summary>
    public partial class frm20409 : frmBaseMdi
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frm20409()
        {
            InitializeComponent();
        }
        #endregion

        #region var/property


        #endregion

        #region method

        public override void Search()
        {

        }

        public override void Remind()
        {
            frmPopup2040901 frm = new frmPopup2040901(0);
            frm.ShowDialog();
        }

        public override void Edit()
        {
            frmPopup2040901 frm = new frmPopup2040901(1);
            frm.ShowDialog();
        }

        public override void Delete()
        {

        }

        public override void Preview()
        {
            uiHelper.Print(this.gridControl);
        }

        public override void Export()
        {
            uiHelper.ExportToXls(this.gridView);
        }

        #endregion

        #region event

        private void frm20409_Load(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
