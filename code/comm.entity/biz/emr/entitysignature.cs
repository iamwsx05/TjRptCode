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
    /// 签名类
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrSignature")]
    public class EntitySignature : BaseDataContract, IComparable
    {
        /// <summary>
        /// 技术职称代码
        /// </summary>
        string _techLevelCode = string.Empty;
       
        /// <summary>
        /// 技术职称名称
        /// </summary>
        [DataMember]
        public string techLevelName { get; set; }
       
        /// <summary>
        /// 对象ID
        /// </summary>
        [DataMember]
        public string objectID { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [DataMember]
        private int sortNo = 0;
       
        /// <summary>
        /// 业务数据表
        /// </summary>
        [DataMember]
        public string dbTableName { get; set; }

        /// <summary>
        /// 表格最大行索引
        /// </summary>
        [DataMember]
        public int tabMaxRowIndex { get; set; }
              
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntitySignature)
            {
                return this.sortNo.CompareTo(((EntitySignature)obj).sortNo);
            }
            return 0;
        }


        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Empid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "empid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String empId { get; set; }

        /// <summary>
        /// Empname
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "empname", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String empName { get; set; }

        /// <summary>
        /// Techlevelcode 技术职称代码
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "techlevelcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.String techLevelCode
        {
            get { return _techLevelCode; }
            set
            {
                _techLevelCode = value;
                int.TryParse(_techLevelCode, out sortNo);
            }
        }

        /// <summary>
        /// Signdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "signdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.DateTime? signDate { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Casecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 7)]
        public System.String caseCode { get; set; }

        /// <summary>
        /// Commid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "commid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 8)]
        public System.Int32? commId { get; set; }

        /// <summary>
        /// Commtypeid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "commtypeid", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 9)]
        public System.Int32 commTypeId { get; set; }

        /// <summary>
        /// Colcode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "colcode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 10)]
        public System.String colCode { get; set; }

        /// <summary>
        /// Tablecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "tablecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 11)]
        public System.String tableCode { get; set; }

        /// <summary>
        /// Signkeyid CA微缩图
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "signkeyid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 12)]
        public System.String signKeyId { get; set; }

        /// <summary>
        /// Signcontent
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "signcontent", DbType = DbType.Binary, IsPK = false, IsSeq = false, SerNo = 13)]
        public System.Byte[] signContent { get; set; }

        /// <summary>
        /// Recorddate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "recorddate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 14)]
        public System.DateTime? recordDate { get; set; }

        /// <summary>
        /// Columns
        /// </summary>
        public static EnumCols Columns = new EnumCols();

        /// <summary>
        /// EnumCols
        /// </summary>
        public class EnumCols
        {
            public string serNo = "serno";
            public string empId = "empid";
            public string empName = "empname";
            public string techLevelCode = "techlevelcode";
            public string signDate = "signdate";
            public string registerId = "registerid";
            public string caseCode = "casecode";
            public string commId = "commid";
            public string commTypeId = "commtypeid";
            public string colCode = "colcode";
            public string tableCode = "tablecode";
            public string signKeyId = "signkeyid";
            public string signContent = "signcontent";
            public string recordDate = "recorddate";
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
