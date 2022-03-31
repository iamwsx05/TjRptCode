using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// code_addr
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "code_addr")]
    public class EntityCodeAddr : BaseDataContract
    {
        /// <summary>
        /// Addr_Code
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "addr_code", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String addrCode { get; set; }

        /// <summary>
        /// Addr_Name
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "addr_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String addrName { get; set; }

        /// <summary>
        /// Addr_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "addr_flag", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String addrFlag { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string addrCode = "addrCode";
            public string addrName = "addrName";
            public string addrFlag = "addrFlag";
        }
    }

}
