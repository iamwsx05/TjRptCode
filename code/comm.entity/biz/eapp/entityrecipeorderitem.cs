using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using weCare.Core.Entity;

namespace Common.Entity
{
    [DataContract, Serializable]
    public class EntityCsRecipeOrderItem : BaseDataContract
    {
        [DataMember]
        public int rowNo { get; set; }

        [DataMember]
        public string itemId { get; set; }

        [DataMember]
        public string itemName { get; set; }

        [DataMember]
        public decimal price { get; set; }

        [DataMember]
        public decimal qty { get; set; }

        [DataMember]
        public decimal total { get; set; }

        [DataMember]
        public string attachId { get; set; }

        [DataMember]
        public string itemSpec { get; set; }

        [DataMember]
        public string itemUnit { get; set; }

        [DataMember]
        public string orderId { get; set; }

        [DataMember]
        public decimal orderBaseNum { get; set; }
    }
}
