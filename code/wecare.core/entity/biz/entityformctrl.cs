using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// 控件实体
    /// </summary>
    [Serializable, DataContract]
    public class EntityFormCtrl : BaseDataContract, IComparable
    {
        //[DataMember]
        //public int AppFID { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public string ItemType { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public string ItemCaption { get; set; }

        [DataMember]
        public string ItemFeeCode { get; set; }

        [DataMember]
        public string RCode { get; set; }

        [DataMember]
        public string GroupName { get; set; }

        [DataMember]
        public string SumName { get; set; }

        [DataMember]
        public string ControlName { get; set; }

        [DataMember]
        public string ControlType { get; set; }

        [DataMember]
        public int Height { get; set; }

        [DataMember]
        public int Width { get; set; }

        [DataMember]
        public int Top { get; set; }

        [DataMember]
        public int Bottom { get; set; }

        [DataMember]
        public int Left { get; set; }

        [DataMember]
        public int Right { get; set; }

        [DataMember]
        public int LineWidth { get; set; }

        [DataMember]
        public string LineStyle { get; set; }

        [DataMember]
        public string Checked { get; set; }

        [DataMember]
        public string PicFileName { get; set; }

        [DataMember]
        public string BodyExamStyle { get; set; }

        [DataMember]
        public string ImageType { get; set; }

        [DataMember]
        public string ParentNode { get; set; }

        /// <summary>
        /// 前景色
        /// </summary>
        [DataMember]
        public Color ForeColor
        {
            get
            {
                try
                {
                    ColorConverter cc = new ColorConverter();
                    Color c = (Color)cc.ConvertFromString(this.ForeColorText);
                    return c;
                }
                catch
                {
                    return Color.Transparent;
                }
            }
            set
            {
                ColorConverter cc = new ColorConverter();
                this.ForeColorText = cc.ConvertToString(value);
            }
        }

        /// <summary>
        /// 前景色存储值
        /// </summary>
        [DataMember]
        public string ForeColorText { get; set; }

        /// <summary>
        /// 背景色
        /// </summary>
        [DataMember]
        public Color BackColor
        {
            get
            {
                try
                {
                    ColorConverter cc = new ColorConverter();
                    Color c = (Color)cc.ConvertFromString(this.BackColorText);
                    return c;
                }
                catch
                {
                    return Color.White;
                }
            }
            set
            {
                ColorConverter cc = new ColorConverter();
                this.BackColorText = cc.ConvertToString(value);
            }
        }

        /// <summary>
        /// 背景色存储值
        /// </summary>
        [DataMember]
        public string BackColorText { get; set; }

        /// <summary>
        /// 文本字体
        /// </summary>
        [DataMember]
        public string TextFont { get; set; }

        /// <summary>
        /// 父控件
        /// </summary>
        [DataMember]
        public string Parent { get; set; }

        /// <summary>
        /// 父项目
        /// </summary>
        [DataMember]
        public string ItemParent { get; set; }

        /// <summary>
        /// 项目值(下拉控件项目列表)
        /// </summary>
        [DataMember]
        public string Items { get; set; }

        /// <summary>
        /// 计算属性 
        /// </summary>
        [DataMember]
        public string CalProperty { get; set; }

        /// <summary>
        /// 行缩进字符数
        /// </summary>
        [DataMember]
        public int RowShrinkDigit { get; set; }

        /// <summary>
        ///  引用类型
        /// </summary>
        [DataMember]
        public int ReferenceType { get; set; }

        /// <summary>
        /// (是否)必填项
        /// </summary>
        [DataMember]
        public int Essential { get; set; }

        /// <summary>
        /// 是否自动签名
        /// </summary>
        [DataMember]
        public int IsAutoSignature { get; set; }

        /// <summary>
        /// 是否允许空签名
        /// </summary>
        [DataMember]
        public int IsAllowSignNull { get; set; }

        /// <summary>
        /// 默认行数
        /// </summary>
        [DataMember]
        public int DefaultRows { get; set; }

        /// <summary>
        /// 表现层模式
        /// </summary>
        [DataMember]
        public int PresentationMode { get; set; }

        /// <summary>
        /// Tab顺序号
        /// </summary>
        [DataMember]
        public int TabIndex { get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        [DataMember]
        public string ReserveField { get; set; }

        /// <summary>
        /// 勾选计算值
        /// </summary>
        [DataMember]
        public decimal CheckedWeightValue { get; set; }

         bool _ReadPatientInfoFromGolbolEnv = true;

        /// <summary>
        /// 从全局对象获取病人宏元素信息
        /// </summary>
        [DataMember]
        public bool ReadPatientInfoFromGolbolEnv 
        {
            get { return _ReadPatientInfoFromGolbolEnv; }
            set { _ReadPatientInfoFromGolbolEnv = value; }
        }

        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityFormCtrl)
            {
                return this.Top.CompareTo(((EntityFormCtrl)obj).Top);
            }
            return 0;
        }
    }

    #region EntityNodeCtrl
    /// <summary>
    /// EntityNodeCtrl
    /// </summary>
    [Serializable, DataContract]
    public class EntityNodeCtrl : BaseDataContract, IComparable
    {
        [DataMember]
        public string ParentName { get; set; }
        [DataMember]
        public string FieldName { get; set; }
        [DataMember]
        public string value { get; set; }
        [DataMember]
        public int TabIndex { get; set; }
        [DataMember]
        public bool IsCdata { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is EntityNodeCtrl)
            {
                return this.TabIndex.CompareTo(((EntityNodeCtrl)obj).TabIndex);
            }
            return 0;
        }
    }
    #endregion
}
