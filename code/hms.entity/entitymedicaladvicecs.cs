using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    public class EntityMedicalAdvicecs : BaseDataContract
    {
        [DataMember]
        public string important { get; set; }
        [DataMember]
        public string unnormal { get; set; }
        [DataMember]
        public string medDate { get; set; }
        [DataMember]
        public string refferDept { get; set; }
    }
}
