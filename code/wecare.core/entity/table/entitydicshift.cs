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
    /// dicShift
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicShift")]
    public class EntityDicShift : BaseDataContract
    {
        /// <summary>
        /// Shiftcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "shiftCode", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 shiftCode { get; set; }

        /// <summary>
        /// Shiftname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "shiftName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String shiftName { get; set; }

        /// <summary>
        /// Starttime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "startTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String startTime { get; set; }

        /// <summary>
        /// Endtime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "endTime", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String endTime { get; set; }

        /// <summary>
        /// Hisid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hisId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String hisId { get; set; }

        /// <summary>
        /// isBk
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isBk", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 isBk { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string shiftCode = "shiftCode";
            public string shiftName = "shiftName";
            public string startTime = "startTime";
            public string endTime = "endTime";
            public string hisId = "hisId";
            public string isBk = "isBk";
        }
    }
}
