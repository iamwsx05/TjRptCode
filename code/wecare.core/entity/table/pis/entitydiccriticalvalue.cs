using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityDicCriticalValue
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicCriticalValue")]
    public class EntityDicCriticalValue : BaseDataContract
    {
        /// <summary>
        /// criNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "criNo", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String criNo { get; set; }

        /// <summary>
        /// criDesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "criDesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String criDesc { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string criNo = "criNo";
            public string criDesc = "criDesc";
            public string status = "status";
        }
    }
}
