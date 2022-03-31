namespace Hms.Ui
{
    partial class frm21001
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
            this.sportNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sportName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sportNumName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sportTimeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.metValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.announcements = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.sportTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.pcBackGround.Location = new System.Drawing.Point(-212, 232);
            this.pcBackGround.Size = new System.Drawing.Size(188, 40);
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
            this.gridControl.Size = new System.Drawing.Size(1161, 692);
            this.gridControl.TabIndex = 13;
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
            this.sportNo,
            this.sportName,
            this.sportNumName,
            this.sportTimeName,
            this.metValue,
            this.announcements,
            this.sportTypeName});
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 38;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.RowAutoHeight = true;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView_CustomDrawRowIndicator);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // sportNo
            // 
            this.sportNo.AppearanceCell.Options.UseTextOptions = true;
            this.sportNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sportNo.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.sportNo.AppearanceHeader.Options.UseFont = true;
            this.sportNo.Caption = "编号";
            this.sportNo.FieldName = "sportNo";
            this.sportNo.Name = "sportNo";
            this.sportNo.OptionsColumn.AllowEdit = false;
            this.sportNo.OptionsColumn.AllowFocus = false;
            this.sportNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.sportNo.OptionsFilter.AllowAutoFilter = false;
            this.sportNo.OptionsFilter.AllowFilter = false;
            this.sportNo.Visible = true;
            this.sportNo.VisibleIndex = 0;
            this.sportNo.Width = 79;
            // 
            // sportName
            // 
            this.sportName.AppearanceCell.Options.UseTextOptions = true;
            this.sportName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sportName.Caption = "运动名称";
            this.sportName.FieldName = "sportName";
            this.sportName.Name = "sportName";
            this.sportName.OptionsColumn.AllowEdit = false;
            this.sportName.OptionsColumn.AllowFocus = false;
            this.sportName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.sportName.OptionsFilter.AllowAutoFilter = false;
            this.sportName.OptionsFilter.AllowFilter = false;
            this.sportName.Visible = true;
            this.sportName.VisibleIndex = 1;
            this.sportName.Width = 230;
            // 
            // sportNumName
            // 
            this.sportNumName.AppearanceCell.Options.UseTextOptions = true;
            this.sportNumName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sportNumName.Caption = "运动类型";
            this.sportNumName.FieldName = "sportNumName";
            this.sportNumName.Name = "sportNumName";
            this.sportNumName.OptionsColumn.AllowEdit = false;
            this.sportNumName.OptionsColumn.AllowFocus = false;
            this.sportNumName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.sportNumName.Visible = true;
            this.sportNumName.VisibleIndex = 2;
            this.sportNumName.Width = 111;
            // 
            // sportTimeName
            // 
            this.sportTimeName.AppearanceCell.Options.UseTextOptions = true;
            this.sportTimeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sportTimeName.Caption = "运动强度";
            this.sportTimeName.FieldName = "sportTimeName";
            this.sportTimeName.Name = "sportTimeName";
            this.sportTimeName.OptionsColumn.AllowEdit = false;
            this.sportTimeName.OptionsColumn.AllowFocus = false;
            this.sportTimeName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.sportTimeName.OptionsFilter.AllowAutoFilter = false;
            this.sportTimeName.OptionsFilter.AllowFilter = false;
            this.sportTimeName.Visible = true;
            this.sportTimeName.VisibleIndex = 3;
            this.sportTimeName.Width = 96;
            // 
            // metValue
            // 
            this.metValue.AppearanceCell.Options.UseTextOptions = true;
            this.metValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.metValue.Caption = "代谢当量MET";
            this.metValue.FieldName = "metValue";
            this.metValue.Name = "metValue";
            this.metValue.OptionsColumn.AllowEdit = false;
            this.metValue.OptionsColumn.AllowFocus = false;
            this.metValue.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.metValue.OptionsFilter.AllowAutoFilter = false;
            this.metValue.OptionsFilter.AllowFilter = false;
            this.metValue.Visible = true;
            this.metValue.VisibleIndex = 4;
            this.metValue.Width = 87;
            // 
            // announcements
            // 
            this.announcements.Caption = "运动禁忌";
            this.announcements.ColumnEdit = this.repositoryItemMemoEdit1;
            this.announcements.FieldName = "announcements";
            this.announcements.Name = "announcements";
            this.announcements.OptionsColumn.AllowEdit = false;
            this.announcements.OptionsColumn.AllowFocus = false;
            this.announcements.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.announcements.OptionsFilter.AllowAutoFilter = false;
            this.announcements.OptionsFilter.AllowFilter = false;
            this.announcements.Visible = true;
            this.announcements.VisibleIndex = 5;
            this.announcements.Width = 384;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // sportTypeName
            // 
            this.sportTypeName.AppearanceCell.Options.UseTextOptions = true;
            this.sportTypeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sportTypeName.Caption = "运动分类";
            this.sportTypeName.FieldName = "sportTypeName";
            this.sportTypeName.Name = "sportTypeName";
            this.sportTypeName.OptionsColumn.AllowEdit = false;
            this.sportTypeName.OptionsColumn.AllowFocus = false;
            this.sportTypeName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.sportTypeName.Visible = true;
            this.sportTypeName.VisibleIndex = 6;
            this.sportTypeName.Width = 99;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // frm21001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 692);
            this.Controls.Add(this.gridControl);
            this.Name = "frm21001";
            this.Text = "运动库";
            this.Load += new System.EventHandler(this.frm21001_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn sportNo;
        private DevExpress.XtraGrid.Columns.GridColumn sportName;
        private DevExpress.XtraGrid.Columns.GridColumn sportNumName;
        private DevExpress.XtraGrid.Columns.GridColumn sportTimeName;
        private DevExpress.XtraGrid.Columns.GridColumn metValue;
        private DevExpress.XtraGrid.Columns.GridColumn announcements;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn sportTypeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}