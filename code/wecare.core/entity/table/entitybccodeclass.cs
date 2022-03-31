using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// BC_CODE_CLASS
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "BC_CODE_CLASS")]
    public class EntityBcCodeClass : BaseDataContract
    {
        /// <summary>
        /// CLASS_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLASS_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String classCode { get; set; }

        /// <summary>
        /// CLASS_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLASS_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String className { get; set; }

        /// <summary>
        /// Exec_Dept
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "exec_dept", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String execDept { get; set; }

        /// <summary>
        /// DW_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DW_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String dwName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string classCode = "classCode";
            public string className = "className";
            public string execDept = "execDept";
            public string dwName = "dwName";
        }
    }

}
