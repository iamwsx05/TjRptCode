using Common.Controls;
using Common.Entity;
using Common.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System.Configuration;

namespace Console.Ui
{
    /// <summary>
    /// 患者(病人)资料
    /// </summary>
    public class ctlPatient : BaseController
    {
        #region Override

        /// <summary>
        /// UI.Viewer
        /// </summary>
        private frmPatient Viewer = null;

        /// <summary>
        /// SetUI
        /// </summary>
        /// <param name="child"></param>
        public override void SetUI(frmBase child)
        {
            base.SetUI(child);
            Viewer = (frmPatient)child;
        }
        #endregion

        #region 属性.变量

        bool isChkAllergic { get; set; }
        bool isChkIsAutoGen { get; set; }

        #endregion

        #region 方法

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        internal void Init()
        {
            InitLue();

            SetEditValueChangedEvent(Viewer.groupControl1);
            SetEditValueChangedEvent(Viewer.groupControl2);

            Viewer.gcCardPlus.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            Viewer.chkIsAutoGen1.Checked = true;
            Viewer.txtAllergicDrug.Properties.ReadOnly = true;

        }
        #endregion

        #region InitLue
        /// <summary>
        /// InitLue
        /// </summary>
        void InitLue()
        {
            // lueFee
            Viewer.lueFee.Properties.PopupWidth = 240;
            Viewer.lueFee.Properties.PopupHeight = 400;
            Viewer.lueFee.Properties.ValueColumn = EntityCodeFee.Columns.feeCode;
            Viewer.lueFee.Properties.DisplayColumn = EntityCodeFee.Columns.feeName;
            Viewer.lueFee.Properties.Essential = false;
            Viewer.lueFee.Properties.IsShowColumnHeaders = true;
            Viewer.lueFee.Properties.ColumnWidth.Add(EntityCodeFee.Columns.feeCode, 50);
            Viewer.lueFee.Properties.ColumnWidth.Add(EntityCodeFee.Columns.feeName, 190);
            Viewer.lueFee.Properties.ColumnHeaders.Add(EntityCodeFee.Columns.feeCode, "编码");
            Viewer.lueFee.Properties.ColumnHeaders.Add(EntityCodeFee.Columns.feeName, "名称");
            Viewer.lueFee.Properties.ShowColumn = EntityCodeFee.Columns.feeCode + "|" + EntityCodeFee.Columns.feeName;
            Viewer.lueFee.Properties.IsUseShowColumn = true;
            if (GlobalDic.DataSourceDicFee != null && GlobalDic.DataSourceDicFee.Count > 0) Viewer.lueFee.Properties.DataSource = GlobalDic.DataSourceDicFee.ToArray();
            Viewer.lueFee.Properties.SetSize();

            // lueMarry
            Viewer.lueMarry.Properties.PopupWidth = 120;
            Viewer.lueMarry.Properties.PopupHeight = 180;
            Viewer.lueMarry.Properties.ValueColumn = EntityCodeMarry.Columns.code;
            Viewer.lueMarry.Properties.DisplayColumn = EntityCodeMarry.Columns.name;
            Viewer.lueMarry.Properties.Essential = false;
            Viewer.lueMarry.Properties.IsShowColumnHeaders = true;
            Viewer.lueMarry.Properties.ColumnWidth.Add(EntityCodeMarry.Columns.code, 50);
            Viewer.lueMarry.Properties.ColumnWidth.Add(EntityCodeMarry.Columns.name, 70);
            Viewer.lueMarry.Properties.ColumnHeaders.Add(EntityCodeMarry.Columns.code, "编码");
            Viewer.lueMarry.Properties.ColumnHeaders.Add(EntityCodeMarry.Columns.name, "名称");
            Viewer.lueMarry.Properties.ShowColumn = EntityCodeMarry.Columns.code + "|" + EntityCodeMarry.Columns.name;
            Viewer.lueMarry.Properties.IsUseShowColumn = true;
            if (GlobalDic.DataSourceDicMarry != null && GlobalDic.DataSourceDicMarry.Count > 0) Viewer.lueMarry.Properties.DataSource = GlobalDic.DataSourceDicMarry.ToArray();
            Viewer.lueMarry.Properties.SetSize();

            // luecitizen
            Viewer.lueCitizenship.Properties.PopupWidth = 140;
            Viewer.lueCitizenship.Properties.PopupHeight = 400;
            Viewer.lueCitizenship.Properties.ValueColumn = EntityCodeCountry.Columns.code;
            Viewer.lueCitizenship.Properties.DisplayColumn = EntityCodeCountry.Columns.name;
            Viewer.lueCitizenship.Properties.Essential = false;
            Viewer.lueCitizenship.Properties.IsShowColumnHeaders = true;
            Viewer.lueCitizenship.Properties.ColumnWidth.Add(EntityCodeCountry.Columns.code, 50);
            Viewer.lueCitizenship.Properties.ColumnWidth.Add(EntityCodeCountry.Columns.name, 90);
            Viewer.lueCitizenship.Properties.ColumnHeaders.Add(EntityCodeCountry.Columns.code, "编码");
            Viewer.lueCitizenship.Properties.ColumnHeaders.Add(EntityCodeCountry.Columns.name, "名称");
            Viewer.lueCitizenship.Properties.ShowColumn = EntityCodeCountry.Columns.code + "|" + EntityCodeCountry.Columns.name;
            Viewer.lueCitizenship.Properties.IsUseShowColumn = true;
            if (GlobalDic.DataSourceDicCountry != null && GlobalDic.DataSourceDicCountry.Count > 0) Viewer.lueCitizenship.Properties.DataSource = GlobalDic.DataSourceDicCountry.ToArray();
            Viewer.lueCitizenship.Properties.SetSize();

            // lueNation
            Viewer.lueNation.Properties.PopupWidth = 120;
            Viewer.lueNation.Properties.PopupHeight = 400;
            Viewer.lueNation.Properties.ValueColumn = EntityCodeNation.Columns.code;
            Viewer.lueNation.Properties.DisplayColumn = EntityCodeNation.Columns.name;
            Viewer.lueNation.Properties.Essential = false;
            Viewer.lueNation.Properties.IsShowColumnHeaders = true;
            Viewer.lueNation.Properties.ColumnWidth.Add(EntityCodeNation.Columns.code, 50);
            Viewer.lueNation.Properties.ColumnWidth.Add(EntityCodeNation.Columns.name, 70);
            Viewer.lueNation.Properties.ColumnHeaders.Add(EntityCodeNation.Columns.code, "编码");
            Viewer.lueNation.Properties.ColumnHeaders.Add(EntityCodeNation.Columns.name, "名称");
            Viewer.lueNation.Properties.ShowColumn = EntityCodeNation.Columns.code + "|" + EntityCodeNation.Columns.name;
            Viewer.lueNation.Properties.IsUseShowColumn = true;
            if (GlobalDic.DataSourceDicNation != null && GlobalDic.DataSourceDicNation.Count > 0) Viewer.lueNation.Properties.DataSource = GlobalDic.DataSourceDicNation.ToArray();
            Viewer.lueNation.Properties.SetSize();

            // lueOccupation
            Viewer.lueOccupation.Properties.PopupWidth = 140;
            Viewer.lueOccupation.Properties.PopupHeight = 400;
            Viewer.lueOccupation.Properties.ValueColumn = EntityCodeJob.Columns.code;
            Viewer.lueOccupation.Properties.DisplayColumn = EntityCodeJob.Columns.name;
            Viewer.lueOccupation.Properties.Essential = false;
            Viewer.lueOccupation.Properties.IsShowColumnHeaders = true;
            Viewer.lueOccupation.Properties.ColumnWidth.Add(EntityCodeJob.Columns.code, 50);
            Viewer.lueOccupation.Properties.ColumnWidth.Add(EntityCodeJob.Columns.name, 90);
            Viewer.lueOccupation.Properties.ColumnHeaders.Add(EntityCodeJob.Columns.code, "编码");
            Viewer.lueOccupation.Properties.ColumnHeaders.Add(EntityCodeJob.Columns.name, "名称");
            Viewer.lueOccupation.Properties.ShowColumn = EntityCodeJob.Columns.code + "|" + EntityCodeJob.Columns.name;
            Viewer.lueOccupation.Properties.IsUseShowColumn = true;
            if (GlobalDic.DataSourceDicJob != null && GlobalDic.DataSourceDicJob.Count > 0) Viewer.lueOccupation.Properties.DataSource = GlobalDic.DataSourceDicJob.ToArray();
            Viewer.lueOccupation.Properties.SetSize();
        }
        #endregion

