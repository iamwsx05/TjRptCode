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
    /// opRegPlatformLog
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegPlatformLog")]
    public class EntityOpRegPlatformLog : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Deptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String deptName { get; set; }

        /// <summary>
        /// Doctcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String doctCode { get; set; }

        /// <summary>
        /// Doctname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String doctName { get; set; }

        /// <summary>
        /// Regdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String regDate { get; set; }

        /// <summary>
        /// Starttime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "startTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String startTime { get; set; }

        /// <summary>
        /// Endtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "endTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String endTime { get; set; }

        /// <summary>
        /// Subscribeno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "subscribeNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String subscribeNo { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String recipeId { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// Senddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sendDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime? sendDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string serNo = "serNo";
            public string deptCode = "deptCode";
            public string deptName = "deptName";
            public string doctCode = "doctCode";
            public string doctName = "doctName";
            public string regDate = "regDate";
            public string startTime = "startTime";
            public string endTime = "endTime";
            public string subscribeNo = "subscribeNo";
            public string recipeId = "recipeId";
            public string recordDate = "recordDate";
            public string sendDate = "sendDate";
        }
    }

}
