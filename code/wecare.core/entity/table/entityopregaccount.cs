using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// opRegAccount
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegAccount")]
    public class EntityOpRegAccount : BaseDataContract
    {
        /// <summary>
        /// bookingNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "bookingNo", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal bookingNo { get; set; }

        /// <summary>
        /// totalAmt
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "totalAmt", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.Decimal totalAmt { get; set; }

        /// <summary>
        /// selfAmt
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "selfAmt", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.Decimal selfAmt { get; set; }

        /// <summary>
        /// isUpload
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "isUpload", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Decimal isUpload { get; set; }

        /// <summary>
        /// uploadDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "uploadDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.DateTime? uploadDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string bookingNo = "bookingNo";
            public string totalAmt = "totalAmt";
            public string selfAmt = "selfAmt";
            public string isUpload = "isUpload";
            public string uploadDate = "uploadDate";
        }
    }

}
