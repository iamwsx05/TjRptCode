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
    [Entity(TableName = "dicDietTreatment")]
    public class EntityDietTreatment : BaseDataContract
    {
        [DataMember]
        [Entity(FieldName = "id", DbType = DbType.String, IsPK = true, IsSeq = false, SerNo = 1)]
        public string id { get; set; }
        [DataMember]
        [Entity(FieldName = "names", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public string names { get; set; }
        [DataMember]
        [Entity(FieldName = "configs", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 3)]
        public string configs { get; set; }
        [DataMember]
        [Entity(FieldName = "fuctions", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 4)]
        public string fuctions { get; set; }
        [DataMember]
        [Entity(FieldName = "usage", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 5)]
        public string usage { get; set; }
        [DataMember]
        [Entity(FieldName = "attention", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 6)]
        public string attention { get; set; }
        [DataMember]
        [Entity(FieldName = "methods", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public string methods { get; set; }
        [DataMember]
        [Entity(FieldName = "bakfield1", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 8)]
        public string bakfield1 { get; set; }
        [DataMember]
        [Entity(FieldName = "bakfield2", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 9)]
        public string bakfield2 { get; set; }
        [DataMember]
        [Entity(FieldName = "createDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 10)]
        public DateTime? createDate { get; set; }
        [DataMember]
        [Entity(FieldName = "creator", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 11)]
        public string creator { get; set; }
        [DataMember]
        [Entity(FieldName = "createName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 12)]
        public string createName { get; set; }
        [DataMember]
        [Entity(FieldName = "modifyDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 13)]
        public DateTime ? modifyDate { get; set; }
        [DataMember]
        [Entity(FieldName = "modifytor", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 14)]
        public string modifytor { get; set; }
        [DataMember]
        [Entity(FieldName = "modifyName", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 15)]
        public string modifyName { get; set; }
        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string id = "id";
            public string names = "names";
            public string configs = "configs";
            public string fuctions = "fuctions";
            public string usage = "usage";
            public string attention = "attention";
            public string methods = "methods";
            public string bakfield1 = "bakfield1";
            public string bakfield2 = "bakfield2";
            public string createDate = "createDate";
            public string creator = "creator";
            public string createName = "createName";
            public string modifyDate = "modifyDate";
            public string modifytor = "modifytor";
            public string modifyName = "modifyName";
        }

    }
}
