using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// DEF_DIRECTION_ITEM
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "DEF_DIRECTION_ITEM")]
    public class EntityDefDirectionItem : BaseDataContract
    {
        /// <summary>
        /// DIRE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIRE_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String direCode { get; set; }

        /// <summary>
        /// ITEM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ITEM_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// CLASS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLASS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String class2 { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String type { get; set; }

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
            public string itemCode = "itemCode";
            public string class2 = "class";
            public string type = "type";
        }
    }

}
