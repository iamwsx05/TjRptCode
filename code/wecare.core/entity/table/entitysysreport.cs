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
    /// sysReport
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "sysReport")]
    public class EntitySysReport : BaseDataContract
    {
        /// <summary>
        /// Rptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rptId", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal rptId { get; set; }

        /// <summary>
        /// Rptno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rptNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String rptNo { get; set; }

        /// <summary>
        /// Rptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rptName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String rptName { get; set; }

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
        /// Type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "type", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 type { get; set; }

        /// <summary>
        /// Rptsql
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rptSql", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String rptSql { get; set; }

        /// <summary>
        /// Rptfile
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rptFile", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Byte[] rptFile { get; set; }

        /// <summary>
        /// Creatorid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatorId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String creatorId { get; set; }

        /// <summary>
        /// Createdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "createDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime? createDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// 报表数据源
        /// </summary>
        [DataMember]
        public object dataSource { get; set; }

        [DataMember]
        public int imageIndex { get; set; }

        [DataMember]
        public bool isModify { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string rptId = "rptId";
            public string rptNo = "rptNo";
            public string rptName = "rptName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string type = "type";
            public string rptSql = "rptSql";
            public string rptFile = "rptFile";
            public string creatorId = "creatorId";
            public string createDate = "createDate";
            public string status = "status";
            public string dataSource = "dataSource";
            public string imageIndex = "imageIndex";
            public string isModify = "isModify";
        }
    }

}
