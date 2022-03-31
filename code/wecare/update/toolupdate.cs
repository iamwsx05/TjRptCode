using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace weCare
{
    public class ToolUpdate
    {
        public bool DownLoad()
        {
            if (Tool.Int(Tool.GetUpdateXmlValue("isStartUsing")) != 1)
            {
                // 不启用返回true
                return true;
            }

            bool blnRet = false;
            //文件路径
            string strCurrDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //Directory.GetCurrentDirectory();
            string strTempDir = strCurrDir + "\\Temp_Update";
            //WCF代理
            ProxyUpdate proxy = new ProxyUpdate();
            try
            {
                frmInit frmStart = new frmInit();
                frmStart.Show();
                Application.DoEvents();

                #region 比较版本号
                decimal decLocalVersion = 0;
                string strLocalVersion = Tool.GetUpdateXmlValue("version");
                decimal.TryParse(strLocalVersion.Replace(".", ""), out decLocalVersion);

                decimal decSvcVersion = 0;
                string strSvcVersion = string.Empty;

                proxy.Service.GetVersion(ref strSvcVersion);
                decimal.TryParse(strSvcVersion.Replace(".", ""), out decSvcVersion);

                bool blnAllDown = false;
                int intDiff = (int)(decSvcVersion - decLocalVersion);

                if (intDiff <= 0)
                {
                    frmStart.Dispose();
                    frmStart = null;
                    return true;
                }
                if (intDiff == 1)
                    blnAllDown = false;
                else
                    blnAllDown = true;
                #endregion

                #region 更新列表
                List<string> lstFile = proxy.Service.GetUpdateFileList(blnAllDown);
                if (lstFile == null || lstFile.Count == 0)
                {
                    frmStart.Dispose();
                    frmStart = null;
                    return true;
                }

                int intPos = 0;
                int intTotal = lstFile.Count();
                UpdateFileInfo objFileInfo = null;
                List<UpdateFileInfo> lstFileInfo = new List<UpdateFileInfo>();
                foreach (string str in lstFile)
                {
                    objFileInfo = new UpdateFileInfo();

                    intPos = str.LastIndexOf("\\");
                    if (intPos >= 0)
                    {
                        objFileInfo.SubDirectory = str.Substring(0, intPos);
                        objFileInfo.FileName = str.Substring(intPos + 1);
                    }
                    else
                    {
                        objFileInfo.SubDirectory = string.Empty;
                        objFileInfo.FileName = str;
                    }
                    lstFileInfo.Add(objFileInfo);
                }

                frmStart.Dispose();
                frmStart = null;

                frmUpdate frm = new frmUpdate();
                frm.progressBarControl.Properties.Maximum = intTotal;
                frm.lblFile.Text = "准备下载文件...";
                frm.Show();
                Application.DoEvents();

                try
                {
                    if (Directory.Exists(strTempDir))
                    {
                        Directory.Delete(strTempDir, true);
                    }
                    Directory.CreateDirectory(strTempDir);

                    byte[] bytFile = null;
                    FileStream fileStream = null;
                    for (int i = 0; i < lstFileInfo.Count; i++)
                    {
                        objFileInfo = lstFileInfo[i];
                        frm.lblFile.Text = "更新进度(" + Convert.ToString(i + 1) + "/" + intTotal.ToString() + ") : " + objFileInfo.FileName;
                        Application.DoEvents();

                        if (objFileInfo.SubDirectory != string.Empty)
                        {
                            if (!Directory.Exists(strTempDir + "\\" + objFileInfo.SubDirectory))
                            {
                                Directory.CreateDirectory(strTempDir + "\\" + objFileInfo.SubDirectory);
                            }
                        }
                        try
                        {
                            bytFile = proxy.Service.DownLoadFile(objFileInfo.SubDirectory + "\\" + objFileInfo.FileName);
                            if (bytFile != null)
                            {
                                objFileInfo.FileValue = bytFile;
                                objFileInfo.TempFilePath = strTempDir + "\\" + objFileInfo.SubDirectory + "\\" + objFileInfo.FileName;
                                objFileInfo.WorkFilePath = strCurrDir + "\\" + objFileInfo.SubDirectory + "\\" + objFileInfo.FileName;
                                fileStream = new FileStream(objFileInfo.TempFilePath, FileMode.CreateNew);
                                fileStream.Write(bytFile, 0, bytFile.Length);
                                fileStream.Close();
                                fileStream.Dispose();
                                fileStream = null;
                            }
                            else
                            {
                                MessageBox.Show("下载文件: " + objFileInfo.FileName + " 失败。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("下载文件: " + objFileInfo.FileName + " 失败。\r\n\r\n" + e.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        frm.progressBarControl.EditValue = i + 1;
                        Application.DoEvents();
                    }

                    #region 更新本地文件
                    frm.lblFile.Text = "下载完毕，更新本地文件请稍候...";
                    Application.DoEvents();

                    foreach (UpdateFileInfo objFile in lstFileInfo)
                    {
                        if (objFile.SubDirectory != string.Empty)
                        {
                            if (!Directory.Exists(strCurrDir + "\\" + objFile.SubDirectory))
                            {
                                Directory.CreateDirectory(strCurrDir + "\\" + objFile.SubDirectory);
                            }
                        }
                        if (File.Exists(objFile.WorkFilePath))
                        {
                            if (blnAllDown)
                            {
                                if (VerifyMd5Hash(GetMd5Hash(GetFile(objFile.WorkFilePath)), GetMd5Hash(objFile.FileValue)))
                                {
                                    continue;
                                }
                            }

                            File.SetAttributes(objFile.WorkFilePath, FileAttributes.Normal);
                            File.Delete(objFile.WorkFilePath);
                        }
                        File.Move(objFile.TempFilePath, objFile.WorkFilePath);
                    }
                    // 更新本地版本号
                    UpdateVersion(strSvcVersion);
                    #endregion

                    #region 注册文件 Ver:1.0
                    if (decLocalVersion == 10)
                    {
                        string strBatFile = Application.StartupPath + "\\RegOcx.bat";
                        if (File.Exists(strBatFile))
                        {
                            frm.lblFile.Text = "注册控件，请稍候...";
                            Application.DoEvents();

                            Process p = new Process();
                            p.StartInfo.FileName = strBatFile;
                            p.Start();
                            if (p.HasExited)
                            {
                                p.Kill();
                            }
                        }
                    }
                    #endregion

                    #region 释放
                    frm.Hide();
                    frm.Dispose();
                    frm = null;
                    Application.DoEvents();
                    #endregion

                    blnRet = true;
                }
                catch (Exception objEx)
                {
                    MessageBox.Show(objEx.Message);
                    frm.Hide();
                    frm.Dispose();
                    frm = null;
                    return false;
                }
                #endregion
            }
            finally
            {
                proxy = null;
                if (Directory.Exists(strTempDir))
                {
                    Directory.Delete(strTempDir, true);
                }
            }
            return blnRet;
        }

        /// <summary>
        /// 文件信息
        /// </summary>
        private class UpdateFileInfo
        {
            /// <summary>
            /// 文件名
            /// </summary>
            public string FileName { get; set; }
            /// <summary>
            /// 文件字节内容
            /// </summary>
            public byte[] FileValue { get; set; }
            /// <summary>
            /// 子目录
            /// </summary>
            public string SubDirectory { get; set; }
            /// <summary>
            /// 临时文件路径
            /// </summary>
            public string TempFilePath { get; set; }
            /// <summary>
            /// 工作文件路径
            /// </summary>
            public string WorkFilePath { get; set; }
        }

        #region 更新版本号
        /// <summary>
        /// 更新版本号
        /// </summary>
        /// <param name="version"></param>
        private void UpdateVersion(string version)
        {
            string strFile = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\update.client.xml";
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(strFile);
            System.Xml.XmlElement element = doc["Main"]["version"];
            if (element != null)
            {
                element.Attributes["value"].Value = version;
                doc.Save(strFile);
            }

            doc = null;
            element = null;
        }
        #endregion

        #region 获取文件BYTE
        /// <summary>
        /// 获取文件BYTE
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private byte[] GetFile(string file)
        {
            byte[] bytFile = null;
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
        #endregion

        #region 比较文件

        /// <summary>
        /// 获取HASH值
        /// </summary>
        /// <param name="inputByte"></param>
        /// <returns></returns>
        private string GetMd5Hash(byte[] inputByte)
        {
            MD5 md5Hasher = MD5.Create();

            byte[] data = md5Hasher.ComputeHash(inputByte);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            md5Hasher = null;

            return sb.ToString();
        }

        /// <summary>
        /// 验证HASH值
        /// </summary>
        /// <param name="p_strHas1"></param>
        /// <param name="p_strHas2"></param>
        /// <returns></returns>
        private bool VerifyMd5Hash(string p_strHas1, string p_strHas2)
        {
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (comparer.Compare(p_strHas1, p_strHas2) == 0)
                return true;
            else
                return false;
        }
        #endregion        
    }
}
