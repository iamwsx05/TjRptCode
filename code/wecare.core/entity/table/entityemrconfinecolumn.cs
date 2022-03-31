using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrConfineColumn
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrConfineColumn")]
    public class EntityEmrConfineColumn : BaseDataContract
    {
        /// <summary>
        /// Serid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 serId { get; set; }

        /// <summary>
        /// Identtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "identtype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Int32 identType { get; set; }

        /// <summary>
        /// Confinetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confinetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 confineType { get; set; }

        /// <summary>
        /// Opersign
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opersign", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 operSign { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "value", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String value { get; set; }

        /// <summary>
        /// Valtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "valtype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 valType { get; set; }

        /// <summary>
        /// Casecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String caseCode { get; set; }

        /// <summary>
        /// Colcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String colCode { get; set; }

        /// <summary>
        /// Groupcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String groupCode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string serId = "serId";
            public string identType = "identType";
            public string confineType = "confineType";
            public string operSign = "operSign";
            public string value = "value";
            public string valType = "valType";
            public string caseCode = "caseCode";
            public string colCode = "colCode";
            public string groupCode = "groupCode";
        }
    }

    /// <summary>
    /// emrSelfDefineCol
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrSelfDefineCol")]
    public class EntityEmrSelfDefineCol : BaseDataContract
    {
        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Casecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String caseCode { get; set; }

        /// <summary>
        /// Colcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String colCode { get; set; }

        /// <summary>
        /// Coldesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "coldesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String colDesc { get; set; }

        /// <summary>
        /// Pageno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pageno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 5)]
        public System.Int32 pageNo { get; set; }

        /// <summary>
        /// vRows
        /// </summary>
        [DataMember]
        public int vRows { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string registerId = "registerId";
            public string caseCode = "caseCode";
            public string colCode = "colCode";
            public string colDesc = "colDesc";
            public string pageNo = "pageNo";
            public string vRows = "vRows";
        }
    }
}
