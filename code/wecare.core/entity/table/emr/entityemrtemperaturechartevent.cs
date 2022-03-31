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
    /// emrTemperatureChartEvent
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrTemperatureChartEvent")]
    public class EntityEmrTemperatureChartEvent : BaseDataContract
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
        /// Eventname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "eventName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String eventName { get; set; }

        /// <summary>
        /// Eventtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "eventType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal eventType { get; set; }

        /// <summary>
        /// Eventvalue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "eventValue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String eventValue { get; set; }

        /// <summary>
        /// Lastmodifytime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lastModifyTime", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime lastModifyTime { get; set; }

        /// <summary>
        /// Lastmodifier
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lastModifier", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String lastModifier { get; set; }

        /// <summary>
        /// Isdeleted
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isDeleted", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal isDeleted { get; set; }

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
            public string eventName = "eventName";
            public string eventType = "eventType";
            public string eventValue = "eventValue";
            public string lastModifyTime = "lastModifyTime";
            public string lastModifier = "lastModifier";
            public string isDeleted = "isDeleted";
        }

        public eumnThreeItemsTimePeriod timePeriod { get; set; }
        public DateTime drawingPointDate;

        public EntityDicEventType EventType { get; set; }

        /// <summary>
        /// 特殊值:某些非事件的数据点的绘画形式跟事件相似则归为特殊事件,如:"辅助呼吸","停辅助呼吸"
        /// </summary>
        public EntityEmrTemperatureMonitorData SpecialValue { get; set; }

        /// <summary>
        /// 0=描绘于42度下 1=描绘于35度下
        /// </summary>
        public decimal drawingPotision { get; set; }

        /// <summary>
        /// 是否中断连线
        /// </summary>
        public decimal isBreakingPoint { get; set; }

        /// <summary>
        /// 是否描绘时间
        /// </summary>
        public decimal isDrawTime { get; set; }

        /// <summary>
        /// 是否为手术
        /// </summary>
        public decimal isOperation { get; set; }

        public EntityEmrTemperatureChartEvent()
        {
            EventType = null;
            SpecialValue = null;
        }

    }

    public class EntityEmrTemperaturePatInfo
    {
        public EntityEmrTemperaturePatInfo(string regId, string name, string age, string sex, DateTime inDate, string area, string bedNo, string ipNo)
        {
            RegID = regId;
            Name = name;
            Age = age;
            Sex = sex;
            InDate = inDate;
            Area = area;
            BedNo = bedNo;
            IpNo = ipNo;
        }

        public string RegID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }

        /// <summary>
        /// 入院时间
        /// </summary>
        public DateTime InDate { get; set; }
        public string Area { get; set; }
        public string BedNo { get; set; }
        public string IpNo { get; set; }

        public override string ToString()
        {
            return string.Format("姓名：{0} 年龄：{1} 性别：{2} 入院日期：{3} 病区：{4} 床号：{5} 住院号：{6}",
                Name,
                Age,
                Sex,
                InDate.ToString("yyyy年MM月dd日"),
                Area,
                BedNo,
                IpNo);
        }
    }
}
