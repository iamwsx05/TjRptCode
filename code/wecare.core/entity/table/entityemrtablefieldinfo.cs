using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrTableFieldInfo
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrTableFieldInfo")]
    public class EntityEmrTableFieldInfo : BaseDataContract
    {
        /// <summary>
        /// Tablecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tablecode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String tableCode { get; set; }

        /// <summary>
        /// Bandname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bandname", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String bandName { get; set; }

        /// <summary>
        /// Fieldname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldname", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String fieldName { get; set; }

        /// <summary>
        /// Fieldcaptain
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldcaptain", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String fieldCaptain { get; set; }

        /// <summary>
        /// Fieldwidth
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldwidth", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? fieldWidth { get; set; }

        /// <summary>
        /// Fieldtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldtype", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String fieldType { get; set; }

        /// <summary>
        /// Fieldconfig
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldconfig", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String fieldConfig { get; set; }

        /// <summary>
        /// Allownull
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "allownull", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 allowNull { get; set; }

        /// <summary>
        /// Alloweditaftersave
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "alloweditaftersave", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 allowEditAfterSave { get; set; }

        /// <summary>
        /// Showunderline
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "showunderline", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 showUnderline { get; set; }

        /// <summary>
        /// Autosign
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "autosign", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Int32 autoSign { get; set; }

        /// <summary>
        /// Allmultiline
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "allmultiline", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal? allMultiline { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
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
            public string tableCode = "tableCode";
            public string bandName = "bandName";
            public string fieldName = "fieldName";
            public string fieldCaptain = "fieldCaptain";
            public string fieldWidth = "fieldWidth";
            public string fieldType = "fieldType";
            public string fieldConfig = "fieldConfig";
            public string allowNull = "allowNull";
            public string allowEditAfterSave = "allowEditAfterSave";
            public string showUnderline = "showUnderline";
            public string autoSign = "autoSign";
            public string allMultiline = "allMultiline";
            public string sortNo = "sortNo";
        }
    }

}
