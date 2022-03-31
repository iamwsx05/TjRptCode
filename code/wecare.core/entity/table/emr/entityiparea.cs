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
    /// ipArea
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "ipArea")]
    public class EntityIpArea : BaseDataContract
    {
        /// <summary>
        /// Areaid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String areaId { get; set; }

        /// <summary>
        /// Areacode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String areaCode { get; set; }

        /// <summary>
        /// Areaname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String areaName { get; set; }

        /// <summary>
        /// Bednums
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bedNums", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal bedNums { get; set; }

        /// <summary>
        /// Pycode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pyCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// Wbcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
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
            public string areaId = "areaId";
            public string areaCode = "areaCode";
            public string areaName = "areaName";
            public string bedNums = "bedNums";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string status = "status";
        }
    }

}
