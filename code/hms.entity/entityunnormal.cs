using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using weCare.Core.Entity;

namespace Hms.Entity
{
    [DataContract, Serializable]
    public class EntityUnnormal : BaseDataContract
    {
        /// <summary>
        /// 选择
        /// </summary>
        public bool check { get; set; }
        /// <summary>
        /// 异常名称
        /// </summary>
        [DataMember]
        public string unnormalName { get; set; }
        /// <summary>
        /// 异常类型
        /// </summary>
        [DataMember]
        public string unnormalType { get; set; }
        /// <summary>
        /// 重要性
        /// </summary>
        [DataMember]
        public string importance { get; set; }
        /// <summary>
        /// 紧急性
        /// </summary>
        [DataMember]
        public string emergency { get; set; }
        /// <summary>
        /// 推荐科室
        /// </summary>
        [DataMember]
        public string refDeptname { get; set; }
        /// <summary>
        /// 推荐检查
        /// </summary>
        [DataMember]
        public string refCheck { get; set; }
        /// <summary>
        /// 所属系统
        /// </summary>
        [DataMember]
        public string belongSys { get; set; }
    }
}
