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
    /// emrPrintTemplate
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrPrintTemplate")]
    public class EntityEmrPrintTemplate : BaseDataContract
    {
        /// <summary>
        /// Templateid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal templateId { get; set; }

        /// <summary>
        /// Templatecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String templateCode { get; set; }

        /// <summary>
        /// Templatename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String templateName { get; set; }

        /// <summary>
        /// Templateremark
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateRemark", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String templateRemark { get; set; }

        /// <summary>
        /// Templatefile
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateFile", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Byte[] templateFile { get; set; }

        /// <summary>
        /// Templateversion
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateVersion", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 templateVersion { get; set; }

        /// <summary>
        /// Templatedate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime templateDate { get; set; }

        /// <summary>
        /// Templatcreator
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templatCreator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String templatCreator { get; set; }

        /// <summary>
        /// Templatecolumns
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateColumns", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Byte[] templateColumns { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pyCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Tabletype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tableType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Int32 tableType { get; set; }

        /// <summary>
        /// Acrosscols
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "acrossCols", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal? acrossCols { get; set; }

        /// <summary>
        /// Vrows
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "vrows", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal? vrows { get; set; }

        /// <summary>
        /// Useenddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "useEndDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.DateTime? useEndDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// 报表数据源
        /// </summary>
        [DataMember]
        public object dataSource { get; set; }

        [DataMember]
        public string origTemplateCode { get; set; }

        [DataMember]
        public string parent { get; set; }

        [DataMember]
        public int imageIndex { get; set; }

        [DataMember]
        public bool isLeaf { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string templateId = "templateId";
            public string templateCode = "templateCode";
            public string templateName = "templateName";
            public string templateRemark = "templateRemark";
            public string templateFile = "templateFile";
            public string templateVersion = "templateVersion";
            public string templateDate = "templateDate";
            public string templatCreator = "templatCreator";
            public string templateColumns = "templateColumns";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string tableType = "tableType";
            public string acrossCols = "acrossCols";
            public string vrows = "vrows";
            public string useEndDate = "useEndDate";
            public string status = "status";

            public string origTemplateCode = "origTemplateCode";
            public string parent = "parent";
            public string imageIndex = "imageIndex";
            public string isLeaf = "isLeaf";
        }
    }

    /// <summary>
    /// EntityEmrPrintTemplateCols
    /// </summary>
    [DataContract, Serializable]
    public class EntityEmrPrintTemplateCols : BaseDataContract
    {
        /// <summary>
        /// 列.编码
        /// </summary>
        [DataMember]
        public string code { get; set; }

        /// <summary>
        /// 列.名称
        /// </summary>
        [DataMember]
        public string name { get; set; }
    }
}
