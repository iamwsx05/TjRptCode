using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// MD_DEF_DRUGSTORE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "MD_DEF_DRUGSTORE")]
    public class EntityMdDefDrugStore : BaseDataContract
    {
        /// <summary>
        /// STOR_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "STOR_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String storCode { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String type { get; set; }

        /// <summary>
        /// UNIT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "UNIT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String unit { get; set; }

        /// <summary>
        /// ROOM_TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROOM_TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String roomType { get; set; }

        /// <summary>
        /// USE_PRD
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "USE_PRD", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String usePrd { get; set; }

        /// <summary>
        /// STOR_INIT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "STOR_INIT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String storInit { get; set; }

        /// <summary>
        /// ACCT_INIT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ACCT_INIT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String acctInit { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string storCode = "storCode";
            public string type = "type";
            public string unit = "unit";
            public string roomType = "roomType";
            public string usePrd = "usePrd";
            public string storInit = "storInit";
            public string acctInit = "acctInit";
        }
    }

}
