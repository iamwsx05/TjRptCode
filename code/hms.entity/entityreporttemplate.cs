using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract, Serializable]
    public class EntityReportTemplate : BaseDataContract
    {
        /// <summary>
        /// 选择
        /// </summary>
        [DataMember]
        public bool isSelect { get; set; }
        /// <summary>
        /// 模板id
        /// </summary>
       [DataMember]
        public string templateId { get; set; }
        /// <summary>
        /// 模板名称
        /// </summary>
        [DataMember]
        public string templateName { get; set; }

        /// <summary>
        /// 检验库
        /// </summary>
        [DataMember]
        public string peDatabase { get; set; }

        /// <summary>
        /// 参考价格
        /// </summary>
        [DataMember]
        public decimal refPrice { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [DataMember]
        public string describe { get; set; }

    }
}
