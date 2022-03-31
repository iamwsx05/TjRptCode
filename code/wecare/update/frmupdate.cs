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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private bool m_blnAltF4 = false;

        private void frmUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode == Keys.F4)
                {
                    this.m_blnAltF4 = true;
                }
            }
        }

        private void frmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.m_blnAltF4)
            {
                e.Cancel = true;
            }
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            this.Top -= 50;
            this.TopMost = true;
        }
    }
}
