using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using weCare.Core.Entity;
using weCare.Core.Itf;
using Oracle.DataAccess.Client;

namespace weCare.Core.Dac
{
    public class Oracle : IDataService
    {
        #region 获取绑定参数
        /// <summary>
        /// 获取绑定参数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private string GetParam(string sql)
        {
            int intPara = 1;

            for (int idx = sql.IndexOf("?"); idx > 0; idx = sql.IndexOf("?"))
            {
                sql = sql.Substring(0, idx) + ":" + (intPara++) + sql.Substring(idx + 1, sql.Length - idx - 1);
            }
            SqlLog.OutPutSql(sql);

            return sql;
        }

        /// <summary>
        /// 获取绑定参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="loop"></param>
        /// <returns></returns>
        private string GetParam(string sql, int loop)
        {
            int intPara = 1;

            for (int idx = sql.IndexOf("?"); idx > 0; idx = sql.IndexOf("?"))
            {
                sql = sql.Substring(0, idx) + ":" + loop.ToString() + (intPara++) + sql.Substring(idx + 1, sql.Length - idx - 1);
            }
            SqlLog.OutPutSql(sql);

            return sql;
        }
        #endregion

        #region SqlCommand
        /// <summary>
        /// SqlCommand
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        internal OracleCommand GetSqlCommand(string conn, CommandType type)
        {
            OracleConnection con = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                con = new OracleConnection(conn);
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = type;
                cmd.CommandTimeout = 3000;
            }
            catch (Exception ex)
            {
                weCare.Core.Utils.ExceptionLog.OutPutException(conn + "\r\n" + ex.Message);
            }
            return cmd;
        }

        /// <summary>
        /// GetSqlCommand
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="execType"></param>
        /// <returns></returns>
        internal OracleCommand GetSqlCommand(string conn, EnumExecType execType)
        {
            OracleConnection con = new OracleConnection(conn);
            OracleCommand cmd = new OracleCommand();

            con.Open();
            cmd.Connection = con;
            if (execType == EnumExecType.ExecSql || execType == EnumExecType.ExecSqlForBatch)
            {
                cmd.CommandType = CommandType.Text;
            }
            else if (execType == EnumExecType.ExecProc)
            {
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                return null;
            }
            cmd.CommandTimeout = 3000;

            return cmd;
        }
        #endregion

        #region 获取DataTable

