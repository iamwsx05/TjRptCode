using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Console.Svc
{
    /// <summary>
    /// SvcUpdate
    /// </summary>
    public class SvcUpdate : Console.Itf.ItfUpdate
    {
        /// <summary>
        /// 获取版本号
        /// </summary>
        /// <param name="version"></param>
        public void GetVersion(ref string version)
        {
            this.Version(1, ref version);
        }

        /// <summary>
        /// 更新版本号
        /// </summary>
        /// <param name="version"></param>
        public void UpdateVersion(string version)
        {
            this.Version(2, ref version);
        }

        private System.Xml.XmlDocument GetDoc()
        {
            string strFile = string.Empty;
            try
            {
                strFile = System.AppDomain.CurrentDomain.BaseDirectory + @"\update.svc.xml";
            }
            catch
            {
                strFile = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\update.svc.xml";
            }
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(strFile);

            return doc;
        }

        /// <summary>
        /// 版本号
        /// </summary>
        /// <param name="intType">1 获取；2 修改</param>
        /// <param name="version"></param>
        private void Version(int intType, ref string version)
        {
            System.Xml.XmlDocument doc = this.GetDoc();
            System.Xml.XmlElement element = doc["Main"]["Version"];
            if (element != null)
            {
                if (intType == 1)
                {
                    version = element.Attributes["value"].Value.Trim();
                }
                else if (intType == 2)
                {
                    element.Attributes["value"].Value = version;
                }
            }
            doc = null;
            element = null;
        }

        /// <summary>
        /// 获取更新文件列表
        /// </summary>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public List<string> GetUpdateFileList(bool isAll)
        {
            List<string> lstFiles = new List<string>();
            System.Xml.XmlDocument doc = this.GetDoc();
            System.Xml.XmlNodeList nodelist = doc["Main"]["FileList"].GetElementsByTagName("File");
            if (nodelist == null || nodelist.Count == 0)
            {
                return lstFiles;
            }

            System.Xml.XmlNode node = null;
            for (int i = 0; i < nodelist.Count; i++)
            {
                node = nodelist.Item(i);
                if (isAll)
                {
                    lstFiles.Add(node.Attributes["name"].Value.Trim());
                }
                else
                {
                    if (node.Attributes["status"].Value.Trim() == "1")
                    {
                        lstFiles.Add(node.Attributes["name"].Value.Trim());
                    }
                }
            }
            doc = null;
            node = null;

            return lstFiles;
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        public byte[] DownLoadFile(string file)
        {
            System.Xml.XmlDocument doc = this.GetDoc();
            System.Xml.XmlElement element = doc["Main"]["FilePath"];
            string strPath = element.Attributes["value"].Value.Trim();
            //if (!strPath.EndsWith("\\"))
            //{
            //    strPath += "\\";
            //}
            doc = null;
            element = null;

            byte[] bytFile = null;
            file = strPath + file;
            if (File.Exists(file))
            {
                FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
                int intLen = (int)stream.Length;
                bytFile = new byte[intLen];
                stream.Read(bytFile, 0, intLen);
                stream.Close();
                stream.Dispose();
            }
            return bytFile;
        }

        #region Verify
        /// <summary>
        /// Verify
        /// </summary>
        /// <returns></returns>
        public bool Verify()
        { return true; }
        #endregion

        #region IDispose
        /// <summary>
        /// IDispose
        /// </summary>
        public void Dispose()
        { GC.SuppressFinalize(this); }
        #endregion
    }
}
