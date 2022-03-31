using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// rptContagion
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "rptContagion")]
    public class EntityRptContagion : BaseDataContract
    {
        /// <summary>
        /// Rptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rptId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal rptId { get; set; }

        /// <summary>
        /// Reportid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String reportId { get; set; }

        /// <summary>
        /// Reporttime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String reportTime { get; set; }

        /// <summary>
        /// Reportopercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportOperCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String reportOperCode { get; set; }

        /// <summary>
        /// Reportopername
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportOperName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String reportOperName { get; set; }

        /// <summary>
        /// Registercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String registerCode { get; set; }

        /// <summary>
        /// patType
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 patType { get; set; }

        /// <summary>
        /// Patno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String patNo { get; set; }

        /// <summary>
        /// Patname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String patName { get; set; }

        /// <summary>
        /// Patsex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patSex", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String patSex { get; set; }

        /// <summary>
        /// Idcard
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "idCard", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String idCard { get; set; }

        /// <summary>
        /// Birthday
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "birthday", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime? birthday { get; set; }

        /// <summary>
        /// Contactaddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "contactAddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String contactAddr { get; set; }

        /// <summary>
        /// Contacttel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "contactTel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String contactTel { get; set; }

        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Formid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Decimal formId { get; set; }

        /// <summary>
        /// Opercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String operCode { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Decimal status { get; set; }

        [DataMember]
        public string xmlData { get; set; }

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
            public string reportId = "reportId";
            public string reportTime = "reportTime";
            public string reportOperCode = "reportOperCode";
            public string reportOperName = "reportOperName";
            public string registerCode = "registerCode";
            public string patType = "patType";
            public string patNo = "patNo";
            public string patName = "patName";
            public string patSex = "patSex";
            public string idCard = "idCard";
            public string birthday = "birthday";
            public string contactAddr = "contactAddr";
            public string contactTel = "contactTel";
            public string deptCode = "deptCode";
            public string formId = "formId";
            public string operCode = "operCode";
            public string recordDate = "recordDate";
            public string status = "status";
            public string xmlData = "xmlData";
        }
    }

    /// <summary>
    /// rptContagionData
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "rptContagionData")]
    public class EntityRptContagionData : BaseDataContract
    {
        /// <summary>
        /// Rptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rptId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal rptId { get; set; }

        /// <summary>
        /// Xmldata
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "xmlData", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String xmlData { get; set; }

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
            public string xmlData = "xmlData";
        }
    }

    /// <summary>
    /// rptContagionParm
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "rptContagionParm")]
    public class EntityRptContagionParm : BaseDataContract
    {
        /// <summary>
        /// Eventid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String reportId { get; set; }

        /// <summary>
        /// Keyid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "keyId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String keyId { get; set; }

        /// <summary>
        /// Keyvalue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "keyValue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String keyValue { get; set; }

        /// <summary>
        /// Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "flag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal flag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string reportId = "reportId";
            public string keyId = "keyId";
            public string keyValue = "keyValue";
            public string flag = "flag";
        }
    }

}
