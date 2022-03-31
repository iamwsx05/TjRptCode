using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Hms.Entity
{
    /// <summary>
    /// EntityReportMainItemConfig
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "reportMainItemConfig")]
    public class EntityReportMainItemConfig : BaseDataContract
    {
        /// <summary>
        /// itemCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// itemName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String itemName { get; set; }

        /// <summary>
        /// sort
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sort", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32? sort { get; set; }

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
            public string itemName = "itemName";
            public string sort = "sort";
        }
    }
}
