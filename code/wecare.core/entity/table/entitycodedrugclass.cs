using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_DRUGCLASS
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_DRUGCLASS")]
    public class EntityCodeDrugclass : BaseDataContract
    {
        /// <summary>
        /// CLS_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLS_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String clsCode { get; set; }

        /// <summary>
        /// CLS_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLS_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String clsName { get; set; }

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
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string clsCode = "clsCode";
            public string clsName = "clsName";
            public string parent = "parent";
            public string grade = "grade";
            public string leafFlag = "leafFlag";
        }
    }

}
