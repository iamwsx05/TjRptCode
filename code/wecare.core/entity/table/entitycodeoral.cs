using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_ORAL
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_ORAL")]
    public class EntityCodeOral : BaseDataContract
    {
        /// <summary>
        /// ORAL_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ORAL_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String oralCode { get; set; }

        /// <summary>
        /// ORAL_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ORAL_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String oralName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string oralCode = "oralCode";
            public string oralName = "oralName";
        }
    }

}
