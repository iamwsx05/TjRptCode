using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Data.Odbc;
using weCare.Core.Entity;
using weCare.Core.Itf;
using weCare.Core.Utils;
using Oracle.DataAccess.Client;
//using Sybase.Data.AseClient;

namespace weCare.Core.Dac
{
    #region EnumDBMS
    /// <summary>
    /// EnumDBMS
    /// </summary>
    public enum EnumDBMS
    {
        Oracle,
        SqlServer,
        Sybase,
        Odbc
    }
    #endregion

    #region EnumBiz
    /// <summary>
    /// EnumBiz
    /// </summary>
    public enum EnumBiz
    {
        onlineDB,
        offlineDB,
        interfaceDB,
        ipDB,
        baDB,
        emrDB,
        lisDB,
        pacsDB,
        lcDB,
        peDB,
        othDB,
        nullDB
    }
    #endregion

    #region 提交参数
    /// <summary>
    /// 提交参数
    /// </summary>
    public class DacParm
    {
        /// <summary>
        /// 数据库类型 1 SQL SERVER; 2 ORACLE; 3 Sybase; 4 ODBC
        /// </summary>
        internal EnumDBMS enumDBMS { get; set; }

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string connStr { get; set; }

        /// <summary>
        /// 数据服务
        /// </summary>
        public IDataService dataService { get; set; }

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumExecType execType { get; set; }

        /// <summary>
        /// sql语句或存储过程名称
        /// </summary>
        public string sqlName { get; set; }

        /// <summary>
        /// 参数列表
        /// </summary>
        public IDataParameter[] objParams { get; set; }

        /// <summary>
        /// 批量执行数值
        /// </summary>
        public object[][] objValuesArr { get; set; }

        /// <summary>
        /// 批量执行数据类型
        /// </summary>
        public DbType[] objDbTypes { get; set; }

        /// <summary>
        /// 是否仅一行
        /// </summary>
        public bool isOnlyRow { get; set; }

        /// <summary>
        /// 是否必须更新
        /// </summary>
        public bool isMustUpdate { get; set; }

        /// <summary>
        /// 是否同步到同结构的数据库
        /// </summary>
        public bool isSync { get; set; }

        /// <summary>
        /// 同步数据库列表
        /// </summary>
        public List<EnumBiz> lstBiz { get; set; }
    }
    #endregion

    #region SqlHelper
    /// <summary>
    /// SqlHelper
    /// </summary>
    public class SqlHelper
    {
        #region 变量.属性
        /// <summary>
        /// enumDBMS
        /// </summary>
        public EnumDBMS enumDBMS = EnumDBMS.SqlServer;
        /// <summary>
        /// enumBiz
        /// </summary>
        EnumBiz enumBiz = EnumBiz.onlineDB;
        /// <summary>
        /// 连接串
        /// </summary>
        public string connStr { get; set; }
        /// <summary>
        /// 运行模式： 2 CS; 3 CSS。
        /// </summary>
        public static int RunningMode { get; set; }

        #endregion

        #region 构造
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="_EnumDBMS"></param>
        public SqlHelper(EnumBiz _EnumBiz)
        {
            // 授权验证

            enumBiz = _EnumBiz;
            connStr = ConnStr(enumBiz.ToString());
        }
        #endregion

        #region ConnStr
        /// <summary>
        /// ConnStr
        /// </summary>
        /// <returns></returns>
        string ConnStr(string dbKey)
        {
            string strConn = null;
            string strFile = Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName + @"\database.xml";
            if (!System.IO.File.Exists(strFile))
            {
                try
                {
                    strFile = System.AppDomain.CurrentDomain.BaseDirectory + @"\database.xml";
                    if (!System.IO.File.Exists(strFile))
                    {
                        strFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\database.xml";
                    }
                }
                catch
                {
                    strFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\database.xml";
                }
            }
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(strFile);

            System.Xml.XmlElement element = doc["configuration"]["DBMS"][dbKey];
            if (element == null)
            {
                element = doc["configuration"]["DBMS"][EnumBiz.onlineDB.ToString()];
            }
            // 是否加密
            bool isEnc = false;
            string strDBMS = element.Attributes["dbms"].Value.Trim();
            if (strDBMS.Length == 2)
            {
                if (strDBMS.Substring(1, 1) == "+") isEnc = true;
                strDBMS = strDBMS.Substring(0, 1);
            }
            if (strDBMS == "1")
                enumDBMS = EnumDBMS.SqlServer;
            else if (strDBMS == "2")
                enumDBMS = EnumDBMS.Oracle;
            else if (strDBMS == "3")
                enumDBMS = EnumDBMS.Sybase;
            else if (strDBMS == "4")
                enumDBMS = EnumDBMS.Odbc;
            strConn = element.Attributes["connStr"].Value.Trim();
            // 加密->解密
            if (isEnc)
            {
                List<string> lstParm = strConn.Split(';').ToList();
                for (int i = 0; i < lstParm.Count; i++)
                {
                    if (lstParm[i].StartsWith("Password="))
                    {
                        string KEY = "daXPc0JKOKOElQOBJRBV9Y81qE8qB3ceXNeynhFOc3c=";
                        clsSymmetricAlgorithm.enmSymmetricAlgorithmType EnumSym = clsSymmetricAlgorithm.enmSymmetricAlgorithmType.RIJNDAEL;
                        clsSymmetricAlgorithm csa = new clsSymmetricAlgorithm();
                        csa.Key = KEY;

                        string pwd = lstParm[i].Substring(9);
                        pwd = csa.Decrypt(pwd, EnumSym);
                        lstParm[i] = "Password=" + pwd;
                        break;
                    }
                }
                strConn = string.Empty;
                foreach (string str in lstParm)
                {
                    strConn += str + ";";
                }
                strConn = strConn.TrimEnd(';');
            }
            element = null;
            doc = null;
            return strConn;
        }
        #endregion

        #region CreateParm

        /// <summary>
        /// 创建SQL参数
        /// </summary>
        /// <returns></returns>
        public IDataParameter CreateParm()
        {
            return CreateParm(1)[0];
        }

        /// <summary>
        /// 创建SQL参数
        /// </summary>
        /// <returns></returns>
        public IDataParameter[] CreateParm(int nums)
        {
            IDataParameter[] objParm = null;
            if (enumDBMS == EnumDBMS.SqlServer)
            {
                objParm = new SqlParameter[nums];
                for (int i = 0; i < nums; i++)
                {
                    objParm[i] = new SqlParameter();
                }
            }
            else if (enumDBMS == EnumDBMS.Oracle)
            {
                objParm = new OracleParameter[nums];
                for (int i = 0; i < nums; i++)
                {
                    objParm[i] = new OracleParameter();
                }
            }
            else if (enumDBMS == EnumDBMS.Sybase)
            {
                //objParm = new AseParameter[nums];
                //for (int i = 0; i < nums; i++)
                //{
                //    objParm[i] = new AseParameter();
                //}
            }
            else if (enumDBMS == EnumDBMS.Odbc)
            {
                objParm = new OdbcParameter[nums];
                for (int i = 0; i < nums; i++)
                {
                    objParm[i] = new OdbcParameter();
                }
            }
            return objParm;
        }

        public IDataParameter[] CreateParm(int nums, List<object> lstValue)
        {
            IDataParameter[] objParm = null;
            if (enumDBMS == EnumDBMS.SqlServer)
            {
                objParm = new SqlParameter[nums];
                for (int i = 0; i < nums; i++)
                {
                    objParm[i] = new SqlParameter();
                    objParm[i].Value = lstValue[i];
                }
            }
            else if (enumDBMS == EnumDBMS.Oracle)
            {
                objParm = new OracleParameter[nums];
                for (int i = 0; i < nums; i++)
                {
                    objParm[i] = new OracleParameter();
                    objParm[i].Value = lstValue[i];
                }
            }
            else if (enumDBMS == EnumDBMS.Sybase)
            {
                //objParm = new AseParameter[nums];
                //for (int i = 0; i < nums; i++)
                //{
                //    objParm[i] = new AseParameter();
                //    objParm[i].Value = lstValue[i];
                //}
            }
            else if (enumDBMS == EnumDBMS.Odbc)
            {
                objParm = new OdbcParameter[nums];
                for (int i = 0; i < nums; i++)
                {
                    objParm[i] = new OdbcParameter();
                    objParm[i].Value = lstValue[i];
                }
            }
            return objParm;
        }
        #endregion

        #region Dac.Parm

