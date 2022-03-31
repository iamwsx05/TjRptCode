using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frm20403 : frmBaseMdi
    {
        public frm20403()
        {
            InitializeComponent();
        }

        #region var/property
        List<EntityDisplayPromotionPlan> lstPromotionPlan { get; set; }
        #endregion

        #region override

        #region 
        public override void Search()
        {
            string name = this.txtName.Text;

            if (!string.IsNullOrEmpty(name))
            {
                this.gridControl.DataSource = this.lstPromotionPlan.FindAll(r => r.clientName.Contains(name));
            }
            else
            {
                this.gridControl.DataSource = this.lstPromotionPlan;
            }
            this.gridControl.RefreshDataSource();
        }
        #endregion


        public override void Copy()
        {
            frmPopup2040301 frm = new frmPopup2040301();
            frm.ShowDialog();
        }

        public override void Remind()
        {
            frmPopup2040302 frm = new frmPopup2040302();
            frm.ShowDialog();
        }
        #endregion

        #region methods

        void Init()
        {
            using (ProxyHms proxy = new ProxyHms())
            {
                lstPromotionPlan = proxy.Service.GetPromotionPlanRecords(null);
                gridControl.DataSource = lstPromotionPlan;
                gridControl.RefreshDataSource();
            }
        }
        #endregion

        #region events
        private void frm20403_Load(object sender, EventArgs e)
        {
            Init();
        }
       
        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        #endregion
    }
}
