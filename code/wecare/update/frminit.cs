using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace weCare
{
    public partial class frmInit : Form
    {
        public frmInit()
        {
            InitializeComponent();
        }

        private void frmInit_Load(object sender, EventArgs e)
        {
            this.Top -= 50;
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            base.WndProc(ref m);
        }
    }
}
