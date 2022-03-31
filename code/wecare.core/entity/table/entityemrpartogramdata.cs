using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// emrPartogramData
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrPartogramData")]
    public class EntityEmrPartogramData : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Mserno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "mSerNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal mSerNo { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// Measuretype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "measureType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal measureType { get; set; }

        /// <summary>
        /// Eventtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "eventType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? eventType { get; set; }

        /// <summary>
        /// Measurevalue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "measureValue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String measureValue { get; set; }

        /// <summary>
        /// Measurevalue2
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "measureValue2", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String measureValue2 { get; set; }

        /// <summary>
        /// Isdeleted
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isDeleted", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? isDeleted { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string serNo = "serNo";
            public string mSerNo = "mSerNo";
            public string recordDate = "recordDate";
            public string measureType = "measureType";
            public string eventType = "eventType";
            public string measureValue = "measureValue";
            public string measureValue2 = "measureValue2";
            public string isDeleted = "isDeleted";
        }
    }

}
