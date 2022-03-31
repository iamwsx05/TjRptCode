using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_FRYING
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_FRYING")]
    public class EntityCodeFrying : BaseDataContract
    {
        /// <summary>
        /// FRY_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FRY_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String fryCode { get; set; }

        /// <summary>
        /// FRY_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FRY_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String fryName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string fryCode = "fryCode";
            public string fryName = "fryName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
        }

        [DataMember]
        public string pyCode { get; set; }
        [DataMember]
        public string wbCode { get; set; }
    }

}
