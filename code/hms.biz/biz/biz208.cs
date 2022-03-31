using Common.Entity;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using System.Transactions;
using Hms.Entity;

namespace Hms.Biz
{
    /// <summary>
    /// 体检项目维护
    /// </summary>
    public class Biz208 : IDisposable
    {
        #region 体检项目

        #region 获取体检项目列表
        /// <summary>
        /// 获取体检项目列表
        /// </summary>
        /// <returns></returns>
        public List<EntityDicPeItem> GetPeItems()
        {
            List<EntityDicPeItem> data = null;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            string Sql = string.Empty;
            Sql = @"select a.itemId,
                           a.itemName,
                           a.deptId,
                           a.minValue,
                           a.maxValue,
                           a.refRange,
                           a.gender,
                           a.displayPosition,
                           a.unit,
                           a.itemInfo,
                           a.isCompare,
                           a.isMain,
                           a.sortNo,
                           b.deptName
                      from dicPeItem a
                     inner join dicPeDepartment b
                        on a.deptId = b.deptId";

            DataTable dt = svc.GetDataTable(Sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                data = new List<EntityDicPeItem>();
                EntityDicPeItem vo = null;
                foreach (DataRow dr in dt.Rows)
                {
                    vo = new EntityDicPeItem();
                    vo.itemId = dr["itemId"].ToString();
                    vo.itemName = dr["itemName"].ToString();
                    vo.deptId = dr["deptId"].ToString();
                    vo.minValue = Function.Decnull(dr["minValue"]);
                    vo.maxValue = Function.Decnull(dr["maxValue"]);
                    vo.refRange = dr["refRange"].ToString();
                    vo.gender = Function.Int(dr["gender"]);
                    vo.displayPosition = Function.Int(dr["displayPosition"]);
                    vo.unit = dr["unit"].ToString();
                    vo.itemInfo = dr["itemInfo"].ToString();
                    vo.isCompare = Function.Int(dr["isCompare"]);
                    vo.isMain = Function.Int(dr["isMain"]);
                    vo.sortNo = Function.Int(dr["sortNo"]);
                    vo.deptName = dr["deptName"].ToString();
                    data.Add(vo);
                }
            }
            return data;
        }
        #endregion

        #region 保存
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="vo"></param>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public int SavePeItem(EntityDicPeItem vo, out string itemId)
        {
            int affectRows = 0;
            itemId = string.Empty;
            string Sql = string.Empty;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                if (string.IsNullOrEmpty(vo.itemId))
                {
                    vo.itemId = svc.GetNextID("dicPeItem", "itemId").ToString().PadLeft(6, '0');
                }
                if (vo.sortNo == 0)
                    vo.sortNo = Function.Int(vo.itemId);
                List<DacParm> lstParm = new List<DacParm>();
                lstParm.Add(svc.GetDelParmByPk(vo));
                lstParm.Add(svc.GetInsertParm(vo));
                affectRows = svc.Commit(lstParm);
                itemId = vo.itemId;
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svc = null;
            }
            return affectRows;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public int DeletePeItem(string itemId)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                affectRows = svc.Commit(svc.GetDelParmByPk(new EntityDicPeItem() { itemId = itemId }));
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svc = null;
            }
            return affectRows;
        }
        #endregion

        #region  体检报告模板
        /// <summary>
        /// 报告模板
        /// </summary>
        /// <returns></returns>
        public List<EntityReportTemplate> GetReportTemplate()
        {
            List<EntityReportTemplate> data = null;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            string Sql = string.Empty;
            Sql = @"select a.templateId,a.templateName,a.refPrice,a.describe from dicReportTemplate a  ";

            DataTable dt = svc.GetDataTable(Sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                data = new List<EntityReportTemplate>();
                EntityReportTemplate vo = null;
                foreach (DataRow dr in dt.Rows)
                {
                    vo = new EntityReportTemplate();
                    vo.templateId = dr["templateId"].ToString();
                    vo.templateName = dr["templateName"].ToString();
                    vo.peDatabase = "";
                    vo.refPrice = Function.Dec(dr["refPrice"]);
                    vo.describe = dr["describe"].ToString() ;
                    data.Add(vo);
                }
            }
            return data;
        }

        /// <summary>
        /// 体检报告模板的详细信息
        /// </summary>
        public List<EntityDisplaypeitem> GetReportTemplateDetail()
        {
            List<EntityDisplaypeitem> data = null;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            string Sql = string.Empty;
            Sql = @"select b.deptId,b.deptName,a.itemId,a.itemName,a.unit,
                            a.refRange,a.gender,a.isCompare,a.isMain
                            from dicPeItem a 
                            left join dicPeDepartment b 
                            on a.deptId = b.deptId ";

            DataTable dt = svc.GetDataTable(Sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                data = new List<EntityDisplaypeitem>();
                EntityDisplaypeitem vo = null;
                foreach (DataRow dr in dt.Rows)
                {
                    vo = new EntityDisplaypeitem();
                    vo.peDepartmentId = dr["deptId"].ToString();
                    vo.peDepartmentName = dr["deptName"].ToString();
                    
                    if(!data.Any(t=>t.peDepartmentId == vo.peDepartmentId))
                    {
                        vo.detailData = new List<EntityTemplatedetail>();
                        DataRow [] drr = dt.Select("deptId = '" + vo.peDepartmentId + "'");
                        for(int i = 0;i<drr.Length;i++)
                        {
                            DataRow drData = drr[i];
                            EntityTemplatedetail detailVo = new EntityTemplatedetail();
                            detailVo.itemName = drData["itemName"].ToString();
                            detailVo.itemUnit = drData["unit"].ToString();
                            detailVo.refRange = dr["refRange"].ToString();
                            detailVo.gender = Function.Int( dr["gender"].ToString());
                            detailVo.isCompare = Function.Int(drData["isCompare"].ToString());
                            detailVo.isMain = Function.Int(drData["isMain"].ToString());
                            vo.detailData.Add(detailVo);
                        }
                        data.Add(vo);
                    }
                }
            }
            return data;
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
