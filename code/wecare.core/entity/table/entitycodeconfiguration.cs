using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_CONFIGURATION
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_CONFIGURATION")]
    public class EntityCodeConfiguration : BaseDataContract
    {
        /// <summary>
        /// CONFIG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CONFIG_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String configCode { get; set; }

        /// <summary>
        /// CONFIG_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CONFIG_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String configName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string configCode = "configCode";
            public string configName = "configName";
        }
    }

}
