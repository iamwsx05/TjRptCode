using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using weCare.Core.Entity;
using weCare.Core.Itf;

namespace weCare.Core.Dac
{
    public class SqlServer : IDataService
    {
        #region 获取绑定参数
        /// <summary>
        /// 获取绑定参数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private string GetParm(string sql)
        {
            return GetParm(sql, 0);
        }
        /// <summary>
        /// 获取绑定参数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private string GetParm(string sql, int loop)
        {
            return GetParm(sql, loop, true);
        }
        /// <summary>
        /// 获取绑定参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="loop"></param>
        /// <param name="isLog"></param>
        /// <returns></returns>
        private string GetParm(string sql, int loop, bool isLog)
        {
            int intPara = 1;
            int i = -1;

            for (int idx = sql.IndexOf("?"); idx > 0; idx = sql.IndexOf("?"))
            {
                if (loop == 0)
                    sql = sql.Substring(0, idx) + "@" + (intPara++) + sql.Substring(idx + 1, sql.Length - idx - 1);
                else
                    sql = sql.Substring(0, idx) + "@" + ((++i) + 1 + loop * 10).ToString() + sql.Substring(idx + 1, sql.Length - idx - 1);
            }
            if (isLog)
            {
                SqlLog.OutPutSql(sql);
            }
            return sql;
        }
        #endregion

        #region SqlCommand
        /// <summary>
        /// commod.List
        /// </summary>
        Dictionary<string, SqlCommand> SqlCommands = null;

        /// <summary>
        /// SqlCommand
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="execType"></param>
        /// <returns></returns>
        internal SqlCommand GetSqlCommand(string conn, EnumExecType execType)
        {
            if (SqlCommands == null)
            {
                SqlCommands = new Dictionary<string, SqlCommand>();
            }
            else
            {
                if (SqlCommands.ContainsKey(conn + "|" + execType.ToString()))
                {
                    return SqlCommands[conn + "|" + execType.ToString()];
                }
            }
            SqlConnection con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
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
                cmd.CommandType = CommandType.Text;
            }
            cmd.CommandTimeout = 3000;
            SqlCommands.Add(conn + "|" + execType.ToString(), cmd);
            return cmd;
        }
        #endregion

        #region 获取DataTable

        /// <summary>
        /// 获取DataTable带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string conn, string sql)
        {
            return GetDataTable(conn, sql, null);
        }

