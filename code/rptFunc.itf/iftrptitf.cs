using RptFunc.Entity;
using RptFunc.Xtyy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using weCare.Core.Entity;
using weCare.Core.Itf;

namespace RtpFunc.Itf
{
    [ServiceContract]
    public interface ItfRptFunc : IWcf, IDisposable
    {
        #region 杏坛医院
        /// <summary>
        /// 客户列表
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetItemRpt")]
        List<EntityItemRpt> GetItemRpt(List<EntityParm> parms);

        /// <summary>
        /// 体检单位挂账分类报表
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetTjgzflRpt")]
        List<EntityTjdwgzfl> GetTjgzflRpt(List<EntityParm> parms);

        /// <summary>
        /// 人员进度表
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetTjjdb")]
        List<EntityTjjdb> GetTjjdb(List<EntityParm> parms);

        /// <summary>
        /// 异常报表
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetYcjgRpt")]
        List<EntityYcjgRpt> GetYcjgRpt(List<EntityParm> parms);

        /// <summary>
        /// GetTjSfJkmx
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetTjSfJkmx")]
        List<EntityTjSfJkmx> GetTjSfJkmx(List<EntityParm> parms);

        [OperationContract(Name = "GetZybRegRpt")]
        List<EntityZybRegRpt> GetZybRegRpt(List<EntityParm> parms);

        [OperationContract(Name = "GetFhljlRpts")]
        List<EntityFhljlRpt> GetFhljlRpts(List<EntityParm> parms);

        [OperationContract(Name = "GetZybjgRpts")]
        List<EntityZybjgRpt> GetZybjgRpts(List<EntityParm> parms);

        [OperationContract(Name = "GetTjywflRpts")]
        List<EntityTjywflRpt> GetTjywflRpts(List<EntityParm> parms);

        [OperationContract(Name = "GetGzlRpts")]
        List<EntityGzlRpt> GetGzlRpts(List<EntityParm> parms);
        #endregion

        #region 佛山五院
        /// <summary>
        /// 人员进度表
        /// </summary>
        /// <param name="parms"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetTjjdb2")]
        List<EntityTjjdb> GetTjjdb2(List<EntityParm> parms);
        #endregion

        [OperationContract(Name = "GetZdZy")]
        List<EntityZdzy> GetZdZy();

        /// <summary>
        /// 本地参数配置
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetAppConfig")]
        List<EntityAppConfig> GetAppConfig(EntityPC pc);

        //单位
        [OperationContract(Name = "GetZdDw")]
        List<EntityDw> GetZdDw();

        /// <summary>
        /// 项目分类
        /// </summary>
        /// <returns></returns>
        [OperationContract(Name = "GetZdXmfl")]
        List<EntityXmfl> GetZdXmfl();

        [OperationContract(Name = "GetYwdjxx")]
        EntityYwDjxx GetYwdjxx(string regNo);

        [OperationContract(Name = "GetZdzh")]
        List<EntityZdzh> GetZdzh();

        [OperationContract(Name = "GetDyTjyjymxxm")]
        List<EntityDyTjyjymxxm> GetDyTjyjymxxm();
    }
}
