using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrBasicInfo
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrBasicInfo")]
    public class EntityEmrBasicInfo : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal typeId { get; set; }

        /// <summary>
        /// caseCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String caseCode { get; set; }

        /// <summary>
        /// formName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String caseName { get; set; }

        /// <summary>
        /// formId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal formId { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Tablename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tablename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String tableName { get; set; }

        /// <summary>
        /// printTemplateId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printtemplateid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal printTemplateId { get; set; }

        /// <summary>
        /// Attribute
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "attribute", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal attribute { get; set; }

        /// <summary>
        /// Timelimit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "timelimit", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal timeLimit { get; set; }

        /// <summary>
        /// Specialflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "specialflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Int32 specialFlag { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Int32 sortNo { get; set; }

        /// <summary>
        /// Parentcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String parentCode { get; set; }

        /// <summary>
        /// Timetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "timetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Int32 timeType { get; set; }

        /// <summary>
        /// Timeperiod
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "timeperiod", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Decimal timePeriod { get; set; }

        /// <summary>
        /// Aheadtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "aheadtime", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal aheadTime { get; set; }

        /// <summary>
        /// Catalogid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "catalogid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Int32 catalogId { get; set; }

        /// <summary>
        /// Referencetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "referencetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Int32 referenceType { get; set; }

        /// <summary>
        /// Osortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "osortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Int32 oSortNo { get; set; }

        /// <summary>
        /// Showtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "showtype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Int32 showType { get; set; }

        /// <summary>
        /// Qcflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "qcflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Int32 qcFlag { get; set; }

        /// <summary>
        /// Supdoctsignflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "supdoctsignflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.Int32 supDoctSignFlag { get; set; }

        /// <summary>
        /// Dirdoctsignflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dirdoctsignflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.Int32 dirDoctSignFlag { get; set; }

        /// <summary>
        /// Showcasestatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "showcasestatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.Int32 showCaseStatus { get; set; }

        /// <summary>
        /// Bandingflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bandingflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.Int32 bandingFlag { get; set; }

        /// <summary>
        /// Continueprtflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "continueprtflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.Int32 continuePrtFlag { get; set; }

        /// <summary>
        /// Casestyle
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casestyle", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.Int32 caseStyle { get; set; }

        /// <summary>
        /// Multipageflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "multipageflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.Int32 multiPageFlag { get; set; }

        /// <summary>
        /// Multicolcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "multicolcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.String multiColCode { get; set; }

        /// <summary>
        /// Signlevel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "signlevel", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.Int32 signLevel { get; set; }

        /// <summary>
        /// Casescope
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casescope", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.Int32 caseScope { get; set; }

        /// <summary>
        /// Lockdatedirector
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockdatedirector", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.Int32 lockDateDirector { get; set; }

        /// <summary>
        /// Lockdateqcdept
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockdateqcdept", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.Int32 lockDateQcDept { get; set; }

        /// <summary>
        /// Excludegroupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "excludegroupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.Int32 excludeGroupNo { get; set; }

        /// <summary>
        /// fieldXml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldxml", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.String fieldXml { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// 病程记录.caseCode
        /// </summary>
        [DataMember]
        public string progressNoteCaseCode { get; set; }

        [DataMember]
        public DateTime? recordDate { get; set; }

        string _recordDateStr = string.Empty;

        [DataMember]
        public string recordDateStr
        {
            get
            {
                _recordDateStr = (recordDate == null ? "" : recordDate.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                return _recordDateStr;
            }
            set { _recordDateStr = value; }
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
            public string serNo = "serNo";
            public string typeId = "typeId";
            public string formId = "formId";
            public string caseName = "caseName";
            public string caseCode = "caseCode";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string tableName = "tableName";
            public string printTemplateId = "printTemplateId";
            public string attribute = "attribute";
            public string timeLimit = "timeLimit";
            public string specialFlag = "specialFlag";
            public string sortNo = "sortNo";
            public string parentCode = "parentCode";
            public string timeType = "timeType";
            public string timePeriod = "timePeriod";
            public string aheadTime = "aheadTime";
            public string catalogId = "catalogId";
            public string referenceType = "referenceType";
            public string oSortNo = "oSortNo";
            public string showType = "showType";
            public string qcFlag = "qcFlag";
            public string supDoctSignFlag = "supDoctSignFlag";
            public string dirDoctSignFlag = "dirDoctSignFlag";
            public string showCaseStatus = "showCaseStatus";
            public string bandingFlag = "bandingFlag";
            public string continuePrtFlag = "continuePrtFlag";
            public string caseStyle = "caseStyle";
            public string multiPageFlag = "multiPageFlag";
            public string multiColCode = "multiColCode";
            public string signLevel = "signLevel";
            public string caseScope = "caseScope";
            public string lockDateDirector = "lockDateDirector";
            public string lockDateQcDept = "lockDateQcDept";
            public string excludeGroupNo = "excludeGroupNo";
            public string fieldXml = "fieldXml";
            public string status = "status";
            public string progressNoteCaseCode = "progressNoteCaseCode";
            public string tempSerNo = "tempSerNo";
            public string recordDate = "recordDate";
        }

        /// <summary>
        /// 临时序列号，分类时用
        /// </summary>
        public decimal? tempSerNo { get; set; }
    }
}
