using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// BC_REQENTRY_PACS
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "BC_REQENTRY_PACS")]
    public class EntityBcReqentryPacs : BaseDataContract
    {
        /// <summary>
        /// REQ_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REQ_NO", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal reqNo { get; set; }

        /// <summary>
        /// GROUP_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "GROUP_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String groupCode { get; set; }

        /// <summary>
        /// PRE_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PRE_NO", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String preNo { get; set; }

        /// <summary>
        /// CONFIRM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CONFIRM", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String confirm { get; set; }

        /// <summary>
        /// TOTAL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TOTAL", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal total { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string reqNo = "reqNo";
            public string groupCode = "groupCode";
            public string preNo = "preNo";
            public string confirm = "confirm";
            public string total = "total";
        }
    }

}
