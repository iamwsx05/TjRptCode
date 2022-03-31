using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityPisRecord
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "pisRecord")]
    public class EntityPisRecord : BaseDataContract
    {
        /// <summary>
        /// pNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pNo", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String pNo { get; set; }

        /// <summary>
        /// xmlData
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "xmlData", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String xmlData { get; set; }

        /// <summary>
        /// recDoctCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recDoctCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String recDoctCode { get; set; }

        /// <summary>
        /// recDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime recDate { get; set; }

        /// <summary>
        /// confDoctCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confDoctCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String confDoctCode { get; set; }

        /// <summary>
        /// confDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.DateTime? confDate { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 status { get; set; }

        [DataMember]
        public string recDoctName { get; set; }

        [DataMember]
        public string confDoctName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string pNo = "pNo";
            public string xmlData = "xmlData";
            public string recDoctCode = "recDoctCode";
            public string recDate = "recDate";
            public string confDoctCode = "confDoctCode";
            public string confDate = "confDate";
            public string status = "status";
            public string recDoctName = "recDoctName";
            public string confDoctName = "confDoctName";
        }
    }
}
