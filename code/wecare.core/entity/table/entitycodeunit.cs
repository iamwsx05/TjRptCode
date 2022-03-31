using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// code_unit
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "code_unit")]
    public class EntityCodeUnit : BaseDataContract
    {
        /// <summary>
        /// Code
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "code", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String code { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String name { get; set; }

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
        }
    }

}
