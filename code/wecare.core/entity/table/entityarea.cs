using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region 病区
    /// <summary>
    /// EntityIpArea
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicArea")]
    public class EntityArea : BaseDataContract
    {
        /// <summary>
        /// Areaid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 Areaid { get; set; }

        /// <summary>
        /// Areacode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areacode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Areacode { get; set; }

        /// <summary>
        /// Areaname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Areaname { get; set; }

        /// <summary>
        /// Bednums
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bednums", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 Bednums { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pycode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String Pycode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String Wbcode { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 Status { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Areaid = "Areaid";
            public string Areacode = "Areacode";
            public string Areaname = "Areaname";
            public string Bednums = "Bednums";
            public string Pycode = "Pycode";
            public string Wbcode = "Wbcode";
            public string Status = "Status";
        }
    }

    /// <summary>
    /// EntityDeptArea
    /// </summary>
    //[DataContract, Serializable]
    //[EntityAttribute(TableName = "defDeptarea")]
    //public class EntityDeptArea : BaseDataContract
    //{
    //    /// <summary>
    //    /// Deptid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "deptid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
    //    public System.Decimal Deptid { get; set; }

    //    /// <summary>
    //    /// Areaid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "areaid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
    //    public System.Decimal Areaid { get; set; }

    //    public static EnumCols Columns = new EnumCols();

    //    public class EnumCols
    //    {
    //        public string Deptid = "Deptid";
    //        public string Areaid = "Areaid";
    //        public string Deptcode = "Deptcode";
    //        public string Deptname = "Deptname";
    //        public string Areacode = "Areacode";
    //        public string Areaname = "Areaname";
    //    }

    //    [DataMember]
    //    public string Deptcode { get; set; }

    //    [DataMember]
    //    public string Deptname { get; set; }

    //    [DataMember]
    //    public string Areacode { get; set; }

    //    [DataMember]
    //    public string Areaname { get; set; }

    //}
    #endregion

    #region 病床.new
    /// <summary>
    /// EntityBedInfo
    /// </summary>
    //[DataContract, Serializable]
    //[EntityAttribute(TableName = "dicBedinfo")]
    //public class EntityBedInfo : BaseDataContract
    //{
    //    /// <summary>
    //    /// Bedid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "bedid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
    //    public System.Decimal Bedid { get; set; }

    //    /// <summary>
    //    /// Bedno
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "bedno", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
    //    public System.String Bedno { get; set; }

    //    /// <summary>
    //    /// Category
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "category", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
    //    public System.Decimal? Category { get; set; }

    //    /// <summary>
    //    /// Sex
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "sex", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
    //    public System.Decimal? Sex { get; set; }

    //    /// <summary>
    //    /// Status
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
    //    public System.Decimal? Status { get; set; }

    //    /// <summary>
    //    /// Sortno
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
    //    public System.Decimal? Sortno { get; set; }

    //    /// <summary>
    //    /// Areaid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "areaid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
    //    public System.Decimal? Areaid { get; set; }

    //    /// <summary>
    //    /// Registerid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "registerid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
    //    public System.Decimal? Registerid { get; set; }

    //    /// <summary>
    //    /// Roomid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "roomid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
    //    public System.Decimal? Roomid { get; set; }

    //    public static EnumCols Columns = new EnumCols();

    //    public class EnumCols
    //    {
    //        public string Bedid = "Bedid";
    //        public string Bedno = "Bedno";
    //        public string Category = "Category";
    //        public string Sex = "Sex";
    //        public string Status = "Status";
    //        public string Sortno = "Sortno";
    //        public string Areaid = "Areaid";
    //        public string Registerid = "Registerid";
    //        public string Roomid = "Roomid";
    //    }
    //}

    #endregion

    #region 病床.old

    /// <summary>
    /// IP_CODE_BED
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "IP_CODE_BED")]
    public class EntityIpCodeBed : BaseDataContract
    {
        /// <summary>
        /// DEPT_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DEPT_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String deptCode { get; set; }

        /// <summary>
        /// BED_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BED_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String bedCode { get; set; }

        /// <summary>
        /// BED_CLS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BED_CLS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String bedCls { get; set; }

        /// <summary>
        /// TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TYPE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String type { get; set; }

        /// <summary>
        /// STATUS
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "STATUS", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String status { get; set; }

        /// <summary>
        /// BORR_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "BORR_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String borrFlag { get; set; }

        /// <summary>
        /// USE_DEPT
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "USE_DEPT", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String useDept { get; set; }

        /// <summary>
        /// REG_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REG_NO", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String regNo { get; set; }

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
            public string bedCode = "bedCode";
            public string bedCls = "bedCls";
            public string type = "type";
            public string status = "status";
            public string borrFlag = "borrFlag";
            public string useDept = "useDept";
            public string regNo = "regNo";
        }
    }

    /// <summary>
    /// IP_CODE_BEDCLS
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "IP_CODE_BEDCLS")]
    public class EntityIpCodeBedcls : BaseDataContract
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
        }
    }
    #endregion
}
