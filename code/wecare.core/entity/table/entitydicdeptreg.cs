using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// dicDeptReg
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicDeptReg")]
    public class EntityDicDeptReg : BaseDataContract
    {
        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Regcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String regCode { get; set; }

        /// <summary>
        /// Regname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String regName { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string deptCode = "deptCode";
            public string regCode = "regCode";
            public string regName = "regName";
            public string status = "status";
        }
    }

}
