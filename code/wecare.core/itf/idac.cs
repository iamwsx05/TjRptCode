using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace weCare.Core.Itf
{
    public interface IDataService
    {
        /// <summary>
        /// 获取DATATABLE.无参
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        DataTable GetDataTable(string conn, string sql);        

        /// <summary>
        /// 获取DATATABLE.有参
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        DataTable GetDataTable(string conn, string sql, params IDataParameter[] objParms);
        
        /// <summary>
        /// 获取DATATABLE.通过存储过程.无参
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <returns></returns>
        DataTable GetDataTableFromProc(string conn, string procName);
        
        /// <summary>
        /// 获取DATATABLE.通过存储过程.有参
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        DataTable GetDataTableFromProc(string conn, string procName, params IDataParameter[] objParms);
              
        /// <summary>
        /// 执行SQL
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        int ExecSql(string conn, string sql);

        /// <summary>
        /// 执行SQL.有参
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        int ExecSql(string conn, string sql, int step, params IDataParameter[] objParms);

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <returns></returns>
        int ExecProc(string conn, string procName);

        /// <summary>
        /// 执行存储过程.有参
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="procName"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        int ExecProc(string conn, string procName, params IDataParameter[] objParms);

        /// <summary>
        /// 执行SQL.批量.有参
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <returns></returns>
        int ExecSqlForBatch(string conn, string sql, ref int step, object[][] objValuesArr, params DbType[] objDbTypes);

        /// <summary>
        /// 执行SQL.批量.有参
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="execType"></param>
        /// <param name="sql"></param>
        /// <param name="step"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <returns></returns>
        int ExecSqlForBatch(string conn, weCare.Core.Entity.EnumExecType execType, string sql, ref int step, object[][] objValuesArr, params DbType[] objDbTypes);

        /// <summary>
        /// 执行SQL.批量.有参.单表操作
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <returns></returns>
        int ExecSqlForBatchSimpleInsert(string conn, string sql, int step, object[][] objValuesArr, params DbType[] objDbTypes);
    
    }
}
