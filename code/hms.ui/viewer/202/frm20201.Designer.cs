namespace Hms.Ui
{
    partial class frm20201
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm20201));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcReport = new DevExpress.XtraGrid.GridControl();
            this.gvReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isCompareName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.refRange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isMainName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dteBegin = new DevExpress.XtraEditors.DateEdit();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            this.pcBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Controls.Add(this.labelControl3);
            this.pcBackGround.Controls.Add(this.labelControl2);
            this.pcBackGround.Controls.Add(this.dteEnd);
            this.pcBackGround.Controls.Add(this.dteBegin);
            this.pcBackGround.Controls.Add(this.labelControl1);
            this.pcBackGround.Controls.Add(this.txtSearch);
            this.pcBackGround.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcBackGround.Location = new System.Drawing.Point(0, 0);
            this.pcBackGround.Size = new System.Drawing.Size(999, 36);
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
            // gcReport
            // 
            this.gcReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcReport.Location = new System.Drawing.Point(0, 36);
            this.gcReport.MainView = this.gvReport;
            this.gcReport.Name = "gcReport";
            this.gcReport.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemButtonEdit2});
            this.gcReport.Size = new System.Drawing.Size(999, 473);
            this.gcReport.TabIndex = 18;
            this.gcReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReport});
            // 
            // gvReport
            // 
            this.gvReport.Appearance.GroupPanel.Font = new System.Drawing.Font("宋体", 9F);
            this.gvReport.Appearance.GroupPanel.Options.UseFont = true;
            this.gvReport.Appearance.Preview.Font = new System.Drawing.Font("宋体", 9F);
            this.gvReport.Appearance.Preview.Options.UseFont = true;
            this.gvReport.Appearance.Row.Font = new System.Drawing.Font("宋体", 9F);
            this.gvReport.Appearance.Row.Options.UseFont = true;
            this.gvReport.Appearance.Row.Options.UseTextOptions = true;
            this.gvReport.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvReport.Appearance.ViewCaption.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold);
            this.gvReport.Appearance.ViewCaption.Options.UseFont = true;
            this.gvReport.ColumnPanelRowHeight = 26;
            this.gvReport.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.itemName,
            this.isCompareName,
            this.sex,
            this.deptName,
            this.gridColumn2,
            this.refRange,
            this.isMainName,
            this.gridColumn4});
            this.gvReport.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvReport.GridControl = this.gcReport;
            this.gvReport.GroupFormat = "[#image]{1} {2}";
            this.gvReport.IndicatorWidth = 40;
            this.gvReport.Name = "gvReport";
            this.gvReport.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gvReport.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvReport.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvReport.OptionsDetail.EnableMasterViewMode = false;
            this.gvReport.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gvReport.OptionsView.ShowGroupPanel = false;
            this.gvReport.RowHeight = 27;
            this.gvReport.DoubleClick += new System.EventHandler(this.gvReport_DoubleClick);
            // 
            // itemName
            // 
            this.itemName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.itemName.AppearanceHeader.Options.UseFont = true;
            this.itemName.AppearanceHeader.Options.UseTextOptions = true;
            this.itemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.itemName.Caption = "姓名";
            this.itemName.FieldName = "clientName";
            this.itemName.Name = "itemName";
            this.itemName.OptionsColumn.AllowEdit = false;
            this.itemName.OptionsColumn.AllowFocus = false;
            this.itemName.OptionsFilter.AllowAutoFilter = false;
            this.itemName.OptionsFilter.AllowFilter = false;
            this.itemName.Visible = true;
            this.itemName.VisibleIndex = 0;
            this.itemName.Width = 94;
            // 
            // isCompareName
            // 
            this.isCompareName.AppearanceCell.Options.UseTextOptions = true;
            this.isCompareName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isCompareName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.isCompareName.AppearanceHeader.Options.UseFont = true;
            this.isCompareName.AppearanceHeader.Options.UseTextOptions = true;
            this.isCompareName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isCompareName.Caption = "体检编号";
            this.isCompareName.FieldName = "reportNo";
            this.isCompareName.Name = "isCompareName";
            this.isCompareName.OptionsColumn.AllowEdit = false;
            this.isCompareName.OptionsColumn.AllowFocus = false;
            this.isCompareName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.isCompareName.OptionsFilter.AllowAutoFilter = false;
            this.isCompareName.OptionsFilter.AllowFilter = false;
            this.isCompareName.Visible = true;
            this.isCompareName.VisibleIndex = 5;
            this.isCompareName.Width = 160;
            // 
            // sex
            // 
            this.sex.AppearanceCell.Options.UseTextOptions = true;
            this.sex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sex.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.sex.AppearanceHeader.Options.UseFont = true;
            this.sex.AppearanceHeader.Options.UseTextOptions = true;
            this.sex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sex.Caption = "性别";
            this.sex.FieldName = "sex";
            this.sex.Name = "sex";
            this.sex.OptionsColumn.AllowEdit = false;
            this.sex.OptionsColumn.AllowFocus = false;
            this.sex.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.sex.OptionsFilter.AllowAutoFilter = false;
            this.sex.OptionsFilter.AllowFilter = false;
            this.sex.Visible = true;
            this.sex.VisibleIndex = 1;
            this.sex.Width = 60;
            // 
            // deptName
            // 
            this.deptName.AppearanceCell.Options.UseTextOptions = true;
            this.deptName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deptName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.deptName.AppearanceHeader.Options.UseFont = true;
            this.deptName.AppearanceHeader.Options.UseTextOptions = true;
            this.deptName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deptName.Caption = "年龄";
            this.deptName.FieldName = "age";
            this.deptName.Name = "deptName";
            this.deptName.OptionsColumn.AllowEdit = false;
            this.deptName.OptionsColumn.AllowFocus = false;
            this.deptName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.deptName.OptionsFilter.AllowAutoFilter = false;
            this.deptName.OptionsFilter.AllowFilter = false;
            this.deptName.Visible = true;
            this.deptName.VisibleIndex = 2;
            this.deptName.Width = 91;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "单位名称";
            this.gridColumn2.FieldName = "company";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 221;
            // 
            // refRange
            // 
            this.refRange.AppearanceCell.Options.UseTextOptions = true;
            this.refRange.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.refRange.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.refRange.AppearanceHeader.Options.UseFont = true;
            this.refRange.AppearanceHeader.Options.UseTextOptions = true;
            this.refRange.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.refRange.Caption = "人员类别";
            this.refRange.FieldName = "gradeName";
            this.refRange.Name = "refRange";
            this.refRange.OptionsColumn.AllowEdit = false;
            this.refRange.OptionsColumn.AllowFocus = false;
            this.refRange.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.refRange.OptionsFilter.AllowAutoFilter = false;
            this.refRange.OptionsFilter.AllowFilter = false;
            this.refRange.Visible = true;
            this.refRange.VisibleIndex = 4;
            this.refRange.Width = 110;
            // 
            // isMainName
            // 
            this.isMainName.AppearanceCell.Options.UseTextOptions = true;
            this.isMainName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isMainName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.isMainName.AppearanceHeader.Options.UseFont = true;
            this.isMainName.AppearanceHeader.Options.UseTextOptions = true;
            this.isMainName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isMainName.Caption = "体检日期";
            this.isMainName.FieldName = "reportDate";
            this.isMainName.Name = "isMainName";
            this.isMainName.OptionsColumn.AllowEdit = false;
            this.isMainName.OptionsColumn.AllowFocus = false;
            this.isMainName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.isMainName.OptionsFilter.AllowAutoFilter = false;
            this.isMainName.OptionsFilter.AllowFilter = false;
            this.isMainName.Visible = true;
            this.isMainName.VisibleIndex = 6;
            this.isMainName.Width = 145;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "体检次数";
            this.gridColumn4.FieldName = "regTimes";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 76;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit2.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // txtSearch
            // 
            this.txtSearch.EnterMoveNextControl = true;
            this.txtSearch.Location = new System.Drawing.Point(368, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Size = new System.Drawing.Size(245, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(334, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 14);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "查询:";
            // 
            // dteBegin
            // 
            this.dteBegin.EditValue = null;
            this.dteBegin.Location = new System.Drawing.Point(78, 9);
            this.dteBegin.MenuManager = this.barManager;
            this.dteBegin.Name = "dteBegin";
            this.dteBegin.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dteBegin.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.dteBegin.Properties.Appearance.Options.UseFont = true;
            this.dteBegin.Properties.Appearance.Options.UseForeColor = true;
            this.dteBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dteBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dteBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dteBegin.Size = new System.Drawing.Size(111, 20);
            this.dteBegin.TabIndex = 8;
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(213, 9);
            this.dteEnd.MenuManager = this.barManager;
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dteEnd.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.dteEnd.Properties.Appearance.Options.UseFont = true;
            this.dteEnd.Properties.Appearance.Options.UseForeColor = true;
            this.dteEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dteEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dteEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dteEnd.Size = new System.Drawing.Size(107, 20);
            this.dteEnd.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "报告日期：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(195, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 14);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "至";
            // 
            // frm20201
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 509);
            this.Controls.Add(this.gcReport);
            this.Name = "frm20201";
            this.Text = "体检报告";
            this.Load += new System.EventHandler(this.frm20201_Load);
            this.Controls.SetChildIndex(this.marqueeProgressBarControl, 0);
            this.Controls.SetChildIndex(this.pcBackGround, 0);
            this.Controls.SetChildIndex(this.gcReport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).EndInit();
            this.pcBackGround.ResumeLayout(false);
            this.pcBackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReport;
        private DevExpress.XtraGrid.Columns.GridColumn itemName;
        private DevExpress.XtraGrid.Columns.GridColumn isCompareName;
        private DevExpress.XtraGrid.Columns.GridColumn sex;
        private DevExpress.XtraGrid.Columns.GridColumn deptName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn refRange;
        private DevExpress.XtraGrid.Columns.GridColumn isMainName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.DateEdit dteBegin;
    }
}