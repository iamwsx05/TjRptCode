using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weCare.Core.Entity;
using weCare.Core.Utils;
using Common.Entity;
using Common.Biz;

namespace Common.Svc
{
    /// <summary>
    /// SvcCommon
    /// </summary>
    public class SvcEntityFactory : Common.Itf.ItfEntityFactory
    {
        #region 查询
        
        #region 全表查询
        /// <summary>
        /// 全表查询
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataTable SelectFullTable(BaseDataContract entity)
        {
            using (BizEntityFactory biz = new BizEntityFactory())
            {
                return biz.SelectFullTable(entity);
            }
        }
        #endregion

        #region 根据主键查询
        /// <summary>
        /// 根据主键查询-1
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public DataTable SelectByPk(BaseDataContract entity)
        {
            return SelectByPk(entity, null);
        }
        /// <summary>
        /// 根据主键查询-2
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstFields"></param>
        /// <returns></returns>
        public DataTable SelectByPk(BaseDataContract entity, List<string> lstFields)
        {
            return SelectByPk(new List<BaseDataContract> { entity }, lstFields);
        }
        /// <summary>
        /// 根据主键查询-3
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstFields"></param>
        /// <returns></returns>
        public DataTable SelectByPk(List<BaseDataContract> lstEntity, List<string> lstFields)
        {
            using (BizEntityFactory biz = new BizEntityFactory())
            {
                return biz.SelectByPk(lstEntity, lstFields);
            }
        }
        #endregion

        #region 查询:按列、排序、值等否

        public DataTable Select(BaseDataContract entity, List<string> lstCols)
        {
            return Select(entity, null, lstCols, string.Empty, null);
        }

        public DataTable Select(BaseDataContract entity, List<string> lstCols, string opSign)
        {
            return Select(entity, null, lstCols, opSign, null);
        }

        public DataTable Select(BaseDataContract entity, List<string> lstFields, List<string> lstCols)
        {
            return Select(entity, lstFields, lstCols, string.Empty, null);
        }

        public DataTable Select(BaseDataContract entity, List<string> lstCols, string opSign, List<string> lstSorts)
        {
            return Select(entity, null, lstCols, opSign, lstSorts);
        }

        public DataTable Select(BaseDataContract entity, List<string> lstFields, List<string> lstCols, List<string> lstSorts)
        {
            return Select(entity, lstFields, lstCols, string.Empty, lstSorts);
        }

        public DataTable SelectSort(BaseDataContract entity, List<string> lstCols, List<string> lstSorts)
        {
            return Select(entity, null, lstCols, string.Empty, lstSorts);
        }

        public DataTable SelectSort(BaseDataContract entity, List<string> lstCols, string opSign, List<string> lstSorts)
        {
            return Select(entity, null, lstCols, opSign, lstSorts);
        }

        public DataTable SelectFields(BaseDataContract entity, List<string> lstFields)
        {
            return Select(entity, lstFields, null, string.Empty, null);
        }

        public DataTable SelectFields(BaseDataContract entity, List<string> lstFields, List<string> lstSorts)
        {
            return Select(entity, lstFields, null, string.Empty, lstSorts);
        }

        DataTable Select(BaseDataContract entity, List<string> lstFields, List<string> lstCols, string opSign, List<string> lstSortCols)
        {
            using (BizEntityFactory biz = new BizEntityFactory())
            {
                return biz.Select(entity, lstFields, lstCols, opSign, lstSortCols);
            }
        }
        #endregion

        #endregion

        #region 插入

        #region 单条
        /// <summary>
        /// 插入.单条
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Insert(BaseDataContract entity)
        {
            return Insert(new List<BaseDataContract> { entity });
        }
        #endregion

        #region 多条
        /// <summary>
        /// 插入.多条
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <returns></returns>
        public int Insert(List<BaseDataContract> lstEntity)
        {
            using (BizEntityFactory biz = new BizEntityFactory())
            {
                return biz.Insert(lstEntity);
            }
        }
        #endregion

        #endregion

        #region 删除

