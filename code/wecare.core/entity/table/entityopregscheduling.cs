using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region opRegScheduling
    /// <summary>
    /// opRegScheduling
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegScheduling")]
    public class EntityOpRegScheduling : BaseDataContract
    {
        /// <summary>
        /// Regwid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regWid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal regWid { get; set; }

        /// <summary>
        /// Weekid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "weekId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Int32 weekId { get; set; }

        /// <summary>
        /// Regcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String regCode { get; set; }

        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Roomcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roomCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String roomCode { get; set; }

        /// <summary>
        /// Doctcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String doctCode { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "remark", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String comment { get; set; }

        /// <summary>
        /// ltFlag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ltFlag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 ltFlag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string regWid = "regWid";
            public string weekId = "weekId";
            public string regCode = "regCode";
            public string deptCode = "deptCode";
            public string roomCode = "roomCode";
            public string doctCode = "doctCode";
            public string comment = "comment";
            public string regName = "regName";
            public string deptName = "deptName";
            public string roomName = "roomName";
            public string doctName = "doctName";
            public string ltFlag = "ltFlag";
            public string isScheduling = "isScheduling";
        }

        [DataMember]
        public string regName { get; set; }

        [DataMember]
        public string deptName { get; set; }

        [DataMember]
        public string roomName { get; set; }

        [DataMember]
        public string doctName { get; set; }

        [DataMember]
        public int isScheduling { get; set; }
    }

    #endregion

    #region opRegSchedulingDate
    /// <summary>
    /// opRegSchedulingDate
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegSchedulingDate")]
    public class EntityOpRegSchedulingDate : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Regwid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regWid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal regWid { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 typeId { get; set; }

        /// <summary>
        /// Ampm
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amPm", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 amPm { get; set; }

        /// <summary>
        /// Starttime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "startTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String startTime { get; set; }

        /// <summary>
        /// Endtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "endTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String endTime { get; set; }

        /// <summary>
        /// Limitnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "limitNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 limitNum { get; set; }

        /// <summary>
        /// freqNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal freqNum { get; set; }

        /// <summary>
        /// regCode
        /// </summary>
        [DataMember]
        //[EntityAttribute(FieldName = "regCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String regCode { get; set; }

        [DataMember]
        public int weekId { get; set; }

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
            public string regWid = "regWid";
            public string typeId = "typeId";
            public string amPm = "amPm";
            public string startTime = "startTime";
            public string endTime = "endTime";
            public string limitNum = "limitNum";
            public string freqNum = "freqNum";
            public string regCode = "regCode";
            public string weekId = "weekId";
        }
    }
    #endregion

    #region opRegSchedulingNumber
    /// <summary>
    /// opRegSchedulingNumber
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegSchedulingNumber")]
    public class EntityOpRegSchedulingNumber : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Regwid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regWid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal regWid { get; set; }

        /// <summary>
        /// Ampm
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amPm", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 amPm { get; set; }

        /// <summary>
        /// Starttime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "startTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String startTime { get; set; }

        /// <summary>
        /// Endtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "endTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String endTime { get; set; }

        /// <summary>
        /// Normalnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "normalNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 normalNum { get; set; }

        /// <summary>
        /// Webnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "webNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 webNum { get; set; }

        /// <summary>
        /// Wenum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "weNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 weNum { get; set; }

        /// <summary>
        /// Telnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "telNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 telNum { get; set; }

        /// <summary>
        /// Localnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "localNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 localNum { get; set; }

        /// <summary>
        /// Othnum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "othNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Int32 othNum { get; set; }

        /// <summary>
        /// regCode
        /// </summary>
        [DataMember]
        //[EntityAttribute(FieldName = "regCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String regCode { get; set; }

        [DataMember]
        public decimal weekId { get; set; }

        [DataMember]
        public string weekIdName { get; set; }

        [DataMember]
        public string regCodeName { get; set; }

        [DataMember]
        public string amPmName { get; set; }

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
            public string regWid = "regWid";
            public string amPm = "amPm";
            public string amPmName = "amPmName";
            public string startTime = "startTime";
            public string endTime = "endTime";
            public string normalNum = "normalNum";
            public string webNum = "webNum";
            public string weNum = "weNum";
            public string telNum = "telNum";
            public string localNum = "localNum";
            public string othNum = "othNum";
            public string weekId = "weekId";
            public string weekIdName = "weekIdName";
            public string regCode = "regCode";
            public string regCodeName = "regCodeName";
        }
    }
    #endregion

    #region opRegSchedulingDoct
    /// <summary>
    /// opRegSchedulingDoct
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegSchedulingDoct")]
    public class EntityOpRegSchedulingDoct : BaseDataContract
    {
        /// <summary>
        /// Doctcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String doctCode { get; set; }

        /// <summary>
        /// Doctname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String doctName { get; set; }

        /// <summary>
        /// Doctphoto
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctPhoto", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Byte[] doctPhoto { get; set; }

        /// <summary>
        /// Doctintroduce
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctIntroduce", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String doctIntroduce { get; set; }

        /// <summary>
        /// doctSkill
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctSkill", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String doctSkill { get; set; }

        [DataMember]
        public string rankName { get; set; }

        [DataMember]
        public bool isConfirm { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string doctCode = "doctCode";
            public string doctName = "doctName";
            public string doctPhoto = "doctPhoto";
            public string doctIntroduce = "doctIntroduce";
            public string doctSkill = "doctSkill";
            public string rankName = "rankName";
            public string isConfirm = "isConfirm";
        }
    }
    #endregion

    #region EntityOpRegSchedulingDatePlus
    /// <summary>
    /// EntityOpRegSchedulingDatePlus
    /// </summary>
    [DataContract, Serializable]
    public class EntityOpRegSchedulingDatePlus : BaseDataContract
    {
        [DataMember]
        public decimal serNo { get; set; }
        [DataMember]
        public decimal weekId { get; set; }
        [DataMember]
        public decimal amPm { get; set; }
        [DataMember]
        public string regCode { get; set; }
        [DataMember]
        public string weekIdName { get; set; }
        [DataMember]
        public string amPmName { get; set; }
        [DataMember]
        public string regCodeName { get; set; }
        [DataMember]
        public decimal limitNum { get; set; }
        [DataMember]
        public decimal freqNum { get; set; }
        [DataMember]
        public int status { get; set; }
        [DataMember]
        public string statusName { get; set; }
        [DataMember]
        public decimal regWid { get; set; }
        [DataMember]
        public decimal regDid { get; set; }
        [DataMember]
        public string regDate { get; set; }
        [DataMember]
        public string dateScope { get; set; }
        [DataMember]
        public int check { get; set; }
        [DataMember]
        public decimal addNo { get; set; }
        [DataMember]
        public bool isHaveQueue { get; set; }
        [DataMember]
        public bool isConfirm { get; set; }
        [DataMember]
        public int limitTypeId { get; set; }
        [DataMember]
        public string limitTypeName { get; set; }

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
            public string weekId = "weekId";
            public string amPm = "amPm";
            public string regCode = "regCode";
            public string weekIdName = "weekIdName";
            public string amPmName = "amPmName";
            public string regCodeName = "regCodeName";
            public string limitNum = "limitNum";
            public string freqNum = "freqNum";
            public string status = "status";
            public string statusName = "statusName";
            public string regWid = "regWid";
            public string regDid = "regDid";
            public string regDate = "regDate";
            public string dateScope = "dateScope";
            public string check = "check";
            public string addNo = "addNo";
            public string limitTypeId = "limitTypeId"; 
        }
    }
    #endregion
}
