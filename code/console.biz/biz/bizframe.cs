using Common.Entity;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;

namespace Console.Biz
{
    /// <summary>
    /// BizFrame
    /// </summary>
    public class BizFrame : IDisposable
    {
        #region 本地参数

        #region 获取
        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="vo"></param>
        public void GetLocalSetting(ref EntityLocalSetting vo)
        {
            List<EntityLocalSetting> data = GetLocalSetting(new List<EntityLocalSetting> { vo });
            if (data.Count == 1) vo = data[0];
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="lstLocalSetting"></param>
        public void GetLocalSetting(ref List<EntityLocalSetting> lstLocalSetting)
        {
            lstLocalSetting = GetLocalSetting(lstLocalSetting);
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="lstLocalSetting"></param>
        /// <returns></returns>
        List<EntityLocalSetting> GetLocalSetting(List<EntityLocalSetting> data)
        {
            string SQL = string.Empty;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            DataTable dt = null;

            try
            {
                // 个人.优先
                foreach (EntityLocalSetting item in data)
                {
                    if (svc.enumDBMS == EnumDBMS.Oracle)
                    {
                        SQL = @"select '" + item.Parent + "' as parent, '" + item.Node + @"' as node, 
                                       extractvalue(setting, '/Parms/" + item.Parent + "/" + item.Node + @"') as value
                                  from sysLocalsetting
                                 where typeid = 3 and status = 1 and empno = '" + item.EmpNo + @"' 
                              " + (string.IsNullOrEmpty(SQL) ? string.Empty : @" union all 
                              " + SQL);
                    }
                    else
                    {
                        SQL = @"select '" + item.Parent + "' as parent, '" + item.Node + @"' as node, 
                                       setting.value('(Parms/" + item.Parent + "/" + item.Node + @")[1]', 'varchar(max)') as value 
                                  from sysLocalsetting
                                 where typeid = 3 and status = 1 and empno = '" + item.EmpNo + @"' 
                              " + (string.IsNullOrEmpty(SQL) ? string.Empty : @" union all 
                              " + SQL);
                    }
                }
                if (!string.IsNullOrEmpty(SQL))
                {
                    dt = svc.GetDataTable(SQL);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            (data.FirstOrDefault(t => t.Parent == dr["parent"].ToString() && t.Node == dr["node"].ToString())).Value = dr["value"].ToString();
                            (data.FirstOrDefault(t => t.Parent == dr["parent"].ToString() && t.Node == dr["node"].ToString())).IsDo = true;
                        }
                    }
                }
                // 本机.其次
                SQL = string.Empty;
                foreach (EntityLocalSetting item in data)
                {
                    if (item.IsDo) continue;
                    if (svc.enumDBMS == EnumDBMS.Oracle)
                    {
                        SQL = @"select '" + item.Parent + "' as parent, '" + item.Node + @"' as node, 
                                   extractvalue(setting, '/Parms/" + item.Parent + "/" + item.Node + @"') as value 
                                  from sysLocalsetting
                                 where typeid = 2 and status = 1 and (machinename = '" + item.MachName + "' or ipaddr = '" + item.IpAddr + "' or macaddr = '" + item.MacAddr + @"')  
                              " + (string.IsNullOrEmpty(SQL) ? string.Empty : @" union all 
                              " + SQL);
                    }
                    else
                    {
                        SQL = @"select '" + item.Parent + "' as parent, '" + item.Node + @"' as node, 
                                   setting.value('(Parms/" + item.Parent + "/" + item.Node + @")[1]', 'varchar(max)') as value 
                                  from sysLocalsetting
                                 where typeid = 2 and status = 1 and (machinename = '" + item.MachName + "' or ipaddr = '" + item.IpAddr + "' or macaddr = '" + item.MacAddr + @"')  
                              " + (string.IsNullOrEmpty(SQL) ? string.Empty : @" union all 
                              " + SQL);
                    }
                }
                if (!string.IsNullOrEmpty(SQL))
                {
                    dt = svc.GetDataTable(SQL);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            (data.FirstOrDefault(t => t.Parent == dr["parent"].ToString() && t.Node == dr["node"].ToString())).Value = dr["value"].ToString();
                            (data.FirstOrDefault(t => t.Parent == dr["parent"].ToString() && t.Node == dr["node"].ToString())).IsDo = true;
                        }
                    }
                }
                // 公用.最后
                SQL = string.Empty;
                foreach (EntityLocalSetting item in data)
                {
                    if (item.IsDo) continue;
                    if (svc.enumDBMS == EnumDBMS.Oracle)
                    {
                        SQL = @"select '" + item.Parent + "' as parent, '" + item.Node + @"' as node, 
                                       extractvalue(setting, '/Parms/" + item.Parent + "/" + item.Node + @"') as value 
                                  from sysLocalsetting
                                 where typeid = 1 and status = 1 
                              " + (string.IsNullOrEmpty(SQL) ? string.Empty : @" union all 
                              " + SQL);
                    }
                    else
                    {
                        SQL = @"select '" + item.Parent + "' as parent, '" + item.Node + @"' as node, 
                                       setting.value('(Parms/" + item.Parent + "/" + item.Node + @")[1]', 'varchar(max)') as value 
                                  from sysLocalsetting
                                 where typeid = 1 and status = 1 
                              " + (string.IsNullOrEmpty(SQL) ? string.Empty : @" union all 
                              " + SQL);
                    }
                }
                if (!string.IsNullOrEmpty(SQL))
                {
                    dt = svc.GetDataTable(SQL);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            (data.FirstOrDefault(t => t.Parent == dr["parent"].ToString() && t.Node == dr["node"].ToString())).Value = dr["value"].ToString();
                            (data.FirstOrDefault(t => t.Parent == dr["parent"].ToString() && t.Node == dr["node"].ToString())).IsDo = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return data;
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
            int intRet = 0;
            string SQL = string.Empty;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);

