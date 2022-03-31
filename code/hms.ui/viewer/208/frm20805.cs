using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frm20805 : frmBaseMdi
    {
        public frm20805()
        {
            InitializeComponent();
        }

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
            frmPopup2080501 frm = new frmPopup2080501();
            frm.ShowDialog();
        }

        /// <summary>
        /// 编辑
        /// </summary>
        public override void Edit()
        {
            
        }

        /// <summary>
        /// 删除
        /// </summary>
        public override void Delete()
        {
            
        }
        #endregion


        #region event
        private void frm20805_Load(object sender, EventArgs e)
        {
            List<EntityUnnormalcombin> data = new List<EntityUnnormalcombin>();

            EntityUnnormalcombin vo1 = new EntityUnnormalcombin();
            vo1.name = "心脏病";
            vo1.describe = "肺心病,职业性急性学物中毒性心脏病,先天性心脏病";
            data.Add(vo1);

            EntityUnnormalcombin vo2 = new EntityUnnormalcombin();
            vo2.name = "前列腺疾病";
            vo2.describe = "慢性前列腺炎，慢性前列腺炎急性发作，慢性细菌性前列腺炎，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬，前列腺癌，前列腺坚硬。";
            data.Add(vo2);

            this.gridControl1.DataSource = data;
        }
        #endregion
    }
}