        #region SQL式

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType">执行类型</param>
        /// <param name="sqlName">sql语句或存储过程名称</param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumExecType execType, string sqlName)
        {
            return GetDacParm(this.enumBiz, execType, sqlName, null, null, null, false, false, false);
        }

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="sqlName"></param>
        /// <param name="isSync"></param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumExecType execType, string sqlName, bool isSync)
        {
            return GetDacParm(this.enumBiz, execType, sqlName, null, null, null, false, false, isSync);
        }

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType">执行类型</param>
        /// <param name="sqlName">sql语句或存储过程名称</param>
        /// <param name="isOnlyRow">是否仅一行</param>
        /// <param name="isMustUpdate">是否必须更新</param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumExecType execType, string sqlName, bool isOnlyRow, bool isMustUpdate)
        {
            return GetDacParm(this.enumBiz, execType, sqlName, null, null, null, isOnlyRow, isMustUpdate, false);
        }

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType">执行类型</param>
        /// <param name="sqlName">sql语句或存储过程名称</param>
        /// <param name="objParm">参数列表</param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumExecType execType, string sqlName, IDataParameter[] objParm)
        {
            return GetDacParm(this.enumBiz, execType, sqlName, objParm, null, null, false, false, false);
        }

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="sqlName"></param>
        /// <param name="objParm"></param>
        /// <param name="isSync"></param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumExecType execType, string sqlName, IDataParameter[] objParm, bool isSync)
        {
            return GetDacParm(this.enumBiz, execType, sqlName, objParm, null, null, false, false, isSync);
        }

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType">执行类型</param>
        /// <param name="sqlName">sql语句或存储过程名称</param>
        /// <param name="objParm">参数列表</param>
        /// <param name="isOnlyRow">是否仅一行</param>
        /// <param name="isMustUpdate">是否必须更新</param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumExecType execType, string sqlName, IDataParameter[] objParm, bool isOnlyRow, bool isMustUpdate)
        {
            return GetDacParm(this.enumBiz, execType, sqlName, objParm, null, null, isOnlyRow, isMustUpdate, false);
        }

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType">执行类型</param>
        /// <param name="sqlName">sql语句或存储过程名称</param>
        /// <param name="objValuesArr">批量执行数值</param>
        /// <param name="objDbTypes">批量执行数据类型</param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumExecType execType, string sqlName, object[][] objValuesArr, DbType[] objDbTypes)
        {
            return GetDacParm(this.enumBiz, execType, sqlName, null, objValuesArr, objDbTypes, false, false, false);
        }

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType">执行类型</param>
        /// <param name="sqlName">sql语句或存储过程名称</param>
        /// <param name="objValuesArr">批量执行数值</param>
        /// <param name="objDbTypes">批量执行数据类型</param>
        /// <param name="isOnlyRow">是否仅一行</param>
        /// <param name="isMustUpdate">是否必须更新</param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumExecType execType, string sqlName, object[][] objValuesArr, DbType[] objDbTypes, bool isOnlyRow, bool isMustUpdate)
        {
            return GetDacParm(this.enumBiz, execType, sqlName, null, objValuesArr, objDbTypes, isOnlyRow, isMustUpdate, false);
        }

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="sqlName"></param>
        /// <param name="objValuesArr"></param>
        /// <param name="objDbTypes"></param>
        /// <param name="isSync"></param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumExecType execType, string sqlName, object[][] objValuesArr, DbType[] objDbTypes, bool isSync)
        {
            return GetDacParm(this.enumBiz, execType, sqlName, null, objValuesArr, objDbTypes, false, false, isSync);
        }

        /// <summary>
        /// 获取提交参数
        /// </summary>
        /// <param name="enumType">执行类型</param>
        /// <param name="sqlName">sql语句或存储过程名称</param>
        /// <param name="objParm">参数列表</param>
        /// <param name="objValuesArr">批量执行数值</param>
        /// <param name="objDbTypes">批量执行数据类型</param>
        /// <param name="isOnlyRow">是否仅一行</param>
        /// <param name="isMustUpdate">是否必须更新</param>
        /// <param name="isSync">是否同步到同结构的数据库</param>
        /// <returns></returns>
        public DacParm GetDacParm(EnumBiz enumBiz, EnumExecType execType, string sqlName, IDataParameter[] objParm,
                                              object[][] objValuesArr, DbType[] objDbTypes, bool isOnlyRow, bool isMustUpdate, bool isSync)
        {
            DacParm dacParm = new DacParm();
            dacParm.connStr = ConnStr(enumBiz.ToString());
            dacParm.enumDBMS = this.enumDBMS;
            dacParm.dataService = DataService();
            dacParm.execType = execType;
            dacParm.sqlName = sqlName;
            dacParm.objParams = objParm;
            dacParm.objValuesArr = objValuesArr;
            dacParm.objDbTypes = objDbTypes;
            dacParm.isOnlyRow = isOnlyRow;
            dacParm.isMustUpdate = isMustUpdate;
            dacParm.isSync = isSync;
            return dacParm;
        }

        #endregion

        #region 存储过程
        /// <summary>
        /// 参数.存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <returns></returns>
        public DacParm GetProcDacParm(string procName)
        {
            return GetProcDacParm(procName, null);
        }
        /// <summary>
        /// 参数.存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="objParm"></param>
        /// <returns></returns>
        public DacParm GetProcDacParm(string procName, IDataParameter[] objParm)
        {
            return GetProcDacParm(procName, objParm, false);
        }
        /// <summary>
        /// 参数.存储过程
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="objParm"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetProcDacParm(string procName, IDataParameter[] objParm, bool isSyn)
        {
            return GetProcDacParm(this.enumBiz, procName, objParm, isSyn);
        }
        /// <summary>
        /// 参数.存储过程
        /// </summary>
        /// <param name="enumBiz"></param>
        /// <param name="procName"></param>
        /// <param name="objParm"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetProcDacParm(EnumBiz enumBiz, string procName, IDataParameter[] objParm, bool isSyn)
        {
            return this.GetDacParm(enumBiz, EnumExecType.ExecProc, procName, objParm, null, null, false, false, isSyn);
        }

        #endregion

        #region 实体式

        #region Insert
        /// <summary>
        /// 参数.插入
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        public DacParm GetInsertParm(BaseDataContract objEntity)
        {
            return GetInsertParm(new BaseDataContract[1] { objEntity });
        }
        /// <summary>
        /// 参数.插入
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="isBulkCopy"></param>
        /// <returns></returns>
        public DacParm GetInsertParm(BaseDataContract objEntity, bool isBulkCopy)
        {
            return GetInsertParm(this.enumBiz, new BaseDataContract[1] { objEntity }, false, false);
        }
        /// <summary>
        /// 参数.插入
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <returns></returns>
        public DacParm GetInsertParm(BaseDataContract[] lstEntity)
        {
            return GetInsertParm(lstEntity, false);
        }
        /// <summary>
        /// 参数.插入
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetInsertParm(BaseDataContract[] lstEntity, bool isSyn)
        {
            return GetInsertParm(this.enumBiz, lstEntity, isSyn);
        }
        /// <summary>
        /// 参数.插入
        /// </summary>
        /// <param name="enumBiz"></param>
        /// <param name="lstEntity"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetInsertParm(EnumBiz enumBiz, BaseDataContract[] lstEntity, bool isSyn)
        {
            return GetInsertParm(this.enumBiz, lstEntity, isSyn, true);
        }
        /// <summary>
        /// 参数.插入
        /// </summary>
        /// <param name="enumBiz"></param>
        /// <param name="lstEntity"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetInsertParm(EnumBiz enumBiz, BaseDataContract[] lstEntity, bool isSyn, bool isBulkCopy)
        {
            string SQL = "insert into " + EntityTools.GetTableName(lstEntity[0]);
            string strCol = " (";
            string strVal = " values (";

            int minNo = 0;
            PropertyInfo colProperty = null;
            Dictionary<PropertyInfo, int> dicSeqCol = new Dictionary<PropertyInfo, int>();
            Dictionary<PropertyInfo, DbType> dicSeqType = new Dictionary<PropertyInfo, DbType>();

            List<DbType> lstDbType = new List<DbType>();
            List<PropertyInfo> lstColProperty = new List<PropertyInfo>();
            List<EntityAttribute> lstAttri = EntityTools.GetFieldAttribute(lstEntity[0]);
            foreach (EntityAttribute attri in lstAttri)
            {
                strCol += attri.FieldName + ", ";
                strVal += "?, ";

                colProperty = EntityTools.GetFieldProperty(lstEntity[0], attri);
                lstDbType.Add(attri.DbType);
                lstColProperty.Add(colProperty);

                // 生成自增值
                if (attri.IsSeq)
                {
                    minNo = this.GetScopeID(EntityTools.GetTableName(lstEntity[0]), attri.FieldName, lstEntity.Length);
                    dicSeqCol.Add(colProperty, minNo);
                    dicSeqType.Add(colProperty, attri.DbType);
                }
            }

            strCol = strCol.Substring(0, strCol.Length - 2) + ")";
            strVal = strVal.Substring(0, strVal.Length - 2) + ")";
            SQL += strCol + strVal;

            object[][] objValues = new object[lstDbType.Count][];
            for (int i = 0; i < objValues.Length; i++)
            {
                objValues[i] = new object[lstEntity.Length];
            }

            for (int i = 0; i < lstEntity.Length; i++)
            {
                for (int j = 0; j < lstColProperty.Count; j++)
                {
                    colProperty = lstColProperty[j];

                    if (colProperty == null)
                    {
                        objValues[j][i] = null;
                    }
                    else
                    {
                        if (dicSeqCol.ContainsKey(colProperty))
                        {
                            minNo = dicSeqCol[colProperty];
                            if (dicSeqType[colProperty] == DbType.Int32)
                            {
                                colProperty.SetValue(lstEntity[i], Convert.ToInt32(minNo), null);
                            }
                            else if (dicSeqType[colProperty] == DbType.Double)
                            {
                                colProperty.SetValue(lstEntity[i], weCare.Core.Utils.Function.Double(minNo), null);
                            }
                            else if (dicSeqType[colProperty] == DbType.Decimal)
                            {
                                colProperty.SetValue(lstEntity[i], weCare.Core.Utils.Function.Dec(minNo), null);
                            }
                            dicSeqCol[colProperty] += 1;
                        }
                        try
                        {
                            objValues[j][i] = colProperty.GetValue(lstEntity[i], null);
                        }
                        catch
                        {
                            objValues[j][i] = null;
                        }
                    }
                }
            }
            if (isBulkCopy)
                return this.GetDacParm(enumBiz, EnumExecType.ExecSqlForBatchSimpleInsert, SQL, null, objValues, lstDbType.ToArray(), false, false, isSyn);
            else
                return this.GetDacParm(enumBiz, EnumExecType.ExecSqlForBatch, SQL, null, objValues, lstDbType.ToArray(), false, false, isSyn);
        }

