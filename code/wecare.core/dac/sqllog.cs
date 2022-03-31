using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Reflection;

namespace weCare.Core.Dac
{
    /// <summary>
    /// sql.log
    /// </summary>
    public class SqlLog
    {
        /// <summary>
        /// 写SQL
        /// </summary>
        /// <param name="p_strText"></param>
        /// <returns></returns>
        internal static bool OutPutSql(string _sql)
        {
            return WriteText(_sql);
        }

        #region IsWriteSqlLog
        /// <summary>
        /// IsWriteSqlLog
        /// </summary>
        /// <returns></returns>
        private static bool IsWriteSqlLog()
        {
            string strFile = string.Empty;
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
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(strFile);

            System.Xml.XmlElement eleDBLog = doc["configuration"]["IsOutputSql"];
            bool b = eleDBLog.InnerText == "1" ? true : false;
            eleDBLog = null;
            return b;
        }
        #endregion

        #region 写文本
        /// <summary>
        /// 写文本
        /// </summary>
        /// <param name="p_strFileName"></param>
        /// <param name="p_strText"></param>
        /// <returns></returns>
        private static bool WriteText(string _sql)
        {
            if (!IsWriteSqlLog()) return true;
            string strDate = DateTime.Now.ToString("yyyy-MM-dd");
            string strTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
            string strFile = System.AppDomain.CurrentDomain.BaseDirectory + @"\sql\" + strDate + ".txt";

            bool blnAllWaysNew = false;
            StreamWriter sw = null;
            try
            {
                FileInfo fi = new FileInfo(strFile);
                if (fi.Exists)
                {
                    if (fi.Length >= 2000000)
                    {
                        fi.CopyTo(System.AppDomain.CurrentDomain.BaseDirectory + @"\sql\" + strDate + "-" + DateTime.Now.ToString("HHmm") + ".txt", true);
                        sw = fi.CreateText();
                    }
                    else
                    {
                        if (blnAllWaysNew)
                        {
                            sw = fi.CreateText();
                        }
                        else
                        {
                            sw = fi.AppendText();
                        }
                    }
                }
                else
                {
                    if (!Directory.Exists(fi.DirectoryName))
                    {
                        Directory.CreateDirectory(fi.DirectoryName);
                    }
                    sw = fi.CreateText();
                }

                sw.WriteLine("-->>>>> " + strTime);
                sw.WriteLine(_sql);
                sw.WriteLine();
            }
            catch
            {
                return false;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
            return true;
        }
        #endregion

        #region 输出SQL.参数 日志
        /// <summary>
        /// 输出SQL.参数 日志
        /// </summary>
        /// <param name="_parms"></param>
        internal static void OutPutParmLog(params IDataParameter[] _parms)
        {
            if (_parms == null) return;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _parms.Length; i++)
            {
                sb.Append(Convert.ToString(i + 1));
                sb.Append(":= ");
                if (_parms[i] == null || _parms[i].Value == null)
                    sb.Append("null");
                else
                    sb.Append(_parms[i].Value.ToString());
                sb.Append("; ");
            }

            OutPutSql("values: " + sb.ToString());
        }
        #endregion
    }
}
