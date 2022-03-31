using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract,Serializable]
    public class EntityEvaluateResult :BaseDataContract
    {
        /// <summary>
        /// 评估项目
        /// </summary>
        [DataMember]
        public string evaluationName { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        [DataMember]
        public double result { get; set; }
    }
}
