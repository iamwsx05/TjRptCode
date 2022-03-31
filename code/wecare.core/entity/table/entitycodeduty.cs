using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_DUTY
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_DUTY")]
    public class EntityCodeDuty : BaseDataContract
    {
        /// <summary>
        /// DUTY_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DUTY_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String dutyCode { get; set; }

        /// <summary>
        /// DUTY_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DUTY_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String dutyName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string dutyCode = "dutyCode";
            public string dutyName = "dutyName";
        }
    }

}
