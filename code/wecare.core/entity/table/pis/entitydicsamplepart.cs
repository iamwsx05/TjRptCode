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
    /// dicSamplePart
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicSamplePart")]
    public class EntityDicSamplePart : BaseDataContract
    {
        /// <summary>
        /// Spcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String spCode { get; set; }

        /// <summary>
        /// Spname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String spName { get; set; }

        /// <summary>
        /// Classid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String classId { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pyCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal? sortNo { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "remark", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String remark { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal status { get; set; }

        [DataMember]
        public string className
        {
            get;
            set;
        }

        [DataMember]
        public string statusName
        {
            get;
            set;
        }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string spCode = "spCode";
            public string spName = "spName";
            public string classId = "classId";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string sortNo = "sortNo";
            public string remark = "remark";
            public string status = "status";

            public string statusName = "statusName";
        }
    }

}
