using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    [Entity(TableName = "dicCaiIngredient")]
    public class EntityDicCaiIngredient : BaseDataContract
    {
        [DataMember]
        [Entity(FieldName = "id", DbType = DbType.String, IsPK = true, IsSeq = false, SerNo = 1)]
        public string id { get; set; }
        [DataMember]
        [Entity(FieldName = "caiId", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public string caiId { get; set; }
        [DataMember]
        [Entity(FieldName = "ingredietId", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 3)]
        public string ingredietId { get; set; }
        [DataMember]
        [Entity(FieldName = "ingredietName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 4)]
        public string ingredietName { get; set; }
        [DataMember]
        [Entity(FieldName = "weight", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public decimal weight { get; set; }
        [DataMember]
        [Entity(FieldName = "bakFiled1", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 6)]
        public string bakFiled1 { get; set; }
        [DataMember]
        [Entity(FieldName = "bakFiled2", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public string bakFiled2 { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string id = "id";
            public string caiId = "caiId";
            public string ingredietId = "ingredietId";
            public string ingredietName = "ingredietName";
            public string weight = "weight";
            public string bakFiled1 = "bakFiled1";
            public string bakFiled2 = "bakFiled2";
        }
    }
}
