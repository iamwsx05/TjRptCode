using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// 本地参数
    /// </summary>
    [DataContract, Serializable]
    public class EntityAppConfig : BaseDataContract
    {
        /// <summary>
        /// 节点
        /// </summary>
        [DataMember]
        public string Node { get; set; }
        /// <summary>
        /// 模块
        /// </summary>
        [DataMember]
        public string Module { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 功能描述(文本)
        /// </summary>
        [DataMember]
        public string Text { get; set; }
        /// <summary>
        /// 功能值
        /// </summary>
        [DataMember]
        public string Value { get; set; }
    }
}
