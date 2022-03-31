using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_FEE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_FEE")]
    public class EntityCodeFee : BaseDataContract
    {
        /// <summary>
        /// FEE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FEE_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String feeCode { get; set; }

        /// <summary>
        /// FEE_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FEE_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String feeName { get; set; }

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
        /// SCOPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SCOPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String scope { get; set; }

        /// <summary>
        /// Qf_Sum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "qf_sum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal qfSum { get; set; }

        /// <summary>
        /// Self_Rate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "self_rate", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal selfRate { get; set; }

        /// <summary>
        /// FMBX_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FMBX_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal fmbxSum { get; set; }

        /// <summary>
        /// FMBZ_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FMBZ_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal fmbzSum { get; set; }

        /// <summary>
        /// Inst_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inst_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String instFlag { get; set; }

        /// <summary>
        /// BA_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BA_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String baCode { get; set; }

        /// <summary>
        /// BA_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BA_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String baName { get; set; }

        /// <summary>
        /// pyCode
        /// </summary>
        [DataMember]
        public string pyCode { get; set; }

        /// <summary>
        /// wbCode
        /// </summary>
        [DataMember]
        public string wbCode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string feeCode = "feeCode";
            public string feeName = "feeName";
            public string parent = "parent";
            public string grade = "grade";
            public string leafFlag = "leafFlag";
            public string scope = "scope";
            public string qfSum = "qfSum";
            public string selfRate = "selfRate";
            public string fmbxSum = "fmbxSum";
            public string fmbzSum = "fmbzSum";
            public string instFlag = "instFlag";
            public string baCode = "baCode";
            public string baName = "baName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
        }
    }

}
