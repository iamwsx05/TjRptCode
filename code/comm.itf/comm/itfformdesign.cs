using System;
using System.Collections.Generic;
using System.ServiceModel;
using weCare.Core.Entity;
using weCare.Core.Itf;
using Common.Entity;

namespace Common.Itf
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
        List<EntityFormDesign> GetForm(int formId, bool isShowLayout);

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

        #region 表单打印模板

        /// <summary>
        /// 获取.表单打印模板
        /// </summary>
        /// <param name="idType">1 formId; 2 formCode</param>
        /// <param name="templateId"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetFormPrintTemplate")]
        EntityEmrPrintTemplate GetFormPrintTemplate(int idType, string templateId);

        /// <summary>
        /// 删除.表单打印模板
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns></returns>
        [OperationContract(Name = "DelFormPrintTemplate")]
        int DelFormPrintTemplate(int templateId);

        /// <summary>
        /// 保存.表单打印模板
        /// </summary>
        /// <param name="templateVo"></param>
        /// <param name="templateId"></param>
        /// <returns></returns>
        [OperationContract(Name = "SaveFormPrintTemplate")]
        int SaveFormPrintTemplate(EntityEmrPrintTemplate templateVo, out int templateId);

        /// <summary>
        /// 更新.表单打印模板
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateFormPrintTemplate")]
        int UpdateFormPrintTemplate(EntityEmrPrintTemplate templateVo);

        #endregion

        #region 表格

        /// <summary>
        /// 表格主表
        /// </summary>
        /// <param name="tableCode"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetGetTableMainInfo")]
        EntityEmrTableBasicInfo GetGetTableMainInfo(string tableCode);

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

        #region 打印

        /// <summary>
        /// 报表文件
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        [OperationContract(Name = "SaveReportFile")]
        int SaveReportFile(EntitySysReport vo);

        #endregion


    }
}
