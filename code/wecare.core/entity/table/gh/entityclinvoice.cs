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
    /// CL_INVOICE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_INVOICE")]
    public class EntityClInvoice : BaseDataContract
    {
        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String TYPE { get; set; }

        /// <summary>
        /// INVO_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INVO_NO", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String INVO_NO { get; set; }

        /// <summary>
        /// CHRG_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHRG_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String CHRG_DATE { get; set; }

        /// <summary>
        /// CHRG_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHRG_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String CHRG_TIME { get; set; }

        /// <summary>
        /// INVO_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INVO_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String INVO_DATE { get; set; }

        /// <summary>
        /// OPER_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OPER_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String OPER_CODE { get; set; }

        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "STATUS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String STATUS { get; set; }

        /// <summary>
        /// ACCT_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ACCT_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? ACCT_SUM { get; set; }

        /// <summary>
        /// SB_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SB_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? SB_SUM { get; set; }

        /// <summary>
        /// SP_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SP_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal? SP_SUM { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string TYPE = "TYPE";
            public string INVO_NO = "INVO_NO";
            public string CHRG_DATE = "CHRG_DATE";
            public string CHRG_TIME = "CHRG_TIME";
            public string INVO_DATE = "INVO_DATE";
            public string OPER_CODE = "OPER_CODE";
            public string STATUS = "STATUS";
            public string ACCT_SUM = "ACCT_SUM";
            public string SB_SUM = "SB_SUM";
            public string SP_SUM = "SP_SUM";
        }
    }

}
