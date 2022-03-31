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
    /// opRecLock
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRecLock")]
    public class EntityOpRecLock : BaseDataContract
    {
        /// <summary>
        /// Recipeno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recipeNo", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String recipeNo { get; set; }

        /// <summary>
        /// Lockstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockStatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal lockStatus { get; set; }

        /// <summary>
        /// Locktime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lockTime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 3)]
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
            public string recipeNo = "recipeNo";
            public string lockStatus = "lockStatus";
            public string lockTime = "lockTime";
        }
    }

}
