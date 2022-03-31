using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// AS_DEF_REQITEM
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "AS_DEF_REQITEM")]
    public class EntityAsDefReqItem : BaseDataContract
    {
        /// <summary>
        /// ROOM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROOM_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String roomCode { get; set; }

        /// <summary>
        /// GROUP_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "GROUP_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String groupCode { get; set; }

        /// <summary>
        /// ITEM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ITEM_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// RATIO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RATIO", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal ratio { get; set; }

        /// <summary>
        /// QTY
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "QTY", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal qty { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string roomCode = "roomCode";
            public string groupCode = "groupCode";
            public string itemCode = "itemCode";
            public string ratio = "ratio";
            public string qty = "qty";
        }
    }

}
