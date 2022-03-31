using System;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// 系统功能模块
    /// </summary>
    [DataContract, Serializable]
    public class EntitySysModule : BaseDataContract
    {
        /// <summary>
        /// 功能模块ID
        /// </summary>
        [DataMember]
        public int FuncId { get; set; }
        /// <summary>
        /// 功能模块代码
        /// </summary>
        [DataMember]
        public string FuncCode { get; set; }
        /// <summary>
        /// 功能模块名称
        /// </summary>
        [DataMember]
        public string FuncName { get; set; }
        /// <summary>
        /// 功能模块文件名
        /// </summary>
        [DataMember]
        public string FuncFile { get; set; }
        /// <summary>
        /// 功能类型 1 窗体 2 功能 3 分隔符 4 自定义
        /// </summary>
        [DataMember]
        public int FuncType { get; set; }
        /// <summary>
        /// 操作名称
        /// </summary>
        [DataMember]
        public string OperName { get; set; }
        /// <summary>
        /// 父功能模块ID
        /// </summary>
        [DataMember]
        public int ParentId { get; set; }
        /// <summary>
        /// 根节点标志 0 否 1 是
        /// </summary>
        [DataMember]
        public int LeafFlag { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [DataMember]
        public int SortNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int QuickLoad { get; set; }
        /// <summary>
        /// 图像资源文件
        /// </summary>
        [DataMember]
        public string ImageSource { get; set; }

    }
}
