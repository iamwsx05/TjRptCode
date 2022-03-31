using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract, Serializable]
    [Entity(TableName = "DicIngredientConfig")]
    public class EntityDicIngredientConfig : BaseDataContract
    {
        [DataMember]
        [Entity(FieldName = "classifyId", DbType = DbType.Int16, IsPK = true, IsSeq = false, SerNo = 1)]
        public int classifyId { get; set; }
        [DataMember]
        [Entity(FieldName = "ingredientId", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public string ingredientId { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string classifyId = "classifyId";
            public string ingredientId = "ingredientId";
        }
    }
}
