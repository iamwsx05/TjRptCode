using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// 登录账户
    /// </summary>
    [DataContract, Serializable]
    public class EntityAccount : BaseDataContract
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int AcctStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string EmpId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string EmpNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Pwd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string SignDigital { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int FuncId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string FuncCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string FuncName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int FuncType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string OperName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string ParentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool IsLeaf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string FuncFile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string ImageSource { get; set; }
    }

    /// <summary>
    /// PC信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityPC : BaseDataContract
    {
        /// <summary>
        /// 机器名
        /// </summary>
        [DataMember]
        public string MachineName { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        [DataMember]
        public string IpAddr { get; set; }
        /// <summary>
        /// Mac地址
        /// </summary>
        [DataMember]
        public string MacAddr { get; set; }

        /// <summary>
        /// 工号(个人)
        /// </summary>
        [DataMember]
        public string EmpNo { get; set; }
    }
}
