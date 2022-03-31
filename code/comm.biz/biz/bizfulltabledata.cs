using Common.Entity;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace Common.Biz
{
    /// <summary>
    /// BizFullTableData
    /// </summary>
    public class BizFullTableData : IDisposable
    {
        #region GetFullTableData

        #region GetEmployee
        /// <summary>
        /// GetEmployee
        /// </summary>
        /// <param name="typeID">0 全部 1 医生 2 护士</param>
        /// <returns></returns>
        public EntityCodeOperator[] GetEmployee(int typeID)
        {
            string Sql = string.Empty;
            SqlHelper svc = null;
            try
            {
                Sql = @"select distinct null as empid,
                                            a.oper_code as empno,
                                            a.oper_name as empname,
                                            a.pwd,
                                            null as signdigital,
                                            b.py_code as pycode,
                                            b.wb_code as wbcode,
                                            b.cls_code,
                                            null as teacherid,
                                            null as deptid,
                                            c.dept_code as deptcode,
                                            c.dept_name as deptname,
                                            b.rank_code as rankcode,
                                            d.rank_name as rankname,
                                            b.duty_code as dutycode,
                                            e.duty_name as dutyname
                              from code_operator a
                             inner join plus_operator b on a.oper_code = b.oper_code
                              left join code_department c on b.dept_code = c.dept_code
                              left join code_rank d on b.rank_code = d.rank_code
                              left join code_duty e on b.duty_code = e.duty_code
                             where a.disable = 'F' 
                               {0}
                             order by b.rank_code";

                svc = new SqlHelper(EnumBiz.onlineDB);
                DataTable dt = null;
                IDataParameter[] parm = null;
                if (typeID == 0)
                {
                    Sql = string.Format(Sql, string.Empty);
                    dt = svc.GetDataTable(Sql);
                }
                else
                {
                    Sql = string.Format(Sql, "and b.cls_code = ? ");
                    string clsCode = string.Empty;
                    if (typeID == 1)
                        clsCode = "01";
                    else if (typeID == 2)
                        clsCode = "02";
                    parm = svc.CreateParm(1);
                    parm[0].Value = clsCode;
                    dt = svc.GetDataTable(Sql, parm);
                }
                if (dt != null && dt.Rows.Count > 0)
                {
                    int i = 0;
                    string empID = string.Empty;
                    List<string> lstEmpID = new List<string>();
                    EntityCodeOperator[] empVOArr = new EntityCodeOperator[dt.Rows.Count];
                    foreach (DataRow dr in dt.Rows)
                    {
                        empVOArr[i] = new EntityCodeOperator();
                        //empVOArr[i].Empid = Function.Dec(dr["empid"].ToString());
                        empVOArr[i].operCode = dr["empno"].ToString();
                        empVOArr[i].operName = dr["empname"].ToString();
                        //empVOArr[i].DeptID = dr["deptid"].ToString();
                        empVOArr[i].DeptNo = dr["deptcode"].ToString();
                        empVOArr[i].DeptName = dr["deptname"].ToString();
                        empVOArr[i].TechnicalLevelNo = dr["rankcode"].ToString();
                        empVOArr[i].TechnicalLevelName = dr["rankname"].ToString();
                        empVOArr[i].AdminLevelNo = dr["dutycode"].ToString();
                        empVOArr[i].AdminLevelName = dr["dutyname"].ToString();
                        try
                        {
                            if (dr["pwd"] != DBNull.Value && !string.IsNullOrEmpty(dr["pwd"].ToString()))
                                empVOArr[i].pwd = dr["pwd"].ToString();//ESCryptography.Decrypt(dr["pwd"].ToString());
                            else
                                empVOArr[i].pwd = string.Empty;
                        }
                        catch
                        {
                            empVOArr[i].pwd = "888888";
                        }
                        empVOArr[i].pyCode = dr["pycode"].ToString().ToUpper();
                        empVOArr[i].wbCode = dr["wbcode"].ToString().ToUpper();

                        if (lstEmpID.IndexOf(empVOArr[i].operCode) < 0)
                        {
                            empID += "'" + empVOArr[i].operCode + "',";
                            lstEmpID.Add(empVOArr[i].operCode);
                        }
                        i++;
                    }

                    Sql = @"select oper_code as opercode, role_code as rolecode
                              from def_operator_role 
                             where oper_code in (" + empID.Substring(0, empID.Length - 1) + ")";
                    dt = svc.GetDataTable(Sql);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        DataRow[] drr = null;
                        foreach (EntityCodeOperator item in empVOArr)
                        {
                            item.RoleID = new List<string>();
                            drr = dt.Select("opercode = '" + item.operCode + "'");
                            foreach (DataRow dr1 in drr)
                            {
                                item.RoleID.Add(dr1["rolecode"].ToString());
                            }
                        }
                    }
                    return empVOArr;
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return null;
        }
        #endregion

        #region GetEmpRoleList
        /// <summary>
        /// GetEmpRoleList
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<string>> GetEmpRoleList()
        {
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
            SqlHelper svc = null;
            try
            {
                EntityDefOperatorRole vo = new EntityDefOperatorRole();
                svc = new SqlHelper(EnumBiz.onlineDB);
                DataTable dt = svc.Select(new EntityDefOperatorRole());
                if (dt != null)
                {
                    string empId = string.Empty;
                    string roleID = string.Empty;
                    List<string> lstRoleID = null;
                    foreach (DataRow dr in dt.Rows)
                    {
                        empId = dr[EntityTools.GetFieldName(vo, EntityDefOperatorRole.Columns.operCode)].ToString();
                        roleID = dr[EntityTools.GetFieldName(vo, EntityDefOperatorRole.Columns.roleCode)].ToString();
                        if (data.ContainsKey(empId))
                        {
                            data[empId].Add(roleID);
                        }
                        else
                        {
                            lstRoleID = new List<string>() { roleID };
                            data.Add(empId, lstRoleID);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return data;
        }
        #endregion

        #region GetIcd
        /// <summary>
        /// GetIcd
        /// </summary>
        /// <returns></returns>
        public EntityIcd[] GetIcd()
        {
            SqlHelper svc = null;
            List<EntityIcd> lstIcd = new List<EntityIcd>();
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityIcd vo = null;
                List<EntityIcd10> lstIcd10 = EntityTools.ConvertToEntityList<EntityIcd10>(svc.Select(new EntityIcd10()));
                foreach (EntityIcd10 item in lstIcd10)
                {
                    vo = new EntityIcd();
                    vo.Type = "1";
                    vo.IcdCode = item.Icdcode;
                    vo.IcdName = item.Icdcnname;
                    vo.PyCode = item.Icdpycode;
                    vo.WbCode = item.Icdwbcode;
                    vo.ParentCode = item.Parentcode;
                    lstIcd.Add(vo);
                }
                List<EntityOpIcd> lstOpIcd = EntityTools.ConvertToEntityList<EntityOpIcd>(svc.Select(new EntityOpIcd()));
                foreach (EntityOpIcd item in lstOpIcd)
                {
                    vo = new EntityIcd();
                    vo.Type = "2";
                    vo.IcdCode = item.Icdcode;
                    vo.IcdName = item.Icdname;
                    vo.PyCode = item.Icdpycode;
                    vo.WbCode = item.Icdwbcode;
                    lstIcd.Add(vo);
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return lstIcd.ToArray();
        }
        #endregion

        #region 获取员工-科室对应表
        /// <summary>
        /// 获取员工-科室对应表
        /// </summary>
        /// <returns></returns>
        public List<EntityDefDeptemployee> GetDefDeptEmployee()
        {
            string Sql = string.Empty;
            List<EntityDefDeptemployee> data = new List<EntityDefDeptemployee>();
            SqlHelper svc = null;
            try
            {
                Sql = @"select b.defaultflag as defaultflag,
                               null          as deptid,
                               a.dept_code   as deptcode,
                               a.dept_name   as deptname,
                               a.py_code     as pycode,
                               a.wb_code     as wbcode,
                               c.OPER_CODE   as operCode,
                               c.OPER_NAME   as operName
                          from code_department a
                         inner join defDeptemployee b
                            on a.dept_code = b.deptcode
                         inner join code_operator c
                            on b.operCode = c.OPER_CODE";
                svc = new SqlHelper(EnumBiz.onlineDB);
                DataTable dt = svc.GetDataTable(Sql);
                EntityDefDeptemployee vo = null;
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        vo = new EntityDefDeptemployee();
                        vo.operCode = dr["operCode"].ToString();
                        vo.deptCode = dr["deptcode"].ToString();
                        vo.defaultFlag = Function.Int(dr["defaultflag"].ToString());
                        vo.deptName = dr["deptname"].ToString();
                        vo.operName = dr["operName"].ToString();
                        vo.pyCode = SpellCodeHelper.GetPyCode(dr["operName"].ToString());
                        vo.wbCode = SpellCodeHelper.GetWbCode(dr["operName"].ToString());
                        data.Add(vo);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return data;
        }
        #endregion
        
        #endregion

        #region 获取报表文件
        /// <summary>
        /// 获取报表文件
        /// </summary>
        /// <param name="rptId"></param>
        /// <returns></returns>
        public EntitySysReport GetReport(decimal rptId)
        {
            SqlHelper svc = null;
            try
            {
                EntitySysReport vo = new EntitySysReport();
                vo.rptId = rptId;
                svc = new SqlHelper(EnumBiz.onlineDB);
                List<EntitySysReport> lstRpt = EntityTools.ConvertToEntityList<EntitySysReport>(svc.Select(vo, new List<string> { EntitySysReport.Columns.rptId }));
                if (lstRpt != null && lstRpt.Count > 0)
                {
                    return lstRpt[0];
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return null;
        }
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
