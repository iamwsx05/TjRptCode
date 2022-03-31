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
    /// CL_DIAGQUEUE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_DIAGQUEUE")]
    public class EntityClDiagQueue : BaseDataContract
    {
        /// <summary>
        /// REG_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_NO", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String REG_NO { get; set; }

        /// <summary>
        /// DAY_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DAY_NO", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal DAY_NO { get; set; }

        /// <summary>
        /// QUEUE_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "QUEUE_NO", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal QUEUE_NO { get; set; }

        /// <summary>
        /// PID
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PID", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal PID { get; set; }

        /// <summary>
        /// DEPT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DEPT_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String DEPT_CODE { get; set; }

        /// <summary>
        /// ROOM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROOM_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String ROOM_CODE { get; set; }

        /// <summary>
        /// DR_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DR_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String DR_CODE { get; set; }

        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "STATUS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String STATUS { get; set; }

        /// <summary>
        /// REG_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String REG_TIME { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SHIFT_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String SHIFT_CODE { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string REG_NO = "REG_NO";
            public string DAY_NO = "DAY_NO";
            public string QUEUE_NO = "QUEUE_NO";
            public string PID = "PID";
            public string DEPT_CODE = "DEPT_CODE";
            public string ROOM_CODE = "ROOM_CODE";
            public string DR_CODE = "DR_CODE";
            public string STATUS = "STATUS";
            public string REG_TIME = "REG_TIME";
            public string SHIFT_CODE = "SHIFT_CODE";
        }
    }

}
