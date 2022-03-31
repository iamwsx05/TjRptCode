using Common.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hms.Entity;
using DevExpress.XtraReports.UI;

namespace Hms.Ui
{
    public partial class frmPopup2020202 : frmBasePopup
    {
        public frmPopup2020202(EntityQnRecord _qnVo =null)
        {
            InitializeComponent();
            qnVo = _qnVo;
        }

        EntityQnRecord qnVo { get; set; }
        xrptQn xr { get; set; }
        xrptCustomQn xrCustomQn { get; set; }

        #region methods
        /// <summary>
        /// 
        /// </summary>
        void InitNormalQn()
        {
            xrptQuest01 xr1 = new xrptQuest01(qnVo);
            xr1.CreateDocument();//创建报表
            xrptQuest02 xr2 = new xrptQuest02(qnVo);
            xr2.CreateDocument();//创建报表

            xrptQuest03 xr3 = new xrptQuest03(qnVo);
            xr3.CreateDocument();//创建报表
            xrptQuest04 xr4 = new xrptQuest04(qnVo);
            xr4.CreateDocument();//创建报表

            xrptQuest05 xr5 = new xrptQuest05(qnVo);
            xr5.CreateDocument();//创建报表
            xrptQuest06 xr6 = new xrptQuest06(qnVo);
            xr6.CreateDocument();//创建报表

            xrptQuest07 xr7 = new xrptQuest07(qnVo);
            xr7.CreateDocument();//创建报表
            xrptQuest08 xr8 = new xrptQuest08(qnVo);
            xr8.CreateDocument();//创建报表

            xrptQuest09 xr9= new xrptQuest09(qnVo);
            xr9.CreateDocument();//创建报表
            xrptQuest10 xr10 = new xrptQuest10(qnVo);
            xr10.CreateDocument();//创建报表
            
            xr = new xrptQn(qnVo);
            xr.xrptQuest01.ReportSource = xr1;
            xr.xrptQuest02.ReportSource = xr2;
            xr.xrptQuest03.ReportSource = xr3;
            xr.xrptQuest04.ReportSource = xr4;
            xr.xrptQuest05.ReportSource = xr5;
            xr.xrptQuest06.ReportSource = xr6;
            xr.xrptQuest07.ReportSource = xr7;
            xr.xrptQuest08.ReportSource = xr8;
            xr.xrptQuest09.ReportSource = xr9;
            xr.xrptQuest10.ReportSource = xr10;
            xr.CreateDocument();//创建报表
            this.documentViewer1.PrintingSystem = xr.PrintingSystem;
        }


        void InitCustomQn()
        {
            xrCustomQn = new xrptCustomQn(qnVo);
            xrCustomQn.CreateDocument();//创建报表
            this.documentViewer1.PrintingSystem = xrCustomQn.PrintingSystem;
        }
        #endregion

        private void blbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (qnVo.qnType == 1)
                xr.PrintDialog();
            else
                xrCustomQn.PrintDialog();
        }

        private void frmPopup2020201_Load(object sender, EventArgs e)
        {
            if (qnVo.qnType == 1)
                InitNormalQn();
            else
                InitCustomQn();
        }
    }
}
