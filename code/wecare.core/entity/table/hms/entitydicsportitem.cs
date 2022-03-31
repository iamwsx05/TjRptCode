using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityDicSportItem
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicSportItem")]
    public class EntityDicSportItem : BaseDataContract
    {
        /// <summary>
        /// sId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal sId { get; set; }

        /// <summary>
        /// sportNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sportNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String sportNo { get; set; }

        /// <summary>
        /// sportName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sportName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String sportName { get; set; }

        /// <summary>
        /// sportType
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sportType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String sportType { get; set; }

        /// <summary>
        /// sportTime
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sportTime", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal? sportTime { get; set; }

        /// <summary>
        /// metValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "metValue", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal? metValue { get; set; }

        /// <summary>
        /// sportNum
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sportNum", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal? sportNum { get; set; }

        /// <summary>
        /// minAge
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "minAge", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal? minAge { get; set; }

        /// <summary>
        /// maxAge
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "maxAge", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal? maxAge { get; set; }

        /// <summary>
        /// sex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sex", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String sex { get; set; }

        /// <summary>
        /// decription
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "decription", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String decription { get; set; }

        /// <summary>
        /// effect
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "effect", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String effect { get; set; }

        /// <summary>
        /// announcements
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "announcements", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String announcements { get; set; }

        /// <summary>
        /// recommend
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recommend", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String recommend { get; set; }

        /// <summary>
        /// dataSource
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "dataSource", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 15)]
        public System.String dataSource { get; set; }

        /// <summary>
        /// imageData
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "imageData", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String imageData { get; set; }

        /// <summary>
        /// isEnabled
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isEnabled", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.Decimal isEnabled { get; set; }

        /// <summary>
        /// creatorId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatorId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 18)]
        public System.String creatorId { get; set; }

        /// <summary>
        /// creatDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 19)]
        public System.DateTime creatDate { get; set; }

        /// <summary>
        /// organId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "organId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String organId { get; set; }

        [DataMember]
        public string sportTypeName
        {
            get
            {
                if (sportType == "1")
                    return "有氧运动";
                else if (sportType == "2")
                    return "力量运动";
                else if (sportType == "3")
                    return "柔韧性锻炼";
                else
                    return "其他";
            }
            set {; }
        }

        [DataMember]
        public string sportNumName
        {
            get
            {
                if (sportNum == 1)
                    return "日常活动";
                else if (sportNum == 2)
                    return "健身类";
                else if (sportNum == 3)
                    return "耐力类";
                else if (sportNum == 4)
                    return "休闲球类";
                else if (sportNum == 5)
                    return "大球类";
                else if (sportNum == 6)
                    return "小球类";
                else if (sportNum == 7)
                    return "跳绳类";
                else if (sportNum == 8)
                    return "舞蹈类";
                else if (sportNum == 9)
                    return "游泳类";
                else if (sportNum == 10)
                    return "休闲娱乐";
                else if (sportNum == 11)
                    return "户外运动";
                else
                    return "其他";
            }
            set {; }
        }

        [DataMember]
        public string sportTimeName
        {
            get
            {
                if (sportTime == 1)
                    return "低强度";
                else if (sportTime == 2)
                    return "中等强度";
                else if (sportTime == 3)
                    return "高强度";
                else
                    return "其他";
            }
            set {; }
        }


        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string sId = "sId";
            public string sportNo = "sportNo";
            public string sportName = "sportName";
            public string sportType = "sportType";
            public string sportTime = "sportTime";
            public string metValue = "metValue";
            public string sportNum = "sportNum";
            public string minAge = "minAge";
            public string maxAge = "maxAge";
            public string sex = "sex";
            public string decription = "decription";
            public string effect = "effect";
            public string announcements = "announcements";
            public string recommend = "recommend";
            public string dataSource = "dataSource";
            public string imageData = "imageData";
            public string isEnabled = "isEnabled";
            public string creatorId = "creatorId";
            public string creatDate = "creatDate";
            public string organId = "organId";

            public string sportTypeName = "sportTypeName";
        }
    }
}
