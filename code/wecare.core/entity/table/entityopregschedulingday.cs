using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region opRegSchedulingDay
    /// <summary>
    /// opRegSchedulingDay
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegSchedulingDay")]
    public class EntityOpRegSchedulingDay : BaseDataContract, IComparable
    {
        /// <summary>
        /// Regdid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal regDid { get; set; }

        /// <summary>
        /// Regdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String regDate { get; set; }

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
        /// Status: 0 停诊； 1 出诊.
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// auditorCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "auditorCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String auditorCode { get; set; }

        /// <summary>
        /// auditDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "auditDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.DateTime? auditDate { get; set; }

        /// <summary>
        /// ltFlag 0 临； 1 长
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ltFlag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Int32 ltFlag { get; set; }

        [DataMember]
        public decimal regParent { get; set; }

        [DataMember]
        public int imageIndex { get; set; }

        [DataMember]
        public string deptName { get; set; }

        [DataMember]
        public string doctName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string regDid = "regDid";
            public string regDate = "regDate";
            public string regCode = "regCode";
            public string deptCode = "deptCode";
            public string roomCode = "roomCode";
            public string doctCode = "doctCode";
            public string comment = "comment";
            public string status = "status";
            public string auditorCode = "auditorCode";
            public string auditDate = "auditDate";
            public string regParent = "regParent";
            public string imageIndex = "imageIndex";
            public string ltFlag = "ltFlag";
        }

        /// <summary>
        /// 比较
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityOpRegSchedulingDay)
            {
                return this.regDate.CompareTo(((EntityOpRegSchedulingDay)obj).regDate);
            }
            return 0;
        }
    }
    #endregion

    #region opRegSchedulingDayDate
    /// <summary>
    /// opRegSchedulingDayDate
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegSchedulingDayDate")]
    public class EntityOpRegSchedulingDayDate : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Regdid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal regDid { get; set; }

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
        /// usedNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usedNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32 usedNum { get; set; }

        /// <summary>
        /// freqNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "freqNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal freqNum { get; set; }

        /// <summary>
        /// usedNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// limitTypeId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "limitTypeId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Int32 limitTypeId { get; set; }

        [DataMember]
        public string regCode { get; set; }

        [DataMember]
        public decimal addNo { get; set; }

        [DataMember]
        public bool isHaveQueue { get; set; }

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
            public string regDid = "regDid";
            public string typeId = "typeId";
            public string amPm = "amPm";
            public string startTime = "startTime";
            public string endTime = "endTime";
            public string limitNum = "limitNum";
            public string usedNum = "usedNum";
            public string freqNum = "freqNum";
            public string status = "status";
            public string regCode = "regCode";
            public string addNo = "addNo";
            public string limitTypeId = "limitTypeId";
        }
    }
    #endregion

    #region opRegSchedulingDayNumber
    /// <summary>
    /// opRegSchedulingDayNumber
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegSchedulingDayNumber")]
    public class EntityOpRegSchedulingDayNumber : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Regdid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal regDid { get; set; }

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
        /// usedNormalNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usedNormalNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Int32 usedNormalNum { get; set; }

        /// <summary>
        /// usedWebNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usedWebNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Int32 usedWebNum { get; set; }

        /// <summary>
        /// usedWeNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usedWeNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Int32 usedWeNum { get; set; }

        /// <summary>
        /// usedTelNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usedTelNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Int32 usedTelNum { get; set; }

        /// <summary>
        /// usedLocalNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usedLocalNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Int32 usedLocalNum { get; set; }

        /// <summary>
        /// usedOthNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usedOthNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Int32 usedOthNum { get; set; }

        [DataMember]
        public string amPmName { get; set; }

        [DataMember]
        public int check { get; set; }

        [DataMember]
        public decimal numberSerNo { get; set; }

        [DataMember]
        public string limitNum { get; set; }

        [DataMember]
        public string surplusNum { get; set; }

        [DataMember]
        public int weekId { get; set; }

        [DataMember]
        public string weekIdName { get; set; }

        [DataMember]
        public string regCode { get; set; }

        [DataMember]
        public string regCodeName { get; set; }

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
            public string serNo = "serNo";
            public string regDid = "regDid";
            public string amPm = "amPm";
            public string startTime = "startTime";
            public string endTime = "endTime";
            public string normalNum = "normalNum";
            public string webNum = "webNum";
            public string weNum = "weNum";
            public string telNum = "telNum";
            public string localNum = "localNum";
            public string othNum = "othNum";
            public string usedNormalNum = "usedNormalNum";
            public string usedWebNum = "usedWebNum";
            public string usedWeNum = "usedWeNum";
            public string usedTelNum = "usedTelNum";
            public string usedLocalNum = "usedLocalNum";
            public string usedOthNum = "usedOthNum";
            public string numberSerNo = "numberSerNo";
            public string surplusNum = "surplusNum";
            public string check = "check";
            public string weekId = "weekId";
            public string weekIdName = "weekIdName";
            public string regCode = "regCode";
            public string regCodeName = "regCodeName";
            public string limitNum = "limitNum";
        }
    }
    #endregion

}
