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
    /// dicPisItem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicPisItem")]
    public class EntityDicPisItem : BaseDataContract
    {
        /// <summary>
        /// Itemcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// Itemname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String itemName { get; set; }

        /// <summary>
        /// Unit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Unit { get; set; }

        /// <summary>
        /// Classid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String classId { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pyCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Refblood
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refBlood", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String refBlood { get; set; }

        /// <summary>
        /// Refmarrow
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refMarrow", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String refMarrow { get; set; }

        /// <summary>
        /// Reflower
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refLower", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String refLower { get; set; }

        /// <summary>
        /// Refupper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "refUpper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String refUpper { get; set; }

        /// <summary>
        /// Hintlower
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hintLower", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String hintLower { get; set; }

        /// <summary>
        /// Hintupper
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hintUpper", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String hintUpper { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal? sortNo { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "remark", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String remark { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal status { get; set; }

        [DataMember]
        public string className { get; set; }

        [DataMember]
        public string statusName { get; set; }

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
            public string unit = "unit";
            public string classId = "classId";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string refBlood = "refBlood";
            public string refMarrow = "refMarrow";
            public string refLower = "refLower";
            public string refUpper = "refUpper";
            public string hintLower = "hintLower";
            public string hintUpper = "hintUpper";
            public string sortNo = "sortNo";
            public string remark = "remark";
            public string status = "status";

            public string className = "className";
            public string statusName = "statusName";
        }
    }

}
