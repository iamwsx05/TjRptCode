namespace Hms.Ui
{
    partial class frm20903
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
            this.hazards = new DevExpress.XtraGrid.Columns.GridColumn();
            this.className = new DevExpress.XtraGrid.Columns.GridColumn();
            this.suggest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.sortNo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl.Size = new System.Drawing.Size(800, 450);
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
            this.hazards,
            this.className,
            this.suggest,
            this.sortNo});
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
            // hazards
            // 
            this.hazards.AppearanceCell.Options.UseTextOptions = true;
            this.hazards.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.hazards.Caption = "危险因素";
            this.hazards.FieldName = "hazards";
            this.hazards.Name = "hazards";
            this.hazards.OptionsColumn.AllowEdit = false;
            this.hazards.OptionsColumn.AllowFocus = false;
            this.hazards.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.hazards.OptionsFilter.AllowAutoFilter = false;
            this.hazards.OptionsFilter.AllowFilter = false;
            this.hazards.Visible = true;
            this.hazards.VisibleIndex = 0;
            this.hazards.Width = 460;
            // 
            // className
            // 
            this.className.AppearanceCell.Options.UseTextOptions = true;
            this.className.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.className.Caption = "分类";
            this.className.FieldName = "className";
            this.className.Name = "className";
            this.className.OptionsColumn.AllowEdit = false;
            this.className.OptionsColumn.AllowFocus = false;
            this.className.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.className.Visible = true;
            this.className.VisibleIndex = 1;
            this.className.Width = 70;
            // 
            // suggest
            // 
            this.suggest.Caption = "建议";
            this.suggest.ColumnEdit = this.repositoryItemMemoEdit1;
            this.suggest.FieldName = "suggest";
            this.suggest.Name = "suggest";
            this.suggest.OptionsColumn.AllowEdit = false;
            this.suggest.OptionsColumn.AllowFocus = false;
            this.suggest.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.suggest.OptionsFilter.AllowAutoFilter = false;
            this.suggest.OptionsFilter.AllowFilter = false;
            this.suggest.Visible = true;
            this.suggest.VisibleIndex = 2;
            this.suggest.Width = 420;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // sortNo
            // 
            this.sortNo.AppearanceCell.Options.UseTextOptions = true;
            this.sortNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sortNo.Caption = "排序号";
            this.sortNo.FieldName = "sortNo";
            this.sortNo.Name = "sortNo";
            this.sortNo.OptionsColumn.AllowEdit = false;
            this.sortNo.OptionsColumn.AllowFocus = false;
            this.sortNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.sortNo.OptionsFilter.AllowAutoFilter = false;
            this.sortNo.OptionsFilter.AllowFilter = false;
            this.sortNo.Visible = true;
            this.sortNo.VisibleIndex = 3;
            this.sortNo.Width = 60;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // frm20903
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl);
            this.Name = "frm20903";
            this.Text = "危险因素库";
            this.Load += new System.EventHandler(this.frm20903_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn hazards;
        private DevExpress.XtraGrid.Columns.GridColumn className;
        private DevExpress.XtraGrid.Columns.GridColumn suggest;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn sortNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}