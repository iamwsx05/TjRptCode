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
    /// CL_INVOENTRY
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_INVOENTRY")]
    public class EntityClInvoEntry : BaseDataContract
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
        /// INVO_CLS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INVO_CLS", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String INVO_CLS { get; set; }

        /// <summary>
        /// TOTAL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TOTAL", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal TOTAL { get; set; }

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
            public string INVO_CLS = "INVO_CLS";
            public string TOTAL = "TOTAL";
        }
    }

}
