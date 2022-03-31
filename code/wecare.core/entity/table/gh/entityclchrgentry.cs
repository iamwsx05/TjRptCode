using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CL_CHRGENTRY
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_CHRGENTRY")]
    public class EntityClChrgEntry : BaseDataContract
    {
        /// <summary>
        /// CHRG_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHRG_NO", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal CHRG_NO { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String TYPE { get; set; }

        /// <summary>
        /// BASIC_CLS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BASIC_CLS", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String BASIC_CLS { get; set; }
        
        /// <summary>
        /// DR_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DR_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 4)]
        public System.String DR_CODE { get; set; }

        /// <summary>
        /// DEPT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DEPT_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 5)]
        public System.String DEPT_CODE { get; set; }

        /// <summary>
        /// TOTAL_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TOTAL_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal TOTAL_SUM { get; set; }

        /// <summary>
        /// ACCT_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ACCT_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal ACCT_SUM { get; set; }

        /// <summary>
        /// SB_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SB_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal SB_SUM { get; set; }

        /// <summary>
        /// SP_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SP_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal SP_SUM { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string CHRG_NO = "CHRG_NO";
            public string TYPE = "TYPE";
            public string BASIC_CLS = "BASIC_CLS";
            public string DR_CODE = "DR_CODE";
            public string DEPT_CODE = "DEPT_CODE";
            public string TOTAL_SUM = "TOTAL_SUM";
            public string ACCT_SUM = "ACCT_SUM";
            public string SB_SUM = "SB_SUM";
            public string SP_SUM = "SP_SUM";
        }
    }

}