        /// <summary>
        /// 获取DataTable
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string conn, string sql)
        {
            DataTable dtRecord = null;
            GetDataTable(conn, sql, ref dtRecord);
            return dtRecord;
        }

        /// <summary>
        /// 获取DataTable
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="dtRecord"></param>
        /// <returns></returns>
        public int GetDataTable(string conn, string sql, ref DataTable dtRecord)
        {
            OracleCommand cmd = GetSqlCommand(conn, CommandType.Text);
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(sql);
                OracleDataAdapter Adapter = new OracleDataAdapter();
                Adapter.SelectCommand = cmd;

                dtRecord = new DataTable();
                Adapter.Fill(dtRecord);
                if (dtRecord != null)
                {
                    for (int i = 0; i < dtRecord.Columns.Count; i++)
                    {
                        dtRecord.Columns[i].ColumnName = dtRecord.Columns[i].ColumnName.ToLower();
                    }
                }
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return intAffectedRows;
        }
        #endregion

        #region 获取DataTable带参数

        /// <summary>
        /// 获取DataTable带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string conn, string sql, params IDataParameter[] objParams)
        {
            DataTable dtRecord = null;
            GetDataTable(conn, sql, ref dtRecord, objParams);
            return dtRecord;
        }

        /// <summary>
        /// 获取DataTable带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="dtRecord"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public int GetDataTable(string conn, string sql, ref DataTable dtRecord, params IDataParameter[] objParams)
        {
            OracleCommand cmd = GetSqlCommand(conn, CommandType.Text);
            int intAffectedRows = 0;
            try
            {
                cmd.CommandText = GetParam(sql);
                if (objParams != null)
                {
                    for (int i = 0; i < objParams.Length; i++)
                    {
                        if (objParams[i].Value == null)
                        {
                            objParams[i].Value = System.DBNull.Value;
                        }
                        ((OracleParameter)objParams[i]).ParameterName = (i + 1).ToString();
                        cmd.Parameters.Add((OracleParameter)objParams[i]);
                    }
                }
                SqlLog.OutPutParmLog(objParams);

                OracleDataReader oraReader = cmd.ExecuteReader();
                dtRecord = new DataTable();
                dtRecord.Load(oraReader);
                oraReader.Close();

                //int fieldCount = oraReader.FieldCount;
                //for (int i = 0; i < fieldCount; i++)
                //{
                //    if (dtRecord.Columns.IndexOf(oraReader.GetName(i)) > 0)
                //        dtRecord.Columns.Add(oraReader.GetName(i) + i.ToString(), oraReader.GetFieldType(i));
                //    else
                //        dtRecord.Columns.Add(oraReader.GetName(i), oraReader.GetFieldType(i));
                //}
                //dtRecord.BeginLoadData();
                //object[] objValues = new object[fieldCount];
                //while (oraReader.Read())
                //{
                //    oraReader.GetValues(objValues);
                //    dtRecord.LoadDataRow(objValues, true);
                //}
                //oraReader.Close();
                //dtRecord.EndLoadData();

                //OracleDataAdapter Adapter = new OracleDataAdapter();
                //Adapter.SelectCommand = cmd;
                //dtRecord = new DataTable();
                //Adapter.Fill(dtRecord);
                for (int i = 0; i < dtRecord.Columns.Count; i++)
                {
                    dtRecord.Columns[i].ColumnName = dtRecord.Columns[i].ColumnName.ToLower();
                }
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                weCare.Core.Utils.ExceptionLog.OutPutException(objEx);
                throw objEx;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return intAffectedRows;
        }
        #endregion

        #region 执行SQL
        /// <summary>
        /// 执行SQL
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecSql(string conn, string sql)
        {
            OracleCommand cmd = GetSqlCommand(conn, CommandType.Text);
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(sql);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return intAffectedRows;
        }

        /// <summary>
        /// ExecSQL
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecSql(OracleCommand cmd, string sql)
        {
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(sql);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }

            return intAffectedRows;
        }
        #endregion

        #region 执行SQL带参数
        /// <summary>
        /// 执行SQL带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public int ExecSql(string conn, string sql, int step, params IDataParameter[] objParams)
        {
            OracleCommand cmd = GetSqlCommand(conn, CommandType.Text);
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(sql);
                if (objParams != null)
                {
                    for (int i = 0; i < objParams.Length; i++)
                    {
                        if (objParams[i].Value == null)
                        {
                            objParams[i].Value = System.DBNull.Value;
                        }
                        if (!string.IsNullOrEmpty(objParams[i].ParameterName) && objParams[i].ParameterName == "xmltype")
                        {
                            ((OracleParameter)objParams[i]).OracleDbType = OracleDbType.XmlType;
                        }
                        ((OracleParameter)objParams[i]).ParameterName = (i + 1 + step * 10).ToString();
                        cmd.Parameters.Add((OracleParameter)objParams[i]);
                    }
                }
                SqlLog.OutPutParmLog(objParams);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return intAffectedRows;
        }

        /// <summary>
        /// ExecSQL
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="sql"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public int ExecSql(OracleCommand cmd, string sql, int step, params IDataParameter[] objParams)
        {
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(sql);
                if (objParams != null)
                {
                    for (int i = 0; i < objParams.Length; i++)
                    {
                        if (objParams[i].Value == null)
                        {
                            objParams[i].Value = System.DBNull.Value;
                        }
                        ((OracleParameter)objParams[i]).ParameterName = (i + 1 + step * 10).ToString();
                        cmd.Parameters.Add((OracleParameter)objParams[i]);
                    }
                }
                SqlLog.OutPutParmLog(objParams);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }

            return intAffectedRows;
        }
        #endregion

        #region 存储过程

        #region 获取DataTable

        /// <summary>
        /// 获取DataTable
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <returns></returns>
        public DataTable GetDataTableFromProc(string conn, string procName)
        {
            DataTable dtRecord = null;
            GetDataTableFromProc(conn, procName, ref dtRecord);
            return dtRecord;
        }

        /// <summary>
        /// 获取DataTable
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <param name="dtRecord"></param>
        /// <returns></returns>
        public int GetDataTableFromProc(string conn, string procName, ref DataTable dtRecord)
        {
            OracleCommand cmd = GetSqlCommand(conn, CommandType.StoredProcedure);
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(procName);
                OracleDataAdapter Adapter = new OracleDataAdapter();
                Adapter.SelectCommand = cmd;

                dtRecord = new DataTable();
                Adapter.Fill(dtRecord);
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return intAffectedRows;
        }
        #endregion

        #region 获取DataTable带参数

        /// <summary>
        /// 获取DataTable带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public DataTable GetDataTableFromProc(string conn, string procName, params IDataParameter[] objParams)
        {
            DataTable dtRecord = null;
            GetDataTableFromProc(conn, procName, ref dtRecord, objParams);
            return dtRecord;
        }

        /// <summary>
        /// 获取DataTable带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <param name="dtRecord"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public int GetDataTableFromProc(string conn, string procName, ref DataTable dtRecord, params IDataParameter[] objParams)
        {
            OracleCommand cmd = GetSqlCommand(conn, CommandType.StoredProcedure);
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(procName);
                if (objParams != null)
                {
                    for (int i = 0; i < objParams.Length; i++)
                    {
                        if (objParams[i].Value == null)
                        {
                            objParams[i].Value = System.DBNull.Value;
                        }
                        else if (objParams[i].Direction == ParameterDirection.Output && objParams[i].DbType == DbType.String)
                        {
                            ((OracleParameter)objParams[i]).Size = 1000;
                        }
                        cmd.Parameters.Add((OracleParameter)objParams[i]);
                    }
                }
                SqlLog.OutPutParmLog(objParams);

                OracleDataAdapter Adapter = new OracleDataAdapter();
                Adapter.SelectCommand = cmd;

                dtRecord = new DataTable();
                Adapter.Fill(dtRecord);
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return intAffectedRows;
        }
        #endregion

        #region 执行存储过程
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <returns></returns>
        public int ExecProc(string conn, string procName)
        {
            OracleCommand cmd = GetSqlCommand(conn, CommandType.StoredProcedure);
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(procName);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return intAffectedRows;
        }

        /// <summary>
        /// ExecProc
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="procName"></param>
        /// <returns></returns>
        public int ExecProc(OracleCommand cmd, string procName)
        {
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(procName);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }

            return intAffectedRows;
        }
        #endregion

        #region 执行存储过程带参数
        /// <summary>
        /// 执行存储过程带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public int ExecProc(string conn, string procName, params IDataParameter[] objParams)
        {
            OracleCommand cmd = GetSqlCommand(conn, CommandType.StoredProcedure);
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(procName);
                if (objParams != null)
                {
                    for (int i = 0; i < objParams.Length; i++)
                    {
                        if (objParams[i].Value == null)
                        {
                            objParams[i].Value = System.DBNull.Value;
                        }
                        else if (objParams[i].Direction == ParameterDirection.Output && objParams[i].DbType == DbType.String)
                        {
                            ((OracleParameter)objParams[i]).Size = 1000;
                        }
                        cmd.Parameters.Add((OracleParameter)objParams[i]);
                    }
                }
                SqlLog.OutPutParmLog(objParams);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return intAffectedRows;
        }

        public int ExecProc(OracleCommand cmd, string procName, params IDataParameter[] objParams)
        {
            int intAffectedRows = 0;

            try
            {
                cmd.CommandText = GetParam(procName);
                if (objParams != null)
                {
                    for (int i = 0; i < objParams.Length; i++)
                    {
                        if (objParams[i].Value == null)
                        {
                            objParams[i].Value = System.DBNull.Value;
                        }
                        else if (objParams[i].Direction == ParameterDirection.Output && objParams[i].DbType == DbType.String)
                        {
                            ((OracleParameter)objParams[i]).Size = 1000;
                        }
                        cmd.Parameters.Add((OracleParameter)objParams[i]);
                    }
                }
                SqlLog.OutPutParmLog(objParams);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }

            return intAffectedRows;
        }
        #endregion

        #endregion

        #region 批量操作
        /// <summary>
        /// 批量操作
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <returns></returns>
        public int ExecSqlForBatchSimpleInsert(string conn, string sql, int step, object[][] objValuesArr, params DbType[] objDbTypes)
        {
            return ExecSqlForBatch(conn, EnumExecType.ExecSql, sql, ref step, objValuesArr, objDbTypes);
        }

        /// <summary>
        /// 批量操作
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="step"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <returns></returns>
        public int ExecSqlForBatch(string conn, string sql, ref int step, object[][] objValuesArr, params DbType[] objDbTypes)
        {
            return ExecSqlForBatch(conn, EnumExecType.ExecSql, sql, ref step, objValuesArr, objDbTypes);
        }

        /// <summary>
        /// 批量操作
        /// </summary>
        /// <param name="p_strConnstr"></param>
        /// <param name="p_strSQL"></param>
        /// <param name="p_objValuesArr"></param>
        /// <param name="p_lngAffectedRows"></param>
        /// <param name="p_objDbTypes"></param>
        /// <returns></returns>
        public int ExecSqlForBatch(string conn, EnumExecType execType, string sql, ref int step, object[][] objValuesArr, params DbType[] objDbTypes)
        {
            OracleCommand cmd = null;
            if (execType == EnumExecType.ExecSql || execType == EnumExecType.ExecSqlForBatch || execType == EnumExecType.ExecSqlForBatchSimpleInsert)
                cmd = GetSqlCommand(conn, CommandType.Text);
            else if (execType == EnumExecType.ExecProc)
                cmd = GetSqlCommand(conn, CommandType.StoredProcedure);
            else
                cmd = GetSqlCommand(conn, CommandType.Text);

            int intAffectedRows = 0;
            try
            {
                cmd.ArrayBindCount = objValuesArr[0].Length;
                cmd.CommandText = GetParam(sql);
                OracleDbType[] enmOracleDbType = ConvertDbTypeToOracleDbType(objDbTypes);
                OracleParameter param = null;
                for (int i = 0; i < enmOracleDbType.Length; i++)
                {
                    param = new OracleParameter(Convert.ToString(i + 1 + step * 10), enmOracleDbType[i]);
                    param.Direction = ParameterDirection.Input;
                    param.Value = objValuesArr[i];
                    cmd.Parameters.Add(param);
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < objValuesArr[0].Length; i++)
                {
                    sb.Append("---> " + Convert.ToString(i + 1) + Environment.NewLine);
                    for (int j = 0; j < objValuesArr.Length; j++)
                    {
                        if (objValuesArr[j][i] == null)
                            objValuesArr[j][i] = System.DBNull.Value;
                        sb.Append(Convert.ToString(j + 1) + ":= " + objValuesArr[j][i] + "; ");
                    }
                    sb.AppendLine();
                }
                SqlLog.OutPutSql("Values: " + sb.ToString());
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                    cmd.Dispose();
                }
            }
            return intAffectedRows;
        }

        /// <summary>
        /// ExecSQLForBatch
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="sql"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <returns></returns>
        public int ExecSqlForBatch(OracleCommand cmd, string sql, ref int step, object[][] objValuesArr, params DbType[] objDbTypes)
        {
            int intAffectedRows = 0;

            try
            {
                cmd.ArrayBindCount = objValuesArr[0].Length;
                cmd.CommandText = GetParam(sql);
                OracleDbType[] enmOracleDbType = ConvertDbTypeToOracleDbType(objDbTypes);
                OracleParameter param = null;
                for (int i = 0; i < enmOracleDbType.Length; i++)
                {
                    param = new OracleParameter(Convert.ToString(i + 1 * step * 10), enmOracleDbType[i]);
                    param.Direction = ParameterDirection.Input;
                    param.Value = objValuesArr[i];
                    cmd.Parameters.Add(param);
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < objValuesArr[0].Length; i++)
                {
                    sb.Append("---> " + Convert.ToString(i + 1) + Environment.NewLine);
                    for (int j = 0; j < objValuesArr.Length; j++)
                    {
                        if (objValuesArr[j][i] == null)
                            objValuesArr[j][i] = System.DBNull.Value;
                        sb.Append(Convert.ToString(j + 1) + ":= " + objValuesArr[j][i] + "; ");
                    }
                    sb.AppendLine();
                }
                SqlLog.OutPutSql("Values: " + sb.ToString());
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                intAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }

            return intAffectedRows;
        }

        /// <summary>
        /// OracleDbType
        /// </summary>
        /// <param name="enmDbType"></param>
        /// <returns></returns>
        private OracleDbType[] ConvertDbTypeToOracleDbType(DbType[] enmDbType)
        {
            OracleDbType[] enmOracleDbType = new OracleDbType[enmDbType.Length];
            for (int i = 0; i < enmDbType.Length; i++)
            {
                switch (enmDbType[i])
                {
                    case DbType.Date:
                        enmOracleDbType[i] = OracleDbType.Date;
                        break;
                    case DbType.DateTime:
                        enmOracleDbType[i] = OracleDbType.Date;
                        break;
                    case DbType.StringFixedLength:
                        enmOracleDbType[i] = OracleDbType.Char;
                        break;
                    case DbType.String:
                        enmOracleDbType[i] = OracleDbType.Varchar2;
                        break;
                    case DbType.AnsiString:
                        enmOracleDbType[i] = OracleDbType.Varchar2;
                        break;
                    case DbType.Byte:
                        enmOracleDbType[i] = OracleDbType.Blob;
                        break;
                    case DbType.Int32:
                        enmOracleDbType[i] = OracleDbType.Int32;
                        break;
                    case DbType.Int64:
                        enmOracleDbType[i] = OracleDbType.Int64;
                        break;
                    case DbType.Double:
                        enmOracleDbType[i] = OracleDbType.Double;
                        break;
                    case DbType.Binary:
                        enmOracleDbType[i] = OracleDbType.Blob;
                        break;
                    case DbType.Object:
                        enmOracleDbType[i] = OracleDbType.Blob;
                        break;
                    case DbType.Xml:
                        enmOracleDbType[i] = OracleDbType.XmlType;
                        break;
                    default:
                        enmOracleDbType[i] = OracleDbType.Varchar2;
                        break;
                }
            }
            return enmOracleDbType;
        }
        #endregion
    }
}
