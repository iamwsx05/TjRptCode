using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    public class EntityTjResult :BaseDataContract
    {
        [DataMember]
        public string clientName { get; set; }
        [DataMember]
        public string regNo { get; set; }
        [DataMember]
        public string pFlag { get; set; }
        [DataMember]
        public string sex { get; set; }
        [DataMember]
        public string examinationNo { get; set; }
        [DataMember]
        public string deptName { get; set; }
        [DataMember]
        public string itemCode { get; set; }
        [DataMember]
        public string itemName { get; set; }
        [DataMember]
        public string itemResult { get; set; }
        [DataMember]
        public string range { get; set; }
        [DataMember]
        public string unit { get; set; }
        [DataMember]
        public string doctName { get; set; }
        [DataMember]
        public string regDate { get; set; }
        [DataMember]
        public string ttop { get; set; }
        [DataMember]
        public string hint { get; set; }
    }
}
