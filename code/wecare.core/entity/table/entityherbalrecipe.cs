using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// herbalRecipe
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "herbalRecipe")]
    public class EntityHerbalRecipe : BaseDataContract
    {
        /// <summary>
        /// Recipeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal recipeId { get; set; }

        /// <summary>
        /// Recipecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String recipeCode { get; set; }

        /// <summary>
        /// Recipename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String recipeName { get; set; }

        /// <summary>
        /// Recipeattributeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeattributeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 recipeAttributeId { get; set; }

        /// <summary>
        /// Recipetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Int32 recipeType { get; set; }

        /// <summary>
        /// Typeida
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeida", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 typeIdA { get; set; }

        /// <summary>
        /// Typeidb
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidb", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 typeIdB { get; set; }

        /// <summary>
        /// Typeidc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeidc", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 typeIdC { get; set; }

        /// <summary>
        /// Begindatetype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindatetype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 beginDateType { get; set; }

        /// <summary>
        /// Begindate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "begindate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime beginDate { get; set; }

        /// <summary>
        /// Decoction
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoction", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String decoction { get; set; }

        /// <summary>
        /// Decoctionname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decoctionname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String decoctionName { get; set; }

        /// <summary>
        /// Usagecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String usageCode { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String usageName { get; set; }

        /// <summary>
        /// Freqcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String freqCode { get; set; }

        /// <summary>
        /// Freqname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String freqName { get; set; }

        /// <summary>
        /// Dosage
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosage", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal dosage { get; set; }

        /// <summary>
        /// Dosageunitcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dosageunitcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String dosageUnitCode { get; set; }

        /// <summary>
        /// Packs
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "packs", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Int32 packs { get; set; }

        /// <summary>
        /// Outflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Int32 outFlag { get; set; }

        /// <summary>
        /// Helpflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "helpflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Int32 helpFlag { get; set; }

        /// <summary>
        /// Recipemoney
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipemoney", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Decimal recipeMoney { get; set; }

        /// <summary>
        /// Makedoctcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makedoctcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String makeDoctCode { get; set; }

        /// <summary>
        /// Makedeptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "makedeptcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String makeDeptCode { get; set; }

        /// <summary>
        /// Execdeptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String execDeptCode { get; set; }

        /// <summary>
        /// Execdeptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "execdeptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String execDeptName { get; set; }

        /// <summary>
        /// Entrustinfo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "entrustinfo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String entrustInfo { get; set; }

        /// <summary>
        /// Recordopercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordopercode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String recordOperCode { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.DateTime? recordDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Confirmopercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmopercode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String confirmOperCode { get; set; }

        /// <summary>
        /// Confirmdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "confirmdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.DateTime? confirmDate { get; set; }

        /// <summary>
        /// Preno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "preno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.String preNo { get; set; }

        /// <summary>
        /// Regno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.String regNo { get; set; }

        /// <summary>
        /// Pattype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pattype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.Int32 patType { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string recipeId = "recipeId";
            public string recipeCode = "recipeCode";
            public string recipeName = "recipeName";
            public string recipeAttributeId = "recipeAttributeId";
            public string recipeType = "recipeType";
            public string typeIdA = "typeIdA";
            public string typeIdB = "typeIdB";
            public string typeIdC = "typeIdC";
            public string beginDateType = "beginDateType";
            public string beginDate = "beginDate";
            public string decoction = "decoction";
            public string decoctionName = "decoctionName";
            public string usageCode = "usageCode";
            public string usageName = "usageName";
            public string freqCode = "freqCode";
            public string freqName = "freqName";
            public string dosage = "dosage";
            public string dosageUnitCode = "dosageUnitCode";
            public string packs = "packs";
            public string outFlag = "outFlag";
            public string helpFlag = "helpFlag";
            public string recipeMoney = "recipeMoney";
            public string makeDoctCode = "makeDoctCode";
            public string makeDeptCode = "makeDeptCode";
            public string execDeptCode = "execDeptCode";
            public string execDeptName = "execDeptName";
            public string entrustInfo = "entrustInfo";
            public string recordOperCode = "recordOperCode";
            public string recordDate = "recordDate";
            public string status = "status";
            public string confirmOperCode = "confirmOperCode";
            public string confirmDate = "confirmDate";
            public string preNo = "preNo";
            public string regNo = "regNo";
            public string patType = "patType";
        }

        [DataMember]
        public bool isNew { get; set; }

        /// <summary>
        /// 婴儿标志 1，2，3...... (0||null 没有婴儿)
        /// </summary>
        [DataMember]
        public int ChildFlag { get; set; }
    }

}
