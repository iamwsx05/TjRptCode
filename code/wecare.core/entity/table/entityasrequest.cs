using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// AS_REQUEST
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "AS_REQUEST")]
    public class EntityAsRequest : BaseDataContract
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
        /// ROOM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROOM_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String roomCode { get; set; }

        /// <summary>
        /// ASSAY_TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ASSAY_TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String assayType { get; set; }

        /// <summary>
        /// CLASS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLASS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String class2 { get; set; }

        /// <summary>
        /// AIM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "AIM", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String aim { get; set; }

        /// <summary>
        /// FINI_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FINI_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String finiDate { get; set; }

        /// <summary>
        /// REQ_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REQ_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String reqDate { get; set; }

        /// <summary>
        /// REQ_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REQ_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String reqTime { get; set; }

        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "STATUS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String status { get; set; }

        /// <summary>
        /// NOTE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NOTE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String note { get; set; }

        /// <summary>
        /// PRINT_FALG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PRINT_FALG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String printFalg { get; set; }

        /// <summary>
        /// SAMP_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SAMP_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String sampCode { get; set; }

        /// <summary>
        /// DIAG_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String diagName { get; set; }

        /// <summary>
        /// OPER_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OPER_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String operCode { get; set; }

        /// <summary>
        /// OPER_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OPER_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String operDate { get; set; }

        /// <summary>
        /// OPER_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OPER_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String operTime { get; set; }

        /// <summary>
        /// CHECK_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHECK_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String checkNo { get; set; }

        /// <summary>
        /// EXEOPER_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "EXEOPER_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String exeoperCode { get; set; }

        /// <summary>
        /// EXEOPER_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "EXEOPER_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String exeoperDate { get; set; }

        /// <summary>
        /// EXEOPER_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "EXEOPER_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String exeoperTime { get; set; }

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
            public string roomCode = "roomCode";
            public string assayType = "assayType";
            public string class2 = "class";
            public string aim = "aim";
            public string finiDate = "finiDate";
            public string reqDate = "reqDate";
            public string reqTime = "reqTime";
            public string status = "status";
            public string note = "note";
            public string printFalg = "printFalg";
            public string sampCode = "sampCode";
            public string diagName = "diagName";
            public string operCode = "operCode";
            public string operDate = "operDate";
            public string operTime = "operTime";
            public string checkNo = "checkNo";
            public string exeoperCode = "exeoperCode";
            public string exeoperDate = "exeoperDate";
            public string exeoperTime = "exeoperTime";
        }

        [DataMember]
        public string roomName { get; set; }
    }

}
