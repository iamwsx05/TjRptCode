using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_HEA
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_HEA")]
    public class EntityCodeHea : BaseDataContract
    {
        /// <summary>
        /// HEA_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "HEA_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String heaCode { get; set; }

        /// <summary>
        /// HEA_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "HEA_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String heaName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string heaCode = "heaCode";
            public string heaName = "heaName";
        }
    }

}
