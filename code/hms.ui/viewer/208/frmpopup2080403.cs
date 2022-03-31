using Common.Controls;
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
    public partial class frmPopup2080403 : frmBasePopup
    {
        public frmPopup2080403()
        {
            InitializeComponent();
        }

        private void frmPopup2080403_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            frmPopup208040301 frm = new frmPopup208040301();
            frm.ShowDialog();
        }
    }
}
