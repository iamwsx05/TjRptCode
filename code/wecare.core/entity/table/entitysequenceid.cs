using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// sysSequenceid
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "sysSequenceid")]
    public class EntitySequenceID : BaseDataContract
    {
        public static EnumSequenceID Columns = new EnumSequenceID();

        /// <summary>
        /// Tabname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tabname", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String Tabname { get; set; }

        /// <summary>
        /// Colname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colname", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Colname { get; set; }

        /// <summary>
        /// Curid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "curid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal Curid { get; set; }


        public class EnumSequenceID
        {
            public string Tabname = "Tabname";
            public string Colname = "Colname";
            public string Curid = "Curid";
        }
    }
}
