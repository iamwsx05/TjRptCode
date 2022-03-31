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
    /// AS_IP_REQENTRY
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "AS_IP_REQENTRY")]
    public class EntityAsIpReqEntry : BaseDataContract
    {
        /// <summary>
        /// REQ_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "REQ_NO", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Int32 reqNo { get; set; }

        /// <summary>
        /// GROUP_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "GROUP_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String groupCode { get; set; }

        /// <summary>
        /// PRE_NO
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PRE_NO", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 3)]
        public System.String preNo { get; set; }

        /// <summary>
        /// CONFIRM
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "CONFIRM", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String confirm { get; set; }

        /// <summary>
        /// RECEIVE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RECEIVE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String receive { get; set; }

        /// <summary>
        /// RECEIVE_OPER
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RECEIVE_OPER", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String receiveOper { get; set; }

        /// <summary>
        /// RECEIVE_DATE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RECEIVE_DATE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String receiveDate { get; set; }

        /// <summary>
        /// RECEIVE_TIME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "RECEIVE_TIME", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String receiveTime { get; set; }

        /// <summary>
        /// TOTAL
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "TOTAL", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal total { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string reqNo = "reqNo";
            public string groupCode = "groupCode";
            public string preNo = "preNo";
            public string confirm = "confirm";
            public string receive = "receive";
            public string receiveOper = "receiveOper";
            public string receiveDate = "receiveDate";
            public string receiveTime = "receiveTime";
            public string total = "total";
        }

        [DataMember]
        public string roomCode { get; set; }
    }

}
