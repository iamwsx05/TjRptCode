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
    /// <summary>
    /// dicDepartment
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicDepartment")]
    public class EntityDepartment : BaseDataContract
    {
        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Deptid { get; set; }

        /// <summary>
        /// Deptcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Deptcode { get; set; }

        /// <summary>
        /// Deptname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Deptname { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Level
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "level", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal? Level { get; set; }

        /// <summary>
        /// Parentid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal Parentid { get; set; }

        /// <summary>
        /// Leafflag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "leafflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? Leafflag { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? Sortno { get; set; }

        /// <summary>
        /// Opaddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "opaddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String Opaddr { get; set; }

        /// <summary>
        /// Ipaddr
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ipaddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String Ipaddr { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal? Status { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Deptid = "Deptid";
            public string Deptcode = "Deptcode";
            public string Deptname = "Deptname";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Level = "Level";
            public string Parentid = "Parentid";
            public string Leafflag = "Leafflag";
            public string Sortno = "Sortno";
            public string Opaddr = "Opaddr";
            public string Ipaddr = "Ipaddr";
            public string Status = "Status";
        }
    }

    /// <summary>
    /// dicDeptattribute
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicDeptattribute")]
    public class EntityDeptattribute : BaseDataContract
    {
        /// <summary>
        /// Deptid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Deptid { get; set; }

        /// <summary>
        /// Attrid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "attrid", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String Attrid { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Deptid = "Deptid";
            public string Attrid = "Attrid";
        }
    }

    /// <summary>
    /// 科室
    /// </summary>
    [DataContract, Serializable]
    public class EntityDeptInfo : BaseDataContract
    {
        /// <summary>
        /// 科室ID
        /// </summary>
        [DataMember]
        public int DeptID { get; set; }
        /// <summary>
        /// 科室代码
        /// </summary>
        [DataMember]
        public string DeptCode { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        [DataMember]
        public string DeptName { get; set; }
        /// <summary>
        /// 拼音简码
        /// </summary>
        [DataMember]
        public string PyCode { get; set; }
        /// <summary>
        /// 五笔简码
        /// </summary>
        [DataMember]
        public string WbCode { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string DeptID = "DeptID";
            public string DeptCode = "DeptCode";
            public string DeptName = "DeptName";
            public string PyCode = "PyCode";
            public string WbCode = "WbCode";
        }
    }
}
