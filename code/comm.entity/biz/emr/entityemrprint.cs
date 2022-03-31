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
    /// <summary>
    /// 自定义打印数据契约
    /// </summary>
    [DataContract, Serializable]
    public class EntityCustomPrint : BaseDataContract
    {
        /// <summary>
        /// 病人登记ID
        /// </summary>
        [DataMember]
        public string RegisterID { get; set; }
        /// <summary>
        /// 表单代码
        /// </summary>
        [DataMember]
        public string CaseCode { get; set; }
        /// <summary>
        /// 打印模板
        /// </summary>
        [DataMember]
        public string PrintTemplate { get; set; }
        /// <summary>
        /// 表单名称
        /// </summary>
        [DataMember]
        public string CaseName { get; set; }
        /// <summary>
        /// 出院顺序
        /// </summary>
        [DataMember]
        public int OSortNo { get; set; }
        /// <summary>
        /// 绑定状态
        /// </summary>
        [DataMember]
        public int BindingStatusInt { get; set; }

        /// <summary>
        /// 目录ID
        /// </summary>
        [DataMember]
        public int? PnID { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [DataMember]
        public string TableName { get; set; }

        /// <summary>
        /// 绑定标志
        /// </summary>
        [DataMember]
        public int BindingFlags { get; set; }

        /// <summary>
        /// 是否已绑定
        /// </summary>
        public string BindingStatus
        {
            get
            {
                if (BindingFlags == 1)
                {
                    if (BindingStatusInt == 1)
                    {
                        return "已绑定";
                    }
                    else
                    {
                        return "未绑定";
                    }
                }
                else
                {
                    return "不需要绑定";
                }
            }
        }

        /// <summary>
        /// 记录日期
        /// </summary>
        [DataMember]
        public DateTime? RecordDate = null;
        /// <summary>
        /// 使用属性(-1 不使用 0 公用 1 医生 2 护士 )
        /// </summary>
        [DataMember]
        public int? Attribute = null;
    }

    /// <summary>
    /// 护理记录诊断特殊打印设置
    /// </summary>
    [DataContract, Serializable]
    public class EntityTabDiagSetting : BaseDataContract
    {
        /// <summary>
        /// 表单CASECODE
        /// </summary>
        [DataMember]
        public string CaseCode { get; set; }
        /// <summary>
        /// 表单字段数据列名
        /// </summary>
        [DataMember]
        public string ColCode { get; set; }
        /// <summary>
        /// 打印模板报表名
        /// </summary>
        [DataMember]
        public string RptName { get; set; }
        /// <summary>
        /// 打印模板绑定列名
        /// </summary>
        [DataMember]
        public string RptColCode { get; set; }
    }

}