            try
            {
                if (svc.enumDBMS == EnumDBMS.Oracle)
                {
                    SQL = @"update sysLocalsetting set setting = updatexml(setting, '/Parms/" + vo.Parent + "/" + vo.Node + "/text()', '" + vo.Value + "') ";
                }
                else
                {
                    SQL = @"update sysLocalsetting set setting.modify('replace value of (Parms/" + vo.Parent + "/" + vo.Node + "/text())[1] with \"" + vo.Value + "\"') ";
                }
                if (vo.Type == 1)
                    SQL += "where typeid = 1 and status = 1";
                else if (vo.Type == 2)
                    SQL += "where typeid = 2 and status = 1 and (machinename = '" + vo.MachName + "' or ipaddr = '" + vo.IpAddr + "' or macaddr = '" + vo.MacAddr + "')";
                else if (vo.Type == 3)
                    SQL += "where typeid = 3 and status = 1 and empno = '" + vo.EmpNo + "'";

                intRet = svc.ExecSql(SQL);
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return intRet;
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
            int intRet = 0;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            try
            {
                EntityCodeOperator voEmp = new EntityCodeOperator();
                Dictionary<string, object> dicSet = new Dictionary<string, object>();
                dicSet.Add(EntityCodeOperator.Columns.acctStatus, 1);
                dicSet.Add(EntityCodeOperator.Columns.acctLockDate, DateTime.Now);
                Dictionary<string, object> dicWhere = new Dictionary<string, object>();
                dicWhere.Add(EntityCodeOperator.Columns.operCode, empNo);
                intRet = svc.Commit(svc.GetUpdateParm(voEmp, dicSet, dicWhere));
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return intRet;
        }
        #endregion

        #region 用户修改密码
        /// <summary>
        /// 用户修改密码
        /// </summary>
        /// <param name="empNo">用户工号</param>
        /// <param name="oldPassWord">旧密码</param>
        /// <param name="newPassWord">新密码</param>
        /// <returns></returns>
        public int ChangePassword(string empNo, string oldPassWord, string newPassWord)
        {
            int intRet = 0;
            string SQL = string.Empty;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            try
            {
                EntityCodeOperator voEmp = new EntityCodeOperator();
                voEmp.disable = "F";
                voEmp.operCode = empNo;
                List<EntityCodeOperator> lstEmp = EntityTools.ConvertToEntityList<EntityCodeOperator>(svc.Select(voEmp, new List<string> { EntityCodeOperator.Columns.disable, EntityCodeOperator.Columns.operCode }));

                if (lstEmp != null && lstEmp.Count > 0)
                {
                    string strDBPwd = string.Empty;
                    bool blnNull = false;
                    if (string.IsNullOrEmpty(lstEmp[0].pwd))
                    {
                        blnNull = true;
                    }
                    if (blnNull)
                    {
                    }
                    else
                    {
                        strDBPwd = lstEmp[0].pwd; //ESCryptography.Decrypt(lstEmp[0].pwd);
                    }
                    if (blnNull || strDBPwd == oldPassWord)
                    {
                        Dictionary<string, object> dicSet = new Dictionary<string, object>();
                        Dictionary<string, object> dicWhere = new Dictionary<string, object>();

                        dicSet.Add(EntityCodeOperator.Columns.pwd, newPassWord);//ESCryptography.Decrypt(newPassWord));
                        //dicSet.Add(EntityCodeOperator.Columns.Pwdusedate, DateTime.Now);

                        dicWhere.Add(EntityCodeOperator.Columns.disable, "F");
                        dicWhere.Add(EntityCodeOperator.Columns.operCode, empNo);

                        intRet = svc.Commit(svc.GetUpdateParm(voEmp, dicSet, dicWhere));
                    }
                    else
                    {
                        intRet = 0;
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                intRet = -1;
            }
            finally
            {
                svc = null;
            }
            return intRet;
        }
        #endregion

        #region 报表设计器

        #region GetRptDataTable
        /// <summary>
        /// GetRptDataTable
        /// </summary>
        /// <param name="Sql"></param>
        /// <returns></returns>
        public DataTable GetRptDataTable(string sql)
        {
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            DataTable dt = null;
            try
            {
                dt = svc.GetDataTable(sql);
            }
            catch
            {
                dt = new DataTable();
            }
            finally
            {
                svc = null;
            }
            if (dt == null) dt = new DataTable();
            dt.TableName = "table";
            return dt;
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
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                if (vo.rptId <= 0)
                {
                    affectRows = svc.Commit(svc.GetInsertParm(vo));
                }
                else
                {
                    affectRows = svc.Commit(svc.GetUpdateParm(vo, new List<string> { EntitySysReport.Columns.rptNo, EntitySysReport.Columns.rptName, EntitySysReport.Columns.pyCode,
                                                                                     EntitySysReport.Columns.wbCode, EntitySysReport.Columns.rptSql},
                                                                  new List<string> { EntitySysReport.Columns.rptId }));

                }
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

        #region 报表文件
        /// <summary>
        /// 报表文件
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveReportFile(EntitySysReport vo)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                affectRows = svc.Commit(svc.GetUpdateParm(vo, new List<string> { EntitySysReport.Columns.rptFile }, new List<string> { EntitySysReport.Columns.rptId }));
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

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="rptId"></param>
        /// <returns></returns>
        public int DeleteReport(decimal rptId)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntitySysReport vo = new EntitySysReport();
                vo.rptId = (int)rptId;
                affectRows = svc.Commit(svc.GetDelParmByPk(vo));
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
