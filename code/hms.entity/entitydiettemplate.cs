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
    [Entity(TableName = "dietTemplate")]
    public class EntityDietTemplate :BaseDataContract
    {
        /// <summary>
        /// 模板Id
        /// </summary>
        [DataMember]
        [Entity(FieldName = "templateId", DbType = DbType.String, IsPK = true, IsSeq = false, SerNo = 1)]
        public string templateId { get; set; }
        /// <summary>
        /// 模板名称
        /// </summary>
        [DataMember]
        [Entity(FieldName = "templateName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public string templateName { get; set; }
        /// <summary>
        /// 模板类型
        /// </summary>
        [DataMember]
        [Entity(FieldName = "typeid", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 3)]
        public string typeid { get; set; }
        /// <summary>
        /// 详情
        /// </summary>
        [DataMember]
        [Entity(FieldName = "descriptions", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 4)]
        public string descriptions { get; set; }
        /// <summary>
        /// 模板周期
        /// </summary>
        [DataMember]
        [Entity(FieldName = "days", DbType = DbType.Int16, IsPK = false, IsSeq = false, SerNo = 5)]
        public int days { get; set; }
        /// <summary>
        ///创建时间
        /// </summary>
        [DataMember]
        [Entity(FieldName = "createDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public DateTime ? createDate { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        [DataMember]
        [Entity(FieldName = "creator", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public string creator { get; set; }
        /// <summary>
        /// 创建者姓名 
        /// </summary>
        [DataMember]
        [Entity(FieldName = "createName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 8)]
        public string createName { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [DataMember]
        [Entity(FieldName = "modifyDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 9)]
        public DateTime ? modifyDate { get; set; }
        /// <summary>
        /// 修改者
        /// </summary>
        [DataMember]
        [Entity(FieldName = "modifytor", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 10)]
        public string modifytor { get; set; }
        /// <summary>
        /// 修改者姓名
        /// </summary>
        [DataMember]
        [Entity(FieldName = "modifyName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 11)]
        public string modifyName { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string templateId = "templateId";
            public string templateName = "templateName";
            public string typeId = "typeId";
            public string descriptions = "descriptions";
            public string days = "days";
            public string createDate = "createDate";
            public string creator = "creator";
            public string createName = "createName";
            public string modifyDate = "modifyDate";
            public string modifytor = "modifytor";
            public string modifyName = "modifyName";
        }
    }
}
