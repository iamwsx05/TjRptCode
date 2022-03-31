using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region 通用字典
    /// <summary>
    /// EntityCommonDic
    /// </summary>
    [Serializable]
    [EntityAttribute(TableName = "dicCommon")]
    public class EntityCommonDic : BaseDataContract
    {
        /// <summary>
        /// Classid
        /// </summary>
        [EntityAttribute(FieldName = "classid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Classid { get; set; }

        /// <summary>
        /// Classname
        /// </summary>
        [EntityAttribute(FieldName = "classname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Classname { get; set; }

        /// <summary>
        /// Itemcode
        /// </summary>
        [EntityAttribute(FieldName = "itemcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String Itemcode { get; set; }

        /// <summary>
        /// Itemname
        /// </summary>
        [EntityAttribute(FieldName = "itemname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Itemname { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 7)]
        public System.Int32 Status { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Classid = "Classid";
            public string Classname = "Classname";
            public string Itemcode = "Itemcode";
            public string Itemname = "Itemname";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Status = "Status";
        }
    }
    #endregion
        
}
