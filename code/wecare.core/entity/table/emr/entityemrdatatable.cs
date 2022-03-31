using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace weCare.Core.Entity
{
    [DataContract, Serializable]
    public class EntityEmrDataTable : BaseDataContract
    {
        [DataMember]
        public string dbTableName { get; set; }

        [DataMember]
        public string registerId { get; set; }

        [DataMember]
        public string recorderId { get; set; }

        [DataMember]
        public DateTime? recordDate { get; set; }

        [DataMember]
        public string modifierId { get; set; }

        [DataMember]
        public DateTime modifyDate { get; set; }

        [DataMember]
        public string xmlData { get; set; }

        [DataMember]
        public bool isNew { get; set; }

        [DataMember]
        public string caseCode { get; set; }

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
            public string dbTableName = "dbTableName";
            public string registerId = "registerId";
            public string recorderId = "recorderId";
            public string recordDate = "recordDate";
            public string modifierId = "modifierId";
            public string modifyDate = "modifyDate";
            public string xmlData = "xmlData";
            public string caseCode = "caseCode";
            public string layout = "layout";
        }
    }

}
