using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_MARRY
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_MARRY")]
    public class EntityCodeMarry : BaseDataContract
    {
        /// <summary>
        /// CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String code { get; set; }

        /// <summary>
        /// NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String name { get; set; }

        /// <summary>
        /// BA_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BA_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String baCode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string code = "code";
            public string name = "name";
            public string baCode = "baCode";
        }
    }

}
