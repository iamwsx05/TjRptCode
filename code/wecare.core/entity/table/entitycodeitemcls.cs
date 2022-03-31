using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_ITEMCLS
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_ITEMCLS")]
    public class EntityCodeItemcls : BaseDataContract
    {
        /// <summary>
        /// SCOPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "SCOPE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String scope { get; set; }

        /// <summary>
        /// CLS_TYPE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLS_TYPE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String clsType { get; set; }

        /// <summary>
        /// CLS_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLS_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String clsCode { get; set; }

        /// <summary>
        /// CLS_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CLS_NAME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String clsName { get; set; }

        /// <summary>
        /// ADD_FLAG
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ADD_FLAG", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String addFlag { get; set; }

        /// <summary>
        /// GROUP_ID
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "GROUP_ID", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 groupId { get; set; }

        /// <summary>
        /// Print_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "print_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String printFlag { get; set; }

        /// <summary>
        /// Locid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "locId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String locid { get; set; }

        /// <summary>
        /// Locname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "locName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String locname { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string scope = "scope";
            public string clsType = "clsType";
            public string clsCode = "clsCode";
            public string clsName = "clsName";
            public string addFlag = "addFlag";
            public string groupId = "groupId";
            public string printFlag = "printFlag";
            public string locid = "locid";
            public string locname = "locname";
        }
    }

}
