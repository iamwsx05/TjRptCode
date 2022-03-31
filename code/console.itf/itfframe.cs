using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
    public interface ItfFrame : IWcf, IDisposable
    {
        #region 本地参数

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="vo"></param>
        [OperationContract(Name = "GetLocalSetting1")]
        void GetLocalSetting(ref EntityLocalSetting vo);

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="lstLocalSetting"></param>
        [OperationContract(Name = "GetLocalSetting2")]
        void GetLocalSetting(ref List<EntityLocalSetting> lstLocalSetting);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        [OperationContract(Name = "UpdateLocalSetting")]
        int UpdateLocalSetting(EntityLocalSetting vo);

        #endregion

        /// <summary>
        /// 锁账户
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        [OperationContract(Name = "LockAccount")]
        int LockAccount(string empNo);

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="empNo"></param>
        /// <param name="oldPassWord"></param>
        /// <param name="newPassWord"></param>
        /// <returns></returns>
        [OperationContract(Name = "ChangePassword")]
        int ChangePassword(string empNo, string oldPassWord, string newPassWord);

        #region 报表设计器

        /// <summary>
        /// GetRptDataTable
        /// </summary>
        /// <param name="Sql"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetRptDataTable")]
        DataTable GetRptDataTable(string sql);

        #region 保存

        /// <summary>
        /// 主信息
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        [OperationContract(Name = "SaveReport")]
        int SaveReport(ref EntitySysReport vo);
        /// <summary>
        /// 报表文件
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        [OperationContract(Name = "SaveReportFile")]
        int SaveReportFile(EntitySysReport vo);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="rptId"></param>
        /// <returns></returns>
        [OperationContract(Name = "DeleteReport")]
        int DeleteReport(decimal rptId);

        #endregion

        #endregion
    }
}
