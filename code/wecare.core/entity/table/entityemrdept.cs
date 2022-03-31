using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrDept
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrDept")]
    public class EntityEmrDept : BaseDataContract
    {
        /// <summary>
        /// Casecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String caseCode { get; set; }

        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Attrflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "attrflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 attrFlag { get; set; }

        /// <summary>
        /// deptName
        /// </summary>
        [DataMember]
        public string deptName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string caseCode = "caseCode";
            public string deptCode = "deptCode";
            public string deptName = "deptName";
            public string attrFlag = "attrFlag";
        }
    }

}
