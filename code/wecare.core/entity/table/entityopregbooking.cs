using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// opRegBooking
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegBooking")]
    public class EntityOpRegBooking : BaseDataContract, IComparable
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Cardno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cardNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String cardNo { get; set; }

        /// <summary>
        /// Pid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String pid { get; set; }

        /// <summary>
        /// regDid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal regDid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// regType: 0 今日挂号; 1 网络（网站）预约； 2 微信预约；3 电话预约；4 现场预约；5 其他预约 
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 regType { get; set; }

        /// <summary>
        /// Regnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regNum", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String regNum { get; set; }

        /// <summary>
        /// Regdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String regDate { get; set; }

        /// <summary>
        /// Ampm
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amPm", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 amPm { get; set; }

        /// <summary>
        /// Starttime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "startTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String startTime { get; set; }

        /// <summary>
        /// Endtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "endTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String endTime { get; set; }

        /// <summary>
        /// Regcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String regCode { get; set; }

        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Doctcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String doctCode { get; set; }

        /// <summary>
        /// recorderCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorderCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String recorderCode { get; set; }

        /// <summary>
        /// cancelReason
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cancelReason", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String cancelReason { get; set; }

        /// <summary>
        /// Canceldate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cancelDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.DateTime? cancelDate { get; set; }

        /// <summary>
        /// Cancelopercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cancelOperCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String cancelOperCode { get; set; }

        /// <summary>
        /// Checkindate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "checkinDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.DateTime? checkinDate { get; set; }

        /// <summary>
        /// Checkinopercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "checkinOperCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String checkinOperCode { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// 微信公众服务平台唯一流水号
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "psOrdNum", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 22)]
        public string psOrdNum { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "lockStatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Int32 lockStatus { get; set; }

        /// <summary>
        /// 是否虚拟标志
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isVirtual", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.Int32 isVirtual { get; set; }

        /// <summary>
        /// 结算身份
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "settleCode", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 25)]
        public string settleCode { get; set; }

        [DataMember]
        public decimal numberSerNo { get; set; }

        [DataMember]
        public int check { get; set; }

        [DataMember]
        public int rowHandle { get; set; }

        [DataMember]
        public string startTime2 { get; set; }

        //[DataMember]
        //public string amPmName
        //{
        //    get
        //    {
        //        if (amPm == 1)
        //            return "上午";
        //        else if (amPm == 2)
        //            return "下午";
        //        else if (amPm == 3)
        //            return "晚上";
        //        else if (amPm == 4)
        //            return "中午";
        //        else
        //            return "";
        //    }
        //    set { ;}
        //}

        [DataMember]
        public string statusName
        {
            get
            {
                if (status == -2)
                    return "未报到";
                else if (status == -1)
                    return "取消";
                else if (status == 0)
                    return "预约";
                else if (status == 1)
                    return "已报到";
                else if (status == 9)   // UI端临时处理
                    return "挂号";
                else
                    return "";
            }
            set { ; }
        }

        [DataMember]
        public string regTypeName
        {
            //1 网络（网站）预约； 2 微信预约；3 电话预约；4 现场预约；5 其他预约 
            get
            {
                if (regType == 0)
                    return "现场";
                else if (regType == 1)
                    return "网站";
                else if (regType == 2)
                    return "微信";
                else if (regType == 3)
                    return "电话";
                else if (regType == 4)  // 现场预约
                {
                    if (doctCode == recorderCode)
                        return "诊间";
                    else
                        return "现场";
                }
                else if (regType == 5)
                    return "其他";
                else if (regType == 6)
                    return "诊间";
                else if (regType == 7)
                    return "APP";
                #region city platform
                else if (regType == 90)
                    return "网络";
                else if (regType == 91)
                    return "现场";
                else if (regType == 92)
                    return "电话";
                else if (regType == 93)
                    return "诊间";
                else if (regType == 94)
                    return "自助";
                else if (regType == 95)
                    return "住院";
                else if (regType == 96)
                    return "微信";
                else if (regType == 97)
                    return "支付宝";
                else if (regType == 98)
                    return "社区";
                else if (regType == 99)
                    return "星医";
                #endregion
                else
                    return "其他";
            }
            set { ;}
        }

        [DataMember]
        public string dateScope
        {
            get { return startTime + " ~ " + endTime; }
            set { ;}
        }

        [DataMember]
        public string regCodeName { get; set; }

        [DataMember]
        public string regFee { get; set; }

        [DataMember]
        public string doctFee { get; set; }

        [DataMember]
        public string deptName { get; set; }

        [DataMember]
        public string doctName { get; set; }

        [DataMember]
        public string patName { get; set; }

        [DataMember]
        public string sex { get; set; }

        [DataMember]
        public string age { get; set; }

        [DataMember]
        public string idNo { get; set; }

        [DataMember]
        public string contactTel { get; set; }

        [DataMember]
        public string contactAddr { get; set; }

        [DataMember]
        public string recorderName { get; set; }

        [DataMember]
        public string cancerName { get; set; }

        [DataMember]
        public string checkinOperName { get; set; }

        [DataMember]
        public string comment { get; set; }

        [DataMember]
        public string payAmt { get; set; }

        [DataMember]
        public string agtOrdNum { get; set; }

        [DataMember]
        public string invoNo { get; set; }

        [DataMember]
        public string refundReason { get; set; }

        [DataMember]
        public string refundTime { get; set; }

        [DataMember]
        public int feeStatus { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [DataMember]
        public string payMode { get; set; }

        [DataMember]
        public string oriRegNo { get; set; }

        [DataMember]
        public string feeStatusName
        {
            get
            {
                if (feeStatus == -1)
                    return "退费";
                else if (feeStatus == 0)
                    return "未收费";
                else if (feeStatus == 1)
                    return "收费";
                else
                    return "未收费";
            }
            set { ; }
        }

        /// <summary>
        /// 是否发送信息
        /// </summary>
        bool _isSendMsg = true;

        /// <summary>
        /// 是否发送信息
        /// </summary>
        [DataMember]
        public bool isSendMsg
        {
            get { return _isSendMsg; }
            set { _isSendMsg = value; }
        }

        /// <summary>
        /// 异常
        /// </summary>
        [DataMember]
        public string exception { get; set; }

        [DataMember]
        public string payTime { get; set; }

        [DataMember]
        public string accDate { get; set; }

        [DataMember]
        public string roomName { get; set; }

        [DataMember]
        public string roomDesc { get; set; }

        /// <summary>
        /// 是否附加号
        /// </summary>
        [DataMember]
        public bool isPlus { get; set; }

        /// <summary>
        /// 是否当天微信挂号
        /// </summary>
        [DataMember]
        public bool isTodayWeChat { get; set; }

        /// <summary>
        /// 记账金额
        /// </summary>
        [DataMember]
        public decimal acctAmt { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [DataMember]
        public decimal totalAmt { get; set; }

        /// <summary>
        /// 自付金额
        /// </summary>
        [DataMember]
        public decimal selfAmt { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        [DataMember]
        public string birthday { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string serNo = "serNo";
            public string cardNo = "cardNo";
            public string pid = "pid";
            public string regDid = "regDid";
            public string recordDate = "recordDate";
            public string regType = "regType";
            public string regNum = "regNum";
            public string regDate = "regDate";
            public string amPm = "amPm";
            public string startTime = "startTime";
            public string endTime = "endTime";
            public string regCode = "regCode";
            public string deptCode = "deptCode";
            public string doctCode = "doctCode";
            public string recorderCode = "recorderCode";
            public string cancelReason = "cancelReason";
            public string cancelDate = "cancelDate";
            public string cancelOperCode = "cancelOperCode";
            public string checkinDate = "checkinDate";
            public string checkinOperCode = "checkinOperCode";
            public string status = "status";
            public string numberSerNo = "numberSerNo";
            public string check = "check";
            public string statusName = "statusName";
            public string dateScope = "dateScope";
            public string regCodeName = "regCodeName";
            public string regFee = "regFee";
            public string doctFee = "doctFee";
            public string deptName = "deptName";
            public string doctName = "doctName";
            public string rowHandle = "rowHandle";
            public string patName = "patName";
            public string sex = "sex";
            public string age = "age";
            public string idNo = "idNo";
            public string contactTel = "contactTel";
            public string contactAddr = "contactAddr";
            public string recorderName = "recorderName";
            public string cancerName = "cancerName";
            public string checkinOperName = "checkinOperName";
            public string psOrdNum = "psOrdNum";
            public string comment = "comment";
            public string regTypeName = "regTypeName";
            public string startTime2 = "startTime2";
            public string lockStatus = "lockStatus";
            public string isVirtual = "isVirtual";

            public string payAmt = "payAmt";
            public string agtOrdNum = "agtOrdNum";
            public string invoNo = "invoNo";
            public string refundReason = "refundReason";
            public string refundTime = "refundTime";
            public string feeStatus = "feeStatus";
            public string feeStatusName = "feeStatusName";
            public string payMode = "payMode";
            public string oriRegNo = "oriRegNo";
            public string exception = "exception";
            public string payTime = "payTime";
            public string accDate = "accDate";
            public string settleCode = "settleCode";
        }

        public int CompareTo(object obj)
        {
            if (obj is EntityOpRegBooking)
            {
                return this.accDate.CompareTo(((EntityOpRegBooking)obj).accDate);
            }
            return 0;
        }
    }

}