        #endregion

        #region Delete

        #region 1 根据主键删除 GetDelParmByPk

        /// <summary>
        /// 参数.删除.主键
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        public DacParm GetDelParmByPk(BaseDataContract objEntity)
        {
            return GetDelParmByPk(new BaseDataContract[1] { objEntity });
        }
        /// <summary>
        /// 参数.删除.主键
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <returns></returns>

        public DacParm GetDelParmByPk(BaseDataContract[] lstEntity)
        {
            return GetDelParmByPk(lstEntity, false);
        }
        /// <summary>
        /// 参数.删除.主键
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetDelParmByPk(BaseDataContract[] lstEntity, bool isSyn)
        {
            return GetDelParmByPk(this.enumBiz, lstEntity, isSyn);
        }
        /// <summary>
        /// 参数.删除.主键
        /// </summary>
        /// <param name="enumBiz"></param>
        /// <param name="lstEntity"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetDelParmByPk(EnumBiz enumBiz, BaseDataContract[] lstEntity, bool isSyn)
        {
            List<EntityAttribute> lstAttri = EntityTools.GetFieldAttributePk(lstEntity[0]);
            if (lstAttri == null || lstAttri.Count == 0) return null;

            string strCol = string.Empty;
            string SQL = "delete from " + EntityTools.GetTableName(lstEntity[0]);
            List<PropertyInfo> lstColProperty = new List<PropertyInfo>();
            foreach (EntityAttribute attri in lstAttri)
            {
                strCol += attri.FieldName + " = ? and ";
                lstColProperty.Add(EntityTools.GetFieldProperty(lstEntity[0], attri));
            }
            SQL += " where " + strCol.Substring(0, strCol.Length - 4);

            int n = -1;
            DbType[] dbtypes = new DbType[lstAttri.Count];
            foreach (EntityAttribute attri in lstAttri)
            {
                dbtypes[++n] = attri.DbType;
            }
            object[][] objValues = new object[dbtypes.Length][];
            for (int i = 0; i < objValues.Length; i++)
            {
                objValues[i] = new object[lstEntity.Length];
            }

            for (int i = 0; i < lstEntity.Length; i++)
            {
                n = -1;
                for (int j = 0; j < lstColProperty.Count; j++)
                {
                    try
                    {
                        objValues[++n][i] = lstColProperty[j].GetValue(lstEntity[i], null);
                    }
                    catch
                    {
                        objValues[++n][i] = null;
                    }
                }
            }
            bool isOnlyRow = false; //(lstEntity.Length == 1 ? true : false);
            return this.GetDacParm(enumBiz, EnumExecType.ExecSqlForBatch, SQL, null, objValues, dbtypes, isOnlyRow, false, isSyn);
        }
        #endregion

        #region 2 删除 GetDelParm

        /// <summary>
        /// 参数.删除
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DacParm GetDelParm(BaseDataContract objEntity, string strWhere)
        {
            return GetDelParm(objEntity, new List<string> { strWhere });
        }
        /// <summary>
        /// 参数.删除
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public DacParm GetDelParm(BaseDataContract objEntity, List<string> lstWhere)
        {
            return GetDelParm(new BaseDataContract[1] { objEntity }, lstWhere);
        }
        /// <summary>
        /// 参数.删除
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DacParm GetDelParm(BaseDataContract[] lstEntity, string strWhere)
        {
            return GetDelParm(lstEntity, new List<string> { strWhere });
        }
        /// <summary>
        /// 参数.删除
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public DacParm GetDelParm(BaseDataContract[] lstEntity, List<string> lstWhere)
        {
            return GetDelParm(this.enumBiz, lstEntity, lstWhere, false);
        }
        /// <summary>
        /// 参数.删除
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstWhere"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetDelParm(BaseDataContract[] lstEntity, List<string> lstWhere, bool isSyn)
        {
            return GetDelParm(this.enumBiz, lstEntity, lstWhere, isSyn);
        }
        /// <summary>
        /// 参数.删除
        /// </summary>
        /// <param name="enumSys"></param>
        /// <param name="lstEntity"></param>
        /// <param name="lstWhere"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetDelParm(EnumBiz enumSys, BaseDataContract[] lstEntity, List<string> lstWhere, bool isSyn)
        {
            if (lstWhere == null && lstWhere.Count == 0) return null;
            string strCol = string.Empty;
            string SQL = "delete from " + EntityTools.GetTableName(lstEntity[0]);
            List<PropertyInfo> lstColProperty = new List<PropertyInfo>();
            foreach (string item in lstWhere)
            {
                strCol += EntityTools.GetFieldAttribute(lstEntity[0], item).FieldName + " = ? and ";
                lstColProperty.Add(EntityTools.GetFieldProperty(lstEntity[0], item));
            }
            SQL += " where " + strCol.Substring(0, strCol.Length - 4);

            int n = -1;
            DbType[] dbtypes = new DbType[lstWhere.Count];
            foreach (string item in lstWhere)
            {
                dbtypes[++n] = EntityTools.GetFieldAttribute(lstEntity[0], item).DbType;
            }
            object[][] objValues = new object[dbtypes.Length][];
            for (int i = 0; i < objValues.Length; i++)
            {
                objValues[i] = new object[lstEntity.Length];
            }

            for (int i = 0; i < lstEntity.Length; i++)
            {
                n = -1;
                for (int j = 0; j < lstColProperty.Count; j++)
                {
                    try
                    {
                        objValues[++n][i] = lstColProperty[j].GetValue(lstEntity[i], null);
                    }
                    catch
                    {
                        objValues[++n][i] = null;
                    }
                }
            }
            bool isOnlyRow = false; //(lstWhere.Count == 1 ? true : false);
            return this.GetDacParm(enumSys, EnumExecType.ExecSqlForBatch, SQL, null, objValues, dbtypes, isOnlyRow, false, isSyn);
        }
        #endregion

        #region 3 删除自由式 GetDelParmByFree

        /// <summary>
        /// 参数.删除.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="strWhere"></param>
        /// <param name="objValue"></param>
        /// <returns></returns>
        public DacParm GetDelParmByFree(BaseDataContract objEntity, string strWhere, object objValue)
        {
            return GetDelParmByFree(objEntity, strWhere, new List<object> { objValue }, false);
        }
        /// <summary>
        /// 参数.删除.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="strWhere"></param>
        /// <param name="objValue"></param>
        /// <returns></returns>
        public DacParm GetDelParmByFree(BaseDataContract objEntity, string strWhere, object objValue, bool isOnlyRow)
        {
            return GetDelParmByFree(objEntity, strWhere, new List<object> { objValue }, isOnlyRow);
        }
        /// <summary>
        /// 参数.删除.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="strWhere"></param>
        /// <param name="lstValue"></param>
        /// <returns></returns>
        public DacParm GetDelParmByFree(BaseDataContract objEntity, string strWhere, List<object> lstValue)
        {
            return GetDelParmByFree(objEntity, strWhere, lstValue, false, false);
        }
        /// <summary>
        /// 参数.删除.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="strWhere"></param>
        /// <param name="lstValue"></param>
        /// <returns></returns>
        public DacParm GetDelParmByFree(BaseDataContract objEntity, string strWhere, List<object> lstValue, bool isOnlyRow)
        {
            return GetDelParmByFree(objEntity, strWhere, lstValue, isOnlyRow, false);
        }
        /// <summary>
        /// 参数.删除.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="strWhere"></param>
        /// <param name="lstValue"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetDelParmByFree(BaseDataContract objEntity, string strWhere, List<object> lstValue, bool isOnlyRow, bool isSyn)
        {
            return GetDelParmByFree(this.enumBiz, objEntity, strWhere, lstValue, isOnlyRow, isSyn);
        }
        /// <summary>
        /// 参数.删除.自由式
        /// </summary>
        /// <param name="enumBiz"></param>
        /// <param name="objEntity"></param>
        /// <param name="strWhere"></param>
        /// <param name="lstValue"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetDelParmByFree(EnumBiz enumBiz, BaseDataContract objEntity, string strWhere, List<object> lstValue, bool isOnlyRow, bool isSyn)
        {
            if (string.IsNullOrEmpty(strWhere)) return null;
            string SQL = "delete from " + EntityTools.GetTableName(objEntity) + " where " + strWhere;
            IDataParameter[] objParas = this.CreateParm(lstValue.Count);
            int n = -1;
            foreach (object obj in lstValue)
            {
                objParas[++n].Value = obj;
            }
            return this.GetDacParm(enumBiz, EnumExecType.ExecSql, SQL, objParas, null, null, isOnlyRow, false, isSyn);
        }
        #endregion

