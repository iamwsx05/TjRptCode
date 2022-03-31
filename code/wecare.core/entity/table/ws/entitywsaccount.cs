using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// EntityWsAccount
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "wsAccount")]
    public class EntityWsAccount : BaseDataContract
    {
        /// <summary>
        /// patientId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String patientId { get; set; }

        /// <summary>
        /// patientName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patientName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String patientName { get; set; }

        /// <summary>
        /// idCardNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "idCardNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String idCardNo { get; set; }

        /// <summary>
        /// contactTelNo
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "contactTelNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String contactTelNo { get; set; }

        /// <summary>
        /// accpwd
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "accPwd", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String accPwd { get; set; }

        /// <summary>
        /// accStatus
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "accStatus", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Decimal accStatus { get; set; }

        /// <summary>
        /// regDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "regDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime regDate { get; set; }

        [DataMember]
        public int sex { get; set; }

        [DataMember]
        public string birthday { get; set; }

        [DataMember]
        public string workUnit { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string patientId = "patientId";
            public string patientName = "patientName";
            public string idCardNo = "idCardNo";
            public string contactTelNo = "contactTelNo";
            public string accpwd = "accpwd";
            public string accStatus = "accStatus";
            public string regDate = "regDate";
        }
    }
}
