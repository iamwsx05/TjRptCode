using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using weCare.Core.Entity;
using System.Drawing;

namespace Hms.Entity
{
    /// <summary>
    /// EntityReportMainItem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "reportMainItem")]
    public class EntityReportMainItem : BaseDataContract
    {
        /// <summary>
        /// id
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "id", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String id { get; set; }

        /// <summary>
        /// clientId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "clientId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String clientId { get; set; }

        /// <summary>
        /// reportId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String reportId { get; set; }

        /// <summary>
        /// sectionName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sectionName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String sectionName { get; set; }

        /// <summary>
        /// itemName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String itemName { get; set; }

        /// <summary>
        /// itemValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemValue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String itemValue { get; set; }

        /// <summary>
        /// itemUnits
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemUnits", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String itemUnits { get; set; }

        /// <summary>
        /// itemRefrange
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemRefrange", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String itemRefrange { get; set; }

        /// <summary>
        /// isNormal
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isNormal", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String isNormal { get; set; }

        /// <summary>
        /// minValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "minValue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String minValue { get; set; }

        /// <summary>
        /// maxValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "maxValue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String maxValue { get; set; }

        /// <summary>
        /// orderId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal? orderId { get; set; }

        /// <summary>
        /// bakField1
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bakField1", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String bakField1 { get; set; }

        /// <summary>
        /// bakField2
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bakField2", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String bakField2 { get; set; }

        /// <summary>
        /// createDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "createDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.DateTime? createDate { get; set; }

        /// <summary>
        /// createId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "createId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String createId { get; set; }

        /// <summary>
        /// createName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "createName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String createName { get; set; }

        /// <summary>
        /// modifyDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifyDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.DateTime? modifyDate { get; set; }

        /// <summary>
        /// modifyId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifyId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String modifyId { get; set; }

        /// <summary>
        /// modifyName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifyName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String modifyName { get; set; }
         
        [DataMember]
        public Image pic { get; set; }

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
            public string reportId = "reportId";
            public string sectionName = "sectionName";
            public string itemName = "itemName";
            public string itemValue = "itemValue";
            public string itemUnits = "itemUnits";
            public string itemRefrange = "itemRefrange";
            public string isNormal = "isNormal";
            public string minValue = "minValue";
            public string maxValue = "maxValue";
            public string orderId = "orderId";
            public string bakField1 = "bakField1";
            public string bakField2 = "bakField2";
            public string createDate = "createDate";
            public string createId = "createId";
            public string createName = "createName";
            public string modifyDate = "modifyDate";
            public string modifyId = "modifyId";
            public string modifyName = "modifyName";
        }
    }
}
