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
    /// CL_PAYMENT
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_PAYMENT")]
    public class EntityClPayment : BaseDataContract
    {
        /// <summary>
        /// CHRG_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHRG_NO", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal CHRG_NO { get; set; }

        /// <summary>
        /// PAY_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PAY_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String PAY_CODE { get; set; }

        /// <summary>
        /// PAY_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PAY_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal PAY_SUM { get; set; }

        /// <summary>
        /// REFU_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REFU_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal REFU_SUM { get; set; }

        /// <summary>
        /// RATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RATE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal RATE { get; set; }

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
            public string PAY_CODE = "PAY_CODE";
            public string PAY_SUM = "PAY_SUM";
            public string REFU_SUM = "REFU_SUM";
            public string RATE = "RATE";
        }
    }

}
