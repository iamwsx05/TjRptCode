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
    /// dicSampleDesc
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicSampleDesc")]
    public class EntityDicSampleDesc : BaseDataContract
    {
        /// <summary>
        /// Sdcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sdCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String sdCode { get; set; }

        /// <summary>
        /// Sdname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sdName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String sdName { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pyCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "remark", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String remark { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string sdCode = "sdCode";
            public string sdName = "sdName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string remark = "remark";
        }
    }

}
