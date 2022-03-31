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

namespace Common.Itf
{
    /// <summary>
    /// ItfCommon
    /// </summary>
    [ServiceContract]
    public interface ItfCommon : IWcf, IDisposable
    {
        #region GetFullTableData
        /// <summary>
        /// GetEmployee
        /// </summary>
        /// <param name="typeID">1 医生 2 护士</param>
        /// <returns></returns>
        [OperationContract(Name = "GetEmployee")]
        EntityCodeOperator[] GetEmployee(int typeID);

        [OperationContract(Name = "GetIcd")]
        EntityIcd[] GetIcd();

        /// <summary>
        /// GetEmpRoleList
        /// </summary>
        /// <returns></returns>
        [OperationContract(Name = "GetEmpRoleList")]
        Dictionary<string, List<string>> GetEmpRoleList();

        /// <summary>
        /// 获取员工-科室对应表
        /// </summary>
        /// <returns></returns>
        [OperationContract(Name = "GetDefDeptEmployee")]
        List<EntityDefDeptemployee> GetDefDeptEmployee();
        
        #endregion

        #region 医嘱录入字典
        /// <summary>
        /// 医嘱录入字典
        /// </summary>
        /// <param name="orderType">1 长、临嘱； 2 草药； 3 检验、检查</param>
        /// <returns></returns>
        [OperationContract(Name = "GetDicOrderInput")]
        List<EntityDicOrderInput> GetDicOrderInput(int orderType);
        #endregion

        #region emr
        /// <summary>
        /// 获取元素模板
        /// </summary>
        /// <param name="elementID"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetElementTemplate2")]
        List<EntityElementTemplate> GetElementTemplate(int elementID);

        /// <summary>
        /// 获取表格最大行索引号
        /// </summary>
        /// <param name="regID"></param>
        /// <param name="dbTableName"></param>
        /// <param name="tableCode"></param>
        /// <param name="recordDate"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetTableMaxRowIndex")]
        int GetTableMaxRowIndex(string regID, string dbTableName, string tableCode, DateTime? recordDate);

        /// <summary>
        /// 获取表格病历数据
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dbTableName"></param>
        /// <param name="tableCode"></param>
        /// <param name="fromRowIndex"></param>
        /// <param name="toRowIndex"></param>
        /// <param name="recordDate"></param>
        /// <param name="lstCaseRecord"></param>
        /// <param name="lstSignature"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetCaseTable")]
        int GetCaseTable(string regId, string dbTableName, string tableCode, int fromRowIndex, int toRowIndex, DateTime? recordDate, out List<EntityEmrData> lstCaseRecord, out List<EntitySignature> lstSignature);

        /// <summary>
        /// 插空行
        /// </summary>
        /// <param name="dbTableName"></param>
        /// <param name="lstCaseData"></param>
        /// <returns></returns>
        [OperationContract(Name = "AppendBlankRow")]
        int AppendBlankRow(string dbTableName, List<EntityEmrData> lstCaseData);

        /// <summary>
        /// 复制列标题
        /// </summary>
        /// <param name="p_intRegisterID"></param>
        /// <param name="p_strCaseCode"></param>
        /// <param name="p_intPageNo"></param>
        /// <returns></returns>
        [OperationContract(Name = "CopySelfDefineCol")]
        int CopySelfDefineCol(string regId, string caseCode, int pageNo, List<EntityCasTablePagePatInfoCell> lstTabPagePatInfo);

        /// <summary>
        /// 满足条件的表格列值(按时间点)
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dbTableName"></param>
        /// <param name="tableCode"></param>
        /// <param name="timeColCode"></param>
        /// <param name="lstComputeColCode"></param>
        /// <param name="endRowNo"></param>
        /// <param name="strTime"></param>
        /// <param name="decSumValue"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetTableTimePointValue")]
        int GetTableTimePointValue(string regId, string dbTableName, string tableCode, string timeColCode, List<string> lstComputeColCode, int endRowNo, string strTime, ref decimal decSumValue);

        /// <summary>
        /// 删除表格行记录
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dbTableName"></param>
        /// <param name="caseCode"></param>
        /// <param name="tabCode"></param>
        /// <param name="tabRowNo"></param>
        /// <param name="recordDate"></param>
        /// <returns></returns>
        [OperationContract(Name = "DelTableRowCase")]
        int DelTableRowCase(string regId, string dbTableName, string caseCode, string tabCode, int tabRowNo, DateTime? recordDate);

        /// <summary>
        /// 自定义列信息.获取1
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="caseCode"></param>
        /// <param name="pageNo"></param>
        /// <param name="lstTabPagePatInfo"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetCaseSelfDefineCol1")]
        void GetCaseSelfDefineCol(string regId, string caseCode, int pageNo, ref List<EntityCasTablePagePatInfoCell> lstTabPagePatInfo);

        /// <summary>
        /// 自定义列信息.获取2
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dbTableName"></param>
        /// <param name="lstTabPagePatInfo"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetCaseSelfDefineCol2")]
        void GetCaseSelfDefineCol(string regId, string dbTableName, ref List<EntityCasTablePagePatInfoCell> lstTabPagePatInfo);

        /// <summary>
        /// GetCaseSelfDefineCol
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetCaseSelfDefineCol3")]
        List<EntityEmrSelfDefineCol> GetCaseSelfDefineCol(string regId, string caseCode);


        /// <summary>
        /// 病历基础信息.保存
        /// </summary>
        /// <param name="caseVo"></param>
        /// <param name="lstCaseDept"></param>
        /// <returns></returns>
        [OperationContract(Name = "SaveCaseBasicInfo")]
        bool SaveCaseBasicInfo(ref EntityEmrBasicInfo caseVo, List<EntityEmrDept> lstCaseDept);

        /// <summary>
        /// 病历基础信息.删除
        /// </summary>
        /// <param name="serNo"></param>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        [OperationContract(Name = "DeleteCaseBasicInfo")]
        bool DeleteCaseBasicInfo(int serNo, string caseCode);

        /// <summary>
        /// GetCaseDept
        /// </summary>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetCaseDept")]
        List<EntityEmrDept> GetCaseDept(string caseCode);

        /// <summary>
        /// SaveCaseDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        [OperationContract(Name = "SaveCaseDept")]
        int SaveCaseDept(EntityEmrDept vo);

        /// <summary>
        /// DelCaseDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        [OperationContract(Name = "DelCaseDept")]
        int DelCaseDept(EntityEmrDept vo);

        /// <summary>
        /// 读取表格病历数据
        /// </summary>
        /// <param name="caseVo"></param>
        [OperationContract(Name = "GetTableCaseData")]
        string GetTableCaseData(EntityEmrDataTable caseVo);

        #endregion

        #region 服务器时间
        /// <summary>
        /// 服务器时间
        /// </summary>
        /// <returns></returns>
        [OperationContract(Name = "GetServerTime")]
        DateTime GetServerTime();
        #endregion

        #region 获取报表文件

        /// <summary>
        /// 获取报表文件
        /// </summary>
        /// <param name="rptId"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetReport")]
        EntitySysReport GetReport(decimal rptId);
        #endregion
    }
}
