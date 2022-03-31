using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrPatientRecord
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrPatientRecord")]
    public class EntityEmrPatientRecord : BaseDataContract, IComparable
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String registerId { get; set; }

        /// <summary>
        /// caseCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "caseCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String caseCode { get; set; }
        
        /// <summary>
        /// Pnid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pnid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 pnId { get; set; }

        /// <summary>
        /// version
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "version", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Int32 version { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// creatorId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatorid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String creatorId { get; set; }

        /// <summary>
        /// Createdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "createdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime createDate { get; set; }

        /// <summary>
        /// confirmoperid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmoperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String confirmOperId { get; set; }

        /// <summary>
        /// Confirmdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime? confirmDate { get; set; }

        /// <summary>
        /// Archivistno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "archivistId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String archiVistId { get; set; }

        /// <summary>
        /// Archdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "archdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime? archDate { get; set; }

        /// <summary>
        /// delOperId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deloperid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String delOperId { get; set; }

        /// <summary>
        /// Deldate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deldate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.DateTime? delDate { get; set; }

        /// <summary>
        /// Caselimittype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "caselimittype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Int32 caseLimitType { get; set; }

        /// <summary>
        /// Locktype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "locktype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Int32 lockType { get; set; }

        /// <summary>
        /// Pdfuri
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pdfuri", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String pdfUri { get; set; }
        
        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Bstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bstatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Int32 bStatus { get; set; }

        /// <summary>
        /// cStatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cstatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Int32 cStatus { get; set; }
                
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
            public string registerId = "registerId";
            public string caseCode = "caseCode";
            public string pnId = "pnId";
            public string version = "version";
            public string recordDate = "recordDate";
            public string creatorId = "creatorId";
            public string createDate = "createDate";
            public string confirmOperId = "confirmOperId";
            public string confirmDate = "confirmDate";
            public string archiVistId = "archiVistId";
            public string archDate = "archDate";
            public string delOperId = "delOperId";
            public string delDate = "delDate";
            public string caseLimitType = "caseLimitType";
            public string lockType = "lockType";
            public string pdfUri = "pdfUri";
            public string status = "status";
            public string bStatus = "bStatus";
            public string cStatus = "cStatus";
        }

        public int CompareTo(object obj)
        {
            if (obj is EntityEmrPatientRecord)
            {
                return this.recordDate.CompareTo(((EntityEmrPatientRecord)obj).recordDate);
            }
            return 0;
        }

    }

}
