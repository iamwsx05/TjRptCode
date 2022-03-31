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
    /// code_reg
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "code_reg")]
    public class EntityCodeReg : BaseDataContract
    {
        /// <summary>
        /// Reg_Code
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reg_code", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String regCode { get; set; }

        /// <summary>
        /// Reg_Name
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reg_name", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String regName { get; set; }

        /// <summary>
        /// Reg_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reg_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String regFlag { get; set; }

        /// <summary>
        /// Book_Flag
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "book_flag", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String bookFlag { get; set; }

        /// <summary>
        /// Reg_Fee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reg_fee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal regFee { get; set; }

        /// <summary>
        /// Doct_Fee
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doct_fee", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal doctFee { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// 分类代码:  01 普通； 02 急诊
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String typeCode { get; set; }

        /// <summary>
        /// 挂号费编码
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regItemCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String regItemCode { get; set; }

        /// <summary>
        /// 诊金费编码
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "doctItemCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String doctItemCode { get; set; }

        [DataMember]
        public string regFlagName { get; set; }

        [DataMember]
        public string bookFlagName { get; set; }

        [DataMember]
        public string statusName { get; set; }

        [DataMember]
        public string typeName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string regCode = "regCode";
            public string regName = "regName";
            public string regFlag = "regFlag";
            public string bookFlag = "bookFlag";
            public string regFee = "regFee";
            public string doctFee = "doctFee";
            public string status = "status";
            public string statusName = "statusName";
            public string bookFlagName = "bookFlagName";
            public string regFlagName = "regFlagName";
            public string typeCode = "typeCode";
            public string typeName = "typeName";
            public string regItemCode = "regItemCode";
            public string doctItemCode = "doctItemCode";
        }
    }

}
