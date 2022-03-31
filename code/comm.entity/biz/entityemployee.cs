using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using iCare.Core.Entity;

namespace Common.Entity
{
    #region 职工

    /// <summary>
    /// dicEmployee
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicEmployee")]
    public class EntityEmployee : BaseDataContract
    {
        /// <summary>
        /// Empid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "empid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Empid { get; set; }

        /// <summary>
        /// Empno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "empno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Empno { get; set; }

        /// <summary>
        /// Empname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "empname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Empname { get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sex", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Sex { get; set; }

        /// <summary>
        /// Birthday
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "birthday", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Birthday { get; set; }

        /// <summary>
        /// Idcard
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "idcard", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Idcard { get; set; }

        /// <summary>
        /// Tel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String Tel { get; set; }

        /// <summary>
        /// Addr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "addr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String Addr { get; set; }

        /// <summary>
        /// Identity
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "idtype", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String Identity { get; set; }

        /// <summary>
        /// Technicallevel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "technicallevel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Technicallevel { get; set; }

        /// <summary>
        /// Adminlevel
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "adminlevel", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Adminlevel { get; set; }

        /// <summary>
        /// Signimage_Img
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "signimage", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Byte[] Signimage_Img { get; set; }

        /// <summary>
        /// Signdigital
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "signdigital", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String Signdigital { get; set; }

        /// <summary>
        /// Resume
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "resume", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String Resume { get; set; }

        /// <summary>
        /// Pwd
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pwd", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String Pwd { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Acctstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "acctstatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.Decimal? Acctstatus { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.Decimal? Status { get; set; }

        /// <summary>
        /// Pwdusedate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pwdusedate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.DateTime? Pwdusedate { get; set; }

        /// <summary>
        /// Acctlockdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "acctlockdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 21)]
        public System.DateTime? Acctlockdate { get; set; }

        /// <summary>
        /// Teacherid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "teacherid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 22)]
        public System.Decimal? Teacherid { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Empid = "Empid";
            public string Empno = "Empno";
            public string Empname = "Empname";
            public string Sex = "Sex";
            public string Birthday = "Birthday";
            public string Idcard = "Idcard";
            public string Tel = "Tel";
            public string Addr = "Addr";
            public string Identity = "Identity";
            public string Technicallevel = "Technicallevel";
            public string Adminlevel = "Adminlevel";
            public string Signimage_Img = "Signimage_Img";
            public string Signdigital = "Signdigital";
            public string Resume = "Resume";
            public string Pwd = "Pwd";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Acctstatus = "Acctstatus";
            public string Status = "Status";
            public string Pwdusedate = "Pwdusedate";
            public string Acctlockdate = "Acctlockdate";
            public string Teacherid = "Teacherid";

            public string DeptID = "DeptID";
            public string DeptNo = "DeptNo";
            public string DeptName = "DeptName";
            public string TechnicalLevelNo = "TechnicalLevelNo";
            public string TechnicalLevelName = "TechnicalLevelName";
            public string AdminLevelNo = "AdminLevelNo";
            public string AdminLevelName = "AdminLevelName";
            public string Prescription = "Prescription";
            public string MedLimits = "MedLimits";
            public string ParentDeptID = "ParentDeptID";
            public string TreeType = "TreeType";
            public string RoleID = "RoleID";

            public string EmpidStr = "EmpidStr";
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
    }

    /// <summary>
    /// EntityDeptEmployee
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "defDeptemployee")]
    public class EntityDeptEmployee : BaseDataContract
    {
        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Deptid { get; set; }

        /// <summary>
        /// Empid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "empid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Empid { get; set; }

        /// <summary>
        /// Attrflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "attrflag", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.Decimal Attrflag { get; set; }

        /// <summary>
        /// Defaultflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "defaultflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal? Defaultflag { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Deptid = "Deptid";
            public string Empid = "Empid";
            public string Attrflag = "Attrflag";
            public string Defaultflag = "Defaultflag";

            public string EmpName = "EmpName";
            public string EmpSex = "EmpSex";
            public string DeptName = "DeptName";
        }


        /// <summary>
        /// EmpName
        /// </summary>
        [DataMember]
        public System.String EmpName { get; set; }

        [DataMember]
        public string EmpSex { get; set; }

        [DataMember]
        public string DeptName { get; set; }
    }

    /// <summary>
    /// t_def_prescriberightemp
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "defPrescriberightemp")]
    public class EntityPrescribeRightEmp : BaseDataContract
    {
        /// <summary>
        /// Prescriberightid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "prescriberightid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Prescriberightid { get; set; }

        /// <summary>
        /// Empid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "empid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Empid { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal? Status { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Prescriberightid = "Prescriberightid";
            public string Empid = "Empid";
            public string Status = "Status";
        }
    }

    #endregion
}
