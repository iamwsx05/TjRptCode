using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region 角色.new

    /// <summary>
    /// EntityRole
    /// </summary>
    //[DataContract, Serializable]
    //[EntityAttribute(TableName = "sysRole")]
    //public class EntityRole : BaseDataContract
    //{
    //    /// <summary>
    //    /// Roleid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "roleid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
    //    public System.Decimal Roleid { get; set; }

    //    /// <summary>
    //    /// Rolename
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "rolename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
    //    public System.String Rolename { get; set; }

    //    /// <summary>
    //    /// Roledesc
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "roledesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
    //    public System.String Roledesc { get; set; }

    //    public static EnumCols Columns = new EnumCols();

    //    public class EnumCols
    //    {
    //        public string Roleid = "Roleid";
    //        public string Rolename = "Rolename";
    //        public string Roledesc = "Roledesc";
    //    }
    //}

    /// <summary>
    /// EntityRoleEmployee
    /// </summary>
    //[DataContract, Serializable]
    //[EntityAttribute(TableName = "defRoleemployee")]
    //public class EntityRoleEmployee : BaseDataContract
    //{
    //    /// <summary>
    //    /// Roleid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "roleid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
    //    public System.Decimal Roleid { get; set; }

    //    /// <summary>
    //    /// Empid
    //    /// </summary>
    //    [DataMember]
    //    [EntityAttribute(FieldName = "empid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
    //    public System.Decimal Empid { get; set; }

    //    public static EnumCols Columns = new EnumCols();

    //    public class EnumCols
    //    {
    //        public string Roleid = "Roleid";
    //        public string Empid = "Empid";
    //    }
    //}

    /// <summary>
    /// EntityRoleFunction
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "defRolefunction")]
    public class EntityRoleFunction : BaseDataContract
    {
        ///// <summary>
        ///// Roleid
        ///// </summary>
        //[DataMember]
        //[EntityAttribute(FieldName = "roleid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        //public System.Decimal Roleid { get; set; }

        [DataMember]
        [EntityAttribute(FieldName = "rolecode", DbType = DbType.String, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String Rolecode { get; set; }

        /// <summary>
        /// Funcid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "funcid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Funcid { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            //public string Roleid = "Roleid";
            public string Funcid = "Funcid";
            public string Rolecode = "Rolecode";
        }
    }

    #endregion

    #region 角色.old

    /// <summary>
    /// CODE_ROLE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_ROLE")]
    public class EntityCodeRole : BaseDataContract
    {
        /// <summary>
        /// ROLE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROLE_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String roleCode { get; set; }

        /// <summary>
        /// ROLE_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROLE_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String roleName { get; set; }

        /// <summary>
        /// NOTE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "NOTE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String note { get; set; }

        /// <summary>
        /// INNER_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "INNER_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String innerFlag { get; set; }

        [DataMember]
        public int isEdit { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string roleCode = "roleCode";
            public string roleName = "roleName";
            public string note = "note";
            public string innerFlag = "innerFlag";
            public string isEdit = "isEdit";
        }
    }

    /// <summary>
    /// DEF_OPERATOR_ROLE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "DEF_OPERATOR_ROLE")]
    public class EntityDefOperatorRole : BaseDataContract
    {
        /// <summary>
        /// OPER_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "OPER_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String operCode { get; set; }

        /// <summary>
        /// ROLE_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ROLE_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String roleCode { get; set; }

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
            public string roleCode = "roleCode";
            public string operName = "operName";
            public string roleName = "roleName";
        }

        [DataMember]
        public string operName { get; set; }

        [DataMember]
        public string roleName { get; set; }
    }

    #endregion
}