        #endregion

        #region Update

        #region 1 参数.更新.主键 GetUpdateParmByPk

        /// <summary>
        /// 参数.更新.主键
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByPk(BaseDataContract objEntity)
        {
            return GetUpdateParmByPk(new BaseDataContract[1] { objEntity });
        }
        /// <summary>
        /// 参数.更新.主键
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByPk(BaseDataContract[] lstEntity)
        {
            //return GetUpdateParmByPk(lstEntity, null);
            return GetUpdateParmByPk(lstEntity, lstEntity);
        }

        /// <summary>
        /// 参数.更新.主键
        /// </summary>
        /// <param name="objEntityNew"></param>
        /// <param name="objEntityOrg"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByPk(BaseDataContract objEntityNew, BaseDataContract objEntityOrg)
        {
            return GetUpdateParmByPk(this.enumBiz, new BaseDataContract[1] { objEntityNew }, new BaseDataContract[1] { objEntityOrg }, false);
        }

        /// <summary>
        /// 参数.更新.主键
        /// </summary>
        /// <param name="lstEntityNew"></param>
        /// <param name="lstEntityOrg"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByPk(BaseDataContract[] lstEntityNew, BaseDataContract[] lstEntityOrg)
        {
            return GetUpdateParmByPk(this.enumBiz, lstEntityNew, lstEntityOrg, false);
        }

        /// <summary>
        /// 参数.更新.主键
        /// </summary>
        /// <param name="lstEntityNew"></param>
        /// <param name="lstEntityOrg"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByPk(BaseDataContract[] lstEntityNew, BaseDataContract[] lstEntityOrg, bool isSyn)
        {
            return GetUpdateParmByPk(this.enumBiz, lstEntityNew, lstEntityOrg, isSyn);
        }

        /// <summary>
        /// 参数.更新.主键
        /// </summary>
        /// <param name="enumBiz"></param>
        /// <param name="lstEntityNew"></param>
        /// <param name="lstEntityOrg"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByPk(EnumBiz enumBiz, BaseDataContract[] lstEntityNew, BaseDataContract[] lstEntityOrg, bool isSyn)
        {
            // 条件列
            List<EntityAttribute> lstKeyAttri = new List<EntityAttribute>();
            List<EntityAttribute> lstAttriPk = new List<EntityAttribute>();

            // 根据主键更新
            lstAttriPk = EntityTools.GetFieldAttributePk(lstEntityOrg[0]);
            if (lstAttriPk == null || lstAttriPk.Count == 0) return null;
            lstKeyAttri.AddRange(lstAttriPk);

            // 更新列--全部列
            List<EntityAttribute> lstUpdateAttri = new List<EntityAttribute>();
            lstUpdateAttri.AddRange(EntityTools.GetFieldAttribute(lstEntityOrg[0]));

            int n = -1;
            string strVal = string.Empty;
            string strCol = string.Empty;
            string SQL = "update " + EntityTools.GetTableName(lstEntityOrg[0]);

            int updateFieldCount = 0;
            List<PropertyInfo> lstColProperty = new List<PropertyInfo>();
            List<string> lstkeyField = new List<string>();
            List<DbType> lstDbTypes = new List<DbType>();
            foreach (EntityAttribute attri in lstUpdateAttri)
            {
                strVal += attri.FieldName + " = ?, ";
                lstDbTypes.Add(attri.DbType);
                lstColProperty.Add(EntityTools.GetFieldProperty(lstEntityOrg[0], attri));
                //lstkeyField.Add(EntityTools.GetFieldProperty(lstEntityOrg[0], attri).f // .FieldName);
                updateFieldCount++;
            }
            foreach (EntityAttribute attri in lstKeyAttri)
            {
                strCol += attri.FieldName + " = ? and ";
                lstDbTypes.Add(attri.DbType);
                lstColProperty.Add(EntityTools.GetFieldProperty(lstEntityOrg[0], attri));
            }

            SQL += " set " + strVal.Substring(0, strVal.Length - 2) + " where " + strCol.Substring(0, strCol.Length - 4);
            object[][] objValues = new object[lstDbTypes.Count][];
            for (int i = 0; i < objValues.Length; i++)
            {
                objValues[i] = new object[lstEntityOrg.Length];
            }

            for (int i = 0; i < lstEntityOrg.Length; i++)
            {
                n = -1;
                for (int j = 0; j < lstColProperty.Count; j++)
                {
                    try
                    {
                        if (j < updateFieldCount)
                        {
                            objValues[++n][i] = lstColProperty[j].GetValue(lstEntityNew[i], null);
                        }
                        else
                        {
                            objValues[++n][i] = lstColProperty[j].GetValue(lstEntityOrg[i], null);
                        }
                    }
                    catch
                    {
                        objValues[++n][i] = null;
                    }
                }
            }
            return this.GetDacParm(enumBiz, EnumExecType.ExecSqlForBatch, SQL, null, objValues, lstDbTypes.ToArray(), false, true, isSyn);
        }
        #endregion

        #region 2 参数.更新 GetUpdateParm

        #region 通过实体(数组)，主键或指定列

        /// <summary>
        /// 参数.更新
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstKeyFields"></param>
        /// <returns></returns>
        public DacParm GetUpdateParm(BaseDataContract[] lstEntity, List<string> lstKeyFields)
        {
            return GetUpdateParm(lstEntity, null, lstKeyFields);
        }

        public DacParm GetUpdateParm(BaseDataContract entity, List<string> lstUpdateFields, List<string> lstKeyFields)
        {
            BaseDataContract[] voArr = new BaseDataContract[1];
            voArr[0] = entity;
            return GetUpdateParm(this.enumBiz, voArr, lstUpdateFields, lstKeyFields, false);
        }

        /// <summary>
        /// 参数.更新
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="lstUpdateFields"></param>
        /// <param name="lstKeyFields"></param>
        /// <returns></returns>
        public DacParm GetUpdateParm(BaseDataContract[] lstEntity, List<string> lstUpdateFields, List<string> lstKeyFields)
        {
            return GetUpdateParm(this.enumBiz, lstEntity, lstUpdateFields, lstKeyFields, false);
        }
        /// <summary>
        /// 参数.更新
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetUpdateParm(BaseDataContract[] lstEntity, List<string> lstUpdateFields, List<string> lstKeyFields, bool isSyn)
        {
            return GetUpdateParm(this.enumBiz, lstEntity, lstUpdateFields, lstKeyFields, isSyn);
        }
        /// <summary>
        /// 参数.更新
        /// </summary>
        /// <param name="enumBiz"></param>
        /// <param name="lstEntity"></param>
        /// <param name="lstUpdateFields">更新列</param>
        /// <param name="lstKeyFields">条件列</param>
        /// <param name="isSyn">是否同步分库</param>
        /// <returns></returns>
        public DacParm GetUpdateParm(EnumBiz enumBiz, BaseDataContract[] lstEntity, List<string> lstUpdateFields, List<string> lstKeyFields, bool isSyn)
        {
            // 条件列
            List<EntityAttribute> lstKeyAttri = new List<EntityAttribute>();
            List<EntityAttribute> lstAttriPk = new List<EntityAttribute>();
            if (lstKeyFields == null || lstKeyFields.Count == 0) // 条件列为空，使用主键更新
            {
                lstAttriPk = EntityTools.GetFieldAttributePk(lstEntity[0]);
                if (lstAttriPk == null || lstAttriPk.Count == 0) return null;
                lstKeyAttri.AddRange(lstAttriPk);
            }
            else
            {
                foreach (string key in lstKeyFields)
                {
                    lstKeyAttri.Add(EntityTools.GetFieldAttribute(lstEntity[0], key));
                }
            }

            // 更新列
            List<EntityAttribute> lstAttriField = EntityTools.GetFieldAttribute(lstEntity[0]);
            List<EntityAttribute> lstUpdateAttri = new List<EntityAttribute>();
            if (lstUpdateFields == null || lstUpdateFields.Count == 0) // 更新列为空，使用全部列
            {
                lstUpdateAttri.AddRange(lstAttriField);
            }
            else
            {
                foreach (string key in lstUpdateFields)
                {
                    lstUpdateAttri.Add(EntityTools.GetFieldAttribute(lstEntity[0], key));
                }
            }

            int n = -1;
            string strVal = string.Empty;
            string strCol = string.Empty;
            string SQL = "update " + EntityTools.GetTableName(lstEntity[0]);

            List<PropertyInfo> lstColProperty = new List<PropertyInfo>();
            List<DbType> lstDbTypes = new List<DbType>();
            foreach (EntityAttribute attri in lstUpdateAttri)
            {
                // 条件列不更新
                if (lstKeyAttri.Exists(t => t.FieldName == attri.FieldName)) continue;
                strVal += attri.FieldName + " = ?, ";
                lstDbTypes.Add(attri.DbType);
                lstColProperty.Add(EntityTools.GetFieldProperty(lstEntity[0], attri));
            }
            foreach (EntityAttribute attri in lstKeyAttri)
            {
                strCol += attri.FieldName + " = ? and ";
                lstDbTypes.Add(attri.DbType);
                lstColProperty.Add(EntityTools.GetFieldProperty(lstEntity[0], attri));
            }

            SQL += " set " + strVal.Substring(0, strVal.Length - 2) + " where " + strCol.Substring(0, strCol.Length - 4);
            object[][] objValues = new object[lstDbTypes.Count][];
            for (int i = 0; i < objValues.Length; i++)
            {
                objValues[i] = new object[lstEntity.Length];
            }

            for (int i = 0; i < lstEntity.Length; i++)
            {
                n = -1;
                for (int j = 0; j < lstColProperty.Count; j++)
                {
                    try
                    {
                        objValues[++n][i] = lstColProperty[j].GetValue(lstEntity[i], null);
                    }
                    catch
                    {
                        objValues[++n][i] = null;
                    }
                }
            }
            return this.GetDacParm(enumBiz, EnumExecType.ExecSqlForBatch, SQL, null, objValues, lstDbTypes.ToArray(), false, true, isSyn);
        }

