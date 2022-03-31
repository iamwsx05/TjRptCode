using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace weCare.Core.Entity
{
    #region 实体工具
    /// <summary>
    /// 实体工具
    /// </summary>
    public class EntityTools
    {
        #region 方法
        /// <summary>
        /// 获取属性-Table
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static EntityAttribute GetAttribute(Type type)
        {
            try
            {
                return (EntityAttribute)type.GetCustomAttributes(typeof(EntityAttribute), false)[0];
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 获取属性-Field
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static EntityAttribute GetAttribute(PropertyInfo property)
        {
            try
            {
                return (EntityAttribute)property.GetCustomAttributes(typeof(EntityAttribute), false)[0];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取属性-Table
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        internal static EntityAttribute GetTableAttribute(BaseDataContract objEntity)
        {
            try
            {
                return GetAttribute(objEntity.GetType());
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取属性-Field
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static EntityAttribute GetFieldAttribute(BaseDataContract objEntity, string fieldName)
        {
            try
            {
                PropertyInfo[] objPropertyArr = objEntity.GetType().GetProperties();
                return (EntityAttribute)(objPropertyArr.FirstOrDefault(t => t.Name.ToLower() == fieldName.ToLower())).GetCustomAttributes(typeof(EntityAttribute), false)[0];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取表名
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        public static string GetTableName(BaseDataContract objEntity)
        {
            return EntityTools.GetTableAttribute(objEntity).TableName;
        }

        /// <summary>
        /// 获取属性-Field.Name
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static string GetFieldName(BaseDataContract objEntity, string fieldName)
        {
            try
            {
                PropertyInfo[] objPropertyArr = objEntity.GetType().GetProperties();
                return ((EntityAttribute)(objPropertyArr.FirstOrDefault(t => t.Name.ToLower() == fieldName.ToLower())).GetCustomAttributes(typeof(EntityAttribute), false)[0]).FieldName;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取属性-Field.Value
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static object GetFieldValue(BaseDataContract objEntity, string fieldName)
        {
            PropertyInfo property = GetFieldProperty(objEntity, fieldName);
            if (property != null)
            {
                return property.GetValue(objEntity, null);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取属性-Field
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        internal static PropertyInfo GetFieldProperty(BaseDataContract objEntity, string fieldName)
        {
            try
            {
                PropertyInfo[] objPropertyArr = objEntity.GetType().GetProperties();
                return objPropertyArr.FirstOrDefault(t => t.Name.ToLower() == fieldName.ToLower());
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取属性-Field
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static PropertyInfo GetFieldProperty(BaseDataContract objEntity, EntityAttribute obj)
        {
            try
            {
                PropertyInfo[] objPropertyArr = objEntity.GetType().GetProperties();
                EntityAttribute attri = null;
                foreach (var item in objPropertyArr)
                {
                    attri = EntityTools.GetAttribute(item);
                    if (attri != null && attri.FieldName.ToLower() == obj.FieldName.ToLower())
                    {
                        return item;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取属性-PK.Field(带排序)
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        public static List<EntityAttribute> GetFieldAttributePk(BaseDataContract objEntity)
        {
            return GetFieldAttribute(objEntity, 1);
        }

        /// <summary>
        /// 获取属性-Seq.Field(带排序)
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        internal static List<EntityAttribute> GetFieldAttributeSeq(BaseDataContract objEntity)
        {
            return GetFieldAttribute(objEntity, 2);
        }

        /// <summary>
        /// 获取实体数组
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="flag">1 主键 2 自增</param>
        /// <returns></returns>
        private static List<EntityAttribute> GetFieldAttribute(BaseDataContract objEntity, int flag)
        {
            try
            {
                List<EntityAttribute> lstAttri = new List<EntityAttribute>();
                PropertyInfo[] objPropertyArr = objEntity.GetType().GetProperties();

                EntityAttribute attri = null;
                foreach (var item in objPropertyArr)
                {
                    attri = EntityTools.GetAttribute(item);
                    if (attri != null)
                    {
                        if (flag == 1 && attri.IsPK)
                        {
                            lstAttri.Add(attri);
                        }
                        else if (flag == 2 && attri.IsSeq)
                        {
                            lstAttri.Add(attri);
                        }
                    }
                }
                if (lstAttri != null && lstAttri.Count > 0)
                {
                    lstAttri.Sort();
                }
                return lstAttri;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取属性-所有Field(带排序)
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        public static List<EntityAttribute> GetFieldAttribute(BaseDataContract objEntity)
        {
            try
            {
                List<EntityAttribute> lstAttri = new List<EntityAttribute>();
                PropertyInfo[] objPropertyArr = objEntity.GetType().GetProperties();

                EntityAttribute attri = null;
                foreach (var item in objPropertyArr)
                {
                    attri = EntityTools.GetAttribute(item);
                    if (attri != null)
                    {
                        lstAttri.Add(attri);
                    }
                }
                if (lstAttri != null && lstAttri.Count > 0)
                {
                    lstAttri.Sort();
                }
                return lstAttri;
            }
            catch
            {
                return null;
            }
        }

        #region 获取实体字段类型
        /// <summary>
        /// 获取实体字段类型
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        public static EntityFieldAttribute[] GetEntityFieldAttri(BaseDataContract objEntity)
        {
            EntityFieldAttribute fieldAttri = null;
            List<EntityFieldAttribute> lstFieldAttri = new List<EntityFieldAttribute>();
            PropertyInfo[] propertyInfo = objEntity.GetType().GetProperties();
            foreach (PropertyInfo item in propertyInfo)
            {
                fieldAttri = new EntityFieldAttribute();
                fieldAttri.FieldName = item.Name;
                fieldAttri.FieldType = Nullable.GetUnderlyingType(item.PropertyType) ?? item.PropertyType;
                lstFieldAttri.Add(fieldAttri);
            }
            return lstFieldAttri.ToArray();
        }
        #endregion
        #endregion

        #region 实体-表 互转
        /// <summary>
        /// 表转实体
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static TEntity ConvertToEntity<TEntity>(System.Data.DataTable dataTable)
        {
            List<TEntity> data = EntityTools.ConvertToEntityList<TEntity>(dataTable);
            if (data != null && data.Count > 0)
                return data[0];
            else
                return default(TEntity);
        }

        /// <summary>
        /// 表转实体
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<TEntity> ConvertToEntityList<TEntity>(System.Data.DataTable dataTable)
        {
            List<TEntity> list = new List<TEntity>();
            if (dataTable == null || dataTable.Rows.Count == 0) return list;
            // 创建行转换器
            TableEntityBuilder<TEntity> builder = TableEntityBuilder<TEntity>.CreateBuilder(dataTable);
            // 遍历每一行进行转换
            foreach (DataRow dr in dataTable.Rows)
            {
                list.Add(builder.Build(dr));
            }
            return list;
        }
        /// <summary>
        /// 实体转表
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ConvertToDataTable<TEntity>(List<TEntity> list)
        {
            PropertyInfo[] props = typeof(TEntity).GetProperties();

            #region 构造DataTable

            if (list == null) return null;
            DataTable table = new DataTable();
            foreach (PropertyInfo prop in props)
            {
                //判断是否为可空类型nullable
                Type nullUnderlyingType = Nullable.GetUnderlyingType(prop.PropertyType);

                //Nullable.GetUnderlyingType不为空即为可空类型
                Type unboxType = nullUnderlyingType != null ? nullUnderlyingType : prop.PropertyType;

                table.Columns.Add(prop.Name, unboxType);
            }
            #endregion

            //遍历实体中的每一个元素
            foreach (TEntity entity in list)
            {
                DataRow row = table.NewRow();

                //遍历实体的所有Property
                foreach (PropertyInfo prop in props)
                {
                    string fieldName = prop.Name;

                    object value = prop.GetValue(entity, null);

                    //Table的单元格是不能填充null值，null值需要转为DBNull
                    if (value == null)
                    {
                        row[fieldName] = DBNull.Value;
                    }
                    else
                    {
                        row[fieldName] = value;
                    }
                }
                table.Rows.Add(row);
            }
            return table;
        }

        #endregion

    }

    #region TableEntityBuilder
    /// <summary>
    /// TableEntityBuilder
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class TableEntityBuilder<T>
    {
        private delegate T Load(DataRow row);
        private Load handler;//最终执行动态方法的一个委托 参数是DataRow接口
        private static readonly MethodInfo getValueMethod = typeof(DataRow).GetMethod("get_Item", new Type[] { typeof(string) });
        private static readonly MethodInfo isDBNullMethod = typeof(DataRow).GetMethod("IsNull", new Type[] { typeof(int) });

        public T Build(DataRow row)
        {
            return handler(row);//执行CreateBuilder里创建的DynamicCreate动态方法的委托
        }

        //数据类型和对应的强制转换方法的methodinfo，供实体属性赋值时调用
        private static Dictionary<Type, MethodInfo> ConvertMethods = new Dictionary<Type, MethodInfo>()
        {
           {typeof(int),typeof(Convert).GetMethod("ToInt32",new Type[]{typeof(object)})},
           {typeof(Decimal),typeof(Convert).GetMethod("ToDecimal",new Type[]{typeof(object)})},
           {typeof(Double),typeof(Convert).GetMethod("ToDouble",new Type[]{typeof(object)})},
           {typeof(Boolean),typeof(Convert).GetMethod("ToBoolean",new Type[]{typeof(object)})},
        };

        public static TableEntityBuilder<T> CreateBuilder(DataTable table)//, PropertyInfo[] props)
        {
            PropertyInfo[] props = typeof(T).GetProperties();
            DataTable parentTable = table;
            TableEntityBuilder<T> dynamicBuilder = new TableEntityBuilder<T>();
            //定义一个名为DynamicCreate的动态方法，返回值typof(T)，参数typeof(DataRow)
            DynamicMethod method = new DynamicMethod("DynamicCreate", typeof(T), new Type[] { typeof(DataRow) }, typeof(T), true);
            ILGenerator generator = method.GetILGenerator();//创建一个MSIL生成器，为动态方法生成代码
            LocalBuilder result = generator.DeclareLocal(typeof(T));//声明指定类型的局部变量 可以T t;这么理解
            //T t=new T() 构造实体实例
            generator.Emit(OpCodes.Newobj, typeof(T).GetConstructor(Type.EmptyTypes));
            generator.Emit(OpCodes.Stloc, result);

            for (int i = 0; i < parentTable.Columns.Count; i++)
            {
                PropertyInfo pInfo = null;
                string fieldName = string.Empty;

                foreach (PropertyInfo p in props)
                {
                    EntityAttribute[] attrs = (EntityAttribute[])p.GetCustomAttributes(typeof(EntityAttribute), true);
                    if (attrs.Length > 0 && attrs[0].FieldName.ToLower() == parentTable.Columns[i].ColumnName.ToLower())
                    {
                        pInfo = p;
                        fieldName = attrs[0].FieldName;
                        break;
                    }
                    else if (p.Name.ToLower() == parentTable.Columns[i].ColumnName.ToLower())
                    {
                        pInfo = p;
                        fieldName = p.Name;
                        break;
                    }
                }

                System.Reflection.Emit.Label endIfLabel = generator.DefineLabel();
                //实体存在该属性 且该属性有SetMethod方法
                if (pInfo != null && pInfo.GetSetMethod() != null)
                {
                    generator.Emit(OpCodes.Ldarg_0);
                    generator.Emit(OpCodes.Ldc_I4, i);
                    generator.Emit(OpCodes.Callvirt, isDBNullMethod);//调用IsDBNull方法 如果IsDBNull==true contine
                    generator.Emit(OpCodes.Brtrue, endIfLabel);

                    /*If the value in the data reader is not null, the code sets the value on the object.*/
                    generator.Emit(OpCodes.Ldloc, result);
                    generator.Emit(OpCodes.Ldarg_0);
                    generator.Emit(OpCodes.Ldstr, fieldName);
                    generator.Emit(OpCodes.Callvirt, getValueMethod);//调用get_Item方法

                    Type memberType = pInfo.PropertyType;
                    Type nullUnderlyingType = Nullable.GetUnderlyingType(memberType);
                    Type unboxType = nullUnderlyingType != null ? nullUnderlyingType : memberType;

                    if (unboxType == typeof(byte[]) || unboxType == typeof(string))
                    {
                        generator.Emit(OpCodes.Castclass, memberType);
                    }
                    else
                    {
                        if (unboxType == typeof(int) || unboxType == typeof(double) || unboxType == typeof(decimal))// || unboxType == typeof(decimal?))
                        {
                            generator.Emit(OpCodes.Call, ConvertMethods[unboxType]);
                        }
                        else
                        {
                            generator.Emit(OpCodes.Unbox_Any, parentTable.Columns[i].DataType);
                            //if (nullUnderlyingType != null)
                            //{
                            //    generator.Emit(OpCodes.Newobj, memberType.GetConstructor(new[] { nullUnderlyingType }));
                            //}
                        }
                        if (nullUnderlyingType != null)
                        {
                            generator.Emit(OpCodes.Newobj, memberType.GetConstructor(new[] { nullUnderlyingType }));
                        }
                    }
                    generator.Emit(OpCodes.Callvirt, pInfo.GetSetMethod());//给该属性设置对应值
                    generator.MarkLabel(endIfLabel);
                }
            }

            generator.Emit(OpCodes.Ldloc, result);//加载返回结果到
            generator.Emit(OpCodes.Ret);//方法结束，返回

            //完成动态方法的创建，并且创建执行该动态方法的委托，赋值到全局变量handler,handler在Build方法里Invoke
            dynamicBuilder.handler = (Load)method.CreateDelegate(typeof(Load));
            return dynamicBuilder;
        }
    }

    #endregion

    #endregion


}
