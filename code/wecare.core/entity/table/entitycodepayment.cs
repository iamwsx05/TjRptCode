using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_PAYMENT
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_PAYMENT")]
    public class EntityCodePayment : BaseDataContract
    {
        /// <summary>
        /// PAY_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PAY_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String payCode { get; set; }

        /// <summary>
        /// PAY_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PAY_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String payName { get; set; }

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
        /// RATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RATE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal rate { get; set; }

        /// <summary>
        /// ACCT_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ACCT_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String acctFlag { get; set; }

        /// <summary>
        /// CURR_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CURR_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String currFlag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string payCode = "payCode";
            public string payName = "payName";
            public string parent = "parent";
            public string grade = "grade";
            public string leafFlag = "leafFlag";
            public string rate = "rate";
            public string acctFlag = "acctFlag";
            public string currFlag = "currFlag";
        }
    }

}
