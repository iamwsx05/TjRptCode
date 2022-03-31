using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    public class EntitySetQnControl :BaseDataContract
    {
        [DataMember]
        public string qnId { get; set; }
        [DataMember]
        public string qnName { get; set; }
        [DataMember]
        public string classId { get; set; }
        [DataMember]
        public string parentFieldId { get; set; }
        [DataMember]
        public string parentFieldName { get; set; }
        [DataMember]
        public string typeId { get; set; }
        [DataMember]
        public string childFieldId { get; set; }
        [DataMember]
        public string childFieldName { get; set; }
    }
}
