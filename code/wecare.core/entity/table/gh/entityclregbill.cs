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
    /// CL_REGBILL
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_REGBILL")]
    public class EntityClRegBill : BaseDataContract
    {
        /// <summary>
        /// REG_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_NO", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String REG_NO { get; set; }

        /// <summary>
        /// FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FLAG", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String FLAG { get; set; }

        /// <summary>
        /// ITEM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ITEM_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String ITEM_CODE { get; set; }

        /// <summary>
        /// REG_SUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_SUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal REG_SUM { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string REG_NO = "REG_NO";
            public string FLAG = "FLAG";
            public string ITEM_CODE = "ITEM_CODE";
            public string REG_SUM = "REG_SUM";
        }
    }

}
