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
    /// CL_CHARGE_INVOICE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_CHARGE_INVOICE")]
    public class EntityClChargeInvoice : BaseDataContract
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
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String TYPE { get; set; }

        /// <summary>
        /// INVO_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INVO_NO", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String INVO_NO { get; set; }

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
            public string INVO_NO = "INVO_NO";
        }
    }

}
