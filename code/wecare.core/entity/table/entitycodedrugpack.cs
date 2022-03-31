using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_DRUGPACK
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_DRUGPACK")]
    public class EntityCodeDrugpack : BaseDataContract
    {
        /// <summary>
        /// PACK_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PACK_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String packCode { get; set; }

        /// <summary>
        /// PACK_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PACK_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String packName { get; set; }

        /// <summary>
        /// CLASS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLASS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String class2 { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string packCode = "packCode";
            public string packName = "packName";
            public string class2 = "class2";
        }
    }

}
