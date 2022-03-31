using Common.Controls;
using Common.Entity;
using System;
using System.Windows.Forms;
using weCare.Core.Entity;

namespace Hms.Ui
{
    public partial class frmPopup21002 : frmBasePopup
    {
        string typeId { get; set; }
        string typeName { get; set; }
        public EntityDicMessageContent smsVo { get; set; }
        /// <summary>
        /// 是否要求刷新
        /// </summary>
        public bool IsRequireRefresh { get; set; }

        public frmPopup21002(EntityDicMessageContent _smsContent)
        {
            InitializeComponent();
            smsVo = _smsContent;
        }

        void SetContent(EntityDicMessageContent vo)
        {
            this.typeId = vo.typeId;
            this.typeName = vo.typeName;
            this.cboTypeName.Text = vo.typeName;
            this.cboSuitGender.Text = vo.suitGenderDesc;
            this.cboSuitPersons.Text = vo.suitPersonsDesc;
            this.cboSuitSeason.Text = vo.suitSeasonDesc;
            this.txtSmsContent.Text = vo.smsContent;
        }

        void New()
        {
            smsVo = new EntityDicMessageContent() { sId = 0, typeId = this.typeId, typeName = this.typeName };
            SetContent(smsVo);
        }

        private void frmPopup21002_Load(object sender, EventArgs e)
        {
            SetContent(smsVo);
        }

        private void blbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void blbiDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (smsVo.sId > 0)
            {
                if (DialogBox.Msg("是否删除当前短信模板？", MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (ProxyHms proxy = new ProxyHms())
                    {
                        if (proxy.Service.DeleteMessageTemplate(smsVo.sId) > 0)
                        {
                            this.IsRequireRefresh = true;
                            New();
                            DialogBox.Msg("删除成功！");
                        }
                        else
                        {
                            DialogBox.Msg("删除失败。");
                        }
                    }
                }
            }
            else
            {
                New();
            }
        }

        private void blbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ProxyHms proxy = new ProxyHms())
            {
                smsVo.suitGender = this.cboSuitGender.SelectedIndex.ToString();
                smsVo.suitPersons = this.cboSuitPersons.SelectedIndex.ToString();
                smsVo.suitSeason = this.cboSuitSeason.SelectedIndex.ToString();
                smsVo.smsContent = this.txtSmsContent.Text.Trim();
                smsVo.creatorId = GlobalLogin.objLogin.EmpNo;
                smsVo.creatDate = DateTime.Now;
                smsVo.organId = GlobalHospital.HospitalCode;

                if (smsVo.smsContent == string.Empty)
                {
                    DialogBox.Msg("请输入模板内容。");
                    this.txtSmsContent.Focus();
                    return;
                }

                decimal templateId = 0;
                bool isNew = smsVo.sId <= 0 ? true : false;
                if (proxy.Service.SaveMessageTemplate(smsVo, out templateId) > 0)
                {
                    this.IsRequireRefresh = true;
                    if (isNew)
                        smsVo.sId = templateId;
                    DialogBox.Msg("保存成功！");
                }
                else
                {
                    DialogBox.Msg("保存失败。");
                }
            }
        }

        private void blbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
