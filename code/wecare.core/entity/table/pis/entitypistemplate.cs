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
    /// EntityPisTemplate
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "pisTemplate")]
    public class EntityPisTemplate : BaseDataContract
    {
        /// <summary>
        /// templateId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateId", DbType = DbType.Decimal, IsPK = true, IsSeq = true, SerNo = 1)]
        public System.Decimal templateId { get; set; }

        /// <summary>
        /// templateCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String templateCode { get; set; }

        /// <summary>
        /// templateName
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "templateName", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String templateName { get; set; }

        /// <summary>
        /// authority
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "authority", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.Int32 authority { get; set; }

        /// <summary>
        /// pyCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "pyCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// classId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String classId { get; set; }

        /// <summary>
        /// xmlData
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "xmlData", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String xmlData { get; set; }

        /// <summary>
        /// wbCode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "wbCode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// parentId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "parentId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.String parentId { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.Int32 status { get; set; }

        /// <summary>
        /// creator
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creator", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String creator { get; set; }

        /// <summary>
        /// creatDate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "creatDate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.DateTime creatDate { get; set; }

        [DataMember]
        public string key { get; set; }

        [DataMember]
        public int imageIndex { get; set; }

        [DataMember]
        public bool isLeaf { get; set; }

        [DataMember]
        public bool isNew { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string templateId = "templateId";
            public string templateCode = "templateCode";
            public string templateName = "templateName";
            public string authority = "authority";
            public string pyCode = "pyCode";
            public string classId = "classId";
            public string xmlData = "xmlData";
            public string wbCode = "wbCode";
            public string parentId = "parentId";
            public string status = "status";
            public string creator = "creator";
            public string creatDate = "creatDate";
            public string key = "key";
            public string imageIndex = "imageIndex";
            public string isLeaf = "isLeaf";
            public string isNew = "isNew";
        }
    }

}