        #region SetChkAllergic

        /// <summary>
        /// SetChkAllergic
        /// </summary>
        internal void SetChkAllergic(int idx)
        {
            if (isChkAllergic) return;
            isChkAllergic = true;
            try
            {
                Viewer.txtAllergicDrug.Properties.ReadOnly = true;
                if (idx == 1 && Viewer.chkAllergic1.Checked)
                {
                    Viewer.chkAllergic2.Checked = false;
                    Viewer.txtAllergicDrug.Properties.ReadOnly = false;
                }
                else if (idx == 2 && Viewer.chkAllergic2.Checked)
                {
                    Viewer.chkAllergic1.Checked = false;
                }
            }
            finally
            {
                isChkAllergic = false;
            }
        }
        #endregion

        #region SetChkIsAutoGen
        /// <summary>
        /// SetChkIsAutoGen
        /// </summary>
        internal void SetChkIsAutoGen(int idx)
        {
            if (isChkIsAutoGen) return;
            isChkIsAutoGen = true;
            try
            {
                if (idx == 1 && Viewer.chkIsAutoGen1.Checked)
                {
                    Viewer.chkIsAutoGen2.Checked = false;
                }
                else if (idx == 2 && Viewer.chkIsAutoGen2.Checked)
                {
                    Viewer.chkIsAutoGen1.Checked = false;
                }
            }
            finally
            {
                isChkIsAutoGen = false;
            }
        }
        #endregion

