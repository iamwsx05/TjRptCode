using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Common.Controls;
using Common.Entity;
using Common.Utils;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Console.Ui
{
    /// <summary>
    /// 登录UI
    /// </summary>
    public partial class frmLogin : Form
    {
        #region 构造
        /// <summary>
        /// 构造
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
            this.Hide();
            this.AutoScaleMode = AutoScaleMode.None;
            this.Location = new Point(-800, -800);
        }
        #endregion

        #region 属性.变量

        /// <summary>
        /// 密码错误次数
        /// </summary>
        private int ErrorNums = 0;
        /// <summary>
        /// 允许错误次数
        /// </summary>
        private int AllowErrorNums = 3;

        /// <summary>
        /// 账号信息
        /// </summary>
        private List<EntityAccount> lstAccount = new List<EntityAccount>();

        /// <summary>
        /// 异步中
        /// </summary>
        private bool IsAsync { get; set; }

        #endregion

        #region 方法

        #region 登录功能模块
        /// <summary>
        /// 登录功能模块
        /// </summary>
        /// <param name="funcID"></param>
        private void LoginModule(string funcID)
        {
            this.Tag = funcID;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        #endregion

        #region 本地配置
        /// <summary>
        /// 本地配置
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        List<EntityAppConfig> GetAppConfig(string empNo)
        {
            EntityPC pc = new EntityPC();
            pc.MachineName = Function.LocalHostName();
            pc.IpAddr = Function.LocalIP();
            pc.MacAddr = Function.LocalMac();
            pc.EmpNo = empNo;
            using (ProxyLogin proxy = new ProxyLogin())
            {
                return proxy.Service.GetAppConfig(pc);
            }
        }
        #endregion

        #region 默认用户
        /// <summary>
        /// 默认用户
        /// </summary>
        private void ReadAccountNo()
        {
            string accountNo = Function.ReadLocalSettingValue("Main|accountNo", "value");
            if (accountNo != string.Empty)
            {
                this.txtAccountNo.Text = accountNo;
            }
            this.timer.Enabled = true;
        }
        /// <summary>
        /// 写默认登录账号
        /// </summary>
        private void WriteAccountNo()
        {
            string accountNo = this.txtAccountNo.Text.Trim();
            if (accountNo != string.Empty)
            {
                Function.SetLocalSettingValue("Main|accountNo", "value", accountNo);
            }
        }
        #endregion

        #region Login
        /// <summary>
        /// Verify
        /// </summary>
        /// <returns></returns>
        private bool Verify()
        {
            string accountNo = this.txtAccountNo.Text.Trim();
            string pwd = this.txtPwd.Text;

            if (accountNo == string.Empty)
            {
                return false;
            }
            if (lstAccount == null || lstAccount.Count == 0)
            {
                DialogBox.Msg("登录账号信息未配置，请联系管理员。", MessageBoxIcon.Information);
                return false;
            }

            List<EntityAccount> acc = lstAccount.FindAll(t => t.EmpNo == accountNo);
            ProxyLogin proxy = new ProxyLogin();
            try
            {
                if (acc == null || acc.Count == 0)
                {
                    DialogBox.Msg("登录账号不存在，请重新输入。", MessageBoxIcon.Information);
                    this.txtAccountNo.Focus();
                    return false;
                }
                GlobalAppConfig.AccountFuncs = acc;

                EntityLogin dcLoginInfo = null;
                EntityHospital dcHospitalInfo = null;
                proxy.Service.GetLoginInfo(accountNo, ref dcLoginInfo, ref dcHospitalInfo);

                if (dcLoginInfo != null)
                {
                    //本机信息
                    dcLoginInfo.IP = Function.LocalIP();
                    dcLoginInfo.Mac = Function.LocalMac();
                    dcLoginInfo.HostName = Function.LocalHostName();

                    GlobalLogin.objLogin = dcLoginInfo;
                    GlobalHospital.objHospital = dcHospitalInfo;
                    string oriPwd = GlobalLogin.objLogin.Pwd;
                    if (pwd != string.Empty)
                    {
                        if (1 != 1)
                        {
                            oriPwd = (new clsSymmetricAlgorithm()).Decrypt(oriPwd, clsSymmetricAlgorithm.enmSymmetricAlgorithmType.DES);
                        }
                    }
                    if (pwd != oriPwd)      //GlobalLogin.objLogin.Pwd)
                    {
                        //if (CheckCAType())
                        //{
                        //    if (!HopeBridge.Common.Ca.CA.IDVerify(acc[0].SignDigital))
                        //    {
                        //        DialogBox.Msg("电子认证失败，请检查电子密钥KEY盘。");
                        //        return false;
                        //    }
                        //}
                        if (dcLoginInfo.AcctLock)
                        {
                            DialogBox.Msg("账户被锁定，请与管理员联系。", MessageBoxIcon.Information);
                            return false;
                        }

                        this.ErrorNums++;
                        if (this.AllowErrorNums == this.ErrorNums)
                        {
                            ProxyFrame proxy1 = new ProxyFrame();
                            if (proxy1.Service.LockAccount(accountNo) > 0)
                            {
                                DialogBox.Msg("密码输入超过系统允许的最大错误次数(" + this.AllowErrorNums.ToString() + "次)\r\n\r\n系统将被锁定，请与管理员联系。", MessageBoxIcon.Information);
                                Application.Exit();
                                return false;
                            }
                        }
                        this.txtPwd.Focus();
                        DialogBox.Msg("密码不正确，请重新输入。\r\n\r\n错误" + this.ErrorNums.ToString() + "次，剩余" + Convert.ToString((3 - this.ErrorNums)) + "次。");
                        return false;
                    }

                    //if (dcLoginInfo.Pwd == GlobalAppConfig.INIT_PWD)
                    //{
                    //    DialogBox.Msg("使用系统前请先修改初始密码！", MessageBoxIcon.Information);

                    //    frmPassWord frmPwd = new frmPassWord(accountNo);
                    //    if (frmPwd.ShowDialog() != DialogResult.OK)
                    //    {
                    //        return false;
                    //    }
                    //}
                    //if (dcLoginInfo.PwdValidDays > 0 && dcLoginInfo.PwdUseDate != null)
                    //{
                    //    DateTime dtmNow = Utils.ServerTime();
                    //    TimeSpan ts = new TimeSpan(dcLoginInfo.PwdValidDays, 0, 0, 0);
                    //    if (dtmNow.Subtract(ts) >= dcLoginInfo.PwdUseDate)
                    //    {
                    //        DialogBox.Msg("密码超过系统默认的有效期(" + dcLoginInfo.PwdValidDays.ToString() + "天)，请重设密码。");
                    //        frmPassWord frmPwd = new frmPassWord(accountNo);
                    //        if (frmPwd.ShowDialog() != DialogResult.OK)
                    //        {
                    //            return false;
                    //        }
                    //    }
                    //}
                    if (dcLoginInfo.EmpFlag == 1 || dcLoginInfo.EmpFlag == 3)
                    {
                        if (string.IsNullOrEmpty(dcLoginInfo.DeptCode) || dcLoginInfo.lstDept.Count == 0)
                        {
                            DialogBox.Msg("当前登录人没有默认科室，请联系管理员。");
                            return false;
                        }
                    }
                    //if (dcLoginInfo.EmpFlag == 2)
                    //{
                    //    if (dcLoginInfo.AreaID <= 0 || dcLoginInfo.lstArea.Count == 0)
                    //    {
                    //        DialogBox.Msg("当前登录人没有默认病区，请联系管理员。");
                    //        return false;
                    //    }
                    //}

                    // 重新.加载本地参数
                    GlobalAppConfig.AppConfig = GetAppConfig(dcLoginInfo.EmpNo);
                    // 医院组织机构系统编码
                    //GlobalHospital.OrgSysCode = Function.LocalSettingValue("Login", "Hospital", "OrgSysCode");

                    // 主题
                    string skinName = Function.ReadLocalSettingValue("Main|skinName", "value");
                    if (string.IsNullOrEmpty(skinName))
                    {
                        EntityLocalSetting vo = new EntityLocalSetting();
                        vo.MachName = Function.LocalHostName();
                        vo.MacAddr = Function.LocalMac();
                        vo.IpAddr = Function.LocalIP();
                        vo.EmpNo = dcLoginInfo.EmpNo;
                        vo.Parent = "Common";
                        vo.Node = "SkinName";
                        ProxyFrame proxyFrame = new ProxyFrame();
                        proxyFrame.Service.GetLocalSetting(ref vo);
                        skinName = vo.Value;
                    }
                    if (!string.IsNullOrEmpty(skinName)) GlobalLogin.SkinName = skinName;

                    // 写账号
                    WriteAccountNo();
                    return true;
                }
            }
            finally
            {
                proxy = null;
            }
            return false;
        }
        /// <summary>
        /// 登录状态
        /// </summary>
        private bool IsLogin { get; set; }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="funcID"></param>
        private void Login()
        {
            if (IsLogin) return;
            try
            {
                if (!Verify()) return;
                IsLogin = true;

                #region 异步加载
                if (IsAsync) return;
                IsAsync = true;
                backgroundWorker.RunWorkerAsync();
                #endregion

                // 健康管理
                LoginModule("15");
            }
            finally
            {
                IsLogin = false;
            }
        }

        #endregion

        #region Init
        /// <summary>
        /// Init
        /// </summary>
        private void Init()
        {
            // 加载本地参数
            GlobalAppConfig.RunningMode = Function.Int(this.Tag);
            GlobalAppConfig.AppConfig = GetAppConfig(string.Empty);
            using (ProxyLogin proxy = new ProxyLogin())
            {
                lstAccount = proxy.Service.GetAccount();
                GlobalParm.dicSysParameter = proxy.Service.SysParameter();
                this.picLogin.Image = Properties.Resources.健康管理;
            }
            ReadAccountNo();
        }
        #endregion

        #region 异步加载

        #region 异步加载字典
        /// <summary>
        /// 异步加载字典
        /// </summary>
        public void AsyncLoadDic()
        {
            try
            {
                LoadDicEmployee();
                LoadDicDepartment();
                LoadDicCommon();
                
                if (GlobalParm.dicSysParameter.ContainsKey(0))
                {
                    if (GlobalParm.dicSysParameter[0].IndexOf("02") >= 0)
                    {
                        #region 住院.医生站

                        //LoadDicOrderInput();
                        //LoadDicArea();
                        //LoadDicDirection();
                        //LoadDicFrequency();
                        //LoadDefConfiguration();

                        //LoadDicFee();
                        //LoadDicMarry();
                        //LoadDicCountry();
                        //LoadDicNation();
                        //LoadDicJob();

                        //Assembly objAsm = Assembly.LoadFrom(Application.StartupPath + "\\Doctstation.Ui.dll");
                        //Type objType = objAsm.GetType("Doctstation.Ui.ctlOrderManage");
                        //MethodInfo objMth = objType.GetMethod("AsyncLoad");
                        //objMth.Invoke(null, null);
                        #endregion
                    }
                }
            }
            catch (Exception e)
            {
                string str = e.Message;
            }
        }
        #endregion
        
        #region LoadDicDepartment
        /// <summary>
        /// LoadDicDepartment
        /// </summary>
        static void LoadDicDepartment()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    DataTable dt = proxy.Service.SelectFullTable(new EntityCodeDepartment());
                    GlobalDic.DataSourceDepartment = EntityTools.ConvertToEntityList<EntityCodeDepartment>(dt);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDicArea
        /// <summary>
        /// LoadDicArea
        /// </summary>
        void LoadDicArea()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    DataTable dt = proxy.Service.SelectFullTable(new EntityArea());
                    GlobalDic.DataSourceArea = EntityTools.ConvertToEntityList<EntityArea>(dt);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDicEmployee
        /// <summary>
        /// LoadDicEmployee
        /// </summary>
        static void LoadDicEmployee()
        {
            try
            {
                using (ProxyCommon proxy = new ProxyCommon())
                {
                    EntityCodeOperator[] data1 = null;
                    data1 = proxy.Service.GetEmployee(0);
                    if (data1 != null && data1.Length > 0)
                        GlobalDic.DataSourceEmployee = data1.ToList();
                    else
                        GlobalDic.DataSourceEmployee = new List<EntityCodeOperator>();
                    data1 = proxy.Service.GetEmployee(1);
                    if (data1 != null && data1.Length > 0)
                        GlobalDic.DataSourceDoctor = data1.ToList();
                    else
                        GlobalDic.DataSourceDoctor = new List<EntityCodeOperator>();
                    data1 = proxy.Service.GetEmployee(2);
                    if (data1 != null && data1.Length > 0)
                        GlobalDic.DataSourceNurse = data1.ToList();
                    else
                        GlobalDic.DataSourceNurse = new List<EntityCodeOperator>();
                    GlobalDic.dicEmpRole = proxy.Service.GetEmpRoleList();
                    GlobalDic.DataSourceDefDeptEmployee = proxy.Service.GetDefDeptEmployee();
                    // 
                    EntityIcd[] icdDataSource = proxy.Service.GetIcd();
                    if (icdDataSource != null && icdDataSource.Length > 0)
                        GlobalDic.DataSourceICD = icdDataSource.ToList();

                }
                using (ProxyEntityFactory proxy1 = new ProxyEntityFactory())
                {
                    DataTable dt = null;
                    dt = proxy1.Service.SelectFullTable(new EntityPlusOperator());
                    GlobalDic.DataSourceEmpDept = EntityTools.ConvertToEntityList<EntityPlusOperator>(dt);

                    dt = proxy1.Service.SelectFullTable(new EntityDefOperatorRole());
                    GlobalDic.DataSourceEmpRole = EntityTools.ConvertToEntityList<EntityDefOperatorRole>(dt);

                    dt = proxy1.Service.SelectFullTable(new EntityCodeRank());
                    GlobalDic.DataSourceRank = EntityTools.ConvertToEntityList<EntityCodeRank>(dt);
                }

                //GlobalDic.DataSourceEmployee = null;
                //GlobalDic.DataSourceEmployee = new List<EntityCodeOperator>();
                //if (GlobalDic.DataSourceDoctor != null)
                //{
                //    GlobalDic.DataSourceEmployee.AddRange(GlobalDic.DataSourceDoctor);
                //}
                //if (GlobalDic.DataSourceNurse != null)
                //{
                //    GlobalDic.DataSourceEmployee.AddRange(GlobalDic.DataSourceNurse);
                //}
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDicDirection
        /// <summary>
        /// LoadDicDirection
        /// </summary>
        void LoadDicDirection()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    DataTable dt = proxy.Service.SelectFullTable(new EntityCodeDirection());
                    GlobalDic.DataSourceDicDirection = EntityTools.ConvertToEntityList<EntityCodeDirection>(dt);
                    if (GlobalDic.DataSourceDicDirection != null)
                    {
                        foreach (EntityCodeDirection item in GlobalDic.DataSourceDicDirection)
                        {
                            item.pyCode = SpellCodeHelper.GetPyCode(item.direName);
                            item.wbCode = SpellCodeHelper.GetWbCode(item.direName);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDicFrequency
        /// <summary>
        /// LoadDicFrequency
        /// </summary>
        void LoadDicFrequency()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    DataTable dt = proxy.Service.SelectFullTable(new EntityCodeFrequency());
                    GlobalDic.DataSourceDicFrequency = EntityTools.ConvertToEntityList<EntityCodeFrequency>(dt);
                    if (GlobalDic.DataSourceDicFrequency != null)
                    {
                        foreach (EntityCodeFrequency item in GlobalDic.DataSourceDicFrequency)
                        {
                            item.pyCode = SpellCodeHelper.GetPyCode(item.freqName);
                            item.wbCode = SpellCodeHelper.GetWbCode(item.freqName);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDefConfiguration
        /// <summary>
        /// LoadDefConfiguration
        /// </summary>
        void LoadDefConfiguration()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    DataTable dt = proxy.Service.SelectFullTable(new EntityDefConfiguration());
                    GlobalDic.DataSourceDefConfiguration = EntityTools.ConvertToEntityList<EntityDefConfiguration>(dt);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDicFee
        /// <summary>
        /// LoadDicFee
        /// </summary>
        void LoadDicFee()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    DataTable dt = proxy.Service.SelectFullTable(new EntityCodeFee());
                    GlobalDic.DataSourceDicFee = EntityTools.ConvertToEntityList<EntityCodeFee>(dt);
                    if (GlobalDic.DataSourceDicFee != null)
                    {
                        for (int i = GlobalDic.DataSourceDicFee.Count - 1; i >= 0; i--)
                        {
                            if (!string.IsNullOrEmpty(GlobalDic.DataSourceDicFee[i].instFlag) && GlobalDic.DataSourceDicFee[i].instFlag.ToUpper() == "T" &&
                                GlobalDic.DataSourceDicFee[i].leafFlag.ToUpper() == "T")
                            {
                                GlobalDic.DataSourceDicFee[i].pyCode = SpellCodeHelper.GetPyCode(GlobalDic.DataSourceDicFee[i].feeName);
                                GlobalDic.DataSourceDicFee[i].wbCode = SpellCodeHelper.GetWbCode(GlobalDic.DataSourceDicFee[i].feeName);
                            }
                            else
                            {
                                GlobalDic.DataSourceDicFee.RemoveAt(i);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDicMarry
        /// <summary>
        /// LoadDicMarry
        /// </summary>
        void LoadDicMarry()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    GlobalDic.DataSourceDicMarry = EntityTools.ConvertToEntityList<EntityCodeMarry>(proxy.Service.SelectFullTable(new EntityCodeMarry()));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDicCountry
        /// <summary>
        /// LoadDicCountry
        /// </summary>
        void LoadDicCountry()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    GlobalDic.DataSourceDicCountry = EntityTools.ConvertToEntityList<EntityCodeCountry>(proxy.Service.SelectFullTable(new EntityCodeCountry()));
                    if (GlobalDic.DataSourceDicCountry != null)
                    {
                        foreach (EntityCodeCountry item in GlobalDic.DataSourceDicCountry)
                        {
                            item.pyCode = SpellCodeHelper.GetPyCode(item.name);
                            item.wbCode = SpellCodeHelper.GetWbCode(item.name);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDicNation
        /// <summary>
        /// LoadDicNation
        /// </summary>
        void LoadDicNation()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    GlobalDic.DataSourceDicNation = EntityTools.ConvertToEntityList<EntityCodeNation>(proxy.Service.SelectFullTable(new EntityCodeNation()));
                    if (GlobalDic.DataSourceDicNation != null)
                    {
                        foreach (EntityCodeNation item in GlobalDic.DataSourceDicNation)
                        {
                            item.pyCode = SpellCodeHelper.GetPyCode(item.name);
                            item.wbCode = SpellCodeHelper.GetWbCode(item.name);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region LoadDicJob
        /// <summary>
        /// LoadDicJob
        /// </summary>
        void LoadDicJob()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    GlobalDic.DataSourceDicJob = EntityTools.ConvertToEntityList<EntityCodeJob>(proxy.Service.SelectFullTable(new EntityCodeJob()));
                    if (GlobalDic.DataSourceDicJob != null)
                    {
                        foreach (EntityCodeJob item in GlobalDic.DataSourceDicJob)
                        {
                            item.pyCode = SpellCodeHelper.GetPyCode(item.name);
                            item.wbCode = SpellCodeHelper.GetWbCode(item.name);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region 通用字典
        /// <summary>
        /// 通用字典
        /// </summary>
        void LoadDicCommon()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    GlobalDic.DataSourceDicCommon = EntityTools.ConvertToEntityList<EntityCommonDic>(proxy.Service.SelectFullTable(new EntityCommonDic()));
                    if (GlobalDic.DataSourceDicCommon != null)
                    {
                        foreach (EntityCommonDic item in GlobalDic.DataSourceDicCommon)
                        {
                            if (!string.IsNullOrEmpty(item.Itemname))
                            {
                                item.Pycode = SpellCodeHelper.GetPyCode(item.Itemname);
                                item.Wbcode = SpellCodeHelper.GetWbCode(item.Itemname);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region 病理分类
        /// <summary>
        /// 病理分类
        /// </summary>
        void LoadPisClass()
        {
            try
            {
                using (ProxyEntityFactory proxy = new ProxyEntityFactory())
                {
                    GlobalParm.PisClass = EntityTools.ConvertToEntityList<EntityPisClass>(proxy.Service.SelectFullTable(new EntityPisClass()));
                    if (GlobalParm.PisClass == null)
                    {
                        GlobalParm.PisClass = new List<EntityPisClass>();
                    }
                    else
                    {
                        List<EntityFormDesign> data = EntityTools.ConvertToEntityList<EntityFormDesign>(proxy.Service.SelectFullTable(new EntityFormDesign()));
                        foreach (EntityPisClass item in GlobalParm.PisClass)
                        {
                            if (data.Any(t => t.Formid == (int)item.formId))
                            {
                                item.layout = data.FirstOrDefault(t => t.Formid == (int)item.formId).Layout;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #endregion

        #endregion

        #region 窗体事件

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Init();
            }
            catch (Exception ex)
            {
                DialogBox.Msg(ex.Message);
                Application.Exit();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ReadAccountNo();
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.btnOk_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteAccountNo();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            Function.SendMessage(this.Handle);
        }

        private void picLogin_MouseDown(object sender, MouseEventArgs e)
        {
            Function.SendMessage(this.Handle);
        }

        private void picLnc_MouseDown(object sender, MouseEventArgs e)
        {
            Function.SendMessage(this.Handle);
        }

        private void appPic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BackColor = Color.Black;
        }

        private void appPic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BackColor = Color.Transparent;
        }

        private void appPic_MouseClick(object sender, MouseEventArgs e)
        {
            this.LoginModule((sender as PictureBox).Tag.ToString());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //using (ProxyLogin proxy = new ProxyLogin())
            //{
            //    DialogBox.Msg(proxy.Service.TestXml());
            //}
            this.Login();
        }

        private void picX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAccountNo_EditValueChanged(object sender, EventArgs e)
        {
            //this.lblAccountNo.Visible = (this.txtAccountNo.Text == string.Empty ? true : false);
            this.txtPwd.Text = string.Empty;
        }

        private void txtAccountNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.txtAccountNo.Text.Trim() != string.Empty)
            { this.txtPwd.Focus(); }
        }

        private void txtPwd_EditValueChanged(object sender, EventArgs e)
        {
            // this.lblPwd.Visible = (this.txtPwd.Text == string.Empty ? true : false);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
            this.Location = new Point((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2 - 50);
            this.Update();
            this.Refresh();
            this.Show();
            this.txtAccountNo.Focus();//txtPwd.Focus();
            this.txtAccountNo.SelectionLength = 0;
            this.txtAccountNo.SelectionStart = 0;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            AsyncLoadDic();
            IsAsync = false;
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk_Click(null, null);
            }
        }


        #endregion
    }
}
