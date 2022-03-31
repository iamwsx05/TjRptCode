using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrElementTemplate
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrElementTemplate")]
    public class EntityElementTemplate : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serno { get; set; }

        /// <summary>
        /// Templatename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templatename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String templateName { get; set; }

        /// <summary>
        /// Createrid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "createrid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String createrId { get; set; }

        /// <summary>
        /// Createdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "createdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime? createDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Int32 status { get; set; }

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
        /// Casecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String caseCode { get; set; }

        /// <summary>
        /// Multiflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "multiflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 multiFlag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string serno = "serno";
            public string templateName = "templateName";
            public string createrId = "createrId";
            public string createDate = "createDate";
            public string status = "status";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string caseCode = "caseCode";
            public string multiFlag = "multiFlag";

            public string elementid = "elementid";
            public string colcontent_chs = "colcontent_chs";
            public string colcontent = "colcontent";
            public string linkSerno = "linkSerno";
        }
       
        /// <summary>
        /// 元素ID
        /// </summary>
        [DataMember]
        public int elementid { set; get; }
        /// <summary>
        /// 元素名称
        /// </summary>
        [DataMember]
        public string colcontent { set; get; }

        [DataMember]
        public string colcontent_chs
        {
            get
            {
                if (linkSerno == null)
                {
                    return colcontent;
                }
                else
                {
                    return colcontent + " ->";
                }
            }
            set { ;}
        }
        /// <summary>
        /// 关联项ID
        /// </summary>
        [DataMember]
        public int? linkSerno { set; get; }
        
    }

    /// <summary>
    /// emrElementTemplateContent
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrElementTemplateContent")]
    public class EntityElementTemplateContent : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Elementid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "elementid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Int32 elementId { get; set; }

        /// <summary>
        /// Colcontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String colContent { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Int32 sortNo { get; set; }

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
            public string elementId = "elementId";
            public string colContent = "colContent";
            public string status = "status";
            public string sortNo = "sortNo";
        }
    }

    /// <summary>
    /// emrElementTemplateLinkage
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrElementTemplateLinkage")]
    public class EntityElementTemplateLinkage : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Int32 serNo { get; set; }

        /// <summary>
        /// Elementid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "elementid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Int32 elementId { get; set; }

        /// <summary>
        /// Colcontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String colContent { get; set; }

        /// <summary>
        /// Colcontentxml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontentxml", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String colContentXml { get; set; }

        /// <summary>
        /// Colcontentrtf
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontentrtf", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Byte[] colContentRtf { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 sortNo { get; set; }

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
            public string elementId = "elementId";
            public string colContent = "colContent";
            public string colContentXml = "colContentXml";
            public string colContentRtf = "colContentRtf";
            public string status = "status";
            public string sortNo = "sortNo";
        }
    }


}
