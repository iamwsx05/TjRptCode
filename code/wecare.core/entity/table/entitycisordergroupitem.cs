using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// cisOrderGroupItem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "cisOrderGroupItem")]
    public class EntityOrderGroupItem : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Pattype 1 门诊 2 住院
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pattype", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String patType { get; set; }

        /// <summary>
        /// Regno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String regNo { get; set; }

        /// <summary>
        /// Orderno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String orderNo { get; set; }

        /// <summary>
        /// Roomcode 专业组编号
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roomcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String roomCode { get; set; }

        /// <summary>
        /// Groupcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String groupCode { get; set; }

        /// <summary>
        /// Groupname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String groupName { get; set; }

        /// <summary>
        /// Itemcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// flag 1 医嘱带出项目（用法） 2 组合项目(检验 检查)
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String flag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string serNo = "serNo";
            public string patType = "patType";
            public string regNo = "regNo";
            public string orderNo = "orderNo";
            public string roomCode = "roomCode";
            public string groupCode = "groupCode";
            public string groupName = "groupName";
            public string itemCode = "itemCode";
            public string flag = "flag";

            public string isHRecipe = "isHRecipe"; 
        }

        /// <summary>
        /// 是否草药处方
        /// </summary>
        [DataMember]
        public bool isHRecipe { get; set; }
    }

}
