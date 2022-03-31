using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityTnbSfData
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "tnbSfData")]
    public class EntityTnbSfData : BaseDataContract
    {
        /// <summary>
        /// sfId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sfId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal sfId { get; set; }

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
            public string sfId = "sfId";
            public string xmlData = "xmlData";
        }
    }
}
