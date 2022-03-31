using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_DIRECTION
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_DIRECTION")]
    public class EntityCodeDirection : BaseDataContract
    {
        /// <summary>
        /// DIRE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIRE_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String direCode { get; set; }

        /// <summary>
        /// DIRE_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIRE_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String direName { get; set; }

        /// <summary>
        /// DIRE_CLS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIRE_CLS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String direCls { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String type { get; set; }

        /// <summary>
        /// SCOPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SCOPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String scope { get; set; }

        /// <summary>
        /// DIS_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIS_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String disName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string direCode = "direCode";
            public string direName = "direName";
            public string direCls = "direCls";
            public string type = "type";
            public string scope = "scope";
            public string disName = "disName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
        }
        [DataMember]
        public string pyCode { get; set; }
        [DataMember]
        public string wbCode { get; set; }
    }

}
