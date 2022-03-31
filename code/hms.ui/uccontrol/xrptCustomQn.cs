using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Hms.Entity;
using weCare.Core.Entity;
using System.Collections.Generic;
using Common.Controls;
using weCare.Core.Utils;

namespace Hms.Ui
{
    public partial class xrptCustomQn : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptCustomQn(EntityQnRecord qnVo)
        {
            InitializeComponent();
            InitComponent(qnVo);
        }


        #region InitComponent
        /// <summary>
        /// InitComponent
        /// </summary>
        public void InitComponent(EntityQnRecord qnRecordVo)
        {
            try
            {
                List<EntityDicQnSetting> lstTopic = null;
                List<EntityDicQnSetting> lstItems = null;
                using (ProxyHms svc = new ProxyHms())
                {
                     svc.Service.GetQnCustom(qnRecordVo.qnId, out lstTopic, out lstItems);
                }
                int intY = 10;
                Dictionary<string, string> dicData = Function.ReadXmlNodes(qnRecordVo.xmlData, "FormData");
                this.Sex.Text = dicData["Sex"];
                this.ClientName.Text = dicData["ClientName"];
                this.ClientNo.Text = dicData["clientNo"];
                this.QuestionDate.Text = dicData["QuestionDate"];
                this.Birthday.Text = dicData["Birthday"];

                if (lstTopic != null && lstTopic.Count > 0)
                {

                    qnName.Text = qnRecordVo.qnName;
                    EntityDicQnSetting item = null;
                    EntityDicQnSetting item2 = null;
                    for (int i = 0; i < lstTopic.Count; i++)
                    {
                        item = lstTopic[i];
                        DevExpress.XtraReports.UI.XRLabel lblTopic = new DevExpress.XtraReports.UI.XRLabel();
                        lblTopic.Name = item.fieldId;
                        lblTopic.Text = Convert.ToString(i + 1) + "、" + item.fieldName;
                        lblTopic.WidthF = lblTopic.Text.Length + 120;
                        lblTopic.Font = new System.Drawing.Font("宋体", 9.5F);
                        lblTopic.Location = new Point(44, intY);
                        this.Detail.Controls.Add(lblTopic);

                        List<EntityDicQnSetting> lstCtrls = lstItems.FindAll(t => t.parentFieldId == item.fieldId);
                        if (lstCtrls != null && lstCtrls.Count > 0)
                        {
                            intY += 40;
                            int tmpX = 0;
                            int tmpY = intY;
                            for (int j = 0; j < lstCtrls.Count; j++)
                            {
                                tmpY = intY + 30 * (j / 5);
                                tmpX = 44 + (j % 5) * 130;

                                item2 = lstCtrls[j];
                                if (item2.typeId == "3")
                                {
                                    DevExpress.XtraReports.UI.XRLabel lblAns = new XRLabel() ;
                                    lblAns.Location = new Point(44, intY);
                                    lblAns.Font = new System.Drawing.Font("宋体", 9.5F);
                                    if (dicData.ContainsKey(item2.fieldId))
                                        lblAns.Text = dicData[item2.fieldId];

                                    lblAns.Width = lblAns.Text.Length + 120;
                                    this.Detail.Controls.Add(lblAns);
                                }
                                else
                                {
                                    DevExpress.XtraReports.UI.XRCheckBox chkAns  = new XRCheckBox();
                                    chkAns.Name = item2.fieldId;
                                    chkAns.Text = item2.fieldName;
                                    chkAns.Font = new System.Drawing.Font("宋体", 9.5F);
                                    chkAns.Width = item2.fieldName.Length + 85;
                                    if (dicData.ContainsKey(item2.fieldId))
                                        chkAns.Checked = dicData[item2.fieldId]== "1" ? true : false;
                                    chkAns.Location = new Point(tmpX, tmpY);

                                    this.Detail.Controls.Add(chkAns);
                                }
                            }
                            intY = tmpY;
                            intY += 60;
                        }
                        else
                        {
                            if (item.typeId == "3")
                            {
                                intY += 30;
                                DevExpress.XtraReports.UI.XRLabel lblAns = new XRLabel();
                                lblAns.Location = new Point(44, intY);
                                lblAns.Font = new System.Drawing.Font("宋体", 9.5F);
                                if (dicData.ContainsKey(item2.fieldId))
                                    lblAns.Text = dicData[item2.fieldId];
                                lblAns.Width = lblAns.Text.Length + 120;
                                this.Detail.Controls.Add(lblAns);
                            }
                            else
                            {
                                intY += 60;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DialogBox.Msg(ex.Message);
            }
            finally
            {

            }
        }
        #endregion

    }
}
