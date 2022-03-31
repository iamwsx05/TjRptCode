namespace Hms.Ui
{
    partial class frm21006
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
            this.模型名称 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.评估疾病 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.性别 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.年龄范围 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.介绍及说明 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            this.pcBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Controls.Add(this.gridControl);
            this.pcBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcBackGround.Location = new System.Drawing.Point(0, 0);
            this.pcBackGround.Size = new System.Drawing.Size(800, 450);
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
            this.gridControl.Size = new System.Drawing.Size(796, 446);
            this.gridControl.TabIndex = 16;
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
            this.模型名称,
            this.评估疾病,
            this.性别,
            this.年龄范围,
            this.介绍及说明});
            this.gridView.GridControl = this.gridControl;
            this.gridView.IndicatorWidth = 38;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsView.RowAutoHeight = true;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // 模型名称
            // 
            this.模型名称.AppearanceCell.Options.UseTextOptions = true;
            this.模型名称.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.模型名称.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.模型名称.AppearanceHeader.Options.UseFont = true;
            this.模型名称.Caption = "模型名称";
            this.模型名称.FieldName = "sportNo";
            this.模型名称.Name = "模型名称";
            this.模型名称.OptionsColumn.AllowEdit = false;
            this.模型名称.OptionsColumn.AllowFocus = false;
            this.模型名称.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.模型名称.OptionsFilter.AllowAutoFilter = false;
            this.模型名称.OptionsFilter.AllowFilter = false;
            this.模型名称.Visible = true;
            this.模型名称.VisibleIndex = 0;
            this.模型名称.Width = 193;
            // 
            // 评估疾病
            // 
            this.评估疾病.AppearanceCell.Options.UseTextOptions = true;
            this.评估疾病.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.评估疾病.Caption = "评估疾病";
            this.评估疾病.FieldName = "sportName";
            this.评估疾病.Name = "评估疾病";
            this.评估疾病.OptionsColumn.AllowEdit = false;
            this.评估疾病.OptionsColumn.AllowFocus = false;
            this.评估疾病.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.评估疾病.OptionsFilter.AllowAutoFilter = false;
            this.评估疾病.OptionsFilter.AllowFilter = false;
            this.评估疾病.Visible = true;
            this.评估疾病.VisibleIndex = 1;
            this.评估疾病.Width = 147;
            // 
            // 性别
            // 
            this.性别.AppearanceCell.Options.UseTextOptions = true;
            this.性别.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.性别.Caption = "性别";
            this.性别.FieldName = "sportNumName";
            this.性别.Name = "性别";
            this.性别.OptionsColumn.AllowEdit = false;
            this.性别.OptionsColumn.AllowFocus = false;
            this.性别.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.性别.OptionsFilter.AllowAutoFilter = false;
            this.性别.OptionsFilter.AllowFilter = false;
            this.性别.Visible = true;
            this.性别.VisibleIndex = 2;
            this.性别.Width = 61;
            // 
            // 年龄范围
            // 
            this.年龄范围.Caption = "年龄范围";
            this.年龄范围.Name = "年龄范围";
            this.年龄范围.OptionsColumn.AllowEdit = false;
            this.年龄范围.OptionsColumn.AllowFocus = false;
            this.年龄范围.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.年龄范围.OptionsFilter.AllowAutoFilter = false;
            this.年龄范围.OptionsFilter.AllowFilter = false;
            this.年龄范围.Visible = true;
            this.年龄范围.VisibleIndex = 3;
            this.年龄范围.Width = 103;
            // 
            // 介绍及说明
            // 
            this.介绍及说明.AppearanceCell.Options.UseTextOptions = true;
            this.介绍及说明.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.介绍及说明.Caption = "介绍及说明";
            this.介绍及说明.ColumnEdit = this.repositoryItemMemoEdit1;
            this.介绍及说明.FieldName = "sportTimeName";
            this.介绍及说明.Name = "介绍及说明";
            this.介绍及说明.OptionsColumn.AllowEdit = false;
            this.介绍及说明.OptionsColumn.AllowFocus = false;
            this.介绍及说明.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.介绍及说明.OptionsFilter.AllowAutoFilter = false;
            this.介绍及说明.OptionsFilter.AllowFilter = false;
            this.介绍及说明.Visible = true;
            this.介绍及说明.VisibleIndex = 4;
            this.介绍及说明.Width = 407;
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
            // frm21006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frm21006";
            this.Text = "评估模型设置";
            this.Load += new System.EventHandler(this.frm21006_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).EndInit();
            this.pcBackGround.ResumeLayout(false);
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
        private DevExpress.XtraGrid.Columns.GridColumn 模型名称;
        private DevExpress.XtraGrid.Columns.GridColumn 评估疾病;
        private DevExpress.XtraGrid.Columns.GridColumn 性别;
        private DevExpress.XtraGrid.Columns.GridColumn 年龄范围;
        private DevExpress.XtraGrid.Columns.GridColumn 介绍及说明;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}