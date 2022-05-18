using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RptFunc.Entity
{
    public class EntityTjywflRpt
    {
        [DataMember]
        public string job_name { get; set; }
        [DataMember]
        public string reg_no { get; set; }
        [DataMember]
        public string pat_name { get; set; }
        [DataMember]
        public string sex { get; set; }
        [DataMember]
        public string age { get; set; }
        [DataMember]
        public string idcard { get; set; }
        [DataMember]
        public string tel { get; set; }
        [DataMember]
        public string reg_date { get; set; }
        [DataMember]
        public string lnc_name { get; set; }
        [DataMember]
        public string cFlag { get; set; }
        [DataMember]
        public string fFlag { get; set; }
        [DataMember]
        public  decimal sumGr { get; set; }
        [DataMember]
        public string status { get; set; }
    }
}
