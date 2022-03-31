using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Hms.Entity
{
    /// <summary>
    /// EntityModelParam
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "modelParam")]
    public class EntityModelParam : BaseDataContract
    {
        /// <summary>
        /// id
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "id", DbType = DbType.Int32, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// modelId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modelId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal modelId { get; set; }

        /// <summary>
        /// judgeType
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "judgeType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal judgeType { get; set; }

        /// <summary>
        /// paramType
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "paramType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal paramType { get; set; }

        /// <summary>
        /// gender
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "gender", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal gender { get; set; }

        /// <summary>
        /// isChange
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isChange", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal isChange { get; set; }

        /// <summary>
        /// paramNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "paramNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String paramNo { get; set; }

        /// <summary>
        /// paramName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "paramName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String paramName { get; set; }

        /// <summary>
        /// judgeValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "judgeValue", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal judgeValue { get; set; }

        /// <summary>
        /// judgeRange
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "judgeRange", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String judgeRange { get; set; }

        /// <summary>
        /// score
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "score", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal score { get; set; }

        /// <summary>
        /// modulus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modulus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.Decimal modulus { get; set; }

        /// <summary>
        /// remarks
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "remarks", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String remarks { get; set; }

        /// <summary>
        /// parentFieldId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentFieldId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 16)]
        public System.String parentFieldId { get; set; }

        /// <summary>
        /// isBest
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isBest", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 17)]
        public System.String isBest { get; set; }

        /// <summary>
        /// isNormal
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isNormal", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 20)]
        public System.String isNormal { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string id = "id";
            public string modelId = "modelId";
            public string judgeType = "judgeType";
            public string paramType = "paramType";
            public string gender = "gender";
            public string isChange = "isChange";
            public string paramNo = "paramNo";
            public string paramName = "paramName";
            public string judgeValue = "judgeValue";
            public string judgeRange = "judgeRange";
            public string score = "score";
            public string modulus = "modulus";
            public string remarks = "remarks";
            public string parentFieldId = "parentFieldId";
            public string isBest = "isBest";
            public string isNormal = "isNormal";
        }
    }
}
