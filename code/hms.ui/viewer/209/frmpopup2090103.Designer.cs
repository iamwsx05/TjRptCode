namespace Hms.Ui
{
    partial class frmPopup2090103
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
            this.customQN = new Hms.Ui.CustomQN();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            this.pcBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            this.xtraScrollableControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Appearance.BackColor = System.Drawing.Color.White;
            this.pcBackGround.Appearance.Options.UseBackColor = true;
            this.pcBackGround.Controls.Add(this.xtraScrollableControl);
            this.pcBackGround.Size = new System.Drawing.Size(1141, 589);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // xtraScrollableControl
            // 
            this.xtraScrollableControl.Appearance.BackColor = System.Drawing.Color.Gray;
            this.xtraScrollableControl.Appearance.Options.UseBackColor = true;
            this.xtraScrollableControl.Controls.Add(this.customQN);
            this.xtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl.Location = new System.Drawing.Point(2, 2);
            this.xtraScrollableControl.Name = "xtraScrollableControl";
            this.xtraScrollableControl.Size = new System.Drawing.Size(1137, 585);
            this.xtraScrollableControl.TabIndex = 1;
            // 
            // customQN
            // 
            this.customQN.BackColor = System.Drawing.Color.White;
            this.customQN.Location = new System.Drawing.Point(16, 20);
            this.customQN.Name = "customQN";
            this.customQN.QnVo = null;
            this.customQN.Size = new System.Drawing.Size(1068, 32);
            this.customQN.TabIndex = 0;
            // 
            // frmPopup2090103
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 589);
            this.Name = "frmPopup2090103";
            this.Text = "问卷预览";
            this.Load += new System.EventHandler(this.frmPopup2090103_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).EndInit();
            this.pcBackGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            this.xtraScrollableControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomQN customQN;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl;
    }
}