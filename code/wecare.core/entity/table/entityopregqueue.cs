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
    /// opRegQueue
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegQueue")]
    public class EntityOpRegQueue : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// regDid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal regDid { get; set; }

        /// <summary>
        /// Regdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String regDate { get; set; }

        /// <summary>
        /// Plantime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "planTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String planTime { get; set; }

        /// <summary>
        /// finishTime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "finishTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String finishTime { get; set; }
        
        /// <summary>
        /// ltFlag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ltFlag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal ltFlag { get; set; }
        
        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Roomcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roomCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String roomCode { get; set; }

        /// <summary>
        /// Doctcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String doctCode { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal? typeId { get; set; }

        /// <summary>
        /// Regtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regTime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.DateTime? regTime { get; set; }

        /// <summary>
        /// Regno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String regNo { get; set; }

        /// <summary>
        /// Queueno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "queueNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal? queueNo { get; set; }

        /// <summary>
        /// Pid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String pid { get; set; }

        /// <summary>
        /// Bookingid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bookingId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal? bookingId { get; set; }

        /// <summary>
        /// Isplus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isPlus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.Decimal isPlus { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal status { get; set; }

        /// <summary>
        /// amPm
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "amPm", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Int32 amPm { get; set; }

        /// <summary>
        /// Queueno2
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "queueNo2", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Decimal? queueNo2 { get; set; }

        /// <summary>
        /// checkInTime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "checkInTime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.DateTime? checkInTime { get; set; }
        
        [DataMember]
        public int limitNum { get; set; }

        [DataMember]
        public int freqNum { get; set; }

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
            public string regDate = "regDate";
            public string planTime = "planTime";
            public string finishTime = "finishTime";
            public string ltFlag = "ltFlag";
            public string deptCode = "deptCode";
            public string roomCode = "roomCode";
            public string doctCode = "doctCode";
            public string typeId = "typeId";
            public string regTime = "regTime";
            public string regNo = "regNo";
            public string queueNo = "queueNo";
            public string pid = "pid";
            public string bookingId = "bookingId";
            public string isPlus = "isPlus";
            public string status = "status";
            public string queueNo2 = "queueNo2";
            public string checkInTime = "checkInTime";

            public string amPm = "amPm";
            public string limitNum = "limitNum";
            public string freqNum = "freqNum";
        }
    }

}
