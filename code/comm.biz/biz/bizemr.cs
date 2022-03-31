using Common.Entity;
using weCare.Core.Dac;
using weCare.Core.Entity;
using weCare.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;

namespace Common.Biz
{
    /// <summary>
    /// EMR
    /// </summary>
    public class BizEmr : IDisposable
    {
        #region 病历基础信息

        #region 病历基础信息.保存
        /// <summary>
        /// 病历基础信息.保存
        /// </summary>
        /// <param name="caseVo"></param>
        /// <param name="lstCaseDept"></param>
        /// <returns></returns>
        public bool SaveCaseBasicInfo(ref EntityEmrBasicInfo caseVo, List<EntityEmrDept> lstCaseDept)
        {
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);

                if (caseVo.serNo > 0)
                {
                    EntityEmrBasicInfo vo = new EntityEmrBasicInfo();
                    vo.serNo = caseVo.serNo;
                    lstParm.Add(svc.GetDelParm(vo, EntityEmrBasicInfo.Columns.serNo));
                }
                lstParm.Add(svc.GetInsertParm(caseVo));

                EntityEmrDept vo2 = new EntityEmrDept();
                vo2.caseCode = caseVo.caseCode;
                lstParm.Add(svc.GetDelParm(vo2, EntityEmrDept.Columns.caseCode));

                if (lstCaseDept != null && lstCaseDept.Count > 0)
                {
                    lstParm.Add(svc.GetInsertParm(lstCaseDept.ToArray()));
                }

