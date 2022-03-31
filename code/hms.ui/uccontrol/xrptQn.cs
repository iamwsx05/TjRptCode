using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Hms.Entity;
using Hms.Itf;
using weCare.Core;
using Hms.Ui;
using weCare.Core.Entity;
using System.Collections.Generic;
using weCare.Core.Utils;
using System.Xml;

namespace Hms.Ui
{
    public partial class xrptQn : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptQn(EntityQnRecord qnRecord)
        {
            InitializeComponent();
            AddQuestCtrl(qnRecord);
        }

        string xmlData = string.Empty;
        Dictionary<string, string> dicData = new Dictionary<string, string>();

        #region AddQuestCtrl
        /// <summary>
        /// AddQuestCtrl
        /// </summary>
        void AddQuestCtrl(EntityQnRecord qnRecord)
        {
            try
            {
                if (qnRecord != null)
                {
                    if (!string.IsNullOrEmpty(qnRecord.xmlData))
                    {
                        XmlDocument document = new XmlDocument();
                        document.LoadXml(qnRecord.xmlData);
                        XmlNodeList list = document["FormData"].ChildNodes;
                        string xmlData = list[0].OuterXml;
                        dicData = Function.ReadXML(xmlData);
                        ClientName.Text = dicData[ClientName.Name];
                        //BirthPlace.Text = dicData[BirthPlace.Name];
                        Company.Text = dicData[Company.Name];
                        Telephone.Text = dicData[Telephone.Name];
                        YearIncom.Text = dicData[YearIncom.Name];
                        ConnectPhone.Text = dicData[ConnectPhone.Name];
                        ClientName.Text = dicData[ClientName.Name];
                        Sex.Text = dicData[Sex.Name];
                        Mobile.Text = dicData[Mobile.Name];
                        YbType.Text = dicData[YbType.Name];
                        ConnectName.Text = dicData[ConnectName.Name];
                        BooldType.Text = dicData[BooldType.Name];
                        Rh.Text = dicData[Rh.Name];
                        Job.Text = dicData[Job.Name];
                        EhtnicGroup.Text = dicData[EhtnicGroup.Name];
                        QuestDate.Text = dicData[QuestDate.Name];
                        Marriage.Text = dicData[Marriage.Name];
                        Birthday.Text = dicData[Birthday.Name];
                        EduationLevel.Text = dicData[EduationLevel.Name];
                        Religious.Text = dicData[Religious.Name];
                        IdCard.Text = dicData[IdCard.Name];
                        Address.Text = dicData[Address.Name];
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(ex);
            }
            finally
            {

            }
        }
        #endregion
    }
}
