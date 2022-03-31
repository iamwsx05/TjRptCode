namespace Hms.Ui
{
    partial class frmPopup21002
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopup21002));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.blbiAdd = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiDel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboSuitGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboSuitPersons = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboSuitSeason = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboTypeName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSmsContent = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            this.pcBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSuitGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSuitPersons.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSuitSeason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSmsContent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Controls.Add(this.txtSmsContent);
            this.pcBackGround.Controls.Add(this.labelControl5);
            this.pcBackGround.Controls.Add(this.cboTypeName);
            this.pcBackGround.Controls.Add(this.cboSuitSeason);
            this.pcBackGround.Controls.Add(this.cboSuitPersons);
            this.pcBackGround.Controls.Add(this.cboSuitGender);
            this.pcBackGround.Controls.Add(this.labelControl4);
            this.pcBackGround.Controls.Add(this.labelControl3);
            this.pcBackGround.Controls.Add(this.labelControl2);
            this.pcBackGround.Controls.Add(this.labelControl1);
            this.pcBackGround.Location = new System.Drawing.Point(0, 60);
            this.pcBackGround.Size = new System.Drawing.Size(435, 330);
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
            this.blbiAdd,
            this.blbiDel,
            this.blbiSave,
            this.blbiClose});
            this.barManager.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Disabled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Disabled.Options.UseFont = true;
            this.bar1.BarAppearance.Hovered.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiAdd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiDel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // blbiAdd
            // 
            this.blbiAdd.Caption = "添加";
            this.blbiAdd.Id = 0;
            this.blbiAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("blbiAdd.ImageOptions.Image")));
            this.blbiAdd.Name = "blbiAdd";
            this.blbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiAdd_ItemClick);
            // 
            // blbiDel
            // 
            this.blbiDel.Caption = "删除";
            this.blbiDel.Id = 1;
            this.blbiDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("blbiDel.ImageOptions.Image")));
            this.blbiDel.Name = "blbiDel";
            this.blbiDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiDel_ItemClick);
            // 
            // blbiSave
            // 
            this.blbiSave.Caption = "保存";
            this.blbiSave.Id = 2;
            this.blbiSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("blbiSave.ImageOptions.Image")));
            this.blbiSave.Name = "blbiSave";
            this.blbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiSave_ItemClick);
            // 
            // blbiClose
            // 
            this.blbiClose.Caption = "关闭";
            this.blbiClose.Id = 3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(435, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 390);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(435, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 330);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(435, 60);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 330);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 12);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "短信类型：";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(227, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 12);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "适宜性别：";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 12);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "适宜人群：";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(227, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 12);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "适宜季节：";
            // 
            // cboSuitGender
            // 
            this.cboSuitGender.EnterMoveNextControl = true;
            this.cboSuitGender.Location = new System.Drawing.Point(289, 12);
            this.cboSuitGender.MenuManager = this.barManager;
            this.cboSuitGender.Name = "cboSuitGender";
            this.cboSuitGender.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitGender.Properties.Appearance.Options.UseFont = true;
            this.cboSuitGender.Properties.AppearanceDisabled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitGender.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cboSuitGender.Properties.AppearanceDropDown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitGender.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboSuitGender.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitGender.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cboSuitGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSuitGender.Properties.DropDownItemHeight = 23;
            this.cboSuitGender.Properties.Items.AddRange(new object[] {
            "不限",
            "男",
            "女"});
            this.cboSuitGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSuitGender.Size = new System.Drawing.Size(140, 18);
            this.cboSuitGender.TabIndex = 2;
            // 
            // cboSuitPersons
            // 
            this.cboSuitPersons.EnterMoveNextControl = true;
            this.cboSuitPersons.Location = new System.Drawing.Point(69, 44);
            this.cboSuitPersons.MenuManager = this.barManager;
            this.cboSuitPersons.Name = "cboSuitPersons";
            this.cboSuitPersons.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitPersons.Properties.Appearance.Options.UseFont = true;
            this.cboSuitPersons.Properties.AppearanceDisabled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitPersons.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cboSuitPersons.Properties.AppearanceDropDown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitPersons.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboSuitPersons.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitPersons.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cboSuitPersons.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSuitPersons.Properties.DropDownItemHeight = 23;
            this.cboSuitPersons.Properties.Items.AddRange(new object[] {
            "不限",
            "成人",
            "老人",
            "少儿"});
            this.cboSuitPersons.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSuitPersons.Size = new System.Drawing.Size(140, 18);
            this.cboSuitPersons.TabIndex = 3;
            // 
            // cboSuitSeason
            // 
            this.cboSuitSeason.EnterMoveNextControl = true;
            this.cboSuitSeason.Location = new System.Drawing.Point(289, 44);
            this.cboSuitSeason.MenuManager = this.barManager;
            this.cboSuitSeason.Name = "cboSuitSeason";
            this.cboSuitSeason.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitSeason.Properties.Appearance.Options.UseFont = true;
            this.cboSuitSeason.Properties.AppearanceDisabled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitSeason.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cboSuitSeason.Properties.AppearanceDropDown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitSeason.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboSuitSeason.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuitSeason.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cboSuitSeason.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSuitSeason.Properties.DropDownItemHeight = 23;
            this.cboSuitSeason.Properties.Items.AddRange(new object[] {
            "不限",
            "春",
            "夏",
            "秋",
            "冬"});
            this.cboSuitSeason.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSuitSeason.Size = new System.Drawing.Size(140, 18);
            this.cboSuitSeason.TabIndex = 4;
            // 
            // cboTypeName
            // 
            this.cboTypeName.EnterMoveNextControl = true;
            this.cboTypeName.Location = new System.Drawing.Point(69, 12);
            this.cboTypeName.MenuManager = this.barManager;
            this.cboTypeName.Name = "cboTypeName";
            this.cboTypeName.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeName.Properties.Appearance.Options.UseFont = true;
            this.cboTypeName.Properties.AppearanceDisabled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeName.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cboTypeName.Properties.AppearanceDropDown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeName.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboTypeName.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeName.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cboTypeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTypeName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTypeName.Size = new System.Drawing.Size(140, 18);
            this.cboTypeName.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(8, 77);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 12);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "模板内容：";
            // 
            // txtSmsContent
            // 
            this.txtSmsContent.Location = new System.Drawing.Point(69, 77);
            this.txtSmsContent.MenuManager = this.barManager;
            this.txtSmsContent.Name = "txtSmsContent";
            this.txtSmsContent.Size = new System.Drawing.Size(360, 240);
            this.txtSmsContent.TabIndex = 5;
            // 
            // frmPopup21002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 390);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPopup21002";
            this.Text = "短信模板";
            this.Load += new System.EventHandler(this.frmPopup21002_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cboSuitGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSuitPersons.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSuitSeason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSmsContent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtSmsContent;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem blbiAdd;
        private DevExpress.XtraBars.BarLargeButtonItem blbiDel;
        private DevExpress.XtraBars.BarLargeButtonItem blbiSave;
        private DevExpress.XtraBars.BarLargeButtonItem blbiClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboTypeName;
        private DevExpress.XtraEditors.ComboBoxEdit cboSuitSeason;
        private DevExpress.XtraEditors.ComboBoxEdit cboSuitPersons;
        private DevExpress.XtraEditors.ComboBoxEdit cboSuitGender;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}