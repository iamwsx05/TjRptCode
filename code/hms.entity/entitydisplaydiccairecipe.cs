using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    public class EntityDisplayDicCaiRecipe : BaseDataContract
    {
        [DataMember]
        public string caiMasterName { get; set; }
        [DataMember]
        public int caiMasterId { get; set; }
        [DataMember]
        public string caiSlaveName { get; set; }
        [DataMember]
        public string caiSlaveId { get; set; }
        [DataMember]
        public string strName { get; set; }
    }
}
