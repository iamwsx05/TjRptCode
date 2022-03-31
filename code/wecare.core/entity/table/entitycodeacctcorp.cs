using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_ACCTCORP
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_ACCTCORP")]
    public class EntityCodeAcctcorp : BaseDataContract
    {
        /// <summary>
        /// SCOPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SCOPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String scope { get; set; }

        /// <summary>
        /// CORP_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CORP_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String corpCode { get; set; }

        /// <summary>
        /// CORP_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CORP_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String corpName { get; set; }

        /// <summary>
        /// ADDR
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ADDR", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String addr { get; set; }

        /// <summary>
        /// CONTACT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CONTACT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String contact { get; set; }

        /// <summary>
        /// TEL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TEL", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String tel { get; set; }

        /// <summary>
        /// CORP_KIND
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CORP_KIND", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String corpKind { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string scope = "scope";
            public string corpCode = "corpCode";
            public string corpName = "corpName";
            public string addr = "addr";
            public string contact = "contact";
            public string tel = "tel";
            public string corpKind = "corpKind";
        }
    }

}
