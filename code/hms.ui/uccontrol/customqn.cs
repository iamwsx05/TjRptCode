using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using weCare.Core.Entity;
using Common.Controls;

namespace Hms.Ui
{
    /// <summary>
    /// 绘制问卷
    /// </summary>
    public partial class CustomQN : UserControl
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public CustomQN()
        {
            InitializeComponent();
        }
        #endregion

        #region var/property

        public EntityDicQnMain QnVo { get; set; }

        List<DevExpress.XtraEditors.CheckEdit> lstCheck = new List<DevExpress.XtraEditors.CheckEdit>();

        #endregion

        #region mthod

        #region InitComponent
        /// <summary>
        /// InitComponent
        /// </summary>
        public void InitComponent(decimal QnId)
        {
            try
            {
                this.SuspendLayout();
                List<EntityDicQnSetting> lstTopic = null;
                List<EntityDicQnSetting> lstItems = null;
                using (ProxyHms svc = new ProxyHms())
                {
                    svc.Service.GetQnCustom(QnId, out lstTopic, out lstItems);
                }

                int intY = 50;
                if (lstTopic != null && lstTopic.Count > 0)
                {
                    if (this.QnVo != null)
                    {
                        DevExpress.XtraEditors.LabelControl lblTitle = new DevExpress.XtraEditors.LabelControl();
                        lblTitle.Text = this.QnVo.qnName;
                        lblTitle.Font = new System.Drawing.Font("宋体", 18F, FontStyle.Bold);
                        lblTitle.Location = new Point(450, intY);
                        this.plContent.Controls.Add(lblTitle);
                        intY += 60;
                    }

                    EntityDicQnSetting item = null;
                    EntityDicQnSetting item2 = null;
                    for (int i = 0; i < lstTopic.Count; i++)
                    {
                        item = lstTopic[i];
                        DevExpress.XtraEditors.LabelControl lblTopic = new DevExpress.XtraEditors.LabelControl();
                        lblTopic.Name = item.fieldId;
                        lblTopic.Text = Convert.ToString(i + 1) + "、" + item.fieldName;
                        lblTopic.Font = new System.Drawing.Font("宋体", 9.5F);
                        lblTopic.Location = new Point(80, intY);
                        this.plContent.Controls.Add(lblTopic);

                        List<EntityDicQnSetting> lstCtrls = lstItems.FindAll(t => t.parentFieldId == item.fieldId);
                        if (lstCtrls != null && lstCtrls.Count > 0)
                        {
                            intY += 40;
                            int tmpX = 0;
                            int tmpY = intY;
                            for (int j = 0; j < lstCtrls.Count; j++)
                            {
                                tmpY = intY + 40 * (j / 6);
                                tmpX = 100 + (j % 6) * 150;

                                item2 = lstCtrls[j];
                                DevExpress.XtraEditors.CheckEdit chkAns = new DevExpress.XtraEditors.CheckEdit();
                                chkAns.Name = item2.fieldId;
                                chkAns.Text = item2.fieldName;
                                chkAns.Font = new System.Drawing.Font("宋体", 9.5F);
                                chkAns.Location = new Point(tmpX, tmpY);
                                chkAns.CheckedChanged += new EventHandler(iChk_CheckedChanged);
                                if (!string.IsNullOrEmpty(item2.parentFieldId) && item2.isMultipe == 0)
                                {
                                    chkAns.Properties.AccessibleName = item2.parentFieldId;
                                    lstCheck.Add(chkAns);
                                }
                                this.plContent.Controls.Add(chkAns);
                            }
                            intY = tmpY;
                            intY += 60;
                        }
                        else
                        {
                            if (item.typeId == "3")
                            {
                                intY += 30;
                                DevExpress.XtraEditors.TextEdit txtAns = new DevExpress.XtraEditors.TextEdit();
                                txtAns.Location = new Point(100, intY);
                                txtAns.Width = 600;
                                txtAns.Font = new System.Drawing.Font("宋体", 9.5F);
                                txtAns.ForeColor = Color.Blue;
                                this.plContent.Controls.Add(txtAns);
                            }
                            else
                            {
                                intY += 60;
                            }
                        }
                    }
                }
                this.Height = intY + 100;
            }
            catch (Exception ex)
            {
                DialogBox.Msg(ex.Message);
            }
            finally
            {
                this.ResumeLayout();
            }
        }
        #endregion

