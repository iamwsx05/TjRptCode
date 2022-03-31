using Common.Controls;
using Common.Entity;
using weCare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hms.Entity;

namespace Hms.Ui
{
    /// <summary>
    /// 短信平台
    /// </summary>
    public partial class frm20404 : frmBaseMdi
    {
        #region ctor
        /// <summary>
        /// ctor
        /// </summary>
        public frm20404()
        {
            InitializeComponent();
        }
        #endregion

        #region var/property


        #endregion

        #region method

        public override void Remind()
        {
            DialogBox.Msg("发送短信 ing...");
        }

        public override void Preview()
        {
            uiHelper.Print(this.gcRight);
        }

        public override void Export()
        {
            uiHelper.ExportToXls(this.gvRight);
        }

        #region init
        /// <summary>
        /// Init
        /// </summary>
        void Init()
        {
            try
            {
                uiHelper.BeginLoading(this);

                List<EntitySMS> data1 = new List<EntitySMS>();
                data1.Add(new EntitySMS() { patName = "罗利威", telNo = "17502029***", sex = "男", age = "47", unitName = "中钢设备有限公司", patType = "VIP客户" });
                data1.Add(new EntitySMS() { patName = "何金龙", telNo = "15999813***", sex = "男", age = "24", unitName = "广州百特医疗有限公司", patType = "VIP客户" });
                data1.Add(new EntitySMS() { patName = "平琛民", telNo = "13929583***", sex = "男", age = "23", unitName = "广州百特医疗有限公司", patType = "VIP客户" });
                data1.Add(new EntitySMS() { patName = "李群", telNo = "15738471***", sex = "女", age = "25", unitName = "广州百特医疗有限公司", patType = "VIP客户" });
                data1.Add(new EntitySMS() { patName = "王小奇", telNo = "13242775***", sex = "男", age = "22", unitName = "广州百特医疗有限公司", patType = "VIP客户" });
                data1.Add(new EntitySMS() { patName = "王永刚", telNo = "18149039***", sex = "男", age = "28", unitName = "广州百特医疗有限公司", patType = "VIP客户" });
                this.gcLeft.DataSource = data1;

                List<EntitySMS> data2 = new List<EntitySMS>();
                data2.Add(new EntitySMS() { patName = "张津海", telNo = "18898608***", sex = "男" });
                data2.Add(new EntitySMS() { patName = "陈在培", telNo = "13420108***", sex = "男" });
                this.gcMid.DataSource = data2;

                List<EntitySMS> data3 = new List<EntitySMS>();
                data3.Add(new EntitySMS() { patName = "蔡志凤", telNo = "18826226***", sex = "女", SMS = "在4日国家卫健委发布会上，国家卫生健康委医政医管局副局长焦雅辉表示，针对湖北省重症病例较多的情况，已经建立院士团队巡查制度。钟南山院士团队、李兰娟院士团队、王晨院士团队对武汉市定点医院重症患者救治进行巡诊" });
                data3.Add(new EntitySMS() { patName = "谢胜标", telNo = "13802410***", sex = "男", SMS = "“今天一定要把这片沙漠路推出来。”天还未完全放亮，一阵发动机的轰鸣已唤醒沉寂的塔克拉玛干大沙漠腹地。为“伙伴”推土机做完体检后，胡军擦了擦手上的黑油，开始在连绵的沙丘中颠簸……" });
                data3.Add(new EntitySMS() { patName = "刘赛强", telNo = "18666167***", sex = "男", SMS = "每天胡军独自一人要按照测点在沙漠中推出10多公里的“路”，即使面对大沙包也不能绕行，“推出的路左右偏差只能小于12.5米，开着推土机在沙包上直上直下，有时候感觉像在坐过山车。”" });
                data3.Add(new EntitySMS() { patName = "杨放", telNo = "13929512***", sex = "女", SMS = "冬季的沙漠只有9月到来年的3月较为平静，虽然寒冷，但这是物探工人最好的施工期，这也意味着他们春节必须守在沙漠里，无法与家人团聚。" });
                this.gcRight.DataSource = data3;
            }
            finally
            {
                uiHelper.CloseLoading(this);
            }
        }
        #endregion

        #endregion

        #region event

        private void frm20404_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        #endregion

    }
}
