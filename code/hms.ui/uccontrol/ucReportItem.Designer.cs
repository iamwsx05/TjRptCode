namespace Hms.Ui
{
    partial class ucReportItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblDoctName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblDeptName = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblXj = new DevExpress.XtraEditors.LabelControl();
            this.gcReport = new DevExpress.XtraGrid.GridControl();
            this.gvReport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.itemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isCompareName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(193)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.lblRegDate);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.lblDoctName);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.lblDeptName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblRegDate
            // 
            this.lblRegDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegDate.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegDate.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblRegDate.Appearance.Options.UseFont = true;
            this.lblRegDate.Appearance.Options.UseForeColor = true;
            this.lblRegDate.Location = new System.Drawing.Point(663, 12);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(70, 14);
            this.lblRegDate.TabIndex = 4;
            this.lblRegDate.Text = "2019-12-12";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(587, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "检查时间：";
            // 
            // lblDoctName
            // 
            this.lblDoctName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoctName.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctName.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblDoctName.Appearance.Options.UseFont = true;
            this.lblDoctName.Appearance.Options.UseForeColor = true;
            this.lblDoctName.Location = new System.Drawing.Point(523, 12);
            this.lblDoctName.Name = "lblDoctName";
            this.lblDoctName.Size = new System.Drawing.Size(42, 14);
            this.lblDoctName.TabIndex = 2;
            this.lblDoctName.Text = "管理员";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(461, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "检查人：";
            // 
            // lblDeptName
            // 
            this.lblDeptName.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeptName.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblDeptName.Appearance.Options.UseFont = true;
            this.lblDeptName.Appearance.Options.UseForeColor = true;
            this.lblDeptName.Location = new System.Drawing.Point(16, 12);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(56, 14);
            this.lblDeptName.TabIndex = 0;
            this.lblDeptName.Text = "一般情况";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.lblXj);
            this.panel2.Controls.Add(this.labelControl7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 35);
            this.panel2.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(16, 12);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 14);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "小结：";
            // 
            // lblXj
            // 
            this.lblXj.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblXj.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblXj.Appearance.Options.UseFont = true;
            this.lblXj.Appearance.Options.UseForeColor = true;
            this.lblXj.Location = new System.Drawing.Point(64, 12);
            this.lblXj.Name = "lblXj";
            this.lblXj.Size = new System.Drawing.Size(42, 14);
            this.lblXj.TabIndex = 1;
            this.lblXj.Text = "小结：";
            // 
            // gcReport
            // 
            this.gcReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcReport.Location = new System.Drawing.Point(0, 70);
            this.gcReport.MainView = this.gvReport;
            this.gcReport.Name = "gcReport";
            this.gcReport.Size = new System.Drawing.Size(750, 150);
            this.gcReport.TabIndex = 21;
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
            this.deptName});
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
            // 
            // itemName
            // 
            this.itemName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.itemName.AppearanceHeader.Options.UseFont = true;
            this.itemName.AppearanceHeader.Options.UseTextOptions = true;
            this.itemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.itemName.Caption = "名称";
            this.itemName.FieldName = "itemName";
            this.itemName.Name = "itemName";
            this.itemName.OptionsColumn.AllowEdit = false;
            this.itemName.OptionsColumn.AllowFocus = false;
            this.itemName.OptionsFilter.AllowAutoFilter = false;
            this.itemName.OptionsFilter.AllowFilter = false;
            this.itemName.Visible = true;
            this.itemName.VisibleIndex = 0;
            this.itemName.Width = 164;
            // 
            // isCompareName
            // 
            this.isCompareName.AppearanceCell.Options.UseTextOptions = true;
            this.isCompareName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isCompareName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.isCompareName.AppearanceHeader.Options.UseFont = true;
            this.isCompareName.AppearanceHeader.Options.UseTextOptions = true;
            this.isCompareName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isCompareName.Caption = "结果";
            this.isCompareName.FieldName = "itemResult";
            this.isCompareName.Name = "isCompareName";
            this.isCompareName.OptionsColumn.AllowEdit = false;
            this.isCompareName.OptionsColumn.AllowFocus = false;
            this.isCompareName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.isCompareName.OptionsFilter.AllowAutoFilter = false;
            this.isCompareName.OptionsFilter.AllowFilter = false;
            this.isCompareName.Visible = true;
            this.isCompareName.VisibleIndex = 1;
            this.isCompareName.Width = 176;
            // 
            // sex
            // 
            this.sex.AppearanceCell.Options.UseTextOptions = true;
            this.sex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sex.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.sex.AppearanceHeader.Options.UseFont = true;
            this.sex.AppearanceHeader.Options.UseTextOptions = true;
            this.sex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sex.Caption = "正常参考";
            this.sex.FieldName = "range";
            this.sex.Name = "sex";
            this.sex.OptionsColumn.AllowEdit = false;
            this.sex.OptionsColumn.AllowFocus = false;
            this.sex.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.sex.OptionsFilter.AllowAutoFilter = false;
            this.sex.OptionsFilter.AllowFilter = false;
            this.sex.Visible = true;
            this.sex.VisibleIndex = 2;
            this.sex.Width = 246;
            // 
            // deptName
            // 
            this.deptName.AppearanceCell.Options.UseTextOptions = true;
            this.deptName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deptName.AppearanceHeader.Font = new System.Drawing.Font("宋体", 9F);
            this.deptName.AppearanceHeader.Options.UseFont = true;
            this.deptName.AppearanceHeader.Options.UseTextOptions = true;
            this.deptName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deptName.Caption = "单位";
            this.deptName.FieldName = "unit";
            this.deptName.Name = "deptName";
            this.deptName.OptionsColumn.AllowEdit = false;
            this.deptName.OptionsColumn.AllowFocus = false;
            this.deptName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.deptName.OptionsFilter.AllowAutoFilter = false;
            this.deptName.OptionsFilter.AllowFilter = false;
            this.deptName.Visible = true;
            this.deptName.VisibleIndex = 3;
            this.deptName.Width = 122;
            // 
            // ucReportItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcReport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucReportItem";
            this.Size = new System.Drawing.Size(750, 220);
            this.Load += new System.EventHandler(this.ucReportItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblRegDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblDoctName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblDeptName;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblXj;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gcReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReport;
        private DevExpress.XtraGrid.Columns.GridColumn itemName;
        private DevExpress.XtraGrid.Columns.GridColumn isCompareName;
        private DevExpress.XtraGrid.Columns.GridColumn sex;
        private DevExpress.XtraGrid.Columns.GridColumn deptName;
    }
}
