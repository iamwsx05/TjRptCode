using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// 实体属性(标签)
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class EntityAttribute : System.Attribute, IComparable
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 字段名
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public DbType DbType { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 是否自增长
        /// </summary>
        public bool IsGenerator { get; set; }
        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsPK { set; get; }
        /// <summary>
        /// 是否允许为空
        /// </summary>
        public bool IsNull { set; get; }
        /// <summary>
        /// DB字段序号
        /// </summary>
        public int SerNo { get; set; }
        /// <summary>
        /// 自增标识
        /// </summary>
        public bool IsSeq { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is EntityAttribute)
            {
                return this.SerNo.CompareTo(((EntityAttribute)obj).SerNo);
            }
            return 0;
        }
    }

    /// <summary>
    /// 实体字段属性
    /// </summary>
    public class EntityFieldAttribute
    {
        /// <summary>
        /// 字段类型
        /// </summary>
        public Type FieldType { get; set; }
        /// <summary>
        /// 字段名
        /// </summary>
        public string FieldName { get; set; }
    }

    /// <summary>
    /// 通用树Column
    /// </summary>
    [DataContract, Serializable]
    public class CommViewColumn
    {
        /// <summary>
        /// FieldName
        /// </summary>
        [DataMember]
        public string FieldName { get; set; }
        /// <summary>
        /// Caption
        /// </summary>
        [DataMember]
        public string Caption { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        public int Width { get; set; }

    }

    public enum EnumSkinName
    {
        Caramel,
        Money_Twins,
        Lilian,
        The_Asphalt_World,
        iMaginary,
        Black,
        Blue,
        DevExpress_Style,
        DevExpress_Dark_Style,
        Sharp
    }
}
