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
    /// CL_REFUNDMENT
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_REFUNDMENT")]
    public class EntityClRefundment : BaseDataContract
    {
        /// <summary>
        /// NEW_CHRGNO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NEW_CHRGNO", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal NEW_CHRGNO { get; set; }

        /// <summary>
        /// OLD_CHRGNO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OLD_CHRGNO", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal OLD_CHRGNO { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string NEW_CHRGNO = "NEW_CHRGNO";
            public string OLD_CHRGNO = "OLD_CHRGNO";
        }
    }

}