        #region Clear
        /// <summary>
        /// Clear
        /// </summary>
        internal void Clear()
        {
            Viewer.dteFirst.EditValue = null;
            Viewer.txtOpNo.Text = string.Empty;
            Viewer.txtIpNo.Text = string.Empty;
            Viewer.txtCardNo.Text = string.Empty;
            Viewer.txtPatName.Text = string.Empty;
            Viewer.cboSex.Text = string.Empty;
            Viewer.lueFee.Text = string.Empty;
            Viewer.lueFee.Properties.DBValue = string.Empty;
            Viewer.txtIdNo.Text = string.Empty;
            Viewer.dteBirth.EditValue = null;
            Viewer.cboBlood.Text = string.Empty;
            Viewer.lueMarry.Text = string.Empty;
            Viewer.lueMarry.Properties.DBValue = string.Empty;
            Viewer.txtHomeAddr.Text = string.Empty;
            Viewer.txtWorkAddr.Text = string.Empty;
            Viewer.txtContactPerson.Text = string.Empty;
            Viewer.txtContactPersonTel.Text = string.Empty;
            Viewer.cboContackRel.Text = string.Empty;
            Viewer.cboStatus.Text = string.Empty;
            Viewer.chkAllergic1.Checked = false;
            Viewer.chkAllergic2.Checked = false;
            Viewer.chkIsAutoGen1.Checked = false;
            Viewer.chkIsAutoGen2.Checked = false;
            Viewer.txtAllergicDrug.Text = string.Empty;

            Viewer.lueCitizenship.Text = string.Empty;
            Viewer.lueCitizenship.Properties.DBValue = string.Empty;
            Viewer.lueNation.Text = string.Empty;
            Viewer.lueNation.Properties.DBValue = string.Empty;
            Viewer.lueOccupation.Text = string.Empty;
            Viewer.lueOccupation.Properties.DBValue = string.Empty;
            Viewer.txtBirthplace.Text = string.Empty;
            Viewer.txtEmail.Text = string.Empty;
            Viewer.txtOfficeLocation.Text = string.Empty;
            Viewer.txtOfficeTel.Text = string.Empty;
            Viewer.txtContactPersonAddr.Text = string.Empty;
            Viewer.txtContactPersonTel.Text = string.Empty;
            Viewer.txtContactPersonZip.Text = string.Empty;
            Viewer.gcCardPlus.DataSource = null;

            Viewer.txtCardNo.Tag = null;
        }
        #endregion

        #region New
        /// <summary>
        /// New
        /// </summary>
        internal void New()
        {
            Clear();

            Viewer.dteFirst.Text = DateTime.Now.ToString("yyyy-MM-dd");
            Viewer.chkAllergic2.Checked = true;
            Viewer.chkIsAutoGen1.Checked = true;
            Viewer.cboStatus.SelectedIndex = 1;
            Viewer.txtCardNo.Focus();
        }
        #endregion

