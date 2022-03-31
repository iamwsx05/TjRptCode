using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_CUT
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_CUT")]
    public class EntityCodeCut : BaseDataContract
    {
        /// <summary>
        /// CUT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CUT_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String cutCode { get; set; }

        /// <summary>
        /// CUT_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CUT_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String cutName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string cutCode = "cutCode";
            public string cutName = "cutName";
        }
    }

}
