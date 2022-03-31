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
    /// ipBeds
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "ipBeds")]
    public class EntityIpBeds : BaseDataContract
    {
        /// <summary>
        /// Bedid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bedId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String bedId { get; set; }

        /// <summary>
        /// Bedno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bedNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String bedNo { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "category", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal category { get; set; }

        /// <summary>
        /// Sex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sex", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal sex { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal status { get; set; }

        /// <summary>
        /// Areaid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "areaId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String areaId { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Roomno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "roomNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String roomNo { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal sortNo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string bedId = "bedId";
            public string bedNo = "bedNo";
            public string category = "category";
            public string sex = "sex";
            public string status = "status";
            public string areaId = "areaId";
            public string registerId = "registerId";
            public string roomNo = "roomNo";
            public string sortNo = "sortNo";
        }
    }

}
