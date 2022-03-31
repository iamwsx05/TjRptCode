using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Hms.Entity
{
    /// <summary>
    /// EntityModelAnalysisPoint
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "modelAnalysisPoint")]
    public class EntityModelAnalysisPoint : BaseDataContract
    {
        /// <summary>
        /// id
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "id", DbType = DbType.Int32, IsPK = false, IsSeq = false, SerNo = 1)]
        public System.Int32 id { get; set; }

        /// <summary>
        /// paramType
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "paramType", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal paramType { get; set; }

        /// <summary>
        /// paramNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "paramNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String paramNo { get; set; }

        /// <summary>
        /// paramName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "paramName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String paramName { get; set; }

        /// <summary>
        /// judgeWay
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "judgeWay", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String judgeWay { get; set; }

        /// <summary>
        /// judgeValue
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "judgeValue", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String judgeValue { get; set; }

        /// <summary>
        /// pintAdvice
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pintAdvice", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String pintAdvice { get; set; }

        /// <summary>
        /// remarks
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "remarks", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String remarks { get; set; }

        /// <summary>
        /// bakField1
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bakField1", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String bakField1 { get; set; }

        /// <summary>
        /// bakField2
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bakField2", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
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
            public string id = "id";
            public string paramType = "paramType";
            public string paramNo = "paramNo";
            public string paramName = "paramName";
            public string judgeWay = "judgeWay";
            public string judgeValue = "judgeValue";
            public string pintAdvice = "pintAdvice";
            public string remarks = "remarks";
            public string bakField1 = "bakField1";
            public string bakField2 = "bakField2";
        }
    }
}
