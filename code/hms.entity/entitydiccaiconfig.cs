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
    [Entity(TableName = "dicCaiConfig")]
    public class EntityDicCaiConfig : BaseDataContract
    {
        [DataMember]
        [Entity(FieldName = "caiSlaveId", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 1)]
        public string caiSlaveId { get; set; }
        [DataMember]
        [Entity(FieldName = "caiId", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public string caiId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string caiSlaveNameStr { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string caiSlaveId = "caiSlaveId";
            public string caiId = "caiId";
        }
    }
}
