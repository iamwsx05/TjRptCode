namespace Console.Ui
{
    partial class frmPassWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassWord));
            this.xtraPanelControl1 = new Common.Controls.xtraPanelControl();
            this.btnClose = new Common.Controls.xtraSimpleButton();
            this.btnOK = new Common.Controls.xtraSimpleButton();
            this.txtConfrimPW = new Common.Controls.xtraTextEdit();
            this.txtNewPW = new Common.Controls.xtraTextEdit();
            this.txtOldPW = new Common.Controls.xtraTextEdit();
            this.txtEmpNo = new Common.Controls.xtraTextEdit();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtraPanelControl1)).BeginInit();
            this.xtraPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfrimPW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraPanelControl1
            // 
            this.xtraPanelControl1.Controls.Add(this.btnClose);
            this.xtraPanelControl1.Controls.Add(this.btnOK);
            this.xtraPanelControl1.Controls.Add(this.txtConfrimPW);
            this.xtraPanelControl1.Controls.Add(this.txtNewPW);
            this.xtraPanelControl1.Controls.Add(this.txtOldPW);
            this.xtraPanelControl1.Controls.Add(this.txtEmpNo);
            this.xtraPanelControl1.Controls.Add(this.lblMsg);
            this.xtraPanelControl1.Controls.Add(this.pictureBox1);
            this.xtraPanelControl1.Controls.Add(this.label5);
            this.xtraPanelControl1.Controls.Add(this.label4);
            this.xtraPanelControl1.Controls.Add(this.label2);
            this.xtraPanelControl1.Controls.Add(this.label3);
            this.xtraPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraPanelControl1.Name = "xtraPanelControl1";
            this.xtraPanelControl1.Size = new System.Drawing.Size(334, 212);
            this.xtraPanelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("宋体", 9F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(184, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("宋体", 9F);
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(81, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 23);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "保存(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtConfrimPW
            // 
            this.txtConfrimPW.Location = new System.Drawing.Point(126, 125);
            this.txtConfrimPW.Name = "txtConfrimPW";
            this.txtConfrimPW.Properties.PasswordChar = '●';
            this.txtConfrimPW.Size = new System.Drawing.Size(196, 20);
            this.txtConfrimPW.TabIndex = 23;
            // 
            // txtNewPW
            // 
            this.txtNewPW.Location = new System.Drawing.Point(126, 91);
            this.txtNewPW.Name = "txtNewPW";
            this.txtNewPW.Properties.PasswordChar = '●';
            this.txtNewPW.Size = new System.Drawing.Size(196, 20);
            this.txtNewPW.TabIndex = 22;
            // 
            // txtOldPW
            // 
            this.txtOldPW.Location = new System.Drawing.Point(126, 57);
            this.txtOldPW.Name = "txtOldPW";
            this.txtOldPW.Properties.PasswordChar = '●';
            this.txtOldPW.Size = new System.Drawing.Size(196, 20);
            this.txtOldPW.TabIndex = 21;
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(126, 23);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(196, 20);
            this.txtEmpNo.TabIndex = 20;
            // 
            // lblMsg
            // 
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(2, 194);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(330, 16);
            this.lblMsg.TabIndex = 19;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9.5F);
            this.label5.Location = new System.Drawing.Point(56, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "确认密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9.5F);
            this.label4.Location = new System.Drawing.Point(69, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9.5F);
            this.label2.Location = new System.Drawing.Point(82, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9.5F);
            this.label3.Location = new System.Drawing.Point(69, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "原密码：";
            // 
            // frmPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 212);
            this.Controls.Add(this.xtraPanelControl1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPassWord";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.frmPassWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraPanelControl1)).EndInit();
            this.xtraPanelControl1.ResumeLayout(false);
            this.xtraPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfrimPW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Controls.xtraPanelControl xtraPanelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Common.Controls.xtraSimpleButton btnClose;
        private Common.Controls.xtraSimpleButton btnOK;
        private Common.Controls.xtraTextEdit txtConfrimPW;
        private Common.Controls.xtraTextEdit txtNewPW;
        private Common.Controls.xtraTextEdit txtOldPW;
        private Common.Controls.xtraTextEdit txtEmpNo;
        private System.Windows.Forms.Label lblMsg;
    }
}