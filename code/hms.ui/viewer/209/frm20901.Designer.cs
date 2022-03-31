namespace Hms.Ui
{
    partial class frm20901
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm20901));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.qnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.className = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hazardFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.creatDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Location = new System.Drawing.Point(12, 336);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.barManager;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemImageComboBox1});
            this.gridControl.Size = new System.Drawing.Size(858, 450);
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
            this.qnName,
            this.className,
            this.statusName,
            this.hazardFlag,
            this.creatDate});
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 38;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.RowAutoHeight = true;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowHeight = 26;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // qnName
            // 
            this.qnName.AppearanceCell.Options.UseTextOptions = true;
            this.qnName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.qnName.Caption = "问卷名称";
            this.qnName.FieldName = "qnName";
            this.qnName.Name = "qnName";
            this.qnName.OptionsColumn.AllowEdit = false;
            this.qnName.OptionsColumn.AllowFocus = false;
            this.qnName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.qnName.OptionsFilter.AllowAutoFilter = false;
            this.qnName.OptionsFilter.AllowFilter = false;
            this.qnName.Visible = true;
            this.qnName.VisibleIndex = 0;
            this.qnName.Width = 414;
            // 
            // className
            // 
            this.className.AppearanceCell.Options.UseTextOptions = true;
            this.className.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.className.Caption = "问卷类型";
            this.className.FieldName = "className";
            this.className.Name = "className";
            this.className.OptionsColumn.AllowEdit = false;
            this.className.OptionsColumn.AllowFocus = false;
            this.className.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.className.OptionsFilter.AllowAutoFilter = false;
            this.className.OptionsFilter.AllowFilter = false;
            this.className.Visible = true;
            this.className.VisibleIndex = 1;
            this.className.Width = 100;
            // 
            // statusName
            // 
            this.statusName.AppearanceCell.Options.UseTextOptions = true;
            this.statusName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.statusName.Caption = "是否启用";
            this.statusName.FieldName = "statusName";
            this.statusName.Name = "statusName";
            this.statusName.OptionsColumn.AllowEdit = false;
            this.statusName.OptionsColumn.AllowFocus = false;
            this.statusName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.statusName.OptionsFilter.AllowAutoFilter = false;
            this.statusName.OptionsFilter.AllowFilter = false;
            this.statusName.Visible = true;
            this.statusName.VisibleIndex = 2;
            this.statusName.Width = 69;
            // 
            // hazardFlag
            // 
            this.hazardFlag.AppearanceCell.Options.UseTextOptions = true;
            this.hazardFlag.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hazardFlag.Caption = "配置危险因素";
            this.hazardFlag.ColumnEdit = this.repositoryItemImageComboBox1;
            this.hazardFlag.FieldName = "hazardFlag";
            this.hazardFlag.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.hazardFlag.Name = "hazardFlag";
            this.hazardFlag.OptionsColumn.AllowEdit = false;
            this.hazardFlag.OptionsColumn.AllowFocus = false;
            this.hazardFlag.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.hazardFlag.OptionsFilter.AllowAutoFilter = false;
            this.hazardFlag.OptionsFilter.AllowFilter = false;
            this.hazardFlag.Visible = true;
            this.hazardFlag.VisibleIndex = 3;
            this.hazardFlag.Width = 101;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollection;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageSize = new System.Drawing.Size(13, 13);
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("linestyle_16x16.png", "images/analysis/linestyle_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/analysis/linestyle_16x16.png"), 0);
            this.imageCollection.Images.SetKeyName(0, "linestyle_16x16.png");
            this.imageCollection.InsertGalleryImage("managerules_16x16.png", "images/conditional%20formatting/managerules_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/conditional%20formatting/managerules_16x16.png"), 1);
            this.imageCollection.Images.SetKeyName(1, "managerules_16x16.png");
            this.imageCollection.InsertGalleryImage("feature_16x16.png", "images/support/feature_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/feature_16x16.png"), 2);
            this.imageCollection.Images.SetKeyName(2, "feature_16x16.png");
            this.imageCollection.InsertGalleryImage("richtext_16x16.png", "images/toolbox%20items/richtext_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/toolbox%20items/richtext_16x16.png"), 3);
            this.imageCollection.Images.SetKeyName(3, "richtext_16x16.png");
            // 
            // creatDate
            // 
            this.creatDate.AppearanceCell.Options.UseTextOptions = true;
            this.creatDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.creatDate.Caption = "创建时间";
            this.creatDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.creatDate.FieldName = "creatDate";
            this.creatDate.Name = "creatDate";
            this.creatDate.OptionsColumn.AllowEdit = false;
            this.creatDate.OptionsColumn.AllowFocus = false;
            this.creatDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.creatDate.OptionsFilter.AllowAutoFilter = false;
            this.creatDate.OptionsFilter.AllowFilter = false;
            this.creatDate.Visible = true;
            this.creatDate.VisibleIndex = 4;
            this.creatDate.Width = 143;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "yyyy-MM-dd HH:mm";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
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
            // frm20901
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.gridControl);
            this.Name = "frm20901";
            this.Text = "自定义量表设置";
            this.Load += new System.EventHandler(this.frm20901_Load);
            this.Controls.SetChildIndex(this.marqueeProgressBarControl, 0);
            this.Controls.SetChildIndex(this.pcBackGround, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn qnName;
        private DevExpress.XtraGrid.Columns.GridColumn className;
        private DevExpress.XtraGrid.Columns.GridColumn statusName;
        private DevExpress.XtraGrid.Columns.GridColumn hazardFlag;
        private DevExpress.XtraGrid.Columns.GridColumn creatDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        internal DevExpress.Utils.ImageCollection imageCollection;
    }
}