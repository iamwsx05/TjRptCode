using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// dicHerbalrecipetype
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicHerbalrecipetype")]
    public class EntityDicHerbalrecipetype : BaseDataContract
    {
        /// <summary>
        /// Hrtypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hrTypeId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 hrTypeId { get; set; }

        /// <summary>
        /// Hrtypecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hrTypeCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String hrTypeCode { get; set; }

        /// <summary>
        /// Hrtypename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hrTypeName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String hrTypeName { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pyCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Decid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String decId { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string hrTypeId = "hrTypeId";
            public string hrTypeCode = "hrTypeCode";
            public string hrTypeName = "hrTypeName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string decId = "decId";
            public string status = "status";
        }
    }

}
