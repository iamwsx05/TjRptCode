using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;

namespace Common.Biz
{
    /// <summary>
    /// 电子表单.Biz
    /// </summary>
    public class BizFormDesign : IDisposable
    {
        #region 表单

        #region 获取.电子申请单
        /// <summary>
        /// 获取.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="formVo"></param>
        public void GetForm(int formId, out EntityFormDesign formVo)
        {
            GetForm(formId, -1, out formVo);
        }
        /// <summary>
        /// 获取.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="version"></param>
        /// <param name="formVo"></param>
        public void GetForm(int formId, int version, out EntityFormDesign formVo)
        {
            string SQL = string.Empty;
            formVo = new EntityFormDesign();

            List<EntityFormDesign> main = GetForm(formId, true);
            if (main != null && main.Count > 0)
            {
                List<int> lstVersion = new List<int>();
                foreach (EntityFormDesign item in main)
                {
                    lstVersion.Add((int)item.Version);
                }
                if (version > 0)
                {
                    if (main.Exists(t => t.Version == version))
                    {
                        formVo = main.FirstOrDefault(t => t.Version == version);
                    }
                    else
                    {
                        formVo = null;
                    }
                }
                else
                {
                    formVo = main[main.Count - 1];
                }
                if (formVo != null) formVo.lstVersion = lstVersion;
            }
        }

        /// <summary>
        /// GetForm
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public List<EntityFormDesign> GetForm(int formId, bool isShowLayout)
        {
            string SQL = string.Empty;
            List<EntityFormDesign> lstForm = new List<EntityFormDesign>();
            EntityFormDesign vo = new EntityFormDesign();
            DataTable dt = null;

            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            IDataParameter[] paramArr = null;
            try
            {
                SQL = @"select t.formid,
                               t.formcode,
                               t.formname,
                               t.formtype,
                               t.version,
                               t.pycode,
                               t.wbcode,
                               t.panelsize,
                               {0}
                               t.printtemplateid,
                               t.recorderid,
                               t.recorddate,
                               t.status,
                               b.oper_name as empname
                          from emrFormDesign t
                          left join code_operator b
                            on t.recorderid = b.oper_code
                         ";
                if (isShowLayout)
                    SQL = string.Format(SQL, "t.layout,");
                else
                    SQL = string.Format(SQL, "");

                if (formId <= 0)
                {
                    SQL += @"order by t.version asc";
                    dt = svc.GetDataTable(SQL);
                }
                else
                {
                    SQL += @" where t.formid = ?
                           order by t.version asc";
                    paramArr = svc.CreateParm(1);
                    paramArr[0].Value = formId;
                    dt = svc.GetDataTable(SQL, paramArr);
                }

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        vo = new EntityFormDesign();
                        vo.Formid = Function.Int(dr["formid"]);
                        vo.Formcode = dr["formcode"].ToString();
                        vo.Formname = dr["formname"].ToString();
                        vo.Formtype = Function.Int(dr["formtype"].ToString());
                        vo.Version = Function.Int(dr["version"]);
                        vo.Pycode = dr["pycode"].ToString().ToUpper();
                        vo.Wbcode = dr["wbcode"].ToString().ToUpper();
                        vo.Panelsize = dr["panelsize"].ToString();
                        if (isShowLayout) vo.Layout = dr["layout"].ToString();
                        vo.Printtemplateid = Function.Int(dr["printtemplateid"].ToString());
                        vo.Recorderid = dr["recorderid"].ToString();
                        vo.RecorderName = dr["empname"].ToString();
                        vo.Recorddate = Convert.ToDateTime(dr["recorddate"].ToString());
                        vo.Status = Function.Int(dr["status"]);
                        vo.StatusName = (vo.Status == 1 ? "启用" : "停用");
                        lstForm.Add(vo);
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
                paramArr = null;
            }
            return lstForm;
        }
        #endregion

        #region 保存.电子申请单
        /// <summary>
        /// 保存.电子申请单
        /// </summary>
        /// <param name="formVo"></param>
        /// <param name="formId"></param>
        /// <returns></returns>
        public int SaveForm(EntityFormDesign formVo, out int formId)
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svc = null;
            formId = 0;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                List<DacParm> lstPara = new List<DacParm>();

                bool isExsit = true;
                if (formVo.Formid <= 0)
                {
                    isExsit = false;
                    formVo.Formid = svc.GetNextID(EntityTools.GetTableName(formVo), EntityTools.GetFieldName(formVo, EntityFormDesign.Columns.Formid));
                }
                lstPara.Add(svc.GetInsertParm(formVo));

