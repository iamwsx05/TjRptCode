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
    /// dicItem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicItem")]
    public class EntityDicItem : BaseDataContract
    {
        /// <summary>
        /// Itemid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String itemId { get; set; }

        /// <summary>
        /// Itemcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// Itemname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String itemName { get; set; }

        /// <summary>
        /// Itemcomname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemComName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String itemComName { get; set; }

        /// <summary>
        /// Itemprtnname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "itemPrtnName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String itemPrtnName { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String typeId { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pyCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Spec
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "spec", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String spec { get; set; }

        /// <summary>
        /// Dosage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosage", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal? dosage { get; set; }

        /// <summary>
        /// Dosageunit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageUnit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String dosageUnit { get; set; }

        /// <summary>
        /// Packqty
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packQty", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal? packQty { get; set; }

        /// <summary>
        /// Unit
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unit", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String unit { get; set; }

        /// <summary>
        /// Tradeprice
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tradePrice", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Decimal tradePrice { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "price", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal price { get; set; }

        /// <summary>
        /// Sbtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sbType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Decimal sbType { get; set; }

        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String usageId { get; set; }

        /// <summary>
        /// Freqid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String freqId { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "remark", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String remark { get; set; }

        [DataMember]
        public string usageName { get; set; }
        [DataMember]
        public string usagePrtName { get; set; }
        [DataMember]
        public string usageTypeId { get; set; }
        [DataMember]
        public string isSt { get; set; }
        [DataMember]
        public string freqName { get; set; }
        [DataMember]
        public string freqPrtName { get; set; }
        [DataMember]
        public int times { get; set; }
        [DataMember]
        public string sbTypeName
        {
            set { ;}
            get
            {
                if (sbType == 1)
                    return "甲类";
                else if (sbType == 2)
                    return "乙类";
                else
                    return "";
            }
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
            public string itemCode = "itemCode";
            public string itemName = "itemName";
            public string itemComName = "itemComName";
            public string itemPrtnName = "itemPrtnName";
            public string typeId = "typeId";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string spec = "spec";
            public string dosage = "dosage";
            public string dosageUnit = "dosageUnit";
            public string packQty = "packQty";
            public string unit = "unit";
            public string tradePrice = "tradePrice";
            public string price = "price";
            public string sbType = "sbType";
            public string usageId = "usageId";
            public string freqId = "freqId";
            public string remark = "remark";

            public string usageName = "usageName";
            public string usagePrtName = "usagePrtName";
            public string usageTypeId = "usageTypeId";
            public string isSt = "isSt";
            public string freqName = "freqName";
            public string freqPrtName = "freqPrtName";
            public string times = "times";
            public string sbTypeName = "sbTypeName";
        }
    }

}
