using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frm20804 : frmBaseMdi
    {
        public frm20804()
        {
            InitializeComponent();
        }

        #region var/property 

        #endregion

        #region override
        /// <summary>
        /// 查询
        /// </summary>
        public override void Search()
        {

        }
        /// <summary>
        /// 添加
        /// </summary>
        public override void New() 
        {
            frmPopup2080401 frm = new frmPopup2080401();
            frm.ShowDialog();
            if (frm.IsRequireRefresh)
            {
                this.RefreshData();
            }
        }
        /// <summary>
        /// 编辑
        /// </summary>
        public override void Edit()
        {
            if (this.gridView1.SelectedRowsCount > 0)
            {
                EntityUnnormal vo = this.gridView1.GetRow(this.gridView1.GetSelectedRows()[0]) as EntityUnnormal;
                frmPopup2080401 frm = new frmPopup2080401(vo);
                frm.ShowDialog();
                if (frm.IsRequireRefresh)
                {
                    this.RefreshData();
                }
            }
            else
            {
                DialogBox.Msg("请选择要编辑的记录.");
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        public override void Delete()
        {

        }
        /// <summary>
        /// 批量推荐就医检查
        /// </summary>
        public override void Refrence()
        {

        }
        /// <summary>
        /// 推荐科室配置
        /// </summary>
        public override void Cpmgt()
        {
            frmPopup2080402 frm = new frmPopup2080402();
            frm.ShowDialog();
        }
        /// <summary>
        /// 检查项目配置
        /// </summary>
        public override void Remind()
        {
            frmPopup2080403 frm = new frmPopup2080403();
            frm.ShowDialog();
        }
        
        /// <summary>
        /// 异常合并
        /// </summary>
        public override void Consent()
        {
            frmPopup2080404 frm = new frmPopup2080404();
            frm.ShowDialog();
        }

        #endregion

        #region method
        internal void Init()
        {
            EntityUnnormal unnormal = new EntityUnnormal();
            List<EntityUnnormal> data = new List<EntityUnnormal>();
            unnormal.unnormalName = "上纵隔小圆形钙化灶";
            unnormal.unnormalType = "未指定";
            unnormal.importance = "未指定";
            unnormal.emergency = "";
            unnormal.refDeptname = "";
            unnormal.refCheck = "";
            unnormal.belongSys = "";
            data.Add(unnormal);
            this.gridControl1.DataSource = data;
        }

        #endregion

        #region event
        private void frm20804_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int a = gridView1.FocusedRowHandle;
            this.gridView1.SelectRow(a);
            this.Edit();
        }


        #endregion
    }
}
