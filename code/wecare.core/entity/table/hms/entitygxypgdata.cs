using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityGxyPgData
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "gxyPgData")]
    public class EntityGxyPgData : BaseDataContract
    {
        /// <summary>
        /// pgId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pgId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal pgId { get; set; }

        /// <summary>
        /// xmlData
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "xmlData", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String xmlData { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string pgId = "pgId";
            public string xmlData = "xmlData";
        }
    }
}
