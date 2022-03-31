using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityDicHazards
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "dicHazards")]
    public class EntityDicHazards : BaseDataContract
    {
        /// <summary>
        /// hid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hId", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal hId { get; set; }

        /// <summary>
        /// classId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Int32 classId { get; set; }

        /// <summary>
        /// hazards
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "hazards", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String hazards { get; set; }

        /// <summary>
        /// topicId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "topicId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String topicId { get; set; }

        /// <summary>
        /// topicName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "topicName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String topicName { get; set; }

        /// <summary>
        /// fieldId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String fieldId { get; set; }

        /// <summary>
        /// fieldName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "fieldName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String fieldName { get; set; }

        /// <summary>
        /// suggest
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "suggest", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String suggest { get; set; }

        /// <summary>
        /// sortNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "sortNo", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 sortNo { get; set; }

        [DataMember]
        public string className
        {
            get
            {
                if (classId == 1)
                    return "饮食";
                else if (classId == 2)
                    return "运动";
                else if (classId == 3)
                    return "吸烟情况";
                else if (classId == 4)
                    return "饮酒情况";
                else if (classId == 5)
                    return "心理及睡眠";
                else if (classId == 6)
                    return "既往接触史";
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
            public string hId = "hId";
            public string classId = "classId";
            public string className = "className";
            public string hazards = "hazards";
            public string topicId = "topicId";
            public string topicName = "topicName";
            public string fieldId = "fieldId";
            public string fieldName = "fieldName";
            public string suggest = "suggest";
            public string sortNo = "sortNo";
        }
    }
}