                if (Function.Int(formVo.Formtype) < 3)
                {
                    if (isExsit == false)
                    {
                        string tbName = "emrFormRtf" + formVo.Formid.ToString();

                        // 自动生成
                        EntityEmrBasicInfo vo = new EntityEmrBasicInfo();
                        vo.typeId = 1;
                        vo.formId = formVo.Formid;
                        vo.caseName = formVo.Formname;
                        vo.caseCode = formVo.Formid.ToString();
                        vo.pyCode = SpellCodeHelper.GetPyCode(formVo.Formname);
                        vo.wbCode = SpellCodeHelper.GetWbCode(formVo.Formname);
                        vo.tableName = tbName;
                        vo.attribute = 0;
                        vo.showType = 0;
                        vo.caseStyle = 0;
                        vo.catalogId = 23;  // 其他类
                        vo.fieldXml = EmrTool.GetBasicFieldXml(formVo.Layout);
                        vo.status = 1;
                        lstPara.Add(svc.GetInsertParm(vo));

                        if (svc.enumDBMS == EnumDBMS.Oracle)
                        {


                        }
                        else
                        {
                            Sql = @"if exists (select 1
                                                from  sysobjects
                                               where  id = object_id('{0}')
                                                and   type = 'U')
                                       drop table {1}";
                            lstPara.Add(svc.GetDacParm(EnumExecType.ExecSql, string.Format(Sql, tbName, tbName)));

                            Sql = @"create table {0} (                               
                                           registerid           varchar(20)          not null,
                                           recorddate           datetime             not null,
                                           fieldname            varchar(50)          not null,
                                           rowindex             numeric(10,0)        not null,
                                           tablecode            varchar(100)         null,
                                           contentrtf           image                null,
                                           printrtf             image                null,
                                           isprint              numeric(1,0)         not null,
                                           constraint pk_{0} primary key (registerid, recorddate, fieldname, rowindex)
                                        )";
                        }

