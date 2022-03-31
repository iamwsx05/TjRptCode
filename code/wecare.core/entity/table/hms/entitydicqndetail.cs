using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityDicQnDetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicQnDetail")]
    public class EntityDicQnDetail : BaseDataContract
    {
        /// <summary>
        /// qnId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "qnId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal qnId { get; set; }

        /// <summary>
        /// fieldId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String fieldId { get; set; }

        /// <summary>
        /// questName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "questName", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String questName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string qnId = "qnId";
            public string fieldId = "fieldId";
            public string questName = "questName";
        }
    }
}
