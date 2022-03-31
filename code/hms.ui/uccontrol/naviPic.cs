using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;

namespace Hms.Ui
{
    public partial class naviPic : UserControl
    {
        public naviPic()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
        }

        string _picName = string.Empty;

        [Browsable(true)]
        public string PicName
        {
            set
            {
                _picName = value;
                if (!string.IsNullOrEmpty(_picName))
                {
                    this.pic.Image = (new System.Resources.ResourceManager(typeof(Properties.Resource))).GetObject(value) as Image;
                }
            }
            get { return _picName; }
        }

        public bool IsStyle { get; set; }

        private void naviPic_Load(object sender, EventArgs e)
        {
            ContextMenu emptyMenu = new ContextMenu();
            pic.Properties.ContextMenu = emptyMenu;
            if (IsStyle) this.pic.Cursor = Cursors.Hand;
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            if (IsStyle)
            {
                this.pic.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                this.BackColor = Color.Blue;
            }
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            if (IsStyle)
            {
                this.pic.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
                this.BackColor = Color.White;
            }
        }
    }
}