        #endregion

        #region 通过更新列、条件列 Dictionary

        /// <summary>
        /// 参数.更新
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="dicSet"></param>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        public DacParm GetUpdateParm(BaseDataContract objEntity, Dictionary<string, object> dicSet, Dictionary<string, object> dicWhere)
        {
            return GetUpdateParm(objEntity, new List<Dictionary<string, object>> { dicSet }, new List<Dictionary<string, object>> { dicWhere });
        }
        /// <summary>
        /// 参数.更新
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="dicSet"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public DacParm GetUpdateParm(BaseDataContract objEntity, Dictionary<string, object> dicSet, List<Dictionary<string, object>> lstWhere)
        {
            List<Dictionary<string, object>> lstTmp = new List<Dictionary<string, object>>();
            for (int i = 0; i < lstWhere.Count; i++)
            {
                lstTmp.Add(Function.CloneByBinary(dicSet) as Dictionary<string, object>);
            }
            return GetUpdateParm(objEntity, lstTmp, lstWhere);
        }
        /// <summary>
        /// 参数.更新
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="lstSet"></param>
        /// <param name="lstWhere"></param>
        /// <returns></returns>
        public DacParm GetUpdateParm(BaseDataContract objEntity, List<Dictionary<string, object>> lstSet, List<Dictionary<string, object>> lstWhere)
        {
            return GetUpdateParm(objEntity, lstSet, lstWhere, false);
        }
        /// <summary>
        /// 参数.更新
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="lstSet"></param>
        /// <param name="lstWhere"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetUpdateParm(BaseDataContract objEntity, List<Dictionary<string, object>> lstSet, List<Dictionary<string, object>> lstWhere, bool isSyn)
        {
            return GetUpdateParm(this.enumBiz, objEntity, lstSet, lstWhere, isSyn);
        }
        /// <summary>
        /// 参数.更新
        /// </summary>
        /// <param name="enumBiz"></param>
        /// <param name="objEntity"></param>
        /// <param name="lstSet"></param>
        /// <param name="lstWhere"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetUpdateParm(EnumBiz enumBiz, BaseDataContract objEntity, List<Dictionary<string, object>> lstSet, List<Dictionary<string, object>> lstWhere, bool isSyn)
        {
            if (lstWhere == null && lstWhere.Count == 0) return null;
            string strVal = string.Empty;
            string strCol = string.Empty;
            string SQL = "update " + EntityTools.GetTableName(objEntity);
            string[] setArr = new string[lstSet[0].Keys.Count];
            string[] whereArr = new string[lstWhere[0].Keys.Count];
            lstSet[0].Keys.CopyTo(setArr, 0);
            lstWhere[0].Keys.CopyTo(whereArr, 0);

            int n = -1;
            DbType[] dbtypes = new DbType[lstSet[0].Keys.Count + lstWhere[0].Keys.Count];
            foreach (string item in lstSet[0].Keys)
            {
                strVal += EntityTools.GetFieldAttribute(objEntity, item).FieldName + " = ?, ";
                dbtypes[++n] = EntityTools.GetFieldAttribute(objEntity, item).DbType;
            }

            foreach (string item in lstWhere[0].Keys)
            {
                strCol += EntityTools.GetFieldAttribute(objEntity, item).FieldName + " = ? and ";
                dbtypes[++n] = EntityTools.GetFieldAttribute(objEntity, item).DbType;
            }

            SQL += " set " + strVal.Substring(0, strVal.Length - 2) + " where " + strCol.Substring(0, strCol.Length - 4);
            object[][] objValues = new object[dbtypes.Length][];
            for (int i = 0; i < objValues.Length; i++)
            {
                objValues[i] = new object[lstWhere.Count];
            }

            for (int i = 0; i < lstWhere.Count; i++)
            {
                n = -1;
                for (int j = 0; j < setArr.Length; j++)
                {
                    objValues[++n][i] = lstSet[i][setArr[j]];
                }
                for (int j = 0; j < whereArr.Length; j++)
                {
                    objValues[++n][i] = lstWhere[i][whereArr[j]];
                }
            }
            return this.GetDacParm(enumBiz, EnumExecType.ExecSqlForBatch, SQL, null, objValues, dbtypes, false, true, isSyn);
        }
        #endregion

        #endregion

        #region 3 参数.更新.自由式 GetUpdateParmByFree

        /// <summary>
        /// 参数.更新.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="dicSet"></param>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByFree(BaseDataContract objEntity, Dictionary<string, object> dicSet, Dictionary<string, object> dicWhere)
        {
            string[] strArr = new string[1];
            Dictionary<string, List<object>> dicTmp1 = new Dictionary<string, List<object>>();
            Dictionary<string, List<object>> dicTmp2 = new Dictionary<string, List<object>>();

            dicSet.Keys.CopyTo(strArr, 0);
            dicTmp1.Add(strArr[0], new List<object> { dicSet[strArr[0]] });

            dicWhere.Keys.CopyTo(strArr, 0);
            dicTmp2.Add(strArr[0], new List<object> { dicWhere[strArr[0]] });

            return GetUpdateParmByFree(objEntity, dicTmp1, dicTmp2);
        }
        /// <summary>
        /// 参数.更新.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="dicSet"></param>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByFree(BaseDataContract objEntity, Dictionary<string, List<object>> dicSet, Dictionary<string, object> dicWhere)
        {
            string[] strArr = new string[1];
            dicWhere.Keys.CopyTo(strArr, 0);
            Dictionary<string, List<object>> dicTmp = new Dictionary<string, List<object>>();
            dicTmp.Add(strArr[0], new List<object> { dicWhere[strArr[0]] });
            return GetUpdateParmByFree(objEntity, dicSet, dicTmp);
        }
        /// <summary>
        /// 参数.更新.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="dicSet"></param>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByFree(BaseDataContract objEntity, Dictionary<string, object> dicSet, Dictionary<string, List<object>> dicWhere)
        {
            string[] strArr = new string[1];
            dicSet.Keys.CopyTo(strArr, 0);
            Dictionary<string, List<object>> dicTmp = new Dictionary<string, List<object>>();
            dicTmp.Add(strArr[0], new List<object> { dicSet[strArr[0]] });
            return GetUpdateParmByFree(objEntity, dicTmp, dicWhere);
        }
        /// <summary>
        /// 参数.更新.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="dicSet"></param>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByFree(BaseDataContract objEntity, Dictionary<string, List<object>> dicSet, Dictionary<string, List<object>> dicWhere)
        {
            return GetUpdateParmByFree(objEntity, dicSet, dicWhere, false);
        }
        /// <summary>
        /// 参数.更新.自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="dicSet"></param>
        /// <param name="dicWhere"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByFree(BaseDataContract objEntity, Dictionary<string, List<object>> dicSet, Dictionary<string, List<object>> dicWhere, bool isSyn)
        {
            return GetUpdateParmByFree(this.enumBiz, objEntity, dicSet, dicWhere, isSyn);
        }
        /// <summary>
        /// 参数.更新.自由式
        /// </summary>
        /// <param name="enumBiz"></param>
        /// <param name="objEntity"></param>
        /// <param name="dicSet"></param>
        /// <param name="dicWhere"></param>
        /// <param name="isSyn"></param>
        /// <returns></returns>
        public DacParm GetUpdateParmByFree(EnumBiz enumBiz, BaseDataContract objEntity, Dictionary<string, List<object>> dicSet, Dictionary<string, List<object>> dicWhere, bool isSyn)
        {
            if (dicWhere == null && dicWhere.Count == 0) return null;
            string[] setArr = new string[dicSet.Keys.Count];
            string[] whereArr = new string[dicWhere.Keys.Count];
            dicSet.Keys.CopyTo(setArr, 0);
            dicWhere.Keys.CopyTo(whereArr, 0);
            string SQL = "update " + EntityTools.GetTableName(objEntity) + " set " + setArr[0] + " where " + whereArr[0];

            IDataParameter[] objParas = this.CreateParm(dicSet[setArr[0]].Count + dicWhere[whereArr[0]].Count);
            int n = -1;
            foreach (object obj in dicSet[setArr[0]])
            {
                objParas[++n].Value = obj;
            }
            foreach (object obj in dicWhere[whereArr[0]])
            {
                objParas[++n].Value = obj;
            }
            return this.GetDacParm(enumBiz, EnumExecType.ExecSql, SQL, objParas, null, null, false, true, isSyn);
        }
        #endregion
        #endregion
        #endregion
        #endregion

