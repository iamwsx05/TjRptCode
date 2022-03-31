using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Hms.Entity
{
    /// <summary>
    /// EntityReportInfo
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "reportInfo")]
    public class EntityReportInfo : BaseDataContract
    {
        /// <summary>
        /// id
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "id", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String id { get; set; }

        /// <summary>
        /// clientId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "clientId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String clientId { get; set; }

        /// <summary>
        /// libraryId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "libraryId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String libraryId { get; set; }

        /// <summary>
        /// reportTemplateId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportTemplateId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String reportTemplateId { get; set; }

        /// <summary>
        /// reportNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String reportNo { get; set; }

        /// <summary>
        /// reportDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime reportDate { get; set; }

        /// <summary>
        /// reportState
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportState", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String reportState { get; set; }

        /// <summary>
        /// examinationOrgan
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "examinationOrgan", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String examinationOrgan { get; set; }

        /// <summary>
        /// unit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String unit { get; set; }

        /// <summary>
        /// examinationNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "examinationNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String examinationNo { get; set; }

        /// <summary>
        /// dataSource
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dataSource", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String dataSource { get; set; }

        /// <summary>
        /// upTag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "upTag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String upTag { get; set; }

        /// <summary>
        /// bakField1
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bakField1", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String bakField1 { get; set; }

        /// <summary>
        /// bakField2
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bakField2", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String bakField2 { get; set; }

        /// <summary>
        /// careteDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "createDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.DateTime? createDate { get; set; }

        /// <summary>
        /// creator
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String creator { get; set; }

        /// <summary>
        /// createName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "createName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String createName { get; set; }

        /// <summary>
        /// modifyDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifyDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.DateTime? modifyDate { get; set; }

        /// <summary>
        /// modifyId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifyId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String modifyId { get; set; }

        /// <summary>
        /// modifyName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifyName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String modifyName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string id = "id";
            public string clientId = "clientId";
            public string libraryId = "libraryId";
            public string reportTemplateId = "reportTemplateId";
            public string reportNo = "reportNo";
            public string reportDate = "reportDate";
            public string reportState = "reportState";
            public string examinationOrgan = "examinationOrgan";
            public string unit = "unit";
            public string examinationNo = "examinationNo";
            public string dataSource = "dataSource";
            public string upTag = "upTag";
            public string bakField1 = "bakField1";
            public string bakField2 = "bakField2";
            public string careteDate = "careteDate";
            public string creator = "creator";
            public string createName = "createName";
            public string modifyDate = "modifyDate";
            public string modifyId = "modifyId";
            public string modifyName = "modifyName";
        }
    }
}
