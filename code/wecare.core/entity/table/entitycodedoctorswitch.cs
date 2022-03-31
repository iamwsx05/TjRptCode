using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// CODE_DOCTORSWITCH
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "CODE_DOCTORSWITCH")]
    public class EntityCodeDoctorswitch : BaseDataContract
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
        }
    }

}
