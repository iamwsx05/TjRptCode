using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using iCare.Core.Entity;

namespace Common.Entity
{
    /// <summary>
    /// sysFunction
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "sysFunction")]
    public class EntityFunction : BaseDataContract
    {
        /// <summary>
        /// Funcid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "funcid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Funcid { get; set; }

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
        public System.Decimal Functype { get; set; }

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
        public System.Decimal Parentid { get; set; }

        /// <summary>
        /// Levelid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "levelid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? Levelid { get; set; }

        /// <summary>
        /// Leafflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "leafflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? Leafflag { get; set; }

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
        public System.Decimal? Sortno { get; set; }

        [DataMember]
        public string Functypename { get; set; }

        [DataMember]
        public string Leafflagname { get; set; }

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
