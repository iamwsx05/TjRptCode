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
    /// emrAcceptanceCheck
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrAcceptanceCheck")]
    public class EntityEmrAcceptanceCheck : BaseDataContract
    {
        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Checkerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "checkerId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String checkerId { get; set; }

        /// <summary>
        /// Checkdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "checkDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.DateTime checkDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal status { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string registerId = "registerId";
            public string checkerId = "checkerId";
            public string checkDate = "checkDate";
            public string status = "status";
        }
    }

}
