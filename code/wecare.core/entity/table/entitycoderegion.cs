using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_REGION
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_REGION")]
    public class EntityCodeRegion : BaseDataContract
    {
        /// <summary>
        /// REG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String regCode { get; set; }

        /// <summary>
        /// REG_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String regName { get; set; }

        /// <summary>
        /// FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String flag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string regCode = "regCode";
            public string regName = "regName";
            public string flag = "flag";
        }
    }

}
