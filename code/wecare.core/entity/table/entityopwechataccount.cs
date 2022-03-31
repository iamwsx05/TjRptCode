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
    /// EntityOpWeChatAccount
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opWeChatAccount")]
    public class EntityOpWeChatAccount : BaseDataContract
    {
        /// <summary>
        /// Accdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "accDate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String accDate { get; set; }

        /// <summary>
        /// Agtordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "agtOrdNum", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String agtOrdNum { get; set; }

        /// <summary>
        /// Hisordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hisOrdNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal hisOrdNum { get; set; }

        /// <summary>
        /// Psordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "psOrdNum", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String psOrdNum { get; set; }

        /// <summary>
        /// Ordertype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String orderType { get; set; }

        /// <summary>
        /// Paymode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payMode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String payMode { get; set; }

        /// <summary>
        /// Payamt
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payAmt", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal payAmt { get; set; }

        /// <summary>
        /// Paytime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String payTime { get; set; }

        /// <summary>
        /// Oldagtordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "oldAgtOrdNum", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String oldAgtOrdNum { get; set; }

        /// <summary>
        /// Oldpsordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "oldPsOrdNum", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String oldPsOrdNum { get; set; }

        /// <summary>
        /// Oldhisordnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "oldHisOrdNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal? oldHisOrdNum { get; set; }

        /// <summary>
        /// Feetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "feeType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String feeType { get; set; }

        /// <summary>
        /// Cardno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cardNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String cardNo { get; set; }

        /// <summary>
        /// Patname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String patName { get; set; }

        /// <summary>
        /// Recorder
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorder", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String recorder { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// payType
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "payType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String payType { get; set; }

        [DataMember]
        public int status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string accDate = "accDate";
            public string agtOrdNum = "agtOrdNum";
            public string hisOrdNum = "hisOrdNum";
            public string psOrdNum = "psOrdNum";
            public string orderType = "orderType";
            public string payMode = "payMode";
            public string payAmt = "payAmt";
            public string payTime = "payTime";
            public string oldAgtOrdNum = "oldAgtOrdNum";
            public string oldPsOrdNum = "oldPsOrdNum";
            public string oldHisOrdNum = "oldHisOrdNum";
            public string feeType = "feeType";
            public string cardNo = "cardNo";
            public string patName = "patName";
            public string recorder = "recorder";
            public string recordDate = "recordDate";
            public string status = "status";
            public string payType = "payType";
        }
    }

}
