using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace weCare.Core.Utils
{
    /// <summary>
    /// FTP.Class
    /// </summary>
    public class FTP
    {
        #region 默认读取当前目录下FTP.Setting配置信息
        /// <summary>
        /// 默认读取当前目录下FTP.Setting配置信息
        /// </summary>
        /// <param name="p_strUri"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPwd"></param>
        private static void GetFtpCredential(ref string p_strUri, ref string p_strUserID, ref string p_strPwd)
        {
            string strFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\ftpconfig.xml";

            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(strFile);

            p_strUri = string.Empty;
            p_strUserID = string.Empty;
            p_strPwd = string.Empty;
            string strPort = string.Empty;

            System.Xml.XmlElement element = null;
            element = doc["main"]["server"];
            p_strUri = element.Attributes["value"].Value.Trim();
            element = doc["main"]["userid"];
            p_strUserID = element.Attributes["value"].Value.Trim();
            element = doc["main"]["password"];
            p_strPwd = element.Attributes["value"].Value.Trim();
            element = doc["main"]["port"];
            strPort = element.Attributes["value"].Value.Trim();

            if (!string.IsNullOrEmpty(strPort))
            {
                p_strUri += ":" + strPort;
            }
        }
        #endregion

        #region 生成FTP客户端对象
        /// <summary>
        /// 生成FTP客户端对象
        /// </summary>
        /// <param name="p_strUri"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPwd"></param>
        /// <param name="p_strFtpMethod"></param>
        /// <returns></returns>
        private static FtpWebRequest CreateFtp(string p_strUri, string p_strUserID, string p_strPwd, string p_strFtpMethod)
        {
            FtpWebRequest FtpReq = (FtpWebRequest)FtpWebRequest.Create(new Uri(p_strUri));
            FtpReq.Credentials = new NetworkCredential(p_strUserID, p_strPwd);
            FtpReq.KeepAlive = false;
            FtpReq.Method = p_strFtpMethod;
            FtpReq.UseBinary = true;

            return FtpReq;
        }
        #endregion

        #region 上传
        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="p_strFileName"></param>
        /// <returns></returns>
        public static bool UpLoad(string p_strFileName)
        {
            string strUri = string.Empty;
            string strUserID = string.Empty;
            string strPwd = string.Empty;
            GetFtpCredential(ref strUri, ref strUserID, ref strPwd);
            return UpLoad(strUri, strUserID, strPwd, string.Empty, p_strFileName);
        }

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strFileName"></param>
        public static bool UpLoad(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFileName)
        {
            return UpLoad(p_strFtpServerIP, p_strUserID, p_strPassWord, string.Empty, p_strFileName);
        }

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strFtpSubDirectory"></param>
        /// <param name="p_strFileName"></param>
        public static bool UpLoad(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFtpSubDirectory, string p_strFileName)
        {
            FileInfo fi = new FileInfo(p_strFileName);

            if (!string.IsNullOrEmpty(p_strFtpSubDirectory))
            {
                p_strFtpSubDirectory += "/";
            }

            FtpWebRequest FtpReq = CreateFtp("ftp://" + p_strFtpServerIP + "/" + p_strFtpSubDirectory + fi.Name, p_strUserID, p_strPassWord, WebRequestMethods.Ftp.UploadFile);
            FtpReq.ContentLength = fi.Length;

            int intBuffSize = 2048;
            byte[] buff = new byte[intBuffSize];

            int intContentLen = 0;
            FileStream fs = fi.OpenRead();
            Stream sr = null;
            try
            {
                sr = FtpReq.GetRequestStream();

                intContentLen = fs.Read(buff, 0, intBuffSize);
                while (intContentLen != 0)
                {
                    sr.Write(buff, 0, intContentLen);
                    intContentLen = fs.Read(buff, 0, intBuffSize);
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException("FTP上传文件失败。\r\n\r\n" + e.Message);
                return false;
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
                FtpReq = null;
            }

            return true;
        }
        #endregion

        #region 下载

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="p_strLocalDirectory"></param>
        /// <param name="p_strFileName"></param>
        /// <returns></returns>
        public static bool DownLoad(string p_strLocalDirectory, string p_strFileName)
        {
            string strUri = string.Empty;
            string strUserID = string.Empty;
            string strPwd = string.Empty;
            GetFtpCredential(ref strUri, ref strUserID, ref strPwd);
            return DownLoad(strUri, strUserID, strPwd, string.Empty, p_strLocalDirectory, p_strFileName);
        }
        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strLocalDirectory"></param>
        /// <param name="p_strFileName"></param>
        public static bool DownLoad(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strLocalDirectory, string p_strFileName)
        {
            return DownLoad(p_strFtpServerIP, p_strUserID, p_strPassWord, string.Empty, p_strLocalDirectory, p_strFileName);
        }
        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="p_strUriFile"></param>
        /// <param name="mStream"></param>
        /// <returns></returns>
        public static bool DownLoad(string p_strUriFile, ref MemoryStream mStream)
        {
            FtpWebRequest FtpReq = null;
            FtpWebResponse FtpRep = null;
            Stream sr = null;
            try
            {
                string strUri = string.Empty;
                string strUserID = string.Empty;
                string strPwd = string.Empty;
                GetFtpCredential(ref strUri, ref strUserID, ref strPwd);

                FtpReq = CreateFtp("ftp://" + p_strUriFile, strUserID, strPwd, WebRequestMethods.Ftp.DownloadFile);
                FtpRep = (FtpWebResponse)FtpReq.GetResponse();
                sr = FtpRep.GetResponseStream();

                mStream = new MemoryStream();
                int intBuffSize = 2048;
                int intReadCount = 0;
                byte[] buffer = new byte[intBuffSize];

                intReadCount = sr.Read(buffer, 0, intBuffSize);
                while (intReadCount > 0)
                {
                    mStream.Write(buffer, 0, intReadCount);
                    intReadCount = sr.Read(buffer, 0, intBuffSize);
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException("FTP下载文件失败。\r\n\r\n" + e.Message);
                return false;
            }
            finally
            {
                if (sr != null) sr.Close();
                if (FtpRep != null) FtpRep.Close();
                FtpReq = null;
            }
            return true;
        }

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strFtpSubDirectory"></param>
        /// <param name="p_strLocalDirectory"></param>
        /// <param name="p_strFileName"></param>
        public static bool DownLoad(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFtpSubDirectory, string p_strLocalDirectory, string p_strFileName)
        {
            if (!string.IsNullOrEmpty(p_strFtpSubDirectory))
            {
                p_strFtpSubDirectory += "/";
            }

            FileStream fs = null;
            FtpWebRequest FtpReq = null;
            FtpWebResponse FtpRep = null;
            Stream sr = null;
            try
            {
                fs = new FileStream(p_strLocalDirectory + "\\" + p_strFileName, FileMode.Create);

                FtpReq = CreateFtp("ftp://" + p_strFtpServerIP + "/" + p_strFtpSubDirectory + p_strFileName, p_strUserID, p_strPassWord, WebRequestMethods.Ftp.DownloadFile);
                FtpRep = (FtpWebResponse)FtpReq.GetResponse();
                sr = FtpRep.GetResponseStream();

                int intBuffSize = 2048;
                int intReadCount = 0;
                byte[] buffer = new byte[intBuffSize];

                intReadCount = sr.Read(buffer, 0, intBuffSize);
                while (intReadCount > 0)
                {
                    fs.Write(buffer, 0, intReadCount);
                    intReadCount = sr.Read(buffer, 0, intBuffSize);
                }
            }
            catch (Exception e)
            {
                ExceptionLog.OutPutException("FTP下载文件失败。\r\n\r\n" + e.Message);
                return false;
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
                if (FtpRep != null) FtpRep.Close();
                FtpReq = null;
            }

            return true;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="p_strFileName"></param>
        /// <returns></returns>
        public static bool Delete(string p_strFileName)
        {
            string strUri = string.Empty;
            string strUserID = string.Empty;
            string strPwd = string.Empty;
            GetFtpCredential(ref strUri, ref strUserID, ref strPwd);
            return Delete(strUri, strUserID, strPwd, string.Empty, p_strFileName);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strFileName"></param>
        public static bool Delete(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFileName)
        {
            return Delete(p_strFtpServerIP, p_strUserID, p_strPassWord, string.Empty, p_strFileName);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strFtpSubDirectory"></param>
        /// <param name="p_strFileName"></param>
        public static bool Delete(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFtpSubDirectory, string p_strFileName)
        {
            if (!string.IsNullOrEmpty(p_strFtpSubDirectory))
            {
                p_strFtpSubDirectory += "/";
            }

            try
            {
                FtpWebRequest FtpReq = CreateFtp("ftp://" + p_strFtpServerIP + "/" + p_strFtpSubDirectory + p_strFileName, p_strUserID, p_strPassWord, WebRequestMethods.Ftp.DeleteFile);
                FtpWebResponse FtpRep = (FtpWebResponse)FtpReq.GetResponse();
                Stream srData = FtpRep.GetResponseStream();

                StreamReader sr = new StreamReader(srData);
                string strResult = sr.ReadToEnd();
                sr.Close();
                srData.Close();
                FtpRep.Close();
                FtpReq = null;
            }
            catch (Exception e)
            {
                //clsDialog.Msg("FTP文件删除失败。\r\n\r\n" + e.Message, System.Windows.Forms.MessageBoxIcon.Information);
                ExceptionLog.OutPutException("FTP文件删除失败。\r\n\r\n" + e.Message);
                return false;
            }
            return true;
        }
        #endregion

        #region 获取文件大小
        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="p_strFileName"></param>
        /// <returns></returns>
        public static long GetFileSize(string p_strFileName)
        {
            string strUri = string.Empty;
            string strUserID = string.Empty;
            string strPwd = string.Empty;
            GetFtpCredential(ref strUri, ref strUserID, ref strPwd);
            return GetFileSize(strUri, strUserID, strPwd, string.Empty, p_strFileName);
        }
        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strFileName"></param>
        /// <returns></returns>
        public static long GetFileSize(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFileName)
        {
            return GetFileSize(p_strFtpServerIP, p_strUserID, p_strPassWord, string.Empty, p_strFileName);
        }

        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strFtpSubDirectory"></param>
        /// <param name="p_strFileName"></param>
        /// <returns></returns>
        public static long GetFileSize(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFtpSubDirectory, string p_strFileName)
        {
            long lngFileSize = -1;
            if (!string.IsNullOrEmpty(p_strFtpSubDirectory))
            {
                p_strFtpSubDirectory += "/";
            }

            try
            {
                FtpWebRequest FtpReq = CreateFtp("ftp://" + p_strFtpServerIP + "/" + p_strFtpSubDirectory + p_strFileName, p_strUserID, p_strPassWord, WebRequestMethods.Ftp.GetFileSize);
                FtpWebResponse FtpRep = (FtpWebResponse)FtpReq.GetResponse();
                Stream sr = FtpRep.GetResponseStream();

                lngFileSize = FtpRep.ContentLength;

                sr.Close();
                FtpRep.Close();
                FtpReq = null;
            }
            catch (Exception e)
            {
                lngFileSize = -1;
                //clsDialog.Msg("FTP读取文件大小失败。\r\n\r\n" + e.Message, System.Windows.Forms.MessageBoxIcon.Information);
                ExceptionLog.OutPutException("FTP读取文件大小失败。\r\n\r\n" + e.Message);
            }
            return lngFileSize;
        }
        #endregion

        #region 重命名
        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="p_strOldFileName"></param>
        /// <param name="p_strNewFileName"></param>
        /// <returns></returns>
        public static bool ReName(string p_strOldFileName, string p_strNewFileName)
        {
            string strUri = string.Empty;
            string strUserID = string.Empty;
            string strPwd = string.Empty;
            GetFtpCredential(ref strUri, ref strUserID, ref strPwd);
            return ReName(strUri, strUserID, strPwd, string.Empty, p_strOldFileName, p_strNewFileName);
        }
        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strOldFileName"></param>
        /// <param name="p_strNewFileName"></param>
        public static bool ReName(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strOldFileName, string p_strNewFileName)
        {
            return ReName(p_strFtpServerIP, p_strUserID, p_strPassWord, string.Empty, p_strOldFileName, p_strNewFileName);
        }

        /// <summary>
        /// 重命名
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strFtpSubDirectory"></param>
        /// <param name="p_strOldFileName"></param>
        /// <param name="p_strNewFileName"></param>
        public static bool ReName(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFtpSubDirectory, string p_strOldFileName, string p_strNewFileName)
        {
            if (!string.IsNullOrEmpty(p_strFtpSubDirectory))
            {
                p_strFtpSubDirectory += "/";
            }

            try
            {
                FtpWebRequest FtpReq = CreateFtp("ftp://" + p_strFtpServerIP + "/" + p_strFtpSubDirectory + p_strOldFileName, p_strUserID, p_strPassWord, WebRequestMethods.Ftp.Rename);
                FtpReq.RenameTo = p_strNewFileName;
                FtpWebResponse FtpRep = (FtpWebResponse)FtpReq.GetResponse();
                Stream sr = FtpRep.GetResponseStream();

                sr.Close();
                FtpRep.Close();
                FtpReq = null;
            }
            catch (Exception e)
            {
                //clsDialog.Msg("FTP文件重命名失败。\r\n\r\n" + e.Message, System.Windows.Forms.MessageBoxIcon.Information);
                ExceptionLog.OutPutException("FTP文件重命名失败。\r\n\r\n" + e.Message);
                return false;
            }
            return true;
        }
        #endregion

        #region 生成目录
        /// <summary>
        /// 生成目录
        /// </summary>
        /// <param name="p_strFtpSubDirectory"></param>
        /// <returns></returns>
        public static bool MakeDir(string p_strFtpSubDirectory)
        {
            string strUri = string.Empty;
            string strUserID = string.Empty;
            string strPwd = string.Empty;
            GetFtpCredential(ref strUri, ref strUserID, ref strPwd);
            return MakeDir(strUri, strUserID, strPwd, p_strFtpSubDirectory);
        }
        /// <summary>
        /// 生成目录
        /// </summary>
        public static bool MakeDir(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFtpSubDirectory)
        {
            try
            {
                string[] strDirArr = p_strFtpSubDirectory.Split('/');
                if (strDirArr != null && strDirArr.Length > 0)
                {
                    for (int i = 0; i < strDirArr.Length; i++)
                    {
                        if (string.IsNullOrEmpty(strDirArr[i])) return false;
                        FtpWebRequest FtpReq = CreateFtp("ftp://" + p_strFtpServerIP + "/" + GetUpLevelDir(strDirArr, i + 1), p_strUserID, p_strPassWord, WebRequestMethods.Ftp.MakeDirectory);
                        FtpWebResponse FtpRep = (FtpWebResponse)FtpReq.GetResponse();
                        Stream sr = FtpRep.GetResponseStream();

                        sr.Close();
                        FtpRep.Close();
                        FtpReq = null;
                    }
                }
            }
            catch (Exception e)
            {
                //clsDialog.Msg("FTP生成目录失败。\r\n\r\n" + e.Message, System.Windows.Forms.MessageBoxIcon.Information);
                ExceptionLog.OutPutException("FTP生成目录失败。\r\n\r\n" + e.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取上层目录
        /// </summary>
        /// <param name="p_strDirArr"></param>
        /// <param name="p_intLevel"></param>
        private static string GetUpLevelDir(string[] p_strDirArr, int p_intLevel)
        {
            string strUpDir = string.Empty;

            for (int i = 0; i < p_intLevel; i++)
            {
                strUpDir += p_strDirArr[i] + "/";
            }

            return strUpDir;
        }

        #endregion

        #region 获取文件列表
        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <returns></returns>
        public static string[] GetFileList()
        {
            string strUri = string.Empty;
            string strUserID = string.Empty;
            string strPwd = string.Empty;
            GetFtpCredential(ref strUri, ref strUserID, ref strPwd);
            return GetFileList(strUri, strUserID, strPwd);
        }
        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <returns></returns>
        public static string[] GetFileList(string p_strFtpServerIP, string p_strUserID, string p_strPassWord)
        {
            return GetFileList(p_strFtpServerIP, p_strUserID, p_strPassWord, string.Empty);
        }

        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="p_strFtpServerIP"></param>
        /// <param name="p_strUserID"></param>
        /// <param name="p_strPassWord"></param>
        /// <param name="p_strFtpSubDirectory"></param>
        /// <returns></returns>
        public static string[] GetFileList(string p_strFtpServerIP, string p_strUserID, string p_strPassWord, string p_strFtpSubDirectory)
        {
            string[] strFilesArr = null;
            StringBuilder sbResult = new StringBuilder();

            if (!string.IsNullOrEmpty(p_strFtpSubDirectory))
            {
                p_strFtpSubDirectory += "/";
            }

            try
            {
                FtpWebRequest FtpReq = CreateFtp("ftp://" + p_strFtpServerIP + "/" + p_strFtpSubDirectory, p_strUserID, p_strPassWord, WebRequestMethods.Ftp.ListDirectory);
                FtpWebResponse FtpRep = (FtpWebResponse)FtpReq.GetResponse();
                StreamReader sr = new StreamReader(FtpRep.GetResponseStream());
                string strLine = sr.ReadLine();
                while (strLine != null)
                {
                    sbResult.Append(strLine);
                    sbResult.Append("\n");
                    strLine = sr.ReadLine();
                }
                sbResult.Remove(sbResult.ToString().LastIndexOf('\n'), 1);
                strFilesArr = sbResult.ToString().Split('\n');

                sr.Close();
                FtpRep.Close();
                FtpReq = null;
            }
            catch (Exception e)
            {
                strFilesArr = null;
                //clsDialog.Msg("FTP获取文件列表失败。\r\n\r\n" + e.Message, System.Windows.Forms.MessageBoxIcon.Information);
                ExceptionLog.OutPutException("FTP获取文件列表失败。\r\n\r\n" + e.Message);
            }

            return strFilesArr;
        }
        #endregion
    }
}
