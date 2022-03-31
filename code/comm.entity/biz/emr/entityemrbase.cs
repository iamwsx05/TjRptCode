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
    #region 表单列信息
    /// <summary>
    /// 表单列信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityCaseColumnInfo : BaseDataContract
    {
        /// <summary>
        /// 表单CASECODE
        /// </summary>
        [DataMember]
        public string CaseCode { get; set; }
        /// <summary>
        /// 列CODE
        /// </summary>
        [DataMember]
        public string ColCode { get; set; }
        /// <summary>
        /// 列信息
        /// </summary>
        [DataMember]
        public string ColDesc { get; set; }
    }
    #endregion

    #region 智能引用类
    /// <summary>
    /// 智能引用类
    /// </summary>
    [DataContract, Serializable]
    public class EntityIntellectionReference : BaseDataContract, IComparable
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ClassID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int StartIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Len { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string CaseColCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public string OrgText { get; set; }

        /// <summary>
        /// 比较
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityIntellectionReference)
            {
                return this.StartIndex.CompareTo(((EntityIntellectionReference)obj).StartIndex);
            }
            return 0;
        }
    }
    #endregion
    
    #region 元素
    /// <summary>
    /// 元素
    /// </summary>
    [DataContract, Serializable]
    public class EntityElement : BaseDataContract
    {
        /// <summary>
        /// 元素ID
        /// </summary>
        [DataMember]
        public string ElementID { get; set; }
        /// <summary>
        /// 元素名称
        /// </summary>
        [DataMember]
        public string ElementName { get; set; }
    }
    #endregion

    #region 录入限制信息
    /// <summary>
    /// 录入限制信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityInputConfine : BaseDataContract
    {
        /// <summary>
        /// 类型: 1 单一条件；2 复合条件
        /// </summary>
        [DataMember]
        public int intType { get; set; }
        /// <summary>
        /// 单一条件
        /// </summary>
        [DataMember]
        public EntityConfineInfo dcConfineInfo { get; set; }
        /// <summary>
        /// 复合条件
        /// </summary>
        [DataMember]
        public List<EntityConfineInfo> lstConfineInfo { get; set; }
    }

    /// <summary>
    /// 录入限制信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityConfineInfo : BaseDataContract
    {
        /// <summary>
        /// 标识: 1 性别; 2 年龄
        /// </summary>
        [DataMember]
        public int intIdentType { get; set; }
        /// <summary>
        /// 受限类型： -1 禁止录入; 0 不受控制; 1 必填项
        /// </summary>
        [DataMember]
        public int intConfineType { get; set; }
        /// <summary>
        /// 操作符: 0 =; 1 <; 2 <=; 3 >; 4 >=; 5 <>
        /// </summary>
        [DataMember]
        public int intOperSign { get; set; }
        /// <summary>
        /// 比较值
        /// </summary>
        [DataMember]
        public string strValue { get; set; }
        /// <summary>
        /// 值类型: 1 数值; 2 文本
        /// </summary>
        [DataMember]
        public int intValType { get; set; }
    }

    /// <summary>
    /// 表单字段录入限制信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityColumnConfine : BaseDataContract, IComparable
    {
        /// <summary>
        /// 表单CODE
        /// </summary>
        [DataMember]
        public string strCaseCode { get; set; }
        /// <summary>
        /// 列名CODE
        /// </summary>
        [DataMember]
        public string strColCode { get; set; }
        /// <summary>
        /// 必填 True 是 False 否
        /// </summary>
        [DataMember]
        public bool blnMustFill { get; set; }
        /// <summary>
        /// 必填元素列表
        /// </summary>
        [DataMember]
        public List<EntityElement> lstElement { get; set; }
        /// <summary>
        /// 录入限制信息数组
        /// </summary>
        [DataMember]
        public List<EntityInputConfine> lstInputConfine { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [DataMember]
        public int intSortNO { get; set; }
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityColumnConfine)
            {
                return this.intSortNO.CompareTo(((EntityColumnConfine)obj).intSortNO);
            }
            return 0;
        }
    }

    #endregion

    #region 表单多页属性
    /// <summary>
    /// 表单多页属性
    /// </summary>
    [DataContract, Serializable]
    public class EntityCaseMultiPage : BaseDataContract
    {
        /// <summary>
        /// 表单代码
        /// </summary>
        [DataMember]
        public string strCaseCode { get; set; }
        /// <summary>
        /// 多页标志 0 否 1 是
        /// </summary>
        [DataMember]
        public int intMultiPageFlag { get; set; }
        /// <summary>
        /// 多页时对应字段名
        /// </summary>
        [DataMember]
        public string strMultiColCode { get; set; }
    }
    #endregion

    #region 表单多页属性
    /// <summary>
    /// 表单多页属性
    /// </summary>
    [DataContract, Serializable]
    public class EntityCaseMultiPageRecord : BaseDataContract
    {
        /// <summary>
        /// 住院病人登记ID
        /// </summary>
        [DataMember]
        public int intRegisterID { get; set; }
        /// <summary>
        /// 表单代码
        /// </summary>
        [DataMember]
        public string strCaseCode { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        [DataMember]
        public DateTime dtmRecordDate { get; set; }
        /// <summary>
        /// 状态 0 新建 1 暂存 2 保存
        /// </summary>
        [DataMember]
        public int intStatus { get; set; }
    }
    #endregion

    #region 表格

    #region 病历表格页宏元素页绑定信息
    /// <summary>
    /// 病历表格页宏元素页绑定信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityCasTablePagePatInfoCell : BaseDataContract
    {
        /// <summary>
        /// 字段名
        /// </summary>
        [DataMember]
        public string strDBColCode { get; set; }
        /// <summary>
        /// 字段描述
        /// </summary>
        [DataMember]
        public string strDBColDesc { get; set; }
    }
    #endregion
    
    [DataContract, Serializable]
    public class EntityTableDefInfo : BaseDataContract
    {
        [DataMember]
        public string strTableCode { get; set; }

        [DataMember]
        public int intTableheaderdisplay { get; set; }

        [DataMember]
        public string strTemplatecode { get; set; }

        [DataMember]
        public int intDisplayrows { get; set; }

        [DataMember]
        public string strSortfieldname { get; set; }

        [DataMember]
        public string strTablename { get; set; }

        [DataMember]
        public int intDisplaytype { get; set; }

        [DataMember]
        public string strHeaderwidth { get; set; }

        [DataMember]
        public string strPyCode { get; set; }

        [DataMember]
        public string strWbCode { get; set; }

        [DataMember]
        public int intRowHeight { get; set; }
    }

    [DataContract, Serializable]
    public class EntityTableColDefInfo : BaseDataContract, IComparable
    {
        [DataMember]
        public string strTablecode { get; set; }
        [DataMember]
        public string strBandname { get; set; }
        [DataMember]
        public string strFieldname { get; set; }
        [DataMember]
        public string strFieldcaptain { get; set; }
        [DataMember]
        public int intFieldwidth { get; set; }
        [DataMember]
        public string strFieldtype { get; set; }
        [DataMember]
        public string strFieldconfig { get; set; }
        [DataMember]
        public int intAllownull { get; set; }
        [DataMember]
        public int intSortno { get; set; }
        [DataMember]
        public int intAlloweditaftersave { get; set; }
        [DataMember]
        public int intShowunderline { get; set; }
        [DataMember]
        public int intAutosign { get; set; }
        [DataMember]
        public int intAllmultiline { get; set; }

        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityTableColDefInfo)
            {
                return this.intSortno.CompareTo(((EntityTableColDefInfo)obj).intSortno);
            }
            return 0;
        }
    }
    #endregion

    #region 通用表单
    
    /// <summary>
    /// 通用表单记录VO
    /// </summary>
    [DataContract, Serializable]
    public class EntityEmrData : BaseDataContract
    {
        /// <summary>
        /// 通用表单记录VO.构造
        /// </summary>
        public EntityEmrData()
        {
            this.RegisterId = string.Empty;
            this.TableName = string.Empty;
            this.CaseCode = string.Empty;
            this.TableCode = string.Empty;
            this.RowIndex = 0;
            this.FieldName = string.Empty;
            this.FieldText = string.Empty;
            this.FieldMarkXml = string.Empty;
            this.FieldRtf = null;
            this.FieldPrtRtf = null;
            this.PrintFlag = 0;
            this.RecordDate = DateTime.Now;
        }

        /// <summary>
        /// 住院登记流水ID
        /// </summary>
        [DataMember]
        public string RegisterId { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [DataMember]
        public string TableName { get; set; }

        /// <summary>
        /// 表单名
        /// </summary>
        [DataMember]
        public string CaseCode { get; set; }

        /// <summary>
        /// 内部表格CODE
        /// </summary>
        [DataMember]
        public string TableCode { get; set; }

        /// <summary>
        /// 内部表格行索引
        /// </summary>
        [DataMember]
        public int RowIndex { get; set; }

        /// <summary>
        /// 列名
        /// </summary>
        [DataMember]
        public string FieldName { get; set; }

        /// <summary>
        /// 列Text值
        /// </summary>
        [DataMember]
        public string FieldText { get; set; }

        /// <summary>
        /// 列XML格式值
        /// </summary>
        [DataMember]
        public string FieldMarkXml { get; set; }

        /// <summary>
        /// 列完整Rtf值
        /// </summary>
        [DataMember]
        public byte[] FieldRtf { get; set; }

        /// <summary>
        /// 列打印Rtf值
        /// </summary>
        [DataMember]
        public byte[] FieldPrtRtf { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [DataMember]
        public string ModifierId { get; set; }

        /// <summary>
        /// 打印标识 0 打印Text 1 打印Rtf 2 打图片
        /// </summary>
        [DataMember]
        public int PrintFlag { get; set; }

        /// <summary>
        /// 表格最大行索引
        /// </summary>
        [DataMember]
        public int TabMaxRowIndex { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [DataMember]
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// 病历限制类型 0 不限 1 限科室 2 限医生
        /// </summary>
        [DataMember]
        public int CaseLimitType { get; set; }
    }

    /// <summary>
    /// 通用表单记录痕迹VO
    /// </summary>
    [DataContract, Serializable]
    public class EntityUniversalCaseRecordTrace : BaseDataContract
    {
        /// <summary>
        /// 通用表单记录痕迹VO.构造
        /// </summary>
        public EntityUniversalCaseRecordTrace()
        {
            this.SerNo = 0;
            this.RegisterId = string.Empty;
            this.TableName = string.Empty;
            this.TableCode = string.Empty;
            this.RowIndex = 0;
            this.ColCode = string.Empty;
            this.ColContent = string.Empty;
            this.ColContentXml = string.Empty;
            this.ColContentRtf = null;
            this.ModifierId = string.Empty;
            this.ModifierDate = DateTime.Now;
            this.RecordDate = DateTime.Now;
        }

        /// <summary>
        /// 流水号
        /// </summary>
        [DataMember]
        public int SerNo { get; set; }

        /// <summary>
        /// 住院登记流水ID
        /// </summary>
        [DataMember]
        public string RegisterId { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [DataMember]
        public string TableName { get; set; }

        /// <summary>
        /// 内部表格CODE
        /// </summary>
        [DataMember]
        public string TableCode { get; set; }

        /// <summary>
        /// 内部表格行索引
        /// </summary>
        [DataMember]
        public int RowIndex { get; set; }

        /// <summary>
        /// 列名
        /// </summary>
        [DataMember]
        public string ColCode { get; set; }

        /// <summary>
        /// 列Text值
        /// </summary>
        [DataMember]
        public string ColContent { get; set; }

        /// <summary>
        /// 列XML格式值
        /// </summary>
        [DataMember]
        public string ColContentXml { get; set; }

        /// <summary>
        /// 列完整Rtf值
        /// </summary>
        [DataMember]
        public byte[] ColContentRtf { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [DataMember]
        public string ModifierId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [DataMember]
        public DateTime ModifierDate { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [DataMember]
        public DateTime RecordDate { get; set; }
    }

    /// <summary>
    /// 通用表单图像VO
    /// </summary>
    [DataContract, Serializable]
    public class EntityUniversalCaseImage : BaseDataContract
    {
        /// <summary>
        /// 通用表单图像VO.构造
        /// </summary>
        public EntityUniversalCaseImage()
        {
            this.SerNo = 0;
            this.RegisterId = string.Empty;
            this.CaseCode = string.Empty;
            this.ColCode = string.Empty;
            this.ImageIdXml = string.Empty;
            this.ImageData = null;
        }
        /// <summary>
        /// 流水号
        /// </summary>
        [DataMember]
        public int SerNo { get; set; }
        /// <summary>
        /// 住院登记流水ID
        /// </summary>
        [DataMember]
        public string RegisterId { get; set; }
        /// <summary>
        /// 表单代码(类名或自定义表单ID)
        /// </summary>
        [DataMember]
        public string CaseCode { get; set; }
        /// <summary>
        /// 列名
        /// </summary>
        [DataMember]
        public string ColCode { get; set; }
        /// <summary>
        /// 图像ID.XML值
        /// </summary>
        [DataMember]
        public string ImageIdXml { get; set; }
        /// <summary>
        /// 图像BYTE值
        /// </summary>
        [DataMember]
        public byte[] ImageData { get; set; }
    }

    /// <summary>
    /// 通用表单控件图像VO
    /// </summary>
    [DataContract, Serializable]
    public class EntityUniversalCaseRtbImage : BaseDataContract
    {
        /// <summary>
        /// 图像ID.XML值
        /// </summary>
        [DataMember]
        public string ImageIdXml { get; set; }
        /// <summary>
        /// 图像BYTE值
        /// </summary>
        [DataMember]
        public byte[] ImageData { get; set; }
    }
    /// <summary>
    /// 医学公式VO
    /// </summary>
    [DataContract, Serializable]
    public class EntityMedFormula : BaseDataContract
    {
        /// <summary>
        /// 公式类型
        /// </summary>
        [DataMember]
        public int Type = 0;
        /// <summary>
        /// 数据内容(key-方位标识,value-方位数据) 
        /// </summary>
        [DataMember]
        public Dictionary<int, string> Content = null;
        /// <summary>
        /// 生成的图片
        /// </summary>
        [DataMember]
        public System.Drawing.Image imgResult = null;
    }
    /// <summary>
    /// 查询条件
    /// </summary>
    [DataContract, Serializable]
    public class EntityQueryParameters : BaseDataContract
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [DataMember]
        public string KeyID = string.Empty;
        /// <summary>
        /// 值
        /// </summary>
        [DataMember]
        public string Value = string.Empty;
    }

    #endregion
    
    #region 病历提醒
    /// <summary>
    /// emrRemind
    /// </summary>
    [DataContract, Serializable]
    [EntityAttribute(TableName = "emrRemind")]
    public class EntityEmrRemind : BaseDataContract
    {
        /// <summary>
        /// Serno
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "serno", DbType = DbType.Decimal, IsPK = true, IsSeq = false, SerNo = 1)]
        public System.Decimal serNo { get; set; }

        /// <summary>
        /// Registerid
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "registerid", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 2)]
        public System.String registerId { get; set; }

        /// <summary>
        /// Casecode
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "casecode", DbType = DbType.AnsiString, IsPK = false, IsSeq = false, SerNo = 3)]
        public System.String caseCode { get; set; }

        /// <summary>
        /// Predictdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "predictdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 4)]
        public System.DateTime? predictDate { get; set; }

        /// <summary>
        /// Actualdate
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "actualdate", DbType = DbType.DateTime, IsPK = false, IsSeq = false, SerNo = 5)]
        public System.DateTime? actualDate { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember]
        [EntityAttribute(FieldName = "status", DbType = DbType.Decimal, IsPK = false, IsSeq = false, SerNo = 6)]
        public System.Int32 status { get; set; }

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
            public string registerId = "registerid";
            public string caseCode = "casecode";
            public string predictDate = "predictdate";
            public string actualDate = "actualdate";
            public string status = "status";
        }
    }
    #endregion

    #region 病历保存结构实体

    [DataContract, Serializable]
    public class EntityEmrSave : BaseDataContract
    {
        [DataMember]
        public string RegisterID { get; set; }

        [DataMember]
        public int FormId { get; set; }

        [DataMember]
        public string Version { get; set; }

        [DataMember]
        public string CaseCode { get; set; }

        [DataMember]
        public DateTime? RecordDate { get; set; }

        [DataMember]
        public DateTime RecordDateSys { get; set; }

        [DataMember]
        public DateTime? CaseWriteDate { get; set; }

        [DataMember]
        public bool IsMultiPage { get; set; }

        [DataMember]
        public bool IsSave { get; set; }

        [DataMember]
        public string CreatorId { get; set; }

        //[DataMember]
        //public List<EntityEmrData> CaseDataMain { get; set; }

        [DataMember]
        public List<EntityEmrData> CaseDataNew { get; set; }

        [DataMember]
        public List<EntityEmrData> CaseDataUpdate { get; set; }

        [DataMember]
        public List<EntityEmrData> CaseTableDataNew { get; set; }

        [DataMember]
        public List<EntityEmrData> CaseTableDataUpdate { get; set; }

        [DataMember]
        public List<EntityEmrData> CaseTableDataInsert { get; set; }

        [DataMember]
        public List<EntitySignature> CaseSignature { get; set; }

        [DataMember]
        public List<EntitySignature> CaseTableSignature { get; set; }

        [DataMember]
        public List<EntitySignature> CaseTableSignatureInsert { get; set; }

        //DateTime? p_dtmRecordDate, DateTime p_dtmRecordDateSys, bool p_blnMultiPageFlag, DateTime? p_dtmCaseWriteDate)
        //public int m_intSaveCase(int p_intRegisterID, clsDCUniversalCaseRecord[] p_dcUniversalCaseRecordArr, 
        //clsDCUniversalCaseRecordTrace[] p_dcUniversalCaseRecordTraceArr, clsDCUniversalCaseImage[] p_dcUniversalCaseImageArr, clsDCSignature[] p_dcSignatureArr, bool p_blnSaveFlag, DateTime? p_dtmRecordDate, DateTime p_dtmRecordDateSys, bool p_blnMultiPageFlag, DateTime? p_dtmCaseWriteDate)
        //{

        //public int m_intSaveCase(int p_intCaseSerNo, int p_intRegisterID, string p_strCaseCode, int p_intCreatorID, 
        //List<clsDCUniversalCaseRecord> p_lstCaseMainData, List<clsDCUniversalCaseImage> p_lstImageData, 
        //List<clsDCSignature> p_lstSignatureMain, bool p_blnSaveFlag, List<clsDCUniversalCaseRecord> p_lstTabCaseDataNew,
        //List<clsDCUniversalCaseRecord> p_lstTabCaseDataUpdate, List<clsDCSignature> p_lstTabSignature, List<clsDCUniversalCaseRecord> p_lstTabCaseDataInsert, List<clsDCSignature> p_lstTabSignatureInsert, ref DateTime? p_dtmRecordDate, DateTime? p_dtmCaseWriteDate)
        //{
    }

    #endregion

}
