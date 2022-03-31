using Common.Entity;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Xml;

namespace Console.Biz
{
    /// <summary>
    /// BizLogin
    /// </summary>
    public class BizLogin : IDisposable
    {
        #region TestXml
        /// <summary>
        /// TestXml
        /// </summary>
        /// <returns></returns>
        public string TestXml()
        {
            string Sql = @"select xCol from docs";
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            DataTable dt = svc.GetDataTable(Sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(dt.Rows[0][0].ToString());
                XDocument xml = Function.ConvertToXDocument(doc);

                var node = from t in xml.Descendants("book").Where(w => w.Element("title").Value.Contains('P'))
                           select new
                           {
                               id = t.Element("price").Value,
                               val = t.Element("author").Value
                           };
                if (node.Count() > 0)
                {
                    string info = string.Empty;
                    foreach (var item1 in node)
                    {
                        info += item1.id + "  " + item1.val + "\r\n";
                    }
                    return info;
                }
            }
            return string.Empty;
        }
        #endregion

        #region 本地参数配置
        /// <summary>
        /// 本地参数配置
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>
        public List<EntityAppConfig> GetAppConfig(EntityPC pc)
        {
            string SQL = string.Empty;
            List<EntityAppConfig> lstSetting = new List<EntityAppConfig>();
            SqlHelper objSvc = new SqlHelper(EnumBiz.onlineDB);
            DataTable dt = null;

            try
            {
                string SQL1 = @"select t.typeid, t.setting
                                  from sysLocalsetting t
                                 where t.status = 1 
                                   ";
                IDataParameter[] objParamArr = null;
                if (!string.IsNullOrEmpty(pc.EmpNo))
                {
                    SQL += SQL1 + @"and t.typeid = 3
                                    and t.empno = ?";
                    objParamArr = objSvc.CreateParm(1);
                    objParamArr[0].Value = pc.EmpNo;
                    dt = objSvc.GetDataTable(SQL, objParamArr);

                    // 个人.优先
                    GetSetingArr(ref lstSetting, dt);
                }

                SQL = SQL1 + @"and t.typeid = 2
                               and (t.machinename = ? or t.ipaddr = ? or
                                    t.macaddr = ?)";
                objParamArr = objSvc.CreateParm(3);
                objParamArr[0].Value = pc.MachineName;
                objParamArr[1].Value = pc.IpAddr;
                objParamArr[2].Value = pc.MacAddr;
                dt = objSvc.GetDataTable(SQL, objParamArr);

                // 本机.其次
                GetSetingArr(ref lstSetting, dt);

                SQL = SQL1 + @"and t.typeid = 1";
                dt = objSvc.GetDataTable(SQL);

                // 公用.再次
                GetSetingArr(ref lstSetting, dt);
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                objSvc = null;
            }

            return lstSetting;
        }
        /// <summary>
        /// GetSetingArr
        /// </summary>
        /// <param name="lstSetting"></param>
        /// <param name="dt"></param>
        private void GetSetingArr(ref List<EntityAppConfig> lstSetting, DataTable dt)
        {
            List<string> lstNode = new List<string>() { "Service" };
            System.Xml.XmlNodeList nodeList = null;
            System.Xml.XmlNode node = null;
            EntityAppConfig vo = null;

            string xml = string.Empty;

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["setting"] != DBNull.Value && !string.IsNullOrEmpty(dr["setting"].ToString()))
                {
                    xml = "<Main>" + Environment.NewLine + dr["setting"].ToString().Replace("<Parms>", "").Replace("</Parms>", "") + Environment.NewLine + "</Main>";

                    foreach (string nodeName in lstNode)
                    {
                        nodeList = Function.ReadXML(xml, nodeName);

                        if (nodeList != null)
                        {
                            for (int i = 0; i < nodeList.Count; i++)
                            {
                                node = nodeList.Item(i);
                                if (node.Attributes == null)
                                {
                                    continue;
                                }

                                vo = new EntityAppConfig();
                                vo.Node = nodeName;
                                vo.Module = node.Attributes["module"].Value.Trim();
                                vo.Name = node.Attributes["name"].Value.Trim();
                                vo.Text = node.Attributes["text"].Value.Trim();
                                vo.Value = node.Attributes["value"].Value.Trim();

                                if (lstSetting.Exists(t => t.Node == vo.Node && t.Module == vo.Module && t.Name == vo.Name))
                                {
                                    continue;
                                }
                                else
                                {
                                    lstSetting.Add(vo);
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region 系统参数
        /// <summary>
        /// 系统参数
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> SysParameter()
        {
            Dictionary<int, string> dicSysParam = new Dictionary<int, string>();
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);

            try
            {
                EntitySysParameter voSysPara = new EntitySysParameter();
                voSysPara.Parmstatus = 1;
                List<EntitySysParameter> lstSysPara = EntityTools.ConvertToEntityList<EntitySysParameter>(svc.Select(voSysPara, new List<string> { EntitySysParameter.Columns.Parmstatus }));
                if (lstSysPara != null && lstSysPara.Count > 0)
                {
                    foreach (EntitySysParameter vo in lstSysPara)
                    {
                        if (!dicSysParam.ContainsKey(Function.Int(vo.Parmid)))
                            dicSysParam.Add(Function.Int(vo.Parmid), vo.Parmvalue);
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
            return dicSysParam;
        }

        /// <summary>
        /// 系统参数
        /// </summary>
        /// <param name="parmID"></param>
        /// <returns></returns>
        private string SysParameter(int parmID)
        {
            string paraValue = string.Empty;
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);

            try
            {
                EntitySysParameter voSysPara = new EntitySysParameter();
                voSysPara.Parmid = parmID;
                voSysPara.Parmstatus = 1;
                List<EntitySysParameter> lstSysPara = EntityTools.ConvertToEntityList<EntitySysParameter>(svc.Select(voSysPara, new List<string> { EntitySysParameter.Columns.Parmid, EntitySysParameter.Columns.Parmstatus }));
                if (lstSysPara != null && lstSysPara.Count > 0)
                {
                    paraValue = lstSysPara[0].Parmvalue;
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

            return paraValue;
        }
        #endregion

        #region 账号信息
        /// <summary>
        /// 账号信息
        /// </summary>
        /// <param name="dtResult"></param>
        /// <returns></returns>
        public List<EntityAccount> GetAccount()
        {
            string SQL = string.Empty;
            List<EntityAccount> lstAccount = new List<EntityAccount>();
            SqlHelper objSvc = new SqlHelper(EnumBiz.onlineDB);
            try
            {
                SQL = @"select distinct a.oper_code   as empno,
                                        a.pwd,
                                        null          as signdigital,
                                        1             as acctstatus,
                                        d.funcid,
                                        d.funccode,
                                        d.funcname,
                                        d.functype,
                                        d.funcfile,
                                        d.opername,
                                        d.parentid,
                                        d.leafflag,
                                        d.sortno,
                                        d.imagesource
                          from code_operator a
                         inner join def_operator_role b
                            on a.oper_code = b.oper_code
                         inner join defrolefunction c
                            on b.role_code = c.rolecode
                         inner join sysfunction d
                            on c.funcid = d.funcid
                         where a.disable = 'F'
                           and d.functype in (0, 1, 3)
                         order by d.sortno";

                DataTable dtResult = objSvc.GetDataTable(SQL);
                EntityAccount vo = null;
                foreach (DataRow dr in dtResult.Rows)
                {
                    vo = new EntityAccount();
                    vo.AcctStatus = Function.Int(dr["acctstatus"]);
                    //vo.EmpId = Function.Int(dr["empid"]);
                    vo.EmpNo = dr["empno"].ToString();
                    if (dr["pwd"] == DBNull.Value || string.IsNullOrEmpty(dr["pwd"].ToString()))
                    {
                        vo.Pwd = string.Empty;
                    }
                    else
                    {
                        vo.Pwd = dr["pwd"].ToString(); //ESCryptography.Decrypt(dr["pwd"].ToString());
                    }
                    vo.SignDigital = dr["signdigital"].ToString();
                    vo.FuncId = Function.Int(dr["funcid"]);
                    vo.FuncCode = dr["funccode"].ToString();
                    vo.FuncName = dr["funcname"].ToString();
                    vo.FuncType = Function.Int(dr["functype"]);
                    vo.FuncFile = dr["funcfile"].ToString();
                    vo.OperName = dr["opername"].ToString();
                    vo.ParentCode = dr["parentid"].ToString();
                    vo.IsLeaf = (dr["leafflag"] != DBNull.Value && dr["leafflag"].ToString() == "1" ? true : false);
                    vo.ImageSource = dr["imagesource"].ToString();
                    lstAccount.Add(vo);
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                objSvc = null;
            }
            return lstAccount;
        }

        /// <summary>
        /// FuncID
        /// </summary>
        private List<int> lstFuncID = null;

        /// <summary>
        /// GetFuncID
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="dtSource"></param>
        private void GetFuncID(int parentID, DataTable dtSource)
        {
            int intFuncID = 0;
            DataRow[] drr = dtSource.Select("parentid = " + parentID);
            if (drr != null)
            {
                foreach (DataRow dr in drr)
                {
                    intFuncID = Function.Int(dr["funcid"]);
                    lstFuncID.Add(intFuncID);
                    GetFuncID(intFuncID, dtSource);
                }
            }
        }

        /// <summary>
        /// GetFormFuncButton
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="classFullName"></param>
        /// <returns></returns>
        public List<EntitySysModule> GetFormFuncButton(string empNo, string classFullName)
        {
            string SQL = string.Empty;
            SqlHelper objSvc = new SqlHelper(EnumBiz.onlineDB);
            List<EntitySysModule> lstSysModule = new List<EntitySysModule>();

            try
            {
                SQL = @"select distinct d.funcid,
                                        d.funccode,
                                        d.funcname,
                                        d.funcfile,
                                        d.functype,
                                        d.opername,
                                        d.parentid,
                                        d.leafflag,
                                        d.sortno,
                                        d.imagesource
                          from def_operator_role b
                         inner join defrolefunction c
                            on b.role_code = c.rolecode
                         inner join sysfunction d
                            on c.funcid = d.funcid
                         where d.functype = 5
                           and b.oper_code = ?
                           and d.funccode = ?
                         order by d.sortno";

                DataTable dt = null;
                IDataParameter[] objParamArr = objSvc.CreateParm(2);
                objParamArr[0].Value = empNo;
                objParamArr[1].Value = classFullName;
                dt = objSvc.GetDataTable(SQL, objParamArr);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        lstSysModule.Add(GetSysModule(dr));
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                objSvc = null;
            }

            return lstSysModule;
        }

        /// <summary>
        /// GetAccountInfo
        /// </summary>
        /// <param name="empNo"></param>
        /// <param name="parentID"></param>
        /// <param name="typeID">1 菜单(窗体) 2 按钮</param>
        /// <returns></returns>
        public List<EntitySysModule> GetAccount(string empNo, int parentID, int typeID)
        {
            string SQL = string.Empty;
            SqlHelper objSvc = new SqlHelper(EnumBiz.onlineDB);
            List<EntitySysModule> lstSysModule = new List<EntitySysModule>();

            try
            {
                string strSub = string.Empty;
                if (typeID == 1)
                {
                    strSub = @" (d.functype = 1 or d.functype = 3) ";
                }
                else if (typeID == 2)
                {
                    strSub = @" d.functype = 5 ";
                }
                SQL = @"select distinct d.funcid,
                                        d.funccode,
                                        d.funcname,
                                        d.funcfile,
                                        d.functype,
                                        d.opername,
                                        d.parentid,
                                        d.leafflag,
                                        d.imagesource,
                                        d.sortno
                          from def_operator_role b
                         inner join defRolefunction c
                            on b.role_code = c.rolecode
                         inner join sysFunction d
                            on c.funcid = d.funcid
                         where " + strSub + @"
                           and a.oper_code = ?
                         order by d.sortno";

                DataTable dt = null;
                IDataParameter[] objParamArr = objSvc.CreateParm(1);
                objParamArr[0].Value = empNo;
                dt = objSvc.GetDataTable(SQL, objParamArr);
                if (dt != null && dt.Rows.Count > 0)
                {
                    lstFuncID = new List<int>();
                    GetFuncID(parentID, dt);

                    int intFuncID = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        intFuncID = Function.Int(dr["funcid"]);
                        if (lstFuncID.IndexOf(intFuncID) < 0) continue;
                        lstSysModule.Add(GetSysModule(dr));
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
            }
            finally
            {
                objSvc = null;
            }

            return lstSysModule;
        }

        /// <summary>
        /// GetSysModule
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private EntitySysModule GetSysModule(DataRow dr)
        {
            EntitySysModule vo = new EntitySysModule();
            vo.FuncId = Function.Int(dr["funcid"]);
            vo.FuncCode = dr["funccode"].ToString();
            vo.FuncName = dr["funcname"].ToString();
            vo.FuncFile = dr["funcfile"].ToString();
            vo.FuncType = Function.Int(dr["functype"]);
            vo.OperName = dr["opername"].ToString();
            vo.ParentId = Function.Int(dr["parentid"]);
            vo.LeafFlag = Function.Int(dr["leafflag"]);
            vo.ImageSource = dr["imagesource"].ToString();
            vo.SortNo = Function.Int(dr["sortno"]);
            return vo;
        }
        #endregion

        #region 获取登录者信息
        /// <summary>
        /// 获取登录者信息
        /// </summary>
        /// <param name="strEmpNo"></param>
        /// <param name="loginVo"></param>
        /// <param name="hospitalVo"></param>
        /// <returns></returns>
        public void GetLoginInfo(string strEmpNo, ref EntityLogin loginVo, ref EntityHospital hospitalVo)
        {
            string SQL = string.Empty;
            string strValue = string.Empty;
            DataTable dtResult = null;
            loginVo = new EntityLogin();
            hospitalVo = new EntityHospital();

            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            IDataParameter[] objParamArr = null;
            try
            {
                EntityCodeOperator voEmp = new EntityCodeOperator();
                voEmp.disable = "F";
                voEmp.operCode = strEmpNo;
                List<EntityCodeOperator> lstEmployee = EntityTools.ConvertToEntityList<EntityCodeOperator>(svc.Select(voEmp, new List<string> { EntityCodeOperator.Columns.disable, EntityCodeOperator.Columns.operCode }));
                if (lstEmployee != null && lstEmployee.Count == 1)
                {
                    voEmp = lstEmployee[0];
                    EntityPlusOperator voEmpPlus = new EntityPlusOperator();
                    voEmpPlus.operCode = strEmpNo;
                    List<EntityPlusOperator> lstEmpPlus = EntityTools.ConvertToEntityList<EntityPlusOperator>(svc.Select(voEmpPlus, new List<string> { EntityPlusOperator.Columns.operCode }));
                    if (lstEmpPlus != null && lstEmpPlus.Count > 0) voEmpPlus = lstEmpPlus[0];

                    bool blnLock = false;
                    if (voEmp.acctStatus.ToString() == "1")
                    {
                        blnLock = true;
                        if (voEmp.acctLockDate != null)
                        {
                            strValue = SysParameter(72);
                            int intTemp = 24;//默认24小时后自动解锁
                            if (!string.IsNullOrEmpty(strValue))
                            {
                                intTemp = Function.Int(strValue);
                            }

                            if (intTemp != 0)
                            {
                                DateTime dtmLock = voEmp.acctLockDate.Value;
                                DateTime dtmNow = DateTime.Now;
                                if (dtmNow.Subtract(dtmLock).TotalHours >= intTemp)
                                {
                                    blnLock = false;
                                    Dictionary<string, object> dicSet = new Dictionary<string, object>();
                                    dicSet.Add(EntityCodeOperator.Columns.acctStatus, 0);
                                    dicSet.Add(EntityCodeOperator.Columns.acctLockDate, null);
                                    Dictionary<string, object> dicWhere = new Dictionary<string, object>();
                                    dicWhere.Add(EntityCodeOperator.Columns.operCode, strEmpNo);
                                    svc.Commit(svc.GetUpdateParm(voEmp, dicSet, dicWhere));
                                }
                            }
                        }
                    }

                    //loginVo.EmpId = voEmp.Empid.ToString();
                    loginVo.EmpNo = voEmp.operCode;
                    loginVo.EmpName = voEmp.operName;
                    //loginVo.Sex = voEmpPlus.Sex;
                    loginVo.Birthday = voEmpPlus.birth;
                    //loginVo.IdCard = voEmpPlus.Idcard;
                    loginVo.Tel = voEmpPlus.tel;
                    loginVo.Addr = voEmpPlus.addr;
                    //loginVo.IdentityFlag = voEmp.Identity;
                    loginVo.AdminlevelCode = voEmpPlus.dutyCode;
                    loginVo.TechLevelCode = voEmpPlus.rankCode;
                    //loginVo.SignKeyID = voEmp.Signdigital;
                    if (!string.IsNullOrEmpty(voEmp.pwd))
                        loginVo.Pwd = voEmp.pwd; //ESCryptography.Decrypt(voEmp.pwd);
                    else
                        loginVo.Pwd = string.Empty;
                    loginVo.LoginTime = svc.ServerTime().ToString("yyyy-MM-dd HH:mm:ss");
                    if (!string.IsNullOrEmpty(voEmpPlus.clsCode) && voEmpPlus.clsCode.Trim() == "01")
                        loginVo.EmpFlag = 1;
                    else if (!string.IsNullOrEmpty(voEmpPlus.clsCode) && voEmpPlus.clsCode.Trim() == "02")
                        loginVo.EmpFlag = 2;
                    else
                        loginVo.EmpFlag = 3;
                    loginVo.clsCode = voEmpPlus.clsCode.Trim();
                    // 是否管理员
                    if (loginVo.EmpNo.Trim() == "00") loginVo.IsAdmin = true;
                    //if (voEmp.Pwdusedate == null)
                    //    loginVo.PwdUseDate = null;
                    //else
                    //    loginVo.PwdUseDate = Convert.ToDateTime(voEmp.Pwdusedate.Value);
                    loginVo.AcctLock = blnLock;

                    #region 职称改从code_rank取值
                    //EntityCommonDic voComm = new EntityCommonDic();
                    //voComm.Status = 1;
                    //voComm.Classid = 1;
                    //voComm.Itemcode = loginVo.TechLevelCode;
                    //List<EntityCommonDic> lstComm = EntityTools.ConvertToEntityList<EntityCommonDic>(svc.Select(voComm, new List<string> { EntityCommonDic.Columns.Status, EntityCommonDic.Columns.Classid, EntityCommonDic.Columns.Itemcode }));
                    //if (lstComm.Count > 0)
                    //{
                    //    loginVo.TechLevelName = lstComm[0].Itemname;
                    //}

                    EntityCodeRank rankVo = new EntityCodeRank();
                    rankVo.rankCode = loginVo.TechLevelCode;
                    List<EntityCodeRank> lstRank = EntityTools.ConvertToEntityList<EntityCodeRank>(svc.Select(rankVo, new List<string> { EntityCodeRank.Columns.rankCode }));
                    if (lstRank.Count > 0)
                    {
                        loginVo.TechLevelName = lstRank[0].rankName;
                    }
                    #endregion

                    string strIDArr = string.Empty;
                    //DataTable dtTemp = null;
                    //if (loginVo.EmpFlag == 1 || loginVo.EmpFlag == 3)
                    //{
                    SQL = @"select b.defaultflag as defaultflag,
                                   null          as deptid,
                                   a.dept_code   as deptcode,
                                   a.dept_name   as deptname,
                                   a.py_code     as pycode,
                                   a.wb_code     as wbcode
                              from code_department a
                             inner join defDeptemployee b
                                on a.dept_code = b.deptcode
                             where b.opercode = ?";
                    objParamArr = svc.CreateParm(1);
                    objParamArr[0].Value = loginVo.EmpNo;
                    dtResult = svc.GetDataTable(SQL, objParamArr);
                    if (dtResult.Rows.Count > 0)
                    {
                        EntityCodeDepartment deptVo = null;
                        loginVo.lstDept = new List<EntityCodeDepartment>();
                        foreach (DataRow dr in dtResult.Rows)
                        {
                            deptVo = new EntityCodeDepartment();
                            //deptVo.Deptid = Function.Int(dr["deptid"]);
                            deptVo.deptCode = dr["deptcode"].ToString();
                            deptVo.deptName = dr["deptname"].ToString();
                            deptVo.pyCode = dr["pycode"].ToString().ToUpper();
                            deptVo.wbCode = dr["wbcode"].ToString().ToUpper();
                            loginVo.lstDept.Add(deptVo);
                            if (Function.Int(dr["defaultflag"]) == 1)
                            {
                                //loginVo.DeptID = Function.Int(deptVo.Deptid);
                                loginVo.DeptName = deptVo.deptName;
                                loginVo.DeptCode = dr["deptcode"].ToString();

                                //                                    SQL = @"select b.areaid,
                                //                                                   b.areaname,
                                //                                                   b.pycode,
                                //                                                   b.wbcode,
                                //                                                   '' as c_code
                                //                                              from defDeptarea a
                                //                                              left join dicArea b
                                //                                                on a.areaid = b.areaid                                              
                                //                                             where a.deptid = ?";

                                //                                    objParamArr = svc.CreateParm(1);
                                //                                    objParamArr[0].Value = deptVo.Deptid;
                                //                                    dtTemp = svc.GetDataTable(SQL, objParamArr);
                                //                                    if (dtTemp != null && dtTemp.Rows.Count > 0)
                                //                                    {
                                //                                        loginVo.AreaID = Function.Int(dtTemp.Rows[0]["areaid"]);
                                //                                        loginVo.AreaName = dtTemp.Rows[0]["areaname"].ToString();
                                //                                        loginVo.DeptCode_zy = dtTemp.Rows[0]["c_code"].ToString();
                                //                                    }
                            }
                            //strIDArr += dr["deptid"].ToString() + ",";
                        }

                        //                            SQL = @"select distinct b.areaid, b.areaname, b.pycode, b.wbcode
                        //                                      from defDeptarea a, dicArea b
                        //                                     where a.areaid = b.areaid
                        //                                       and a.deptid in (" + strIDArr.Substring(0, strIDArr.Length - 1) + ")";
                        //                            dtResult = svc.GetDataTable(SQL);
                        //                            if (dtResult.Rows.Count > 0)
                        //                            {
                        //                                EntityArea dcAreaInfo = null;
                        //                                loginVo.lstArea = new List<EntityArea>();
                        //                                foreach (DataRow dr in dtResult.Rows)
                        //                                {
                        //                                    dcAreaInfo = new EntityArea();
                        //                                    dcAreaInfo.Areaid = Function.Int(dr["areaid"]);
                        //                                    dcAreaInfo.Areaname = dr["areaname"].ToString();
                        //                                    dcAreaInfo.Pycode = dr["pycode"].ToString();
                        //                                    dcAreaInfo.Wbcode = dr["wbcode"].ToString();
                        //                                    loginVo.lstArea.Add(dcAreaInfo);
                        //                                }
                        //                            }
                        //                        }
                        //                    }
                        //                    else if (loginVo.EmpFlag == 2)
                        //                    {
                        //                        SQL = @"select a.defaultflag, b.areaid, b.areaname, b.pycode, b.wbcode
                        //                                  from defDeptemployee a, dicArea b
                        //                                 where a.deptid = b.areaid
                        //                                   and a.attrflag = 2
                        //                                   and a.empid = ?";
                        //                        objParamArr = svc.CreateParm(1);
                        //                        objParamArr[0].Value = loginVo.EmpId;
                        //                        dtResult = svc.GetDataTable(SQL, objParamArr);
                        //                        if (dtResult.Rows.Count > 0)
                        //                        {
                        //                            EntityArea dcAreaInfo = null;
                        //                            loginVo.lstArea = new List<EntityArea>();
                        //                            foreach (DataRow dr in dtResult.Rows)
                        //                            {
                        //                                dcAreaInfo = new EntityArea();
                        //                                dcAreaInfo.Areaid = Function.Int(dr["areaid"]);
                        //                                dcAreaInfo.Areaname = dr["areaname"].ToString();
                        //                                dcAreaInfo.Pycode = dr["pycode"].ToString();
                        //                                dcAreaInfo.Wbcode = dr["wbcode"].ToString();
                        //                                loginVo.lstArea.Add(dcAreaInfo);
                        //                                if (Function.Int(dr["defaultflag"]) == 1)
                        //                                {
                        //                                    loginVo.AreaID = Function.Int(dcAreaInfo.Areaid);
                        //                                    loginVo.AreaName = dcAreaInfo.Areaname;

                        //                                    SQL = @"select b.deptid, b.deptname, b.deptcode, b.pycode, b.wbcode
                        //                                              from defDeptarea a, dicDepartment b
                        //                                             where a.deptid = b.deptid
                        //                                               and a.areaid = ?";

                        //                                    objParamArr = svc.CreateParm(1);
                        //                                    objParamArr[0].Value = dcAreaInfo.Areaid;
                        //                                    dtTemp = svc.GetDataTable(SQL, objParamArr);
                        //                                    if (dtTemp != null && dtTemp.Rows.Count > 0)
                        //                                    {
                        //                                        loginVo.DeptID = Function.Int(dtTemp.Rows[0]["deptid"]);
                        //                                        loginVo.DeptName = dtTemp.Rows[0]["deptname"].ToString();
                        //                                        loginVo.DeptCode = dtTemp.Rows[0]["deptcode"].ToString();
                        //                                    }
                        //                                }
                        //                                strIDArr += dr["areaid"].ToString() + ",";
                        //                            }

                        //                            SQL = @"select distinct b.deptid, b.deptcode, b.deptname, b.pycode, b.wbcode
                        //                                      from defDeptarea a, dicDepartment b
                        //                                     where a.deptid = b.deptid
                        //                                       and a.areaid in (" + strIDArr.Substring(0, strIDArr.Length - 1) + ")";
                        //                            dtResult = svc.GetDataTable(SQL);
                        //                            if (dtResult.Rows.Count > 0)
                        //                            {
                        //                                EntityDepartment dcDeptInfo = null;
                        //                                loginVo.lstDept = new List<EntityDepartment>();
                        //                                foreach (DataRow dr in dtResult.Rows)
                        //                                {
                        //                                    dcDeptInfo = new EntityDepartment();
                        //                                    dcDeptInfo.Deptid = Function.Int(dr["deptid"]);
                        //                                    dcDeptInfo.Deptcode = dr["deptcode"].ToString();
                        //                                    dcDeptInfo.Deptname = dr["deptname"].ToString();
                        //                                    dcDeptInfo.Pycode = dr["pycode"].ToString();
                        //                                    dcDeptInfo.Wbcode = dr["wbcode"].ToString();
                        //                                    loginVo.lstDept.Add(dcDeptInfo);
                        //                                }
                        //                            }
                    }
                    //}

                    if (loginVo != null)
                    {
                        EntityDefOperatorRole voRoleEmp = new EntityDefOperatorRole();
                        voRoleEmp.operCode = loginVo.EmpNo;
                        List<EntityDefOperatorRole> lstRoleEmp = EntityTools.ConvertToEntityList<EntityDefOperatorRole>(svc.Select(voRoleEmp, new List<string> { EntityDefOperatorRole.Columns.operCode }));
                        if (lstRoleEmp.Count > 0)
                        {
                            loginVo.lstRoleID = new List<string>();
                            foreach (EntityDefOperatorRole vo in lstRoleEmp)
                            {
                                loginVo.lstRoleID.Add(vo.roleCode);
                            }
                        }
                    }

                    EntityHospital voHospital = new EntityHospital();
                    List<EntityHospital> lstHospital = EntityTools.ConvertToEntityList<EntityHospital>(svc.Select(voHospital));
                    if (lstHospital.Count > 0)
                    {
                        hospitalVo = lstHospital[0];
                        GlobalHospital.HospitalName = hospitalVo.Hospitalname;
                    }

                    //密码有效期      
                    loginVo.PwdValidDays = Function.Int(SysParameter(2));
                }
                dtResult = null;
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
