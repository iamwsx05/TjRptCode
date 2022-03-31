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
    /// opRegWeChatBinding
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "opRegWeChatBinding")]
    public class EntityOpRegWeChatBinding : BaseDataContract
    {
        /// <summary>
        /// Cardno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cardNo", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String cardNo { get; set; }

        /// <summary>
        /// Patname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "patName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String patName { get; set; }

        /// <summary>
        /// Idtype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "idType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String idType { get; set; }

        /// <summary>
        /// Idno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "idNo", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String idNo { get; set; }

        /// <summary>
        /// Channeltype
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "channelType", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String channelType { get; set; }

        /// <summary>
        /// Openid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "openId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String openId { get; set; }

        /// <summary>
        /// Creatdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.DateTime creatDate { get; set; }

        /// <summary>
        /// Canceldate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "cancelDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.DateTime? cancelDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Decimal status { get; set; }

        [DataMember]
        public bool isUpdate { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [DataMember]
        public string phoneNo { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string cardNo = "cardNo";
            public string patName = "patName";
            public string idType = "idType";
            public string idNo = "idNo";
            public string channelType = "channelType";
            public string openId = "openId";
            public string creatDate = "creatDate";
            public string cancelDate = "cancelDate";
            public string status = "status";
            public string isUpdate = "isUpdate";
            public string phoneNo = "phoneNo";
        }
    }

}
