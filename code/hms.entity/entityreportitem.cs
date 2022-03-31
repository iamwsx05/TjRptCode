using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Hms.Entity
{
    /// <summary>
    /// EntityReportItem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "reportItem")]
    public class EntityReportItem : BaseDataContract
    {
        /// <summary>
        /// reportId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String reportId { get; set; }

        /// <summary>
        /// sectionName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sectionName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String sectionName { get; set; }

        /// <summary>
        /// itemName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String itemName { get; set; }

        /// <summary>
        /// itemValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemValue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String itemValue { get; set; }

        /// <summary>
        /// memo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "memo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String memo { get; set; }

        /// <summary>
        /// itemUnit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemUnit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String itemUnit { get; set; }

        /// <summary>
        /// minValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "minValue", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? minValue { get; set; }

        /// <summary>
        /// maxValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "maxValue", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? maxValue { get; set; }

        /// <summary>
        /// refRange
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refRange", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String refRange { get; set; }

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
            public string sectionName = "sectionName";
            public string itemName = "itemName";
            public string itemValue = "itemValue";
            public string memo = "memo";
            public string itemUnit = "itemUnit";
            public string minValue = "minValue";
            public string maxValue = "maxValue";
            public string refRange = "refRange";
        }
    }
}
