using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    [DataContract, Serializable]
    public class EntityParm : BaseDataContract
    {
        [DataMember]
        public string key { get; set; }
        [DataMember]
        public string value { get; set; }
    }
}
