using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_INFECT
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_INFECT")]
    public class EntityCodeInfect : BaseDataContract
    {
        /// <summary>
        /// INFECT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INFECT_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String infectCode { get; set; }

        /// <summary>
        /// INFECT_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INFECT_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String infectName { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String type { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string infectCode = "infectCode";
            public string infectName = "infectName";
            public string type = "type";
        }
    }

}
