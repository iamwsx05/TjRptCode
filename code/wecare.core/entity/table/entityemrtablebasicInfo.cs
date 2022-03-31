using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrTableBasicInfo
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrTableBasicInfo")]
    public class EntityEmrTableBasicInfo : BaseDataContract
    {
        /// <summary>
        /// Tablecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tablecode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String tableCode { get; set; }

        /// <summary>
        /// Tablename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tablename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String tableName { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Displaytype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "displaytype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? displayType { get; set; }

        /// <summary>
        /// Displayrows
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "displayrows", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal? displayRows { get; set; }

        /// <summary>
        /// Tableheaderdisplay
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tableheaderdisplay", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal? tableHeaderDisplay { get; set; }

        /// <summary>
        /// Headerwidth
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "headerwidth", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String headerWidth { get; set; }

        /// <summary>
        /// Rowheight
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rowheight", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? rowHeight { get; set; }

        /// <summary>
        /// Sortfieldname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortfieldname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String sortFieldName { get; set; }

        [DataMember]
        public string origTableCode { get; set; }

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
            public string origTableCode = "origTableCode";
            public string tableCode = "tableCode";
            public string tableName = "tableName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string displayType = "displayType";
            public string displayRows = "displayRows";
            public string tableHeaderDisplay = "tableHeaderDisplay";
            public string headerWidth = "headerWidth";
            public string rowHeight = "rowHeight";
            public string sortFieldName = "sortFieldName";
            public string parent = "parent";
            public string imageIndex = "imageIndex";

        }
    }

}
