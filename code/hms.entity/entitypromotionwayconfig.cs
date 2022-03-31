using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    /// <summary>
    /// EntityPromotionWayConfig
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "promotionWayConfig")]
    public class EntityPromotionWayConfig : BaseDataContract
    {
        /// <summary>
        /// id
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "id", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String id { get; set; }

        /// <summary>
        /// planWay
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "planWay", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String planWay { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string id = "id";
            public string planWay = "planWay";
        }
    }
}
