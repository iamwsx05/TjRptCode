using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrFieldInfo
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrFieldInfo")]
    public class EntityEmrFieldInfo : BaseDataContract
    {
        /// <summary>
        /// Formcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String formCode { get; set; }

        /// <summary>
        /// Fieldcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String fieldCode { get; set; }

        /// <summary>
        /// Fielddesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fielddesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String fieldDesc { get; set; }

        /// <summary>
        /// Fieldtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldtype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal? fieldType { get; set; }

        /// <summary>
        /// Referencetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "referencetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? referenceType { get; set; }

        /// <summary>
        /// Nullflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "nullflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal? nullFlag { get; set; }

        /// <summary>
        /// Elementitems
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "elementitems", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String elementItems { get; set; }

        /// <summary>
        /// Defaultrows
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "defaultrows", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? defaultRows { get; set; }

        /// <summary>
        /// Qctype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "qctype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? qcType { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal? sortNo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string formCode = "formCode";
            public string fieldCode = "fieldCode";
            public string fieldDesc = "fieldDesc";
            public string fieldType = "fieldType";
            public string referenceType = "referenceType";
            public string nullFlag = "nullFlag";
            public string elementItems = "elementItems";
            public string defaultRows = "defaultRows";
            public string qcType = "qcType";
            public string sortNo = "sortNo";
        }
    }

}
