using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_RANK
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_RANK")]
    public class EntityCodeRank : BaseDataContract
    {
        /// <summary>
        /// RANK_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RANK_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String rankCode { get; set; }

        /// <summary>
        /// RANK_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RANK_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String rankName { get; set; }

        /// <summary>
        /// REG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String regCode { get; set; }

        /// <summary>
        /// Doc_Level
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doc_level", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String docLevel { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string rankCode = "rankCode";
            public string rankName = "rankName";
            public string regCode = "regCode";
            public string docLevel = "docLevel";
        }
    }

}
