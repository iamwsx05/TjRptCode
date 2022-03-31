namespace Hms.Ui
{
    partial class naviPic
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(naviPic));
            this.pic = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.EditValue = ((object)(resources.GetObject("pic.EditValue")));
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pic.Properties.ZoomAccelerationFactor = 1D;
            this.pic.Size = new System.Drawing.Size(150, 30);
            this.pic.TabIndex = 28;
            this.pic.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.pic.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // naviPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pic);
            this.Name = "naviPic";
            this.Size = new System.Drawing.Size(150, 30);
            this.Load += new System.EventHandler(this.naviPic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PictureEdit pic;
    }
}
