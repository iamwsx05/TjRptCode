//using Sybase.Data.AseClient;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Odbc;
//using System.Data.SqlClient;
//using System.IO;
//using System.Reflection;
//using System.Transactions;
//using weCare.Core.Dac;

//namespace weCare.Core.Ase
//{
//    #region DBMS
//    /// <summary>
//    /// DBMS
//    /// </summary>
//    public class DBMS
//    {
//        #region 构造

//        SqlHelper sqlHelper { get; set; }

//        public DBMS(SqlHelper _sqlHelper)
//        {
//            this.sqlHelper = _sqlHelper;
//        }
//        #endregion

//        #region 事务类型
//        /// <summary>
//        /// 事务类型
//        /// </summary>
//        public TransactionScope TransactionScope
//        {
//            get
//            {
//                TransactionOptions transOption = new TransactionOptions();
//                // 隔离级别-事务期间不允许脏读
//                transOption.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
//                // Timeout-10分钟
//                transOption.Timeout = new TimeSpan(0, 10, 0);
//                return new TransactionScope(TransactionScopeOption.Required, transOption);
//            }
//        }
//        #endregion

//        #region Ase

//        #region 获取绑定参数
//        /// <summary>
//        /// 获取绑定参数
//        /// </summary>
//        /// <param name="sql"></param>
//        /// <returns></returns>
//        string GetParam(string sql)
//        {
//            return GetParam(sql, 0);
//        }

//        /// <summary>
//        /// 获取绑定参数
//        /// </summary>
//        /// <param name="sql"></param>
//        /// <returns></returns>
//        string GetParam(string sql, int loop)
//        {
//            int intPara = 1;
//            int i = -1;

//            for (int idx = sql.IndexOf("?"); idx > 0; idx = sql.IndexOf("?"))
//            {
//                if (loop == 0)
//                    sql = sql.Substring(0, idx) + "@" + (intPara++) + sql.Substring(idx + 1, sql.Length - idx - 1);
//                else
//                    sql = sql.Substring(0, idx) + "@" + ((++i) + 1 + loop * 100).ToString() + sql.Substring(idx + 1, sql.Length - idx - 1);
//            }
//            return sql;
//        }
//        #endregion

//        #endregion

//        #region Commit
//        /// <summary>
//        /// Commit
//        /// </summary>
//        /// <param name="lstSvcParam"></param>
//        /// <returns></returns>
//        public int Commit(List<DacParm> lstParm)
//        {
//            return Commit(lstParm, true);
//        }
//        /// <summary>
//        /// Commit
//        /// </summary>
//        /// <param name="lstParm"></param>
//        /// <param name="isDTC"></param>
//        /// <returns></returns>
//        public int Commit(List<DacParm> lstParm, bool isDTC)
//        {
//            int affectedRows = 0;
//            if (isDTC)
//            {
//                using (AseConnection con = new AseConnection(sqlHelper.connStr))
//                {
//                    AseTransaction trans = null;
//                    con.Open();
//                    trans = con.BeginTransaction();

//                    bool isHavePara = false;
//                    foreach (DacParm parm in lstParm)
//                    {
//                        AseCommand cmd = new AseCommand();
//                        cmd.Connection = con;
//                        cmd.Transaction = trans;
//                        cmd.CommandTimeout = 30;

//                        isHavePara = false;
//                        if (parm.objParams != null && parm.objParams.Length > 0)
//                        {
//                            cmd.CommandText = GetParam(parm.sqlName);
//                            isHavePara = true;
//                        }
//                        else
//                        {
//                            cmd.CommandText = parm.sqlName;
//                        }
//                        SqlLog.OutPutSql(parm.sqlName);
//                        if (parm.objParams != null && parm.objParams.Length > 0)
//                            SqlLog.OutPutParmLog(parm.objParams);

//                        if (isHavePara)
//                        {
//                            for (int i = 0; i < parm.objParams.Length; i++)
//                            {
//                                if (parm.objParams[i].Value == null)
//                                {
//                                    parm.objParams[i].Value = System.DBNull.Value;
//                                }
//                                ((AseParameter)parm.objParams[i]).ParameterName = "@" + (i + 1).ToString();
//                                ((AseParameter)parm.objParams[i]).Direction = ParameterDirection.Input;
//                                cmd.Parameters.Add((AseParameter)parm.objParams[i]);
//                            }
//                        }
//                        try
//                        {
//                            affectedRows += cmd.ExecuteNonQuery();
//                        }
//                        catch (Exception ex)
//                        {
//                            trans.Rollback();
//                            weCare.Core.Utils.ExceptionLog.OutPutException(ex);
//                            throw ex;
//                        }
//                    }
//                    if (affectedRows > 0)
//                    {
//                        trans.Commit();
//                    }
//                }
//                return affectedRows;
//            }
//            return affectedRows;
//        }
//        #endregion
//    }
//    #endregion
//}
