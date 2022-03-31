using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    [Entity(TableName = "dietPrinciple")]
    public class EntityDietPrinciple : BaseDataContract
    {
        /// <summary>
        /// id
        /// </summary>
        [DataMember]
        [Entity(FieldName = "principleId", DbType = DbType.String, IsPK = true, IsSeq = false, SerNo = 1)]
        public string principleId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [DataMember]
        [Entity(FieldName = "principleName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public string principleName { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [DataMember]
        [Entity(FieldName = "contents", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 3)]
        public string contents { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [DataMember]
        [Entity(FieldName = "createDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public DateTime ? createDate { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DataMember]
        [Entity(FieldName = "createUserId", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 5)]
        public string createUserId { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        [DataMember]
        [Entity(FieldName = "modifyDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public DateTime ? modifyDate { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [DataMember]
        [Entity(FieldName = "modifyUserId", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public string modifyUserId { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string principleId = "principleId";
            public string principleName = "principleName";
            public string contents = "contents";
            public string createDate = "createDate";
            public string createUserId = "createUserId";
            public string modifyDate = "modifyDate";
            public string modifyUserId = "modifyUserId";
        }
    }
}
