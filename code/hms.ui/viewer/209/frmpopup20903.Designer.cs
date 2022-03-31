namespace Hms.Ui
{
    partial class frmPopup20903
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopup20903));
            this.cboClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSortNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSuggest = new DevExpress.XtraEditors.MemoEdit();
            this.txtHazards = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTopic = new DevExpress.XtraEditors.LabelControl();
            this.lueTopic = new Common.Controls.LookUpEdit();
            this.lueField = new Common.Controls.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.blbiSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            this.pcBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuggest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHazards.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTopic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Controls.Add(this.lueField);
            this.pcBackGround.Controls.Add(this.labelControl8);
            this.pcBackGround.Controls.Add(this.lueTopic);
            this.pcBackGround.Controls.Add(this.lblTopic);
            this.pcBackGround.Controls.Add(this.cboClass);
            this.pcBackGround.Controls.Add(this.labelControl6);
            this.pcBackGround.Controls.Add(this.txtSortNo);
            this.pcBackGround.Controls.Add(this.labelControl5);
            this.pcBackGround.Controls.Add(this.labelControl2);
            this.pcBackGround.Controls.Add(this.txtSuggest);
            this.pcBackGround.Controls.Add(this.txtHazards);
            this.pcBackGround.Controls.Add(this.labelControl1);
            this.pcBackGround.Location = new System.Drawing.Point(0, 60);
            this.pcBackGround.Size = new System.Drawing.Size(468, 430);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cboClass
            // 
            this.cboClass.EnterMoveNextControl = true;
            this.cboClass.Location = new System.Drawing.Point(68, 20);
            this.cboClass.Name = "cboClass";
            this.cboClass.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboClass.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.cboClass.Properties.Appearance.Options.UseFont = true;
            this.cboClass.Properties.Appearance.Options.UseForeColor = true;
            this.cboClass.Properties.AppearanceDropDown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboClass.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboClass.Properties.AppearanceFocused.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboClass.Properties.AppearanceFocused.Options.UseFont = true;
            this.cboClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClass.Properties.DropDownItemHeight = 23;
            this.cboClass.Properties.Items.AddRange(new object[] {
            "饮食",
            "运动",
            "吸烟情况",
            "饮酒情况",
            "心理及睡眠",
            "既往接触史"});
            this.cboClass.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboClass.Size = new System.Drawing.Size(216, 18);
            this.cboClass.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(8, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 12);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "分    类：";
            // 
            // txtSortNo
            // 
            this.txtSortNo.EnterMoveNextControl = true;
            this.txtSortNo.Location = new System.Drawing.Point(364, 20);
            this.txtSortNo.Name = "txtSortNo";
            this.txtSortNo.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.txtSortNo.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtSortNo.Properties.Appearance.Options.UseFont = true;
            this.txtSortNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtSortNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSortNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSortNo.Properties.Mask.EditMask = "####";
            this.txtSortNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSortNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSortNo.Size = new System.Drawing.Size(96, 20);
            this.txtSortNo.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(302, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 12);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "排序编号：";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 178);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 12);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "建议内容：";
            // 
            // txtSuggest
            // 
            this.txtSuggest.Location = new System.Drawing.Point(68, 174);
            this.txtSuggest.Name = "txtSuggest";
            this.txtSuggest.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.txtSuggest.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtSuggest.Properties.Appearance.Options.UseFont = true;
            this.txtSuggest.Properties.Appearance.Options.UseForeColor = true;
            this.txtSuggest.Size = new System.Drawing.Size(392, 240);
            this.txtSuggest.TabIndex = 6;
            // 
            // txtHazards
            // 
            this.txtHazards.EnterMoveNextControl = true;
            this.txtHazards.Location = new System.Drawing.Point(68, 57);
            this.txtHazards.Name = "txtHazards";
            this.txtHazards.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.txtHazards.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtHazards.Properties.Appearance.Options.UseFont = true;
            this.txtHazards.Properties.Appearance.Options.UseForeColor = true;
            this.txtHazards.Size = new System.Drawing.Size(392, 20);
            this.txtHazards.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 12);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "危险因素：";
            // 
            // lblTopic
            // 
            this.lblTopic.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Appearance.Options.UseFont = true;
            this.lblTopic.Location = new System.Drawing.Point(8, 99);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(60, 12);
            this.lblTopic.TabIndex = 33;
            this.lblTopic.Text = "题    目：";
            // 
            // lueTopic
            // 
            this.lueTopic.CellValueChanged = true;
            this.lueTopic.EditValue = "";
            this.lueTopic.IsButtonFind = false;
            this.lueTopic.Location = new System.Drawing.Point(68, 96);
            this.lueTopic.Name = "lueTopic";
            this.lueTopic.ParentBandedGridView = null;
            this.lueTopic.ParentBindingSource = null;
            this.lueTopic.ParentGridView = null;
            this.lueTopic.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.lueTopic.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lueTopic.Properties.Appearance.Options.UseFont = true;
            this.lueTopic.Properties.Appearance.Options.UseForeColor = true;
            this.lueTopic.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.lueTopic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTopic.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueTopic.Properties.DataSource = null;
            this.lueTopic.Properties.DBRow = null;
            this.lueTopic.Properties.DBValue = "";
            this.lueTopic.Properties.DescCode = null;
            this.lueTopic.Properties.DisplayColumn = null;
            this.lueTopic.Properties.DisplayValue = "";
            this.lueTopic.Properties.Essential = false;
            this.lueTopic.Properties.FieldName = null;
            this.lueTopic.Properties.FilterColumn = null;
            this.lueTopic.Properties.ForbidPoput = false;
            this.lueTopic.Properties.HideColumn = null;
            this.lueTopic.Properties.IsAutoPopup = false;
            this.lueTopic.Properties.IsCheckValid = true;
            this.lueTopic.Properties.IsDescField = false;
            this.lueTopic.Properties.IsFreeInput = false;
            this.lueTopic.Properties.IsHideValueColumn = false;
            this.lueTopic.Properties.IsSelectedMoveNextControl = false;
            this.lueTopic.Properties.IsShowColumnHeaders = false;
            this.lueTopic.Properties.IsShowDescInfo = false;
            this.lueTopic.Properties.IsShowRowNo = false;
            this.lueTopic.Properties.IsTab = true;
            this.lueTopic.Properties.IsUseShowColumn = false;
            this.lueTopic.Properties.ParentBandedGridView = null;
            this.lueTopic.Properties.ParentBindingSource = null;
            this.lueTopic.Properties.ParentGridView = null;
            this.lueTopic.Properties.PopupFormMinSize = new System.Drawing.Size(10, 10);
            this.lueTopic.Properties.PopupFormSize = new System.Drawing.Size(10, 10);
            this.lueTopic.Properties.PopupHeight = 0;
            this.lueTopic.Properties.PopupSizeable = false;
            this.lueTopic.Properties.PopupWidth = 0;
            this.lueTopic.Properties.PresentationMode = 0;
            this.lueTopic.Properties.ShowColumn = null;
            this.lueTopic.Properties.ShowPopupCloseButton = false;
            this.lueTopic.Properties.ShowPopupShadow = false;
            this.lueTopic.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueTopic.Properties.ValueColumn = null;
            this.lueTopic.Size = new System.Drawing.Size(392, 20);
            this.lueTopic.TabIndex = 4;
            this.lueTopic.HandleDBValueChanged += new Common.Controls._HandleDBValueChanged(this.lueTopic_HandleDBValueChanged);
            // 
            // lueField
            // 
            this.lueField.CellValueChanged = true;
            this.lueField.EditValue = "";
            this.lueField.IsButtonFind = false;
            this.lueField.Location = new System.Drawing.Point(68, 135);
            this.lueField.Name = "lueField";
            this.lueField.ParentBandedGridView = null;
            this.lueField.ParentBindingSource = null;
            this.lueField.ParentGridView = null;
            this.lueField.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.lueField.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lueField.Properties.Appearance.Options.UseFont = true;
            this.lueField.Properties.Appearance.Options.UseForeColor = true;
            this.lueField.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.lueField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueField.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueField.Properties.DataSource = null;
            this.lueField.Properties.DBRow = null;
            this.lueField.Properties.DBValue = "";
            this.lueField.Properties.DescCode = null;
            this.lueField.Properties.DisplayColumn = null;
            this.lueField.Properties.DisplayValue = "";
            this.lueField.Properties.Essential = false;
            this.lueField.Properties.FieldName = null;
            this.lueField.Properties.FilterColumn = null;
            this.lueField.Properties.ForbidPoput = false;
            this.lueField.Properties.HideColumn = null;
            this.lueField.Properties.IsAutoPopup = false;
            this.lueField.Properties.IsCheckValid = true;
            this.lueField.Properties.IsDescField = false;
            this.lueField.Properties.IsFreeInput = false;
            this.lueField.Properties.IsHideValueColumn = false;
            this.lueField.Properties.IsSelectedMoveNextControl = false;
            this.lueField.Properties.IsShowColumnHeaders = false;
            this.lueField.Properties.IsShowDescInfo = false;
            this.lueField.Properties.IsShowRowNo = false;
            this.lueField.Properties.IsTab = true;
            this.lueField.Properties.IsUseShowColumn = false;
            this.lueField.Properties.ParentBandedGridView = null;
            this.lueField.Properties.ParentBindingSource = null;
            this.lueField.Properties.ParentGridView = null;
            this.lueField.Properties.PopupFormMinSize = new System.Drawing.Size(10, 10);
            this.lueField.Properties.PopupFormSize = new System.Drawing.Size(10, 10);
            this.lueField.Properties.PopupHeight = 0;
            this.lueField.Properties.PopupSizeable = false;
            this.lueField.Properties.PopupWidth = 0;
            this.lueField.Properties.PresentationMode = 0;
            this.lueField.Properties.ShowColumn = null;
            this.lueField.Properties.ShowPopupCloseButton = false;
            this.lueField.Properties.ShowPopupShadow = false;
            this.lueField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueField.Properties.ValueColumn = null;
            this.lueField.Size = new System.Drawing.Size(392, 20);
            this.lueField.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(8, 138);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 12);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "选    项：";
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
            this.blbiSave,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // blbiSave
            // 
            this.blbiSave.Caption = "保存";
            this.blbiSave.Id = 0;
            this.blbiSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("blbiSave.ImageOptions.Image")));
            this.blbiSave.Name = "blbiSave";
            this.blbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiSave_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(468, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 490);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(468, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 430);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(468, 60);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 430);
            // 
            // frmPopup20903
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 490);
            this.ControlBox = false;
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPopup20903";
            this.Text = "危险因素";
            this.Load += new System.EventHandler(this.frmPopup2090105_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cboClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuggest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHazards.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTopic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ComboBoxEdit cboClass;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSortNo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtSuggest;
        private DevExpress.XtraEditors.TextEdit txtHazards;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Common.Controls.LookUpEdit lueField;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Common.Controls.LookUpEdit lueTopic;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem blbiSave;
        private DevExpress.XtraBars.BarLargeButtonItem blbiClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl lblTopic;
    }
}