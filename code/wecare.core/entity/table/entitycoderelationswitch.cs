using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_RELATIONSWITCH
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_RELATIONSWITCH")]
    public class EntityCodeRelationswitch : BaseDataContract
    {
        /// <summary>
        /// RELATION_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RELATION_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String relationCode { get; set; }

        /// <summary>
        /// RELATION_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RELATION_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String relationName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string relationCode = "relationCode";
            public string relationName = "relationName";
        }
    }

}
