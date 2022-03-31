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
    /// EntityPromotionContentConfig
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "promotionContentConfig")]
    public class EntityPromotionContentConfig : BaseDataContract
    {
        /// <summary>
        /// id
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "id", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String id { get; set; }

        /// <summary>
        /// planContent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "planContent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String planContent { get; set; }

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
            public string planContent = "planContent";
        }
    }

}
