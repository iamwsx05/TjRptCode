using Common.Entity;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Common.Biz
{
    /// <summary>
    /// 实体工厂Biz
    /// </summary>
    public class BizEntityFactory : IDisposable
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
            DataTable dt = null;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                dt = svc.Select(entity);
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return dt;
        }
        #endregion

        #region 根据主键查询
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstFields"></param>
        /// <returns></returns>
        public DataTable SelectByPk(List<BaseDataContract> lstEntity, List<string> lstFields)
        {
            DataTable dt = null;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                dt = svc.SelectPk(lstEntity.ToArray(), lstFields);
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return dt;
        }
        #endregion

        #region 查询:按列、排序、值等否
        /// <summary>
        /// 查询:按列、排序、值等否
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstFields"></param>
        /// <param name="lstCols"></param>
        /// <param name="opSign"></param>
        /// <param name="lstSortCols"></param>
        /// <returns></returns>
        internal DataTable Select(BaseDataContract entity, List<string> lstFields, List<string> lstCols, string opSign, List<string> lstSortCols)
        {
            DataTable dt = null;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                dt = svc.Select(entity, lstFields, lstCols, opSign, lstSortCols);
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return dt;
        }
        #endregion

        #endregion

        #region 插入
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <returns></returns>
        public int Insert(List<BaseDataContract> lstEntity)
        {
            int intRet = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                intRet = svc.Commit(svc.GetInsertParm(lstEntity.ToArray()));
            }
            catch (Exception ex)
            {
                intRet = -1;
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return intRet;
        }
        #endregion

        #region 删除

        #region 根据主键删除
        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int DeleteByPk(List<BaseDataContract> lstEntity)
        {
            int intRet = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                intRet = svc.Commit(svc.GetDelParmByPk(lstEntity.ToArray()));
            }
            catch (Exception ex)
            {
                intRet = -1;
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return intRet;
        }
        #endregion

        #region 根据条件删除
        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public int DeleteByParm(List<BaseDataContract> lstEntity, List<string> lstWhere)
        {
            int intRet = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                intRet = svc.Commit(svc.GetDelParm(lstEntity.ToArray(), lstWhere));
            }
            catch (Exception ex)
            {
                intRet = -1;
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return intRet;
        }
        #endregion

        #endregion

        #region 更新

        #region 根据主键更新
        /// <summary>
        /// 根据主键更新
        /// </summary>
        /// <param name="lstEntityNew"></param>
        /// <param name="lstEntityOrg"></param>
        /// <returns></returns>
        public int UpdateByPk(List<BaseDataContract> lstEntityNew, List<BaseDataContract> lstEntityOrg)
        {
            int intRet = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                intRet = svc.Commit(svc.GetUpdateParmByPk(lstEntityNew.ToArray(), lstEntityOrg.ToArray()));
            }
            catch (Exception ex)
            {
                intRet = -1;
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            { 
                svc = null;
            }
            return intRet;
        }
        #endregion

        #region 通过更新列、条件列 Dictionary
        /// <summary>
        /// 通过更新列、条件列 Dictionary
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstSet"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public int UpdateByParm(BaseDataContract entity, List<Dictionary<string, object>> lstSet, List<Dictionary<string, object>> lstWhere)
        {
            int intRet = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                intRet = svc.Commit(svc.GetUpdateParm(entity, lstSet, lstWhere));
            }
            catch (Exception ex)
            {
                intRet = -1;
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return intRet;
        }
        #endregion

        #endregion

        #region Dispose
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
