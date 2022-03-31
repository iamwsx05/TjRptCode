using System;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace Hms.Entity
{
    [DataContract, Serializable]
    public class EntitySMS : weCare.Core.Entity.BaseDataContract
    {
        [DataMember]
        public string patName { get; set; }

        [DataMember]
        public string telNo { get; set; }

        [DataMember]
        public string sex { get; set; }

        [DataMember]
        public string age { get; set; }

        [DataMember]
        public string unitName { get; set; }

        [DataMember]
        public string patType { get; set; }

        [DataMember]
        public string SMS { get; set; }
    }
}
