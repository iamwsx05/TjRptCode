using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// BC_REQUEST
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "BC_REQUEST")]
    public class EntityBcRequest : BaseDataContract
    {
        /// <summary>
        /// REQ_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REQ_NO", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 reqNo { get; set; }

        /// <summary>
        /// PID
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PID", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Int32 pid { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String type { get; set; }

        /// <summary>
        /// REG_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String regNo { get; set; }

        /// <summary>
        /// REC_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REC_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String recNo { get; set; }

        /// <summary>
        /// ERG_FALG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ERG_FALG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String ergFalg { get; set; }

        /// <summary>
        /// BED_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BED_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String bedCode { get; set; }

        /// <summary>
        /// DEPT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DEPT_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// DR_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DR_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String drCode { get; set; }

        /// <summary>
        /// DIAG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String diagCode { get; set; }

        /// <summary>
        /// CLASS_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLASS_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String classCode { get; set; }

        /// <summary>
        /// FINI_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FINI_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String finiDate { get; set; }

        /// <summary>
        /// REQ_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REQ_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String reqDate { get; set; }

        /// <summary>
        /// REQ_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REQ_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String reqTime { get; set; }

        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "STATUS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String status { get; set; }

        /// <summary>
        /// NOTE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NOTE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String note { get; set; }

        /// <summary>
        /// PRINT_NUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PRINT_NUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Int32 printNum { get; set; }

        /// <summary>
        /// IP_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "IP_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String ipNo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string reqNo = "reqNo";
            public string pid = "pid";
            public string type = "type";
            public string regNo = "regNo";
            public string recNo = "recNo";
            public string ergFalg = "ergFalg";
            public string bedCode = "bedCode";
            public string deptCode = "deptCode";
            public string drCode = "drCode";
            public string diagCode = "diagCode";
            public string classCode = "classCode";
            public string finiDate = "finiDate";
            public string reqDate = "reqDate";
            public string reqTime = "reqTime";
            public string status = "status";
            public string note = "note";
            public string printNum = "printNum";
            public string ipNo = "ipNo";
        }

        [DataMember]
        public string className { get; set; }
    }

}
