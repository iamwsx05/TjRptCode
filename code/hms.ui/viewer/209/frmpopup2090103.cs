using Common.Controls;
using System;
using System.Windows.Forms;
using weCare.Core.Entity;

namespace Hms.Ui
{
    /// <summary>
    /// 问卷预览
    /// </summary>
    public partial class frmPopup2090103 : frmBasePopup
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frmPopup2090103()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }
        #endregion

        #region var/property

        EntityDicQnMain QnVo { get; set; }

        #endregion

        #region method


        #endregion

        #region event

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="_qnVo"></param>
        public frmPopup2090103(EntityDicQnMain _qnVo)
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.QnVo = _qnVo;
        }

        private void frmPopup2090103_Load(object sender, EventArgs e)
        {
            this.customQN.QnVo = this.QnVo;
            this.customQN.InitComponent(this.QnVo.qnId);
        }

        #endregion

    }
}
