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
    /// CL_CHARGE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_CHARGE")]
    public class EntityClCharge : BaseDataContract
    {
        /// <summary>
        /// CHRG_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHRG_NO", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal CHRG_NO { get; set; }

        /// <summary>
        /// CHRG_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHRG_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String CHRG_DATE { get; set; }

        /// <summary>
        /// CHRG_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHRG_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String CHRG_TIME { get; set; }

        /// <summary>
        /// OPER_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OPER_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String OPER_CODE { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String TYPE { get; set; }

        /// <summary>
        /// REC_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REC_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String REC_FLAG { get; set; }

        /// <summary>
        /// REC_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REC_NO", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal? REC_NO { get; set; }

        /// <summary>
        /// FEE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FEE_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String FEE_CODE { get; set; }

        /// <summary>
        /// CLASS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLASS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String CLASS { get; set; }

        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "STATUS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String STATUS { get; set; }

        /// <summary>
        /// Corp_Code
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "corp_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Corp_Code { get; set; }

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
            public string CHRG_DATE = "CHRG_DATE";
            public string CHRG_TIME = "CHRG_TIME";
            public string OPER_CODE = "OPER_CODE";
            public string TYPE = "TYPE";
            public string REC_FLAG = "REC_FLAG";
            public string REC_NO = "REC_NO";
            public string FEE_CODE = "FEE_CODE";
            public string CLASS = "CLASS";
            public string STATUS = "STATUS";
            public string Corp_Code = "Corp_Code";
        }
    }

}
