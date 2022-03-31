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
    /// CL_DUTY
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_DUTY")]
    public class EntityClDuty : BaseDataContract
    {
        /// <summary>
        /// DUTY_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DUTY_DATE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String DUTY_DATE { get; set; }

        /// <summary>
        /// DR_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DR_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String DR_CODE { get; set; }

        /// <summary>
        /// SHIFT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SHIFT_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String SHIFT_CODE { get; set; }

        /// <summary>
        /// DIAG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String DIAG_CODE { get; set; }

        /// <summary>
        /// REG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String REG_CODE { get; set; }

        /// <summary>
        /// DEPT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DEPT_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 6)]
        public System.String DEPT_CODE { get; set; }

        /// <summary>
        /// ROOM_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROOM_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String ROOM_CODE { get; set; }

        /// <summary>
        /// LIMIT_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LIMIT_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String LIMIT_FLAG { get; set; }

        /// <summary>
        /// LIMIT_NUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LIMIT_NUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal LIMIT_NUM { get; set; }

        /// <summary>
        /// ADD_NUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ADD_NUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal ADD_NUM { get; set; }

        /// <summary>
        /// BOOK_NUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BOOK_NUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal BOOK_NUM { get; set; }

        /// <summary>
        /// REG_NUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_NUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal REG_NUM { get; set; }

        /// <summary>
        /// DIAG_NUM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_NUM", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Decimal DIAG_NUM { get; set; }

        /// <summary>
        /// Inline
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inline", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Inline { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "regDid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.Decimal regDid { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string DUTY_DATE = "DUTY_DATE";
            public string DR_CODE = "DR_CODE";
            public string SHIFT_CODE = "SHIFT_CODE";
            public string DIAG_CODE = "DIAG_CODE";
            public string REG_CODE = "REG_CODE";
            public string DEPT_CODE = "DEPT_CODE";
            public string ROOM_CODE = "ROOM_CODE";
            public string LIMIT_FLAG = "LIMIT_FLAG";
            public string LIMIT_NUM = "LIMIT_NUM";
            public string ADD_NUM = "ADD_NUM";
            public string BOOK_NUM = "BOOK_NUM";
            public string REG_NUM = "REG_NUM";
            public string DIAG_NUM = "DIAG_NUM";
            public string Inline = "Inline";
            public string regDid = "regDid";
        }
    }

}
