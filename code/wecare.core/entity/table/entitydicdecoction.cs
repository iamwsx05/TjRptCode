using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// dicDecoction
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicDecoction")]
    public class EntityDicDecoction : BaseDataContract
    {
        /// <summary>
        /// Decid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 decId { get; set; }

        /// <summary>
        /// Deccode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deccode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String decCode { get; set; }

        /// <summary>
        /// Decname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String decName { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 typeId { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string decId = "decId";
            public string decCode = "decCode";
            public string decName = "decName";
            public string typeId = "typeId";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string status = "status";
        }
    }

}
