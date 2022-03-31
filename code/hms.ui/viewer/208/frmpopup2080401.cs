using Common.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using weCare.Core.Entity;
using Hms.Entity;

namespace Hms.Ui
{
    public partial class frmPopup2080401 : frmBasePopup
    {
        public frmPopup2080401(EntityUnnormal _unnormal=null)
        {
            InitializeComponent();
            unnormal = _unnormal;
        }

        #region var/property
        public EntityUnnormal unnormal { get; set; }
        public bool IsRequireRefresh { get; set; }
        #endregion

        private void frmPopup2080401_Load(object sender, EventArgs e)
        {
            if(unnormal != null)
            {
                this.Text = "查看/编辑异常";
            }
        }
    }
}
