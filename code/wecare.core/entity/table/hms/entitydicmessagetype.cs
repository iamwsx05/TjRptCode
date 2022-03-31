using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityDicMessageType
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicMessageType")]
    public class EntityDicMessageType : BaseDataContract
    {
        /// <summary>
        /// typeId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String typeId { get; set; }

        /// <summary>
        /// typeName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String typeName { get; set; }

        /// <summary>
        /// typeLevel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeLevel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String typeLevel { get; set; }

        /// <summary>
        /// parentId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String parentId { get; set; }

        [DataMember]
        public int tmpNo
        {
            get { return Convert.ToInt32(typeLevel); }
            set {; }
        }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string typeId = "typeId";
            public string typeName = "typeName";
            public string typeLevel = "typeLevel";
            public string parentId = "parentId";
        }
    }
}
