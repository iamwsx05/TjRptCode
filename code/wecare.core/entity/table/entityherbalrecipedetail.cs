using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// herbalRecipeDetail
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "herbalRecipeDetail")]
    public class EntityHerbalRecipeDetail : BaseDataContract
    {
        /// <summary>
        /// Recipesubid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipesubid", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal recipeSubId { get; set; }

        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal recipeId { get; set; }

        /// <summary>
        /// Groupno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "groupno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 groupNo { get; set; }

        /// <summary>
        /// Itemcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// Itemname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String itemName { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String spec { get; set; }

        /// <summary>
        /// Unitcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String unitCode { get; set; }

        /// <summary>
        /// Unitname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unitname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String unitName { get; set; }

        /// <summary>
        /// Usagecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String usageCode { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String usageName { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amount", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal amount { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "price", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal price { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "total", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal total { get; set; }

        /// <summary>
        /// Parentflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Int32 parentFlag { get; set; }

        /// <summary>
        /// Parentid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String parentId { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Int32 sortNo { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "remark", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String comment { get; set; }

        /// <summary>
        /// preno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "preno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String preNo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string recipeSubId = "recipeSubId";
            public string recipeId = "recipeId";
            public string groupNo = "groupNo";
            public string itemCode = "itemCode";
            public string itemName = "itemName";
            public string spec = "spec";
            public string unitCode = "unitCode";
            public string unitName = "unitName";
            public string usageCode = "usageCode";
            public string usageName = "usageName";
            public string amount = "amount";
            public string price = "price";
            public string total = "total";
            public string parentFlag = "parentFlag";
            public string parentId = "parentId";
            public string sortNo = "sortNo";
            public string comment = "comment";
            public string preNo = "preNo";
        }
    }

}
