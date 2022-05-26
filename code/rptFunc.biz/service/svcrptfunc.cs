using RptFunc.Xtyy;
using RptFunc.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using weCare.Core.Entity;
using RptFunc.Entity;

namespace RtpFunc.Svc
{
    public class SvcRptFunc : RtpFunc.Itf.ItfRptFunc
    {

        #region GetItemRpt
        /// <summary>
        /// GetItemRpt
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityItemRpt> GetItemRpt(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetItemRpt(parms);
            }
        }
        #endregion

        #region 单位挂账分类报表
        /// <summary>
        /// GetTjgzflRpt
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityTjdwgzfl> GetTjgzflRpt(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetTjgzflRpt(parms);
            }
        }
        #endregion

        #region 人员进度表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityTjjdb> GetTjjdb(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetTjjdb(parms);
            }
        }
        #endregion

        #region 异常报表
        public List<EntityYcjgRpt> GetYcjgRpt(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetYcjgRpt(parms);
            }
        }
        #endregion

        #region 体检收费员交款明细
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityTjSfJkmx> GetTjSfJkmx(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetTjSfJkmx(parms);
            }
        }
        #endregion

        #region
        /// <summary>
        /// 职业健康检查人员名单及检查结果
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityZybRegRpt> GetZybRegRpt(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetZybRegRpt(parms);
            }
        }
        #endregion

        #region
        /// <summary>
        /// 肺活量记录表
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityFhljlRpt> GetFhljlRpts(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetFhljlRpts(parms);
            }
        }
        #endregion

        #region 职业病结果报表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityZybjgRpt> GetZybjgRpts(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetZybjgRpts(parms);
            }
        }
        #endregion

        #region 业务分类报表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityTjywflRpt> GetTjywflRpts(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetTjywflRpts(parms);
            }
        }
        #endregion

        #region 工作量统计报表
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityGzlRpt> GetGzlRpts(List<EntityParm> parms)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetGzlRpts(parms);
            }
        }
        #endregion

        #region GetYwdjxx
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regNo"></param>
        /// <returns></returns>
        public EntityYwDjxx GetYwdjxx(string regNo)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetYwdjxx(regNo);
            }
        }
        #endregion

        #region GetZdzh
        public List<EntityZdzh> GetZdzh()
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetZdzh();
            }
        }
        #endregion

        #region GetDyTjyjymxxm
        public List<EntityDyTjyjymxxm> GetDyTjyjymxxm()
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetDyTjyjymxxm();
            }
        }
        #endregion

        #region GetZdDw
        /// <summary>
        /// GetZdDw
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        public List<EntityDw> GetZdDw()
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetZdDw();
            }
        }
        #endregion

        #region 项目分类
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EntityXmfl> GetZdXmfl()
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetZdXmfl();
            }
        }
        #endregion

        #region GetZdZy
        public List<EntityZdzy> GetZdZy()
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetZdZy();
            }
        }
        #endregion

        #region 获取本地配置
        /// <summary>
        /// 获取本地配置
        /// </summary>
        /// <returns></returns>
        public List<EntityAppConfig> GetAppConfig(EntityPC pc)
        {
            using (BizRptFunc biz = new BizRptFunc())
            {
                return biz.GetAppConfig(pc);
            }
        }
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
