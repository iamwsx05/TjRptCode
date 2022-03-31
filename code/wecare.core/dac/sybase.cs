//using Sybase.Data.AseClient;
//using System;
//using System.Data;
//using weCare.Core.Entity;
//using weCare.Core.Itf;

//namespace weCare.Core.Dac
//{
//    public class Sybase : IDataService
//    {
//        #region 获取绑定参数
//        /// <summary>
//        /// 获取绑定参数
//        /// </summary>
//        /// <param name="sql"></param>
//        /// <returns></returns>
//        private string GetParam(string sql)
//        {
//            return GetParam(sql, 0);
//        }

//        /// <summary>
//        /// 获取绑定参数
//        /// </summary>
//        /// <param name="sql"></param>
//        /// <returns></returns>
//        private string GetParam(string sql, int loop)
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

//        #region AseCommand
//        /// <summary>
//        /// AseCommand
//        /// </summary>
//        /// <param name="sql"></param>
//        /// <param name="objParams"></param>
//        /// <returns></returns>
//        AseCommand AseCommand(string sql, params IDataParameter[] objParams)
//        {
//            AseCommand cmd = new AseCommand();
//            bool isHavePara = false;
//            if (objParams != null && objParams.Length > 0)
//            {
//                cmd.CommandText = GetParam(sql);
//                isHavePara = true;
//            }
//            else
//            {
//                cmd.CommandText = sql;
//            }
//            cmd.CommandTimeout = 30000;
//            if (isHavePara)
//            {
//                for (int i = 0; i < objParams.Length; i++)
//                {
//                    if (objParams[i].Value == null)
//                    {
//                        objParams[i].Value = System.DBNull.Value;
//                    }
//                    ((AseParameter)objParams[i]).ParameterName = "@" + (i + 1).ToString();
//                    ((AseParameter)objParams[i]).AseDbType = ConvertDbTypeToAseDbType(objParams[i].DbType);
//                    ((AseParameter)objParams[i]).Direction = ParameterDirection.Input;
//                    cmd.Parameters.Add((AseParameter)objParams[i]);
//                }
//            }
//            return cmd;
//        }
//        #endregion

//        #region GetDataTable
//        /// <summary>
//        /// GetDataTable
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="sql"></param>
//        /// <param name="objParams"></param>
//        /// <returns></returns>
//        public DataTable GetDataTable(string conn, string sql, params IDataParameter[] objParams)
//        {
//            DataTable dtRecord = null;
//            using (AseConnection con = new AseConnection(conn))
//            {
//                AseCommand cmd = AseCommand(sql, objParams);
//                cmd.Connection = con;
//                con.Open();
//                AseDataAdapter Adapter = new AseDataAdapter();
//                Adapter.SelectCommand = cmd;
//                dtRecord = new DataTable();
//                Adapter.Fill(dtRecord);
//                con.Close();
//                SqlLog.OutPutSql(sql);
//            }
//            return dtRecord;
//        }

//        public DataTable GetDataTable(string conn, string sql)
//        {
//            return GetDataTable(conn, sql, null);
//        }

//        #endregion

//        #region ExecSql

//        public int ExecSql(string conn, string sql)
//        {
//            return ExecSql(conn, sql, null);
//        }

//        public int ExecSql(string conn, string sql, IDataParameter[] objParams)
//        {
//            return ExecSql(conn, sql, false, objParams);
//        }

//        public int ExecSql(string conn, string sql, int Step, IDataParameter[] objParams)
//        {
//            return ExecSql(conn, sql, false, objParams);
//        }

//        public int ExecSql(string conn, string sql, bool isDTC, IDataParameter[] objParams)
//        {
//            int affectRows = 0;
//            using (AseConnection con = new AseConnection(conn))
//            {
//                AseTransaction trans = null;
//                con.Open();
//                if (!isDTC) trans = con.BeginTransaction();
//                AseCommand cmd = AseCommand(sql, objParams);
//                cmd.Connection = con;
//                cmd.Transaction = trans;
//                SqlLog.OutPutSql(sql);
//                if (objParams != null && objParams.Length > 0)
//                    SqlLog.OutPutParmLog(objParams);
//                try
//                {
//                    affectRows = cmd.ExecuteNonQuery();
//                    if (!isDTC)
//                    {
//                        try
//                        {
//                            trans.Commit();
//                        }
//                        catch (Exception ex)
//                        {
//                            trans.Rollback();
//                            throw ex;
//                        }
//                    }
//                }
//                catch (Exception ex)
//                {
//                    throw ex;
//                }
//            }
//            return affectRows;
//        }
//        #endregion
        
