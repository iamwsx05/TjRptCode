using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region 科室.new
    /// <summary>
    /// dicDepartment
    /// </summary>
    //[DataContract, Serializable]
    //[EntityAttribute(TableName = "dicDepartment")]
    //public class EntityDepartment : BaseDataContract
    //{
    //    /// <summary>
    //    /// Deptid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
    //    public System.Decimal Deptid { get; set; }

    //    /// <summary>
    //    /// Deptcode
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "deptcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
    //    public System.String Deptcode { get; set; }

    //    /// <summary>
    //    /// Deptname
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "deptname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
    //    public System.String Deptname { get; set; }

    //    /// <summary>
    //    /// Pycode
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
    //    public System.String Pycode { get; set; }

    //    /// <summary>
    //    /// Wbcode
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
    //    public System.String Wbcode { get; set; }

    //    /// <summary>
    //    /// Level
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "level", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
    //    public System.Decimal? Level { get; set; }

    //    /// <summary>
    //    /// Parentid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "parentid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
    //    public System.Decimal Parentid { get; set; }

    //    /// <summary>
    //    /// Leafflag
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "leafflag", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
    //    public System.Decimal? Leafflag { get; set; }

    //    /// <summary>
    //    /// Sortno
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
    //    public System.Decimal? Sortno { get; set; }

    //    /// <summary>
    //    /// Opaddr
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "opaddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
    //    public System.String Opaddr { get; set; }

    //    /// <summary>
    //    /// Ipaddr
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "ipaddr", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
    //    public System.String Ipaddr { get; set; }

    //    /// <summary>
    //    /// Status
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
    //    public System.Decimal? Status { get; set; }

    //    public static EnumCols Columns = new EnumCols();

    //    public class EnumCols
    //    {
    //        public string Deptid = "Deptid";
    //        public string Deptcode = "Deptcode";
    //        public string Deptname = "Deptname";
    //        public string Pycode = "Pycode";
    //        public string Wbcode = "Wbcode";
    //        public string Level = "Level";
    //        public string Parentid = "Parentid";
    //        public string Leafflag = "Leafflag";
    //        public string Sortno = "Sortno";
    //        public string Opaddr = "Opaddr";
    //        public string Ipaddr = "Ipaddr";
    //        public string Status = "Status";
    //    }
    //}

    /// <summary>
    /// dicDeptattribute
    /// </summary>
    //[DataContract, Serializable]
    //[EntityAttribute(TableName = "dicDeptattribute")]
    //public class EntityDeptattribute : BaseDataContract
    //{
    //    /// <summary>
    //    /// Deptid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
    //    public System.Decimal Deptid { get; set; }

    //    /// <summary>
    //    /// Attrid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "attrid", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
    //    public System.String Attrid { get; set; }

    //    public static EnumCols Columns = new EnumCols();

    //    public class EnumCols
    //    {
    //        public string Deptid = "Deptid";
    //        public string Attrid = "Attrid";
    //    }
    //}
    #endregion

    #region 科室.old

    /// <summary>
    /// CODE_DEPARTMENT
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_DEPARTMENT")]
    public class EntityCodeDepartment : BaseDataContract, IComparable
    {
        /// <summary>
        /// DEPT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DEPT_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// DEPT_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DEPT_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String deptName { get; set; }

        /// <summary>
        /// PARENT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PARENT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String parent { get; set; }

        /// <summary>
        /// GRADE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "GRADE", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 grade { get; set; }

        /// <summary>
        /// LEAF_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "LEAF_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String leafFlag { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String type { get; set; }

        /// <summary>
        /// NH_DEPT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NH_DEPT_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String nhDeptCode { get; set; }

        /// <summary>
        /// PY_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PY_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// WB_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "WB_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Xh
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "xh", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 xh { get; set; }

        /// <summary>
        /// isBk
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isBk", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 isBk { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string deptCode = "deptCode";
            public string deptName = "deptName";
            public string parent = "parent";
            public string grade = "grade";
            public string leafFlag = "leafFlag";
            public string type = "type";
            public string nhDeptCode = "nhDeptCode";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string xh = "xh";
            public string imageIndex = "imageIndex";
            public string isBk = "isBk";
            public string deptId = "deptId";
        }
        /// <summary>
        /// 图片索引
        /// </summary>
        [DataMember]
        public int imageIndex { get; set; }

        /// <summary>
        /// deptId
        /// </summary>
        [DataMember]
        public string deptId { get; set; }

        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityCodeDepartment)
            {
                return this.deptName.CompareTo(((EntityCodeDepartment)obj).deptName);
            }
            return 0;
        }
    }
    #endregion

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
