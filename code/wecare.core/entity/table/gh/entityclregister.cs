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
    /// CL_REGISTER
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CL_REGISTER")]
    public class EntityClRegister : BaseDataContract
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
        /// PID
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PID", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal PID { get; set; }

        /// <summary>
        /// FEE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FEE_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String FEE_CODE { get; set; }

        /// <summary>
        /// DIAG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String DIAG_CODE { get; set; }

        /// <summary>
        /// REG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String REG_CODE { get; set; }

        /// <summary>
        /// DEPT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DEPT_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String DEPT_CODE { get; set; }

        /// <summary>
        /// DR_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DR_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String DR_CODE { get; set; }

        /// <summary>
        /// REG_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String REG_DATE { get; set; }

        /// <summary>
        /// REG_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String REG_TIME { get; set; }

        /// <summary>
        /// REG_OPER
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_OPER", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String REG_OPER { get; set; }

        /// <summary>
        /// METHOD
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "METHOD", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String METHOD { get; set; }

        /// <summary>
        /// CHRG_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHRG_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String CHRG_FLAG { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String TYPE { get; set; }

        /// <summary>
        /// DIAG_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String DIAG_FLAG { get; set; }

        /// <summary>
        /// CHRG_ADD
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CHRG_ADD", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String CHRG_ADD { get; set; }

        /// <summary>
        /// TRANS_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TRANS_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String TRANS_FLAG { get; set; }

        /// <summary>
        /// JYDJH
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "JYDJH", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String JYDJH { get; set; }

        /// <summary>
        /// DIAG_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.String DIAG_NAME { get; set; }

        /// <summary>
        /// FUR_CHECK
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "FUR_CHECK", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String FUR_CHECK { get; set; }

        /// <summary>
        /// TAKEN_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TAKEN_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.String TAKEN_DATE { get; set; }

        /// <summary>
        /// BLOOD_PRESSURE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BLOOD_PRESSURE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.String BLOOD_PRESSURE { get; set; }

        /// <summary>
        /// INNER_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INNER_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 23)]
        public System.String INNER_FLAG { get; set; }

        /// <summary>
        /// HANG_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "HANG_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 24)]
        public System.String HANG_FLAG { get; set; }

        /// <summary>
        /// ZJ_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ZJ_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 25)]
        public System.String ZJ_FLAG { get; set; }

        /// <summary>
        /// NOTE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NOTE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 26)]
        public System.String NOTE { get; set; }

        /// <summary>
        /// CL_TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CL_TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 27)]
        public System.String CL_TYPE { get; set; }

        /// <summary>
        /// Body_Temperature
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "body_temperature", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 28)]
        public System.Decimal? Body_Temperature { get; set; }

        /// <summary>
        /// yb_brlx
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "yb_brlx", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 29)]
        public System.String Yb_Brlx { get; set; }
        
        /// <summary>
        /// Ieh_Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ieh_status", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 30)]
        public System.String Ieh_Status { get; set; }

        /// <summary>
        /// Fee_Batch
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fee_batch", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 31)]
        public System.String Fee_Batch { get; set; }

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
            public string PID = "PID";
            public string FEE_CODE = "FEE_CODE";
            public string DIAG_CODE = "DIAG_CODE";
            public string REG_CODE = "REG_CODE";
            public string DEPT_CODE = "DEPT_CODE";
            public string DR_CODE = "DR_CODE";
            public string REG_DATE = "REG_DATE";
            public string REG_TIME = "REG_TIME";
            public string REG_OPER = "REG_OPER";
            public string METHOD = "METHOD";
            public string CHRG_FLAG = "CHRG_FLAG";
            public string TYPE = "TYPE";
            public string DIAG_FLAG = "DIAG_FLAG";
            public string CHRG_ADD = "CHRG_ADD";
            public string TRANS_FLAG = "TRANS_FLAG";
            public string JYDJH = "JYDJH";
            public string DIAG_NAME = "DIAG_NAME";
            public string FUR_CHECK = "FUR_CHECK";
            public string TAKEN_DATE = "TAKEN_DATE";
            public string BLOOD_PRESSURE = "BLOOD_PRESSURE";
            public string INNER_FLAG = "INNER_FLAG";
            public string HANG_FLAG = "HANG_FLAG";
            public string ZJ_FLAG = "ZJ_FLAG";
            public string NOTE = "NOTE";
            public string CL_TYPE = "CL_TYPE";
            public string Yb_Brlx = "Yb_Brlx";
            public string Body_Temperature = "Body_Temperature";
            public string Ieh_Status = "Ieh_Status";
            public string Fee_Batch = "Fee_Batch";
        }
    }

}
