using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Console.Ui
{
    public partial class frmPassWord : Form
    {
        public frmPassWord()
        {
            InitializeComponent();
        }

        public frmPassWord(string p_strEmpNO)
            : this()
        {
            this.txtEmpNo.Text = p_strEmpNO;
            this.txtEmpNo.Enabled = false;
            this.txtOldPW.Focus();
        }

        /// <summary>
        /// 检查输入的信息
        /// </summary>
        /// <returns>是否通过</returns>
        private bool CheckInfo()
        {
            if (string.IsNullOrEmpty(txtEmpNo.Text.Trim()))
            {
                lblMsg.Text = "请输入工号";
                return false;
            }
            if (txtNewPW.Text.Trim() != txtConfrimPW.Text.Trim())
            {
                lblMsg.Text = "两次输入的密码不同";
                return false;
            }

            //新密码认证
            if (txtNewPW.Text == GlobalPatient.InitPwd)
            {
                lblMsg.Text = "新密码不能是账户初始密码，请重设。";
                this.txtNewPW.Focus();
                return false;
            }

            int intP1 = -1;
            if (GlobalParm.dicSysParameter.ContainsKey(1))
            {
                int.TryParse(GlobalParm.dicSysParameter[1], out intP1);
                if (intP1 > 0)
                {
                    if (txtNewPW.Text.Length < intP1)
                    {
                        lblMsg.Text = "新密码长度不能小于" + intP1.ToString() + "位数，请重设。";
                        this.txtNewPW.Focus();
                        return false;
                    }

                    Regex reg = new Regex(@"^\w*([a-zA-Z]+\d+|\d+[a-zA-Z]+)\w*$");
                    if (!reg.IsMatch(txtNewPW.Text))
                    {
                        lblMsg.Text = "新密码必须包含数字和字符，请重设。";
                        this.txtNewPW.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void frmPassWord_Load(object sender, EventArgs e)
        {
            txtEmpNo.Enabled = false;
            if (GlobalLogin.objLogin != null)
            {
                txtEmpNo.Text = GlobalLogin.objLogin.EmpNo;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                int intRet = 0;
                ProxyFrame proxy = new ProxyFrame();
                intRet = proxy.Service.ChangePassword(txtEmpNo.Text.Trim(), txtOldPW.Text.Trim(), txtNewPW.Text.Trim());
                proxy.Dispose();
                if (intRet > 0)
                {
                    DialogBox.Msg("修改密码成功", MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                }
                else if (intRet == 0)
                {
                    DialogBox.Msg("原密码有误", MessageBoxIcon.Information);
                }
                else
                {
                    DialogBox.Msg("修改密码失败", MessageBoxIcon.Information);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        #region 反射修改密码
        /// <summary>
        /// 反射修改密码
        /// </summary>
        /// <param name="empNo"></param>
        /// <param name="frmParent"></param>
        public void RefChangePassword(string empNo, Form frmParent)
        {
            this.txtEmpNo.Text = empNo;
            this.txtEmpNo.Enabled = false;
            this.txtOldPW.Focus();
            this.ShowDialog(frmParent);
        }

        #endregion
    }
}
