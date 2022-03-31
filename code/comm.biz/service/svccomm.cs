using System;
using System.Collections.Generic;
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
    public class SvcCommon : Common.Itf.ItfCommon
    {
        #region 返回全表数据

        #region GetEmployee
        /// <summary>
        /// GetEmployee
        /// </summary>
        /// <returns></returns>
        public EntityCodeOperator[] GetEmployee(int typeID)
        {
            using (BizFullTableData biz = new BizFullTableData())
            {
                return biz.GetEmployee(typeID);
            }
        }
        #endregion

        #region GetIcd
        /// <summary>
        /// GetIcd
        /// </summary>
        /// <returns></returns>
        public EntityIcd[] GetIcd()
        {
            using (BizFullTableData biz = new BizFullTableData())
            {
                return biz.GetIcd();
            }
        }
        #endregion

        #region GetEmpRoleList
        /// <summary>
        /// GetEmpRoleList
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<string>> GetEmpRoleList()
        {
            using (BizFullTableData biz = new BizFullTableData())
            {
                return biz.GetEmpRoleList();
            }
        }
        #endregion

        #region 获取员工-科室对应表
        /// <summary>
        /// 获取员工-科室对应表
        /// </summary>
        /// <returns></returns>
        public List<EntityDefDeptemployee> GetDefDeptEmployee()
        {
            using (BizFullTableData biz = new BizFullTableData())
            {
                return biz.GetDefDeptEmployee();
            }
        }
        #endregion
        
        #endregion

        #region 医嘱字典
        /// <summary>
        /// 医嘱字典
        /// </summary>
        /// <param name="orderType">1 长、临嘱； 2 草药； 3 检验、检查</param>
        /// <returns></returns>
        public List<EntityDicOrderInput> GetDicOrderInput(int orderType)
        {
            using (BizStaticDic biz = new BizStaticDic())
            {
                return biz.GetDicOrderInput(orderType);
            }
        }
        #endregion

        #region EMR

        #region 获取元素模板
        /// <summary>
        /// 获取元素模板
        /// </summary>
        /// <param name="elementID"></param>
        /// <returns></returns>
        public List<EntityElementTemplate> GetElementTemplate(int elementID)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.GetElementTemplate(elementID);
            }
        }
        #endregion

        #region 获取表格最大行索引号
        /// <summary>
        /// 获取表格最大行索引号
        /// </summary>
        /// <param name="regID"></param>
        /// <param name="dbTableName"></param>
        /// <param name="tableCode"></param>
        /// <param name="recordDate"></param>
        /// <returns></returns>
        public int GetTableMaxRowIndex(string regID, string dbTableName, string tableCode, DateTime? recordDate)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.GetTableMaxRowIndex(regID, dbTableName, tableCode, recordDate);
            }
        }
        #endregion

        #region 获取表格病历数据
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
        public int GetCaseTable(string regId, string dbTableName, string tableCode, int fromRowIndex, int toRowIndex, DateTime? recordDate, out List<EntityEmrData> lstCaseRecord, out List<EntitySignature> lstSignature)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.GetCaseTable(regId, dbTableName, tableCode, fromRowIndex, toRowIndex, recordDate, out lstCaseRecord, out lstSignature);
            }
        }
        #endregion

        #region 插空行
        /// <summary>
        /// 插空行
        /// </summary>
        /// <param name="dbTableName"></param>
        /// <param name="lstCaseData"></param>
        /// <returns></returns>
        public int AppendBlankRow(string dbTableName, List<EntityEmrData> lstCaseData)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.AppendBlankRow(dbTableName, lstCaseData);
            }
        }
        #endregion

        #region 复制列标题
        /// <summary>
        /// 复制列标题
        /// </summary>
        /// <param name="p_intRegisterID"></param>
        /// <param name="p_strCaseCode"></param>
        /// <param name="p_intPageNo"></param>
        /// <returns></returns>
        public int CopySelfDefineCol(string regId, string caseCode, int pageNo, List<EntityCasTablePagePatInfoCell> lstTabPagePatInfo)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.CopySelfDefineCol(regId, caseCode, pageNo, lstTabPagePatInfo);
            }
        }
        #endregion

        #region 满足条件的表格列值(按时间点)
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
        public int GetTableTimePointValue(string regId, string dbTableName, string tableCode, string timeColCode, List<string> lstComputeColCode, int endRowNo, string strTime, ref decimal decSumValue)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.GetTableTimePointValue(regId, dbTableName, tableCode, timeColCode, lstComputeColCode, endRowNo, strTime, ref decSumValue);
            }
        }
        #endregion

        #region 删除表格行记录
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
        public int DelTableRowCase(string regId, string dbTableName, string caseCode, string tabCode, int tabRowNo, DateTime? recordDate)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.DelTableRowCase(regId, dbTableName, caseCode, tabCode, tabRowNo, recordDate);
            }
        }
        #endregion

        #region 自定义列信息

        #region 获取
        /// <summary>
        /// GetCaseSelfDefineCol
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="caseCode"></param>
        /// <param name="pageNo"></param>
        /// <param name="lstTabPagePatInfo"></param>
        /// <returns></returns>
        public void GetCaseSelfDefineCol(string regId, string caseCode, int pageNo, ref List<EntityCasTablePagePatInfoCell> lstTabPagePatInfo)
        {
            using (BizEmr biz = new BizEmr())
            {
                biz.GetCaseSelfDefineCol(regId, caseCode, pageNo, ref lstTabPagePatInfo);
            }
        }

        /// <summary>
        /// GetCaseSelfDefineCol
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dbTableName"></param>
        /// <param name="lstTabPagePatInfo"></param>
        /// <returns></returns>
        public void GetCaseSelfDefineCol(string regId, string dbTableName, ref List<EntityCasTablePagePatInfoCell> lstTabPagePatInfo)
        {
            using (BizEmr biz = new BizEmr())
            {
                biz.GetCaseSelfDefineCol(regId, dbTableName, ref lstTabPagePatInfo);
            }
        }

        /// <summary>
        /// GetCaseSelfDefineCol
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        public List<EntityEmrSelfDefineCol> GetCaseSelfDefineCol(string regId, string caseCode)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.GetCaseSelfDefineCol(regId, caseCode);
            }
        }
        #endregion
        #endregion

        #region 病历基础信息

        #region 病历基础信息.保存
        /// <summary>
        /// 病历基础信息.保存
        /// </summary>
        /// <param name="caseVo"></param>
        /// <param name="lstCaseDept"></param>
        /// <returns></returns>
        public bool SaveCaseBasicInfo(ref EntityEmrBasicInfo caseVo, List<EntityEmrDept> lstCaseDept)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.SaveCaseBasicInfo(ref caseVo, lstCaseDept);
            }
        }
        #endregion

        #region 病历基础信息.删除
        /// <summary>
        /// 病历基础信息.删除
        /// </summary>
        /// <param name="serNo"></param>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        public bool DeleteCaseBasicInfo(int serNo, string caseCode)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.DeleteCaseBasicInfo(serNo, caseCode);
            }
        }
        #endregion

        #region GetCaseDept
        /// <summary>
        /// GetCaseDept
        /// </summary>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        public List<EntityEmrDept> GetCaseDept(string caseCode)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.GetCaseDept(caseCode);
            }
        }
        #endregion

        #region SaveCaseDept
        /// <summary>
        /// SaveCaseDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveCaseDept(EntityEmrDept vo)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.SaveCaseDept(vo);
            }
        }
        #endregion

        #region DelCaseDept
        /// <summary>
        /// DelCaseDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int DelCaseDept(EntityEmrDept vo)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.DelCaseDept(vo);
            }
        }
        #endregion

        #endregion

        #region 读取表格病历数据
        /// <summary>
        /// 读取表格病历数据
        /// </summary>
        /// <param name="caseVo"></param>
        public string GetTableCaseData(EntityEmrDataTable caseVo)
        {
            using (BizEmr biz = new BizEmr())
            {
                return biz.GetTableCaseData(caseVo);
            }
        }
        #endregion

        #endregion

        #region ServerTime
        /// <summary>
        /// ServerTime
        /// </summary>
        /// <returns></returns>
        public DateTime GetServerTime()
        {
            weCare.Core.Dac.SqlHelper svc = new weCare.Core.Dac.SqlHelper(weCare.Core.Dac.EnumBiz.onlineDB);
            DateTime dtmNow = svc.ServerTime();
            svc = null;
            return dtmNow;
        }
        #endregion

        #region 获取报表文件
        /// <summary>
        /// 获取报表文件
        /// </summary>
        /// <param name="rptId"></param>
        /// <returns></returns>
        public EntitySysReport GetReport(decimal rptId)
        {
            using (BizFullTableData biz = new BizFullTableData())
            {
                return biz.GetReport(rptId);
            }
        }
        #endregion

        #region 电子申请单



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
