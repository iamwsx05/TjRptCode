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
    /// opRegUnionPay
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegUnionPay")]
    public class EntityOpRegUnionPay : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Clientno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "clientNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String clientNo { get; set; }

        /// <summary>
        /// Bankcardno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bankCardNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String bankCardNo { get; set; }

        /// <summary>
        /// Cardno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cardNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String cardNo { get; set; }

        /// <summary>
        /// Banktranno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bankTranNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String bankTranNo { get; set; }

        /// <summary>
        /// Chgnoteid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "chgnoteId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String chgnoteId { get; set; }

        /// <summary>
        /// Reftranno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refTranNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String refTranNo { get; set; }

        /// <summary>
        /// Reftac
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refTac", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String refTac { get; set; }

        /// <summary>
        /// Sitype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "siType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String siType { get; set; }

        /// <summary>
        /// Payamt
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payAmt", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal payAmt { get; set; }

        /// <summary>
        /// Paytime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String payTime { get; set; }

        /// <summary>
        /// Refundtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refundTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String refundTime { get; set; }

        /// <summary>
        /// Refundreason
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refundReason", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String refundReason { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal status { get; set; }

        /// <summary>
        /// Orichargeno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "oriChargeNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String oriChargeNo { get; set; }

        /// <summary>
        /// Refchargeno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refChargeNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String refChargeNo { get; set; }

        /// <summary>
        /// Invono
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "invoNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String invoNo { get; set; }

        /// <summary>
        /// Oriregno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "oriRegNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String oriRegNo { get; set; }

        /// <summary>
        /// Refregno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refRegNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String refRegNo { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.DateTime? recordDate { get; set; }

        [DataMember]
        public int isBk { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [DataMember]
        public decimal acctAmt { get; set; }

        [DataMember]
        public string settleCode { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        [DataMember]
        public string payMode { get; set; }

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
            public string clientNo = "clientNo";
            public string bankCardNo = "bankCardNo";
            public string cardNo = "cardNo";
            public string bankTranNo = "bankTranNo";
            public string chgnoteId = "chgnoteId";
            public string refTranNo = "refTranNo";
            public string refTac = "refTac";
            public string siType = "siType";
            public string payAmt = "payAmt";
            public string payTime = "payTime";
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
            public string acctAmt = "acctAmt";
            public string settleCode = "settleCode";
            public string payMode = "payMode";
        }
    }
}
