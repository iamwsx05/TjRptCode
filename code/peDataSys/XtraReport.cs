using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;

namespace peDataSys
{
    public partial class XtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport()
        {
            InitializeComponent();
        }

        public XtraReport(Form2.EntityReport reprot)//构造函数重载  
        {
            InitializeComponent();
            SetDataBind(reprot);
        }

        private void SetDataBind(Form2.EntityReport report)//绑定数据源  
        {
            try
            {
                pic01.Image = report.image01;
                pic02.Image = report.image02;
                pic03.Image = report.image03;
                pic04.Image = report.image04;
                pic05.Image = report.image05;
                picFx02.Image = report.imageFx;
                pic07.Image = report.image07;
                picGxyTip.Image = report.imageTip;
                picGzssTip.Image = report.imageTip;

                #region  重要指标
                this.picMainIdicate.DataBindings.Add("Image", report.lstMainIndicate, "pic");
                this.cellItem.DataBindings.Add("Text", report.lstMainIndicate, "item");//
                this.cellResult.DataBindings.Add("Text", report.lstMainIndicate, "result");//
                this.cellRange.DataBindings.Add("Text", report.lstMainIndicate, "range");//
                this.cellUnit.DataBindings.Add("Text", report.lstMainIndicate, "unit");//
                this.dtRptMainIndicate.DataSource = report.lstMainIndicate;
                #endregion

                #region 高血压
                this.picGxy.DataBindings.Add("Image", report.lstGxy, "pic");
                this.cellGxyItem.DataBindings.Add("Text", report.lstGxy, "gxyItem");//
                this.cellGxyResult.DataBindings.Add("Text", report.lstGxy, "gxyResult");//
                this.cellGxyRange.DataBindings.Add("Text", report.lstGxy, "gxyRange");//
                this.cellGxyUnit.DataBindings.Add("Text", report.lstGxy, "gxyUnit");//
                this.dtRptGxy.DataSource = report.lstGxy;
                #endregion

                #region 评估结果
                this.xrChart.DataSource = report.lstEvaluationResult;
                this.xrChart.Series[0].SetDataMembers("evaluationName", "result");
                #endregion

                #region 评估结果
                this.xrChart1.DataSource = report.lstResultTest;
                
                this.xrChart1.Series[0].SetDataMembers("evaluateName", "result1");
                this.xrChart1.Series[0].LegendText = "男";
                this.xrChart1.Series[1].SetDataMembers("evaluateName", "result2");
                this.xrChart1.Series[1].LegendText = "女";
                this.xrChart1.Series[2].SetDataMembers("evaluateName", "result3");
                this.xrChart1.Series[2].LegendText = "合计";
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
