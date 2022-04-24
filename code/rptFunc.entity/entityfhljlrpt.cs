using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RptFunc.Entity
{
    public class EntityFhljlRpt
    {
        [DataMember]
        public string reg_no { get; set; }
        [DataMember]
        public string reg_date { get; set; }
        [DataMember]
        public string pat_name { get; set; }// 
        [DataMember]
        public string sex { get; set; }//
        [DataMember]
        public string age { get; set; }
        [DataMember]
        public string idcard { get; set; }//
        [DataMember]
        public string item_fhl { get; set; }
        [DataMember]
        public string item_fvc { get; set; }
        [DataMember]
        public string item_fev { get; set; }
        [DataMember]
        public string item_fev2 { get; set; }
        [DataMember]
        public string item_ty { get; set; }
    }
}
