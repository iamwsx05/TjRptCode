namespace Hms.Ui
{
    partial class frmPopup2040901
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopup2040901));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.blbiSend = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtSender = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSendDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtReceiver = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSMSContent = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            this.pcBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMSContent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Controls.Add(this.labelControl5);
            this.pcBackGround.Controls.Add(this.txtSMSContent);
            this.pcBackGround.Controls.Add(this.txtTelNo);
            this.pcBackGround.Controls.Add(this.labelControl3);
            this.pcBackGround.Controls.Add(this.txtReceiver);
            this.pcBackGround.Controls.Add(this.labelControl4);
            this.pcBackGround.Controls.Add(this.txtSendDate);
            this.pcBackGround.Controls.Add(this.labelControl2);
            this.pcBackGround.Controls.Add(this.txtSender);
            this.pcBackGround.Controls.Add(this.labelControl1);
            this.pcBackGround.Location = new System.Drawing.Point(0, 60);
            this.pcBackGround.Size = new System.Drawing.Size(413, 384);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.blbiSend,
            this.blbiClose});
            this.barManager.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Disabled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Disabled.Options.UseFont = true;
            this.bar1.BarAppearance.Hovered.Font = new System.Drawing.Font("宋体", 9F);
            this.bar1.BarAppearance.Hovered.Options.UseFont = true;
            this.bar1.BarAppearance.Normal.Font = new System.Drawing.Font("宋体", 9F);
            this.bar1.BarAppearance.Normal.Options.UseFont = true;
            this.bar1.BarAppearance.Pressed.Font = new System.Drawing.Font("宋体", 9F);
            this.bar1.BarAppearance.Pressed.Options.UseFont = true;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiSend, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // blbiSend
            // 
            this.blbiSend.Caption = "发送";
            this.blbiSend.Id = 0;
            this.blbiSend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("blbiSend.ImageOptions.Image")));
            this.blbiSend.Name = "blbiSend";
            this.blbiSend.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiSend_ItemClick);
            // 
            // blbiClose
            // 
            this.blbiClose.Caption = "返回";
            this.blbiClose.Id = 1;
            this.blbiClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("blbiClose.ImageOptions.Image")));
            this.blbiClose.Name = "blbiClose";
            this.blbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(413, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(413, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 384);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(413, 60);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 384);
            // 
            // txtSender
            // 
            this.txtSender.EnterMoveNextControl = true;
            this.txtSender.Location = new System.Drawing.Point(72, 12);
            this.txtSender.Name = "txtSender";
            this.txtSender.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.txtSender.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtSender.Properties.Appearance.Options.UseFont = true;
            this.txtSender.Properties.Appearance.Options.UseForeColor = true;
            this.txtSender.Size = new System.Drawing.Size(128, 20);
            this.txtSender.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 12);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "发 送 人：";
            // 
            // txtSendDate
            // 
            this.txtSendDate.EnterMoveNextControl = true;
            this.txtSendDate.Location = new System.Drawing.Point(276, 12);
            this.txtSendDate.Name = "txtSendDate";
            this.txtSendDate.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.txtSendDate.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtSendDate.Properties.Appearance.Options.UseFont = true;
            this.txtSendDate.Properties.Appearance.Options.UseForeColor = true;
            this.txtSendDate.Size = new System.Drawing.Size(128, 20);
            this.txtSendDate.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(213, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 12);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "发送时间：";
            // 
            // txtTelNo
            // 
            this.txtTelNo.EnterMoveNextControl = true;
            this.txtTelNo.Location = new System.Drawing.Point(276, 44);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.txtTelNo.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtTelNo.Properties.Appearance.Options.UseFont = true;
            this.txtTelNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtTelNo.Size = new System.Drawing.Size(128, 20);
            this.txtTelNo.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(213, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 12);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "电话号码：";
            // 
            // txtReceiver
            // 
            this.txtReceiver.EnterMoveNextControl = true;
            this.txtReceiver.Location = new System.Drawing.Point(72, 44);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.txtReceiver.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtReceiver.Properties.Appearance.Options.UseFont = true;
            this.txtReceiver.Properties.Appearance.Options.UseForeColor = true;
            this.txtReceiver.Size = new System.Drawing.Size(128, 20);
            this.txtReceiver.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 12);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "接 收 人：";
            // 
            // txtSMSContent
            // 
            this.txtSMSContent.Location = new System.Drawing.Point(72, 78);
            this.txtSMSContent.MenuManager = this.barManager;
            this.txtSMSContent.Name = "txtSMSContent";
            this.txtSMSContent.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.txtSMSContent.Properties.Appearance.Options.UseFont = true;
            this.txtSMSContent.Size = new System.Drawing.Size(332, 298);
            this.txtSMSContent.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(9, 80);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 12);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "短信内容：";
            // 
            // frmPopup2040901
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 444);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPopup2040901";
            this.Text = "短信";
            this.Load += new System.EventHandler(this.frmPopup2040901_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.marqueeProgressBarControl, 0);
            this.Controls.SetChildIndex(this.pcBackGround, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).EndInit();
            this.pcBackGround.ResumeLayout(false);
            this.pcBackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMSContent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem blbiSend;
        private DevExpress.XtraBars.BarLargeButtonItem blbiClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtSMSContent;
        private DevExpress.XtraEditors.TextEdit txtTelNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtReceiver;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSendDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSender;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}