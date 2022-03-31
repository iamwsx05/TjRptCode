using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Common.Entity;
using weCare.Core.Entity;
using weCare.Core.Itf;
using weCare.Core.Utils;

namespace Console.Itf
{
    [ServiceContract]
    public interface ItfFormDesign : IWcf, IDisposable
    {
        #region 表单
        /// <summary>
        /// 获取.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="formVo"></param>
        [OperationContract(Name = "GetForm1")]
        void GetForm(int formId, out EntityFormDesign formVo);

        /// <summary>
        /// 获取.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="version"></param>
        /// <param name="formVo"></param>
        [OperationContract(Name = "GetForm2")]
        void GetForm(int formId, int version, out EntityFormDesign formVo);

        /// <summary>
        /// 获取.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetForm3")]
        List<EntityFormDesign> GetForm(int formId);

        /// <summary>
        /// 保存.电子申请单
        /// </summary>
        /// <param name="formVo"></param>
        /// <param name="fromId"></param>
        /// <returns></returns>
        [OperationContract(Name = "SaveForm")]
        int SaveForm(EntityFormDesign formVo, out int fromId);

        /// <summary>
        /// 删除.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [OperationContract(Name = "DelForm")]
        int DelForm(int formId, int version);

        /// <summary>
        /// 更新.电子申请单.打印
        /// </summary>
        /// <param name="formVo"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateFormPrint")]
        int UpdateFormPrint(EntityFormDesign formVo);
        #endregion

        #region 表格
        /// <summary>
        /// 表格明细
        /// </summary>
        /// <param name="tableCode"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetTableFieldInfo")]
        List<EntityEmrTableFieldInfo> GetTableFieldInfo(string tableCode);

        /// <summary>
        /// 检查表格编码、名称是否存在 
        /// </summary>
        /// <param name="tableCode"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        [OperationContract(Name = "IsExistsTableCodeOrName")]
        bool IsExistsTableCodeOrName(string tableCode, string tableName);

        /// <summary>
        /// 删除表格
        /// </summary>
        /// <param name="tableCode"></param>
        /// <returns></returns>
        [OperationContract(Name = "DeleteTableInfo")]
        int DeleteTableInfo(string tableCode);

        /// <summary>
        /// 保存表格
        /// </summary>
        /// <param name="tableVo"></param>
        /// <param name="lstTableField"></param>
        /// <returns></returns>
        [OperationContract(Name = "SaveTableInfo")]
        int SaveTableInfo(EntityEmrTableBasicInfo tableVo, List<EntityEmrTableFieldInfo> lstTableField);

        #endregion
    }
}