                        lstPara.Add(svc.GetDacParm(EnumExecType.ExecSql, string.Format(Sql, tbName, tbName)));
                    }
                    else
                    {
                        EntityEmrBasicInfo vo = new EntityEmrBasicInfo();
                        vo.formId = formVo.Formid;
                        vo.caseName = formVo.Formname;
                        vo.pyCode = SpellCodeHelper.GetPyCode(formVo.Formname);
                        vo.wbCode = SpellCodeHelper.GetWbCode(formVo.Formname);
                        vo.fieldXml = EmrTool.GetBasicFieldXml(formVo.Layout);
                        DataTable dt = svc.Select(vo, new List<string>() { EntityEmrBasicInfo.Columns.formId });
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            //lstPara.Add(svc.GetUpdateParm(vo, new List<string>() { EntityEmrBasicInfo.Columns.caseName, EntityEmrBasicInfo.Columns.pyCode,
                            //                                                   EntityEmrBasicInfo.Columns.wbCode, EntityEmrBasicInfo.Columns.fieldXml },
                            //                                  new List<string>() { EntityEmrBasicInfo.Columns.formId }));
                            Sql = @"update emrBasicInfo
                                       set caseName = ?, pyCode = ?, wbCode = ?, fieldXml = ?
                                     where formId = ?";

                            IDataParameter[] parms = svc.CreateParm(5);
                            parms[0].Value = vo.caseName;
                            parms[1].Value = vo.pyCode;
                            parms[2].Value = vo.wbCode;
                            parms[3].Value = vo.fieldXml;
                            if (!string.IsNullOrEmpty(vo.fieldXml) && vo.fieldXml.Trim() != null) parms[3].ParameterName = "xmltype";
                            parms[4].Value = vo.formId;
                            lstPara.Add(svc.GetDacParm(EnumExecType.ExecSql, Sql, parms));
                        }
                    }
                }
                if (formVo.Formid > 0)
                {
                    using (TransactionScope scope = svc.TransactionScope)
                    {
                        if (DelForm((int)formVo.Formid, (int)formVo.Version) < 0) return -1;
                        affectRows = svc.Commit(lstPara);
                        scope.Complete();
                    }
                }
                else
                {
                    affectRows = svc.Commit(lstPara);
                }
                formId = (int)formVo.Formid;
                if (formId > 0 && affectRows <= 0) affectRows = 1;
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
                affectRows = -1;
            }
            finally
            {
                svc = null;
            }
            return affectRows;
        }
        #endregion

        #region 删除.电子申请单
        /// <summary>
        /// 删除.电子申请单
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public int DelForm(int formId, int version)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityFormDesign po = new EntityFormDesign();
                po.Formid = formId;
                po.Version = version;
                DataTable dt = svc.Select(po, new List<string> { EntityFormDesign.Columns.Formid, EntityFormDesign.Columns.Version });
                if (dt != null && dt.Rows.Count > 0)
                {
                    DacParm para = svc.GetDelParm(po, new List<string>() { EntityFormDesign.Columns.Formid, EntityFormDesign.Columns.Version });
                    affectRows = svc.Commit(para);
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
                affectRows = -1;
            }
            finally
            {
                svc = null;
            }
            return affectRows;
        }
        #endregion

        #region 更新.电子申请单.打印
        /// <summary>
        /// 更新.电子申请单.打印
        /// </summary>
        /// <param name="formVo"></param>
        /// <returns></returns>
        public int UpdateFormPrint(EntityFormDesign formVo)
        {
            int affectRows = 0;
            //SqlHelper svc = null;
            //try
            //{
            //    svc = new SqlHelper(EnumBiz.onlineDB);
            //    DacParm para = svc.GetUpdateParm(eForm, new List<string>() { EntityFormDesign.Columns.Printfilename, EntityFormDesign.Columns.Printfiledata },
            //                                            new List<string>() { EntityFormDesign.Columns.Formid });
            //    affectRows = svc.Commit(para);
            //}
            //catch (Exception e)
            //{
            //    ExceptionLog.OutPutException(e);
            //    affectRows = -1;
            //}
            //finally
            //{
            //    svc = null;
            //}
            return affectRows;
        }
        #endregion


        #endregion

        #region 表单打印模板

        #region 获取.表单打印模板
        /// <summary>
        /// 获取.表单打印模板
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public EntityEmrPrintTemplate GetFormPrintTemplate(int idType, string templateId)
        {
            SqlHelper svc = null;
            EntityEmrPrintTemplate vo = null;
            try
            {
                DataTable dt = null;
                svc = new SqlHelper(EnumBiz.onlineDB);
                vo = new EntityEmrPrintTemplate();
                if (idType == 1)
                {
                    vo.templateId = Function.Dec(templateId);
                    dt = svc.SelectPk(vo);
                }
                else if (idType == 2)
                {
                    vo.templateCode = templateId;
                    dt = svc.Select(vo, EntityEmrPrintTemplate.Columns.templateCode);
                }
                if (dt != null && dt.Rows.Count > 0)
                {
                    vo = EntityTools.ConvertToEntityList<EntityEmrPrintTemplate>(dt)[0];
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
            return vo;
        }
        #endregion

        #region 删除.表单打印模板
        /// <summary>
        /// 删除.表单打印模板
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public int DelFormPrintTemplate(int templateId)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityEmrPrintTemplate vo = new EntityEmrPrintTemplate();
                vo.templateId = templateId;
                DataTable dt = svc.SelectPk(vo);
                if (dt != null && dt.Rows.Count > 0)
                {
                    DacParm para = svc.GetDelParmByPk(vo);
                    affectRows = svc.Commit(para);
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
                affectRows = -1;
            }
            finally
            {
                svc = null;
            }
            return affectRows;
        }
        #endregion

        #region 保存.表单打印模板
        /// <summary>
        /// 保存.表单打印模板
        /// </summary>
        /// <param name="templateVo"></param>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public int SaveFormPrintTemplate(EntityEmrPrintTemplate templateVo, out int templateId)
        {
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svc = null;
            templateId = 0;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                List<DacParm> lstPara = new List<DacParm>();

                bool isExsit = true;
                if (templateVo.templateId <= 0)
                {
                    isExsit = false;
                    templateVo.templateId = svc.GetNextID(EntityTools.GetTableName(templateVo), EntityTools.GetFieldName(templateVo, EntityEmrPrintTemplate.Columns.templateId));
                }
                lstPara.Add(svc.GetInsertParm(templateVo));

                if (templateVo.templateId > 0)
                {
                    using (TransactionScope scope = svc.TransactionScope)
                    {
                        if (DelFormPrintTemplate((int)templateVo.templateId) < 0) return -1;
                        affectRows = svc.Commit(lstPara);
                        scope.Complete();
                    }
                }
                else
                {
                    affectRows = svc.Commit(lstPara);
                }
                templateId = (int)templateVo.templateId;
                if (templateId > 0 && affectRows <= 0) affectRows = 1;
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
                affectRows = -1;
            }
            finally
            {
                svc = null;
            }
            return affectRows;
        }
        #endregion

        #region 更新.表单打印模板
        /// <summary>
        /// 更新.表单打印模板
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int UpdateFormPrintTemplate(EntityEmrPrintTemplate vo)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                affectRows = svc.Commit(svc.GetUpdateParm(vo, new List<string> { EntityEmrPrintTemplate.Columns.templateFile }, new List<string> { EntityEmrPrintTemplate.Columns.templateId }));
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
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

        #region 表格

        #region 获取.表格资料

        #region 表格主表
        /// <summary>
        /// 表格主表
        /// </summary>
        /// <param name="tableCode"></param>
        /// <returns></returns>
        public EntityEmrTableBasicInfo GetGetTableMainInfo(string tableCode)
        {
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityEmrTableBasicInfo vo = new EntityEmrTableBasicInfo();
                vo.tableCode = tableCode;
                DataTable dt = svc.Select(vo, EntityEmrTableBasicInfo.Columns.tableCode);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return EntityTools.ConvertToEntityList<EntityEmrTableBasicInfo>(dt)[0];
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

        #region 表格明细
        /// <summary>
        /// 表格明细
        /// </summary>
        /// <param name="tableCode"></param>
        /// <returns></returns>
        public List<EntityEmrTableFieldInfo> GetTableFieldInfo(string tableCode)
        {
            List<EntityEmrTableFieldInfo> data = new List<EntityEmrTableFieldInfo>();
            EntityEmrTableFieldInfo vo = null;
            SqlHelper svc = null;

            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                vo = new EntityEmrTableFieldInfo();
                vo.tableCode = tableCode;
                DataTable dt = svc.Select(vo, EntityEmrTableFieldInfo.Columns.tableCode);
                DataView dv = new DataView(dt);
                dv.Sort = "sortNo";
                data = EntityTools.ConvertToEntityList<EntityEmrTableFieldInfo>(dv.ToTable());
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

        #region 检查表格编码、名称是否存在
        /// <summary>
        /// 检查表格编码、名称是否存在 
        /// </summary>
        /// <param name="tableCode"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public bool IsExistsTableCodeOrName(string tableCode, string tableName)
        {
            string Sql = string.Empty;
            SqlHelper svc = null;
            IDataParameter[] parm = null;
            try
            {
                Sql = @"select 1 from emrTableBasicInfo t where t.tablecode = ? or t.tablename = ?";
                svc = new SqlHelper(EnumBiz.onlineDB);
                parm = svc.CreateParm(2);
                parm[0].Value = tableCode;
                parm[1].Value = tableName;
                DataTable dt = svc.GetDataTable(Sql, parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
                parm = null;
            }
            return false;
        }
        #endregion

        #endregion

        #region 删除表格
        /// <summary>
        /// 删除表格
        /// </summary>
        /// <param name="tableCode"></param>
        /// <returns></returns>
        public int DeleteTableInfo(string tableCode)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                EntityEmrTableFieldInfo fieldVo = new EntityEmrTableFieldInfo();
                fieldVo.tableCode = tableCode;
                lstParm.Add(svc.GetDelParm(fieldVo, EntityEmrTableFieldInfo.Columns.tableCode));

                EntityEmrTableBasicInfo tableVo = new EntityEmrTableBasicInfo();
                tableVo.tableCode = tableCode;
                lstParm.Add(svc.GetDelParm(tableVo, EntityEmrTableBasicInfo.Columns.tableCode));

                affectRows = svc.Commit(lstParm);
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
                affectRows = -1;
            }
            finally
            {
                svc = null;
            }
            return affectRows;
        }
        #endregion

        #region 保存表格
        /// <summary>
        /// 保存表格
        /// </summary>
        /// <param name="tableVo"></param>
        /// <param name="lstTableField"></param>
        /// <returns></returns>
        public int SaveTableInfo(EntityEmrTableBasicInfo tableVo, List<EntityEmrTableFieldInfo> lstTableField)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                bool haveFields = (lstTableField != null && lstTableField.Count > 0 ? true : false);
                svc = new SqlHelper(EnumBiz.onlineDB);
                List<DacParm> lstParm = new List<DacParm>();
                if (!string.IsNullOrEmpty(tableVo.origTableCode))
                {
                    if (tableVo.origTableCode == tableVo.tableCode)
                    {
                        lstParm.Add(svc.GetUpdateParmByPk(tableVo));
                        EntityEmrTableFieldInfo vo2 = new EntityEmrTableFieldInfo();
                        vo2.tableCode = tableVo.tableCode;
                        lstParm.Add(svc.GetDelParm(vo2, EntityEmrTableFieldInfo.Columns.tableCode));
                    }
                    else
                    {
                        EntityEmrTableBasicInfo vo1 = new EntityEmrTableBasicInfo();
                        vo1.tableCode = tableVo.origTableCode;
                        lstParm.Add(svc.GetDelParmByPk(vo1));
                        lstParm.Add(svc.GetInsertParm(tableVo));

                        EntityEmrTableFieldInfo vo2 = new EntityEmrTableFieldInfo();
                        vo2.tableCode = tableVo.origTableCode;
                        lstParm.Add(svc.GetDelParm(vo2, EntityEmrTableFieldInfo.Columns.tableCode));
                    }
                    if (haveFields) lstParm.Add(svc.GetInsertParm(lstTableField.ToArray()));
                }
                else
                {
                    lstParm.Add(svc.GetInsertParm(tableVo));
                    if (haveFields) lstParm.Add(svc.GetInsertParm(lstTableField.ToArray()));
                }
                affectRows = svc.Commit(lstParm);
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
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

        #region 打印

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
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
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
