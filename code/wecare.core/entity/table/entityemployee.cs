using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region 职工.new

    /// <summary>
    /// dicEmployee
    /// </summary>
    //[DataContract, Serializable]
    //[EntityAttribute(TableName = "dicEmployee")]
    //public class EntityEmployee : BaseDataContract
    //{
    //    /// <summary>
    //    /// Empid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "empid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
    //    public System.Decimal Empid { get; set; }

    //    /// <summary>
    //    /// Empno
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "empno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
    //    public System.String Empno { get; set; }

    //    /// <summary>
    //    /// Empname
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "empname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
    //    public System.String Empname { get; set; }

    //    /// <summary>
    //    /// Sex
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "sex", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
    //    public System.String Sex { get; set; }

    //    /// <summary>
    //    /// Birthday
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "birthday", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
    //    public System.String Birthday { get; set; }

    //    /// <summary>
    //    /// Idcard
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "idcard", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
    //    public System.String Idcard { get; set; }

    //    /// <summary>
    //    /// Tel
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "tel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
    //    public System.String Tel { get; set; }

    //    /// <summary>
    //    /// Addr
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "addr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
    //    public System.String Addr { get; set; }

    //    /// <summary>
    //    /// Identity
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "idtype", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
    //    public System.String Identity { get; set; }

    //    /// <summary>
    //    /// Technicallevel
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "technicallevel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
    //    public System.String Technicallevel { get; set; }

    //    /// <summary>
    //    /// Adminlevel
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "adminlevel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
    //    public System.String Adminlevel { get; set; }

    //    /// <summary>
    //    /// Signimage_Img
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "signimage", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 12)]
    //    public System.Byte[] Signimage_Img { get; set; }

    //    /// <summary>
    //    /// Signdigital
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "signdigital", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
    //    public System.String Signdigital { get; set; }

    //    /// <summary>
    //    /// Resume
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "resume", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
    //    public System.String Resume { get; set; }

    //    /// <summary>
    //    /// Pwd
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "pwd", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
    //    public System.String Pwd { get; set; }

    //    /// <summary>
    //    /// Pycode
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
    //    public System.String Pycode { get; set; }

    //    /// <summary>
    //    /// Wbcode
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
    //    public System.String Wbcode { get; set; }

    //    /// <summary>
    //    /// Acctstatus
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "acctstatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
    //    public System.Decimal? Acctstatus { get; set; }

    //    /// <summary>
    //    /// Status
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
    //    public System.Decimal? Status { get; set; }

    //    /// <summary>
    //    /// Pwdusedate
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "pwdusedate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 20)]
    //    public System.DateTime? Pwdusedate { get; set; }

    //    /// <summary>
    //    /// Acctlockdate
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "acctlockdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 21)]
    //    public System.DateTime? Acctlockdate { get; set; }

    //    /// <summary>
    //    /// Teacherid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "teacherid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
    //    public System.Decimal? Teacherid { get; set; }

    //    public static EnumCols Columns = new EnumCols();

    //    public class EnumCols
    //    {
    //        public string Empid = "Empid";
    //        public string Empno = "Empno";
    //        public string Empname = "Empname";
    //        public string Sex = "Sex";
    //        public string Birthday = "Birthday";
    //        public string Idcard = "Idcard";
    //        public string Tel = "Tel";
    //        public string Addr = "Addr";
    //        public string Identity = "Identity";
    //        public string Technicallevel = "Technicallevel";
    //        public string Adminlevel = "Adminlevel";
    //        public string Signimage_Img = "Signimage_Img";
    //        public string Signdigital = "Signdigital";
    //        public string Resume = "Resume";
    //        public string Pwd = "Pwd";
    //        public string Pycode = "Pycode";
    //        public string Wbcode = "Wbcode";
    //        public string Acctstatus = "Acctstatus";
    //        public string Status = "Status";
    //        public string Pwdusedate = "Pwdusedate";
    //        public string Acctlockdate = "Acctlockdate";
    //        public string Teacherid = "Teacherid";

    //        public string DeptID = "DeptID";
    //        public string DeptNo = "DeptNo";
    //        public string DeptName = "DeptName";
    //        public string TechnicalLevelNo = "TechnicalLevelNo";
    //        public string TechnicalLevelName = "TechnicalLevelName";
    //        public string AdminLevelNo = "AdminLevelNo";
    //        public string AdminLevelName = "AdminLevelName";
    //        public string Prescription = "Prescription";
    //        public string MedLimits = "MedLimits";
    //        public string ParentDeptID = "ParentDeptID";
    //        public string TreeType = "TreeType";
    //        public string RoleID = "RoleID";

    //        public string EmpidStr = "EmpidStr";
    //    }
    //    [DataMember]
    //    public string EmpidStr { get; set; }
    //    [DataMember]
    //    public string DeptID { get; set; }
    //    [DataMember]
    //    public string DeptNo { get; set; }
    //    [DataMember]
    //    public string DeptName { get; set; }
    //    [DataMember]
    //    public string TechnicalLevelNo { get; set; }
    //    [DataMember]
    //    public string TechnicalLevelName { get; set; }
    //    [DataMember]
    //    public string AdminLevelNo { get; set; }
    //    [DataMember]
    //    public string AdminLevelName { get; set; }
    //    /// <summary>
    //    /// 处方权
    //    /// </summary>
    //    [DataMember]
    //    public List<string> Prescription { get; set; }
    //    /// <summary>
    //    /// 药品(用药)权
    //    /// </summary>
    //    [DataMember]
    //    public List<string> MedLimits { get; set; }
    //    [DataMember]
    //    public string ParentDeptID { get; set; }
    //    [DataMember]
    //    public int TreeType { get; set; }
    //    /// <summary>
    //    /// 所属角色ID列表
    //    /// </summary>
    //    [DataMember]
    //    public List<string> RoleID { get; set; }
    //}

    /// <summary>
    /// defDeptemployee
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "defDeptemployee")]
    public class EntityDefDeptemployee : BaseDataContract
    {
        /// <summary>
        /// Opercode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "operCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String operCode { get; set; }

        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptCode", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// Defaultflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "defaultFlag", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 defaultFlag { get; set; }

        [DataMember]
        public string operName { get; set; }

        [DataMember]
        public string deptName { get; set; }

        [DataMember]
        public string pyCode { get; set; }

        [DataMember]
        public string wbCode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string operCode = "operCode";
            public string deptCode = "deptCode";
            public string defaultFlag = "defaultFlag";
            public string deptName = "deptName";
            public string operName = "operName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
        }
    }

    #endregion

    #region 职工.old

    /// <summary>
    /// CODE_OPERATOR
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_OPERATOR")]
    public class EntityCodeOperator : BaseDataContract
    {
        /// <summary>
        /// OPER_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OPER_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String operCode { get; set; }

        /// <summary>
        /// OPER_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OPER_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String operName { get; set; }

        /// <summary>
        /// NOTE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NOTE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String note { get; set; }

        /// <summary>
        /// PWD
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PWD", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String pwd { get; set; }

        /// <summary>
        /// DB_USER
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DB_USER", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String dbUser { get; set; }

        /// <summary>
        /// DB_PWD
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DB_PWD", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String dbPwd { get; set; }

        /// <summary>
        /// INNER_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INNER_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String innerFlag { get; set; }

        /// <summary>
        /// DISABLE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DISABLE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String disable { get; set; }

        /// <summary>
        /// If_Share
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "if_share", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String ifShare { get; set; }

        /// <summary>
        /// Inline
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "inline", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String inline { get; set; }

        /// <summary>
        /// Ukey
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "Ukey", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String ukey { get; set; }

        /// <summary>
        /// Noukey
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "noUkey", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String noukey { get; set; }

        /// <summary>
        /// Esp_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "esp_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String espFlag { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "acctstatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.Int32 acctStatus { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "acctLockDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.DateTime? acctLockDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string operCode = "operCode";
            public string operName = "operName";
            public string note = "note";
            public string pwd = "pwd";
            public string dbUser = "dbUser";
            public string dbPwd = "dbPwd";
            public string innerFlag = "innerFlag";
            public string disable = "disable";
            public string ifShare = "ifShare";
            public string inline = "inline";
            public string ukey = "ukey";
            public string noukey = "noukey";
            public string espFlag = "espFlag";
            public string acctStatus = "acctStatus";
            public string acctLockDate = "acctLockDate";

            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string rankCode = "rankCode";
            public string rankName = "rankName";
            public string introduce = "introduce";
            public string isScheduling = "isScheduling";
            public string roomCode = "roomCode";
            public string roomName = "roomName";
        }
        
        [DataMember]
        public string EmpidStr { get; set; }
        [DataMember]
        public string DeptID { get; set; }
        [DataMember]
        public string DeptNo { get; set; }
        [DataMember]
        public string DeptName { get; set; }
        [DataMember]
        public string TechnicalLevelNo { get; set; }
        [DataMember]
        public string TechnicalLevelName { get; set; }
        [DataMember]
        public string AdminLevelNo { get; set; }
        [DataMember]
        public string AdminLevelName { get; set; }
        /// <summary>
        /// 处方权
        /// </summary>
        [DataMember]
        public List<string> Prescription { get; set; }
        /// <summary>
        /// 药品(用药)权
        /// </summary>
        [DataMember]
        public List<string> MedLimits { get; set; }
        [DataMember]
        public string ParentDeptID { get; set; }
        [DataMember]
        public int TreeType { get; set; }
        /// <summary>
        /// 所属角色ID列表
        /// </summary>
        [DataMember]
        public List<string> RoleID { get; set; }

        [DataMember]
        public string pyCode { get; set; }
        [DataMember]
        public string wbCode { get; set; }

        [DataMember]
        public string rankCode { get; set; }
        [DataMember]
        public string rankName { get; set; }
        [DataMember]
        public string introduce { get; set; }
        [DataMember]
        public string skill { get; set; }
        /// <summary>
        /// 是否已排班: 0 否 1 是
        /// </summary>
        [DataMember]
        public string isScheduling { get; set; }

        [DataMember]
        public string roomCode { get; set; }
        [DataMember]
        public string roomName { get; set; }
    }


    /// <summary>
    /// CODE_OPERATOR_CLASS
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_OPERATOR_CLASS")]
    public class EntityCodeOperatorClass : BaseDataContract
    {
        /// <summary>
        /// CLS_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLS_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String clsCode { get; set; }

        /// <summary>
        /// CLS_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLS_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String clsName { get; set; }

        /// <summary>
        /// INNER_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INNER_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String innerFlag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string clsCode = "clsCode";
            public string clsName = "clsName";
            public string innerFlag = "innerFlag";
        }
    }

    /// <summary>
    /// PLUS_OPERATOR
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "PLUS_OPERATOR")]
    public class EntityPlusOperator : BaseDataContract
    {
        /// <summary>
        /// OPER_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OPER_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String operCode { get; set; }

        /// <summary>
        /// PY_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PY_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// WB_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "WB_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// CLS_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLS_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String clsCode { get; set; }

        /// <summary>
        /// DUTY_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DUTY_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String dutyCode { get; set; }

        /// <summary>
        /// RANK_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RANK_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String rankCode { get; set; }

        /// <summary>
        /// DEPT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DEPT_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// BIRTH
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BIRTH", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String birth { get; set; }

        /// <summary>
        /// TEL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TEL", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String tel { get; set; }

        /// <summary>
        /// ADDR
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ADDR", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String addr { get; set; }

        /// <summary>
        /// EMAIL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "EMAIL", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String email { get; set; }

        /// <summary>
        /// PIC_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PIC_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String picName { get; set; }

        /// <summary>
        /// MA_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "MA_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String maFlag { get; set; }

        /// <summary>
        /// SEX
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SEX", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String sex { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string operCode = "operCode";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string clsCode = "clsCode";
            public string dutyCode = "dutyCode";
            public string rankCode = "rankCode";
            public string deptCode = "deptCode";
            public string birth = "birth";
            public string tel = "tel";
            public string addr = "addr";
            public string email = "email";
            public string picName = "picName";
            public string maFlag = "maFlag";
            public string sex = "sex";
        }
    }
    #endregion
}

