using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_PRINT
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_PRINT")]
    public class EntityCodePrint : BaseDataContract
    {
        /// <summary>
        /// COMPUTER
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "COMPUTER", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String computer { get; set; }

        /// <summary>
        /// FUNC_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FUNC_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String funcCode { get; set; }

        /// <summary>
        /// PRINT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PRINT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String print { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string computer = "computer";
            public string funcCode = "funcCode";
            public string print = "print";
        }
    }

}
