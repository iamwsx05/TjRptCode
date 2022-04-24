using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace RptFunc.Entity
{
    public class EntityZybRegRpt : BaseDataContract
    {
        [DataMember]
        public string reg_no { get; set; }
        [DataMember]
        public string pat_name { get; set; }// 
        [DataMember]
        public string sex { get; set; }//
        [DataMember]
        public string age { get; set; }
        [DataMember]
        public string idcard { get; set; }//
        [DataMember]
        public string tel { get; set; }//
        [DataMember]
        public string pStatus { get; set; }//
        [DataMember]
        public string gz { get; set; }
        [DataMember]
        public string job_whys { get; set; }
        [DataMember]
        public string work_age { get; set; }// 
        [DataMember]
        public string injury_age { get; set; }
        [DataMember]
        public string comb_name { get; set; }
        [DataMember]
        public string res_tag { get; set; }//
        [DataMember]
        public string sugg_tag { get; set; }
    }
}
