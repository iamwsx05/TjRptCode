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

namespace Console.Biz
{
    /// <summary>
    /// BizDictionary
    /// </summary>
    public class BizDictionary : IDisposable
    {
        #region department

        #region LoadDeptInfo
        /// <summary>
        /// LoadDeptInfo
        /// </summary>
        /// <returns></returns>
        public List<EntityCodeDepartment> LoadDeptInfo()
        {
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                List<EntityCodeDepartment> dataSource = EntityTools.ConvertToEntityList<EntityCodeDepartment>(svc.Select(new EntityCodeDepartment()));
                if (dataSource != null && dataSource.Count > 0)
                {
                    foreach (EntityCodeDepartment item in dataSource)
                    {
                        if (!string.IsNullOrEmpty(item.leafFlag) && item.leafFlag.ToUpper() == "T")
                            item.imageIndex = 1;
                        else
                            item.imageIndex = 0;
                    }
                }
                return dataSource;
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return null;
        }
        #endregion

        #region LoadDeptRoom
        /// <summary>
        /// LoadDeptRoom
        /// </summary>
        /// <param name="deptCode"></param>
        /// <returns></returns>
        public List<EntityDicDeptRoom> LoadDeptRoom(string deptCode)
        {
            SqlHelper svc = null;
            try
            {
                EntityDicDeptRoom vo = new EntityDicDeptRoom();
                vo.deptCode = deptCode;
                svc = new SqlHelper(EnumBiz.onlineDB);
                return EntityTools.ConvertToEntityList<EntityDicDeptRoom>(svc.Select(vo, new List<string> { EntityDicDeptRoom.Columns.deptCode }));
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return null;
        }
        #endregion

        #region LoadDeptExpert
        /// <summary>
        /// LoadDeptExpert
        /// </summary>
        /// <param name="deptCode"></param>
        /// <returns></returns>
        public List<EntityDicDeptReg> LoadDeptExpert(string deptCode)
        {
            SqlHelper svc = null;
            try
            {
                EntityDicDeptReg vo = new EntityDicDeptReg();
                vo.deptCode = deptCode;
                svc = new SqlHelper(EnumBiz.onlineDB);
                return EntityTools.ConvertToEntityList<EntityDicDeptReg>(svc.Select(vo, new List<string> { EntityDicDeptReg.Columns.deptCode }));
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return null;
        }
        #endregion

        #region SaveDepartment
        /// <summary>
        /// SaveDepartment
        /// </summary>
        /// <param name="deptVo"></param>
        /// <param name="deptOrig"></param>
        /// <param name="lstDeptRoom"></param>
        /// <param name="lstDeptReg"></param>
        /// <returns></returns>
        public int SaveDepartment(EntityCodeDepartment deptVo, EntityCodeDepartment deptOrig, List<EntityDicDeptRoom> lstDeptRoom, List<EntityDicDeptReg> lstDeptReg)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                if (deptOrig != null && deptVo != null && deptOrig.deptCode == deptVo.deptCode)
                {
                    lstParm.Add(svc.GetUpdateParmByPk(deptVo));

                    EntityDicDeptRoom vo1 = new EntityDicDeptRoom();
                    vo1.deptCode = deptOrig.deptCode;
                    lstParm.Add(svc.GetDelParm(vo1, EntityDicDeptRoom.Columns.deptCode));

                    EntityDicDeptReg vo2 = new EntityDicDeptReg();
                    vo2.deptCode = deptOrig.deptCode;
                    lstParm.Add(svc.GetDelParm(vo2, EntityDicDeptReg.Columns.deptCode));

                    // 2.dicDeptRoom
                    if (lstDeptRoom != null && lstDeptRoom.Count > 0)
                    {
                        lstParm.Add(svc.GetInsertParm(lstDeptRoom.ToArray()));
                    }

                    // 3.dicDeptReg
                    if (lstDeptReg != null && lstDeptReg.Count > 0)
                    {
                        lstParm.Add(svc.GetInsertParm(lstDeptReg.ToArray()));
                    }

                    affectRows = svc.Commit(lstParm);
                }
                else
                {
                    // 1.code_department
                    lstParm.Add(svc.GetInsertParm(deptVo));

                    // 2.dicDeptRoom
                    if (lstDeptRoom != null && lstDeptRoom.Count > 0)
                    {
                        lstParm.Add(svc.GetInsertParm(lstDeptRoom.ToArray()));
                    }

                    // 3.dicDeptReg
                    if (lstDeptReg != null && lstDeptReg.Count > 0)
                    {
                        lstParm.Add(svc.GetInsertParm(lstDeptReg.ToArray()));
                    }

                    if (deptOrig != null && !string.IsNullOrEmpty(deptOrig.deptCode))
                    {
                        using (TransactionScope scope = svc.TransactionScope)
                        {
                            if (DelDepartment(deptOrig.deptCode) < 0) return -1;
                            if (deptOrig.deptCode != deptVo.deptCode)
                            {
                                if (DelDepartment(deptVo.deptCode) < 0) return -1;
                            }
                            affectRows = svc.Commit(lstParm);
                            scope.Complete();
                        }
                    }
                    else
                    {
                        affectRows = svc.Commit(lstParm);
                    }
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

        #region DelDepartment
        /// <summary>
        /// DelDepartment
        /// </summary>
        /// <param name="deptCode"></param>
        /// <returns></returns>
        public int DelDepartment(string deptCode)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                EntityCodeDepartment vo4 = new EntityCodeDepartment();
                vo4.deptCode = deptCode;
                DataTable dt = svc.Select(vo4, new List<string> { EntityCodeDepartment.Columns.deptCode });
                if (dt != null && dt.Rows.Count > 0)
                {
                    lstParm.Add(svc.GetDelParm(vo4, EntityCodeDepartment.Columns.deptCode));

                    EntityDicDeptRoom vo1 = new EntityDicDeptRoom();
                    vo1.deptCode = deptCode;
                    lstParm.Add(svc.GetDelParm(vo1, EntityDicDeptRoom.Columns.deptCode));

                    EntityDicDeptReg vo2 = new EntityDicDeptReg();
                    vo2.deptCode = deptCode;
                    lstParm.Add(svc.GetDelParm(vo2, EntityDicDeptReg.Columns.deptCode));

                    EntityDefDeptemployee vo3 = new EntityDefDeptemployee();
                    vo3.deptCode = deptCode;
                    lstParm.Add(svc.GetDelParm(vo3, EntityDefDeptemployee.Columns.deptCode));

                    affectRows = svc.Commit(lstParm);
                }
                else
                {
                    return 1;
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

        #endregion

        #region employee

        #region LoadEmpInfo
        /// <summary>
        /// LoadEmpInfo
        /// </summary>
        /// <returns></returns>
        public List<EntityOperatorDisp> LoadEmpInfo()
        {
            string Sql = string.Empty;
            List<EntityOperatorDisp> data = null;
            SqlHelper svc = null;
            try
            {
                Sql = @"select a.oper_code,
                               a.oper_name,
                               a.pwd,
                               a.ukey,
                               a.disable as status, 
                               b.cls_code,
                               f.cls_name,
                               b.birth,
                               b.tel,
                               b.addr,
                               b.sex,
                               c.dept_code,
                               c.dept_name,
                               b.rank_code,                        
                               d.rank_name,
                               b.duty_code,
                               e.duty_name
                          from code_operator a
                         inner join plus_operator b on a.oper_code = b.oper_code
                          left join code_department c on b.dept_code = c.dept_code
                          left join code_rank d on b.rank_code = d.rank_code
                          left join code_duty e on b.duty_code = e.duty_code
                          left join code_operator_class f on b.cls_code = f.cls_code";

                svc = new SqlHelper(EnumBiz.onlineDB);
                DataTable dt = svc.GetDataTable(Sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    data = new List<EntityOperatorDisp>();
                    EntityOperatorDisp vo = null;
                    foreach (DataRow dr in dt.Rows)
                    {
                        vo = new EntityOperatorDisp();
                        vo.deptCode = dr["dept_code"].ToString();
                        vo.deptName = dr["dept_name"].ToString();
                        vo.operCode = dr["oper_code"].ToString();
                        vo.operName = dr["oper_name"].ToString();
                        vo.sex = string.Empty;
                        vo.birthday = dr["birth"].ToString();
                        vo.dutyName = dr["duty_name"].ToString();
                        vo.rankName = dr["rank_name"].ToString();
                        vo.pwd = dr["pwd"].ToString();
                        vo.type = dr["cls_name"].ToString();
                        vo.teacher = string.Empty;
                        vo.caKey = dr["ukey"].ToString();
                        vo.contactTel = dr["tel"].ToString();
                        vo.contactAddr = dr["addr"].ToString();
                        vo.status = dr["status"].ToString();
                        vo.sex = dr["sex"].ToString();
                        vo.pyCode = SpellCodeHelper.GetPyCode(vo.operName);
                        vo.wbCode = SpellCodeHelper.GetWbCode(vo.operName);
                        if (!string.IsNullOrEmpty(vo.status))
                        {
                            if (vo.status.Trim().ToUpper() == "T")
                                vo.status = "停职";
                            else if (vo.status.Trim().ToUpper() == "F")
                                vo.status = "在职";
                        }
                        if (!string.IsNullOrEmpty(vo.sex))
                        {
                            if (vo.sex == "1")
                                vo.sex = "男";
                            else if (vo.sex == "2")
                                vo.sex = "女";
                        }
                        data.Add(vo);
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

        #region LoadCodeOperatorAndPlus
        /// <summary>
        /// LoadCodeOperatorAndPlus
        /// </summary>
        /// <param name="operCode"></param>
        /// <param name="mainVo"></param>
        /// <param name="plusVo"></param>
        public void LoadCodeOperatorAndPlus(string operCode, out EntityCodeOperator mainVo, out EntityPlusOperator plusVo)
        {
            mainVo = new EntityCodeOperator();
            plusVo = new EntityPlusOperator();
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                mainVo.operCode = operCode;
                List<EntityCodeOperator> data1 = EntityTools.ConvertToEntityList<EntityCodeOperator>(svc.Select(mainVo, new List<string> { EntityCodeOperator.Columns.operCode }));
                if (data1 != null && data1.Count > 0) mainVo = data1[0];

                plusVo.operCode = operCode;
                List<EntityPlusOperator> data2 = EntityTools.ConvertToEntityList<EntityPlusOperator>(svc.Select(plusVo, new List<string> { EntityPlusOperator.Columns.operCode }));
                if (data1 != null && data1.Count > 0) plusVo = data2[0];
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
        }
        #endregion

        #region LoadOperatorRole
        /// <summary>
        /// LoadOperatorRole
        /// </summary>
        /// <param name="operCode"></param>
        /// <returns></returns>
        public List<EntityDefOperatorRole> LoadOperatorRole(string operCode)
        {
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityDefOperatorRole vo = new EntityDefOperatorRole();
                vo.operCode = operCode;
                return EntityTools.ConvertToEntityList<EntityDefOperatorRole>(svc.Select(vo, new List<string> { EntityDefOperatorRole.Columns.operCode }));
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return null;
        }
        #endregion

        #region LoadOperatorDept
        /// <summary>
        /// LoadOperatorDept
        /// </summary>
        /// <param name="operCode"></param>
        /// <returns></returns>
        public List<EntityDefDeptemployee> LoadOperatorDept(string operCode)
        {
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityDefDeptemployee vo = new EntityDefDeptemployee();
                vo.operCode = operCode;
                return EntityTools.ConvertToEntityList<EntityDefDeptemployee>(svc.Select(vo, new List<string> { EntityDefDeptemployee.Columns.operCode }));
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return null;
        }
        #endregion

        #region SaveOperatorDept
        /// <summary>
        /// SaveOperatorDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveOperatorDept(EntityDefDeptemployee vo)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);
                lstParm.Add(svc.GetDelParmByPk(vo));
                lstParm.Add(svc.GetInsertParm(vo));
                if (vo.defaultFlag == 1)
                {
                    EntityPlusOperator vo1 = new EntityPlusOperator();
                    vo1.operCode = vo.operCode;
                    vo1.deptCode = vo.deptCode;
                    lstParm.Add(svc.GetUpdateParm(vo1, new List<string> { EntityPlusOperator.Columns.deptCode }, new List<string> { EntityPlusOperator.Columns.operCode }));
                }
                affectRows = svc.Commit(lstParm);
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

        #region UpdateOperatorDeptDefault
        /// <summary>
        /// UpdateOperatorDeptDefault
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int UpdateOperatorDeptDefault(EntityDefDeptemployee vo)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                // 1.
                EntityDefDeptemployee vo1 = new EntityDefDeptemployee();
                vo1.operCode = vo.operCode;
                vo1.defaultFlag = 0;
                lstParm.Add(svc.GetUpdateParm(vo1, new List<string> { EntityDefDeptemployee.Columns.defaultFlag }, new List<string> { EntityDefDeptemployee.Columns.operCode }));
                // 2.
                lstParm.Add(svc.GetUpdateParm(vo, new List<string> { EntityDefDeptemployee.Columns.defaultFlag }, new List<string> { EntityDefDeptemployee.Columns.operCode, EntityDefDeptemployee.Columns.deptCode }));
                // 3.
                EntityPlusOperator vo3 = new EntityPlusOperator();
                vo3.operCode = vo.operCode;
                vo3.deptCode = vo.deptCode;
                lstParm.Add(svc.GetUpdateParm(vo3, new List<string> { EntityPlusOperator.Columns.deptCode }, new List<string> { EntityPlusOperator.Columns.operCode }));
                affectRows = svc.Commit(lstParm);
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

        #region SaveOperatorRole
        /// <summary>
        /// SaveOperatorRole
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveOperatorRole(EntityDefOperatorRole vo)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);
                lstParm.Add(svc.GetDelParmByPk(vo));
                lstParm.Add(svc.GetInsertParm(vo));
                affectRows = svc.Commit(lstParm);
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

        #region DelOperatorDept
        /// <summary>
        /// DelOperatorDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int DelOperatorDept(EntityDefDeptemployee vo)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
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

        #region DelOperatorRole
        /// <summary>
        /// DelOperatorRole
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int DelOperatorRole(EntityDefOperatorRole vo)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
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

        #region SaveOperator
        /// <summary>
        /// SaveOperator
        /// </summary>
        /// <param name="mainVo"></param>
        /// <param name="plusVo"></param>
        /// <param name="operOrig"></param>
        /// <returns></returns>
        public int SaveOperator(EntityCodeOperator mainVo, EntityPlusOperator plusVo, EntityCodeOperator operOrig)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                if (operOrig != null)
                {
                    EntityCodeOperator vo1 = new EntityCodeOperator();
                    vo1.operCode = operOrig.operCode;
                    lstParm.Add(svc.GetDelParmByPk(vo1));

                    EntityPlusOperator vo2 = new EntityPlusOperator();
                    vo2.operCode = operOrig.operCode;
                    lstParm.Add(svc.GetDelParmByPk(vo2));

                    if (operOrig.operCode != mainVo.operCode)
                    {
                        // 1.                
                        EntityCodeOperator vo3 = new EntityCodeOperator();
                        vo3.operCode = mainVo.operCode;
                        lstParm.Add(svc.GetDelParmByPk(vo3));

                        // 2.
                        EntityPlusOperator vo4 = new EntityPlusOperator();
                        vo4.operCode = mainVo.operCode;
                        lstParm.Add(svc.GetDelParmByPk(vo4));
                    }
                }

                // 3.CODE_OPERATOR
                lstParm.Add(svc.GetInsertParm(mainVo));

                // 4.PLUS_OPERATOR
                lstParm.Add(svc.GetInsertParm(plusVo));

                affectRows = svc.Commit(lstParm);
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

        #region DelOperator
        /// <summary>
        /// DelOperator
        /// </summary>
        /// <param name="operCode"></param>
        /// <returns></returns>
        public int DelOperator(string operCode)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                EntityDefDeptemployee vo1 = new EntityDefDeptemployee();
                vo1.operCode = operCode;
                lstParm.Add(svc.GetDelParm(vo1, EntityDefDeptemployee.Columns.operCode));

                EntityDefOperatorRole vo2 = new EntityDefOperatorRole();
                vo2.operCode = operCode;
                lstParm.Add(svc.GetDelParm(vo2, EntityDefOperatorRole.Columns.operCode));

                EntityPlusOperator vo3 = new EntityPlusOperator();
                vo3.operCode = operCode;
                lstParm.Add(svc.GetDelParm(vo3, EntityPlusOperator.Columns.operCode));

                EntityCodeOperator vo4 = new EntityCodeOperator();
                vo4.operCode = operCode;
                lstParm.Add(svc.GetDelParm(vo4, EntityCodeOperator.Columns.operCode));

                affectRows = svc.Commit(lstParm);
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

        #region role

        #region LoadRoleOper
        /// <summary>
        /// LoadRoleOper
        /// </summary>
        /// <param name="roleCode"></param>
        /// <returns></returns>
        public List<EntityDefOperatorRole> LoadRoleOper(string roleCode)
        {
            string Sql = string.Empty;
            SqlHelper svc = null;
            List<EntityDefOperatorRole> data = new List<EntityDefOperatorRole>();
            try
            {
                Sql = @"select a.role_code, b.oper_code, b.oper_name
                          from def_operator_role a
                         inner join code_operator b
                            on a.oper_code = b.oper_code
                         where b.disable = 'F'
                           and a.role_code = ? ";
                svc = new SqlHelper(EnumBiz.onlineDB);
                IDataParameter[] parm = svc.CreateParm(1);
                parm[0].Value = roleCode;
                DataTable dt = svc.GetDataTable(Sql, parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    EntityDefOperatorRole vo = null;
                    foreach (DataRow dr in dt.Rows)
                    {
                        vo = new EntityDefOperatorRole();
                        vo.roleCode = roleCode;
                        vo.operCode = dr["oper_code"].ToString();
                        vo.operName = dr["oper_name"].ToString();
                        data.Add(vo);
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

        #region LoadRoleFunc
        /// <summary>
        /// LoadRoleFunc
        /// </summary>
        /// <param name="roleCode"></param>
        /// <returns></returns>
        public List<EntityRoleFunction> LoadRoleFunc(string roleCode)
        {
            SqlHelper svc = null;
            try
            {
                EntityRoleFunction vo = new EntityRoleFunction();
                vo.Rolecode = roleCode;
                svc = new SqlHelper(EnumBiz.onlineDB);
                return EntityTools.ConvertToEntityList<EntityRoleFunction>(svc.Select(vo, new List<string> { EntityRoleFunction.Columns.Rolecode }));
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return null;
        }
        #endregion

        #region SaveRoleFunc
        /// <summary>
        /// SaveRoleFunc
        /// </summary>
        /// <param name="vo"></param>
        /// <param name="type">1 new; 0 delete</param>
        /// <returns></returns>
        public int SaveRoleFunc(EntityRoleFunction vo, int type)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                if (type == 1)
                {
                    affectRows = svc.Commit(svc.GetInsertParm(vo));
                }
                else if (type == 0)
                {
                    affectRows = svc.Commit(svc.GetDelParmByPk(vo));
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

        #region SaveRole
        /// <summary>
        /// SaveRole
        /// </summary>
        /// <param name="lstRoleUpdate"></param>
        /// <param name="lstRoleNew"></param>
        /// <returns></returns>
        public int SaveRole(List<EntityCodeRole> lstRoleUpdate, List<EntityCodeRole> lstRoleNew)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                if (lstRoleUpdate != null && lstRoleUpdate.Count > 0)
                {
                    lstParm.Add(svc.GetUpdateParmByPk(lstRoleUpdate.ToArray()));
                }
                if (lstRoleNew != null && lstRoleNew.Count > 0)
                {
                    lstParm.Add(svc.GetInsertParm(lstRoleNew.ToArray()));
                }
                affectRows = svc.Commit(lstParm);
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

        #region DelRole
        /// <summary>
        /// DelRole
        /// </summary>
        /// <param name="roleCode"></param>
        /// <returns></returns>
        public int DelRole(string roleCode)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                EntityCodeRole vo1 = new EntityCodeRole();
                vo1.roleCode = roleCode;
                lstParm.Add(svc.GetDelParm(vo1, EntityCodeRole.Columns.roleCode));

                EntityDefOperatorRole vo2 = new EntityDefOperatorRole();
                vo2.roleCode = roleCode;
                lstParm.Add(svc.GetDelParm(vo2, EntityDefOperatorRole.Columns.roleCode));

                EntityRoleFunction vo3 = new EntityRoleFunction();
                vo3.Rolecode = roleCode;
                lstParm.Add(svc.GetDelParm(vo3, EntityRoleFunction.Columns.Rolecode));

                affectRows = svc.Commit(lstParm);
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

        #region 患者资料

        #region 获取病人资料
        /// <summary>
        /// 获取病人资料
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<EntityPatientInfo> GetPatInfo(string key, string value)
        {
            EntityPatientInfo patVo = new EntityPatientInfo();
            SqlHelper svc = null;
            try
            {
                string code = string.Empty;
                string sign = "=";
                svc = new SqlHelper(EnumBiz.onlineDB);
                switch (key)
                {
                    case "cardNo":  // 诊疗卡号
                        patVo.cardNo = value + "%";
                        code = EntityPatientInfo.Columns.cardNo;
                        sign = "like";
                        break;
                    case "opNo":    // 门诊号
                        patVo.clNo = value;
                        code = EntityPatientInfo.Columns.clNo;
                        break;
                    case "ipNo":    // 住院号
                        patVo.ipNo = value;
                        code = EntityPatientInfo.Columns.ipNo;
                        break;
                    case "patName": // 姓名
                        patVo.name = value;
                        code = EntityPatientInfo.Columns.name;
                        break;
                    case "idNo":    // 身份证号
                        patVo.ID = value;
                        code = EntityPatientInfo.Columns.ID;
                        break;
                    default:
                        break;
                }
                return EntityTools.ConvertToEntityList<EntityPatientInfo>(svc.Select(patVo, new List<string> { code }, sign));
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                svc = null;
            }
            return null;
        }
        #endregion

        #region 保存病人资料
        /// <summary>
        /// 保存病人资料
        /// </summary>
        /// <param name="pat"></param>
        /// <returns></returns>
        public int SavePatInfo(ref EntityPatientInfo pat)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                if (string.IsNullOrEmpty(pat.pid))
                {
                    int id = svc.GetNextID(EntityTools.GetTableName(pat), EntityTools.GetFieldName(pat, EntityPatientInfo.Columns.pid));
                    pat.pid = id.ToString().PadLeft(10, '0');
                    affectRows = svc.Commit(svc.GetInsertParm(pat));
                }
                else
                {
                    affectRows = svc.Commit(svc.GetUpdateParmByPk(pat));
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

        #region 删除病人资料
        /// <summary>
        /// 删除病人资料
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public int DelPatInfo(string pid)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                EntityPatientInfo pat = new EntityPatientInfo();
                pat.pid = pid;
                affectRows = svc.Commit(svc.GetDelParmByPk(pat));
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

        #region 外部导入字典

        #region 导入科室
        /// <summary>
        /// 导入科室
        /// </summary>
        /// <returns></returns>
        public int ImportDeptInfo()
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityHospital hospitalVo = svc.HospitalInfo();
                if (hospitalVo != null)
                {
                    switch (GlobalHospital.GetEnum(hospitalVo.Orgcode))
                    {
                        case EnumHospitalCode.未定义:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    affectRows = this.ImportDeptForJl();
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

        #region 导入职工
        /// <summary>
        /// 导入职工
        /// </summary>
        /// <returns></returns>
        public int ImportEmpInfo()
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityHospital hospitalVo = svc.HospitalInfo();
                if (hospitalVo != null)
                {
                    switch (GlobalHospital.GetEnum(hospitalVo.Orgcode))
                    {
                        case EnumHospitalCode.未定义:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    affectRows = this.ImportEmpForJl();
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

        #region 导入职称
        /// <summary>
        /// 导入职称
        /// </summary>
        /// <returns></returns>
        public int ImportRankInfo()
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityHospital hospitalVo = svc.HospitalInfo();
                if (hospitalVo != null)
                {
                    switch (GlobalHospital.GetEnum(hospitalVo.Orgcode))
                    {
                        case EnumHospitalCode.未定义:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    affectRows = this.ImportRankForJl();
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

        #region 导入患者信息
        /// <summary>
        /// 导入患者信息
        /// </summary>
        /// <returns></returns>
        public int ImportPatInfo()
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityHospital hospitalVo = svc.HospitalInfo();
                if (hospitalVo != null)
                {
                    switch (GlobalHospital.GetEnum(hospitalVo.Orgcode))
                    {
                        case EnumHospitalCode.未定义:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    affectRows = this.ImportPatForZt();
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

        #region 巨龙

        #region 导入科室
        /// <summary>
        /// 导入科室
        /// </summary>
        /// <returns></returns>
        public int ImportDeptForJl()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select dept_code,
                               dept_name,
                               parent,
                               grade,
                               leaf_flag,
                               type,
                               py_code,
                               wb_code
                          from code_department";

                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);
                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string deptCode = string.Empty;
                    EntityCodeDepartment vo = null;
                    List<EntityCodeDepartment> lstVo = new List<EntityCodeDepartment>();
                    List<EntityCodeDepartment> dataSource = EntityTools.ConvertToEntityList<EntityCodeDepartment>(svcMain.Select(new EntityCodeDepartment()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        deptCode = dr["dept_code"] == DBNull.Value ? string.Empty : dr["dept_code"].ToString();
                        if (dataSource.Any(t => t.deptCode == deptCode)) continue;

                        vo = new EntityCodeDepartment();
                        vo.deptCode = deptCode;
                        vo.deptName = dr["dept_name"] == DBNull.Value ? string.Empty : dr["dept_name"].ToString();
                        vo.parent = dr["parent"].ToString();
                        vo.grade = Function.Int(dr["grade"].ToString());
                        vo.type = dr["type"].ToString();
                        vo.leafFlag = dr["leaf_flag"].ToString();
                        vo.pyCode = dr["py_code"].ToString().ToUpper();
                        vo.wbCode = dr["wb_code"].ToString().ToUpper();
                        lstVo.Add(vo);
                    }
                    if (lstVo.Count > 0)
                    {
                        affectRows = svcMain.Commit(svcMain.GetInsertParm(lstVo.ToArray()));
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #region 导入职工
        /// <summary>
        /// 导入职工
        /// </summary>
        /// <returns></returns>
        public int ImportEmpForJl()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select a.oper_code,
                               a.oper_name,
                               a.note,
                               a.pwd,
                               a.db_user,
                               a.db_pwd,
                               a.inner_flag,
                               a.disable,
                               a.if_share,
                               a.inline,
                               a.ukey,
                               a.noukey,
                               a.esp_flag,
                               b.oper_code,
                               b.py_code,
                               b.wb_code,
                               b.cls_code,
                               b.duty_code,
                               b.rank_code,
                               b.dept_code,
                               b.birth,
                               b.tel,
                               b.addr,
                               b.email,
                               b.pic_name,
                               b.ma_flag
                          from code_operator a
                         inner join plus_operator b
                            on a.oper_code = b.oper_code
                        ";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);

                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string operCode = string.Empty;
                    EntityCodeOperator vo = null;
                    EntityPlusOperator voPlus = null;
                    List<EntityCodeOperator> lstVo = new List<EntityCodeOperator>();
                    List<EntityPlusOperator> lstPlus = new List<EntityPlusOperator>();
                    EntityDefDeptemployee defVo = null;
                    List<EntityDefDeptemployee> lstDefDept = new List<EntityDefDeptemployee>();
                    List<EntityCodeOperator> dataSource = EntityTools.ConvertToEntityList<EntityCodeOperator>(svcMain.Select(new EntityCodeOperator()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        operCode = dr["oper_code"] == DBNull.Value ? string.Empty : dr["oper_code"].ToString();
                        if (dataSource.Exists(t => t.operCode.ToUpper().Trim() == operCode.ToUpper().Trim())) continue;

                        vo = new EntityCodeOperator();
                        vo.operCode = operCode;
                        vo.operName = dr["oper_name"] == DBNull.Value ? string.Empty : dr["oper_name"].ToString();
                        vo.disable = dr["disable"].ToString();
                        vo.innerFlag = dr["inner_flag"].ToString();
                        vo.note = dr["note"].ToString();
                        vo.pwd = dr["pwd"].ToString();
                        vo.pyCode = dr["py_code"].ToString().ToUpper();
                        vo.wbCode = dr["wb_code"].ToString().ToUpper();

                        voPlus = new EntityPlusOperator();
                        voPlus.operCode = operCode;
                        voPlus.pyCode = SpellCodeHelper.GetPyCode(vo.operName);
                        voPlus.wbCode = SpellCodeHelper.GetWbCode(vo.operName);
                        voPlus.rankCode = dr["rank_code"].ToString();
                        voPlus.clsCode = dr["cls_code"].ToString();
                        voPlus.deptCode = dr["dept_code"].ToString();
                        voPlus.dutyCode = dr["duty_code"].ToString();
                        voPlus.birth = dr["birth"].ToString();
                        voPlus.tel = dr["tel"].ToString();
                        voPlus.addr = dr["addr"].ToString();

                        // 人员<--->科室
                        defVo = new EntityDefDeptemployee();
                        defVo.operCode = operCode;
                        defVo.deptCode = voPlus.deptCode;
                        defVo.defaultFlag = 1;
                        lstDefDept.Add(defVo);
                        // 
                        lstVo.Add(vo);
                        lstPlus.Add(voPlus);
                    }
                    if (lstVo.Count > 0)
                    {
                        List<DacParm> lstParm = new List<DacParm>();
                        lstParm.Add(svcMain.GetInsertParm(lstVo.ToArray()));
                        lstParm.Add(svcMain.GetInsertParm(lstPlus.ToArray()));
                        lstParm.Add(svcMain.GetInsertParm(lstDefDept.ToArray()));
                        affectRows = svcMain.Commit(lstParm);
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #region 导入职称
        /// <summary>
        /// 导入职称
        /// </summary>
        /// <returns></returns>
        public int ImportRankForJl()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select rank_code, rank_name from code_rank";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);
                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string rankCode = string.Empty;
                    EntityCodeRank vo = null;
                    List<EntityCodeRank> lstVo = new List<EntityCodeRank>();
                    List<EntityCodeRank> dataSource = EntityTools.ConvertToEntityList<EntityCodeRank>(svcMain.Select(new EntityCodeRank()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        rankCode = dr["rank_code"] == DBNull.Value ? string.Empty : dr["rank_code"].ToString();
                        if (dataSource.Any(t => t.rankCode == rankCode)) continue;

                        vo = new EntityCodeRank();
                        vo.rankCode = rankCode;
                        vo.rankName = dr["rank_name"].ToString();
                        lstVo.Add(vo);
                    }
                    if (lstVo.Count > 0)
                    {
                        affectRows = svcMain.Commit(svcMain.GetInsertParm(lstVo.ToArray()));
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #endregion

        #region 中天

        #region 导入科室
        /// <summary>
        /// 导入科室
        /// </summary>
        /// <returns></returns>
        public int ImportDeptForZt()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select fdeptcode, fdeptname, fparent, fdesc from v_ks";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);
                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string deptCode = string.Empty;
                    EntityCodeDepartment vo = null;
                    List<EntityCodeDepartment> lstVo = new List<EntityCodeDepartment>();
                    List<EntityCodeDepartment> dataSource = EntityTools.ConvertToEntityList<EntityCodeDepartment>(svcMain.Select(new EntityCodeDepartment()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        deptCode = dr["fdeptcode"] == DBNull.Value ? string.Empty : dr["fdeptcode"].ToString().Trim();
                        if (dataSource.Any(t => t.deptCode == deptCode)) continue;

                        vo = new EntityCodeDepartment();
                        vo.deptCode = deptCode;
                        vo.deptName = dr["fdeptname"] == DBNull.Value ? string.Empty : dr["fdeptname"].ToString().Trim();
                        vo.parent = dr["fparent"].ToString();
                        vo.grade = 2;
                        vo.type = "1";
                        vo.leafFlag = "T";
                        vo.pyCode = SpellCodeHelper.GetPyCode(vo.deptName);
                        vo.wbCode = SpellCodeHelper.GetWbCode(vo.deptName);
                        lstVo.Add(vo);
                    }
                    if (lstVo.Count > 0)
                    {
                        affectRows = svcMain.Commit(svcMain.GetInsertParm(lstVo.ToArray()));
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #region 导入职工
        /// <summary>
        /// 导入职工
        /// </summary>
        /// <returns></returns>
        public int ImportEmpForZt()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select fempno, fempname, frankcode, fclscode from v_yh";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);
                Sql = @"select fgh, fkh from v_ysks";
                DataTable dtItfKs = svcItf.GetDataTable(Sql);
                DataRow[] drr = null;
                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string operCode = string.Empty;
                    EntityCodeOperator vo = null;
                    EntityPlusOperator voPlus = null;
                    List<EntityCodeOperator> lstVo = new List<EntityCodeOperator>();
                    List<EntityPlusOperator> lstPlus = new List<EntityPlusOperator>();
                    EntityDefDeptemployee defVo = null;
                    List<EntityDefDeptemployee> lstDefDept = new List<EntityDefDeptemployee>();
                    List<EntityCodeOperator> dataSource = EntityTools.ConvertToEntityList<EntityCodeOperator>(svcMain.Select(new EntityCodeOperator()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        operCode = dr["fempno"] == DBNull.Value ? string.Empty : dr["fempno"].ToString().Trim();
                        if (dataSource.Any(t => t.operCode == operCode)) continue;

                        vo = new EntityCodeOperator();
                        vo.operCode = operCode;
                        vo.operName = dr["fempname"] == DBNull.Value ? string.Empty : dr["fempname"].ToString().Trim();
                        vo.disable = "F";

                        voPlus = new EntityPlusOperator();
                        voPlus.operCode = operCode;
                        voPlus.pyCode = SpellCodeHelper.GetPyCode(vo.operName);
                        voPlus.wbCode = SpellCodeHelper.GetWbCode(vo.operName);
                        voPlus.rankCode = dr["frankcode"].ToString();
                        voPlus.clsCode = dr["fclscode"].ToString();
                        drr = dtItfKs.Select("fgh = '" + operCode + "'");
                        if (drr != null && drr.Length > 0)
                        {
                            // 人员<--->科室
                            voPlus.deptCode = drr[0]["fkh"].ToString();
                            for (int i = 0; i < drr.Length; i++)
                            {
                                defVo = new EntityDefDeptemployee();
                                defVo.operCode = operCode;
                                defVo.deptCode = drr[i]["fkh"].ToString();
                                if (i == 0)
                                    defVo.defaultFlag = 1;
                                else
                                    defVo.defaultFlag = 0;
                                lstDefDept.Add(defVo);
                            }

                        }
                        lstVo.Add(vo);
                        lstPlus.Add(voPlus);
                    }
                    if (lstVo.Count > 0)
                    {
                        List<DacParm> lstParm = new List<DacParm>();
                        lstParm.Add(svcMain.GetInsertParm(lstVo.ToArray()));
                        lstParm.Add(svcMain.GetInsertParm(lstPlus.ToArray()));
                        lstParm.Add(svcMain.GetInsertParm(lstDefDept.ToArray()));
                        affectRows = svcMain.Commit(lstParm);
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #region 导入职称
        /// <summary>
        /// 导入职称
        /// </summary>
        /// <returns></returns>
        public int ImportRankForZt()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select frankcode, frankname from v_zc";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);
                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string rankCode = string.Empty;
                    EntityCodeRank vo = null;
                    List<EntityCodeRank> lstVo = new List<EntityCodeRank>();
                    List<EntityCodeRank> dataSource = EntityTools.ConvertToEntityList<EntityCodeRank>(svcMain.Select(new EntityCodeRank()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        rankCode = dr["frankcode"] == DBNull.Value ? string.Empty : dr["frankcode"].ToString().Trim();
                        if (dataSource.Any(t => t.rankCode == rankCode)) continue;

                        vo = new EntityCodeRank();
                        vo.rankCode = rankCode;
                        vo.rankName = dr["frankname"].ToString();
                        lstVo.Add(vo);
                    }
                    if (lstVo.Count > 0)
                    {
                        affectRows = svcMain.Commit(svcMain.GetInsertParm(lstVo.ToArray()));
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #region 导入患者信息
        /// <summary>
        /// 导入患者信息
        /// </summary>
        /// <returns></returns>
        public int ImportPatForZt()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select fcardno, fpatid, fpatname, fsex, fbirthday, fidtype, fidnumber, fcontactaddr, fcontacttel from v_hz ";//where fcardno < '00001000'";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);
                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string cardNo = string.Empty;
                    EntityPatientInfo vo = null;
                    List<EntityPatientInfo> lstVo = new List<EntityPatientInfo>();
                    List<EntityPatientInfo> dataSource = EntityTools.ConvertToEntityList<EntityPatientInfo>(svcMain.Select(new EntityPatientInfo()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        cardNo = dr["fcardno"].ToString();
                        if (dataSource.Any(t => t.cardNo == cardNo)) continue;

                        vo = new EntityPatientInfo();
                        vo.cardNo = cardNo;
                        vo.pid = cardNo; //((dr["fpatid"] == DBNull.Value || string.IsNullOrEmpty(dr["fpatid"].ToString())) ? cardNo : dr["fpatid"].ToString());
                        vo.name = dr["fpatname"].ToString();
                        vo.sex = dr["fsex"].ToString();
                        if (dr["fbirthday"] != DBNull.Value) vo.birth = Function.Datetime(dr["fbirthday"].ToString()).ToString("yyyy-MM-dd");
                        //vo.idtype = dr["idtype"].ToString();
                        vo.ID = dr["fidnumber"].ToString();
                        vo.addr = dr["fcontactaddr"].ToString();
                        vo.tel = dr["fcontacttel"].ToString();
                        vo.lockFlag = "F";

                        lstVo.Add(vo);
                    }
                    if (lstVo.Count > 0)
                    {
                        affectRows = svcMain.Commit(svcMain.GetInsertParm(lstVo.ToArray()));
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #endregion

        #region 惠侨

        #region 导入科室
        /// <summary>
        /// 导入科室
        /// </summary>
        /// <returns></returns>
        public int ImportDeptForHq()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select dept_sn as fdeptcode, name as fdeptname, '' as fparent, address as fdesc from dic_dept_code";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);
                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string deptCode = string.Empty;
                    EntityCodeDepartment vo = null;
                    List<EntityCodeDepartment> lstVo = new List<EntityCodeDepartment>();
                    List<EntityCodeDepartment> dataSource = EntityTools.ConvertToEntityList<EntityCodeDepartment>(svcMain.Select(new EntityCodeDepartment()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        deptCode = dr["fdeptcode"] == DBNull.Value ? string.Empty : dr["fdeptcode"].ToString().Trim();
                        if (dataSource.Any(t => t.deptCode == deptCode)) continue;

                        vo = new EntityCodeDepartment();
                        vo.deptCode = deptCode;
                        vo.deptName = dr["fdeptname"] == DBNull.Value ? string.Empty : dr["fdeptname"].ToString().Trim();
                        vo.parent = dr["fparent"].ToString();
                        vo.grade = 2;
                        vo.type = "3";
                        vo.leafFlag = "T";
                        vo.pyCode = SpellCodeHelper.GetPyCode(vo.deptName);
                        vo.wbCode = SpellCodeHelper.GetWbCode(vo.deptName);
                        lstVo.Add(vo);
                    }
                    if (lstVo.Count > 0)
                    {
                        affectRows = svcMain.Commit(svcMain.GetInsertParm(lstVo.ToArray()));
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #region 导入职工
        /// <summary>
        /// 导入职工
        /// </summary>
        /// <returns></returns>
        public int ImportEmpForHq()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select emp_sn as fempno,
                                name as fempname,
                                '99' as frankcode,
                                '05' as fclscode,
                                prim_dept_sn as deptcode1,
                                sec_dept_sn as deptcode2
                            from dic_employee
                            where enable = '1'";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);
                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string operCode = string.Empty;
                    EntityCodeOperator vo = null;
                    EntityPlusOperator voPlus = null;
                    List<EntityCodeOperator> lstVo = new List<EntityCodeOperator>();
                    List<EntityPlusOperator> lstPlus = new List<EntityPlusOperator>();
                    EntityDefDeptemployee defVo = null;
                    List<EntityDefDeptemployee> lstDefDept = new List<EntityDefDeptemployee>();
                    List<EntityCodeOperator> dataSource = EntityTools.ConvertToEntityList<EntityCodeOperator>(svcMain.Select(new EntityCodeOperator()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        operCode = dr["fempno"] == DBNull.Value ? string.Empty : dr["fempno"].ToString().Trim();
                        if (dataSource.Any(t => t.operCode == operCode)) continue;

                        vo = new EntityCodeOperator();
                        vo.operCode = operCode;
                        vo.operName = dr["fempname"] == DBNull.Value ? string.Empty : dr["fempname"].ToString().Trim();
                        vo.disable = "F";

                        voPlus = new EntityPlusOperator();
                        voPlus.operCode = operCode;
                        voPlus.pyCode = SpellCodeHelper.GetPyCode(vo.operName);
                        voPlus.wbCode = SpellCodeHelper.GetWbCode(vo.operName);
                        voPlus.rankCode = dr["frankcode"].ToString();
                        voPlus.clsCode = dr["fclscode"].ToString();
                        // 人员<--->科室
                        if (dr["deptcode1"] != DBNull.Value)
                        {
                            voPlus.deptCode = dr["deptcode1"].ToString();
                            defVo = new EntityDefDeptemployee();
                            defVo.operCode = operCode;
                            defVo.deptCode = voPlus.deptCode;
                            defVo.defaultFlag = 1;
                            lstDefDept.Add(defVo);
                            if (dr["deptcode2"] != DBNull.Value)
                            {
                                defVo = new EntityDefDeptemployee();
                                defVo.operCode = operCode;
                                defVo.deptCode = dr["deptcode2"].ToString();
                                defVo.defaultFlag = 0;
                                lstDefDept.Add(defVo);
                            }
                        }
                        else
                        {
                            if (dr["deptcode2"] != DBNull.Value)
                            {
                                voPlus.deptCode = dr["deptcode2"].ToString();
                                defVo = new EntityDefDeptemployee();
                                defVo.operCode = operCode;
                                defVo.deptCode = voPlus.deptCode;
                                defVo.defaultFlag = 1;
                                lstDefDept.Add(defVo);
                            }
                        }
                        lstVo.Add(vo);
                        lstPlus.Add(voPlus);
                    }
                    if (lstVo.Count > 0)
                    {
                        List<DacParm> lstParm = new List<DacParm>();
                        lstParm.Add(svcMain.GetInsertParm(lstVo.ToArray()));
                        lstParm.Add(svcMain.GetInsertParm(lstPlus.ToArray()));
                        lstParm.Add(svcMain.GetInsertParm(lstDefDept.ToArray()));
                        affectRows = svcMain.Commit(lstParm);
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #endregion

        #region 创业

        #region 导入科室
        /// <summary>
        /// 导入科室
        /// </summary>
        /// <returns></returns>
        public int ImportDeptForCy()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select fdeptcode,		--科室编码
                               fdeptname,		--科室名称
                               fparentcode,		--上级科室编码
                               fleafflag,		--末级科室标志 F 否；T 是
                               ftype,			--科室类型 1 门诊科室; 2 留观室; 3 住院科室; 4 医技科室; 5 检验科室; 6 手术室; 7 行政部门; 8 后勤部门; 9 其他.
                               fsortno			--排序号
                          from bsoft.hcs_department
                         where (ftype = '3' or fdeptcode = '7018')";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);
                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string deptCode = string.Empty;
                    EntityCodeDepartment vo = null;
                    List<EntityCodeDepartment> lstInsertVo = new List<EntityCodeDepartment>();
                    List<EntityCodeDepartment> lstUpdateVo = new List<EntityCodeDepartment>();
                    List<EntityCodeDepartment> dataSource = EntityTools.ConvertToEntityList<EntityCodeDepartment>(svcMain.Select(new EntityCodeDepartment()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        deptCode = dr["fdeptcode"] == DBNull.Value ? string.Empty : dr["fdeptcode"].ToString().Trim();
                        vo = new EntityCodeDepartment();
                        vo.deptCode = deptCode;
                        vo.deptName = dr["fdeptname"] == DBNull.Value ? string.Empty : dr["fdeptname"].ToString().Trim();
                        vo.parent = dr["fparentcode"].ToString();
                        vo.grade = 2;
                        vo.type = dr["ftype"].ToString();
                        if (string.IsNullOrEmpty(vo.type)) vo.type = "9";
                        if (dr["fleafflag"].ToString() == "是")
                            vo.leafFlag = "T";
                        else if (dr["fleafflag"].ToString() == "否")
                            vo.leafFlag = "F";
                        else vo.leafFlag = dr["fleafflag"].ToString() == "F" ? "F" : "T";
                        vo.pyCode = SpellCodeHelper.GetPyCode(vo.deptName);
                        vo.wbCode = SpellCodeHelper.GetWbCode(vo.deptName);

                        if (dataSource.Any(t => t.deptCode == deptCode))
                        {
                            lstUpdateVo.Add(vo);
                        }
                        else
                        {
                            lstInsertVo.Add(vo);
                        }
                    }
                    List<DacParm> lstParm = new List<DacParm>();
                    if (lstInsertVo.Count > 0)
                    {
                        lstParm.Add(svcMain.GetInsertParm(lstInsertVo.ToArray()));
                    }
                    if (lstUpdateVo.Count > 0)
                    {
                        lstParm.Add(svcMain.GetUpdateParmByPk(lstUpdateVo.ToArray()));
                    }
                    if (lstParm.Count > 0)
                    {
                        affectRows = svcMain.Commit(lstParm);
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

        #region 导入职工
        /// <summary>
        /// 导入职工
        /// </summary>
        /// <returns></returns>
        public int ImportEmpForCy()
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svcItf = null;
            SqlHelper svcMain = null;
            try
            {
                Sql = @"select fopercode,		--员工工号
                               fopername,		--员工姓名
                               fsex,			--性别
                               fdeptcode,		--所属科室编码
                               fclscode,		--员工类型: 01 医生; 02 护士; 03 收费员; 04 药剂员; 05 其它; 08 客服
                               fdutycode,		--职务代码: 01 院长; 02 主任; 03 科长; 04 护士长; 05 护士; 06 组长; 07 其它; 08 医生; 09 医士; 10 干事; 11 科员
                               frankcode,		--职称代码
                               fbirthday,		--出生日期: 格式 yyyy-MM-dd
                               ftel,			--联系电话
                               fpwd				--登录系统密码
                          from bsoft.hcs_doctor";
                svcItf = new SqlHelper(EnumBiz.interfaceDB);
                svcMain = new SqlHelper(EnumBiz.onlineDB);
                DataTable dtItf = svcItf.GetDataTable(Sql);

                if (dtItf != null && dtItf.Rows.Count > 0)
                {
                    string operCode = string.Empty;
                    EntityCodeOperator vo = null;
                    EntityPlusOperator voPlus = null;
                    List<string> lstOperCode = new List<string>();
                    List<EntityCodeOperator> lstVoInsert = new List<EntityCodeOperator>();
                    List<EntityCodeOperator> lstVoUpdate = new List<EntityCodeOperator>();
                    List<EntityPlusOperator> lstPlusInsert = new List<EntityPlusOperator>();
                    List<EntityPlusOperator> lstPlusUpdate = new List<EntityPlusOperator>();
                    EntityDefDeptemployee defVo = null;
                    List<EntityDefDeptemployee> lstDefDeptInsert = new List<EntityDefDeptemployee>();
                    List<EntityDefDeptemployee> lstDefDeptUpdate = new List<EntityDefDeptemployee>();
                    List<EntityCodeOperator> dataSource = EntityTools.ConvertToEntityList<EntityCodeOperator>(svcMain.Select(new EntityCodeOperator()));
                    List<EntityDefDeptemployee> dataSourceDefDeptEmp = EntityTools.ConvertToEntityList<EntityDefDeptemployee>(svcMain.Select(new EntityDefDeptemployee()));
                    foreach (DataRow dr in dtItf.Rows)
                    {
                        if (dr["fopercode"] == DBNull.Value) continue;
                        operCode = dr["fopercode"].ToString().Trim();
                        // 相同工号的判断
                        if (lstOperCode.IndexOf(operCode) >= 0)
                            continue;
                        else
                            lstOperCode.Add(operCode);

                        //if (dataSource.Any(t => t.operCode == operCode)) continue;
                        bool isExsits = (dataSource.Any(t => t.operCode == operCode)) ? true : false;

                        vo = new EntityCodeOperator();
                        vo.operCode = operCode;
                        vo.operName = dr["fopername"] == DBNull.Value ? string.Empty : dr["fopername"].ToString().Trim();
                        vo.pwd = dr["fpwd"].ToString();
                        vo.disable = "F";
                        vo.innerFlag = "T";

                        voPlus = new EntityPlusOperator();
                        voPlus.operCode = operCode;
                        voPlus.sex = dr["fsex"].ToString();
                        voPlus.birth = dr["fbirthday"].ToString();
                        if (!string.IsNullOrEmpty(voPlus.birth)) voPlus.birth = Function.Datetime(voPlus.birth).ToString("yyyy-MM-dd");
                        voPlus.tel = dr["ftel"].ToString();
                        voPlus.pyCode = SpellCodeHelper.GetPyCode(vo.operName);
                        voPlus.wbCode = SpellCodeHelper.GetWbCode(vo.operName);
                        voPlus.dutyCode = dr["fdutycode"].ToString();
                        voPlus.rankCode = dr["frankcode"].ToString();
                        voPlus.clsCode = dr["fclscode"].ToString();
                        voPlus.deptCode = dr["fdeptcode"].ToString();
                        if (voPlus.deptCode != null)
                        {
                            // 人员<--->科室
                            defVo = new EntityDefDeptemployee();
                            defVo.operCode = operCode;
                            defVo.deptCode = voPlus.deptCode;
                            defVo.defaultFlag = 1;
                            if (isExsits)
                            {
                                if (dataSourceDefDeptEmp.Any(t => t.operCode == defVo.operCode && t.deptCode == defVo.deptCode))
                                {
                                    // 已存在科室-》不处理
                                }
                                else
                                {
                                    int count = dataSourceDefDeptEmp.Count(t => t.operCode == defVo.operCode);
                                    if (count == 0)
                                    {
                                        lstDefDeptInsert.Add(defVo);
                                    }
                                    else if (count == 1)
                                    {
                                        lstDefDeptUpdate.Add(defVo);
                                    }
                                    else if (count > 1) // 一个人属于多个科室
                                    {
                                        defVo.defaultFlag = 0;
                                        lstDefDeptInsert.Add(defVo);
                                    }
                                }
                            }
                            else
                            {
                                lstDefDeptInsert.Add(defVo);
                            }
                        }
                        if (isExsits)
                            lstVoUpdate.Add(vo);
                        else
                            lstVoInsert.Add(vo);
                        if (isExsits)
                            lstPlusUpdate.Add(voPlus);
                        else
                            lstPlusInsert.Add(voPlus);
                    }

                    List<DacParm> lstParm = new List<DacParm>();
                    if (lstVoInsert.Count > 0)
                    {
                        lstParm.Add(svcMain.GetInsertParm(lstVoInsert.ToArray()));
                        lstParm.Add(svcMain.GetInsertParm(lstPlusInsert.ToArray()));
                        lstParm.Add(svcMain.GetInsertParm(lstDefDeptInsert.ToArray()));
                    }
                    if (lstVoUpdate.Count > 0)
                    {
                        lstParm.Add(svcMain.GetUpdateParmByPk(lstVoUpdate.ToArray()));
                        lstParm.Add(svcMain.GetUpdateParmByPk(lstPlusUpdate.ToArray()));
                        lstParm.Add(svcMain.GetUpdateParmByPk(lstDefDeptUpdate.ToArray()));
                    }
                    if (lstParm.Count > 0)
                    {
                        affectRows = svcMain.Commit(lstParm);
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                affectRows = -1;
            }
            finally
            {
                svcItf = null;
                svcMain = null;
            }
            return affectRows;
        }
        #endregion

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
