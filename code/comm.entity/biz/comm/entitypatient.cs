using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Common.Entity
{
    #region 全局病人基本资料
    /// <summary>
    /// 全局病人基本资料
    /// </summary>
    [DataContract, Serializable]
    public class EntityPatient : BaseDataContract, IComparable
    {
        /// <summary>
        /// 病人ID
        /// </summary>
        [DataMember]
        public string PatientID { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        [DataMember]
        public string PatientName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [DataMember]
        public string Sex { get; set; }
        /// <summary>
        /// 性别(中文)
        /// </summary>
        [DataMember]
        public string SexCH
        {
            get
            {
                if (Sex == "1")
                    return "男";
                else if (Sex == "2")
                    return "女";
                else if (Sex == "男")
                    return "男";
                else if (Sex == "女")
                    return "女";
                else
                    return string.Empty;
            }
            set { ;}
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        [DataMember]
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [DataMember]
        public string AgeStr { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        [DataMember]
        public string Nationality { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        [DataMember]
        public string NativePlace { get; set; }
        /// <summary>
        /// 出生地
        /// </summary>
        [DataMember]
        public string BirthPlace { get; set; }
        /// <summary>
        /// 婚姻
        /// </summary>
        [DataMember]
        public string Marriage { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        [DataMember]
        public string IdCard { get; set; }
        /// <summary>
        /// 身高
        /// </summary>
        [DataMember]
        public string Stature { get; set; }
        /// <summary>
        /// 体重
        /// </summary>
        [DataMember]
        public string Weight { get; set; }
        /// <summary>
        /// 血型
        /// </summary>
        [DataMember]
        public string Blood { get; set; }
        /// <summary>
        /// 职业
        /// </summary>
        [DataMember]
        public string Occupation { get; set; }
        /// <summary>
        /// 家庭地址
        /// </summary>
        [DataMember]
        public string HomeAddr { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        [DataMember]
        public string HomeTel { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        [DataMember]
        public string HomeZip { get; set; }
        /// <summary>
        /// 工作单位
        /// </summary>
        [DataMember]
        public string WorkUnit { get; set; }
        /// <summary>
        /// 工作电话
        /// </summary>
        [DataMember]
        public string WorkTel { get; set; }
        /// <summary>
        /// 单位邮编
        /// </summary>
        [DataMember]
        public string WorkZip { get; set; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        [DataMember]
        public string ContactName { get; set; }
        /// <summary>
        /// 联系人电话
        /// </summary>
        [DataMember]
        public string ContactTel { get; set; }
        /// <summary>
        /// 联系人地址
        /// </summary>
        [DataMember]
        public string ContactAddr { get; set; }
        /// <summary>
        /// 关系(病人与联系人)
        /// </summary>
        [DataMember]
        public string ContactRelation { get; set; }
        /// <summary>
        /// 国籍
        /// </summary>
        [DataMember]
        public string CitizenShip { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [DataMember]
        public int Status { get; set; }
        /// <summary>
        /// 登记人ID
        /// </summary>
        [DataMember]
        public string OperId { get; set; }
        /// <summary>
        /// 登记时间
        /// </summary>
        [DataMember]
        public DateTime OperDate { get; set; }

        /// <summary>
        /// 住院登记流水ID/门诊挂号流水ID
        /// </summary>
        [DataMember]
        public string RegisterID { get; set; }
        /// <summary>
        /// 住院号
        /// </summary>
        [DataMember]
        public string PatientIpNo { get; set; }
        /// <summary>
        /// 住院次数
        /// </summary>
        [DataMember]
        public int IpTimes { get; set; }
        /// <summary>
        /// 住院时间
        /// </summary>
        [DataMember]
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// 入病区时间
        /// </summary>
        [DataMember]
        public DateTime? Indate { get; set; }
        /// <summary>
        /// 入院诊断(文本)
        /// </summary>
        [DataMember]
        public string InDiagnosis { get; set; }

        /// <summary>
        /// 出院时间
        /// </summary>
        [DataMember]
        public DateTime? OutDate { get; set; }
        /// <summary>
        /// 科室ID
        /// </summary>
        [DataMember]
        public string DeptID { get; set; }
        /// <summary>
        /// 科室编号
        /// </summary>
        [DataMember]
        public string DeptNo { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        [DataMember]
        public string DeptName { get; set; }
        /// <summary>
        /// 病区ID
        /// </summary>
        [DataMember]
        public string AreaID { get; set; }
        /// <summary>
        /// 病区编号
        /// </summary>
        [DataMember]
        public string AreaNo { get; set; }
        /// <summary>
        /// 病区名称
        /// </summary>
        [DataMember]
        public string AreaName { get; set; }
        /// <summary>
        /// 床ID
        /// </summary>
        [DataMember]
        public string BedID { get; set; }
        /// <summary>
        /// 床号
        /// </summary>
        [DataMember]
        public string BedNo { get; set; }
        /// <summary>
        /// 床.排序号
        /// </summary>
        [DataMember]
        public int BedSortNo { get; set; }
        /// <summary>
        /// 主治医生ID
        /// </summary>
        [DataMember]
        public string DoctID { get; set; }
        /// <summary>
        /// 主治医生工号
        /// </summary>
        [DataMember]
        public string DoctNo { get; set; }
        /// <summary>
        /// 主治医生名称
        /// </summary>
        [DataMember]
        public string DoctName { get; set; }
        /// <summary>
        /// 医院名称
        /// </summary>
        [DataMember]
        public string HospitalName { get; set; }
        /// <summary>
        /// 费别.code
        /// </summary>
        [DataMember]
        public string FeeCode { get; set; }
        /// <summary>
        /// 费别.名称
        /// </summary>
        [DataMember]
        public string FeeName { get; set; }
        /// <summary>
        /// 护理等级
        /// </summary>
        [DataMember]
        public string Carelevel
        {
            get;
            set;
        }
        /// <summary>
        /// 护理等级
        /// </summary>
        [DataMember]
        public string CarelevelName
        {
            get;
            set;
            //get
            //{
            //    if (Carelevel == -1)
            //    {
            //        return "  ";// "无";
            //    }
            //    else if (Carelevel == 0)
            //    {
            //        return "特级护理";
            //    }
            //    else if (Carelevel == 1)
            //    {
            //        return "一级护理";
            //    }
            //    else if (Carelevel == 2)
            //    {
            //        return "二级护理";
            //    }
            //    else if (Carelevel == 3)
            //    {
            //        return "三级护理";
            //    }
            //    else
            //    {
            //        return string.Empty;
            //    }
            //}
        }
        /// <summary>
        /// 护理等级(简)
        /// </summary>
        [DataMember]
        public string CarelevelNameSimple
        {
            get;
            set;
            //get
            //{
            //    if (Carelevel == -1)
            //    {
            //        return "";
            //    }
            //    else if (Carelevel == 0)
            //    {
            //        return "特级";
            //    }
            //    else if (Carelevel == 1)
            //    {
            //        return "一级";
            //    }
            //    else if (Carelevel == 2)
            //    {
            //        return "二级";
            //    }
            //    else if (Carelevel == 3)
            //    {
            //        return "三级";
            //    }
            //    else
            //    {
            //        return string.Empty;
            //    }
            //}
        }
        /// <summary>
        /// 病人类型 0 在院 1 转科 2 出院
        /// </summary>
        [DataMember]
        public int PatType { get; set; }
        /// <summary>
        /// 转科转床信息列表
        /// </summary>
        [DataMember]
        public List<EntityPatientTransDept> PatientTransDeptInfo { get; set; }

        /// <summary>
        /// ToolTip
        /// </summary>
        [DataMember]
        public string ToolTip { get; set; }
        /// <summary>
        /// 列表索引
        /// </summary>
        [DataMember]
        public int ListIndex { get; set; }

        /// <summary>
        /// 拼音码
        /// </summary>
        [DataMember]
        public string PyCode { get; set; }
        /// <summary>
        /// 五笔码
        /// </summary>
        [DataMember]
        public string WbCode { get; set; }
        /// <summary>
        /// 借阅标志
        /// </summary>
        [DataMember]
        public bool BorrowFlag { get; set; }

        /// <summary>
        /// 表单CODE
        /// </summary>
        [DataMember]
        public string CaseCode { get; set; }

        /// <summary>
        /// 比较列
        /// </summary>
        private string _CompareCol { get; set; }
        /// <summary>
        /// 比较列
        /// </summary>
        [DataMember]
        public string CompareCol
        {
            get { return DeptName + AreaName + BedNo; }
            set { _CompareCol = value; }
        }

        /********门诊信息*********/

        private string _PatientOpNo { get; set; }
        /// <summary>
        /// 门诊号
        /// </summary>
        [DataMember]
        public string PatientOpNo
        {
            get;
            set;
            //set
            //{
            //    _PatientOpNo = value;
            //}
            //get
            //{
            //    _PatientOpNo = string.Empty;
            //    string strPid = string.Empty;
            //    int intPid = 0;
            //    int.TryParse(PatientID, out intPid);
            //    if (intPid > 0)
            //    {
            //        strPid = intPid.ToString();
            //        for (int k = strPid.Length - 1; k >= 0; k--)
            //        {
            //            if (int.Parse(strPid.Substring(k, 1)) > 0)
            //            {
            //                _PatientOpNo = strPid.Substring(0, k + 1);
            //                break;
            //            }
            //        }
            //    }
            //    return _PatientOpNo;
            //}
        }
        /// <summary>
        /// 门诊本次接诊流水ID
        /// </summary>
        [DataMember]
        public int OPRegSerNo { get; set; }
        /// <summary>
        /// 就诊次数
        /// </summary>
        [DataMember]
        public int Diagtimes { get; set; }
        /// <summary>
        /// 门诊次数
        /// </summary>
        [DataMember]
        public int OpTimes { get; set; }
        /// <summary>
        /// 就诊状态
        /// </summary>
        [DataMember]
        public int Diagstatus { get; set; }
        /// <summary>
        /// 接诊时间
        /// </summary>
        [DataMember]
        public DateTime Recdate { get; set; }
        /// <summary>
        /// 卡类型
        /// </summary>
        [DataMember]
        public string CardType { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        [DataMember]
        public string CardNo { get; set; }

        //新增
        /// <summary>
        /// 文化(程度)
        /// </summary>
        [DataMember]
        public string Education { get; set; }
        /// <summary>
        /// 监护人
        /// </summary>
        [DataMember]
        public string Guardian { get; set; }
        /// <summary>
        /// 监护人地址
        /// </summary>
        [DataMember]
        public string GuardianAddr { get; set; }
        /// <summary>
        /// 监护人电话
        /// </summary>
        [DataMember]
        public string GuardianTel { get; set; }
        /// <summary>
        /// 关系(监护人与患者)
        /// </summary>
        [DataMember]
        public string GuardRelation { get; set; }
        /// <summary>
        /// 门诊诊断
        /// </summary>
        [DataMember]
        public string OpDiagnosis { get; set; }

        /// <summary>
        /// 门诊处理(描述)
        /// </summary>
        [DataMember]
        public string OpDescription { get; set; }

        /// <summary>
        /// 过敏信息
        /// </summary>
        [DataMember]
        public string AllergyInfo { get; set; }

        /// <summary>
        /// ICD列表
        /// </summary>
        [DataMember]
        public List<string> ICD { get; set; }

        /// <summary>
        /// 户籍地址
        /// </summary>
        [DataMember]
        public string HouseHoldRegAddr { get; set; }

        /// <summary>
        /// 门诊复诊标志
        /// </summary>
        [DataMember]
        public int OpDiagMoreflag { get; set; }

        [DataMember]
        public string GlobalID { get; set; }

        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityPatient)
            {
                //return this.CompareCol.CompareTo(((EntityPatient)obj).CompareCol);
                return this.BedSortNo.CompareTo(((EntityPatient)obj).BedSortNo);
            }
            return 0;
        }

        /******************************/
        /// <summary>
        /// 所在库.KEY
        /// </summary>
        [DataMember]
        public string DbKey { get; set; }
        /// <summary>
        /// 上级医生ID
        /// </summary>
        [DataMember]
        public string SupDoctID { get; set; }
        /// <summary>
        /// 科主任ID
        /// </summary>
        [DataMember]
        public string DirDoctID { get; set; }
        /// <summary>
        /// 专业组ID
        /// </summary>
        [DataMember]
        public string TermID { get; set; }
        /// <summary>
        /// 护理组号
        /// </summary>
        [DataMember]
        public string NurGroupNo { get; set; }
        /// <summary>
        /// 入院(病情)情况
        /// </summary>
        [DataMember]
        public string IllnessState { get; set; }


        /********费用信息*********/

        /// <summary>
        /// 预交金
        /// </summary>
        [DataMember]
        public decimal PreMoney { get; set; }

        /// <summary>
        /// 总费用
        /// </summary>
        [DataMember]
        public decimal TotalMoney { get; set; }

        /// <summary>
        /// 记账费用
        /// </summary>
        [DataMember]
        public decimal AcctMoney { get; set; }

        /// <summary>
        /// 自付费用
        /// </summary>
        [DataMember]
        public decimal SelfMoney { get; set; }

        /// <summary>
        /// 欠费费用
        /// </summary>
        [DataMember]
        public decimal ArrearMoney { get; set; }

        /// <summary>
        /// 身份ID
        /// </summary>
        [DataMember]
        public string IdentityID { get; set; }

        /// <summary>
        /// 身份名称
        /// </summary>
        [DataMember]
        public string IdentityName { get; set; }

        /*********************/

        /// <summary>
        /// 病人类型 1 门诊 2 住院
        /// </summary>
        [DataMember]
        public string PatientType { get; set; }

        /// <summary>
        /// 滚费主键ID
        /// </summary>
        [DataMember]
        public int RollFeeID { get; set; }

        /// <summary>
        /// 滚费时间
        /// </summary>
        [DataMember]
        public DateTime RollDateTime { get; set; }


        /*********************/

        /// <summary>
        /// 诊断信息
        /// </summary>
        [DataMember]
        public string DiagnoseInfo { get; set; }

        //[DataMember]
        //public List<EntityPatientCp> CpInfo { get; set; }

        /// <summary>
        /// 选择节点名
        /// </summary>
        [DataMember]
        public string SelectedNodeName { get; set; }

        /// <summary>
        /// 母婴登记号
        /// </summary>
        [DataMember]
        public string MRegisterID { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string PatientIpNo = "PatientIpNo";
            public string BedNo = "BedNo";
            public string PatientName = "PatientName";
            public string SexCH = "SexCH";
            public string RegisterID = "RegisterID";
            public string BedID = "BedID";
            public string CarelevelName = "CarelevelName";
        }

        /********************************************/

        [DataMember]
        public string NurseID { get; set; }

        [DataMember]
        public string NurseNo { get; set; }

        /// <summary>
        /// 主管护士
        /// </summary>
        [DataMember]
        public string NurseName { get; set; }

        /// <summary>
        /// 饮食
        /// </summary>
        [DataMember]
        public string DietName { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [DataMember]
        public string Age
        {
            get
            {
                if (!string.IsNullOrEmpty(RegisterID))
                {
                    return weCare.Core.Utils.CalcAge.GetAge(Birthday);
                }
                return string.Empty;
            }
            set { ;}
        }

        /// <summary>
        /// 入院时间字符串
        /// </summary>
        [DataMember]
        public string InDateStr
        {
            get
            {
                if (!string.IsNullOrEmpty(RegisterID))
                {
                    return RegisterDate.ToString("yyyy-MM-dd HH:mm");
                }
                return string.Empty;
            }
            set { ;}
        }

        /// <summary>
        /// 入院次数字符串
        /// </summary>
        [DataMember]
        public string IpTimesStr
        {
            get
            {
                if (IpTimes > 0)
                    return IpTimes.ToString();
                return string.Empty;
            }
            set { ;}
        }

        /// <summary>
        /// 未结费用
        /// </summary>
        [DataMember]
        public decimal NoChargeMoney { get; set; }

        /// <summary>
        /// 预交金
        /// </summary>
        [DataMember]
        public decimal DepositMoney { get; set; }

        /// <summary>
        /// 科室欠费上限
        /// </summary>
        [DataMember]
        public decimal DeptLimitUpper { get; set; }

        /// <summary>
        /// 科室欠费下限
        /// </summary>
        [DataMember]
        public decimal DeptLimitLower { get; set; }

        /// <summary>
        /// 是否医院允许欠费继续开医嘱
        /// </summary>
        [DataMember]
        public bool IsHospAllowLimit { get; set; }

        /// <summary>
        /// 是否科室允许欠费继续开医嘱
        /// </summary>
        [DataMember]
        public bool isDeptAllowLimit { get; set; }

        /// <summary>
        /// 户口地址
        /// </summary>
        [DataMember]
        public string patHkadr { get; set; }

        /// <summary>
        /// 与联系人关系
        /// </summary>
        [DataMember]
        public string patContactRelation { get; set; }

        /// <summary>
        /// 体温
        /// </summary>
        [DataMember]
        public string patTemperature { get; set; }

        /// <summary>
        /// 脉搏
        /// </summary>
        [DataMember]
        public string patPulse { get; set; }

        /// <summary>
        /// 呼吸
        /// </summary>
        [DataMember]
        public string patBreath { get; set; }

        /// <summary>
        /// 血压
        /// </summary>
        [DataMember]
        public string patBloodPressure { get; set; }
         
    }
    #endregion

    #region 转科转床信息
    /// <summary>
    /// 转科转床信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityPatientTransDept : BaseDataContract
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [DataMember]
        public DateTime BeginDate { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [DataMember]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 入院登记ID
        /// </summary>
        [DataMember]
        public string RegisterID { get; set; }
        /// <summary>
        /// 科室ID
        /// </summary>
        [DataMember]
        public string DeptID { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        [DataMember]
        public string DeptName { get; set; }
        /// <summary>
        /// 病区ID
        /// </summary>
        [DataMember]
        public int? AreaID { get; set; }
        /// <summary>
        /// 病区名称
        /// </summary>
        [DataMember]
        public string AreaName { get; set; }
        /// <summary>
        /// 病床ID
        /// </summary>
        [DataMember]
        public int? BedID { get; set; }
        /// <summary>
        /// 病床号
        /// </summary>
        [DataMember]
        public string BedNO { get; set; }
        /// <summary>
        /// 医生ID
        /// </summary>
        [DataMember]
        public string DoctID { get; set; }
        /// <summary>
        /// 医生名称
        /// </summary>
        [DataMember]
        public string DoctName { get; set; }
    }
    #endregion

}
