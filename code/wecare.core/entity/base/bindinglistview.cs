using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace weCare.Core.Entity
{
    /// <summary>
    /// BindingListView 过滤与排序(绑定实体.单Field)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class BindingListView<T> : BindingList<T>, IBindingListView, ITypedList
    {
        #region 构造

        private bool IsColSort { get; set; }

        /// <summary>
        /// BindingListView
        /// </summary>
        public BindingListView()
        {
            //PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(typeof(T), new Attribute[] { new BrowsableAttribute(true) });
            //PropertyCollection = pdc;
        }
        /// <summary>
        /// BindingListView
        /// </summary>
        /// <param name="isColSort">是否列排序</param>
        public BindingListView(bool _isColSort)
            : this()
        {
            //PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(typeof(T), new Attribute[] { new BrowsableAttribute(true) });
            //PropertyCollection = (isColSort ? pdc.Sort() : pdc);
            IsColSort = _isColSort;
        }

        #endregion

        #region New

        public new void Add(T o)
        {
            base.Add(o);
            LookUpItemSource.Add(o);
            Pdc(o);
        }

        public void AddRange(IList<T> lstT)
        {
            base.Clear();
            foreach (T vo in lstT)
            {
                base.Add(vo);
            }
            LookUpItemSource.Clear();
            LookUpItemSource.AddRange(lstT);

            if (lstT != null && lstT.Count > 0)
            {
                Pdc(lstT[0]);
            }
        }

        public void AppendRange(IList<T> lstT)
        {
            foreach (T vo in lstT)
            {
                base.Add(vo);
            }
            if (lstT != null && lstT.Count > 0)
            {
                Pdc(lstT[0]);
            }
        }

        private void Pdc(T o)
        {
            // 获取子类型实例,否则为空.( typeof(T) -> o.GetType()))
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(o.GetType(), new Attribute[] { new BrowsableAttribute(true) });
            PropertyCollection = (IsColSort ? pdc.Sort() : pdc);
        }

        public new void Clear()
        {
            base.Clear();
            LookUpItemSource.Clear();
        }

        public new void Remove(T o)
        {
            RemoveItemSource.Add(o);
            base.Remove(o);
        }

        public new void RemoveAt(int index)
        {
            RemoveItemSource.Add(Items[index]);
            base.RemoveAt(index);
        }

        public new void RemoveItem(int index)
        {
            RemoveItemSource.Add(Items[index]);
            base.RemoveItem(index);
        }

        #endregion

        #region 变量.属性

        private List<PropertyComparer<T>> comparers;

        [NonSerialized]
        private PropertyDescriptorCollection PropertyCollection;

        /// <summary>
        /// 源数据(过滤控件使用)
        /// </summary>
        public List<T> LookUpItemSource = new List<T>();

        /// <summary>
        /// Remove数据源
        /// </summary>
        public List<T> RemoveItemSource = new List<T>();

        /// <summary>
        /// 一直显示内容（不过滤）
        /// </summary>
        public string AllwaysContentCol = string.Empty;
        /// <summary>
        /// 一直显示内容列（不过滤）
        /// </summary>
        public string[] AllwaysContentVal = new string[] { "" };

        /// <summary>
        /// 过滤列
        /// </summary>
        public string[] FilterColumns { get; set; }

        #endregion

        #region Sorting

        private bool isSorted;
        private ListSortDirection sortDirection;
        private PropertyDescriptor sortProperty;

        protected override bool IsSortedCore
        {
            get { return isSorted; }
        }

        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get { return sortDirection; }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get { return sortProperty; }
        }

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            var items = Items as List<T>;

            if (items != null)
            {
                var pc = new PropertyComparer<T>(property, direction);
                items.Sort(pc);
                isSorted = true;
            }
            else
            {
                isSorted = false;
            }

            sortProperty = property;
            sortDirection = direction;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            isSorted = false;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public void Sort(string fieldName, ListSortDirection direction)
        {
            if (Items == null || Items.Count == 0) return;
            ApplySortCore(PropertyCollection[fieldName], direction);
        }

        #endregion

        #region Searching

        protected override bool SupportsSearchingCore
        {
            get { return true; }
        }

        protected override int FindCore(PropertyDescriptor property, object key)
        {
            if (property == null) return -1;

            var items = Items as List<T>;
            if (items != null)
            {
                foreach (T item in items)
                {
                    string value = property.GetValue(item).ToString();
                    if (key.ToString() == value) return IndexOf(item);
                }
            }
            return -1;
        }

        #endregion

        #region IBindingListView 成员

        public void ApplySort(ListSortDescriptionCollection sorts)
        {
            var items = Items as List<T>;
            if (items != null)
            {
                SortDescriptions = sorts;
                comparers = new List<PropertyComparer<T>>();
                foreach (ListSortDescription sort in sorts)
                    comparers.Add(new PropertyComparer<T>(sort.PropertyDescriptor, sort.SortDirection));
                items.Sort(CompareValuesByProperties);
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        //缓存属性,避免反复用反射取得类型,可以略微提高一点效率
        List<PropertyInfo> lstPropertyInfo = new List<PropertyInfo>();

        /// <summary>
        /// 自定义过滤(改为private.暂停使用)
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="filterExp"></param>
        private void SetFilter(string fieldName, string filterExp)
        {
            // 暂定: 必须制定列
            if (string.IsNullOrEmpty(fieldName))
            {
                return;
            }

            base.Clear();
            int rowCount = 0;
            bool isExist = false;
            PropertyInfo propertyInfo = null;
            PropertyInfo propertyInfoAls = null;
            object propertyValueAls = null;
            object propertyValue = null;
            foreach (T item in LookUpItemSource)
            {
                if (lstPropertyInfo.Count == 0)
                {
                    propertyInfo = item.GetType().GetProperty(fieldName);
                    if (propertyInfo != null)
                    {
                        lstPropertyInfo.Add(propertyInfo);
                    }
                    else
                    {
                        continue;
                    }
                }
                isExist = false;
                propertyInfoAls = item.GetType().GetProperty(AllwaysContentCol);
                propertyValueAls = null;
                if (propertyInfoAls != null)
                {
                    propertyValueAls = propertyInfoAls.GetValue(item, null);
                }

                if (AllwaysContentCol != "" && propertyInfoAls != null && propertyValueAls != null && AllwaysContentVal.Contains(propertyValueAls.ToString().ToLower()))
                {
                    isExist = true;
                }

                if (!isExist)
                {
                    foreach (PropertyInfo pinfo in lstPropertyInfo)
                    {
                        propertyValue = null;
                        propertyValue = pinfo.GetValue(item, null);
                        if (propertyValue != null && propertyValue.ToString().ToLower().Contains(filterExp.ToLower()))
                        {
                            isExist = true;
                            break;
                        }
                    }
                }
                if (isExist && this.Contains(item) == false)
                {
                    if (rowCount == 0) break;   // 过滤显示暂定100条记录。
                    base.Add(item);
                    rowCount++;
                }
            }
        }

        private string _Filter = string.Empty;

        /// <summary>
        /// 过滤(接口)
        /// </summary>
        public string Filter
        {
            get { return _Filter; }
            set
            {
                _Filter = value;
                if (FilterColumns == null || FilterColumns.Length == 0) return;
                base.Clear();
                int rowCount = 0;
                bool isExist = false;
                PropertyInfo propertyInfo = null;
                PropertyInfo propertyInfoAls = null;
                object propertyValueAls = null;
                object propertyValue = null;
                foreach (T item in LookUpItemSource)
                {
                    if (lstPropertyInfo.Count == 0)
                    {
                        foreach (string col in FilterColumns)
                        {
                            propertyInfo = item.GetType().GetProperty(col);
                            if (propertyInfo != null)
                            {
                                lstPropertyInfo.Add(propertyInfo);
                            }
                        }
                    }

                    isExist = false;
                    propertyInfoAls = item.GetType().GetProperty(AllwaysContentCol);
                    propertyValueAls = null;
                    if (propertyInfoAls != null)
                    {
                        propertyValueAls = propertyInfoAls.GetValue(item, null);
                    }

                    if (AllwaysContentCol != "" && propertyInfoAls != null && propertyValueAls != null && AllwaysContentVal.Contains(propertyValueAls.ToString().ToLower()))
                    {
                        isExist = true;
                    }

                    if (isExist == false)
                    {
                        foreach (PropertyInfo property in lstPropertyInfo)
                        {
                            propertyValue = property.GetValue(item, null);
                            if (propertyValue != null && propertyValue.ToString().ToLower().Contains(value.ToLower()))
                            {
                                isExist = true;
                                break;
                            }
                        }
                    }
                    if (isExist && this.Contains(item) == false)
                    {
                        if (rowCount == 300) break; // 过滤显示暂定300条记录。
                        base.Add(item);
                        rowCount++;
                    }
                }
            }
        }

        public void Reset()
        {
            RemoveFilter();
        }

        public void RemoveFilter()
        {
            base.Clear();
            foreach (T item in LookUpItemSource)
            {
                base.Add(item);
            }
        }

        public ListSortDescriptionCollection SortDescriptions { get; set; }

        public bool SupportsAdvancedSorting
        {
            get { return true; }
        }

        public bool SupportsFiltering
        {
            get { return true; }
        }

        private int CompareValuesByProperties(T x, T y)
        {
            if (x == null)
                return (y == null) ? 0 : -1;
            if (y == null)
                return 1;
            foreach (var comparer in comparers)
            {
                int retval = comparer.Compare(x, y);
                if (retval != 0)
                    return retval;
            }
            return 0;
        }

        #endregion

        #region ITypedList 成员

        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            PropertyDescriptorCollection pdc;

            if (null == listAccessors)
            {
                pdc = PropertyCollection;
            }
            else
            {
                pdc = System.Windows.Forms.ListBindingHelper.GetListItemProperties(listAccessors[0].PropertyType);
            }

            return pdc;
        }

        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return typeof(T).Name;
        }

        #endregion
    }

    /// <summary>
    /// 属性比较
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PropertyComparer<T> : IComparer<T>
    {
        private ListSortDirection _direction;
        private PropertyDescriptor _property;

        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            _property = property;
            _direction = direction;
        }

        /// <summary>
        /// 比较方法
        /// </summary>
        /// <param name="x">相对属性x</param>
        /// <param name="y">相对属性y</param>
        /// <returns></returns>
        #region IComparer<T>

        public int Compare(T xWord, T yWord)
        {
            object xValue = GetPropertyValue(xWord, _property.Name);
            object yValue = GetPropertyValue(yWord, _property.Name);

            if (_direction == ListSortDirection.Ascending)
            {
                return CompareAscending(xValue, yValue);
            }
            return CompareDescending(xValue, yValue);
        }

        public bool Equals(T xWord, T yWord)
        {
            return xWord.Equals(yWord);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        #endregion

        private int CompareAscending(object xValue, object yValue)
        {
            int result;

            if (xValue is IComparable)
            {
                result = ((IComparable)xValue).CompareTo(yValue);
            }
            else if (xValue == null || xValue.Equals(yValue))
            {
                result = 0;
            }
            else
            {
                result = xValue.ToString().CompareTo(yValue.ToString());
            }
            return result;
        }

        private int CompareDescending(object xValue, object yValue)
        {
            return CompareAscending(xValue, yValue) * -1;
        }

        private object GetPropertyValue(T value, string property)
        {
            PropertyInfo propertyInfo = value.GetType().GetProperty(property);
            return propertyInfo.GetValue(value, null);
        }
    }
}
