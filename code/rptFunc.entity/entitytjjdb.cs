using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace RptFunc.Entity
{
    [DataContract, Serializable]
    public class EntityTjjdb : BaseDataContract
    {
        [DataMember]
        public string active { get; set; }
        [DataMember]
        public string reg_date { get; set; }
        [DataMember]
        public string reg_no { get; set; }
        [DataMember]
        public string pat_name { get; set; }
        [DataMember]
        public string pat_code { get; set; }
        [DataMember]
        public string sex { get; set; }
        [DataMember]
        public string comb_code { get; set; }
        [DataMember]
        public string comb_name { get; set; }
        [DataMember]
        public string item_code { get; set; }
        [DataMember]
        public string item_name { get; set; }
        [DataMember]
        public string rec_result { get; set; }
        [DataMember]
        public string doct_name { get; set; }
        [DataMember]
        public string chrg_flag { get; set; }
        [DataMember]
        public string finishStr { get; set; }
        [DataMember]
        public string flg { get; set; }
        [DataMember]
        public int combCount { get; set; }
        [DataMember]
        public int unCombCount { get; set; }
        [DataMember]
        public string lnc_name { get; set; }

    }
}