        #region 根据主键删除
        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int DeleteByPk(BaseDataContract entity)
        {
            return DeleteByPk(new List<BaseDataContract> { entity });
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int DeleteByPk(List<BaseDataContract> lstEntity)
        {
            using (BizEntityFactory biz = new BizEntityFactory())
            {
                return biz.DeleteByPk(lstEntity);
            }
        }
        #endregion

        #region 根据条件删除
        /// <summary>
        /// 根据条件删除-1
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public int DeleteByParm(BaseDataContract entity, string where)
        {
            return DeleteByParm(new List<BaseDataContract> { entity }, new List<string> { where });
        }
        /// <summary>
        /// 根据条件删除-2
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public int DeleteByParm(List<BaseDataContract> lstEntity, string where)
        {
            return DeleteByParm(lstEntity, new List<string> { where });
        }
        /// <summary>
        /// 根据条件删除-3
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public int DeleteByParm(BaseDataContract entity, List<string> lstWhere)
        {
            return DeleteByParm(new List<BaseDataContract> { entity }, lstWhere);
        }
        /// <summary>
        /// 根据条件删除-4
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public int DeleteByParm(List<BaseDataContract> lstEntity, List<string> lstWhere)
        {
            using (BizEntityFactory biz = new BizEntityFactory())
            {
                return biz.DeleteByParm(lstEntity, lstWhere);
            }
        }
        #endregion

        #endregion

        #region 更新

        #region 根据主键更新
        /// <summary>
        /// 根据主键更新-1
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int UpdateByPk(BaseDataContract entity)
        {
            return UpdateByPk(new List<BaseDataContract> { entity });
        }
        /// <summary>
        /// 根据主键更新-2
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <returns></returns>
        public int UpdateByPk(List<BaseDataContract> lstEntity)
        {
            return UpdateByPk(lstEntity, lstEntity);
        }
        /// <summary>
        /// 根据主键更新-3
        /// </summary>
        /// <param name="entityNew"></param>
        /// <param name="entityOrg"></param>
        /// <returns></returns>
        public int UpdateByPk(BaseDataContract entityNew, BaseDataContract entityOrg)
        {
            return UpdateByPk(new List<BaseDataContract> { entityNew }, new List<BaseDataContract> { entityOrg });
        }
        /// <summary>
        /// 根据主键更新-4
        /// </summary>
        /// <param name="lstEntityNew"></param>
        /// <param name="lstEntityOrg"></param>
        /// <returns></returns>
        public int UpdateByPk(List<BaseDataContract> lstEntityNew, List<BaseDataContract> lstEntityOrg)
        {
            using (BizEntityFactory biz = new BizEntityFactory())
            {
                return biz.UpdateByPk(lstEntityNew, lstEntityOrg);
            }
        }
        #endregion

        #region 通过更新列、条件列 Dictionary
        /// <summary>
        /// 通过更新列、条件列 Dictionary -1
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="dicSet"></param>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        public int UpdateByParm(BaseDataContract entity, Dictionary<string, object> dicSet, Dictionary<string, object> dicWhere)
        {
            return UpdateByParm(entity, new List<Dictionary<string, object>> { dicSet }, new List<Dictionary<string, object>> { dicWhere });
        }
        /// <summary>
        /// 通过更新列、条件列 Dictionary -2
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="dicSet"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public int UpdateByParm(BaseDataContract entity, Dictionary<string, object> dicSet, List<Dictionary<string, object>> lstWhere)
        {
            List<Dictionary<string, object>> lstTmp = new List<Dictionary<string, object>>();
            for (int i = 0; i < lstWhere.Count; i++)
            {
                lstTmp.Add(Function.CloneByBinary(dicSet) as Dictionary<string, object>);
            }
            return UpdateByParm(entity, lstTmp, lstWhere);
        }
        /// <summary>
        /// 通过更新列、条件列 Dictionary -3
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstSet"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public int UpdateByParm(BaseDataContract entity, List<Dictionary<string, object>> lstSet, List<Dictionary<string, object>> lstWhere)
        {
            using (BizEntityFactory biz = new BizEntityFactory())
            {
                return biz.UpdateByParm(entity, lstSet, lstWhere);
            }
        }
        #endregion

        #endregion

        #region Verify
        /// <summary>
        /// Verify
        /// </summary>
        /// <returns></returns>
        public bool Verify()
        { return true; }
        #endregion

        #region IDispose
        /// <summary>
        /// IDispose
        /// </summary>
        public void Dispose()
        { GC.SuppressFinalize(this); }
        #endregion
    }
}
