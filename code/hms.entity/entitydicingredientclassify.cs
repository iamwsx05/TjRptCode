using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;


namespace Hms.Entity
{
    [DataContract,Serializable]
    public class EntityDicIngredientClassify: BaseDataContract
    {
        [DataMember]
        public int classifyId { get; set; }
        [DataMember]
        public string classifyName { get; set; }
    }
}
