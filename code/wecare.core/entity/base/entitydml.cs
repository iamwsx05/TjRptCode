using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// 数据操作实体
    /// </summary>
    [DataContract, Serializable]
    public class EntityDML<T> where T : BaseDataContract
    {
        /// <summary>
        /// 是否新增
        /// </summary>
        [DataMember]
        public bool IsAdd { get; set; }

        /// <summary>
        /// 新增数据集
        /// </summary>
        [DataMember]
        public List<T> AddSource { get; set; }

        /// <summary>
        /// 是否更新
        /// </summary>
        [DataMember]
        public bool IsUpdate { get; set; }

        /// <summary>
        /// 更新数据集
        /// </summary>
        [DataMember]
        public List<T> UpdateSource { get; set; }

        /// <summary>
        /// 更新数据集对应之前的数据集
        /// </summary>
        [DataMember]
        public List<T> UpdatePreSource { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [DataMember]
        public bool IsDelete { get; set; }

        /// <summary>
        /// 删除数据集
        /// </summary>
        [DataMember]
        public List<T> DeleteSource { get; set; }

    }
}
