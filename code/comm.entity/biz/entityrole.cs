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
    #region 角色

    /// <summary>
    /// EntityRole
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "sysRole")]
    public class EntityRole : BaseDataContract
    {
        /// <summary>
        /// Roleid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roleid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Roleid { get; set; }

        /// <summary>
        /// Rolename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "rolename", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String Rolename { get; set; }

        /// <summary>
        /// Roledesc
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roledesc", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String Roledesc { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Roleid = "Roleid";
            public string Rolename = "Rolename";
            public string Roledesc = "Roledesc";
        }
    }

    /// <summary>
    /// EntityRoleEmployee
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "defRoleemployee")]
    public class EntityRoleEmployee : BaseDataContract
    {
        /// <summary>
        /// Roleid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roleid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Roleid { get; set; }

        /// <summary>
        /// Empid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "empid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Empid { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Roleid = "Roleid";
            public string Empid = "Empid";
        }
    }

    /// <summary>
    /// EntityRoleFunction
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "defRolefunction")]
    public class EntityRoleFunction : BaseDataContract
    {
        /// <summary>
        /// Roleid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roleid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal Roleid { get; set; }

        /// <summary>
        /// Funcid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "funcid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.Decimal Funcid { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string Roleid = "Roleid";
            public string Funcid = "Funcid";
        }
    }

    #endregion
}
