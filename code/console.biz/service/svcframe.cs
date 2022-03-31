using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
    /// SvcFrame
    /// </summary>
    public class SvcFrame : Console.Itf.ItfFrame
    {
        #region 本地参数

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="vo"></param>
        public void GetLocalSetting(ref EntityLocalSetting vo)
        {
            using (BizFrame biz = new BizFrame())
            {
                biz.GetLocalSetting(ref vo);
            }
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="lstLocalSetting"></param>
        public void GetLocalSetting(ref List<EntityLocalSetting> lstLocalSetting)
        {
            using (BizFrame biz = new BizFrame())
            {
                biz.GetLocalSetting(ref lstLocalSetting);
            }
        }
        #endregion

        #region 更新
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int UpdateLocalSetting(EntityLocalSetting vo)
        {
            using (BizFrame biz = new BizFrame())
            {
                return biz.UpdateLocalSetting(vo);
            }
        }
        #endregion

        #endregion

        #region 锁账户
        /// <summary>
        /// 锁账户
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        public int LockAccount(string empNo)
        {
            using (BizFrame biz = new BizFrame())
            {
                return biz.LockAccount(empNo);
            }
        }
        #endregion

        #region 修改密码
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="empNo"></param>
        /// <param name="oldPassWord"></param>
        /// <param name="newPassWord"></param>
        /// <returns></returns>
        public int ChangePassword(string empNo, string oldPassWord, string newPassWord)
        {
            using (BizFrame biz = new BizFrame())
            {
                return biz.ChangePassword(empNo, oldPassWord, newPassWord);
            }
        }
        #endregion

        #region 报表设计器

        #region GetRptDataTable
        /// <summary>
        /// GetRptDataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetRptDataTable(string sql)
        {
            using (BizFrame biz = new BizFrame())
            {
                return biz.GetRptDataTable(sql);
            }
        }
        #endregion

        #region 保存

        #region 主信息
        /// <summary>
        /// 主信息
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveReport(ref EntitySysReport vo)
        {
            using (BizFrame biz = new BizFrame())
            {
                return biz.SaveReport(ref vo);
            }
        }
        #endregion

        #region 报表文件
        /// <summary>
        /// 报表文件
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveReportFile(EntitySysReport vo)
        {
            using (BizFrame biz = new BizFrame())
            {
                return biz.SaveReportFile(vo);
            }
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="rptId"></param>
        /// <returns></returns>
        public int DeleteReport(decimal rptId)
        {
            using (BizFrame biz = new BizFrame())
            {
                return biz.DeleteReport(rptId);
            }
        }
        #endregion

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