        #region Save
        /// <summary>
        /// Save
        /// </summary>
        internal void Save(bool isExit)
        {
            #region get
            EntityPatientInfo pat = new EntityPatientInfo();
            pat.cardNo = Viewer.txtCardNo.Text.Trim();
            pat.name = Viewer.txtPatName.Text.Trim();
            pat.sex = Viewer.cboSex.SelectedIndex.ToString();
            pat.feeCode = Viewer.lueFee.Properties.DBValue;
            pat.ID = Viewer.txtIdNo.Text.Trim();
            pat.birth = Viewer.dteBirth.Text;
            pat.marry = Viewer.lueMarry.Properties.DBValue;
            pat.addr = Viewer.txtHomeAddr.Text.Trim();
            pat.corp = Viewer.txtWorkAddr.Text.Trim();
            pat.contact = Viewer.txtContactPerson.Text.Trim();
            pat.cTel = Viewer.txtContactPersonTel.Text.Trim();
            pat.relation = Viewer.cboContackRel.Text.Trim();
            pat.lockFlag = (Viewer.cboStatus.SelectedIndex == 1 ? "F" : "T");
            pat.country = Viewer.lueCitizenship.Properties.DBValue;
            pat.nation = Viewer.lueNation.Properties.DBValue;
            pat.job = Viewer.lueOccupation.Properties.DBValue;
            pat.birthArea = Viewer.txtBirthplace.Text.Trim();
            pat.email = Viewer.txtEmail.Text.Trim();
            pat.contAddr = Viewer.txtContactPersonAddr.Text.Trim();
            pat.contTel = Viewer.txtContactPersonTel.Text.Trim();
            #endregion

            #region check
            if (string.IsNullOrEmpty(pat.cardNo))
            {
                DialogBox.Msg("请输入诊疗卡号。");
                Viewer.txtCardNo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pat.name))
            {
                DialogBox.Msg("请输入姓名。");
                Viewer.txtPatName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Viewer.cboSex.Text))
            {
                DialogBox.Msg("请选择性别。");
                Viewer.cboSex.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pat.feeCode))
            {
                DialogBox.Msg("请选择费别。");
                Viewer.lueFee.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pat.ID))
            {
                DialogBox.Msg("请输入身份证号。");
                Viewer.txtIdNo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pat.birth))
            {
                DialogBox.Msg("请输入出生日期。");
                Viewer.dteBirth.Focus();
                return;
            }
            #endregion

            #region default
            DateTime dtmNow = Utils.ServerTime();
            if (Viewer.txtCardNo.Tag != null)
            {
                EntityPatientInfo tmp = Viewer.txtCardNo.Tag as EntityPatientInfo;
                pat.pid = tmp.pid;
                pat.regDate = tmp.regDate;
                pat.regTime = tmp.regTime;
                pat.regOper = tmp.regOper;
            }
            else
            {
                pat.regDate = dtmNow.ToString("yyyy.MM.dd");
                pat.regTime = dtmNow.ToString("yyyy.MM.dd HH:mm:dd");
                pat.regOper = GlobalLogin.objLogin.EmpNo;
            }
            pat.modiDate = dtmNow;
            #endregion

            int ret = 0;
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                ret = proxy.Service.SavePatInfo(ref pat);
            }
            if (ret > 0)
            {
                Viewer.txtCardNo.Tag = pat;
                Viewer.IsSave = true;
                Viewer.ValueChanged = false;
                DialogBox.Msg("保存成功！");
            }
            else
            {
                DialogBox.Msg("保存失败。");
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Delete
        /// </summary>
        internal void Delete()
        {
            EntityPatientInfo patOrig = Viewer.txtCardNo.Tag as EntityPatientInfo;
            if (patOrig == null || string.IsNullOrEmpty(patOrig.pid))
            {
                Clear();
                return;
            }
            if (DialogBox.Msg("确定是否删除？", MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProxyDictionary proxy = new ProxyDictionary();
                int ret = proxy.Service.DelPatInfo(patOrig.pid);
                proxy = null;
                if (ret > 0)
                {
                    Clear();
                    Viewer.ValueChanged = false;
                    DialogBox.Msg("删除患者信息成功！");
                }
                else
                {
                    DialogBox.Msg("删除患者信息失败。");
                }
            }
        }
        #endregion

        #region Refresh
        /// <summary>
        /// Refresh
        /// </summary>
        internal void Refresh()
        {
            SelectedCardRow();
        }
        #endregion

        #region Print
        /// <summary>
        /// Print
        /// </summary>
        internal void Print()
        {
            Viewer.gvCard.PrintDialog();
        }
        #endregion

        #region GetPatInfo
        /// <summary>
        /// GetPatInfo
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        List<EntityPatientInfo> GetPatInfo(string key, string value)
        {
            using (ProxyDictionary proxy = new ProxyDictionary())
            {
                return proxy.Service.GetPatInfo(key, value);
            }
        }
        #endregion

        #region 查询
        /// <summary>
        /// 查询
        /// </summary>
        internal void Query()
        {
            if (Viewer.cboKey.Text.Trim() == string.Empty || Viewer.txtKeyVal.Text.Trim() == string.Empty)
            {
                DialogBox.Msg("请选择查询关键字，并输入查询条件。");
                return;
            }
            string key = string.Empty;
            string value = Viewer.txtKeyVal.Text.Trim();
            switch (Viewer.cboKey.SelectedIndex)
            {
                case 0:     // 诊疗卡号
                    key = "cardNo";
                    break;
                case 1:     // 门诊号
                    key = "opNo";
                    break;
                case 2:     // 住院号
                    key = "ipNo";
                    break;
                case 3:     // 姓名
                    key = "patName";
                    break;
                case 4:     // 身份证号
                    key = "idNo";
                    break;
                default:
                    return;
            }

            try
            {
                uiHelper.BeginLoading(Viewer);
                Viewer.gcCard.DataSource = GetPatInfo(key, value);
                SelectedCardRow();
            }
            finally
            {
                uiHelper.CloseLoading(Viewer);
            }
        }
        #endregion

        #region SelectedCardRow
        /// <summary>
        /// SelectedCardRow
        /// </summary>
        internal void SelectedCardRow()
        {
            int rowHandle = Viewer.gvCard.FocusedRowHandle;
            if (rowHandle < 0) return;
            EntityPatientInfo pat = Viewer.gvCard.GetRow(rowHandle) as EntityPatientInfo;
            if (pat == null)
            {
                Clear();
            }
            else
            {
                SetPatInfo(pat);
            }
        }
        #endregion

        #region SetPatInfo
        /// <summary>
        /// SetPatInfo
        /// </summary>
        /// <param name="pat"></param>
        void SetPatInfo(EntityPatientInfo pat)
        {
            Viewer.txtCardNo.Tag = pat;
            Viewer.dteFirst.EditValue = DateTime.Now;
            Viewer.txtOpNo.Text = pat.clNo;
            Viewer.txtIpNo.Text = pat.ipNo;
            Viewer.txtCardNo.Text = pat.cardNo;
            Viewer.txtPatName.Text = pat.name;
            Viewer.cboSex.Text = pat.sexCH;
            Viewer.lueFee.Properties.DBValue = pat.feeCode;
            SetLueFee(pat.feeCode);
            Viewer.txtIdNo.Text = pat.ID;
            Viewer.dteBirth.Text = pat.birth;
            Viewer.cboBlood.Text = string.Empty;
            Viewer.lueMarry.Properties.DBValue = pat.marry;
            SetLueMarry(pat.marry);
            Viewer.txtHomeAddr.Text = pat.addr;
            Viewer.txtWorkAddr.Text = pat.corp;
            Viewer.txtContactPerson.Text = pat.contact;
            Viewer.txtContactPersonTel.Text = pat.cTel;
            Viewer.cboContackRel.Text = pat.relation;
            Viewer.cboStatus.SelectedIndex = (string.IsNullOrEmpty(pat.lockFlag) && pat.lockFlag.ToUpper() == "T" ? 0 : 1);
            Viewer.chkAllergic1.Checked = false;
            Viewer.chkAllergic2.Checked = true;
            Viewer.chkIsAutoGen1.Checked = false;
            Viewer.chkIsAutoGen2.Checked = true;
            Viewer.txtAllergicDrug.Text = string.Empty;

            Viewer.lueCitizenship.Properties.DBValue = pat.country;
            SetLueCountry(pat.country);
            Viewer.lueNation.Properties.DBValue = pat.nation;
            SetLueNation(pat.nation);
            Viewer.lueOccupation.Properties.DBValue = pat.job;
            SetLueJob(pat.job);
            Viewer.txtBirthplace.Text = pat.birthArea;
            Viewer.txtEmail.Text = pat.email;
            Viewer.txtOfficeLocation.Text = string.Empty;
            Viewer.txtOfficeTel.Text = string.Empty;
            Viewer.txtContactPersonAddr.Text = pat.contAddr;
            Viewer.txtContactPersonTel.Text = pat.contTel;
            Viewer.txtContactPersonZip.Text = string.Empty;
            Viewer.gcCardPlus.DataSource = null;
            Viewer.ValueChanged = false;
        }

        #region SetLueFee
        /// <summary>
        /// SetLueFee
        /// </summary>
        /// <param name="feeCode"></param>
        void SetLueFee(string feeCode)
        {
            Viewer.lueFee.Properties.ForbidPoput = true;
            Viewer.lueFee.Text = string.Empty;
            if (GlobalDic.DataSourceDicFee != null && GlobalDic.DataSourceDicFee.Count > 0)
            {
                if (GlobalDic.DataSourceDicFee.Any(t => t.feeCode == feeCode))
                {
                    Viewer.lueFee.Text = (GlobalDic.DataSourceDicFee.FirstOrDefault(t => t.feeCode == feeCode)).feeName;
                }
            }
            Viewer.lueFee.Properties.DisplayValue = Viewer.lueFee.Text;
            Viewer.lueFee.Properties.ForbidPoput = false;
        }
        #endregion

        #region SetLueMarry
        /// <summary>
        /// SetLueMarry
        /// </summary>
        /// <param name="code"></param>
        void SetLueMarry(string code)
        {
            Viewer.lueMarry.Properties.ForbidPoput = true;
            Viewer.lueMarry.Text = string.Empty;
            if (GlobalDic.DataSourceDicMarry != null && GlobalDic.DataSourceDicMarry.Count > 0)
            {
                if (GlobalDic.DataSourceDicMarry.Any(t => t.code == code))
                {
                    Viewer.lueMarry.Text = (GlobalDic.DataSourceDicMarry.FirstOrDefault(t => t.code == code)).name;
                }
            }
            Viewer.lueMarry.Properties.DisplayValue = Viewer.lueMarry.Text;
            Viewer.lueMarry.Properties.ForbidPoput = false;
        }
        #endregion

        #region SetLueCountry
        /// <summary>
        /// SetLueCountry
        /// </summary>
        /// <param name="code"></param>
        void SetLueCountry(string code)
        {
            Viewer.lueCitizenship.Properties.ForbidPoput = true;
            Viewer.lueCitizenship.Text = string.Empty;
            if (GlobalDic.DataSourceDicCountry != null && GlobalDic.DataSourceDicCountry.Count > 0)
            {
                if (GlobalDic.DataSourceDicCountry.Any(t => t.code == code))
                {
                    Viewer.lueCitizenship.Text = (GlobalDic.DataSourceDicCountry.FirstOrDefault(t => t.code == code)).name;
                }
            }
            Viewer.lueCitizenship.Properties.DisplayValue = Viewer.lueCitizenship.Text;
            Viewer.lueCitizenship.Properties.ForbidPoput = false;
        }
        #endregion

        #region SetLueNation
        /// <summary>
        /// SetLueNation
        /// </summary>
        /// <param name="code"></param>
        void SetLueNation(string code)
        {
            Viewer.lueNation.Properties.ForbidPoput = true;
            Viewer.lueNation.Text = string.Empty;
            if (GlobalDic.DataSourceDicNation != null && GlobalDic.DataSourceDicNation.Count > 0)
            {
                if (GlobalDic.DataSourceDicNation.Any(t => t.code == code))
                {
                    Viewer.lueNation.Text = (GlobalDic.DataSourceDicNation.FirstOrDefault(t => t.code == code)).name;
                }
            }
            Viewer.lueNation.Properties.DisplayValue = Viewer.lueNation.Text;
            Viewer.lueNation.Properties.ForbidPoput = false;
        }
        #endregion

        #region SetLueJob
        /// <summary>
        /// SetLueJob
        /// </summary>
        /// <param name="code"></param>
        void SetLueJob(string code)
        {
            Viewer.lueOccupation.Properties.ForbidPoput = true;
            Viewer.lueOccupation.Text = string.Empty;
            if (GlobalDic.DataSourceDicJob != null && GlobalDic.DataSourceDicJob.Count > 0)
            {
                if (GlobalDic.DataSourceDicJob.Any(t => t.code == code))
                {
                    Viewer.lueOccupation.Text = (GlobalDic.DataSourceDicJob.FirstOrDefault(t => t.code == code)).name;
                }
            }
            Viewer.lueOccupation.Properties.DisplayValue = Viewer.lueOccupation.Text;
            Viewer.lueOccupation.Properties.ForbidPoput = false;
        }
        #endregion

        #endregion

        #endregion

    }
}
