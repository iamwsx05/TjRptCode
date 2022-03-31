using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using weCare.Core.Utils;

namespace peDataSys
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public class EntityReport
        {
            public string ID { get; set; }
            public string userName { get; set; }
            public string userPass { get; set; }
            public string userQQ { get; set; }
            public Image image01 { get; set; }
            public Image image02 { get; set; }
            public Image image03 { get; set; }
            public Image image04 { get; set; }
            public Image image05 { get; set; }
            public Image image06 { get; set; }
            public Image image07 { get; set; }
            public Image image08 { get; set; }
            public Image image09 { get; set; }
            public Image image10 { get; set; }
            public Image image11 { get; set; }
            public Image image12 { get; set; }
            public Image imageFx { get; set; }
            public Image imageTip { get; set; }
            public List<EntityMainIndicate> lstMainIndicate { get; set; }
            public List<EntityEvaluationResult> lstEvaluationResult { get; set; }

            public List<EntityEvaluateTest> lstResultTest { get; set; }




            public List<EntityGxy> lstGxy { get; set; }
        }

        #region 重要指标
        public class EntityMainIndicate
        {
            public Image pic { get; set; }
            public string item { get; set; }
            public string result { get; set; }
            public string range { get; set; }
            public string unit { get; set; }

        }
        #endregion

        #region 高血压
        public class EntityGxy
        {
            public Image pic { get; set; }
            public string gxyItem { get; set; }
            public string gxyResult { get; set; }
            public string gxyRange { get; set; }
            public string gxyUnit { get; set; }

        }
        #endregion

        public class EntityEvaluationResult
        {
            public string evaluationName { get; set; }
            public double result { get; set; }
        }

        public class EntityEvaluateTest
        {
            public string evaluateName { get; set; }
            public double result1 { get; set; }
            public double result2 { get; set; }
            public double result3 { get; set; }
        }

        XtraReport xr;
        private void btnReport_Click(object sender, EventArgs e)
        {
            xr.PrintDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EntityReport report = new EntityReport();

            report.image01 = ReadImageFile("pic01.png");
            report.image02 = ReadImageFile("pic02.jpg");
            report.image03 = ReadImageFile("pic03.png");
            report.image04 = ReadImageFile("pic04.png");
            report.image05 = ReadImageFile("pic05.png");
            report.imageFx = ReadImageFile("picFx.png");
            report.imageTip = ReadImageFile("picTip.png");
            report.image07 = ReadImageFile("pic07.png");

            #region 重要指标
            report.lstMainIndicate = GetMainIndicate();
            #endregion

            #region 高血压
            report.lstGxy = GetGxy();
            #endregion

            #region 评估结果
            report.lstEvaluationResult = new List<EntityEvaluationResult>();
            EntityEvaluationResult eVo1 = new EntityEvaluationResult();
            eVo1.evaluationName = "最佳状态";
            eVo1.result = 2.00;
            report.lstEvaluationResult.Add(eVo1);

            EntityEvaluationResult eVo2 = new EntityEvaluationResult();
            eVo2.evaluationName = "本次风险";
            eVo2.result = 8.65;
            report.lstEvaluationResult.Add(eVo2);

            EntityEvaluationResult eVo3 = new EntityEvaluationResult();
            eVo3.evaluationName = "平均风险";
            eVo3.result = 18.00;
            report.lstEvaluationResult.Add(eVo3);

            #endregion


            #region 评估结果
            report.lstResultTest = new List<EntityEvaluateTest>();
            EntityEvaluateTest eTVo1 = new EntityEvaluateTest();
            eTVo1.evaluateName = "最佳状态";
            eTVo1.result1 = 0.111;
            eTVo1.result2 = 0.2;
            eTVo1.result3 = 0.3;
            report.lstResultTest.Add(eTVo1);

            EntityEvaluateTest eTVo2 = new EntityEvaluateTest();
            eTVo2.evaluateName = "本次风险";
            eTVo2.result1 = 0.4;
            eTVo2.result2 = 0.5;
            eTVo2.result3 = 0.6;
            report.lstResultTest.Add(eTVo2);

            EntityEvaluateTest eTVo3 = new EntityEvaluateTest();
            eTVo3.evaluateName = "平均风险";
            eTVo3.result1 = 0.7;
            eTVo3.result2 = 0.8;
            report.lstResultTest.Add(eTVo3);

            #endregion

            xr = new XtraReport(report);
            xr.CreateDocument();//创建报表
            this.documentViewer1.PrintingSystem = xr.PrintingSystem;
           
        }

        #region 重要指标
        /// <summary>
        /// 重要指标
        /// </summary>
        /// <returns></returns>
        internal List<EntityMainIndicate> GetMainIndicate()
        {
            List<EntityMainIndicate> data = new List<EntityMainIndicate>();
            EntityMainIndicate vo1 = new EntityMainIndicate();
            vo1.item = "身高";
            vo1.result = "176.5";
            vo1.range = "";
            vo1.unit = "cm";
            data.Add(vo1);
            EntityMainIndicate vo2 = new EntityMainIndicate();
            vo2.item = "体重";
            vo2.result = "72.2";
            vo2.range = "";
            vo2.unit = "kg";
            data.Add(vo2);
            EntityMainIndicate vo3 = new EntityMainIndicate();
            vo3.item = "身高体重指数";
            vo3.result = "23.05";
            vo3.range = "";
            vo3.unit = "";
            data.Add(vo3);

            EntityMainIndicate vo4 = new EntityMainIndicate();
            vo4.item = "收缩压";
            vo4.result = "114";
            vo4.range = "130 - 139";
            vo4.unit = "mmHg";
            data.Add(vo4);

            EntityMainIndicate vo5 = new EntityMainIndicate();
            vo5.item = "舒张压";
            vo5.result = "75";
            vo5.range = "85 - 89";
            vo5.unit = "mmHg";
            data.Add(vo5);

            EntityMainIndicate vo6 = new EntityMainIndicate();
            vo6.pic = ReadImageFile("pic06.png");
            vo6.item = "尿酸（UA）";
            vo6.result = "488 ↑";
            vo6.range = "90 - 420";
            vo6.unit = "umol/L";
            data.Add(vo6);

            EntityMainIndicate vo7 = new EntityMainIndicate();
            vo7.item = "总胆固醇(TCHO)";
            vo7.result = "3.76";
            vo7.range = "3.76";
            vo7.unit = "mmol/L";
            data.Add(vo7);

            EntityMainIndicate vo8 = new EntityMainIndicate();
            vo8.item = "甘油三酯(TG)";
            vo8.result = "1.74";
            vo8.range = "0.41-1.86";
            vo8.unit = "mmol/L";
            data.Add(vo8);

            EntityMainIndicate vo9 = new EntityMainIndicate();
            vo9.item = "高密度脂蛋白胆固醇(HDL - C)";
            vo9.result = "1.29";
            vo9.range = "0.83-2.16";
            vo9.unit = "mmol/L";
            data.Add(vo9);

            EntityMainIndicate vo10 = new EntityMainIndicate();
            vo10.item = "低密度脂蛋白胆固醇(LDL - C)";
            vo10.result = "2.18";
            vo10.range = "0-3.10";
            vo10.unit = "mmol/L";
            data.Add(vo10);

            EntityMainIndicate vo11 = new EntityMainIndicate();
            vo11.item = "糖化血红蛋白(HbA1c))";
            vo11.result = "4.6";
            vo11.range = "3-6.2";
            vo11.unit = "%";
            data.Add(vo11);

            EntityMainIndicate vo12 = new EntityMainIndicate();
            vo12.item = "空腹血糖(GLU)";
            vo12.result = "4.92";
            vo12.range = "3.9-6.1";
            vo12.unit = "mmol/L";
            data.Add(vo12);

            EntityMainIndicate vo13 = new EntityMainIndicate();
            vo13.item = "同型半胱氨酸(HCY)";
            vo13.result = "9.1";
            vo13.range = "4.0-15.0";
            vo13.unit = "mmol/L";
            data.Add(vo13);

            return data;
        }
        #endregion

        #region 高血压
        /// <summary>
        /// 高血压
        /// </summary>
        /// <returns></returns>
        internal List<EntityGxy> GetGxy()
        {
            List<EntityGxy> data = new List<EntityGxy>();
            EntityGxy vo1 = new EntityGxy();
            vo1.gxyItem = "身高体重指数";
            vo1.gxyResult = "23.05";
            vo1.gxyRange = "";
            vo1.gxyUnit = "";
            data.Add(vo1);
            EntityGxy vo2 = new EntityGxy();
            vo2.gxyItem = "收缩压";
            vo2.gxyResult = "114";
            vo2.gxyRange = "130－139";
            vo2.gxyUnit = "mmHg";
            data.Add(vo2);
            EntityGxy vo3 = new EntityGxy();
            vo3.gxyItem = "舒张压";
            vo3.gxyResult = "舒张压";
            vo3.gxyRange = "85－89";
            vo3.gxyUnit = "";
            data.Add(vo3);

            EntityGxy vo4 = new EntityGxy();
            vo4.gxyItem = "饮食喜好咸";
            vo4.gxyResult = "未填";
            vo4.gxyRange = "否";
            vo4.gxyUnit = "";
            data.Add(vo4);

            EntityGxy vo5 = new EntityGxy();
            vo5.gxyItem = "每次运动锻炼时间";
            vo5.gxyResult = "未填";
            vo5.gxyRange = "30~<60分钟";
            vo5.gxyUnit = "";
            data.Add(vo5);

            EntityGxy vo6 = new EntityGxy();
            vo6.gxyItem = "饮酒状态";
            vo6.gxyResult = "未填";
            vo6.gxyRange = "从不";
            vo6.gxyUnit = "";
            data.Add(vo6);

            EntityGxy vo7 = new EntityGxy();
            vo7.gxyItem = "总胆固醇(TCHO)";
            vo7.gxyResult = "3.76";
            vo7.gxyRange = "2.9~5.7";
            vo7.gxyUnit = "mmol/L";
            data.Add(vo7);


            EntityGxy vo8 = new EntityGxy();
            vo8.gxyItem = "低密度脂蛋白胆固醇(LDL-C)";
            vo8.gxyResult = "2.18";
            vo8.gxyRange = "2.18";
            vo8.gxyUnit = "mmol/L";
            data.Add(vo8);

            EntityGxy vo9 = new EntityGxy();
            vo9.gxyItem = "糖尿病";
            vo9.gxyResult = "无";
            vo9.gxyRange = "无";
            vo9.gxyUnit = "";
            data.Add(vo9);

            return data;
        }
        #endregion


        #region ReadImageFile
        public static Bitmap ReadImageFile(string picName)
        {
            Bitmap bitmap = null;
            try
            {
                string strFile = Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName + @"\reportTest\"+ picName ;
                if (!System.IO.File.Exists(strFile))
                {
                    try
                    {
                        strFile = System.AppDomain.CurrentDomain.BaseDirectory + @"\reportTest\" + picName ;
                        if (!System.IO.File.Exists(strFile))
                        {
                            strFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\reportTest\" + picName ;
                        }
                    }
                    catch
                    {

                        strFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\reportTest\" + picName;
                    }
                }
                FileStream fileStream = File.OpenRead(strFile);
                Int32 filelength = 0;
                filelength = (int)fileStream.Length;
                Byte[] image = new Byte[filelength];
                fileStream.Read(image, 0, filelength);
                System.Drawing.Image result = System.Drawing.Image.FromStream(fileStream);
                fileStream.Close();
                bitmap = new Bitmap(result);
            }
            catch (Exception ex)
            {
                bitmap = null;
            }
            finally
            {
            }
            return bitmap;
        }
        #endregion

    }
}
