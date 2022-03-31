using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_BASICCLASS
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_BASICCLASS")]
    public class EntityCodeBasicclass : BaseDataContract
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
        /// SCOPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SCOPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String scope { get; set; }

        /// <summary>
        /// YBFL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "YBFL", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal ybfl { get; set; }

        /// <summary>
        /// MD_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MD_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String mdFlag { get; set; }

        /// <summary>
        /// MC_CLS_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MC_CLS_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String mcClsCode { get; set; }

        /// <summary>
        /// Cls_Def
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cls_def", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
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
            public string clsCode = "clsCode";
            public string clsName = "clsName";
            public string scope = "scope";
            public string ybfl = "ybfl";
            public string mdFlag = "mdFlag";
            public string mcClsCode = "mcClsCode";
            public string clsDef = "clsDef";
        }
    }

}