        #region iChk_CheckedChanged
        /// <summary>
        /// iChk_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void iChk_CheckedChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit iChk = sender as DevExpress.XtraEditors.CheckEdit;
            // 同时勾选
            //List<string> lstCGroup = new List<string>();
            //string itemCaption = (sender as DevExpress.XtraEditors.CheckEdit).ItemCaption;
            //if (!string.IsNullOrEmpty(itemCaption))
            //{
            //    int pos1 = itemCaption.IndexOf("|S");
            //    int pos2 = itemCaption.IndexOf("E|");
            //    if (pos1 >= 0 && pos2 > 0)
            //    {
            //        string groupCheckFields = itemCaption.Substring(pos1 + 3, pos2 - (pos1 + 3)).ToLower().Trim();
            //        lstCGroup = groupCheckFields.Split(';').ToList();
            //    }
            //}
            if (iChk.Checked)
            {
                // 根据分组属性控制只选一个
                foreach (DevExpress.XtraEditors.CheckEdit chk in lstCheck)
                {
                    if (chk != iChk && chk.Properties.AccessibleName == iChk.Properties.AccessibleName)
                    {
                        chk.Checked = false;
                        ((DevExpress.XtraEditors.CheckEdit)sender).Properties.Appearance.ForeColor = Color.Black;
                        ((DevExpress.XtraEditors.CheckEdit)sender).Invalidate();
                        ((DevExpress.XtraEditors.CheckEdit)sender).Update();
                    }
                }
                ((DevExpress.XtraEditors.CheckEdit)sender).Properties.Appearance.ForeColor = Color.Blue;
                ((DevExpress.XtraEditors.CheckEdit)sender).Invalidate();
                ((DevExpress.XtraEditors.CheckEdit)sender).Update();
            }
            else
            {
                ((DevExpress.XtraEditors.CheckEdit)sender).Properties.Appearance.ForeColor = Color.Black;
                ((DevExpress.XtraEditors.CheckEdit)sender).Invalidate();
                ((DevExpress.XtraEditors.CheckEdit)sender).Update();
            }
            //if (lstSumCheck != null && lstSumCheck.Count > 0)
            //{
            //    decimal sumWeightVal = 0;
            //    foreach (ICheckBox chk in lstSumCheck)
            //    {
            //        if (chk.Checked && chk.SumName == iChk.SumName)
            //            sumWeightVal += chk.CheckedWeightValue;
            //    }
            //    foreach (ctlTextBox txt in lstSumTxt)
            //    {
            //        if (txt.ItemName == iChk.SumName)
            //        {
            //            txt.Text = sumWeightVal.ToString();
            //            break;
            //        }
            //    }
            //    foreach (ctlLabelEf lbl in lstSumLbl)
            //    {
            //        if (lbl.ItemName == iChk.SumName)
            //        {
            //            lbl.Text = sumWeightVal.ToString();
            //            break;
            //        }
            //    }
            //}
            //// 同时勾选
            //if (lstCGroup.Count > 0)
            //{
            //    foreach (ctlCheckBox chk in lstAllCheckBox)
            //    {
            //        if (lstCGroup.IndexOf(chk.ItemName.ToLower()) >= 0) chk.Checked = iChk.Checked;
            //    }
            //}
        }
        #endregion

        #region CreateControl
        /// <summary>
        /// CreateControl
        /// </summary>
        /// <returns></returns>
        object CreateQnControl()
        {

            return null;
        }
        #endregion

        #endregion

        #region event

        private void CustomQN_Load(object sender, EventArgs e)
        {

        }



        #endregion

    }
}