                int affectRows = svc.Commit(lstParm);
                return ((affectRows > 0) ? true : false);
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
                return false;
            }
            finally
            {
                svc = null;
            }
        }
        #endregion

        #region 病历基础信息.删除
        /// <summary>
        /// 病历基础信息.删除
        /// </summary>
        /// <param name="serNo"></param>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        public bool DeleteCaseBasicInfo(int serNo, string caseCode)
        {
            SqlHelper svc = null;
            try
            {
                List<DacParm> lstParm = new List<DacParm>();
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityEmrBasicInfo vo = new EntityEmrBasicInfo();
                vo.serNo = serNo;
                lstParm.Add(svc.GetDelParm(vo, EntityEmrBasicInfo.Columns.serNo));

                EntityEmrDept vo2 = new EntityEmrDept();
                vo2.caseCode = caseCode;
                lstParm.Add(svc.GetDelParm(vo2, EntityEmrDept.Columns.caseCode));

                int affectRows = svc.Commit(lstParm);
                return ((affectRows > 0) ? true : false);
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
                return false;
            }
            finally
            {
                svc = null;
            }
        }
        #endregion

        #region GetCaseDept
        /// <summary>
        /// GetCaseDept
        /// </summary>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        public List<EntityEmrDept> GetCaseDept(string caseCode)
        {
            SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
            EntityEmrDept vo = new EntityEmrDept();
            vo.caseCode = caseCode;
            DataTable dt = svc.Select(vo, EntityEmrDept.Columns.caseCode);
            if (dt != null && dt.Rows.Count > 0)
                return EntityTools.ConvertToEntityList<EntityEmrDept>(dt);
            else
                return null;
        }
        #endregion

        #region SaveCaseDept
        /// <summary>
        /// SaveCaseDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int SaveCaseDept(EntityEmrDept vo)
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

        #region DelCaseDept
        /// <summary>
        /// DelCaseDept
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int DelCaseDept(EntityEmrDept vo)
        {
            int affectRows = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                affectRows = svc.Commit(svc.GetDelParmByPk(vo));
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

        #region 元素模板

        #region 获取元素模板
        /// <summary>
        /// 获取元素模板
        /// </summary>
        /// <param name="elementID"></param>
        /// <returns></returns>
        public List<EntityElementTemplate> GetElementTemplate(int elementID)
        {
            string SQL = string.Empty;
            List<EntityElementTemplate> data = new List<EntityElementTemplate>();
            SqlHelper svc = null;
            try
            {
                SQL = @"select a.serno, a.elementid, a.colcontent, b.serno as linkserno
                          from emrElementTemplateContent a
                          left join emrElementTemplateLinkage b on a.serno = b.elementid
                                                               and b.status = 1
                         where a.elementid = ?
                           and a.status = 1";

                svc = new SqlHelper(EnumBiz.onlineDB);
                IDataParameter[] parm = svc.CreateParm(1);
                parm[0].Value = elementID;
                DataTable dt = svc.GetDataTable(SQL, parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    EntityElementTemplate vo = null;
                    foreach (DataRow dr in dt.Rows)
                    {
                        vo = new EntityElementTemplate();
                        vo.serno = Function.Int(dr["serno"]);
                        vo.elementid = Function.Int(dr["elementid"]);
                        vo.colcontent = dr["colcontent"].ToString();
                        if (dr["linkserno"] != DBNull.Value)
                            vo.linkSerno = Function.Int(dr["linkserno"]);
                        else
                            vo.linkSerno = null;
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

        #region 获取表格最大行索引号
        /// <summary>
        /// 获取表格最大行索引号
        /// </summary>
        /// <param name="regID"></param>
        /// <param name="dbTableName"></param>
        /// <param name="tableCode"></param>
        /// <param name="recordDate"></param>
        /// <returns></returns>
        public int GetTableMaxRowIndex(string regID, string dbTableName, string tableCode, DateTime? recordDate)
        {
            int rowIndex = 0;
            string Sql = string.Empty;
            SqlHelper svc = null;
            try
            {
                bool multiFlag = (GetCaseMultiPageFlag(dbTableName) && recordDate != null ? true : false);
                IDataParameter[] parm = null;
                svc = new SqlHelper(EnumBiz.onlineDB);
                if (multiFlag)
                {
                    Sql = @"select t.xmlData from {0} t where t.registerId = ? and t.recordDate = ?";
                    parm = svc.CreateParm(2);
                    parm[0].Value = regID;
                    parm[1].Value = recordDate.Value;
                }
                else
                {
                    Sql = @"select t.xmlData from {0} t where t.registerId = ?";
                    parm = svc.CreateParm(1);
                    parm[0].Value = regID;
                }
                Sql = string.Format(Sql, dbTableName);
                DataTable dt = svc.GetDataTable(Sql, parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string xmlData = dt.Rows[0][0].ToString();
                    if (!string.IsNullOrEmpty(xmlData))
                    {
                        DataSet ds = Function.ReadXml(xmlData);
                        if (ds.Tables.Contains("Row"))
                        {
                            DataRow[] drr = ds.Tables["Row"].Select("tableCode = '" + tableCode + "'");
                            if (drr != null)
                            {
                                foreach (DataRow dr in drr)
                                {
                                    rowIndex = Math.Max(Function.Int(dr["rowIndex"].ToString()), rowIndex);
                                }
                            }
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
            return rowIndex;
        }

        #endregion

        #region 获取表单多页标志
        /// <summary>
        /// 获取表单多页标志
        /// </summary>
        /// <param name="dbTableName"></param>
        /// <returns></returns>
        bool GetCaseMultiPageFlag(string dbTableName)
        {
            SqlHelper svc = null;
            try
            {
                EntityEmrBasicInfo vo = new EntityEmrBasicInfo();
                vo.tableName = dbTableName;
                svc = new SqlHelper(EnumBiz.onlineDB);
                DataTable dt = svc.Select(vo, new List<string> { EntityEmrBasicInfo.Columns.tableName });
                if (dt != null && dt.Rows.Count > 0)
                {
                    if (Function.Int(dt.Rows[0][EntityTools.GetFieldName(vo, EntityEmrBasicInfo.Columns.multiPageFlag)]) == 1)
                    {
                        return true;
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
            return false;
        }
        #endregion

        #region 表格病历

        #region 获取表格病历数据
        /// <summary>
        /// 获取表格病历数据
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dbTableName"></param>
        /// <param name="tableCode"></param>
        /// <param name="fromRowIndex"></param>
        /// <param name="toRowIndex"></param>
        /// <param name="recordDate"></param>
        /// <param name="lstCaseRecord"></param>
        /// <param name="lstSignature"></param>
        /// <returns></returns>
        public int GetCaseTable(string regId, string dbTableName, string tableCode, int fromRowIndex, int toRowIndex, DateTime? recordDate, out List<EntityEmrData> lstCaseRecord, out List<EntitySignature> lstSignature)
        {
            int intRet = 0;
            string Sql = string.Empty;
            lstCaseRecord = new List<EntityEmrData>();
            lstSignature = new List<EntitySignature>();
            SqlHelper svc = null;
            try
            {
                bool multiFlag = (GetCaseMultiPageFlag(dbTableName) && recordDate != null ? true : false);
                IDataParameter[] parm = null;
                svc = new SqlHelper(EnumBiz.onlineDB);

                if (multiFlag)
                {
                    Sql = @"select t.xmlData from {0} t where t.registerId = ? and t.recordDate = ?";
                    parm = svc.CreateParm(2);
                    parm[0].Value = regId;
                    parm[1].Value = recordDate.Value;
                }
                else
                {
                    Sql = @"select t.xmlData from {0} t where t.registerId = ?";
                    parm = svc.CreateParm(1);
                    parm[0].Value = regId;
                }
                Sql = string.Format(Sql, dbTableName);
                DataTable dt = svc.GetDataTable(Sql, parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string xmlData = dt.Rows[0][0].ToString();
                    if (!string.IsNullOrEmpty(xmlData))
                    {
                        DataSet ds = Function.ReadXml(xmlData);
                        if (ds.Tables.Contains("Row"))
                        {
                            DataTable dtTable = ds.Tables["Row"];
                            DataTable dtClone = new DataTable();
                            foreach (DataColumn dc in dtTable.Columns)
                            {
                                if (dc.ColumnName == "rowIndex") dtClone.Columns.Add("rowIndex", typeof(int));
                                else dtClone.Columns.Add(dc.ColumnName, typeof(string));
                            }
                            dtClone.BeginLoadData();
                            foreach (DataRow dr in dtTable.Rows)
                            {
                                dtClone.LoadDataRow(dr.ItemArray, true);
                            }
                            dtClone.EndLoadData();
                            DataRow[] drr = dtClone.Select("tableCode = '" + tableCode + "' and rowIndex >= " + fromRowIndex + " and rowIndex <= " + toRowIndex);
                            if (drr != null)
                            {
                                lstCaseRecord = Dt2UniversalCaseRecord(regId, Function.GetTableColumnName(dtTable), drr);
                            }
                        }
                    }
                }

                Sql = @"select t.serno,
                               t.empid,
                               t.empname,
                               t.techlevelcode,
                               t.signdate,
                               t.registerid,
                               t.casecode,
                               t.commid,
                               t.commtypeid,
                               t.colcode,
                               t.tablecode,
                               t.signkeyid,
                               null as signcontent
                          from emrSignature t
                         where t.registerid = ?
                           and t.commtypeid = ?
                           and t.tablecode = ?
                           and t.commid >= ?
                           and t.commid <= ?";
                if (multiFlag)
                {
                    Sql += " and t.recorddate = ? ";
                    parm = svc.CreateParm(6);
                }
                else
                    parm = svc.CreateParm(5);
                parm[0].Value = regId;
                parm[1].Value = 3;
                parm[2].Value = tableCode;
                parm[3].Value = fromRowIndex;
                parm[4].Value = toRowIndex;
                if (multiFlag) parm[5].Value = recordDate.Value;
                dt = svc.GetDataTable(Sql, parm);
                if (lstCaseRecord != null && lstCaseRecord.Count > 0 && dt != null && dt.Rows.Count > 0)
                {
                    List<DataRow> lstDr = new List<DataRow>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (!lstCaseRecord.Exists(t => t.RowIndex.ToString() == dr["commid"].ToString() &&
                                                        t.FieldName == dr["colcode"].ToString() &&
                                                        t.FieldText.Contains(dr["empname"].ToString())))
                        {
                            lstDr.Add(dr);
                        }
                    }
                    if (lstDr.Count > 0)
                    {
                        foreach (DataRow dr in lstDr)
                        {
                            dt.Rows.Remove(dr);
                        }
                    }
                    lstSignature = Dt2Signature(regId, string.Empty, dt);
                }
                intRet = 1;
            }
            catch (Exception ex)
            {
                intRet = -1;
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return intRet;
        }
        /// <summary>
        /// Dt2UniversalCaseRecord
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="cols"></param>
        /// <param name="drr"></param>
        /// <returns></returns>
        List<EntityEmrData> Dt2UniversalCaseRecord(string regId, List<string> cols, DataRow[] drr)
        {
            EntityEmrData vo = null;
            List<EntityEmrData> data = new List<EntityEmrData>();
            if (drr != null && drr.Length > 0)
            {
                foreach (DataRow dr in drr)
                {
                    foreach (string colName in cols)
                    {
                        if (colName.ToLower() == "tablecode" || colName.ToLower() == "rowindex") continue;
                        vo = new EntityEmrData();
                        vo.RegisterId = regId;
                        vo.TableCode = dr["tablecode"].ToString(); ;
                        vo.RowIndex = Function.Int(dr["rowindex"]);
                        vo.FieldName = colName;
                        vo.FieldText = dr[colName].ToString();
                        vo.FieldMarkXml = string.Empty;
                        vo.FieldRtf = null;
                        vo.FieldPrtRtf = null;
                        vo.PrintFlag = 1;
                        data.Add(vo);
                    }
                }
            }
            return data;
        }

        /// <summary>
        /// Dt2UniversalCaseRecord
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        List<EntityEmrData> Dt2UniversalCaseRecord(string regId, DataTable dt)
        {
            EntityEmrData vo = null;
            List<EntityEmrData> data = new List<EntityEmrData>();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    vo = null;
                    vo.RegisterId = regId;
                    vo.TableCode = dr["tablecode"].ToString(); ;
                    vo.RowIndex = Function.Int(dr["rowindex"]);
                    vo.FieldName = dr["colcode"].ToString();
                    vo.FieldText = dr["colcontent"].ToString();
                    vo.FieldMarkXml = dr["colcontentxml"].ToString();
                    vo.FieldRtf = (dr["colcontentrtf"] == System.DBNull.Value ? null : (byte[])dr["colcontentrtf"]);
                    vo.FieldPrtRtf = (dr["colcontentprtrtf"] == System.DBNull.Value ? null : (byte[])dr["colcontentprtrtf"]);
                    vo.PrintFlag = Function.Int(dr["printflag"]);
                    data.Add(vo);
                }
            }
            return data;
        }

        /// <summary>
        /// Dt2Signature
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="caseCode"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        List<EntitySignature> Dt2Signature(string regId, string caseCode, DataTable dt)
        {
            EntitySignature vo = null;
            List<EntitySignature> data = new List<EntitySignature>();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    vo = new EntitySignature();
                    vo.serNo = Function.Dec(dr["serno"]);
                    vo.empId = dr["empid"].ToString();
                    vo.empName = dr["empname"].ToString();
                    vo.techLevelCode = dr["techlevelcode"].ToString();
                    vo.signDate = Function.Datetime(dr["signdate"]);
                    vo.registerId = regId;
                    vo.caseCode = caseCode;
                    if (dr["commid"] == DBNull.Value)
                        vo.commId = null;
                    else
                        vo.commId = Function.Int(dr["commid"]);
                    vo.commTypeId = Function.Int(dr["commtypeid"]);
                    vo.objectID = dr["colcode"].ToString();
                    vo.tableCode = dr["tablecode"].ToString();
                    vo.signKeyId = dr["signkeyid"].ToString();
                    vo.signContent = (dr["signcontent"] == System.DBNull.Value ? null : (byte[])dr["signcontent"]);
                    data.Add(vo);
                }
            }
            return data;
        }

        #endregion

        #region 插空行
        /// <summary>
        /// 插空行
        /// </summary>
        /// <param name="dbTableName"></param>
        /// <param name="lstCaseData"></param>
        /// <returns></returns>
        public int AppendBlankRow(string dbTableName, List<EntityEmrData> lstCaseData)
        {
            int n = -1;
            int affectRows = 0;
            string Sql = string.Empty;
            SqlHelper svc = null;
            try
            {
                bool multiFlag = (GetCaseMultiPageFlag(dbTableName) ? true : false);
                IDataParameter[] parm = null;
                svc = new SqlHelper(EnumBiz.onlineDB);

                if (multiFlag)
                {
                    Sql = @"select t.xmlData from {0} t where t.registerId = ? and t.recordDate = ?";
                    parm = svc.CreateParm(2);
                    parm[0].Value = lstCaseData[0].RegisterId;
                    parm[1].Value = lstCaseData[0].RecordDate;
                }
                else
                {
                    Sql = @"select t.xmlData from {0} t where t.registerId = ?";
                    parm = svc.CreateParm(1);
                    parm[0].Value = lstCaseData[0].RegisterId;
                }

                string xmlData = string.Empty;
                Sql = string.Format(Sql, dbTableName);
                DataTable dt = svc.GetDataTable(Sql, parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    xmlData = dt.Rows[0][0].ToString();
                    if (!string.IsNullOrEmpty(xmlData))
                    {
                        #region append

                        // 可能换页添加多个空行
                        List<int> lstRowIndex = new List<int>();
                        foreach (EntityEmrData item in lstCaseData)
                        {
                            if (lstRowIndex.IndexOf(item.RowIndex) < 0)
                            {
                                lstRowIndex.Add(item.RowIndex);
                            }
                        }
                        lstRowIndex.Sort();
                        string tableCode = lstCaseData[0].TableCode;
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(xmlData);
                        XmlNode root = xmlDoc.SelectSingleNode("FormData").SelectSingleNode("Table");
                        foreach (int appendRowIndex in lstRowIndex)
                        {
                            XmlElement xeRow = xmlDoc.CreateElement("Row");
                            // tableCode
                            XmlElement xeField = xmlDoc.CreateElement("tableCode");
                            xeField.InnerText = tableCode;
                            xeRow.AppendChild(xeField);
                            // rowIndex
                            xeField = xmlDoc.CreateElement("rowIndex");
                            xeField.InnerText = appendRowIndex.ToString();
                            xeRow.AppendChild(xeField);

                            List<EntityEmrData> lstRowData = lstCaseData.FindAll(t => t.RowIndex == appendRowIndex);
                            foreach (EntityEmrData item in lstRowData)
                            {
                                xeField = xmlDoc.CreateElement(item.FieldName);
                                xeField.InnerText = item.FieldText;
                                xeRow.AppendChild(xeField);
                            }
                            root.AppendChild(xeRow);
                        }
                        #endregion

                        #region update                        
                        xmlData = xmlDoc.InnerXml;
                        if (multiFlag)
                        {
                            Sql = @"update {0} set xmlData = ? where registerId = ? and recordDate = ?";
                            parm = svc.CreateParm(3);
                            parm[0].Value = xmlData;
                            if (!string.IsNullOrEmpty(xmlData) && xmlData.Trim() != "") parm[0].ParameterName = "xmltype";
                            parm[1].Value = lstCaseData[0].RegisterId;
                            parm[2].Value = lstCaseData[0].RecordDate;
                        }
                        else
                        {
                            Sql = @"update {0} set xmlData = ? where registerId = ?";
                            parm = svc.CreateParm(2);
                            parm[0].Value = xmlData;
                            if (!string.IsNullOrEmpty(xmlData) && xmlData.Trim() != "") parm[0].ParameterName = "xmltype";
                            parm[1].Value = lstCaseData[0].RegisterId;
                        }
                        Sql = string.Format(Sql, dbTableName);
                        affectRows = svc.ExecSql(Sql, parm);
                        #endregion
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
            return affectRows;
        }
        #endregion

        #region 复制列标题
        /// <summary>
        /// 复制列标题
        /// </summary>
        /// <param name="p_intRegisterID"></param>
        /// <param name="p_strCaseCode"></param>
        /// <param name="p_intPageNo"></param>
        /// <returns></returns>
        public int CopySelfDefineCol(string regId, string caseCode, int pageNo, List<EntityCasTablePagePatInfoCell> lstTabPagePatInfo)
        {
            int intRet = 0;
            string SQL = string.Empty;
            string strSub = string.Empty;
            SqlHelper svc = null;
            try
            {
                if (lstTabPagePatInfo != null && lstTabPagePatInfo.Count > 0)
                {
                    foreach (var item in lstTabPagePatInfo)
                    {
                        strSub += "'" + item.strDBColCode + "',";
                    }
                    strSub = " and colcode not in (" + strSub.Substring(0, strSub.Length - 1) + ")";
                }

                SQL = @"delete from emrselfdefinecol
                            where registerid = ?
                              and casecode = ?
                              and pageno = ? ";

                svc = new SqlHelper(EnumBiz.onlineDB);
                IDataParameter[] parm = svc.CreateParm(3);
                parm[0].Value = regId;
                parm[1].Value = caseCode;
                parm[2].Value = pageNo + 1;
                intRet = svc.ExecSql(SQL, parm);

                SQL = @"insert into emrselfdefinecol
                                      (
                                        registerid,
                                        casecode,
                                        colcode,
                                        coldesc,
                                        pageno
                                      )
                                    select registerid,
                                           casecode,
                                           colcode,
                                           coldesc,
                                           pageno + 1
                                      from emrselfdefinecol
                                     where registerid = ?
                                       and casecode = ?
                                       and pageno = ?";

                if (!string.IsNullOrEmpty(strSub)) SQL += strSub;

                parm = svc.CreateParm(3);
                parm[0].Value = regId;
                parm[1].Value = caseCode;
                parm[2].Value = pageNo;
                intRet = svc.ExecSql(SQL, parm);

                if (!string.IsNullOrEmpty(strSub))
                {
                    EntityEmrSelfDefineCol vo = null;
                    foreach (var item in lstTabPagePatInfo)
                    {
                        vo = new EntityEmrSelfDefineCol();
                        vo.registerId = regId;
                        vo.caseCode = caseCode;
                        vo.colCode = item.strDBColCode;
                        vo.colDesc = item.strDBColDesc;
                        vo.pageNo = pageNo + 1;
                        intRet = svc.Commit(svc.GetInsertParm(vo));
                    }
                }
            }
            catch (Exception ex)
            {
                intRet = 0;
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return intRet;
        }
        #endregion

        #region 满足条件的表格列值(按时间点)
        /// <summary>
        /// 满足条件的表格列值(按时间点)
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dbTableName"></param>
        /// <param name="tableCode"></param>
        /// <param name="timeColCode"></param>
        /// <param name="lstComputeColCode"></param>
        /// <param name="endRowNo"></param>
        /// <param name="strTime"></param>
        /// <param name="decSumValue"></param>
        /// <returns></returns>
        public int GetTableTimePointValue(string regId, string dbTableName, string tableCode, string timeColCode, List<string> lstComputeColCode, int endRowNo, string strTime, ref decimal decSumValue)
        {
            int intRet = -1;
            string Sql = string.Empty;
            decSumValue = 0;
            SqlHelper svc = null;
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                IDataParameter[] parm = svc.CreateParm(4);

                Sql = @"select t.xmlData from {0} t where t.registerId = ?";
                parm = svc.CreateParm(1);
                parm[0].Value = regId;
                Sql = string.Format(Sql, dbTableName);
                DataTable dt = svc.GetDataTable(Sql, parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string xmlData = dt.Rows[0][0].ToString();
                    if (!string.IsNullOrEmpty(xmlData))
                    {
                        DataSet ds = Function.ReadXml(xmlData);
                        if (ds.Tables.Contains("Row"))
                        {
                            int intRowIndex = -1;
                            DateTime dtmComp1 = Function.Datetime(strTime);
                            DateTime dtmComp2 = DateTime.Now;
                            string strContent = string.Empty;

                            DataTable dtTable = ds.Tables["Row"];
                            DataTable dtClone = new DataTable();
                            foreach (DataColumn dc in dtTable.Columns)
                            {
                                if (dc.ColumnName == "rowIndex") dtClone.Columns.Add("rowIndex", typeof(int));
                                else dtClone.Columns.Add(dc.ColumnName, typeof(string));
                            }
                            dtClone.BeginLoadData();
                            foreach (DataRow dr in dtTable.Rows)
                            {
                                dtClone.LoadDataRow(dr.ItemArray, true);
                            }
                            dtClone.EndLoadData();

                            DataView dvTable = new DataView(dtClone);
                            dvTable.Sort = "rowIndex asc";
                            dvTable.RowFilter = "tableCode = '" + tableCode + "' and rowIndex <= " + endRowNo;
                            foreach (DataRowView drv in dvTable)
                            {
                                strContent = drv[timeColCode].ToString();
                                if (!string.IsNullOrEmpty(strContent))
                                {
                                    DateTime.TryParse(strContent, out dtmComp2);
                                    if (dtmComp2 <= dtmComp1)
                                    {
                                        intRowIndex = Function.Int(drv["rowIndex"].ToString());
                                        break;
                                    }
                                }
                            }
                            if (intRowIndex >= 0)
                            {
                                dvTable.RowFilter = "1=1";
                                dvTable.RowFilter = "tableCode = '" + tableCode + "' and rowIndex >= " + intRowIndex + " and rowIndex <= " + endRowNo;
                                foreach (DataRowView drv in dvTable)
                                {
                                    decSumValue += Function.Dec(drv[timeColCode].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                intRet = 0;
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            finally
            {
                svc = null;
            }
            return intRet;
        }
        #endregion

        #region 删除表格行记录
        /// <summary>
        /// 删除表格行记录
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dbTableName"></param>
        /// <param name="caseCode"></param>
        /// <param name="tabCode"></param>
        /// <param name="tabRowNo"></param>
        /// <param name="recordDate"></param>
        /// <returns></returns>
        public int DelTableRowCase(string regId, string dbTableName, string caseCode, string tabCode, int tabRowNo, DateTime? recordDate)
        {
            int affectRows = 0;
            int count = 0;
            string Sql = string.Empty;

            try
            {
                bool multiFlag = (GetCaseMultiPageFlag(dbTableName) && recordDate != null ? true : false);
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                IDataParameter[] parm = null;
                if (multiFlag)
                {
                    Sql = @"select t.xmlData from {0} t where t.registerId = ? and t.recordDate = ?";
                    parm = svc.CreateParm(2);
                    parm[0].Value = regId;
                    parm[1].Value = recordDate.Value;
                }
                else
                {
                    Sql = @"select t.xmlData from {0} t where t.registerId = ?";
                    parm = svc.CreateParm(1);
                    parm[0].Value = regId;
                }
                string xmlData = string.Empty;
                Sql = string.Format(Sql, dbTableName);
                DataTable dt = svc.GetDataTable(Sql, parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    xmlData = dt.Rows[0][0].ToString();
                    if (!string.IsNullOrEmpty(xmlData))
                    {
                        #region 由于XML结果删除修改对于多表(tableCode)不方便，现改为dataset 2019-04-29
                        /*
                        #region del

                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(xmlData);
                        XmlNodeList rowNodes = xmlDoc.SelectSingleNode("FormData").SelectSingleNode("Table").ChildNodes;
                        for (int i = rowNodes.Count - 1; i >= 0; i--)
                        {
                            bool isTableOk = false;
                            bool isRowOk = false;
                            foreach (XmlNode item in rowNodes[i].ChildNodes)
                            {
                                if (item.Name == "tableCode" && item.InnerText == tabCode) isTableOk = true;
                                if (item.Name == "rowIndex" && int.Parse(item.InnerText) == tabRowNo) isRowOk = true;
                                if (isTableOk && isRowOk) break;
                            }
                            if (isTableOk && isRowOk)
                            {
                                rowNodes[i].ParentNode.RemoveChild(rowNodes[i]);
                                break;
                            }
                        }
                        #endregion

                        #region modify

                        rowNodes = xmlDoc.SelectSingleNode("FormData").SelectSingleNode("Table").ChildNodes;
                        for (int i = rowNodes.Count - 1; i >= 0; i--)
                        {
                            bool isTableOk = false;
                            bool isRowOk = false;
                            foreach (XmlNode item in rowNodes[i].ChildNodes)
                            {
                                if (item.Name == "tableCode" && item.InnerText == tabCode) isTableOk = true;
                                if (item.Name == "rowIndex" && int.Parse(item.InnerText) > tabRowNo) isRowOk = true;
                                if (isTableOk && isRowOk)
                                {
                                    item.InnerText = Convert.ToString(int.Parse(item.InnerText) - 1);
                                    break;
                                }
                            }
                        }
                        #endregion

                        // 结果
                        xmlData = xmlDoc.InnerXml;
                        */
                        #endregion

                        // DataSet 模式
                        DataSet ds = Function.ReadXml(xmlData);
                        if (ds.Tables != null && ds.Tables.Contains("Row"))
                        {
                            bool isRemove = false;
                            for (int i = ds.Tables["Row"].Rows.Count - 1; i >= 0; i--)
                            {
                                if (ds.Tables["Row"].Rows[i]["tableCode"].ToString() == tabCode && ds.Tables["Row"].Rows[i]["rowIndex"].ToString() == tabRowNo.ToString())
                                {
                                    ds.Tables["Row"].Rows.RemoveAt(i);
                                    isRemove = true;
                                    break;
                                }
                            }
                            if (isRemove)
                            {
                                ds.Tables["Row"].AcceptChanges();
                                for (int i = 0; i < ds.Tables["Row"].Rows.Count; i++)
                                {
                                    if (ds.Tables["Row"].Rows[i]["tableCode"].ToString() == tabCode && Function.Int(ds.Tables["Row"].Rows[i]["rowIndex"].ToString()) > tabRowNo)
                                    {
                                        ds.Tables["Row"].Rows[i]["rowIndex"] = Function.Int(ds.Tables["Row"].Rows[i]["rowIndex"]) - 1;
                                        isRemove = true;
                                    }
                                }
                                ds.Tables["Row"].AcceptChanges();

                                // 结果
                                xmlData = Function.ConvertDataSetToXML(ds);
                            }
                            else
                            {
                                return 0;
                            }
                        }
                        else
                        {
                            return 0;
                        }

                        #region update
                        if (multiFlag)
                        {
                            Sql = @"update {0} set xmlData = ? where registerId = ? and recordDate = ?";
                            parm = svc.CreateParm(3);
                            parm[0].Value = xmlData;
                            if (!string.IsNullOrEmpty(xmlData) && xmlData.Trim() != "") parm[0].ParameterName = "xmltype";
                            parm[1].Value = regId;
                            parm[2].Value = recordDate.Value;
                        }
                        else
                        {
                            Sql = @"update {0} set xmlData = ? where registerId = ?";
                            parm = svc.CreateParm(2);
                            parm[0].Value = xmlData;
                            if (!string.IsNullOrEmpty(xmlData) && xmlData.Trim() != "") parm[0].ParameterName = "xmltype";
                            parm[1].Value = regId;
                        } 
                        count += svc.ExecSql(string.Format(Sql, dbTableName), parm);

                        #endregion
                    }
                }

                Sql = @"delete from emrSignature where registerid = ? and casecode = ? and tablecode = ? and commid = ?";
                if (multiFlag)
                {
                    Sql += " and recorddate = ? ";
                    parm = svc.CreateParm(5);
                }
                else
                    parm = svc.CreateParm(4);
                parm[0].Value = regId;
                parm[1].Value = caseCode;
                parm[2].Value = tabCode;
                parm[3].Value = tabRowNo;
                if (multiFlag) parm[4].Value = recordDate.Value;
                count += svc.ExecSql(Sql, parm);

                Sql = @"update emrSignature 
                           set commid = commid - 1 
                         where registerid = ?
                           and casecode = ? 
                           and tablecode = ?
                           and commid > ?";
                if (multiFlag)
                {
                    Sql += " and recorddate = ? ";
                    parm = svc.CreateParm(5);
                }
                else
                    parm = svc.CreateParm(4);
                parm[0].Value = regId;
                parm[1].Value = caseCode;
                parm[2].Value = tabCode;
                parm[3].Value = tabRowNo;
                if (multiFlag) parm[4].Value = recordDate.Value;
                affectRows = svc.ExecSql(Sql, parm);
                count += affectRows;

                Sql = @"select 1 from " + dbTableName + " where registerid = ?";
                if (multiFlag)
                {
                    Sql += " and recorddate = ? ";
                    parm = svc.CreateParm(2);
                }
                else
                {
                    parm = svc.CreateParm(1);
                }
                parm[0].Value = regId;
                if (multiFlag)
                {
                    parm[1].Value = recordDate.Value;
                }
                dt = svc.GetDataTable(Sql, parm);
                if (dt != null)
                {
                    if (dt.Rows.Count == 0)
                    {
                        //置病历书写记录标志位
                        Sql = "update emrPatientRecord set status = 0 where registerid = ? and casecode = ?";
                        if (multiFlag)
                        {
                            Sql += " and recorddate = ? ";
                            parm = svc.CreateParm(3);
                        }
                        else
                            parm = svc.CreateParm(2);
                        parm[0].Value = regId;
                        parm[1].Value = caseCode;
                        if (multiFlag) parm[2].Value = recordDate.Value;
                        affectRows = svc.ExecSql(Sql, parm);

                        //更新病历提醒表actualdate_dat
                        Sql = "update emrRemind set actualdate = null where registerid = ? and casecode = ? and status = ?";
                        parm = svc.CreateParm(3);
                        parm[0].Value = regId;
                        parm[1].Value = caseCode;
                        parm[2].Value = 1;
                        affectRows = svc.ExecSql(Sql, parm);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
            return count;
        }
        #endregion

        #region 自定义列信息

        #region 获取
        /// <summary>
        /// GetCaseSelfDefineCol
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="caseCode"></param>
        /// <param name="pageNo"></param>
        /// <param name="lstTabPagePatInfo"></param>
        /// <returns></returns>
        public void GetCaseSelfDefineCol(string regId, string caseCode, int pageNo, ref List<EntityCasTablePagePatInfoCell> lstTabPagePatInfo)
        {
            try
            {
                string strSub = string.Empty;
                foreach (var item in lstTabPagePatInfo)
                {
                    strSub += "'" + item.strDBColCode + "',";
                }
                strSub = " and t.colcode in (" + strSub.Substring(0, strSub.Length - 1) + ") ";

                string SQL = @"select t.colcode, t.coldesc
                                    from emrSelfDefineCol t
                                   where t.registerid = ?
                                     and t.casecode = ?
                                     and t.pageno = ? " + strSub;
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                IDataParameter[] parm = svc.CreateParm(3);
                parm[0].Value = regId;
                parm[1].Value = caseCode;
                parm[2].Value = pageNo;
                DataTable dt = svc.GetDataTable(SQL, parm);
                if (dt != null && dt.Rows.Count <= 0)
                {
                    SQL = @"select t.colcode, t.coldesc, t.pageno 
                              from emrSelfDefineCol t
                             where t.registerid = ?
                               and t.casecode = ? " + strSub + " order by t.colcode, t.pageno";
                    parm = svc.CreateParm(2);
                    parm[0].Value = regId;
                    parm[1].Value = caseCode;
                    dt = svc.GetDataTable(SQL, parm);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        List<string> lstColCheck = new List<string>();
                        EntityCasTablePagePatInfoCell vo = null;
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (lstColCheck.IndexOf(dr["colcode"].ToString()) >= 0) continue;
                            vo = lstTabPagePatInfo.FirstOrDefault(t => t.strDBColCode == dr["colcode"].ToString());
                            if (vo != null)
                            {
                                vo.strDBColDesc = dr["coldesc"].ToString();
                                lstColCheck.Add(dr["colcode"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }
        /// <summary>
        /// GetCaseSelfDefineCol
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="dbTableName"></param>
        /// <param name="lstTabPagePatInfo"></param>
        /// <returns></returns>
        public void GetCaseSelfDefineCol(string regId, string dbTableName, ref List<EntityCasTablePagePatInfoCell> lstTabPagePatInfo)
        {
            try
            {
                string Sql = @"select t.xmlData from {0} t where t.registerId = ?";
                SqlHelper svc = new SqlHelper(EnumBiz.onlineDB);
                IDataParameter[] parm = svc.CreateParm(1);
                parm = svc.CreateParm(1);
                parm[0].Value = regId;
                Sql = string.Format(Sql, dbTableName);
                DataTable dt = svc.GetDataTable(Sql, parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    string xmlData = dt.Rows[0][0].ToString();
                    if (!string.IsNullOrEmpty(xmlData))
                    {
                        DataSet ds = Function.ReadXml(xmlData);
                        if (ds.Tables.Contains("Row"))
                        {
                            DataTable dtTable = ds.Tables["Row"];
                            EntityCasTablePagePatInfoCell vo = null;
                            foreach (DataRow dr in dtTable.Rows)
                            {
                                foreach (EntityCasTablePagePatInfoCell item in lstTabPagePatInfo)
                                {
                                    vo = lstTabPagePatInfo.FirstOrDefault(t => t.strDBColCode == item.strDBColCode);
                                    if (vo != null && dtTable.Columns.IndexOf(item.strDBColCode) >= 0)
                                    {
                                        vo.strDBColDesc = dr[item.strDBColCode].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.OutPutException(Function.GetExceptionCaption(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName, System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }
        #endregion

        #region GetCaseSelfDefineCol
        /// <summary>
        /// GetCaseSelfDefineCol
        /// </summary>
        /// <param name="regId"></param>
        /// <param name="caseCode"></param>
        /// <returns></returns>
        public List<EntityEmrSelfDefineCol> GetCaseSelfDefineCol(string regId, string caseCode)
        {
            SqlHelper svc = null;
            List<EntityEmrSelfDefineCol> data = new List<EntityEmrSelfDefineCol>();
            try
            {
                svc = new SqlHelper(EnumBiz.onlineDB);
                EntityEmrSelfDefineCol vo = new EntityEmrSelfDefineCol();
                vo.registerId = regId;
                vo.caseCode = caseCode;
                DataTable dt = svc.Select(vo, new List<string>() { EntityEmrSelfDefineCol.Columns.registerId, EntityEmrSelfDefineCol.Columns.caseCode });
                if (dt != null && dt.Rows.Count > 0)
                {
                    data = EntityTools.ConvertToEntityList<EntityEmrSelfDefineCol>(dt);
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

        #region 读取表格病历数据
        /// <summary>
        /// 读取表格病历数据
        /// </summary>
        /// <param name="caseVo"></param>
        public string GetTableCaseData(EntityEmrDataTable caseVo)
        {
            string xmlData = string.Empty;
            SqlHelper svc = null;
            try
            {
                string Sql = "select xmlData from {0} where registerId = ? and recordDate = ?";
                svc = new SqlHelper(EnumBiz.onlineDB);
                IDataParameter[] parm = svc.CreateParm(2);
                parm[0].Value = caseVo.registerId;
                parm[1].Value = caseVo.recordDate;
                DataTable dt = svc.GetDataTable(string.Format(Sql, caseVo.dbTableName), parm);
                if (dt != null && dt.Rows.Count > 0)
                {
                    xmlData = dt.Rows[0][0].ToString();
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
            return xmlData;
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
