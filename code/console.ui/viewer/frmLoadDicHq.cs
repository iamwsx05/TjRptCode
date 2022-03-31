using Common.Controls;
using Common.Entity;
using DevExpress.XtraBars;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Console.Ui
{
    public partial class frmLoadDicHq : frmBaseMdi
    {
        #region 构造
        /// <summary>
        /// 构造
        /// </summary>
        public frmLoadDicHq()
        {
            InitializeComponent();
        }
        #endregion

        #region CreateController
        /// <summary>
        /// CreateController
        /// </summary>
        protected override void CreateController()
        {
            base.CreateController();
            Controller = new ctlLoadDicHq();
            Controller.SetUI(this);
        }
        #endregion

        #region 事件

        private void frmLoadDicHq_Load(object sender, EventArgs e)
        {
            ((ctlLoadDicHq)Controller).Init();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ((ctlLoadDicHq)Controller).ImportData();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            ((ctlLoadDicHq)Controller).SetChecked(0);
        }

        private void chkDept_CheckedChanged(object sender, EventArgs e)
        {
            ((ctlLoadDicHq)Controller).SetChecked(1);
        }

        private void chkEmp_CheckedChanged(object sender, EventArgs e)
        {
            ((ctlLoadDicHq)Controller).SetChecked(1);
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ((ctlLoadDicHq)Controller).AsyncImport();
        }

        #endregion

    }
}
