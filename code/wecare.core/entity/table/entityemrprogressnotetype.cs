using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrProgressNoteType
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrProgressNoteType")]
    public class EntityProgressNoteType : BaseDataContract
    {
        /// <summary>
        /// Pntypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pntypeid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 pnTypeId { get; set; }

        /// <summary>
        /// Pntypename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pntypename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String pnTypeName { get; set; }

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
        /// Casecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String caseCode { get; set; }

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
        /// Printtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printtype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 printType { get; set; }

        /// <summary>
        /// Printdistince
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printdistince", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 printDistince { get; set; }

        /// <summary>
        /// Titlechange
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "titlechange", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 titleChange { get; set; }

        /// <summary>
        /// Single
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "single", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Int32 single { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string pnTypeId = "pnTypeId";
            public string pnTypeName = "pnTypeName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string caseCode = "caseCode";
            public string status = "status";
            public string sortNo = "sortNo";
            public string printType = "printType";
            public string printDistince = "printDistince";
            public string titleChange = "titleChange";
            public string single = "single";
        }
    }

}
