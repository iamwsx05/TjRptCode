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
    /// opRecWeChatPay
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRecWeChatPay")]
    public class EntityOpRecWeChatPay : BaseDataContract
    {
        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String recipeId { get; set; }

        /// <summary>
        /// Cardno
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

        /// <summary>
        /// Orichargeno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "oriChargeNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String oriChargeNo { get; set; }

        /// <summary>
        /// Refchargeno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refChargeNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String refChargeNo { get; set; }

        /// <summary>
        /// Invono
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "invoNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String invoNo { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.DateTime? recordDate { get; set; }

        /// <summary>
        /// responsexml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "responseXml", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String responseXml { get; set; }

        [DataMember]
        public string payAmt2 { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string recipeId = "recipeId";
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
            public string recordDate = "recordDate";
            public string payAmt2 = "payAmt2";
            public string responseXml = "responseXml";
        }
    }
}
