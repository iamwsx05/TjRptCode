using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region EntityFormDesign
    /// <summary>
    /// EntityFormDesign
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrFormDesign")]
    public class EntityFormDesign : BaseDataContract
    {
        /// <summary>
        /// formid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Formid { get; set; }

        /// <summary>
        /// formcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Formcode { get; set; }

        /// <summary>
        /// formname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Formname { get; set; }

        /// <summary>
        /// formtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formtype", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 Formtype { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "version", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 5)]
        public System.Int32 Version { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Panelsize
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "panelsize", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Panelsize { get; set; }

        /// <summary>
        /// Layout
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "layout", DbType = DbType.Xml, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Layout { get; set; }

        /// <summary>
        /// printtemplateid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printtemplateid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 Printtemplateid { get; set; }

        /// <summary>
        /// Recorderid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorderid", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Recorderid { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime Recorddate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Int32 Status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string Formid = "Formid";
            public string Formcode = "Formcode";
            public string Formname = "Formname";
            public string Formtype = "Formtype";
            public string Version = "Version";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Panelsize = "Panelsize";
            public string Layout = "Layout";
            public string Printtemplateid = "Printtemplateid";
            public string Recorderid = "Recorderid";
            public string Recorddate = "Recorddate";
            public string Status = "Status";
            //public string Printfilename = "Printfilename";
            //public string Printfiledata = "Printfiledata";
            public string RecorderName = "RecorderName";
            public string StatusName = "StatusName";
            public string Formdesc = "Formdesc";
            public string imageIndex = "imageIndex";
            public string parent = "parent";
            public string isLeaf = "isLeaf";
        }
        [DataMember]
        public string RecorderName { get; set; }
        [DataMember]
        public string StatusName { get; set; }
        [DataMember]
        public System.Collections.Generic.List<int> lstVersion { get; set; }
        [DataMember]
        public string Formdesc
        {
            get
            {
                if (Formid == 99)
                    return Formname;
                else
                    return Formname + " V." + Version.ToString();
            }
            set { ;}
        }
        [DataMember]
        public int imageIndex { get; set; }
        [DataMember]
        public int parent { get; set; }
        [DataMember]
        public bool isLeaf { get; set; }

        #region 长.宽
        /// <summary>
        /// 高
        /// </summary>
        [DataMember]
        public int PanelHeight
        {
            get
            {
                if (!string.IsNullOrEmpty(Panelsize))
                {
                    string[] size = Panelsize.Split('|');
                    if (size.Length == 2)
                    {
                        return Convert.ToInt32(size[0]);
                    }
                }
                return 0;
            }
            set { ;}
        }
        /// <summary>
        /// 宽
        /// </summary>
        [DataMember]
        public int PanelWidth
        {
            get
            {
                if (!string.IsNullOrEmpty(Panelsize))
                {
                    string[] size = Panelsize.Split('|');
                    if (size.Length == 2)
                    {
                        return Convert.ToInt32(size[1]);
                    }
                }
                return 0;
            }
            set { ;}
        }
        #endregion
    }
    #endregion

}
