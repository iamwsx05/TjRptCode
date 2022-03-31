using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_ITEM
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_ITEM")]
    public class EntityCodeItem : BaseDataContract
    {
        /// <summary>
        /// ITEM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ITEM_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String itemCode { get; set; }

        /// <summary>
        /// ITEM_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ITEM_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String itemName { get; set; }

        /// <summary>
        /// ITEM_CLS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ITEM_CLS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String itemCls { get; set; }

        /// <summary>
        /// GB_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "GB_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String gbCode { get; set; }

        /// <summary>
        /// MC_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MC_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String mcCode { get; set; }

        /// <summary>
        /// PY_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PY_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// WB_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "WB_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// LA_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LA_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String laCode { get; set; }

        /// <summary>
        /// PH_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PH_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String phCode { get; set; }

        /// <summary>
        /// DRUG_CLS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DRUG_CLS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String drugCls { get; set; }

        /// <summary>
        /// SOUR_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SOUR_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String sourFlag { get; set; }

        /// <summary>
        /// PACK_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PACK_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String packCode { get; set; }

        /// <summary>
        /// ESP_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ESP_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String espFlag { get; set; }

        /// <summary>
        /// EXP_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "EXP_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String expFlag { get; set; }

        /// <summary>
        /// MC_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MC_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String mcFlag { get; set; }

        /// <summary>
        /// SP_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SP_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String spFlag { get; set; }

        /// <summary>
        /// TEST_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TEST_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String testFlag { get; set; }

        /// <summary>
        /// PRICE_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PRICE_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String priceFlag { get; set; }

        /// <summary>
        /// PACK_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PACK_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String packFlag { get; set; }

        /// <summary>
        /// GP_RATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "GP_RATE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.Decimal gpRate { get; set; }

        /// <summary>
        /// AP_RATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "AP_RATE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.Decimal apRate { get; set; }

        /// <summary>
        /// MD_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MD_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String mdFlag { get; set; }

        /// <summary>
        /// CL_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CL_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String clFlag { get; set; }

        /// <summary>
        /// IP_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "IP_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String ipFlag { get; set; }

        /// <summary>
        /// DISABLE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DISABLE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String disable { get; set; }

        /// <summary>
        /// LOC_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LOC_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String locFlag { get; set; }

        /// <summary>
        /// BLOOD_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BLOOD_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String bloodFlag { get; set; }

        /// <summary>
        /// PREP_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PREP_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.String prepFlag { get; set; }

        /// <summary>
        /// PRICE_METHOD
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PRICE_METHOD", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String priceMethod { get; set; }

        /// <summary>
        /// MAX_RETPRICE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MAX_RETPRICE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.Decimal maxRetprice { get; set; }

        /// <summary>
        /// SCQY
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SCQY", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String scqy { get; set; }

        /// <summary>
        /// PZWH
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PZWH", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 32)]
        public System.String pzwh { get; set; }

        /// <summary>
        /// XTBM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "XTBM", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 33)]
        public System.String xtbm { get; set; }

        /// <summary>
        /// XTMC
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "XTMC", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 34)]
        public System.String xtmc { get; set; }

        /// <summary>
        /// XMBM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "XMBM", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 35)]
        public System.String xmbm { get; set; }

        /// <summary>
        /// XMMC
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "XMMC", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 36)]
        public System.String xmmc { get; set; }

        /// <summary>
        /// DIRECT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIRECT_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 37)]
        public System.String directCode { get; set; }

        /// <summary>
        /// CLS_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLS_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 38)]
        public System.String clsFlag { get; set; }

        /// <summary>
        /// MODALITY
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MODALITY", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 39)]
        public System.String modality { get; set; }

        /// <summary>
        /// MC_TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MC_TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 40)]
        public System.String mcType { get; set; }

        /// <summary>
        /// MC_RATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MC_RATE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 41)]
        public System.Decimal mcRate { get; set; }

        /// <summary>
        /// Jq_Code
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "jq_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 42)]
        public System.String jqCode { get; set; }

        /// <summary>
        /// Old_Code
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "old_code", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 43)]
        public System.String oldCode { get; set; }

        /// <summary>
        /// Jjdw2010
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "jjdw2010", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 44)]
        public System.String jjdw2010 { get; set; }

        /// <summary>
        /// Drugg_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "drugg_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 45)]
        public System.String druggFlag { get; set; }

        /// <summary>
        /// Drugs_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "drugs_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 46)]
        public System.String drugsFlag { get; set; }

        /// <summary>
        /// Big_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "big_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 47)]
        public System.String bigFlag { get; set; }

        /// <summary>
        /// Kss_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "kss_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 48)]
        public System.String kssFlag { get; set; }

        /// <summary>
        /// Show_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "show_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 49)]
        public System.String showFlag { get; set; }

        /// <summary>
        /// BL_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BL_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 50)]
        public System.String blFlag { get; set; }

        /// <summary>
        /// BL_MODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BL_MODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 51)]
        public System.String blMode { get; set; }

        /// <summary>
        /// BL_ROOM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BL_ROOM", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 52)]
        public System.String blRoom { get; set; }

        /// <summary>
        /// PRES_ALL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PRES_ALL", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 53)]
        public System.String presAll { get; set; }

        /// <summary>
        /// Batj_Fyfl
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "batj_fyfl", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 54)]
        public System.String batjFyfl { get; set; }

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
            public string itemCls = "itemCls";
            public string gbCode = "gbCode";
            public string mcCode = "mcCode";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string laCode = "laCode";
            public string phCode = "phCode";
            public string drugCls = "drugCls";
            public string sourFlag = "sourFlag";
            public string packCode = "packCode";
            public string espFlag = "espFlag";
            public string expFlag = "expFlag";
            public string mcFlag = "mcFlag";
            public string spFlag = "spFlag";
            public string testFlag = "testFlag";
            public string priceFlag = "priceFlag";
            public string packFlag = "packFlag";
            public string gpRate = "gpRate";
            public string apRate = "apRate";
            public string mdFlag = "mdFlag";
            public string clFlag = "clFlag";
            public string ipFlag = "ipFlag";
            public string disable = "disable";
            public string locFlag = "locFlag";
            public string bloodFlag = "bloodFlag";
            public string prepFlag = "prepFlag";
            public string priceMethod = "priceMethod";
            public string maxRetprice = "maxRetprice";
            public string scqy = "scqy";
            public string pzwh = "pzwh";
            public string xtbm = "xtbm";
            public string xtmc = "xtmc";
            public string xmbm = "xmbm";
            public string xmmc = "xmmc";
            public string directCode = "directCode";
            public string clsFlag = "clsFlag";
            public string modality = "modality";
            public string mcType = "mcType";
            public string mcRate = "mcRate";
            public string jqCode = "jqCode";
            public string oldCode = "oldCode";
            public string jjdw2010 = "jjdw2010";
            public string druggFlag = "druggFlag";
            public string drugsFlag = "drugsFlag";
            public string bigFlag = "bigFlag";
            public string kssFlag = "kssFlag";
            public string showFlag = "showFlag";
            public string blFlag = "blFlag";
            public string blMode = "blMode";
            public string blRoom = "blRoom";
            public string presAll = "presAll";
            public string batjFyfl = "batjFyfl";
        }
    }

}
