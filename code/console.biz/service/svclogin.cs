using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weCare.Core.Entity;
using weCare.Core.Utils;
using Common.Entity;
using Console.Biz;
using Console.Itf;

namespace Console.Svc
{
    /// <summary>
    /// SvcLogin
    /// </summary>
    public class SvcLogin : Console.Itf.ItfLogin
    {
        public string TestXml()
        {
            using (BizLogin biz = new BizLogin())
            {
                return biz.TestXml();
            }
        }

        #region 获取中间服务器CPU.ID
        /// <summary>
        /// 获取中间服务器CPU.ID
        /// </summary>
        /// <returns></returns>
        public string GetServerCPU()
        {
            return Function.CpuId();
        }
        #endregion

        #region 获取本地配置
        /// <summary>
        /// 获取本地配置
        /// </summary>
        /// <returns></returns>
        public List<EntityAppConfig> GetAppConfig(EntityPC pc)
        {
            using (BizLogin biz = new BizLogin())
            {
                return biz.GetAppConfig(pc);
            }
        }
        #endregion

        #region 系统参数配置
        /// <summary>
        /// 系统参数配置
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> SysParameter()
        {
            using (BizLogin biz = new BizLogin())
            {
                return biz.SysParameter();
            }
        }
        #endregion

        #region 登录账户权限（模块）信息
        /// <summary>
        /// 登录账户权限（模块）信息
        /// </summary>
        /// <param name="dtResult"></param>
        /// <returns></returns>
        public List<EntityAccount> GetAccount()
        {
            using (BizLogin biz = new BizLogin())
            {
                return biz.GetAccount();
            }
        }
        #endregion

        #region 登录账户权限（模块）信息
        /// <summary>
        /// 登录账户权限（模块）信息
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="parentID"></param>
        /// <param name="typeID"></param>
        /// <returns></returns>
        public List<EntitySysModule> GetAccount(string empNo, int parentID, int typeID)
        {
            using (BizLogin biz = new BizLogin())
            {
                return biz.GetAccount(empNo, parentID, typeID);
            }
        }
        #endregion

        #region 界面ToolBar权限
        /// <summary>
        /// 界面ToolBar权限
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="parentID"></param>
        /// <param name="typeID"></param>
        /// <returns></returns>
        public List<EntitySysModule> GetFormFuncButton(string empNo, string classFullName)
        {
            using (BizLogin biz = new BizLogin())
            {
                return biz.GetFormFuncButton(empNo, classFullName);
            }
        }
        #endregion

        #region 登录信息
        /// <summary>
        /// 登录信息
        /// </summary>
        /// <param name="empNo"></param>
        /// <param name="dcLoginInfo"></param>
        /// <param name="dcHospitalInfo"></param>
        public void GetLoginInfo(string empNo, ref EntityLogin loginVo, ref EntityHospital hospitalVo)
        {
            using (BizLogin biz = new BizLogin())
            {
                biz.GetLoginInfo(empNo, ref loginVo, ref hospitalVo);
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
