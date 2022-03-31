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
    /// dicUsage
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicUsage")]
    public class EntityDicUsage : BaseDataContract
    {
        /// <summary>
        /// Usageid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String usageId { get; set; }

        /// <summary>
        /// Usagecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String usageCode { get; set; }

        /// <summary>
        /// Usagename
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usageName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String usageName { get; set; }

        /// <summary>
        /// Usageprtname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "usagePrtName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String usagePrtName { get; set; }

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
        /// Isst
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isSt", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal isSt { get; set; }

        /// <summary>
        /// Typeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal typeId { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal sortNo { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
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
            public string usageId = "usageId";
            public string usageCode = "usageCode";
            public string usageName = "usageName";
            public string usagePrtName = "usagePrtName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
            public string isSt = "isSt";
            public string typeId = "typeId";
            public string sortNo = "sortNo";
            public string status = "status";
        }
    }

}
