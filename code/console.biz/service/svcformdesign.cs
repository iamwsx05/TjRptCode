using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weCare.Core.Entity;
using weCare.Core.Utils;
using Common.Entity;
using Console.Biz;

namespace Console.Svc
{
    public class SvcFormDesign : Console.Itf.ItfFormDesign
    {
        #region 表单

        #region 获取.电子申请单
        /// <summary>
        /// 获取.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="formVo"></param>
        public void GetForm(int formId, out EntityFormDesign formVo)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                biz.GetForm(formId, out formVo);
            }
        }

        /// <summary>
        /// 获取.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="version"></param>
        /// <param name="formVo"></param>
        public void GetForm(int formId, int version, out EntityFormDesign formVo)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                biz.GetForm(formId, version, out formVo);
            }
        }

        /// <summary>
        /// 获取.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public List<EntityFormDesign> GetForm(int formId)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                return biz.GetForm(formId);
            }
        }
        #endregion

        #region 保存.电子申请单
        /// <summary>
        /// 保存.电子申请单
        /// </summary>
        /// <param name="formVo"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public int SaveForm(EntityFormDesign formVo, out int formId)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                return biz.SaveForm(formVo, out formId);
            }
        }
        #endregion

        #region 删除.电子申请单
        /// <summary>
        /// 删除.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public int DelForm(int formId, int version)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                return biz.DelForm(formId, version);
            }
        }
        #endregion

        #region 更新.电子申请单.打印
        /// <summary>
        /// 更新.电子申请单.打印
        /// </summary>
        /// <param name="formVo"></param>
        /// <returns></returns>
        public int UpdateFormPrint(EntityFormDesign formVo)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                return biz.UpdateFormPrint(formVo);
            }
        }
        #endregion

        #endregion

        #region 表格

        #region 检查表格编码、名称是否存在 
        /// <summary>
        /// 检查表格编码、名称是否存在 
        /// </summary>
        /// <param name="tableCode"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public bool IsExistsTableCodeOrName(string tableCode, string tableName)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                return biz.IsExistsTableCodeOrName(tableCode, tableName);
            }
        }
        #endregion

        #region 表格明细
        /// <summary>
        /// 表格明细
        /// </summary>
        /// <param name="tableCode"></param>
        /// <returns></returns>
        public List<EntityEmrTableFieldInfo> GetTableFieldInfo(string tableCode)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                return biz.GetTableFieldInfo(tableCode);
            }
        }
        #endregion

        #region 删除表格
        /// <summary>
        /// 删除表格
        /// </summary>
        /// <param name="tableCode"></param>
        /// <returns></returns>
        public int DeleteTableInfo(string tableCode)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                return biz.DeleteTableInfo(tableCode);
            }
        }
        #endregion

        #region 保存表格
        /// <summary>
        /// 保存表格
        /// </summary>
        /// <param name="tableVo"></param>
        /// <param name="lstTableField"></param>
        /// <returns></returns>
        public int SaveTableInfo(EntityEmrTableBasicInfo tableVo, List<EntityEmrTableFieldInfo> lstTableField)
        {
            using (BizFormDesign biz = new BizFormDesign())
            {
                return biz.SaveTableInfo(tableVo, lstTableField);
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
