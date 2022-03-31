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
    /// pisClass
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "pisClass")]
    public class EntityPisClass : BaseDataContract
    {
        /// <summary>
        /// classId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String classId { get; set; }

        /// <summary>
        /// className
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "className", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String className { get; set; }

        /// <summary>
        /// editObj
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "editObj", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String editObj { get; set; }

        /// <summary>
        /// reportId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "reportId", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String reportId { get; set; }

        /// <summary>
        /// formId
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "formId", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.Decimal formId { get; set; }

        [DataMember]
        public string layout { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string classId = "classId";
            public string className = "className";
            public string editObj = "editObj";
            public string reportId = "reportId";
            public string formId = "formId";
            public string layout = "layout";
        }
    }

    /// <summary>
    /// pisTeam
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "pisTeam")]
    public class EntityPisTeam : BaseDataContract
    {
        /// <summary>
        /// Teamid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "teamId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String teamId { get; set; }

        /// <summary>
        /// Teamname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "teamName", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String teamName { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string teamId = "teamId";
            public string teamName = "teamName";
        }
    }

    /// <summary>
    /// pisTeamClass
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "pisTeamClass")]
    public class EntityPisTeamClass : BaseDataContract
    {
        /// <summary>
        /// Teamid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "teamId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String teamId { get; set; }

        /// <summary>
        /// Classid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "classId", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String classId { get; set; }

        [DataMember]
        public string className { get; set; }

        [DataMember]
        public string editObj { get; set; }

        [DataMember]
        public string reportId { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string teamId = "teamId";
            public string classId = "classId";
            public string className = "className";
            public string editObj = "editObj";
            public string reportId = "reportId";
        }
    }

}
