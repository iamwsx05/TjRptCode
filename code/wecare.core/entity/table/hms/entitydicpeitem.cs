using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityDicPeItem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicPeItem")]
    public class EntityDicPeItem : BaseDataContract
    {
        /// <summary>
        /// itemId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String itemId { get; set; }

        /// <summary>
        /// itemName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String itemName { get; set; }

        /// <summary>
        /// deptId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String deptId { get; set; }

        /// <summary>
        /// minValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "minValue", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal? minValue { get; set; }

        /// <summary>
        /// maxValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "maxValue", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? maxValue { get; set; }

        /// <summary>
        /// refRange
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refRange", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String refRange { get; set; }

        /// <summary>
        /// gender
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "gender", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 gender { get; set; }

        /// <summary>
        /// displayPosition
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "displayPosition", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 displayPosition { get; set; }

        /// <summary>
        /// unit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String unit { get; set; }

        /// <summary>
        /// itemInfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemInfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String itemInfo { get; set; }

        /// <summary>
        /// isCompare
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isCompare", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Int32 isCompare { get; set; }

        /// <summary>
        /// isMain
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isMain", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Int32 isMain { get; set; }

        /// <summary>
        /// sortNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Int32 sortNo { get; set; }

        [DataMember]
        public string sex
        {
            get
            {
                if (gender == 1)
                    return "男";
                else if (gender == 2)
                    return "女";
                else
                    return "不限";
            }
            set {; }
        }

        [DataMember]
        public string deptName { get; set; }

        [DataMember]
        public string displayPositionName
        {
            get
            {
                if (displayPosition == 1)
                    return "推荐";
                else if (displayPosition == 2)
                    return "必查";
                else
                    return "无";
            }
            set {; }
        }

        [DataMember]
        public string isCompareName
        {
            get
            {
                return isCompare == 1 ? "是" : "否";
            }
            set {; }
        }

        [DataMember]
        public string isMainName
        {
            get
            {
                return isMain == 1 ? "是" : "否";
            }
            set {; }
        }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string itemId = "itemId";
            public string itemName = "itemName";
            public string deptId = "deptId";
            public string minValue = "minValue";
            public string maxValue = "maxValue";
            public string refRange = "refRange";
            public string gender = "gender";
            public string displayPosition = "displayPosition";
            public string unit = "unit";
            public string itemInfo = "itemInfo";
            public string isCompare = "isCompare";
            public string isMain = "isMain";
            public string sortNo = "sortNo";

            public string deptName = "deptName";
            public string sex = "sex";
            public string displayPositionName = "displayPositionName";
            public string isCompareName = "isCompareName";
            public string isMainName = "isMainName";
        }
    }
}
