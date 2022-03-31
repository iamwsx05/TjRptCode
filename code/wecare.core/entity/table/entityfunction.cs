using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// sysFunction
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "sysFunction")]
    public class EntityFunction : BaseDataContract, IComparable
    {
        /// <summary>
        /// Funcid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "funcid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Funcid { get; set; }

        /// <summary>
        /// Funccode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "funccode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Funccode { get; set; }

        /// <summary>
        /// Funcname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "funcname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Funcname { get; set; }

        /// <summary>
        /// Funcfile
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "funcfile", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Funcfile { get; set; }

        /// <summary>
        /// Functype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "functype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Int32 Functype { get; set; }

        /// <summary>
        /// Opername
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opername", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Opername { get; set; }

        /// <summary>
        /// Parentid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 Parentid { get; set; }

        /// <summary>
        /// Levelid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "levelid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 Levelid { get; set; }

        /// <summary>
        /// Leafflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "leafflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 Leafflag { get; set; }

        /// <summary>
        /// Imagesource
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "imagesource", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Imagesource { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Int32 Sortno { get; set; }

        [DataMember]
        public int sortNo
        {
            get
            {
                if (Sortno == null)
                    return 0;
                else
                    return int.Parse(Sortno.ToString());
            }
            set { Sortno = value; }
        }

        [DataMember]
        public string Functypename { get; set; }

        [DataMember]
        public string Leafflagname { get; set; }

        [DataMember]
        public int imageIndex { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Funcid = "Funcid";
            public string Funccode = "Funccode";
            public string Funcname = "Funcname";
            public string Funcfile = "Funcfile";
            public string Functype = "Functype";
            public string Opername = "Opername";
            public string Parentid = "Parentid";
            public string Levelid = "Levelid";
            public string Leafflag = "Leafflag";
            public string Imagesource = "Imagesource";
            public string Sortno = "Sortno";
            public string Functypename = "Functypename";
            public string Leafflagname = "Leafflagname";
            public string imageIndex = "imageIndex";
        }

        /// <summary>
        /// 比较
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityFunction)
            {
                return this.sortNo.CompareTo(((EntityFunction)obj).sortNo);
            }
            return 0;
        }
    }

    [DataContract, Serializable]
    public class EntityModule : BaseDataContract
    {
        [DataMember]
        public int ModuleID { get; set; }

        [DataMember]
        public string ModuleName { get; set; }
    }
}
