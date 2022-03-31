using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    public class EntityPromotionTemplate :BaseDataContract
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string templateName { get; set; }
        [DataMember]
        public string templateCondition { get; set; }
        [DataMember]
        public string isEnabled { get; set; }
        [DataMember]
        public string bakField1 { get; set; }
        [DataMember]
        public string bakField2 { get; set; }
        [DataMember]
        public DateTime  createDate { get; set; }
        [DataMember]
        public string cretateId { get; set; }
        [DataMember]
        public string creator { get; set; }
        [DataMember]
        public DateTime  modifyDate { get; set; }
        [DataMember]
        public string modifyId { get; set; }
        [DataMember]
        public string modifyName { get; set; }
    }
}
