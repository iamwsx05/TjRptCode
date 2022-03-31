using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    #region 修改用户信息
    /// <summary>
    /// 修改用户信息
    /// </summary>
    public class EntityModifyUser : IComparable
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyDate;
        /// <summary>
        /// 比较
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityModifyUser)
            {
                return this.ModifyDate.CompareTo(((EntityModifyUser)obj).ModifyDate);
            }
            return 0;
        }
    }
    /// <summary>
    /// 修改用户信息
    /// </summary>
    public class EntityModifyUserInfo
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName;
        /// <summary>
        /// 文本颜色
        /// </summary>
        public Color ColorText;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyDate;
        /// <summary>
        /// 用户索引
        /// </summary>
        public int UserSequence;
    }
    #endregion

    #region 用户修改内容范围
    /// <summary>
    /// 用户修改内容范围
    /// </summary>
    public class EntityUserContentInfo : IComparable
    {
        /// <summary>
        /// 修改用户信息
        /// </summary>
        public EntityModifyUserInfo UserInfo = null;
        /// <summary>
        /// 内容开始索引
        /// </summary>
        public int StartIndex;
        /// <summary>
        /// 内容结束索引
        /// </summary>
        public int EndIndex;
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID;
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName;
        /// <summary>
        /// 用户索引
        /// </summary>
        public int UserSequence;
        /// <summary>
        /// 文本颜色
        /// </summary>
        public Color ColorText;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyDate;
        /// <summary>
        /// 比较
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityUserContentInfo)
            {
                return this.StartIndex.CompareTo(((EntityUserContentInfo)obj).StartIndex);
            }
            return 0;
        }
    }
    #endregion

    #region 医学术语
    /// <summary>
    /// 医学术语
    /// </summary>
    public class EntityMedicalTerm : IComparable
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int StartIndex = 0;
        /// <summary>
        /// 结束位置
        /// </summary>
        public int EndIndex = 0;
        /// <summary>
        /// 颜色
        /// </summary>
        public Color ColorTerm = Color.Black; //Color.FromArgb(50, 60, 250);
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID = string.Empty;
        /// <summary>
        /// 用户名

        /// </summary>
        public string UserName = string.Empty;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime;

        /// <summary>
        /// 表单CASECODE
        /// </summary>
        public string CaseCode = string.Empty;

        /// <summary>
        /// 模板ID
        /// </summary>
        public string TID = string.Empty;
        /// <summary>
        /// 内容
        /// </summary>
        public string Value = string.Empty;
        /// <summary>
        /// 术语类型 0 普通 1 自定义
        /// </summary>
        public int Type = 0;

        /// <summary>
        /// 分类
        /// </summary>
        public int ClassID { get; set; }

        /// <summary>
        /// 是否改变了颜色
        /// </summary>
        public bool IsChangeColor { get; set; }

        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityMedicalTerm)
            {
                return this.StartIndex.CompareTo(((EntityMedicalTerm)obj).StartIndex);
            }
            return 0;
        }
    }
    #endregion

    #region 双划线信息

    /// <summary>
    /// 预览信息
    /// </summary>
    public class EntityView
    {
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public int Index { get; set; }
    }

    /// <summary>
    /// 双划线信息
    /// </summary>
    public class EntityDstInfo : IComparable
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int StartIndex = 0;
        /// <summary>
        /// 结束位置
        /// </summary>
        public int EndIndex = 0;
        /// <summary>
        /// 颜色
        /// </summary>
        public Color ColorDst = Color.Red;
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName;
        /// <summary>
        /// 序号
        /// </summary>
        public int UserSequence;
        /// <summary>
        /// 内容
        /// </summary>
        public string Value = string.Empty;
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime DeleteTime;
        /// <summary>
        /// 克隆
        /// </summary>
        /// <returns></returns>
        public EntityDstInfo Clone()
        {
            EntityDstInfo objDST = new EntityDstInfo();
            objDST.StartIndex = this.StartIndex;
            objDST.EndIndex = this.EndIndex;
            objDST.ColorDst = this.ColorDst;
            objDST.UserID = this.UserID;
            objDST.UserName = this.UserName;
            objDST.UserSequence = this.UserSequence;
            objDST.DeleteTime = this.DeleteTime;
            objDST.Value = this.Value;
            return objDST;
        }
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityDstInfo)
            {
                return this.StartIndex.CompareTo(((EntityDstInfo)obj).StartIndex);
            }
            return 0;
        }
    }
    #endregion

    #region 图片
    /// <summary>
    /// 图片
    /// </summary>
    public class EntityImageInfo : IComparable
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int StartIndex = 0;
        /// <summary>
        /// 结束位置
        /// </summary>
        public int EndIndex = 0;
        /// <summary>
        /// 图片ID
        /// </summary>
        public string ImageID = string.Empty;
        /// <summary>
        /// 图片Rtf800
        /// </summary>
        public string ImageRtf = string.Empty;
        /// <summary>
        /// 图片字节
        /// </summary>
        public byte[] ImageArr = null;
        /// <summary>
        /// 图片序号
        /// </summary>
        public string ImageNO = string.Empty;
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID = string.Empty;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName = string.Empty;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime;
        /// <summary>
        /// 处理标志
        /// </summary>
        public bool DealFlag = false;
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityImageInfo)
            {
                return this.StartIndex.CompareTo(((EntityImageInfo)obj).StartIndex);
            }
            return 0;
        }
    }
    #endregion

    #region 临时数据
    /// <summary>
    /// 临时数据
    /// </summary>
    public class EntityTempData : IComparable
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int StartIndex = 0;
        /// <summary>
        /// 结束位置
        /// </summary>
        public int EndIndex = 0;
        /// <summary>
        /// 长度
        /// </summary>
        public int Len = 0;
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityTempData)
            {
                return this.StartIndex.CompareTo(((EntityTempData)obj).StartIndex);
            }
            return 0;
        }
    }
    #endregion

    #region 上下标信息
    /// <summary>
    /// 上下标信息
    /// </summary>
    public class EntitySuperSubScript : IComparable
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int Index = 0;
        /// <summary>
        /// 偏移量
        /// </summary>
        public int CharOffset = 0;
        /// <summary>
        /// 内容
        /// </summary>
        public string Value;
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntitySuperSubScript)
            {
                return this.Index.CompareTo(((EntitySuperSubScript)obj).Index);
            }
            return 0;
        }
    }
    #endregion

    #region 字体其他属性

    /// <summary>
    /// 颜色
    /// </summary>
    public class EntityFontColor : IComparable
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int Index = 0;
        /// <summary>
        /// 颜色
        /// </summary>
        public Color ColorValue = Color.Black;
        /// <summary>
        /// 内容
        /// </summary>
        public string TxtValue = string.Empty;
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityFontColor)
            {
                return this.Index.CompareTo(((EntityFontColor)obj).Index);
            }
            return 0;
        }
    }

    /// <summary>
    /// 粗体
    /// </summary>
    public class EntityFontBold : IComparable
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int Index = 0;
        /// <summary>
        /// 内容
        /// </summary>
        public string Value = string.Empty;
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityFontBold)
            {
                return this.Index.CompareTo(((EntityFontBold)obj).Index);
            }
            return 0;
        }
    }

    /// <summary>
    /// 斜体
    /// </summary>
    public class EntityFontItalic : IComparable
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int Index = 0;
        /// <summary>
        /// 内容
        /// </summary>
        public string Value = string.Empty;
        public int CompareTo(object obj)
        {
            if (obj is EntityFontItalic)
            {
                return this.Index.CompareTo(((EntityFontItalic)obj).Index);
            }
            return 0;
        }
    }

    /// <summary>
    /// 下划线
    /// </summary>
    public class EntityFontUnderLine : IComparable
    {
        /// <summary>
        /// 起始位置
        /// </summary>
        public int Index = 0;
        /// <summary>
        /// 内容
        /// </summary>
        public string Value = string.Empty;
        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityFontUnderLine)
            {
                return this.Index.CompareTo(((EntityFontUnderLine)obj).Index);
            }
            return 0;
        }
    }
    #endregion

    public class EntityDragRichItem
    {
        string dragString;
        List<EntityMedicalTerm> dragMedicalTerm;

        /// <summary>
        /// 表单CASECODE
        /// </summary>
        public string CaseCode { get; set; }

        /// <summary>
        /// 列CODE
        /// </summary>
        public string ColCode { get; set; }

        /// <summary>
        /// 拖动文本
        /// </summary>
        public string DragString
        {
            get { return dragString; }
            set { dragString = value; }
        }

        /// <summary>
        /// 拖动元素
        /// </summary>
        public List<EntityMedicalTerm> DragMedicalTerm
        {
            get { return dragMedicalTerm; }
            set { dragMedicalTerm = value; }
        }
    }

    /// <summary>
    /// 智能引用项目
    /// </summary>
    public class EntityIntellectiveRefItem
    {
        /// <summary>
        /// 表单CODE
        /// </summary>
        public string CaseCode { get; set; }
        /// <summary>
        ///字段CODE
        /// </summary>
        public string ColCode { get; set; }
        /// <summary>
        /// 字段名
        /// </summary>
        public string ColName { get; set; }
    }

    #region RTF控件图像信息
    /// <summary>
    /// RTF控件图像信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityRtfImage : BaseDataContract
    {
        /// <summary>
        /// 索引号
        /// </summary>
        [DataMember]
        public int Index { get; set; }
        /// <summary>
        /// 图像信息
        /// </summary>
        [DataMember]
        public System.Drawing.Image Image { get; set; }
    }
    #endregion

    #region 全局病历信息
    /// <summary>
    /// 全局病历信息
    /// </summary>
    [DataContract, Serializable]
    public class EntityCaseInfo : BaseDataContract
    {
        [DataMember]
        public int FormId { get; set; }

        [DataMember]
        public int Version { get; set; }

        /// <summary>
        /// 表单代码(类名或自定义表单ID)
        /// </summary>
        [DataMember]
        public string CaseCode = null;
        /// <summary>
        /// 表单名称
        /// </summary>
        [DataMember]
        public string FormName = null;
        /// <summary>
        /// 创建人ID
        /// </summary>
        [DataMember]
        public int? CreatorID = null;
        /// <summary>
        /// 创建时间
        /// </summary>
        [DataMember]
        public DateTime? CreateDate = null;
        /// <summary>
        /// 创建人技术职称
        /// </summary>
        [DataMember]
        public string TechLevelCode = null;

        /// <summary>
        /// 行政职务代码
        /// </summary>
        [DataMember]
        public string AdminLevelCode { get; set; }

        /// <summary>
        /// 通用记录分类ID 0 默认 1 病程 2 会诊通知
        /// </summary>
        [DataMember]
        public int CommTypeID = 0;
        /// <summary>
        /// 通用记录ID
        /// </summary>
        [DataMember]
        public int? CommID = null;
        /// <summary>
        /// 创建人姓名
        /// </summary>
        [DataMember]
        public string CreatorName { get; set; }
        /// <summary>
        /// 暂存人ID
        /// </summary>
        [DataMember]
        public int? TmpSaveOperID = null;
        /// <summary>
        /// 暂存人姓名
        /// </summary>
        [DataMember]
        public string TmpSaveOperName = null;
        /// <summary>
        /// 暂存时间
        /// </summary>
        [DataMember]
        public DateTime? TmpSaveOperDate = null;

        /// <summary>
        /// 书写书写状态 0 新建 1 暂存 2 保存
        /// </summary>
        [DataMember]
        public int CaseStatus { get; set; }

        /// <summary>
        /// 是否显示病历状态 0 不显示 1 显示
        /// </summary>
        [DataMember]
        public int ShowCaseStatus { get; set; }

        /// <summary>
        /// 数据业务表
        /// </summary>
        [DataMember]
        public string TableName { get; set; }
        /// <summary>
        /// 痕迹表
        /// </summary>
        [DataMember]
        public string TraceName { get; set; }
        /// <summary>
        /// 打印模板名称
        /// </summary>
        [DataMember]
        public string PrintTemplateName { get; set; }

        /// <summary>
        /// 表单样式 0 普通表单 1 表格表单
        /// </summary>
        [DataMember]
        public int CaseStyle { get; set; }

        /// <summary>
        /// 多页标志
        /// </summary>
        [DataMember]
        public int CaseMultiFlag { get; set; }

        /// <summary>
        /// 多页字段
        /// </summary>
        [DataMember]
        public string CaseMultiColCode { get; set; }

        /// <summary>
        /// 签名信息列表
        /// </summary>
        [DataMember]
        public List<EntitySignatureSimple> Signature { get; set; }

        /// <summary>
        /// 记录时间
        /// </summary>
        [DataMember]
        public DateTime? RecordDate = null;

        /// <summary>
        /// 病历限制类型 0 不限 1 限科室 2 限医生
        /// </summary>
        int _CaseLimitType = 0;
        /// <summary>
        /// 病历限制类型 0 不限 1 限科室 2 限医生
        /// </summary>
        [DataMember]
        public int CaseLimitType
        {
            get { return _CaseLimitType; }
            set { _CaseLimitType = value; }
        }

        /// <summary>
        /// 当前页号
        /// </summary>
        [DataMember]
        public int CurrentPageNo { get; set; }

        /// <summary>
        /// PnID
        /// </summary>
        [DataMember]
        public decimal PnID { get; set; }

        /// <summary>
        /// 自定义表单版本号
        /// </summary>
        [DataMember]
        public string CustomformVersions { get; set; }

        /// <summary>
        /// 打印模板版本号
        /// </summary>
        [DataMember]
        public string PrinttemplateVersions { get; set; }

        /// <summary>
        /// 病历锁定状态
        /// </summary>
        [DataMember]
        public int CaseLockStatus { get; set; }

        [DataMember]
        public string EmpNo { get; set; }
               

    }
    #endregion

    #region 签名信息简类
    /// <summary>
    /// 签名信息简类
    /// </summary>
    [DataContract, Serializable]
    public class EntitySignatureSimple : BaseDataContract
    {
        /// <summary>
        /// 员工ID
        /// </summary>
        [DataMember]
        public int EmpID { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        [DataMember]
        public string EmpName { get; set; }
        /// <summary>
        /// 签名时间
        /// </summary>
        [DataMember]
        public DateTime SignatureDate { get; set; }

        [DataMember]
        public string EmpNo { get; set; }
    }
    #endregion

    /// <summary>
    /// 全局病历类
    /// </summary>
    public class GlobalCase
    {
        /// <summary>
        /// 病历信息
        /// </summary>
        public static EntityCaseInfo caseInfo = null;
    }
    /// <summary>
    /// 全局richtext变量
    /// </summary>
    public class GlobalRichTextParm
    {
        public static string Parm7 { get; set; }
        public static string Parm41 { get; set; }
        public static string Parm74 { get; set; }
        public static string LoginID { get; set; }
    }
}
