namespace rtpFunc
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.wNavbar1 = new NavbarWinTest.WNavbar();
            this.wNavbarGroup1 = new NavbarWinTest.WNavbarGroup();
            this.wNavbarGroupItem1 = new NavbarWinTest.WNavbarGroupItem();
            this.wNavbarGroupItem2 = new NavbarWinTest.WNavbarGroupItem();
            this.wNavbarGroupItem3 = new NavbarWinTest.WNavbarGroupItem();
            this.wNavbarGroupItem4 = new NavbarWinTest.WNavbarGroupItem();
            this.wNavbarGroup2 = new NavbarWinTest.WNavbarGroup();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.wNavbarGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barStaticItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 9;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.QuickToolbarItemLinks.Add(this.barButtonItem1);
            this.ribbonControl.QuickToolbarItemLinks.Add(this.barButtonItem2);
            this.ribbonControl.Size = new System.Drawing.Size(1337, 48);
            this.ribbonControl.Merge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.ribbonControl1_Merge);
            this.ribbonControl.UnMerge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.ribbonControl1_UnMerge);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "功 能";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1337, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 716);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1337, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 716);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1337, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 716);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            this.xtraTabbedMdiManager.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xtraTabbedMdiManager1_MouseDown);
            // 
            // wNavbar1
            // 
            this.wNavbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.wNavbar1.Caption = "WNavbar";
            this.wNavbar1.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.wNavbar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.wNavbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbar1.Items.AddRange(new NavbarWinTest.WNavbarGroup[] {
            this.wNavbarGroup2,
            this.wNavbarGroup1});
            this.wNavbar1.Location = new System.Drawing.Point(0, 48);
            this.wNavbar1.Name = "wNavbar1";
            this.wNavbar1.Size = new System.Drawing.Size(210, 668);
            this.wNavbar1.TabIndex = 6;
            // 
            // wNavbarGroup1
            // 
            this.wNavbarGroup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.wNavbarGroup1.CaptionSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.wNavbarGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.wNavbarGroup1.EnableExpandCollapseAnimation = true;
            this.wNavbarGroup1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroup1.IsExpand = true;
            this.wNavbarGroup1.Items.AddRange(new NavbarWinTest.WNavbarGroupItem[] {
            this.wNavbarGroupItem4,
            this.wNavbarGroupItem3,
            this.wNavbarGroupItem2,
            this.wNavbarGroupItem1});
            this.wNavbarGroup1.Location = new System.Drawing.Point(0, 0);
            this.wNavbarGroup1.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroup1.Name = "wNavbarGroup1";
            this.wNavbarGroup1.Size = new System.Drawing.Size(210, 207);
            this.wNavbarGroup1.TabIndex = 1;
            this.wNavbarGroup1.Text = "wNavbarGroup1";
            // 
            // wNavbarGroupItem1
            // 
            this.wNavbarGroupItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.wNavbarGroupItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.wNavbarGroupItem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.wNavbarGroupItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroupItem1.Image = null;
            this.wNavbarGroupItem1.Location = new System.Drawing.Point(0, 46);
            this.wNavbarGroupItem1.Name = "wNavbarGroupItem1";
            this.wNavbarGroupItem1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.wNavbarGroupItem1.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(167)))));
            this.wNavbarGroupItem1.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroupItem1.SelectedImage = null;
            this.wNavbarGroupItem1.Size = new System.Drawing.Size(210, 40);
            this.wNavbarGroupItem1.TabIndex = 0;
            this.wNavbarGroupItem1.Text = "wNavbarGroupItem1";
            // 
            // wNavbarGroupItem2
            // 
            this.wNavbarGroupItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.wNavbarGroupItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.wNavbarGroupItem2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.wNavbarGroupItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroupItem2.Image = null;
            this.wNavbarGroupItem2.Location = new System.Drawing.Point(0, 86);
            this.wNavbarGroupItem2.Name = "wNavbarGroupItem2";
            this.wNavbarGroupItem2.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.wNavbarGroupItem2.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(167)))));
            this.wNavbarGroupItem2.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroupItem2.SelectedImage = null;
            this.wNavbarGroupItem2.Size = new System.Drawing.Size(210, 40);
            this.wNavbarGroupItem2.TabIndex = 1;
            this.wNavbarGroupItem2.Text = "wNavbarGroupItem2";
            // 
            // wNavbarGroupItem3
            // 
            this.wNavbarGroupItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.wNavbarGroupItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.wNavbarGroupItem3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.wNavbarGroupItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroupItem3.Image = null;
            this.wNavbarGroupItem3.Location = new System.Drawing.Point(0, 126);
            this.wNavbarGroupItem3.Name = "wNavbarGroupItem3";
            this.wNavbarGroupItem3.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.wNavbarGroupItem3.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(167)))));
            this.wNavbarGroupItem3.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroupItem3.SelectedImage = null;
            this.wNavbarGroupItem3.Size = new System.Drawing.Size(210, 40);
            this.wNavbarGroupItem3.TabIndex = 2;
            this.wNavbarGroupItem3.Text = "wNavbarGroupItem3";
            // 
            // wNavbarGroupItem4
            // 
            this.wNavbarGroupItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.wNavbarGroupItem4.Dock = System.Windows.Forms.DockStyle.Top;
            this.wNavbarGroupItem4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.wNavbarGroupItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroupItem4.Image = null;
            this.wNavbarGroupItem4.Location = new System.Drawing.Point(0, 166);
            this.wNavbarGroupItem4.Name = "wNavbarGroupItem4";
            this.wNavbarGroupItem4.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.wNavbarGroupItem4.SelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(167)))));
            this.wNavbarGroupItem4.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroupItem4.SelectedImage = null;
            this.wNavbarGroupItem4.Size = new System.Drawing.Size(210, 40);
            this.wNavbarGroupItem4.TabIndex = 3;
            this.wNavbarGroupItem4.Text = "wNavbarGroupItem4";
            // 
            // wNavbarGroup2
            // 
            this.wNavbarGroup2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.wNavbarGroup2.CaptionSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.wNavbarGroup2.Dock = System.Windows.Forms.DockStyle.Top;
            this.wNavbarGroup2.EnableExpandCollapseAnimation = true;
            this.wNavbarGroup2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroup2.Location = new System.Drawing.Point(0, 207);
            this.wNavbarGroup2.MouseOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(68)))));
            this.wNavbarGroup2.Name = "wNavbarGroup2";
            this.wNavbarGroup2.Size = new System.Drawing.Size(210, 45);
            this.wNavbarGroup2.TabIndex = 1;
            this.wNavbarGroup2.Text = "wNavbarGroup2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 739);
            this.Controls.Add(this.wNavbar1);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.wNavbar1, 0);
            this.Controls.SetChildIndex(this.marqueeProgressBarControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.wNavbarGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private NavbarWinTest.WNavbar wNavbar1;
        private NavbarWinTest.WNavbarGroup wNavbarGroup2;
        private NavbarWinTest.WNavbarGroup wNavbarGroup1;
        private NavbarWinTest.WNavbarGroupItem wNavbarGroupItem4;
        private NavbarWinTest.WNavbarGroupItem wNavbarGroupItem3;
        private NavbarWinTest.WNavbarGroupItem wNavbarGroupItem2;
        private NavbarWinTest.WNavbarGroupItem wNavbarGroupItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}