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
    /// opRegWeChatPay
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegWeChatPay")]
    public class EntityOpRegWeChatPay : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// cardNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cardNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String cardNo { get; set; }

        /// <summary>
        /// Psordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "psOrdNum", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String psOrdNum { get; set; }

        /// <summary>
        /// Psrefordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "psRefOrdNum", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String psRefOrdNum { get; set; }

        /// <summary>
        /// Paymode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payMode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String payMode { get; set; }

        /// <summary>
        /// Payamt
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payAmt", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal payAmt { get; set; }

        /// <summary>
        /// Paytime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String payTime { get; set; }

        /// <summary>
        /// Agtordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "agtOrdNum", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String agtOrdNum { get; set; }

        /// <summary>
        /// Agtrefordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "agtRefOrdNum", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String agtRefOrdNum { get; set; }

        /// <summary>
        /// Refundtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refundTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String refundTime { get; set; }

        /// <summary>
        /// Refundreason
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refundReason", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String refundReason { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal status { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "oriChargeNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String oriChargeNo { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "refChargeNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String refChargeNo { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "invoNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String invoNo { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "oriRegNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String oriRegNo { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "refRegNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String refRegNo { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.DateTime recordDate { get; set; }

        [DataMember]
        public int isBk { get; set; }

        /// <summary>
        /// 结算身份: 00 自费; 01 社保一卡通; 02 门特门慢; 03 生育产检
        /// </summary>
        [DataMember]
        public string settleCode { get; set; }

        /// <summary>
        /// 记账金额
        /// </summary>
        [DataMember]
        public decimal acctAmt { get; set; }

        /// <summary>
        /// PID
        /// </summary>
        [DataMember]
        public string patientId { get; set; }

        /// <summary>
        /// deptId
        /// </summary>
        [DataMember]
        public string deptId { get; set; }

        /// <summary>
        /// deptCode
        /// </summary>
        [DataMember]
        public string deptCode { get; set; }

        /// <summary>
        /// deptName
        /// </summary>
        [DataMember]
        public string deptName { get; set; }

        /// <summary>
        /// doctId
        /// </summary>
        [DataMember]
        public string doctId { get; set; }

        /// <summary>
        /// doctCode
        /// </summary>
        [DataMember]
        public string doctCode { get; set; }

        /// <summary>
        /// doctName
        /// </summary>
        [DataMember]
        public string doctName { get; set; }

        /// <summary>
        /// shiftName
        /// </summary>
        [DataMember]
        public string shiftName { get; set; }

        /// <summary>
        /// (医生)诊查费编码
        /// </summary>
        [DataMember]
        public string doctItemCode { get; set; }

        /// <summary>
        /// (医生)诊查费单价
        /// </summary>
        [DataMember]
        public decimal doctItemPrice { get; set; }

        /// <summary>
        /// 预约时间
        /// </summary>
        [DataMember]
        public string regDate { get; set; }
        
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
            public string psOrdNum = "psOrdNum";
            public string psRefOrdNum = "psRefOrdNum";
            public string payMode = "payMode";
            public string payAmt = "payAmt";
            public string payTime = "payTime";
            public string agtOrdNum = "agtOrdNum";
            public string agtRefOrdNum = "agtRefOrdNum";
            public string refundTime = "refundTime";
            public string refundReason = "refundReason";
            public string status = "status";
            public string oriChargeNo = "oriChargeNo";
            public string refChargeNo = "refChargeNo";
            public string invoNo = "invoNo";
            public string oriRegNo = "oriRegNo";
            public string refRegNo = "refRegNo";
            public string recordDate = "recordDate";
            public string isBk = "isBk";
            public string patientId = "patientId";
            public string deptCode = "deptCode";
            public string doctId = "doctId";
            public string doctCode = "doctCode";
            public string shiftName = "shiftName";
        }
    }

}
