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
    public class EntityCsRecipeOrderDic : BaseDataContract
    {
        [DataMember]
        public string orderDicId { get; set; }

        [DataMember]
        public string orderDicName { get; set; }

        [DataMember]
        public string spec { get; set; }

        [DataMember]
        public decimal qty { get; set; }

        /// <summary>
        /// 同 eafApplication.appId 
        /// </summary>
        [DataMember]
        public string attachId { get; set; }

        [DataMember]
        public decimal price { get; set; }

        [DataMember]
        public decimal total { get; set; }

        [DataMember]
        public decimal sbBaseMny { get; set; }

        /// <summary>
        /// 是否急诊
        /// </summary>
        [DataMember]
        public int isEmer { get; set; }

    }
}
