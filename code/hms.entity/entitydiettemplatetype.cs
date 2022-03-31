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
    [Entity(TableName = "dietTemplatetype")]
    public class EntityDietTemplatetype  : BaseDataContract
    {
        [DataMember]
        [Entity(FieldName = "typeId", DbType = DbType.String, IsPK = true, IsSeq = false, SerNo = 1)]
        public string typeId { get; set; }
        [DataMember]
        [Entity(FieldName = "typeName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public string typeName { get; set; }
        [DataMember]
        [Entity(FieldName = "createDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 3)]
        public DateTime ? createDate { get; set; }
        [DataMember]
        [Entity(FieldName = "creator", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 4)]
        public string creator { get; set; }
        [DataMember]
        [Entity(FieldName = "createName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 5)]
        public string createName { get; set; }
        [DataMember]
        [Entity(FieldName = "modifyDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 6)]
        public DateTime ? modifyDate { get; set; }
        [DataMember]
        [Entity(FieldName = "modifytor", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public string modifytor { get; set; }
        [DataMember]
        [Entity(FieldName = "modifyName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 8)]
        public string modifyName { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string typeId = "typeId";
            public string typeName = "typeName";
            public string createDate = "createDate";
            public string creator = "creator";
            public string createName = "createName";
            public string modifyDate = "modifyDate";
            public string modifytor = "modifytor";
            public string modifyName = "modifyName";
        }
    }
}
