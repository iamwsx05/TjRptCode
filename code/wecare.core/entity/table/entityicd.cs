using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// ICD (icd10 + icd9cm3)
    /// </summary>
    [DataContract, Serializable]
    public class EntityIcd : BaseDataContract
    {
        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string IcdCode { get; set; }

        [DataMember]
        public string IcdName { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string ParentCode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Type = "Type";
            public string IcdCode = "IcdCode";
            public string IcdName = "IcdName";
            public string PyCode = "PyCode";
            public string WbCode = "WbCode";
            public string ParentCode = "ParentCode";
        }
    }

    #region 诊断
    /// <summary>
    /// EntityIcd10
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicIcd10")]
    public class EntityIcd10 : BaseDataContract
    {
        /// <summary>
        /// Icdcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String Icdcode { get; set; }

        /// <summary>
        /// Icdcnname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdcnname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Icdcnname { get; set; }

        /// <summary>
        /// Icdenname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdenname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Icdenname { get; set; }

        /// <summary>
        /// Icdpycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdpycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Icdpycode { get; set; }

        /// <summary>
        /// Icdwbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdwbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Icdwbcode { get; set; }

        /// <summary>
        /// Parentcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Parentcode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Icdcode = "Icdcode";
            public string Icdcnname = "Icdcnname";
            public string Icdenname = "Icdenname";
            public string Icdpycode = "Icdpycode";
            public string Icdwbcode = "Icdwbcode";
            public string Parentcode = "Parentcode";
        }
    }

    /// <summary>
    /// EntityOpIcd
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicOpicd")]
    public class EntityOpIcd : BaseDataContract
    {
        /// <summary>
        /// Icdcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String Icdcode { get; set; }

        /// <summary>
        /// Icdname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Icdname { get; set; }

        /// <summary>
        /// Level
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "level", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 Level { get; set; }

        /// <summary>
        /// Icdpycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdpycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Icdpycode { get; set; }

        /// <summary>
        /// Icdwbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "icdwbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Icdwbcode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Icdcode = "Icdcode";
            public string Icdname = "Icdname";
            public string Level = "Level";
            public string Icdpycode = "Icdpycode";
            public string Icdwbcode = "Icdwbcode";
        }
    }

    #endregion
}
