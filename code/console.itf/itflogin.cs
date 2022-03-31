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
    public interface ItfLogin : IWcf, IDisposable
    {
        [OperationContract(Name = "TestXml")]
        string TestXml();

        /// <summary>
        /// 获取中间服务器CPU.ID
        /// </summary>
        /// <returns></returns>
        [OperationContract(Name = "GetServerCPU")]
        string GetServerCPU();

        /// <summary>
        /// 本地参数配置
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetAppConfig")]
        List<EntityAppConfig> GetAppConfig(EntityPC pc);

        /// <summary>
        /// 系统参数配置
        /// </summary>
        /// <returns></returns>
        [OperationContract(Name = "SysParameter")]
        Dictionary<int, string> SysParameter();

        /// <summary>
        /// 登录账户权限（模块）信息
        /// </summary>
        /// <param name="dtResult"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetAccountLogin")]
        List<EntityAccount> GetAccount();

        /// <summary>
        /// 登录账户权限（模块）信息
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="parentID"></param>
        /// <param name="typeID"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetAccountSysModule")]
        List<EntitySysModule> GetAccount(string empNo, int parentID, int typeID);

        /// <summary>
        /// 界面ToolBar权限
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="parentID"></param>
        /// <param name="typeID"></param>
        /// <returns></returns>
        [OperationContract(Name = "GetFormFuncButton")]
        List<EntitySysModule> GetFormFuncButton(string empNo, string classFullName);

        /// <summary>
        /// 登录信息
        /// </summary>
        /// <param name="empNo"></param>
        /// <param name="dcLoginInfo"></param>
        /// <param name="dcHospitalInfo"></param>
        [OperationContract(Name = "GetLoginInfo")]
        void GetLoginInfo(string empNo, ref EntityLogin loginVo, ref EntityHospital hospitalVo);


    }
}
