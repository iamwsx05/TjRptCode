using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrFormula
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrFormula")]
    public class EntityEmrFormula : BaseDataContract
    {
        /// <summary>
        /// Mfmid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "mfmid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Int32 mfmId { get; set; }

        /// <summary>
        /// Markid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "markid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Int32 markId { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string mfmId = "mfmId";
            public string markId = "markId";
        }
    }

}
