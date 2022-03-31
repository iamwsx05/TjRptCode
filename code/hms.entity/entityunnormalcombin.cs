using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract, Serializable]
    public class EntityUnnormalcombin : BaseDataContract
    {
        /// <summary>
        /// 组合异常名称
        /// </summary>
        [DataMember]
        public string name { get; set; }
        /// <summary>
        /// 详细描述
        /// </summary>
        [DataMember]
        public string describe { get; set; }
    }
}
