using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    public class EntityDisplaypeitem : BaseDataContract
    {
        public bool isSelect { get; set; }
        /// <summary>
        /// 分类id
        /// </summary>
        [DataMember]
        public string peDepartmentId { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        [DataMember]
        public string peDepartmentName { get; set; }

        /// <summary>
        /// 项目明细
        /// </summary>
        public List<EntityTemplatedetail> detailData { get; set; }
    }
}
