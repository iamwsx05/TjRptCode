using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using iCare.Core.Entity;

namespace Common.Entity
{
    /// <summary>
    /// 签名类
    /// </summary>
    [DataContract, Serializable]
    public class EntitySignature : BaseDataContract, IComparable
    {
        /// <summary>
        /// 技术职称代码
        /// </summary>
        private string strTechCode = string.Empty;
        /// <summary>
        /// 流水号
        /// </summary>
        [DataMember]
        public int? intSerNo { get; set; }
        /// <summary>
        /// 签名人ID
        /// </summary>
        [DataMember]
        public int intEmpID { get; set; }
        /// <summary>
        /// 签名人姓名
        /// </summary>
        [DataMember]
        public string strEmpName { get; set; }
        /// <summary>
        /// 技术职称代码
        /// </summary>
        [DataMember]
        public string strTechLevelCode
        {
            get { return strTechCode; }
            set
            {
                strTechCode = value;
                int.TryParse(strTechCode, out intSortNo);
            }
        }
        /// <summary>
        /// 技术职称名称
        /// </summary>
        [DataMember]
        public string strTechLevelName { get; set; }
        /// <summary>
        /// 签名时间
        /// </summary>
        [DataMember]
        public DateTime? dtmSignDate { get; set; }
        /// <summary>
        /// 病人登记ID
        /// </summary>
        [DataMember]
        public int intRegisterID { get; set; }
        /// <summary>
        /// 病历ID
        /// </summary>
        [DataMember]
        public string strCaseCode { get; set; }
        /// <summary>
        /// 通用记录ID
        /// </summary>
        [DataMember]
        public int? intCommID { get; set; }
        /// <summary>
        /// 通用记录分类ID
        /// </summary>
        [DataMember]
        public int? intCommTypeID { get; set; }
        /// <summary>
        /// 对象ID
        /// </summary>
        [DataMember]
        public string strObjectID { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [DataMember]
        private int intSortNo = 0;
        /// <summary>
        /// 内嵌表格Code
        /// </summary>
        [DataMember]
        public string strTableCode { get; set; }
        /// <summary>
        /// CA微缩图
        /// </summary>
        [DataMember]
        public string strSignKeyID { get; set; }
        /// <summary>
        /// CA密文
        /// </summary>
        [DataMember]
        public byte[] bytSignContent { get; set; }
        /// <summary>
        /// 业务数据表
        /// </summary>
        [DataMember]
        public string strDBTableName { get; set; }

        /// <summary>
        /// 表格最大行索引
        /// </summary>
        [DataMember]
        public int intTabMaxRowIndex { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [DataMember]
        public DateTime dtmRecordDate { get; set; }

        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntitySignature)
            {
                return this.intSortNo.CompareTo(((EntitySignature)obj).intSortNo);
            }
            return 0;
        }
    }

    /// <summary>
    /// 通用表单控件图像VO
    /// </summary>
    [DataContract, Serializable]
    public class EntityCaseRtbImage : BaseDataContract
    {
        /// <summary>
        /// 图像ID.XML值
        /// </summary>
        [DataMember]
        public string strImageIdXml { get; set; }
        /// <summary>
        /// 图像BYTE值
        /// </summary>
        [DataMember]
        public byte[] bytImageData { get; set; }
    }
}
