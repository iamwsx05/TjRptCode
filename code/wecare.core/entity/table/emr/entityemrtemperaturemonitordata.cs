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
    /// emrTemperatureMonitorData
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrTemperatureMonitorData")]
    public class EntityEmrTemperatureMonitorData : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serNo", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Ipstatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ipStatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal? ipStatus { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recordDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime recordDate { get; set; }

        /// <summary>
        /// Measuretype
        /// 1口表 2腋表 3肛表 4降温 5脉搏 6心率 7呼吸 8血压 9总入液量   
        /// 10排出量-大便 11排出量-尿量 12排出量-其他1 
        /// 13体重 14皮试 15其他
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "measureType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal measureType { get; set; }

        /// <summary>
        /// Measurevalue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "measureValue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String measureValue { get; set; }

        /// <summary>
        /// Lastmodifytime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lastModifyTime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime? lastModifyTime { get; set; }

        /// <summary>
        /// Lastmodifier
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lastModifier", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String lastModifier { get; set; }

        /// <summary>
        /// Isdeleted
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isDeleted", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? isDeleted { get; set; }

        /// <summary>
        /// Measurevalue2
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "measureValue2", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String measureValue2 { get; set; }

        /// <summary>
        /// Valuedate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "valueDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.DateTime? valueDate { get; set; }

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
            public string registerId = "registerId";
            public string ipStatus = "ipStatus";
            public string recordDate = "recordDate";
            public string measureType = "measureType";
            public string measureValue = "measureValue";
            public string lastModifyTime = "lastModifyTime";
            public string lastModifier = "lastModifier";
            public string isDeleted = "isDeleted";
            public string measureValue2 = "measureValue2";
            public string valueDate = "valueDate";
        }

        public eumnThreeItemsTimePeriod timePeriod { get; set; }
        public DateTime drawingPointDate;
    }

}
