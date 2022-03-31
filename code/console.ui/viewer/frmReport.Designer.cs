namespace Console.Ui
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.imageList = new System.Windows.Forms.ImageList();
            this.tvRport = new DevExpress.XtraTreeList.TreeList();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.xtabReport = new DevExpress.XtraTab.XtraTabControl();
            this.page1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtSql = new ICSharpCode.TextEditor.TextEditorControl();
            this.page2 = new DevExpress.XtraTab.XtraTabPage();
            this.ucPrintControl = new Common.Controls.ucPrintControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRptName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtRptNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).BeginInit();
            this.pcBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvRport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtabReport)).BeginInit();
            this.xtabReport.SuspendLayout();
            this.page1.SuspendLayout();
            this.page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRptName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRptNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackGround
            // 
            this.pcBackGround.Controls.Add(this.labelControl1);
            this.pcBackGround.Controls.Add(this.txtRptName);
            this.pcBackGround.Controls.Add(this.labelControl3);
            this.pcBackGround.Controls.Add(this.labelControl19);
            this.pcBackGround.Controls.Add(this.txtRptNo);
            this.pcBackGround.Controls.Add(this.labelControl2);
            this.pcBackGround.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcBackGround.Location = new System.Drawing.Point(172, 0);
            this.pcBackGround.Size = new System.Drawing.Size(765, 36);
            this.pcBackGround.Visible = true;
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "InsertHeader_16x16.png");
            // 
            // tvRport
            // 
            this.tvRport.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvRport.Location = new System.Drawing.Point(0, 0);
            this.tvRport.Margin = new System.Windows.Forms.Padding(0);
            this.tvRport.Name = "tvRport";
            this.tvRport.OptionsBehavior.AllowExpandOnDblClick = false;
            this.tvRport.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.tvRport.OptionsSelection.UseIndicatorForSelection = true;
            this.tvRport.OptionsView.ShowColumns = false;
            this.tvRport.OptionsView.ShowHorzLines = false;
            this.tvRport.OptionsView.ShowIndicator = false;
            this.tvRport.OptionsView.ShowVertLines = false;
            this.tvRport.RowHeight = 22;
            this.tvRport.SelectImageList = this.imageList;
            this.tvRport.Size = new System.Drawing.Size(168, 743);
            this.tvRport.TabIndex = 14;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(168, 0);
            this.splitterControl1.MaximumSize = new System.Drawing.Size(4, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(4, 743);
            this.splitterControl1.TabIndex = 15;
            this.splitterControl1.TabStop = false;
            // 
            // xtabReport
            // 
            this.xtabReport.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtabReport.Appearance.Options.UseFont = true;
            this.xtabReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtabReport.Location = new System.Drawing.Point(172, 36);
            this.xtabReport.Name = "xtabReport";
            this.xtabReport.SelectedTabPage = this.page1;
            this.xtabReport.Size = new System.Drawing.Size(765, 707);
            this.xtabReport.TabIndex = 16;
            this.xtabReport.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.page1,
            this.page2});
            // 
            // page1
            // 
            this.page1.Controls.Add(this.txtSql);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(759, 678);
            this.page1.Text = "    数据源(Sql)    ";
            // 
            // txtSql
            // 
            this.txtSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSql.Encoding = ((System.Text.Encoding)(resources.GetObject("txtSql.Encoding")));
            this.txtSql.Location = new System.Drawing.Point(0, 0);
            this.txtSql.Name = "txtSql";
            this.txtSql.ShowEOLMarkers = true;
            this.txtSql.ShowSpaces = true;
            this.txtSql.ShowTabs = true;
            this.txtSql.ShowVRuler = true;
            this.txtSql.Size = new System.Drawing.Size(759, 678);
            this.txtSql.TabIndex = 0;
            // 
            // page2
            // 
            this.page2.Controls.Add(this.ucPrintControl);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(759, 678);
            this.page2.Text = "    报表格式预览    ";
            // 
            // ucPrintControl
            // 
            this.ucPrintControl.Caption = null;
            this.ucPrintControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPrintControl.IsDockFill = true;
            this.ucPrintControl.IsReloadDictionary = false;
            this.ucPrintControl.IsSave = false;
            this.ucPrintControl.Location = new System.Drawing.Point(0, 0);
            this.ucPrintControl.Name = "ucPrintControl";
            this.ucPrintControl.PrintingSystem = null;
            this.ucPrintControl.ShowStatusBar = false;
            this.ucPrintControl.ShowToolBar = false;
            this.ucPrintControl.Size = new System.Drawing.Size(759, 678);
            this.ucPrintControl.TabIndex = 12;
            this.ucPrintControl.ValueChanged = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(225, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 23);
            this.labelControl1.TabIndex = 53;
            this.labelControl1.Text = "*";
            // 
            // txtRptName
            // 
            this.txtRptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRptName.EnterMoveNextControl = true;
            this.txtRptName.Location = new System.Drawing.Point(295, 9);
            this.txtRptName.Name = "txtRptName";
            this.txtRptName.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtRptName.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtRptName.Properties.Appearance.Options.UseFont = true;
            this.txtRptName.Properties.Appearance.Options.UseForeColor = true;
            this.txtRptName.Size = new System.Drawing.Size(444, 20);
            this.txtRptName.TabIndex = 49;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(239, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 12);
            this.labelControl3.TabIndex = 52;
            this.labelControl3.Text = "报表名称:";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl19.Location = new System.Drawing.Point(14, 12);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(10, 23);
            this.labelControl19.TabIndex = 51;
            this.labelControl19.Text = "*";
            // 
            // txtRptNo
            // 
            this.txtRptNo.EnterMoveNextControl = true;
            this.txtRptNo.Location = new System.Drawing.Point(84, 9);
            this.txtRptNo.Name = "txtRptNo";
            this.txtRptNo.Properties.Appearance.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtRptNo.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.txtRptNo.Properties.Appearance.Options.UseFont = true;
            this.txtRptNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtRptNo.Size = new System.Drawing.Size(132, 20);
            this.txtRptNo.TabIndex = 48;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(28, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 12);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "报表编号:";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 743);
            this.Controls.Add(this.xtabReport);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.tvRport);
            this.Name = "frmReport";
            this.Text = "自定义报表管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReport_FormClosing);
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.Controls.SetChildIndex(this.tvRport, 0);
            this.Controls.SetChildIndex(this.splitterControl1, 0);
            this.Controls.SetChildIndex(this.pcBackGround, 0);
            this.Controls.SetChildIndex(this.xtabReport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackGround)).EndInit();
            this.pcBackGround.ResumeLayout(false);
            this.pcBackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvRport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtabReport)).EndInit();
            this.xtabReport.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.page2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRptName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRptNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList imageList;
        internal DevExpress.XtraTreeList.TreeList tvRport;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        internal DevExpress.XtraTab.XtraTabControl xtabReport;
        internal DevExpress.XtraTab.XtraTabPage page1;
        internal DevExpress.XtraTab.XtraTabPage page2;
        internal ICSharpCode.TextEditor.TextEditorControl txtSql;
        internal Common.Controls.ucPrintControl ucPrintControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.TextEdit txtRptName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        internal DevExpress.XtraEditors.TextEdit txtRptNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}