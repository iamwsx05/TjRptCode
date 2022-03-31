using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Common.Entity;
using weCare.Core.Entity;
using weCare.Core.Itf;
using weCare.Core.Utils;

namespace Common.Itf
{
    /// <summary>
    /// ItfEntityFactory
    /// </summary>
    [ServiceContract]
    public interface ItfEntityFactory : IWcf, IDisposable
    {
        #region 查询
        
        #region 全表查询
        /// <summary>
        /// 全表查询
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [OperationContract(Name = "SelectFullTable")]
        DataTable SelectFullTable(BaseDataContract entity);
        #endregion

        #region 根据主键查询
        /// <summary>
        /// 根据主键查询-1
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [OperationContract(Name = "SelectByPk1")]
        DataTable SelectByPk(BaseDataContract entity);
        /// <summary>
        /// 根据主键查询-2
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstFields"></param>
        /// <returns></returns>
        [OperationContract(Name = "SelectByPk2")]
        DataTable SelectByPk(BaseDataContract entity, List<string> lstFields);
        /// <summary>
        /// 根据主键查询-3
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstFields"></param>
        /// <returns></returns>
        [OperationContract(Name = "SelectByPk3")]
        DataTable SelectByPk(List<BaseDataContract> lstEntity, List<string> lstFields);
        #endregion

        #region 查询:按列、排序、值等否

        [OperationContract(Name = "Select1")]
        DataTable Select(BaseDataContract entity, List<string> lstCols);

        [OperationContract(Name = "Select2")]
        DataTable Select(BaseDataContract entity, List<string> lstCols, string opSign);

        [OperationContract(Name = "Select3")]
        DataTable Select(BaseDataContract entity, List<string> lstFields, List<string> lstCols);

        [OperationContract(Name = "Select4")]
        DataTable Select(BaseDataContract entity, List<string> lstCols, string opSign, List<string> lstSorts);

        [OperationContract(Name = "Select5")]
        DataTable Select(BaseDataContract entity, List<string> lstFields, List<string> lstCols, List<string> lstSorts);

        [OperationContract(Name = "SelectSort1")]
        DataTable SelectSort(BaseDataContract entity, List<string> lstCols, List<string> lstSorts);

        [OperationContract(Name = "SelectSort2")]
        DataTable SelectSort(BaseDataContract entity, List<string> lstCols, string opSign, List<string> lstSorts);

        [OperationContract(Name = "SelectFields1")]
        DataTable SelectFields(BaseDataContract entity, List<string> lstFields);

        [OperationContract(Name = "SelectFields2")]
        DataTable SelectFields(BaseDataContract entity, List<string> lstFields, List<string> lstSorts);

        #endregion

        #endregion

        #region 插入

        /// <summary>
        /// 插入.单条
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [OperationContract(Name = "Insert1")]
        int Insert(BaseDataContract entity);

        /// <summary>
        /// 插入.多条
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <returns></returns>
        [OperationContract(Name = "Insert2")]
        int Insert(List<BaseDataContract> lstEntity);

        #endregion

        #region 删除

        #region 根据主键删除
        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [OperationContract(Name = "DeleteByPk1")]
        int DeleteByPk(BaseDataContract entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [OperationContract(Name = "DeleteByPk2")]
        int DeleteByPk(List<BaseDataContract> lstEntity);
        #endregion

        #region 根据条件删除
        /// <summary>
        /// 根据条件删除-1
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        [OperationContract(Name = "DeleteByParm1")]
        int DeleteByParm(BaseDataContract entity, string where);

        /// <summary>
        /// 根据条件删除-2
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        [OperationContract(Name = "DeleteByParm2")]
        int DeleteByParm(List<BaseDataContract> lstEntity, string where);

        /// <summary>
        /// 根据条件删除-3
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        [OperationContract(Name = "DeleteByParm3")]
        int DeleteByParm(BaseDataContract entity, List<string> lstWhere);

        /// <summary>
        /// 根据条件删除-4
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        [OperationContract(Name = "DeleteByParm4")]
        int DeleteByParm(List<BaseDataContract> lstEntity, List<string> lstWhere);
        #endregion

        #endregion

        #region 更新

        #region 根据主键更新
        /// <summary>
        /// 根据主键更新-1
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateByPk1")]
        int UpdateByPk(BaseDataContract entity);
        /// <summary>
        /// 根据主键更新-2
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateByPk2")]
        int UpdateByPk(List<BaseDataContract> lstEntity);
        /// <summary>
        /// 根据主键更新-3
        /// </summary>
        /// <param name="entityNew"></param>
        /// <param name="entityOrg"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateByPk3")]
        int UpdateByPk(BaseDataContract entityNew, BaseDataContract entityOrg);
        /// <summary>
        /// 根据主键更新-4
        /// </summary>
        /// <param name="lstEntityNew"></param>
        /// <param name="lstEntityOrg"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateByPk4")]
        int UpdateByPk(List<BaseDataContract> lstEntityNew, List<BaseDataContract> lstEntityOrg);

        #endregion

        #region 通过更新列、条件列 Dictionary

        /// <summary>
        /// 通过更新列、条件列 Dictionary -1
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="dicSet"></param>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateByParm1")]
        int UpdateByParm(BaseDataContract entity, Dictionary<string, object> dicSet, Dictionary<string, object> dicWhere);

        /// <summary>
        /// 通过更新列、条件列 Dictionary -2
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="dicSet"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateByParm2")]
        int UpdateByParm(BaseDataContract entity, Dictionary<string, object> dicSet, List<Dictionary<string, object>> lstWhere);

        /// <summary>
        /// 通过更新列、条件列 Dictionary -3
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="lstSet"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateByParm3")]
        int UpdateByParm(BaseDataContract entity, List<Dictionary<string, object>> lstSet, List<Dictionary<string, object>> lstWhere);

        #endregion
        #endregion
    }
}
