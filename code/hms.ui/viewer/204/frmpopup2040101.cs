using Common.Controls;
using Common.Utils;
using System;
using System.Collections.Generic;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System.Text;
using System.Windows.Forms;
using Hms.Entity;
using System.Data;

namespace Hms.Ui
{
    /// <summary>
    /// 创建计划
    /// </summary>
    public partial class frmPopup2040101 : frmBasePopup
    {
        public frmPopup2040101()
        {
            InitializeComponent();
        }

        #region var/property
        /// <summary>
        /// 是否要求刷新
        /// </summary>
        public bool IsRequireRefresh { get; set; }

        public EntityPromotionTemplateConfig promotionTemplateConfig { get; set; }

        List<EntityPromotionContentConfig> lstPromotionContents { get; set; }
        List<EntityPromotionWayConfig> lstPromotionWays { get; set; }
        #endregion

        #region methods
        void Init()
        {
            cboContent.Properties.Items.Clear();
            cboWays.Properties.Items.Clear();
            cboContent.Properties.Items.Add("未指定");
            cboWays.Properties.Items.Add("未指定");
            using (ProxyHms proxy = new ProxyHms())
            {
                lstPromotionContents = proxy.Service.GetPromotionContentConfigs();
                lstPromotionWays = proxy.Service.GetPromotionWayConfigs();

                if (lstPromotionContents != null)
                {
                    foreach(var content in lstPromotionContents)
                    {
                        cboContent.Properties.Items.Add(content.planContent);
                    }
                }

                if(lstPromotionWays != null)
                {
                    foreach (var way in lstPromotionWays)
                    {
                        cboWays.Properties.Items.Add(way.planWay);
                    }
                }
            }
        }
        #endregion

        #region event
        private void frmPopup2040101_Load(object sender, EventArgs e)
        {
            Init();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (promotionTemplateConfig == null)
                promotionTemplateConfig = new EntityPromotionTemplateConfig();
            promotionTemplateConfig.planPeriod = dtePlanDate.Text;
            promotionTemplateConfig.planWay = cboWays.Text;
            promotionTemplateConfig.planContent = cboContent.Text;
            promotionTemplateConfig.planRemind = txtTips.Text;

            IsRequireRefresh = true;
        }    
    }

    #endregion
}
