using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_ACCTPERSON
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_ACCTPERSON")]
    public class EntityCodeAcctperson : BaseDataContract
    {
        /// <summary>
        /// SCOPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SCOPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String scope { get; set; }

        /// <summary>
        /// FEE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FEE_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String feeCode { get; set; }

        /// <summary>
        /// PM_ID
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PM_ID", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String pmId { get; set; }

        /// <summary>
        /// NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String name { get; set; }

        /// <summary>
        /// CORP_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CORP_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String corpCode { get; set; }

        /// <summary>
        /// ACCT_RATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ACCT_RATE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal acctRate { get; set; }

        /// <summary>
        /// DISABLE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DISABLE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String disable { get; set; }

        /// <summary>
        /// BED_FEELIMIT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BED_FEELIMIT", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal bedFeelimit { get; set; }

        /// <summary>
        /// DIAG_CODE1
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_CODE1", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String diagCode1 { get; set; }

        /// <summary>
        /// DIAG_CODE2
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_CODE2", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String diagCode2 { get; set; }

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
            public string feeCode = "feeCode";
            public string pmId = "pmId";
            public string name = "name";
            public string corpCode = "corpCode";
            public string acctRate = "acctRate";
            public string disable = "disable";
            public string bedFeelimit = "bedFeelimit";
            public string diagCode1 = "diagCode1";
            public string diagCode2 = "diagCode2";
        }
    }

}
