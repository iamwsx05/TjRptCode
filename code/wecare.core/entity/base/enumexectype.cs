using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weCare.Core.Entity
{
    /// <summary>
    /// 执行类型
    /// </summary>
    public enum EnumExecType
    {
        /// <summary>
        /// 执行SQL
        /// </summary>
        ExecSql = 1,
        /// <summary>
        /// 批量执行SQL
        /// </summary>
        ExecSqlForBatch = 2,
        /// <summary>
        /// 批量执行SQL.只插入
        /// </summary>
        ExecSqlForBatchSimpleInsert = 3,
        /// <summary>
        /// 执行存储过程
        /// </summary>
        ExecProc = 4
    }


}
