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
    /// EntityOpServiceLock
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opServiceLock")]
    public class EntityOpServiceLock : BaseDataContract
    {
        /// <summary>
        /// Biztype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bizType", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal bizType { get; set; }

        /// <summary>
        /// Cardno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cardNo", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String cardNo { get; set; }

        /// <summary>
        /// Lockstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockStatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal lockStatus { get; set; }

        /// <summary>
        /// Locktime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockTime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime lockTime { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string bizType = "bizType";
            public string cardNo = "cardNo";
            public string lockStatus = "lockStatus";
            public string lockTime = "lockTime";
        }
    }

}
