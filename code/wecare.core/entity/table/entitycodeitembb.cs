using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_ITEMBB
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_ITEMBB")]
    public class EntityCodeItembb : BaseDataContract
    {
        /// <summary>
        /// ITEM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ITEM_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// MC_TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MC_TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String mcType { get; set; }

        /// <summary>
        /// MC_RATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MC_RATE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal mcRate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string itemCode = "itemCode";
            public string mcType = "mcType";
            public string mcRate = "mcRate";
        }
    }

}
