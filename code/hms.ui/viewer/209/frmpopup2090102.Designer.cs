namespace Hms.Ui
{
    partial class frmPopup2090102
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopup2090102));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtQnName = new DevExpress.XtraEditors.TextEdit();
            this.txtQnDesc = new DevExpress.XtraEditors.TextEdit();
            this.cboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.className = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.fieldId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qnDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.blbiSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiPrint = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiExport = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiClose = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            this.pcBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQnName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQnDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcBackGround.Appearance.Options.UseFont = true;
            this.pcBackGround.Controls.Add(this.labelControl3);
            this.pcBackGround.Controls.Add(this.cboStatus);
            this.pcBackGround.Controls.Add(this.txtQnDesc);
            this.pcBackGround.Controls.Add(this.txtQnName);
            this.pcBackGround.Controls.Add(this.labelControl2);
            this.pcBackGround.Controls.Add(this.labelControl1);
            this.pcBackGround.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcBackGround.Location = new System.Drawing.Point(0, 60);
            this.pcBackGround.Size = new System.Drawing.Size(829, 72);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 12);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "问卷名称:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 12);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "问卷说明:";
            // 
            // txtQnName
            // 
            this.txtQnName.EnterMoveNextControl = true;
            this.txtQnName.Location = new System.Drawing.Point(76, 12);
            this.txtQnName.Name = "txtQnName";
            this.txtQnName.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQnName.Properties.Appearance.Options.UseFont = true;
            this.txtQnName.Size = new System.Drawing.Size(548, 20);
            this.txtQnName.TabIndex = 1;
            // 
            // txtQnDesc
            // 
            this.txtQnDesc.EnterMoveNextControl = true;
            this.txtQnDesc.Location = new System.Drawing.Point(76, 42);
            this.txtQnDesc.Name = "txtQnDesc";
            this.txtQnDesc.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQnDesc.Properties.Appearance.Options.UseFont = true;
            this.txtQnDesc.Size = new System.Drawing.Size(716, 20);
            this.txtQnDesc.TabIndex = 3;
            // 
            // cboStatus
            // 
            this.cboStatus.EnterMoveNextControl = true;
            this.cboStatus.Location = new System.Drawing.Point(692, 12);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F);
            this.cboStatus.Properties.Appearance.Options.UseFont = true;
            this.cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStatus.Properties.DropDownItemHeight = 26;
            this.cboStatus.Properties.Items.AddRange(new object[] {
            "停用",
            "启用"});
            this.cboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboStatus.Size = new System.Drawing.Size(100, 20);
            this.cboStatus.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(635, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 12);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "是否启用:";
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 132);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemCheckEdit1});
            this.gridControl.Size = new System.Drawing.Size(829, 406);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.GroupPanel.Font = new System.Drawing.Font("宋体", 9F);
            this.gridView.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView.Appearance.Preview.Font = new System.Drawing.Font("宋体", 9F);
            this.gridView.Appearance.Preview.Options.UseFont = true;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("宋体", 9F);
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.fieldName,
            this.className,
            this.isCheck,
            this.fieldId,
            this.qnDesc});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 1;
            this.gridView.GroupFormat = "[#image]{1} {2}";
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView.OptionsDetail.EnableMasterViewMode = false;
            this.gridView.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.gridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.OptionsView.ShowPreview = true;
            this.gridView.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.PreviewFieldName = "qnDesc";
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.className, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // fieldName
            // 
            this.fieldName.Caption = "题目";
            this.fieldName.FieldName = "fieldName";
            this.fieldName.Name = "fieldName";
            this.fieldName.OptionsColumn.AllowEdit = false;
            this.fieldName.OptionsColumn.AllowFocus = false;
            this.fieldName.OptionsFilter.AllowAutoFilter = false;
            this.fieldName.OptionsFilter.AllowFilter = false;
            this.fieldName.Visible = true;
            this.fieldName.VisibleIndex = 1;
            this.fieldName.Width = 745;
            // 
            // className
            // 
            this.className.Caption = "分类";
            this.className.FieldName = "className";
            this.className.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText;
            this.className.Name = "className";
            this.className.OptionsColumn.AllowEdit = false;
            this.className.OptionsColumn.AllowFocus = false;
            this.className.OptionsFilter.AllowAutoFilter = false;
            this.className.OptionsFilter.AllowFilter = false;
            this.className.Visible = true;
            this.className.VisibleIndex = 0;
            // 
            // isCheck
            // 
            this.isCheck.AppearanceHeader.Options.UseTextOptions = true;
            this.isCheck.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isCheck.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.isCheck.Caption = "√";
            this.isCheck.ColumnEdit = this.repositoryItemCheckEdit1;
            this.isCheck.FieldName = "isCheck";
            this.isCheck.Name = "isCheck";
            this.isCheck.OptionsColumn.AllowSize = false;
            this.isCheck.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.isCheck.OptionsColumn.FixedWidth = true;
            this.isCheck.OptionsFilter.AllowAutoFilter = false;
            this.isCheck.OptionsFilter.AllowFilter = false;
            this.isCheck.Visible = true;
            this.isCheck.VisibleIndex = 0;
            this.isCheck.Width = 28;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // fieldId
            // 
            this.fieldId.Caption = "备注";
            this.fieldId.FieldName = "fieldId";
            this.fieldId.Name = "fieldId";
            this.fieldId.OptionsColumn.AllowEdit = false;
            this.fieldId.OptionsColumn.AllowFocus = false;
            this.fieldId.OptionsFilter.AllowAutoFilter = false;
            this.fieldId.OptionsFilter.AllowFilter = false;
            this.fieldId.Width = 714;
            // 
            // qnDesc
            // 
            this.qnDesc.Caption = "说明";
            this.qnDesc.ColumnEdit = this.repositoryItemMemoEdit1;
            this.qnDesc.FieldName = "qnDesc";
            this.qnDesc.Name = "qnDesc";
            this.qnDesc.OptionsColumn.AllowEdit = false;
            this.qnDesc.OptionsColumn.AllowFocus = false;
            this.qnDesc.OptionsFilter.AllowAutoFilter = false;
            this.qnDesc.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
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
            this.blbiPrint,
            this.blbiExport,
            this.blbiClose});
            this.barManager.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Disabled.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Disabled.Options.UseFont = true;
            this.bar1.BarAppearance.Hovered.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Hovered.Options.UseFont = true;
            this.bar1.BarAppearance.Normal.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Normal.Options.UseFont = true;
            this.bar1.BarAppearance.Pressed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Pressed.Options.UseFont = true;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiPrint, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.blbiExport, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // blbiPrint
            // 
            this.blbiPrint.Caption = "打印";
            this.blbiPrint.Id = 1;
            this.blbiPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("blbiPrint.ImageOptions.Image")));
            this.blbiPrint.Name = "blbiPrint";
            this.blbiPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiPrint_ItemClick);
            // 
            // blbiExport
            // 
            this.blbiExport.Caption = "导出";
            this.blbiExport.Id = 2;
            this.blbiExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("blbiExport.ImageOptions.Image")));
            this.blbiExport.Name = "blbiExport";
            this.blbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiExport_ItemClick);
            // 
            // blbiClose
            // 
            this.blbiClose.Caption = "返回";
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
            this.barDockControlTop.Size = new System.Drawing.Size(829, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 538);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(829, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(829, 60);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
            // 
            // frmPopup2090102
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 538);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPopup2090102";
            this.Text = "自定义问卷";
            this.Load += new System.EventHandler(this.frmPopup2090102_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.marqueeProgressBarControl, 0);
            this.Controls.SetChildIndex(this.pcBackGround, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).EndInit();
            this.pcBackGround.ResumeLayout(false);
            this.pcBackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQnName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQnDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtQnDesc;
        private DevExpress.XtraEditors.TextEdit txtQnName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cboStatus;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn fieldName;
        private DevExpress.XtraGrid.Columns.GridColumn className;
        private DevExpress.XtraGrid.Columns.GridColumn isCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn fieldId;
        private DevExpress.XtraGrid.Columns.GridColumn qnDesc;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem blbiSave;
        private DevExpress.XtraBars.BarLargeButtonItem blbiPrint;
        private DevExpress.XtraBars.BarLargeButtonItem blbiExport;
        private DevExpress.XtraBars.BarLargeButtonItem blbiClose;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}