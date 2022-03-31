using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrCaseCatalog
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrCatalog")]
    public class EntityEmrCatalog : BaseDataContract
    {
        /// <summary>
        /// Catalogid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "catalogid", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 catalogId { get; set; }

        /// <summary>
        /// Catalogname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "catalogname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String catalogName { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "type", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Int32 type { get; set; }

        /// <summary>
        /// Sortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 sortNo { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// Outsortno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "outsortno", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 outSortNo { get; set; }

        /// <summary>
        /// Casescope
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casescope", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Int32 caseScope { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string catalogId = "catalogId";
            public string catalogName = "catalogName";
            public string type = "type";
            public string sortNo = "sortNo";
            public string status = "status";
            public string outSortNo = "outSortNo";
            public string caseScope = "caseScope";
        }
    }

}
