using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    [DataContract, Serializable]
    [KnownType("GetTypes")]
    public abstract class BaseDataContract : INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// 类型缓存
        /// </summary>
        static Type[] TypesCache = null;

        #region 可用数据契约类型
        /// <summary>
        /// 可用数据契约类型
        /// </summary>
        /// <returns></returns>
        static Type[] GetTypes()
        {
            if (TypesCache != null)
            {
                return TypesCache;
            }
            else
            {
                //查找系统所有实体文件
                List<Type> lstTypes = new List<Type>();
                Assembly objAssem = null;
                Type[] objTypeArr = null;
                List<FileInfo> lstFInfos = new List<FileInfo>();
                DirectoryInfo objDir = null;

                string strPath1 = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
                string strPath2 = System.AppDomain.CurrentDomain.BaseDirectory + "bin\\";

                if (Directory.Exists(strPath1)) objDir = new DirectoryInfo(strPath1);
                else if (Directory.Exists(strPath2)) objDir = new DirectoryInfo(strPath2);
                else return null;

                FileInfo[] objInfoArr1 = objDir.GetFiles("wecare.core.dll");
                if (objInfoArr1 != null) lstFInfos.AddRange(objInfoArr1);
                FileInfo[] objInfoArr2 = objDir.GetFiles("*.entity.dll");
                if (objInfoArr2 != null) lstFInfos.AddRange(objInfoArr2);

                string strFullName = string.Empty;
                foreach (FileInfo file in lstFInfos)
                {
                    objAssem = null;
                    objTypeArr = null;
                    strFullName = file.FullName;
                    try
                    {
                        objAssem = Assembly.LoadFrom(strFullName);
                    }
                    catch { }

                    if (objAssem != null)
                    {
                        try
                        { objTypeArr = objAssem.GetTypes(); }
                        catch { }
                    }
                    if (objTypeArr != null)
                    {
                        foreach (Type type in objTypeArr)
                        {
                            if (type.BaseType == typeof(BaseDataContract) && !lstTypes.Contains(type))
                            {
                                lstTypes.Add(type);
                            }
                        }
                    }
                }

                TypesCache = lstTypes.ToArray();
                return TypesCache;
            }
        }
        #endregion

        /// <summary>
        /// 属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 属性改变
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (null != PropertyChanged)
            {
                PropertyChanged(this, e);
            }
        }

        /// <summary>
        /// 字段数
        /// </summary>
        protected int FieldCount
        {
            get
            {
                return this.GetType().GetProperties().Length;
            }
        }

        /// <summary>
        /// 自身克隆对象
        /// </summary>
        public object CloneObject { get; set; }

        /// <summary>
        /// 是否修改
        /// </summary>
        public bool IsModify { get; set; }

        #region 字段/属性+值
        /// <summary>
        /// copy 字段/属性+值
        /// </summary>
        //private Dictionary<string, object> _CopyFieldObject = null;

        /// <summary>
        /// copy 字段/属性+值
        /// </summary>
        public Dictionary<string, object> CopyFieldObject
        {
            //get { return _CopyFieldObject; }
            //set { _CopyFieldObject = value; }
            get;
            set;
        }

        /// <summary>
        /// new 字段/属性+值
        /// </summary>
        //private Dictionary<string, object> _NewFieldObject = null;

        /// <summary>
        /// new 字段/属性+值
        /// </summary>
        public Dictionary<string, object> NewFieldObject
        {
            //get { return _NewFieldObject; }
            //set { _NewFieldObject = value; }
            get;
            set;
        }

        public void CopyOriginalValue()
        {
            CopyValue(1);
        }

        public void CopyNewValue()
        {
            CopyValue(2);
        }

        /// <summary>
        /// 复制字段/属性+值
        /// </summary>
        private void CopyValue(int type)
        {
            if (type == 1)
            {
                //_CopyFieldObject = new Dictionary<string, object>();
                CopyFieldObject = new Dictionary<string, object>();
            }
            else if (type == 2)
            {
                //_NewFieldObject = new Dictionary<string, object>();
                NewFieldObject = new Dictionary<string, object>();
            }
            System.Reflection.MemberInfo[] memberCollection = this.GetType().GetMembers();
            foreach (System.Reflection.MemberInfo member in memberCollection)
            {
                if (member.Name == "CopyFieldObject" || member.Name == "_CopyFieldObject" ||
                    member.Name == "NewFieldObject" || member.Name == "_NewFieldObject" ||
                    member.Name == "IsModify" || member.Name == "CloneObject" ||
                    member.Name == "Columns") continue;
                if (member.MemberType == System.Reflection.MemberTypes.Field)
                {
                    if (type == 1)
                    {
                        //_CopyFieldObject.Add(member.Name, ((System.Reflection.FieldInfo)member).GetValue(this));
                        CopyFieldObject.Add(member.Name, ((System.Reflection.FieldInfo)member).GetValue(this));
                    }
                    else if (type == 2)
                    {
                        //_NewFieldObject.Add(member.Name, ((System.Reflection.FieldInfo)member).GetValue(this));
                        NewFieldObject.Add(member.Name, ((System.Reflection.FieldInfo)member).GetValue(this));
                    }
                }
                else if (member.MemberType == System.Reflection.MemberTypes.Property)
                {
                    if (type == 1)
                    {
                        //_CopyFieldObject.Add(member.Name, ((System.Reflection.PropertyInfo)member).GetValue(this, null));
                        CopyFieldObject.Add(member.Name, ((System.Reflection.PropertyInfo)member).GetValue(this, null));
                    }
                    else if (type == 2)
                    {
                        //_NewFieldObject.Add(member.Name, ((System.Reflection.PropertyInfo)member).GetValue(this, null));
                        NewFieldObject.Add(member.Name, ((System.Reflection.PropertyInfo)member).GetValue(this, null));
                    }
                }
            }
        }
        #endregion

        #region Clone

        /// <summary>
        /// 克隆对象，并返回一个已克隆对象的引用
        /// </summary>
        /// <returns>引用新的克隆对象</returns>
        public object Clone()
        {
            //首先建立指定类型的一个实例
            object newObject = Activator.CreateInstance(this.GetType());
            //取得新的类型实例的字段数组。
            FieldInfo[] fields = newObject.GetType().GetFields();

            int i = 0;
            foreach (FieldInfo fi in this.GetType().GetFields())
            {
                //判断字段是否支持ICloneable接口。
                Type ICloneType = fi.FieldType.GetInterface("ICloneable", true);
                if (ICloneType != null)
                {

                    //取得对象的Icloneable接口。
                    ICloneable IClone = (ICloneable)fi.GetValue(this);

                    //使用克隆方法给字段设定新值。
                    fields[i].SetValue(newObject, IClone.Clone());
                }
                else
                {
                    // 如果该字段部支持Icloneable接口，直接设置即可。
                    fields[i].SetValue(newObject, fi.GetValue(this));
                }

                //检查该对象是否支持IEnumerable接口，如果支持还需要枚举其所有项并检查他们是否支持IList 或 IDictionary 接口.              
                Type IEnumerableType = fi.FieldType.GetInterface("IEnumerable", true);
                if (IEnumerableType != null)
                {
                    //取得该字段的IEnumerable接口
                    IEnumerable IEnum = (IEnumerable)fi.GetValue(this);
                    Type IListType = fields[i].FieldType.GetInterface("IList", true);
                    Type IDicType = fields[i].FieldType.GetInterface("IDictionary", true);

                    int j = 0;
                    if (IListType != null)
                    {
                        //取得IList接口。
                        IList list = (IList)fields[i].GetValue(newObject);
                        foreach (object obj in IEnum)
                        {
                            //查看当前项是否支持支持ICloneable 接口。
                            ICloneType = obj.GetType().GetInterface("ICloneable", true);
                            if (ICloneType != null)
                            {
                                //如果支持ICloneable 接口，用它设置列表中的对象的克隆
                                ICloneable clone = (ICloneable)obj;
                                list[j] = clone.Clone();
                            }

                            //注意：如果列表中的项不支持ICloneable接口，那么在克隆列表的项将与原列表对应项相同（只要该类型是引用类型）                           
                            j++;
                        }
                    }

                    else if (IDicType != null)
                    {
                        //取得IDictionary 接口
                        IDictionary dic = (IDictionary)fields[i].GetValue(newObject);

                        j = 0;
                        foreach (DictionaryEntry de in IEnum)
                        {
                            //查看当前项是否支持支持ICloneable 接口。
                            ICloneType = de.Value.GetType().
                            GetInterface("ICloneable", true);
                            if (ICloneType != null)
                            {
                                ICloneable clone = (ICloneable)de.Value;
                                dic[de.Key] = clone.Clone();
                            }
                            j++;

                        }
                    }
                }
                i++;
            }

            PropertyInfo[] propers = this.GetType().GetProperties();
            foreach (PropertyInfo proper in propers)
            {
                System.Reflection.MethodInfo info = proper.GetSetMethod(false);
                if (info != null)
                {
                    object propertyValue = proper.GetValue(this, null);
                    if (propertyValue is ICloneable)
                    {
                        proper.SetValue(newObject, (propertyValue as ICloneable).Clone(), null);
                    }
                    else
                    {
                        try
                        {
                            proper.SetValue(newObject, Subclone(propertyValue), null);
                        }
                        catch { }
                    }
                }
            }

            return newObject;
        }

        private object Subclone(object obj)
        {
            if (obj == null) return null;

            Object targetDeepCopyObj;
            Type targetType = obj.GetType();
            //值类型
            if (targetType.IsValueType == true)
            {
                targetDeepCopyObj = obj;
            }
            //引用类型 
            else
            {
                targetDeepCopyObj = System.Activator.CreateInstance(targetType);   //创建引用对象 
                System.Reflection.MemberInfo[] memberCollection = obj.GetType().GetMembers();

                foreach (System.Reflection.MemberInfo member in memberCollection)
                {
                    if (member.MemberType == System.Reflection.MemberTypes.Field)
                    {
                        System.Reflection.FieldInfo field = (System.Reflection.FieldInfo)member;
                        Object fieldValue = field.GetValue(obj);
                        if (fieldValue is ICloneable)
                        {
                            field.SetValue(targetDeepCopyObj, (fieldValue as ICloneable).Clone());
                        }
                        else
                        {
                            field.SetValue(targetDeepCopyObj, Subclone(fieldValue));
                        }
                    }
                    else if (member.MemberType == System.Reflection.MemberTypes.Property)
                    {
                        System.Reflection.PropertyInfo myProperty = (System.Reflection.PropertyInfo)member;
                        System.Reflection.MethodInfo info = myProperty.GetSetMethod(false);
                        if (info != null)
                        {
                            object propertyValue = myProperty.GetValue(obj, null);
                            if (propertyValue is ICloneable)
                            {
                                myProperty.SetValue(targetDeepCopyObj, (propertyValue as ICloneable).Clone(), null);
                            }
                            else
                            {
                                myProperty.SetValue(targetDeepCopyObj, Subclone(propertyValue), null);
                            }
                        }

                    }
                }
            }
            return targetDeepCopyObj;
        }
        #endregion
    }

    public class ConstValue
    {
        public static float[] DashPattern
        {
            get
            {
                return new float[] { 2.0F, 2.0F };
            }
        }
    }
}
