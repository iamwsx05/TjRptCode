using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RptFunc.Entity
{
    public class EntityItemResult
    {
        [DataMember]
        public string reg_no { get; set; }
        [DataMember]
        public string comb_code { get; set; }
        [DataMember]
        public string item_code { get; set; }
        [DataMember]
        public string rec_result { get; set; }

    }
}
