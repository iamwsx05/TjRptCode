using Common.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hms.Entity;
using DevExpress.XtraReports.UI;

namespace Hms.Ui
{
    public partial class frmPopup2030101  : frmBasePopup
    {
        public frmPopup2030101(EntityClientReport _rpt =null)
        {
            InitializeComponent();
            rpt = _rpt;
        }

        #region var
        /// <summary>
        /// 
        /// </summary>
        EntityClientReport rpt { get; set; }
        xRptPerson xr;
        #endregion

        #region methods
        /// <summary>
        /// 
        /// </summary>
        void Init()
        {
            xr = new xRptPerson(rpt);
            xr.CreateDocument();//创建报表
            this.documentViewer1.PrintingSystem = xr.PrintingSystem;
        }
        #endregion

        #region event

        private void frmpopup2030101_Load(object sender, EventArgs e)
        {
            Init();
        }
        #endregion

        private void blbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xr.PrintDialog();
        }

        private void blbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
