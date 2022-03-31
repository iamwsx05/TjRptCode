using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Hms.Entity
{
    /// <summary>
    /// EntityModelAccess
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "modelAccess")]
    public class EntityModelAccess : BaseDataContract
    {
        /// <summary>
        /// modelId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modelId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal modelId { get; set; }

        /// <summary>
        /// modelName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modelName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String modelName { get; set; }

        /// <summary>
        /// modelIntro
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modelIntro", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String modelIntro { get; set; }

        /// <summary>
        /// modelExplan
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modelExplan", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String modelExplan { get; set; }

        /// <summary>
        /// modelAdvice
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modelAdvice", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String modelAdvice { get; set; }

        /// <summary>
        /// lowDanger
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "lowDanger", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.Decimal lowDanger { get; set; }

        /// <summary>
        /// minAge
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "minAge", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Decimal minAge { get; set; }

        /// <summary>
        /// maxAge
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "maxAge", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal maxAge { get; set; }

        /// <summary>
        /// modelSex
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "modelSex", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Decimal modelSex { get; set; }

        /// <summary>
        /// orderId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "orderId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.Decimal orderId { get; set; }

        /// <summary>
        /// isNeedQuestion
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isNeedQuestion", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String isNeedQuestion { get; set; }

        /// <summary>
        /// bakField1
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bakField1", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.String bakField1 { get; set; }

        /// <summary>
        /// bakField2
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bakField2", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.String bakField2 { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string modelId = "modelId";
            public string modelName = "modelName";
            public string modelIntro = "modelIntro";
            public string modelExplan = "modelExplan";
            public string modelAdvice = "modelAdvice";
            public string lowDanger = "lowDanger";
            public string minAge = "minAge";
            public string maxAge = "maxAge";
            public string modelSex = "modelSex";
            public string orderId = "orderId";
            public string isNeedQuestion = "isNeedQuestion";
            public string bakField1 = "bakField1";
            public string bakField2 = "bakField2";
        }
    }
}
