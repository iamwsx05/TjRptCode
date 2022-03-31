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
    public class EntityCsOrderChargeDept : BaseDataContract
    {
        [DataMember]
        public string orderDicId { get; set; }

        [DataMember]
        public string chargeItemId { get; set; }

        [DataMember]
        public string chargeItemName { get; set; }

        [DataMember]
        public string clacAreaId { get; set; }

        [DataMember]
        public string createAreaId { get; set; }

        [DataMember]
        public string spec { get; set; }

        [DataMember]
        public string unit { get; set; }

        [DataMember]
        public decimal amount { get; set; }

        [DataMember]
        public decimal unitPrice { get; set; }

        [DataMember]
        public string creatorId { get; set; }

        [DataMember]
        public string creatorName { get; set; }

        [DataMember]
        public DateTime createDate { get; set; }

        [DataMember]
        public int flagId { get; set; }

        [DataMember]
        public decimal singleAmount { get; set; }

        [DataMember]
        public int poFlag { get; set; }

        [DataMember]
        public int rateType { get; set; }

        [DataMember]
        public string insuraceDesc { get; set; }

        [DataMember]
        public int continueuseType { get; set; }

        [DataMember]
        public string continueFreqId { get; set; }

        [DataMember]
        public string itemChargeType { get; set; }

    }
}
