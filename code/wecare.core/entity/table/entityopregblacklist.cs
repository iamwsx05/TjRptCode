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
    /// opRegBlackList
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegBlackList")]
    public class EntityOpRegBlackList : BaseDataContract
    {
        /// <summary>
        /// Cardno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cardNo", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String cardNo { get; set; }

        /// <summary>
        /// Patientid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String patientId { get; set; }

        /// <summary>
        /// Patname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String patName { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// Locktimes
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockTimes", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Int32 lockTimes { get; set; }

        /// <summary>
        /// Lockstartdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockStartDate", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String lockStartDate { get; set; }

        /// <summary>
        /// Lockdays
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockDays", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 lockDays { get; set; }

        /// <summary>
        /// Unlockopercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unLockOperCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String unLockOperCode { get; set; }

        /// <summary>
        /// Unlocktime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "unLockTime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.DateTime? unLockTime { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string cardNo = "cardNo";
            public string patientId = "patientId";
            public string patName = "patName";
            public string recordDate = "recordDate";
            public string lockTimes = "lockTimes";
            public string lockStartDate = "lockStartDate";
            public string lockDays = "lockDays";
            public string unLockOperCode = "unLockOperCode";
            public string unLockTime = "unLockTime";
            public string status = "status";
        }
    }

}
