using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityDicMessageContent
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicMessageContent")]
    public class EntityDicMessageContent : BaseDataContract
    {
        /// <summary>
        /// sId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal sId { get; set; }

        /// <summary>
        /// typeId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "typeId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String typeId { get; set; }

        /// <summary>
        /// smsContent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "smsContent", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String smsContent { get; set; }

        /// <summary>
        /// suitGender
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "suitGender", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String suitGender { get; set; }

        /// <summary>
        /// suitPersons
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "suitPersons", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String suitPersons { get; set; }

        /// <summary>
        /// suitSeason
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "suitSeason", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String suitSeason { get; set; }

        /// <summary>
        /// creatorId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatorId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String creatorId { get; set; }

        /// <summary>
        /// creatDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime creatDate { get; set; }

        /// <summary>
        /// organId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "organId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String organId { get; set; }


        [DataMember]
        public string suitGenderDesc
        {
            get
            {
                if (suitGender == "1") return "男";
                else if (suitGender == "2") return "女";
                else return "不限";
            }
            set {; }
        }

        [DataMember]
        public string suitPersonsDesc
        {
            get
            {
                if (suitPersons == "1") return "成人";
                else if (suitPersons == "2") return "老人";
                else if (suitPersons == "3") return "少儿";
                else return "不限";
            }
            set {; }
        }

        [DataMember]
        public string suitSeasonDesc
        {
            get
            {
                if (suitSeason == "1") return "春";
                else if (suitSeason == "2") return "夏";
                else if (suitSeason == "3") return "秋";
                else if (suitSeason == "4") return "冬";
                else return "不限";
            }
            set {; }
        }

        [DataMember]
        public string typeName { get; set; }

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
            public string typeId = "typeId";
            public string smsContent = "smsContent";
            public string suitGender = "suitGender";
            public string suitPersons = "suitPersons";
            public string suitSeason = "suitSeason";
            public string creatorId = "creatorId";
            public string creatDate = "creatDate";
            public string organId = "organId";
            public string suitGenderDesc = "suitGenderDesc";
            public string suitPersonsDesc = "suitPersonsDesc";
            public string suitSeasonDesc = "suitSeasonDesc";
        }
    }
}
