using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Common.Entity
{
    /// <summary>
    /// emrProgressNoteMain
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrProgressNoteMain")]
    public class EntityProgressNoteMain : BaseDataContract
    {
        /// <summary>
        /// Pnid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pnid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal pnId { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Pntypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pntypeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32? pnTypeId { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime? recordDate { get; set; }

        /// <summary>
        /// Recorddoctid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddoctid", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String recordDoctId { get; set; }

        /// <summary>
        /// Systemdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "systemdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.DateTime? systemDate { get; set; }

        /// <summary>
        /// Pntitle
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pntitle", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String pnTitle { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32? status { get; set; }

        /// <summary>
        /// Patientname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String patientName { get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sex", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String sex { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "age", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String age { get; set; }

        /// <summary>
        /// Deptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String deptName { get; set; }

        /// <summary>
        /// Areaname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String areaName { get; set; }

        /// <summary>
        /// Bedno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bedno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String bedNo { get; set; }

        /// <summary>
        /// Patientipno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientipno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String patientIpNo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string pnId = "pnId";
            public string registerId = "registerId";
            public string pnTypeId = "pnTypeId";
            public string recordDate = "recordDate";
            public string recordDoctId = "recordDoctId";
            public string systemDate = "systemDate";
            public string pnTitle = "pnTitle";
            public string status = "status";
            public string patientName = "patientName";
            public string sex = "sex";
            public string age = "age";
            public string deptName = "deptName";
            public string areaName = "areaName";
            public string bedNo = "bedNo";
            public string patientIpNo = "patientIpNo";
        }
    }

    /// <summary>
    /// emrProgressNoteContent
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrProgressNoteContent")]
    public class EntityProgressNoteContent : BaseDataContract
    {
        /// <summary>
        /// Pnid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pnid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal pnId { get; set; }

        /// <summary>
        /// Colcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String colCode { get; set; }

        /// <summary>
        /// Colcontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String colContent { get; set; }

        /// <summary>
        /// Colcontentxml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontentxml", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String colContentXml { get; set; }

        /// <summary>
        /// Colcontentrtf
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontentrtf", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Byte[] colContentRtf { get; set; }

        /// <summary>
        /// Colcontentprtrtf
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontentprtrtf", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Byte[] colContentPrtRtf { get; set; }

        /// <summary>
        /// Printflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "printflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 printFlag { get; set; }

        /// <summary>
        /// Tablecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tablecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String tableCode { get; set; }

        /// <summary>
        /// Rowindex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rowindex", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32? rowIndex { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime? recordDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string pnId = "pnId";
            public string colCode = "colCode";
            public string colContent = "colContent";
            public string colContentXml = "colContentXml";
            public string colContentRtf = "colContentRtf";
            public string colContentPrtRtf = "colContentPrtRtf";
            public string printFlag = "printFlag";
            public string tableCode = "tableCode";
            public string rowIndex = "rowIndex";
            public string recordDate = "recordDate";
        }
    }

    /// <summary>
    /// emrProgressNoteTrace
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrProgressNoteTrace")]
    public class EntityProgressNoteTrace : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Pnid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pnid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal pnId { get; set; }

        /// <summary>
        /// Colcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String colCode { get; set; }

        /// <summary>
        /// Colcontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String colContent { get; set; }

        /// <summary>
        /// Colcontentxml
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontentxml", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String colContentXml { get; set; }

        /// <summary>
        /// Colcontentrtf
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcontentrtf", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Byte[] colContentRtf { get; set; }

        /// <summary>
        /// Modifierid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifierid", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String modifierId { get; set; }

        /// <summary>
        /// Modifydate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modifydate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime? modifyDate { get; set; }

        /// <summary>
        /// Tablecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tablecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String tableCode { get; set; }

        /// <summary>
        /// Rowindex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rowindex", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32? rowIndex { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.DateTime? recordDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string serNo = "serNo";
            public string pnId = "pnId";
            public string colCode = "colCode";
            public string colContent = "colContent";
            public string colContentXml = "colContentXml";
            public string colContentRtf = "colContentRtf";
            public string modifierId = "modifierId";
            public string modifyDate = "modifyDate";
            public string tableCode = "tableCode";
            public string rowIndex = "rowIndex";
            public string recordDate = "recordDate";
        }
    }

}
