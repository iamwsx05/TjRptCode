using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    public class EntityCtrlLocation :BaseDataContract
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public int width { get; set; }
        [DataMember]
        public int height { get; set; }
        [DataMember]
        public int locationX { get; set; }
        [DataMember]
        public int locationY { get; set; }
        [DataMember]
        public int type { get; set; }

    }
}
