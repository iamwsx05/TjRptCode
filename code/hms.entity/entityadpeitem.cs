using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    public class EntityAdPeItem : BaseDataContract
    {
        [DataMember]
        public string item1 { get; set; }
        [DataMember]
        public string item2 { get; set; }
        [DataMember]
        public string item3 { get; set; }
    }
}
