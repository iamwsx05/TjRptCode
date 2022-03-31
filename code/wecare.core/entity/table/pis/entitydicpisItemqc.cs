using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityDicPisItemQc
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicPisItemQc")]
    public class EntityDicPisItemQc : BaseDataContract, IComparable
    {
        /// <summary>
        /// flagId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "flagId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Int32 flagId { get; set; }

        /// <summary>
        /// itemCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// itemName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String itemName { get; set; }

        /// <summary>
        /// sortNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 sortNo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string flagId = "flagId";
            public string itemCode = "itemCode";
            public string itemName = "itemName";
            public string sortNo = "sortNo";
        }

        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityDicPisItemQc)
            {
                return this.sortNo.CompareTo(((EntityDicPisItemQc)obj).sortNo);
            }
            return 0;
        }
    }
}
