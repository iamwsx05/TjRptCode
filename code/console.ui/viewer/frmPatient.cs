using Common.Controls;
using Common.Entity;
using DevExpress.XtraBars;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Console.Ui
{
    /// <summary>
    /// 患者(病人)资料
    /// </summary>
    public partial class frmPatient : frmBaseMdi
    {
        #region 构造
        /// <summary>
        /// 构造
        /// </summary>
        public frmPatient()
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
            Controller = new ctlPatient();
            Controller.SetUI(this);
        }
        #endregion

        #region override

        public override void New()
        {
            ((ctlPatient)Controller).New();
        }

        public override void Delete()
        {
            ((ctlPatient)Controller).Delete();
        }

        public override void Save()
        {
            ((ctlPatient)Controller).Save(false);
        }

        public override void Refresh()
        {
            ((ctlPatient)Controller).Refresh();
        }

        public override void Preview()
        {
            ((ctlPatient)Controller).Print();
        }

        #endregion

        #region 事件

        private void frmPatient_Load(object sender, EventArgs e)
        {
            ((ctlPatient)Controller).Init();
        }

        private void frmPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ValueChanged)
            {
                DialogResult res = DialogBox.Msg("是否保存数据？", MessageBoxIcon.Question, true);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    ((ctlPatient)Controller).Save(true);
                }
                else if (res == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.isCancelExit = true;
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void chkAllergic1_CheckedChanged(object sender, EventArgs e)
        {
            ((ctlPatient)Controller).SetChkAllergic(1);
        }

        private void chkAllergic2_CheckedChanged(object sender, EventArgs e)
        {
            ((ctlPatient)Controller).SetChkAllergic(2);
        }

        private void chkIsAutoGen1_CheckedChanged(object sender, EventArgs e)
        {
            ((ctlPatient)Controller).SetChkIsAutoGen(1);
        }

        private void chkIsAutoGen2_CheckedChanged(object sender, EventArgs e)
        {
            ((ctlPatient)Controller).SetChkIsAutoGen(2);
        }

        private void txtKeyVal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((ctlPatient)Controller).Query();
            }
        }

        private void gvCard_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void gvCard_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ((ctlPatient)Controller).SelectedCardRow();
        }

        #endregion

       


    }
}
