using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityPeRegister
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "peRegister")]
    public class EntityPeRegister : BaseDataContract
    {
        /// <summary>
        /// peNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "peNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String peNo { get; set; }

        /// <summary>
        /// patId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String patId { get; set; }

        /// <summary>
        /// regDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.DateTime? regDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string peNo = "peNo";
            public string patId = "patId";
            public string regDate = "regDate";
        }
    }
}
