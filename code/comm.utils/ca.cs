using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using weCare.Core.Utils;
using weCare.Core.Entity;
using Common.Entity;
//using SecuInter;

namespace Common.Utils
{
    /// <summary>
    /// 数字认证
    /// </summary>
    public class CA
    {
        #region 获取客户端证书
        /// <summary>
        /// 获取客户端证书
        /// </summary>
        /// <param name="p_objStoreType"></param>
        /// <param name="p_blnIsSignCert"></param>
        /// <returns></returns>
        //private static X509Certificate GetCACert(SECUINTER_STORE_NAME p_objStoreType, bool p_blnIsSignCert)
        //{
        //    Utilities oUtil;
        //    Store MyStore;
        //    try
        //    {
        //        oUtil = new Utilities();
        //        MyStore = new Store();
        //        MyStore.Open(SECUINTER_STORE_LOCATION.SECUINTER_CURRENT_USER_STORE, p_objStoreType);
        //        X509Certificates certs = (X509Certificates)MyStore.X509Certificates;
        //        MyStore.Close();
        //        MyStore = null;

        //        X509Certificates MyCerts = new X509Certificates();
        //        for (int i = 0; i < certs.Count; i++)
        //        {
        //            X509Certificate cert = (X509Certificate)certs[i];
        //            string issuer = cert.get_Issuer(SECUINTER_NAMESTRING_TYPE.SECUINTER_X500_NAMESTRING);

        //            if (issuer.IndexOf("CN=NETCA") < 0)
        //            {
        //                continue;
        //            }
        //            else
        //            {
        //                long iKeyUsage = cert.KeyUsage;
        //                if (iKeyUsage == -1)
        //                {
        //                    MyCerts.Add(cert);
        //                }
        //                else
        //                {
        //                    if (p_blnIsSignCert == true)
        //                    {
        //                        if (iKeyUsage % 2 == 1 && iKeyUsage % 4 >= 2)
        //                        {
        //                            MyCerts.Add(cert);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        if (iKeyUsage % 8 >= 4)
        //                        {
        //                            MyCerts.Add(cert);
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        if (MyCerts.Count > 0)
        //        {
        //            return (X509Certificate)MyCerts.SelectCertificate();
        //        }
        //        return null;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}
        #endregion

        #region 获取微缩图(母印)
        /// <summary>
        /// 获取微缩图(母印)
        /// </summary>
        /// <returns></returns>
        public static string GetKeyID()
        {
            return string.Empty;
            //Utilities objUtil = new Utilities();
            //X509Certificate objCert = clsCA.s_objGetCACert(SECUINTER_STORE_NAME.SECUINTER_MY_STORE, true);
            //if (objCert == null)
            //{
            //    clsDialog.Msg("请选择电子证书(或者请插入KEY盘)!");
            //    return string.Empty;
            //}

            //string strID = objUtil.BinaryToHex(objCert.get_Thumbprint(SECUINTER_HASH_ALGORITHM.SECUINTER_SHA1_ALGORITHM));
            //objUtil = null;
            //objCert = null;
            //return strID;
        }
        #endregion

        #region 检查母印
        /// <summary>
        /// 检查母印
        /// </summary>
        /// <param name="p_strDBKeyID"></param>
        /// <returns></returns>
        private static int VerifyCert(string p_strDBKeyID)
        {
            //string strKeyID = clsCA.s_strGetKeyID();

            //if (string.IsNullOrEmpty(strKeyID))
            //    return -1;

            //if (strKeyID != p_strDBKeyID)
            //    return -2;

            return 0;
        }
        #endregion

        #region 身份认证
        /// <summary>
        /// 身份认证
        /// </summary>
        /// <param name="p_strDBKeyID"></param>
        /// <returns></returns>
        public static bool IDVerify(string p_strDBKeyID)
        {
            return true;
            //int i = s_intVerifyCert(p_strDBKeyID);

            //if (i == -2) clsDialog.Msg("当前用户电子身份与KEY不符。");

            //return (i == 0);
        }
        #endregion

        #region 签名判断
        /// <summary>
        /// 签名判断
        /// </summary>
        /// <param name="p_strDBKeyID"></param>
        /// <returns></returns>
        public static bool SignVerify(string p_strDBKeyID)
        {
            return true;
            //int i = s_intVerifyCert(p_strDBKeyID);

            //if (i == -2) clsDialog.Msg("当前签名用户与KEY不符，签名失败。");

            //return (i == 0);
        }
        #endregion

        #region 获取签名内容(密文)
        /// <summary>
        /// 获取签名内容(密文)
        /// </summary>
        /// <param name="p_strOrgContent"></param>
        /// <param name="p_strDBKeyID"></param>
        /// <returns></returns>
        public static string GetSignContent(string p_strOrgContent, string p_strDBKeyID)
        {
            return string.Empty;
            //X509Certificate objCert = clsCA.s_objGetCACert(SECUINTER_STORE_NAME.SECUINTER_MY_STORE, true);
            //if (objCert == null)
            //{
            //    clsDialog.Msg("请选择电子证书(或者请插入KEY盘)!");
            //    return null;
            //}

            //if (clsCA.s_strGetKeyID() != p_strDBKeyID)
            //{
            //    clsDialog.Msg("当前签名用户与KEY不一致，签名失败。");
            //    return null;
            //}

            //Signer objSigner;
            //SignedData objSignedData;
            //try
            //{
            //    objSigner = new Signer();
            //    objSignedData = new SignedData();

            //    objSigner.Certificate = objCert;
            //    objSigner.HashAlgorithm = SECUINTER_HASH_ALGORITHM.SECUINTER_SHA1_ALGORITHM;
            //    objSigner.UseSigningCertificateAttribute = false;
            //    objSigner.UseSigningTime = false;
            //    objSignedData.Content = p_strOrgContent;
            //    objSignedData.Detached = true; // IsNotSource;

            //    string strDeContent = (string)objSignedData.Sign(objSigner, SECUINTER_CMS_ENCODE_TYPE.SECUINTER_CMS_ENCODE_BASE64);

            //    objCert = null;
            //    objSignedData = null;
            //    objSigner = null;

            //    return strDeContent;
            //}
            //catch (Exception e)
            //{
            //    objCert = null;
            //    objSignedData = null;
            //    objSigner = null;
            //    return null;
            //}
        }
        #endregion

        #region 内容验证
        /// <summary>
        /// 内容验证
        /// </summary>
        /// <param name="p_strOrgContent"></param>
        /// <param name="p_strSignContent"></param>
        /// <returns></returns>
        public static bool ContentVerify(string p_strOrgContent, string p_strSignContent)
        {
            //SignedData objSignedData;

            //try
            //{
            //    objSignedData = new SignedData();
            //    objSignedData.Content = p_strOrgContent;
            //    objSignedData.Detached = true;
            //    if (!objSignedData.Verify(p_strSignContent, 0))
            //    {
            //        return false;
            //    }
            //    objSignedData = null;
            //}
            //catch (Exception e)
            //{
            //    clsDialog.Msg("验证内容失败，详细原因:\r\n" + e.Message);
            //    return false;
            //}
            return true;
        }
        #endregion


    }
}
