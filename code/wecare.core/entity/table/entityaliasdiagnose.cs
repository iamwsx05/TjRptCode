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
    /// ALIAS_DIAGNOSE
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "ALIAS_DIAGNOSE")]
    public class EntityAliasDiagnose : BaseDataContract
    {
        /// <summary>
        /// DIAG_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "DIAG_CODE", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.String diagCode { get; set; }

        /// <summary>
        /// ALIAS_NAME
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "ALIAS_NAME", DbType = DbType.AnsiString, IsPK = true, IsSeq = false, SerNo = 2)]
        public System.String aliasName { get; set; }

        /// <summary>
        /// PY_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "PY_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String pyCode { get; set; }

        /// <summary>
        /// WB_CODE
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "WB_CODE", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String wbCode { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string diagCode = "diagCode";
            public string aliasName = "aliasName";
            public string pyCode = "pyCode";
            public string wbCode = "wbCode";
        }
    }

}
