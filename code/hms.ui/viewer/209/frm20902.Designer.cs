namespace Hms.Ui
{
    partial class frm20902
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fieldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qnItemsDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.essentialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sortNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Location = new System.Drawing.Point(-224, 232);
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
            this.repositoryItemCheckEdit1});
            this.gridControl.Size = new System.Drawing.Size(967, 489);
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
            this.fieldName,
            this.qnItemsDesc,
            this.typeName,
            this.essentialName,
            this.statusName,
            this.sortNo});
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
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // fieldName
            // 
            this.fieldName.Caption = "题目名称";
            this.fieldName.FieldName = "fieldName";
            this.fieldName.Name = "fieldName";
            this.fieldName.OptionsColumn.AllowEdit = false;
            this.fieldName.OptionsColumn.AllowFocus = false;
            this.fieldName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.fieldName.OptionsFilter.AllowAutoFilter = false;
            this.fieldName.OptionsFilter.AllowFilter = false;
            this.fieldName.Visible = true;
            this.fieldName.VisibleIndex = 0;
            this.fieldName.Width = 374;
            // 
            // qnItemsDesc
            // 
            this.qnItemsDesc.Caption = "选项";
            this.qnItemsDesc.FieldName = "qnItemsDesc";
            this.qnItemsDesc.Name = "qnItemsDesc";
            this.qnItemsDesc.OptionsColumn.AllowEdit = false;
            this.qnItemsDesc.OptionsColumn.AllowFocus = false;
            this.qnItemsDesc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.qnItemsDesc.OptionsFilter.AllowAutoFilter = false;
            this.qnItemsDesc.OptionsFilter.AllowFilter = false;
            this.qnItemsDesc.Visible = true;
            this.qnItemsDesc.VisibleIndex = 2;
            this.qnItemsDesc.Width = 540;
            // 
            // typeName
            // 
            this.typeName.AppearanceCell.Options.UseTextOptions = true;
            this.typeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.typeName.Caption = "题型";
            this.typeName.FieldName = "typeName";
            this.typeName.Name = "typeName";
            this.typeName.OptionsColumn.AllowEdit = false;
            this.typeName.OptionsColumn.AllowFocus = false;
            this.typeName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.typeName.OptionsFilter.AllowAutoFilter = false;
            this.typeName.OptionsFilter.AllowFilter = false;
            this.typeName.Visible = true;
            this.typeName.VisibleIndex = 1;
            this.typeName.Width = 70;
            // 
            // essentialName
            // 
            this.essentialName.AppearanceCell.Options.UseTextOptions = true;
            this.essentialName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.essentialName.Caption = "是否必填";
            this.essentialName.FieldName = "essentialName";
            this.essentialName.Name = "essentialName";
            this.essentialName.OptionsColumn.AllowEdit = false;
            this.essentialName.OptionsColumn.AllowFocus = false;
            this.essentialName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.essentialName.OptionsFilter.AllowAutoFilter = false;
            this.essentialName.OptionsFilter.AllowFilter = false;
            this.essentialName.Visible = true;
            this.essentialName.VisibleIndex = 3;
            this.essentialName.Width = 71;
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
            this.statusName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.statusName.OptionsFilter.AllowAutoFilter = false;
            this.statusName.OptionsFilter.AllowFilter = false;
            this.statusName.Visible = true;
            this.statusName.VisibleIndex = 4;
            this.statusName.Width = 68;
            // 
            // sortNo
            // 
            this.sortNo.AppearanceCell.Options.UseTextOptions = true;
            this.sortNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sortNo.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.sortNo.AppearanceHeader.Options.UseFont = true;
            this.sortNo.Caption = "排序号";
            this.sortNo.FieldName = "sortNo";
            this.sortNo.Name = "sortNo";
            this.sortNo.OptionsColumn.AllowEdit = false;
            this.sortNo.OptionsColumn.AllowFocus = false;
            this.sortNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.sortNo.OptionsFilter.AllowAutoFilter = false;
            this.sortNo.OptionsFilter.AllowFilter = false;
            this.sortNo.Visible = true;
            this.sortNo.VisibleIndex = 5;
            this.sortNo.Width = 58;
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
            // frm20902
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 489);
            this.Controls.Add(this.gridControl);
            this.Name = "frm20902";
            this.Text = "问卷题库";
            this.Load += new System.EventHandler(this.frm20902_Load);
            this.Controls.SetChildIndex(this.marqueeProgressBarControl, 0);
            this.Controls.SetChildIndex(this.pcBackGround, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn sortNo;
        private DevExpress.XtraGrid.Columns.GridColumn fieldName;
        private DevExpress.XtraGrid.Columns.GridColumn qnItemsDesc;
        private DevExpress.XtraGrid.Columns.GridColumn typeName;
        private DevExpress.XtraGrid.Columns.GridColumn essentialName;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn statusName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}