        #region DataService
        /// <summary>
        /// DataService
        /// </summary>
        /// <returns></returns>
        IDataService DataService()
        {
            if (enumDBMS == EnumDBMS.SqlServer)
            {
                return new SqlServer();
            }
            else if (enumDBMS == EnumDBMS.Oracle)
            {
                return new Oracle();
            }
            else if (enumDBMS == EnumDBMS.Sybase)
            {
                //return new Sybase();
            }
            else if (enumDBMS == EnumDBMS.Odbc)
            {
                //return new Odbc();
            }
            return null;
        }
        /// <summary>
        /// DataService
        /// </summary>
        /// <param name="dbms"></param>
        /// <returns></returns>
        IDataService DataService(EnumDBMS dbms)
        {
            if (dbms == EnumDBMS.SqlServer)
            {
                return new SqlServer();
            }
            else if (dbms == EnumDBMS.Oracle)
            {
                return new Oracle();
            }
            else if (dbms == EnumDBMS.Sybase)
            {
                //return new Sybase();
            }
            else if (dbms == EnumDBMS.Odbc)
            {
                //return new Odbc();
            }
            return null;
        }
        #endregion

        #region ServerTime
        /// <summary>
        /// ServerTime
        /// </summary>
        /// <returns></returns>
        public DateTime ServerTime()
        {
            DateTime dtmNow = DateTime.Now;
            string SQL = string.Empty;
            if (enumDBMS == EnumDBMS.SqlServer)
            {
                SQL = @"select getdate()";
            }
            else if (enumDBMS == EnumDBMS.Oracle)
            {
                SQL = @"select sysdate from dual";
            }
            DataTable dt = this.GetDataTable(SQL);
            // 防止SQL SERVER毫秒的影响
            return Convert.ToDateTime(Convert.ToDateTime(dt.Rows[0][0]).ToString("yyyy-MM-dd HH:mm:ss"));
        }
        #endregion

        #region 自增值

