using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_PHARMIC
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_PHARMIC")]
    public class EntityCodePharmic : BaseDataContract
    {
        /// <summary>
        /// PH_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PH_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String phCode { get; set; }

        /// <summary>
        /// PH_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PH_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String phName { get; set; }

        /// <summary>
        /// PARENT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PARENT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String parent { get; set; }

        /// <summary>
        /// GRADE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "GRADE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 grade { get; set; }

        /// <summary>
        /// LEAF_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LEAF_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String leafFlag { get; set; }

        /// <summary>
        /// Cls_Def
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cls_def", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String clsDef { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string phCode = "phCode";
            public string phName = "phName";
            public string parent = "parent";
            public string grade = "grade";
            public string leafFlag = "leafFlag";
            public string clsDef = "clsDef";
        }
    }

}
