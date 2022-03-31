using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_RULE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_RULE")]
    public class EntityCodeRule : BaseDataContract
    {
        /// <summary>
        /// CONFIG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CONFIG_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String configCode { get; set; }

        /// <summary>
        /// RULE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RULE_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String ruleCode { get; set; }

        /// <summary>
        /// RULE_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RULE_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String ruleName { get; set; }

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
            public string ruleCode = "ruleCode";
            public string ruleName = "ruleName";
        }
    }

}