        #region 自增值.返回将表中指定行的一个列递增一个值
        /// <summary>
        /// 自增值.返回将表中指定行的一个列递增一个值
        /// </summary>
        /// <param name="tableName">要递增的表</param>
        /// <param name="idName">要递增的字段名</param>
        /// <param name="addNum">每次递增量</param>
        /// <param name="keyName">需设定递增值的行对应的键值字段名</param>
        /// <param name="keyValue">需设定递增值的行对应的键值列值</param>
        /// <returns></returns>
        public int GetIdentityID(string tableName, string idName, int addNum, string keyName, string keyValue)
        {
            string SQL = @"update {0} 
                              set {1} = {1} + {2}
                            where {3} = ?";
            SQL = string.Format(SQL, tableName, idName, addNum, keyName);

            IDataParameter[] objParm = this.CreateParm(1);
            objParm[0].Value = keyValue;
            int rows = this.Commit(this.GetDacParm(EnumExecType.ExecSql, SQL, objParm, true, true));
            if (rows > 0)
            {
                SQL = @"select {1} 
                          from {0}
                         where {2} = ?";
                SQL = string.Format(SQL, tableName, idName, keyName);
                objParm = this.CreateParm(1);
                objParm[0].Value = keyValue;
                DataTable dt = this.GetDataTable(SQL, objParm);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        return Convert.ToInt32(dt.Rows[0][0]);
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            return 1;
        }
        #endregion

        #region Seq表形式

        #region 检查
        /// <summary>
        /// 检查
        /// </summary>
        /// <param name="tabName"></param>
        /// <param name="colName"></param>
        /// <returns></returns>
        private int CheckSequence(string tabName, string colName)
        {
            string SQL = @"select 1 from sysSequenceid t where t.tabname = ? and t.colname = ?";

            IDataParameter[] objParm = this.CreateParm(2);
            objParm[0].Value = tabName;
            objParm[1].Value = colName;
            DataTable dt = this.GetDataTable(SQL, objParm);
            if (dt == null || dt.Rows.Count == 0)
            {
                EntitySequenceID vo = new EntitySequenceID();
                vo.Tabname = tabName;
                vo.Colname = colName;
                vo.Curid = 0;

                return this.Commit(this.GetInsertParm(vo));
            }
            return 1;
        }
        #endregion

        #region 获取下一个ID
        /// <summary>
        /// 获取下一个ID
        /// </summary>
        /// <param name="tabName"></param>
        /// <param name="colName"></param>
        /// <returns>获取下一个ID</returns>
        public int GetNextID(string tabName, string colName)
        {
            return GetScopeID(tabName, colName, 1);
        }
        #endregion

        #region 获取指定步长ID.返回最小值
        /// <summary>
        /// 获取指定步长ID.返回最小值
        /// </summary>
        /// <param name="tabName"></param>
        /// <param name="colName"></param>
        /// <returns>返回最小值</returns>
        public int GetScopeID(string tabName, string colName, int stepNum)
        {
            int intMinID = 0;
            string SQL = string.Empty;
            tabName = tabName.ToLower();
            colName = colName.ToLower();

            try
            {
                if (this.CheckSequence(tabName, colName) >= 0)
                {
                    EntitySequenceID vo = new EntitySequenceID();
                    string strSet = EntityTools.GetFieldName(vo, EntitySequenceID.Columns.Curid) + " = " + EntityTools.GetFieldName(vo, EntitySequenceID.Columns.Curid) + " + ? ";
                    string strWhere = EntityTools.GetFieldName(vo, EntitySequenceID.Columns.Tabname) + " = ? and " + EntityTools.GetFieldName(vo, EntitySequenceID.Columns.Colname) + " = ? ";

                    Dictionary<string, object> dicSet = new Dictionary<string, object>();
                    dicSet.Add(strSet, stepNum);
                    Dictionary<string, List<object>> dicWhere = new Dictionary<string, List<object>>();
                    dicWhere.Add(strWhere, new List<object> { tabName, colName });

                    if (this.Commit(GetUpdateParmByFree(vo, dicSet, dicWhere)) > 0)
                    {
                        SQL = @"select curid
                                  from sysSequenceid
                                 where tabname = ?
                                   and colname = ?";

                        IDataParameter[] objParm = this.CreateParm(2);
                        objParm[0].Value = tabName;
                        objParm[1].Value = colName;

                        DataTable dt = this.GetDataTable(SQL, objParm);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            int intMaxID = (dt.Rows[0]["curid"] == System.DBNull.Value) ? 1 : Function.Int(dt.Rows[0]["curid"]);
                            intMinID = intMaxID - stepNum + 1;
                        }
                        else
                        {
                            intMinID = 1;
                        }
                    }
                    else
                    {
                        intMinID = -1;
                    }
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException(e);
                intMinID = 1;
            }

            return intMinID;
        }
        #endregion

        #endregion

        #endregion

        #region Get

        #region GetDataTable
        /// <summary>
        /// GetDataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql)
        {
            return GetDataTable(sql, new List<IDataParameter>());
        }

        public DataTable GetDataTable(string sql, IDataParameter parm)
        {
            return GetDataTable(sql, new List<IDataParameter>() { parm });
        }
        /// <summary>
        /// GetDataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql, IDataParameter[] objParm)
        {
            return DataService().GetDataTable(connStr, sql, objParm);
        }
        /// <summary>
        /// GetDataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="lstParm"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql, List<IDataParameter> lstParm)
        {
            return DataService().GetDataTable(connStr, sql, (lstParm == null || lstParm.Count == 0) ? null : lstParm.ToArray());
        }
        #endregion

        #region GetDataTableFromProc

        /// <summary>
        /// GetDataTableFromProc
        /// </summary>
        /// <param name="procName"></param>
        /// <returns></returns>
        public DataTable GetDataTableFromProc(string procName)
        {
            return GetDataTableFromProc(procName, null);
        }

        /// <summary>
        /// GetDataTableFromProc
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="objParms"></param>
        /// <returns></returns>
        public DataTable GetDataTableFromProc(string procName, params IDataParameter[] objParm)
        {
            return DataService().GetDataTableFromProc(connStr, procName, objParm);
        }

        #endregion

        #region 表单(单实体)

        /// <summary>
        /// 表单(单实体) - 主键
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        public DataTable SelectPk(BaseDataContract objEntity)
        {
            return SelectPk(new BaseDataContract[1] { objEntity }, null);
        }

        /// <summary>
        /// 表单(单实体) - 主键
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="lstFields"></param>
        /// <returns></returns>
        public DataTable SelectPk(BaseDataContract objEntity, List<string> lstFields)
        {
            return SelectPk(new BaseDataContract[1] { objEntity }, lstFields);
        }

        /// <summary>
        /// 表单(单实体) - 主键
        /// </summary>
        /// <param name="lstEntity"></param>
        /// <returns></returns>
        public DataTable SelectPk(BaseDataContract[] lstEntity, List<string> lstFields)
        {
            List<EntityAttribute> lstAttriPk = EntityTools.GetFieldAttributePk(lstEntity[0]);
            if (lstAttriPk == null || lstAttriPk.Count == 0) return null;

            string strTableName = EntityTools.GetTableName(lstEntity[0]);
            string strCol = "select ";
            string strVal = string.Empty;

            List<EntityAttribute> lstAttri = new List<EntityAttribute>();
            if (lstFields == null || lstFields.Count == 0)  // 显示域为空则显示所有列
            {
                lstAttri = EntityTools.GetFieldAttribute(lstEntity[0]);
            }
            else
            {
                foreach (string col in lstFields)
                {
                    lstAttri.Add(EntityTools.GetFieldAttribute(lstEntity[0], col));
                }
            }
            foreach (EntityAttribute attri in lstAttri)
            {
                strCol += attri.FieldName + ", ";
            }

            int n = 0;
            IDataParameter[] objParm = this.CreateParm(lstAttriPk.Count * lstEntity.Length);
            List<string> lstPara = new List<string>();
            for (int i = 0; i < lstEntity.Length; i++)
            {
                foreach (EntityAttribute attri in lstAttriPk)
                {
                    strVal += attri.FieldName + " = ? and ";
                    objParm[n].DbType = attri.DbType;
                    try
                    {
                        objParm[n].Value = EntityTools.GetFieldProperty(lstEntity[i], attri).GetValue(lstEntity[i], null);
                    }
                    catch
                    {
                        objParm[n].Value = null;
                    }
                    n++;
                }
                lstPara.Add(strVal.Substring(0, strVal.Length - 4));
                strVal = string.Empty;
            }
            foreach (string str in lstPara)
            {
                strVal += "(" + str + ") or ";
            }

            string SQL = strCol.Substring(0, strCol.Length - 2) + " from " + strTableName + " where " + strVal.Substring(0, strVal.Length - 3);
            DataTable dt = this.GetDataTable(SQL, objParm);
            dt.TableName = strTableName;
            return dt;
        }

        /// <summary>
        /// 表单(单实体) - 全表
        /// </summary>
        /// <param name="objEntity"></param>
        /// <returns></returns>
        public DataTable Select(BaseDataContract objEntity)
        {
            return Select(objEntity, null, string.Empty);
        }

        /// <summary>
        /// 表单(单实体) - 按字段查找
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public DataTable Select(BaseDataContract entity, string fieldName)
        {
            return Select(entity, new List<string>() { fieldName });
        }

        /// <summary>
        /// 表单(单实体) - 按列
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="lstCols"></param>
        /// <returns></returns>
        public DataTable Select(BaseDataContract objEntity, List<string> lstCols)
        {
            return Select(objEntity, null, lstCols, string.Empty, null);
        }

        public DataTable SelectSort(BaseDataContract objEntity, List<string> lstCols, string sortCol)
        {
            return Select(objEntity, null, lstCols, string.Empty, new List<string>() { sortCol });
        }

        public DataTable SelectSort(BaseDataContract objEntity, List<string> lstCols, List<string> lstSorts)
        {
            return Select(objEntity, null, lstCols, string.Empty, lstSorts);
        }

        public DataTable SelectSort(BaseDataContract objEntity, List<string> lstCols, string opSign, List<string> lstSorts)
        {
            return Select(objEntity, null, lstCols, opSign, lstSorts);
        }

        public DataTable Select(BaseDataContract objEntity, List<string> lstCols, string opSign)
        {
            return Select(objEntity, null, lstCols, opSign, null);
        }

        public DataTable SelectFields(BaseDataContract objEntity, List<string> lstFields)
        {
            return Select(objEntity, lstFields, null, string.Empty, null);
        }

        public DataTable Select(BaseDataContract objEntity, List<string> lstFields, List<string> lstCols)
        {
            return Select(objEntity, lstFields, lstCols, string.Empty, null);
        }

        public DataTable Select(BaseDataContract objEntity, List<string> lstCols, string opSign, List<string> lstSorts)
        {
            return Select(objEntity, null, lstCols, opSign, lstSorts);
        }

        public DataTable SelectFields(BaseDataContract objEntity, List<string> lstFields, List<string> lstSorts)
        {
            return Select(objEntity, lstFields, null, string.Empty, lstSorts);
        }

        public DataTable Select(BaseDataContract objEntity, List<string> lstFields, List<string> lstCols, List<string> lstSorts)
        {
            return Select(objEntity, lstFields, lstCols, string.Empty, lstSorts);
        }

        /// <summary>
        /// 表单(单实体) - 按列
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="lstFields">显示域</param>
        /// <param name="lstCols">条件列</param>
        /// <param name="opSign">值等或不等</param>
        /// <returns></returns>
        public DataTable Select(BaseDataContract objEntity, List<string> lstFields, List<string> lstCols, string opSign, List<string> lstSortCols)
        {
            string strTableName = EntityTools.GetTableName(objEntity);
            string strCol = "select ";
            DataTable dt = null;
            if (string.IsNullOrEmpty(opSign) || opSign.Trim() == "") opSign = "=";

            List<EntityAttribute> lstAttri = new List<EntityAttribute>();
            if (lstFields == null || lstFields.Count == 0)  // 显示域为空则显示所有列
            {
                lstAttri = EntityTools.GetFieldAttribute(objEntity);
            }
            else
            {
                foreach (string col in lstFields)
                {
                    lstAttri.Add(EntityTools.GetFieldAttribute(objEntity, col));
                }
            }
            foreach (EntityAttribute attri in lstAttri)
            {
                strCol += attri.FieldName + ", ";
            }

            // 排序列
            string strSortCol = string.Empty;
            if (lstSortCols != null && lstSortCols.Count > 0)
            {
                List<EntityAttribute> lstTmp = new List<EntityAttribute>();
                foreach (string col in lstSortCols)
                {
                    lstTmp.Add(EntityTools.GetFieldAttribute(objEntity, col));
                }
                foreach (EntityAttribute attri in lstTmp)
                {
                    strSortCol += attri.FieldName + ",";
                }
                strSortCol = " order by " + strSortCol.TrimEnd(',');
            }

            string SQL = strCol.Substring(0, strCol.Length - 2) + " from " + strTableName;
            if (lstCols != null && lstCols.Count > 0)
            {
                strCol = string.Empty;
                string strVal = string.Empty;
                object obj = null;
                List<object> lstObj = new List<object>();
                List<PropertyInfo> lstColProperty = new List<PropertyInfo>();
                string sign = " " + opSign + " "; //isEqualsOrNot ? " = " : " <> ";
                foreach (string col in lstCols)
                {
                    try
                    {
                        obj = EntityTools.GetFieldProperty(objEntity, col).GetValue(objEntity, null);
                    }
                    catch
                    { obj = null; }
                    if (obj != null && obj.GetType() == typeof(String))
                    {
                        try
                        {
                            strVal = obj.ToString();
                        }
                        catch { strVal = string.Empty; }
                        if (!string.IsNullOrEmpty(strVal))
                        {
                            if (strVal.ToLower().Trim().StartsWith("in ("))
                            {
                                strCol += EntityTools.GetFieldAttribute(objEntity, col).FieldName + " " + strVal + " and ";
                                continue;
                            }
                        }
                    }
                    strCol += EntityTools.GetFieldAttribute(objEntity, col).FieldName + sign + " ? and ";
                    lstObj.Add(obj);
                    //lstColProperty.Add(EntityTools.GetFieldProperty(objEntity, col));
                }
                SQL += " where " + strCol.Substring(0, strCol.Length - 4);

                IDataParameter[] objParm = this.CreateParm(lstObj.Count);
                for (int i = 0; i < lstObj.Count; i++)
                {
                    objParm[i].Value = lstObj[i];
                }
                //IDataParameter[] objParm = this.CreateParm(lstCols.Count);
                //for (int i = 0; i < lstColProperty.Count; i++)
                //{
                //    try
                //    {
                //        objParm[i].Value = lstColProperty[i].GetValue(objEntity, null);
                //    }
                //    catch
                //    {
                //        objParm[i].Value = null;
                //    }
                //}
                SQL += strSortCol;
                dt = this.GetDataTable(SQL, objParm);
            }
            else
            {
                SQL += strSortCol;
                dt = this.GetDataTable(SQL);
            }
            dt.TableName = strTableName;
            return dt;
        }

        /// <summary>
        /// 表单(单实体) - 自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="strWhere"></param>
        /// <param name="objValue"></param>
        /// <returns></returns>
        public DataTable SelectFree(BaseDataContract objEntity, string strWhere, object objValue)
        {
            return SelectFree(objEntity, strWhere, new List<object> { objValue });
        }

        /// <summary>
        /// 表单(单实体) - 自由式
        /// </summary>
        /// <param name="objEntity"></param>
        /// <param name="strWhere"></param>
        /// <param name="lstValue"></param>
        /// <returns></returns>
        public DataTable SelectFree(BaseDataContract objEntity, string strWhere, List<object> lstValue)
        {
            if (string.IsNullOrEmpty(strWhere))
            {
                return Select(objEntity);
            }
            string strTableName = EntityTools.GetTableName(objEntity);
            string strCol = "select ";

            List<EntityAttribute> lstAttri = EntityTools.GetFieldAttribute(objEntity);
            foreach (EntityAttribute attri in lstAttri)
            {
                strCol += attri.FieldName + ", ";
            }
            string SQL = strCol.Substring(0, strCol.Length - 2) + " from " + strTableName + " where " + strWhere;

            IDataParameter[] objParm = this.CreateParm(lstValue.Count);
            int n = -1;
            foreach (object obj in lstValue)
            {
                objParm[++n].Value = obj;
            }
            DataTable dt = this.GetDataTable(SQL, objParm);
            dt.TableName = strTableName;
            return dt;
        }
        #endregion

        #endregion

        #region Exec
        /// <summary>
        /// ExecSql
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecSql(string sql)
        {
            return ExecSql(sql, new List<IDataParameter>());
        }
        /// <summary>
        /// ExecSql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="objParm"></param>
        /// <returns></returns>
        public int ExecSql(string sql, IDataParameter parm)
        {
            return ExecSql(sql, new List<IDataParameter>() { parm });
        }
        /// <summary>
        /// ExecSql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="objParm"></param>
        /// <returns></returns>
        public int ExecSql(string sql, params IDataParameter[] objParm)
        {
            if (objParm == null)
                return ExecSql(sql, new List<IDataParameter>());
            else
                return DataService().ExecSql(connStr, sql, 0, objParm);
        }
        /// <summary>
        /// ExecSql
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="lstParm"></param>
        /// <returns></returns>
        public int ExecSql(string sql, List<IDataParameter> lstParm)
        {
            return DataService().ExecSql(connStr, sql, 0, ((lstParm == null || lstParm.Count == 0) ? null : lstParm.ToArray()));
        }
        #endregion

        #region Commit.MTS

        #region 事务类型
        /// <summary>
        /// 事务类型
        /// </summary>
        public TransactionScope TransactionScope
        {
            get
            {
                TransactionOptions transOption = new TransactionOptions();
                // 隔离级别-事务期间不允许脏读
                transOption.IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted;
                // Timeout-10分钟
                transOption.Timeout = new TimeSpan(0, 10, 0);
                return new TransactionScope(TransactionScopeOption.Required, transOption);
            }
        }
        #endregion

        #region 提交事务.单条
        /// <summary>
        /// 提交事务.单条
        /// </summary>
        /// <param name="dacParm"></param>
        /// <returns></returns>
        public int Commit(DacParm dacParm)
        {
            return Commit(new List<DacParm>() { dacParm });
        }
        #endregion

        #region 提交事务.批量
        /// <summary>
        /// 提交事务.批量
        /// </summary>
        /// <param name="lstCommitParam"></param>
        /// <returns></returns>
        public int Commit(List<DacParm> lstDacParm)
        {
            int intAffectedRows = 0;
            int intAffectedRowCount = 0;

            if (lstDacParm == null || lstDacParm.Count == 0)
            {
                return -1;
            }

            #region 分组
            string str = string.Empty;
            Dictionary<string, List<DacParm>> dicParams = new Dictionary<string, List<DacParm>>();
            Dictionary<string, EnumDBMS> dicDBMS = new Dictionary<string, EnumDBMS>();
            foreach (DacParm param in lstDacParm)
            {
                str = param.connStr;
                if (dicParams.ContainsKey(str))
                {
                    dicParams[str].Add(param);
                }
                else
                {
                    dicParams.Add(str, new List<DacParm>() { param });
                    dicDBMS.Add(str, param.enumDBMS);
                }
            }
            #endregion

            int n = 1;
            string strConn = string.Empty;
            List<string> lstConnKey = new List<string>();
            lstConnKey.AddRange(dicParams.Keys);
            using (TransactionScope ts = this.TransactionScope)
            {
                try
                {
                    foreach (string conn in lstConnKey)
                    {
                        #region dac
                        IDataService sqlSvc = DataService(dicDBMS[conn]);
                        strConn = dicParams[conn][0].connStr;
                        try
                        {
                            foreach (DacParm param in dicParams[conn])
                            {
                                if (param.execType == EnumExecType.ExecSql)
                                {
                                    if (param.objParams != null && param.objParams.Length > 0)
                                    {
                                        intAffectedRows = sqlSvc.ExecSql(strConn, param.sqlName, n, param.objParams);
                                    }
                                    else
                                    {
                                        intAffectedRows = sqlSvc.ExecSql(strConn, param.sqlName);
                                    }

                                    // 数据库同步
                                    //if (param.isSync && param.lstDBModule.Count > 0)
                                    //{
                                    //    lstConnStr = null;
                                    //    lstConnStr = new List<string>() { param.connStr };
                                    //    foreach (EnumSystemModule enumSysm in param.lstDBModule)
                                    //    {
                                    //        strConn = GetDBConnectionString(enumSysm);
                                    //        if (lstConnStr.IndexOf(strConn) < 0)
                                    //        {
                                    //            lstConnStr.Add(strConn);
                                    //            intAffectedRows = param.dataService.ExecSQL(strConn, param.sqlName);
                                    //        }
                                    //    }
                                    //}                                        
                                }
                                else if (param.execType == EnumExecType.ExecSqlForBatch)
                                {
                                    if (dicParams[conn][0].enumDBMS == EnumDBMS.Oracle)
                                        intAffectedRows = sqlSvc.ExecSqlForBatch(strConn, param.sqlName, ref n, param.objValuesArr, param.objDbTypes);
                                    else
                                        intAffectedRows = sqlSvc.ExecSqlForBatch(strConn, dicParams[conn][0].execType, param.sqlName, ref n, param.objValuesArr, param.objDbTypes);

                                    // 数据同步
                                    //if (param.isSync && param.lstDBModule.Count > 0)
                                    //{
                                    //    lstConnStr = null;
                                    //    lstConnStr = new List<string>() { param.connStr };
                                    //    foreach (EnumSystemModule enumSysm in param.lstDBModule)
                                    //    {
                                    //        strConn = GetDBConnectionString(enumSysm);
                                    //        if (lstConnStr.IndexOf(strConn) < 0)
                                    //        {
                                    //            lstConnStr.Add(strConn);
                                    //            intAffectedRows = param.dataService.ExecSQLForBatch(strConn, param.sqlName, ref n, param.objValuesArr, param.objDbTypes);
                                    //        }
                                    //    }
                                    //}
                                }
                                else if (param.execType == EnumExecType.ExecSqlForBatchSimpleInsert)
                                {
                                    intAffectedRows = param.dataService.ExecSqlForBatchSimpleInsert(param.connStr, param.sqlName, n, param.objValuesArr, param.objDbTypes);

                                    // 数据同步
                                    //if (param.isSync && param.lstDBModule.Count > 0)
                                    //{
                                    //    lstConnStr = null;
                                    //    lstConnStr = new List<string>() { param.connStr };
                                    //    foreach (EnumSystemModule enumSysm in param.lstDBModule)
                                    //    {
                                    //        strConn = GetDBConnectionString(enumSysm);
                                    //        if (lstConnStr.IndexOf(strConn) < 0)
                                    //        {
                                    //            lstConnStr.Add(strConn);
                                    //            intAffectedRows = param.dataService.ExecSQLForBatchSimpleInsert(strConn, param.sqlName, n, param.objValuesArr, param.objDbTypes);
                                    //        }
                                    //    }
                                    //}
                                }
                                else if (param.execType == EnumExecType.ExecProc)
                                {
                                    if (param.objParams != null && param.objParams.Length > 0)
                                    {
                                        intAffectedRows = sqlSvc.ExecProc(strConn, param.sqlName, param.objParams);
                                    }
                                    else
                                    {
                                        intAffectedRows = sqlSvc.ExecProc(strConn, param.sqlName);
                                    }
                                }

                                if ((param.isOnlyRow && intAffectedRows == 0) || (param.isMustUpdate && intAffectedRows == 0))
                                {
                                    intAffectedRows = -2;
                                    ExceptionLog.OutPutException("当前记录可能被其他用户删除\n" + param.sqlName);
                                }
                                else if (param.isOnlyRow && intAffectedRows > 1)
                                {
                                    intAffectedRows = -3;
                                    ExceptionLog.OutPutException("当前记录可能有重复,或主关键字不符" + param.sqlName);
                                }
                                if (param.sqlName.ToLower().IndexOf("drop table") >= 0 || param.sqlName.ToLower().IndexOf("create table") >= 0)
                                {
                                    intAffectedRows = 1;
                                }
                                intAffectedRowCount += intAffectedRows;
                                n++;
                            }
                        }
                        catch (Exception e)
                        {
                            ExceptionLog.OutPutException(e.Message);
                            intAffectedRowCount = -1;
                        }
                        finally
                        {
                        }
                        #endregion
                    }
                    if (intAffectedRowCount > 0)
                    {
                        ts.Complete();
                    }
                }
                catch (Exception e)
                {
                    ExceptionLog.OutPutException(e);
                }
            }
            return intAffectedRowCount;
        }
        #endregion

        #endregion

        #region 客户信息
        /// <summary>
        /// 客户信息
        /// </summary>
        /// <returns></returns>
        public EntityHospital HospitalInfo()
        {
            List<EntityHospital> data = EntityTools.ConvertToEntityList<EntityHospital>(this.Select(new EntityHospital()));
            if (data != null && data.Count > 0)
                return data[0];
            else
                return null;
        }
        #endregion

        #region Dispose
        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {

        }
        #endregion
    }
    #endregion
}
