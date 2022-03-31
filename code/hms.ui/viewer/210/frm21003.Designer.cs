namespace Hms.Ui
{
    partial class frm21003
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm21003));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.smsContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.suitGenderDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.suitPersonsDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.suitSeasonDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tvMsgType = new DevExpress.XtraTreeList.TreeList();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            this.pcBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvMsgType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Controls.Add(this.gridControl);
            this.pcBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcBackGround.Location = new System.Drawing.Point(220, 0);
            this.pcBackGround.Size = new System.Drawing.Size(1062, 669);
            this.pcBackGround.Visible = true;
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "r1.png");
            this.imageList.Images.SetKeyName(1, "r3.png");
            this.imageList.Images.SetKeyName(2, "r2.png");
            this.imageList.Images.SetKeyName(3, "orange.png");
            this.imageList.Images.SetKeyName(4, "green.png");
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemCheckEdit1});
            this.gridControl.Size = new System.Drawing.Size(1058, 665);
            this.gridControl.TabIndex = 14;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.GroupPanel.Font = new System.Drawing.Font("宋体", 9F);
            this.gridView.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 9.5F);
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("宋体", 9.5F);
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.ColumnPanelRowHeight = 26;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.smsContent,
            this.suitGenderDesc,
            this.suitPersonsDesc,
            this.suitSeasonDesc,
            this.typeName});
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 38;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.RowAutoHeight = true;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // smsContent
            // 
            this.smsContent.Caption = "主题";
            this.smsContent.FieldName = "smsContent";
            this.smsContent.Name = "smsContent";
            this.smsContent.OptionsColumn.AllowEdit = false;
            this.smsContent.OptionsColumn.AllowFocus = false;
            this.smsContent.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.smsContent.OptionsFilter.AllowAutoFilter = false;
            this.smsContent.OptionsFilter.AllowFilter = false;
            this.smsContent.Visible = true;
            this.smsContent.VisibleIndex = 0;
            this.smsContent.Width = 440;
            // 
            // suitGenderDesc
            // 
            this.suitGenderDesc.AppearanceCell.Options.UseTextOptions = true;
            this.suitGenderDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.suitGenderDesc.Caption = "适宜性别";
            this.suitGenderDesc.FieldName = "suitGenderDesc";
            this.suitGenderDesc.Name = "suitGenderDesc";
            this.suitGenderDesc.OptionsColumn.AllowEdit = false;
            this.suitGenderDesc.OptionsColumn.AllowFocus = false;
            this.suitGenderDesc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.suitGenderDesc.OptionsFilter.AllowAutoFilter = false;
            this.suitGenderDesc.OptionsFilter.AllowFilter = false;
            this.suitGenderDesc.Visible = true;
            this.suitGenderDesc.VisibleIndex = 1;
            this.suitGenderDesc.Width = 100;
            // 
            // suitPersonsDesc
            // 
            this.suitPersonsDesc.AppearanceCell.Options.UseTextOptions = true;
            this.suitPersonsDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.suitPersonsDesc.Caption = "适宜人群";
            this.suitPersonsDesc.FieldName = "suitPersonsDesc";
            this.suitPersonsDesc.Name = "suitPersonsDesc";
            this.suitPersonsDesc.OptionsColumn.AllowEdit = false;
            this.suitPersonsDesc.OptionsColumn.AllowFocus = false;
            this.suitPersonsDesc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.suitPersonsDesc.OptionsFilter.AllowAutoFilter = false;
            this.suitPersonsDesc.OptionsFilter.AllowFilter = false;
            this.suitPersonsDesc.Visible = true;
            this.suitPersonsDesc.VisibleIndex = 2;
            this.suitPersonsDesc.Width = 100;
            // 
            // suitSeasonDesc
            // 
            this.suitSeasonDesc.AppearanceCell.Options.UseTextOptions = true;
            this.suitSeasonDesc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.suitSeasonDesc.Caption = "适宜季节";
            this.suitSeasonDesc.FieldName = "suitSeasonDesc";
            this.suitSeasonDesc.Name = "suitSeasonDesc";
            this.suitSeasonDesc.OptionsColumn.AllowEdit = false;
            this.suitSeasonDesc.OptionsColumn.AllowFocus = false;
            this.suitSeasonDesc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.suitSeasonDesc.OptionsFilter.AllowAutoFilter = false;
            this.suitSeasonDesc.OptionsFilter.AllowFilter = false;
            this.suitSeasonDesc.Visible = true;
            this.suitSeasonDesc.VisibleIndex = 3;
            this.suitSeasonDesc.Width = 100;
            // 
            // typeName
            // 
            this.typeName.AppearanceCell.Options.UseTextOptions = true;
            this.typeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.typeName.Caption = "文章类型";
            this.typeName.FieldName = "typeName";
            this.typeName.Name = "typeName";
            this.typeName.OptionsColumn.AllowEdit = false;
            this.typeName.OptionsColumn.AllowFocus = false;
            this.typeName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.typeName.OptionsFilter.AllowAutoFilter = false;
            this.typeName.OptionsFilter.AllowFilter = false;
            this.typeName.Visible = true;
            this.typeName.VisibleIndex = 4;
            this.typeName.Width = 150;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // tvMsgType
            // 
            this.tvMsgType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMsgType.Location = new System.Drawing.Point(0, 0);
            this.tvMsgType.Margin = new System.Windows.Forms.Padding(0);
            this.tvMsgType.Name = "tvMsgType";
            this.tvMsgType.OptionsBehavior.AllowExpandOnDblClick = false;
            this.tvMsgType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.tvMsgType.OptionsSelection.UseIndicatorForSelection = true;
            this.tvMsgType.OptionsView.ShowColumns = false;
            this.tvMsgType.OptionsView.ShowHorzLines = false;
            this.tvMsgType.OptionsView.ShowIndicator = false;
            this.tvMsgType.OptionsView.ShowVertLines = false;
            this.tvMsgType.RowHeight = 22;
            this.tvMsgType.SelectImageList = this.imageList;
            this.tvMsgType.Size = new System.Drawing.Size(211, 640);
            this.tvMsgType.StateImageList = this.imageList;
            this.tvMsgType.TabIndex = 1;
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.MenuManager = this.barManager;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dockPanel
            // 
            this.dockPanel.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockPanel.Appearance.Options.UseFont = true;
            this.dockPanel.Controls.Add(this.dockPanel1_Container);
            this.dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel.ID = new System.Guid("51ea4d74-1280-41e9-8713-4bc6be2ac6ba");
            this.dockPanel.Location = new System.Drawing.Point(0, 0);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Options.ShowCloseButton = false;
            this.dockPanel.OriginalSize = new System.Drawing.Size(220, 200);
            this.dockPanel.Size = new System.Drawing.Size(220, 669);
            this.dockPanel.Text = "宣教分类";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.tvMsgType);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(211, 640);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // frm21003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 669);
            this.Controls.Add(this.dockPanel);
            this.Name = "frm21003";
            this.Text = "宣教文章库";
            this.Load += new System.EventHandler(this.frm21003_Load);
            this.Controls.SetChildIndex(this.dockPanel, 0);
            this.Controls.SetChildIndex(this.marqueeProgressBarControl, 0);
            this.Controls.SetChildIndex(this.pcBackGround, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).EndInit();
            this.pcBackGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvMsgType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ImageList imageList;
        internal DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn smsContent;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn suitGenderDesc;
        private DevExpress.XtraGrid.Columns.GridColumn suitPersonsDesc;
        private DevExpress.XtraGrid.Columns.GridColumn suitSeasonDesc;
        private DevExpress.XtraGrid.Columns.GridColumn typeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        internal DevExpress.XtraTreeList.TreeList tvMsgType;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
    }
}