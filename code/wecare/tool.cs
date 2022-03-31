using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace weCare
{
    public class Tool
    {
        #region 获取UPDATE.XML信息
        /// <summary>
        /// 获取UPDATE.XML信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetUpdateXmlValue(string key)
        {
            string strValue = string.Empty;
            string strFile = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\update.client.xml";

            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(strFile);
            System.Xml.XmlElement element = doc["Main"][key];
            if (element != null)
            {
                strValue = element.Attributes["value"].Value.Trim();
            }

            doc = null;
            element = null;
            return strValue;
        }
        #endregion

        #region 从本地配置文件读取参数值

        /// <summary>
        /// 本地配置文件
        /// </summary>
        private static string LocalSettingFile = System.AppDomain.CurrentDomain.BaseDirectory + @"\app.xml";

        /// <summary>
        /// 从本地配置文件读取参数值
        /// </summary>
        /// <param name="p_strNode"></param>
        /// <param name="p_strKey"></param>
        /// <returns></returns>
        public static string ReadLocalSettingValue(string p_strNode, string p_strKey)
        {
            string strValue = string.Empty;
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            try
            {
                System.Xml.XmlElement element = null;
                doc.Load(LocalSettingFile);

                int n = -1;
                string[] strNodeArr = p_strNode.Split('|');
                switch (strNodeArr.Length)
                {
                    case 1:
                        element = doc[strNodeArr[++n]];
                        break;
                    case 2:
                        element = doc[strNodeArr[++n]][strNodeArr[++n]];
                        break;
                    case 3:
                        element = doc[strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]];
                        break;
                    case 4:
                        element = doc[strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]];
                        break;
                    case 5:
                        element = doc[strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]];
                        break;
                    case 6:
                        element = doc[strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]];
                        break;
                    case 7:
                        element = doc[strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]];
                        break;
                    case 8:
                        element = doc[strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]];
                        break;
                    case 9:
                        element = doc[strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]];
                        break;
                    case 10:
                        element = doc[strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]][strNodeArr[++n]];
                        break;
                    default:
                        return string.Empty;
                }

                if (element != null)
                {
                    strValue = element.Attributes[p_strKey].Value.Trim();
                }
            }
            catch
            {
            }
            finally
            {
                doc = null;
            }
            return strValue;
        }
        #endregion

        #region Int
        /// <summary>
        /// Int
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int Int(string str)
        {
            int i = 0;
            int.TryParse(str, out i);
            return i;
        }
        #endregion

    }
}