//        #region 存储过程

//        #region 获取DataTable

//        /// <summary>
//        /// 获取DataTable
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="procName"></param>
//        /// <returns></returns>
//        public DataTable GetDataTableFromProc(string conn, string procName)
//        {
//            DataTable dtRecord = null;
//            GetDataTableFromProc(conn, procName, ref dtRecord);
//            return dtRecord;
//        }

//        /// <summary>
//        /// 获取DataTable
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="procName"></param>
//        /// <param name="dtRecord"></param>
//        /// <returns></returns>
//        public int GetDataTableFromProc(string conn, string procName, ref DataTable dtRecord)
//        {
//            return 0;
//        }
//        #endregion

//        #region 获取DataTable带参数

//        /// <summary>
//        /// 获取DataTable带参数
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="procName"></param>
//        /// <param name="objParams"></param>
//        /// <returns></returns>
//        public DataTable GetDataTableFromProc(string conn, string procName, params IDataParameter[] objParams)
//        {
//            return null;
//        }

//        /// <summary>
//        /// 获取DataTable带参数
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="procName"></param>
//        /// <param name="dtRecord"></param>
//        /// <param name="objParams"></param>
//        /// <returns></returns>
//        public int GetDataTableFromProc(string conn, string procName, ref DataTable dtRecord, params IDataParameter[] objParams)
//        {
//            return 0;
//        }
//        #endregion

//        #region 执行存储过程
//        /// <summary>
//        /// 执行存储过程
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="procName"></param>
//        /// <returns></returns>
//        public int ExecProc(string conn, string procName)
//        {
//            return 0;
//        }
//        #endregion

//        #region 执行存储过程带参数
//        /// <summary>
//        /// 执行存储过程带参数
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="procName"></param>
//        /// <param name="objParams"></param>
//        /// <returns></returns>
//        public int ExecProc(string conn, string procName, params IDataParameter[] objParams)
//        {
//            return 0;
//        }
//        #endregion

//        #endregion

//        #region 批量操作
//        /// <summary>
//        /// 批量操作
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="sql"></param>
//        /// <param name="objValuesArr"></param>
//        /// <param name="objDbTypes"></param>
//        /// <returns></returns>
//        public int ExecSqlForBatchSimpleInsert(string conn, string sql, int step, object[][] objValuesArr, params DbType[] objDbTypes)
//        {
//            return 0;
//        }

//        /// <summary>
//        /// 批量操作
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="sql"></param>
//        /// <param name="step"></param>
//        /// <param name="objValuesArr"></param>
//        /// <param name="objDbTypes"></param>
//        /// <returns></returns>
//        public int ExecSqlForBatch(string conn, string sql, ref int step, object[][] objValuesArr, params DbType[] objDbTypes)
//        {
//            return 0;
//        }

//        /// <summary>
//        /// 批量操作
//        /// </summary>
//        /// <param name="p_strConnstr"></param>
//        /// <param name="p_strSQL"></param>
//        /// <param name="p_objValuesArr"></param>
//        /// <param name="p_lngAffectedRows"></param>
//        /// <param name="p_objDbTypes"></param>
//        /// <returns></returns>
//        public int ExecSqlForBatch(string conn, EnumExecType execType, string sql, ref int step, object[][] objValuesArr, params DbType[] objDbTypes)
//        {
//            return 0;
//        }
//        #endregion

//        #region DbType
//        /// <summary>
//        /// DbType
//        /// </summary>
//        /// <param name="enmDbType"></param>
//        /// <returns></returns>
//        AseDbType ConvertDbTypeToAseDbType(DbType enmDbType)
//        {
//            switch (enmDbType)
//                {
//                    case DbType.Date:
//                        return AseDbType.Date;
//                    case DbType.DateTime:
//                        return AseDbType.DateTime;
//                    case DbType.StringFixedLength:
//                        return AseDbType.Char;
//                    case DbType.String:
//                        return AseDbType.VarChar;
//                    case DbType.AnsiString:
//                        return AseDbType.VarChar;
//                    case DbType.Byte:
//                        return AseDbType.Binary;
//                    case DbType.Int32:
//                        return AseDbType.Integer;
//                    case DbType.Int64:
//                        return AseDbType.Integer;
//                    case DbType.Double:
//                        return AseDbType.Double;
//                    case DbType.Decimal:
//                        return AseDbType.Decimal;
//                    case DbType.Binary:
//                        return AseDbType.Binary;
//                    case DbType.Object:
//                        return AseDbType.Image;
//                    default:
//                        return AseDbType.VarChar;
//                }
//        }
//        #endregion
//    }
//}
