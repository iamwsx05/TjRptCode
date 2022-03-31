using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Hms.Entity
{
    /// <summary>
    /// EntityQnRecord
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "qnRecord")]
    public class EntityQnRecord : BaseDataContract
    {
        /// <summary>
        /// recId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Decimal recId { get; set; }

        /// <summary>
        /// clientNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "clientNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String clientNo { get; set; }

        /// <summary>
        /// qnType
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "qnType", DbType = DbType.Int16, IsPK = false, IsSeq = false, SerNo = 3)]
        public int qnType { get; set; }

        /// <summary>
        /// qnName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "qnName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public string qnName { get; set; }

        /// <summary>
        /// qnDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "qnDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.DateTime qnDate { get; set; }

        /// <summary>
        /// qnSource
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "qnSource", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal qnSource { get; set; }
        [DataMember]
        public string strQnSource { get; set; }

        /// <summary>
        /// recorder
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorder", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String recorder { get; set; }

        /// <summary>
        /// recordDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal status { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "qnId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public decimal qnId { get; set; }

        [DataMember]
        public string clientName { get; set; }
        [DataMember]
        public int gender { get; set; }
        [DataMember]
        public string sex { get; set; }
        [DataMember]
        public string age{ get ; set ; }
        [DataMember]
        public string gradeName { get; set; }
        [DataMember]
        public string strQnDate { get; set; } 

        [DataMember]
        public string xmlData { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string recId = "recId";
            public string clientNo = "clientNo";
            public string qnName = "qnName";
            public string qnType = "qnType";
            public string qnDate = "qnDate";
            public string qnSource = "qnSource";
            public string recorder = "recorder";
            public string recordDate = "recordDate";
            public string status = "status";
        }
    }
}
