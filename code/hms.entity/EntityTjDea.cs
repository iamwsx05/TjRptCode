using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    public class EntityTjDea : BaseDataContract
    {
        [DataMember]
        public string deaCode { get; set; }
        [DataMember]
        public string deaName { get; set; }
    }
}
