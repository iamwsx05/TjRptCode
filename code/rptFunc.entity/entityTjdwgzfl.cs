using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RptFunc.Entity
{
    public class EntityTjdwgzfl 
    {
        [DataMember]
        public string zdrq { get; set; }
        [DataMember]
        public string pzbh { get; set; }
        [DataMember]
        public string lnc_code { get; set; }
        [DataMember]
        public string lnc_name { get; set; }
        [DataMember]
        public string flmc { get; set; }
        [DataMember]
        public string fyfl { get; set; }
        [DataMember]
        public decimal hj { get; set; }
        [DataMember]
        public decimal flhj { get; set; }
        [DataMember]
        public int rs { get; set; }
    }

    public class EntityDwRs
    {
        [DataMember]
        public string lnc_code { get; set; }
        [DataMember]
        public string reg_no { get; set; }
        [DataMember]
        public string fyfl { get; set; }
    }
}
