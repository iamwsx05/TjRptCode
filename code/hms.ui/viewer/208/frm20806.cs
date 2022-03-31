using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hms.Ui
{
    public partial class frm20806 : frmBaseMdi
    {
        public frm20806()
        {
            InitializeComponent();
        }

        #region override
        /// <summary>
        /// 新增
        /// </summary>
        public override void New()
        {
            frmPopup2080401 frm = new frmPopup2080401();
            frm.ShowDialog();
        }
        /// <summary>
        /// 匹配
        /// </summary>
        public override void Capture()
        {
            frmPopup2080601 frm = new frmPopup2080601();
            frm.ShowDialog();
        }

        /// <summary>
        /// 删除
        /// </summary>
        public override void Delete()
        {
            
        }

        /// <summary>
        /// 忽略
        /// </summary>
        public override void Cancel()
        {
            
        }

        /// <summary>
        /// 撤销
        /// </summary>
        public override void UnConfirm()
        {
            
        }
        #endregion
    }
}
