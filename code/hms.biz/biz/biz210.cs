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

namespace Hms.Biz
{
    /// <summary>
    /// 知识库
    /// </summary>
    public class Biz210 : IDisposable
    {
        #region 运动库

        #region 保存
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="vo"></param>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public int SaveSportItem(EntityDicSportItem vo, out decimal templateId)
        {
            int affectRows = 0;
            templateId = 0;
            string Sql = string.Empty;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                if (vo.sId <= 0)
                {
                    Sql = @"select max(t.sId) as maxId from dicSportItem t";
                    DataTable dt = svc.GetDataTable(Sql);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["maxId"] != DBNull.Value)
                        {
                            vo.sId = Convert.ToDecimal(dt.Rows[0]["maxId"]) + 1;
                        }
                    }
                    if (vo.sId <= 0)
                        vo.sId = 1;
                }
                List<DacParm> lstParm = new List<DacParm>();
                lstParm.Add(svc.GetDelParmByPk(vo));
                lstParm.Add(svc.GetInsertParm(vo));
                affectRows = svc.Commit(lstParm);
                templateId = vo.sId;
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
        /// <param name="templateId"></param>
        /// <returns></returns>
        public int DeleteSportItem(decimal templateId)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                affectRows = svc.Commit(svc.GetDelParmByPk(new EntityDicSportItem() { sId = templateId }));
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

        #endregion

        #region 21002   短信库

        #region 保存
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="vo"></param>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public int SaveMessageTemplate(EntityDicMessageContent vo, out decimal templateId)
        {
            int affectRows = 0;
            templateId = 0;
            string Sql = string.Empty;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                if (vo.sId <= 0)
                {
                    Sql = @"select max(t.sId) as maxId from dicMessageContent t";
                    DataTable dt = svc.GetDataTable(Sql);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["maxId"] != DBNull.Value)
                        {
                            vo.sId = Convert.ToDecimal(dt.Rows[0]["maxId"]) + 1;
                        }
                    }
                    if (vo.sId <= 0)
                        vo.sId = 1;
                }
                List<DacParm> lstParm = new List<DacParm>();
                lstParm.Add(svc.GetDelParmByPk(vo));
                lstParm.Add(svc.GetInsertParm(vo));
                affectRows = svc.Commit(lstParm);
                templateId = vo.sId;
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
        /// <param name="templateId"></param>
        /// <returns></returns>
        public int DeleteMessageTemplate(decimal templateId)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                affectRows = svc.Commit(svc.GetDelParmByPk(new EntityDicMessageContent() { sId = templateId }));
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
