using Common.Controls;
using Common.Entity;
using System;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Hms.Ui
{
    public partial class frmPopup21001 : frmBasePopup
    {
        public EntityDicSportItem SportItemVo { get; set; }

        /// <summary>
        /// 是否要求刷新
        /// </summary>
        public bool IsRequireRefresh { get; set; }

        public frmPopup21001(EntityDicSportItem _sportItemVo)
        {
            InitializeComponent();
            SportItemVo = _sportItemVo;
        }

        void SetContent(EntityDicSportItem vo)
        {
            this.txtSportNo.Text = vo.sportNo;
            this.txtSportName.Text = vo.sportName;
            this.txtMetValue.Text = vo.metValue.ToString();
            this.cboSportTime.Text = vo.sportTimeName;
            this.cboSportType.Text = vo.sportTypeName;
            this.cboSportNum.Text = vo.sportNumName;
            this.txtMinAge.Text = vo.minAge.ToString();
            this.txtMaxAge.Text = vo.maxAge.ToString();
            this.cboSex.Text = vo.sex;
            this.txtAnnouncements.Text = vo.announcements;
            this.txtEffect.Text = vo.effect;
            this.txtDecription.Text = vo.decription;
        }

        void New()
        {
            SportItemVo = new EntityDicSportItem() { sId = 0 };
            SetContent(SportItemVo);
        }

        private void frmPopup21001_Load(object sender, EventArgs e)
        {
            SetContent(SportItemVo);
        }

        private void blbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void blbiDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SportItemVo.sId > 0)
            {
                if (DialogBox.Msg("是否删除当前运动项目模板？", MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (ProxyHms proxy = new ProxyHms())
                    {
                        if (proxy.Service.DeleteSportItem(SportItemVo.sId) > 0)
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
                SportItemVo.sportNo = this.txtSportNo.Text.Trim();
                SportItemVo.sportName = this.txtSportName.Text.Trim();
                SportItemVo.metValue = Function.Dec(this.txtMetValue.Text);
                SportItemVo.sportTime = this.cboSportTime.SelectedIndex + 1;
                SportItemVo.sportType = Convert.ToString(this.cboSportType.SelectedIndex + 1);
                SportItemVo.sportNum = this.cboSportNum.SelectedIndex + 1;
                SportItemVo.minAge = Function.Dec(this.txtMinAge.Text);
                SportItemVo.maxAge = Function.Dec(this.txtMaxAge.Text);
                SportItemVo.sex = this.cboSex.SelectedIndex.ToString();
                SportItemVo.announcements = this.txtAnnouncements.Text.Trim();
                SportItemVo.effect = this.txtEffect.Text.Trim();
                SportItemVo.decription = this.txtDecription.Text.Trim();
                SportItemVo.creatorId = GlobalLogin.objLogin.EmpNo;
                SportItemVo.creatDate = DateTime.Now;
                SportItemVo.organId = GlobalHospital.HospitalCode;

                if (SportItemVo.sportNo == string.Empty)
                {
                    DialogBox.Msg("请输入编号。");
                    this.txtSportNo.Focus();
                    return;
                }

                if (SportItemVo.sportName == string.Empty)
                {
                    DialogBox.Msg("请输入名称。");
                    this.txtSportName.Focus();
                    return;
                }

                decimal templateId = 0;
                bool isNew = SportItemVo.sId <= 0 ? true : false;
                if (proxy.Service.SaveSportItem(SportItemVo, out templateId) > 0)
                {
                    this.IsRequireRefresh = true;
                    if (isNew)
                        SportItemVo.sId = templateId;
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
