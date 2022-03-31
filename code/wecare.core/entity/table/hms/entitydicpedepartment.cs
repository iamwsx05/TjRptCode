using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityDicPeDepartment
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicPeDepartment")]
    public class EntityDicPeDepartment : BaseDataContract
    {
        /// <summary>
        /// deptId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String deptId { get; set; }

        /// <summary>
        /// deptName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String deptName { get; set; }

        /// <summary>
        /// sortNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 sortNo { get; set; }

        [DataMember]
        public string pyCode { get; set; }

        [DataMember]
        public string wbCode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string deptId = "deptId";
            public string deptName = "deptName";
            public string sortNo = "sortNo";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
        }
    }
}