        /// <summary>
        /// 获取DataTable带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="dtRecord"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string conn, string sql, params IDataParameter[] objParm)
        {
            DataTable dtRecord = null;
            SqlCommand cmd = GetSqlCommand(conn, EnumExecType.ExecSql);
            try
            {
                //cmd.CommandText = "set transaction isolation level read uncommitted";
                //cmd.ExecuteNonQuery();
                cmd.CommandText = GetParm(sql);
                if (objParm != null && objParm.Length > 0)
                {
                    for (int i = 0; i < objParm.Length; i++)
                    {
                        if (objParm[i].Value == null)
                        {
                            objParm[i].Value = System.DBNull.Value;
                        }
                        ((SqlParameter)objParm[i]).ParameterName = (i + 1).ToString();
                        cmd.Parameters.Add((SqlParameter)objParm[i]);
                    }
                    SqlLog.OutPutParmLog(objParm);
                }

                SqlDataReader sqlReader = cmd.ExecuteReader();
                dtRecord = new DataTable();
                dtRecord.Load(sqlReader);
                sqlReader.Close();

                //int fieldCount = sqlReader.FieldCount;
                //for (int i = 0; i < fieldCount; i++)
                //{
                //    if (dtRecord.Columns.IndexOf(sqlReader.GetName(i)) > 0)
                //        dtRecord.Columns.Add(sqlReader.GetName(i) + i.ToString(), sqlReader.GetFieldType(i));
                //    else
                //        dtRecord.Columns.Add(sqlReader.GetName(i), sqlReader.GetFieldType(i));
                //}
                //dtRecord.BeginLoadData();
                //object[] objValues = new object[fieldCount];
                //while (sqlReader.Read())
                //{
                //    sqlReader.GetValues(objValues);
                //    dtRecord.LoadDataRow(objValues, true);
                //}
                //sqlReader.Close();
                //dtRecord.EndLoadData();

                //SqlDataAdapter Adapter = new SqlDataAdapter();
                //Adapter.SelectCommand = cmd;
                //dtRecord = new DataTable();
                //Adapter.Fill(dtRecord);
            }
            catch (System.Exception objEx)
            {
                dtRecord = null;
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
            return dtRecord;
        }
        #endregion

        #region 执行Sql

        #region 执行SQL

        /// <summary>
        /// 执行SQL
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecSql(string conn, string sql)
        {
            return ExecSql(conn, sql, 0, null);
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
        public int ExecSql(string conn, string sql, int step, params IDataParameter[] objParm)
        {
            SqlCommand cmd = GetSqlCommand(conn, EnumExecType.ExecSql);
            int affectedRows = 0;

            try
            {
                cmd.CommandText = GetParm(sql, step);
                if (objParm != null && objParm.Length > 0)
                {
                    for (int i = 0; i < objParm.Length; i++)
                    {
                        if (objParm[i].Value == null)
                        {
                            objParm[i].Value = System.DBNull.Value;
                        }
                        ((SqlParameter)objParm[i]).ParameterName = (i + 1 + step * 10).ToString();
                        cmd.Parameters.Add((SqlParameter)objParm[i]);
                    }
                    SqlLog.OutPutParmLog(objParm);
                }
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (System.Exception objEx)
            {
                affectedRows = -1;
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
            return affectedRows;
        }
        #endregion

        #endregion

        #region 存储过程

        #region 获取DataTable

        /// <summary>
        /// 获取DataTable带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public DataTable GetDataTableFromProc(string conn, string procName)
        {
            return GetDataTableFromProc(conn, procName, null);
        }

        /// <summary>
        /// /// 获取DataTable带参数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <param name="objParm"></param>
        /// <returns></returns>
        public DataTable GetDataTableFromProc(string conn, string procName, params IDataParameter[] objParm)
        {
            DataTable dtRecord = null;
            SqlCommand cmd = GetSqlCommand(conn, EnumExecType.ExecProc);
            try
            {
                cmd.CommandText = GetParm(procName);
                if (objParm != null && objParm.Length > 0)
                {
                    for (int i = 0; i < objParm.Length; i++)
                    {
                        if (objParm[i].Value == null)
                        {
                            objParm[i].Value = System.DBNull.Value;
                        }
                        else if (objParm[i].Direction == ParameterDirection.Output && objParm[i].DbType == DbType.String)
                        {
                            ((SqlParameter)objParm[i]).Size = 1000;
                        }
                        cmd.Parameters.Add((SqlParameter)objParm[i]);
                    }
                    SqlLog.OutPutParmLog(objParm);
                }
                SqlDataAdapter Adapter = new SqlDataAdapter();
                Adapter.SelectCommand = cmd;
                dtRecord = new DataTable();
                Adapter.Fill(dtRecord);
            }
            catch (System.Exception objEx)
            {
                dtRecord = null;
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
            return dtRecord;
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
            return ExecProc(conn, procName, null);
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
        public int ExecProc(string conn, string procName, params IDataParameter[] objParm)
        {
            SqlCommand cmd = GetSqlCommand(conn, EnumExecType.ExecProc);
            int intAffectedRows = 0;
            try
            {
                cmd.CommandText = GetParm(procName);
                if (objParm != null && objParm.Length > 0)
                {
                    for (int i = 0; i < objParm.Length; i++)
                    {
                        if (objParm[i].Value == null)
                        {
                            objParm[i].Value = System.DBNull.Value;
                        }
                        else if (objParm[i].Direction == ParameterDirection.Output && objParm[i].DbType == DbType.String)
                        {
                            ((SqlParameter)objParm[i]).Size = 1000;
                        }
                        cmd.Parameters.Add((SqlParameter)objParm[i]);
                    }
                    SqlLog.OutPutParmLog(objParm);
                }
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
        #endregion

        #endregion

        #region 批量操作
        /// <summary>
        /// 获取Schema表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <returns></returns>
        private DataTable GetTableSchema(string sql, object[][] objValuesArr, params DbType[] objDbTypes)
        {
            sql = sql.ToLower();
            DataTable dtSchema = new DataTable();
            System.Type[] enmType = ConvertDbTypeToSysType(objDbTypes);

            int pos1 = sql.IndexOf("(");
            int pos2 = sql.IndexOf(")");
            string strTableName = sql.Substring(0, pos1).Replace("insert into", "").Trim();
            dtSchema.TableName = strTableName;
            string strCol = sql.Substring(pos1 + 1, pos2 - pos1 - 1);
            string[] strCols = strCol.Split(',');
            for (int i = 0; i < strCols.Length; i++)
            {
                dtSchema.Columns.Add(strCols[i], enmType[i]);
            }

            dtSchema.BeginLoadData();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < objValuesArr[0].Length; i++)
            {
                object[] objCol = new object[objValuesArr.Length];
                sb.Append("---> " + Convert.ToString(i + 1) + Environment.NewLine);
                for (int j = 0; j < objValuesArr.Length; j++)
                {
                    if (objValuesArr[j][i] == null)
                        objValuesArr[j][i] = System.DBNull.Value;
                    sb.Append(Convert.ToString(j + 1) + ":= " + objValuesArr[j][i] + "; ");
                    objCol[j] = objValuesArr[j][i];
                }
                dtSchema.LoadDataRow(objCol, true);
                sb.AppendLine();
            }
            dtSchema.EndLoadData();

            GetParm(sql, 0, true);
            SqlLog.OutPutSql("values: " + sb.ToString());

            return dtSchema;
        }
        /// <summary>
        /// 批量操作-简单插入(单表)
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <returns></returns>
        public int ExecSqlForBatchSimpleInsert(string conn, string sql, int step, object[][] objValuesArr, params DbType[] objDbTypes)
        {
            SqlConnection con = new SqlConnection(conn);
            SqlBulkCopy bulk = new SqlBulkCopy(con);

            int intAffectedRows = 0;
            DataTable dt = GetTableSchema(sql, objValuesArr, objDbTypes);
            bulk.DestinationTableName = dt.TableName;
            bulk.BatchSize = dt.Rows.Count;
            try
            {
                con.Open();
                if (dt != null && dt.Rows.Count > 0)
                {
                    bulk.WriteToServer(dt);
                    intAffectedRows = dt.Rows.Count;
                }
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    if (bulk != null)
                    {
                        bulk.Close();
                    }
                    con.Dispose();
                }
            }
            return intAffectedRows;
        }

        /// <summary>
        /// 批量操作
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <returns></returns>
        public int ExecSqlForBatch(string conn, string sql, ref int step, object[][] objValuesArr, params DbType[] objDbTypes)
        {
            SqlCommand cmd = GetSqlCommand(conn, EnumExecType.ExecSql);
            int intAffectedRows = 0;
            int num = 0;

            try
            {
                SqlDbType[] enmSqlDbType = ConvertDbTypeToSqlDbType(objDbTypes);
                SqlParameter param = null;
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

                for (int i = 0; i < objValuesArr[0].Length; i++)
                {
                    for (int j = 0; j < enmSqlDbType.Length; j++)
                    {
                        param = new SqlParameter(Convert.ToString((i + step) * 10) + Convert.ToString(j + 1), enmSqlDbType[j]);
                        param.Direction = ParameterDirection.Input;
                        param.Value = objValuesArr[j][i];
                        cmd.Parameters.Add(param);
                    }
                    cmd.CommandText = GetParm(sql, (i + step) * 10, (i == 0));
                    if (i == 0) SqlLog.OutPutSql("values: " + sb.ToString());
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    intAffectedRows += cmd.ExecuteNonQuery();
                    num = i + step;
                }
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                step = num + 1;
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
        public int ExecSqlForBatch(string conn, EnumExecType execType, string sql, ref int step, object[][] objValuesArr, params DbType[] objDbTypes)
        {
            //EnumExecType execType = EnumExecType.ExecSql;
            //if (typeStr == "1")
            //    execType = EnumExecType.ExecSql;
            //else if (typeStr == "2")
            //    execType = EnumExecType.ExecSqlForBatch;
            //else if (typeStr == "3")
            //    execType = EnumExecType.ExecSqlForBatchSimpleInsert;
            //else if (typeStr == "4")
            //    execType = EnumExecType.ExecProc;

            // 2100参数限制
            int divNum = 2100;
            SqlCommand[] sqlCommandArr = null;
            if (objValuesArr[0].Length * objDbTypes.Length > 2100)
            {
                sqlCommandArr = new SqlCommand[((objValuesArr[0].Length * objDbTypes.Length) / 2100) + 1];
                for (int m = 0; m < sqlCommandArr.Length; m++)
                {
                    sqlCommandArr[m] = GetSqlCommand(conn, execType);
                }
            }
            else
            {
                sqlCommandArr = new SqlCommand[1];
                sqlCommandArr[0] = GetSqlCommand(conn, execType);
            }

            int intAffectedRows = 0;
            int num = 0;
            try
            {
                SqlDbType[] enmSqlDbType = ConvertDbTypeToSqlDbType(objDbTypes);
                SqlParameter param = null;
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

                int div = 0;
                for (int i = 0; i < objValuesArr[0].Length; i++)
                {
                    for (int j = 0; j < enmSqlDbType.Length; j++)
                    {
                        div = ((i + 1) * enmSqlDbType.Length) / divNum;
                        if (j + 1 < 10)
                            param = new SqlParameter(Convert.ToString((i + step) * 10) + Convert.ToString(j + 1), enmSqlDbType[j]);
                        else
                            param = new SqlParameter(Convert.ToString(i + step) + Convert.ToString(j + 1), enmSqlDbType[j]);
                        //param = new SqlParameter(Convert.ToString((i + step) * 10) + Convert.ToString(j + 1), enmSqlDbType[j]);
                        param.Direction = ParameterDirection.Input;
                        param.Value = objValuesArr[j][i];
                        sqlCommandArr[div].Parameters.Add(param);
                    }
                    sqlCommandArr[div].CommandText = GetParm(sql, (i + step) * 10, (i == 0));

                    if (i == 0) SqlLog.OutPutSql("values: " + sb.ToString());
                    if (sqlCommandArr[div].Connection.State == ConnectionState.Closed)
                    {
                        sqlCommandArr[div].Connection.Open();
                    }
                    intAffectedRows += sqlCommandArr[div].ExecuteNonQuery();
                    num = i + step;
                }
            }
            catch (System.Exception objEx)
            {
                intAffectedRows = -1;
                throw objEx;
            }
            finally
            {
                step = num + 1;
            }
            return intAffectedRows;
        }

        /// <summary>
        /// SqlDbType
        /// </summary>
        /// <param name="enmDbType"></param>
        /// <returns></returns>
        private SqlDbType[] ConvertDbTypeToSqlDbType(DbType[] enmDbType)
        {
            SqlDbType[] enmSqlDbType = new SqlDbType[enmDbType.Length];
            for (int i = 0; i < enmDbType.Length; i++)
            {
                switch (enmDbType[i])
                {
                    case DbType.Date:
                        enmSqlDbType[i] = SqlDbType.DateTime;
                        break;
                    case DbType.DateTime:
                        enmSqlDbType[i] = SqlDbType.DateTime;
                        break;
                    case DbType.StringFixedLength:
                        enmSqlDbType[i] = SqlDbType.Char;
                        break;
                    case DbType.String:
                        enmSqlDbType[i] = SqlDbType.VarChar;
                        break;
                    case DbType.AnsiString:
                        enmSqlDbType[i] = SqlDbType.VarChar;
                        break;
                    case DbType.Byte:
                        enmSqlDbType[i] = SqlDbType.Image;
                        break;
                    case DbType.Int32:
                        enmSqlDbType[i] = SqlDbType.Int;
                        break;
                    case DbType.Int64:
                        enmSqlDbType[i] = SqlDbType.BigInt;
                        break;
                    case DbType.Double:
                        enmSqlDbType[i] = SqlDbType.Decimal;
                        break;
                    case DbType.Binary:
                        enmSqlDbType[i] = SqlDbType.Binary;
                        break;
                    case DbType.Object:
                        enmSqlDbType[i] = SqlDbType.Image;
                        break;
                    case DbType.Xml:
                        enmSqlDbType[i] = SqlDbType.Xml;
                        break;
                    default:
                        enmSqlDbType[i] = SqlDbType.VarChar;
                        break;
                }
            }
            return enmSqlDbType;
        }
        /// <summary>
        /// SysType
        /// </summary>
        /// <param name="enmDbType"></param>
        /// <returns></returns>
        private System.Type[] ConvertDbTypeToSysType(DbType[] enmDbType)
        {
            System.Type[] enmType = new Type[enmDbType.Length];
            for (int i = 0; i < enmDbType.Length; i++)
            {
                switch (enmDbType[i])
                {
                    case DbType.Date:
                        enmType[i] = typeof(DateTime);
                        break;
                    case DbType.DateTime:
                        enmType[i] = typeof(DateTime);
                        break;
                    case DbType.StringFixedLength:
                        enmType[i] = typeof(String);
                        break;
                    case DbType.String:
                        enmType[i] = typeof(String);
                        break;
                    case DbType.Byte:
                        enmType[i] = typeof(Byte);
                        break;
                    case DbType.Int32:
                        enmType[i] = typeof(Int32);
                        break;
                    case DbType.Int64:
                        enmType[i] = typeof(Int32);
                        break;
                    case DbType.Double:
                        enmType[i] = typeof(Decimal);
                        break;
                    case DbType.Decimal:
                        enmType[i] = typeof(Decimal);
                        break;
                    case DbType.Binary:
                        enmType[i] = typeof(Byte[]);
                        break;
                    case DbType.Object:
                        enmType[i] = typeof(Byte[]);
                        break;
                    default:
                        enmType[i] = typeof(String);
                        break;
                }
            }
            return enmType;
        }
        #endregion
    }
}
