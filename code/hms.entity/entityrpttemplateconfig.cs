using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract, Serializable]
    [Entity(TableName = "dicRptTemplateConfig")]
    public class EntityRpttemplateConfig : BaseDataContract
    {
        /// <summary>
        /// 模板代码
        /// </summary>
        [DataMember]
        [Entity(FieldName = "templateId", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 1)]
        public string templateId { get; set; }
        /// <summary>
        /// 项目代码
        /// </summary>
        [DataMember]
        [Entity(FieldName = "itemCode", DbType = DbType.String, IsPK = false, IsSeq = false, SerNo = 2)]
        public string itemCode { get; set; }

        public static EnumCols Columns = new EnumCols();

        public class EnumCols
        {
            public string templateId = "templateId";
            public string itemCode = "itemCode";
        }

    }
}
