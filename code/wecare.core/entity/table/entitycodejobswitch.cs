using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_JOBSWITCH
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_JOBSWITCH")]
    public class code_jobswitch : BaseDataContract
    {
        /// <summary>
        /// JOB_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "JOB_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String jobCode { get; set; }

        /// <summary>
        /// JOB_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "JOB_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String jobName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string jobCode = "jobCode";
            public string jobName = "jobName";
        }
    }

}
