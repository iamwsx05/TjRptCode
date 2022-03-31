using Common.Controls;
using Hms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hms.Ui
{
    public partial class frmPopup2030102 : frmBasePopup
    {
        public frmPopup2030102(List<EntityQnRecord> _lstQnRecord)
        {
            InitializeComponent();
            lstQnRecord = _lstQnRecord;
        }
        #region var/property
        List<EntityQnRecord> lstQnRecord { get; set; }
        public EntityQnRecord qnRecord { get; set; }
        public bool isSelect = false;
        #endregion

        #region 
        void Init()
        {
            if(lstQnRecord != null)
            {
                this.gridControl.DataSource = lstQnRecord;
                this.gridControl.RefreshDataSource();
            }
        }
        #endregion

        private void frmPopup2030102_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if(this.gridView.FocusedRowHandle >= 0)
            {
                qnRecord = this.gridView.GetRow(this.gridView.FocusedRowHandle) as EntityQnRecord;
                isSelect = true;
            }

            this.Close();
        }

        private void ribtnOpen_Click(object sender, EventArgs e)
        {
            if (this.gridView.FocusedRowHandle >= 0)
            {
                qnRecord = this.gridView.GetRow(this.gridView.FocusedRowHandle) as EntityQnRecord;
            }
            frmPopup2020201 frm = new frmPopup2020201(qnRecord);
            frm.ShowDialog();
        }
    }
}
