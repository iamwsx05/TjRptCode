using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Security;
using System.Security.Cryptography;
using System.Reflection;
using System.IO;

namespace weCare.Core.Utils
{
    /// <summary>
    /// 对称加密算法类
    /// </summary>
    public class clsSymmetricAlgorithm
    {
        /// <summary>
        /// 默认密钥
        /// </summary>
        private byte[] KEY = new byte[] {   117, 165, 207, 115, 66, 74, 56, 163, 
                                            132, 149, 3, 129, 37, 16, 85, 245, 
                                            143, 53, 168, 79, 42, 7, 119, 30, 
                                            92, 215, 178, 158, 17, 78, 115, 119 };
        /// <summary>
        /// 加密算法类型
        /// </summary>
        public enum enmSymmetricAlgorithmType { DES, RIJNDAEL };
        /// <summary>
        /// 配置信息类型
        /// </summary>
        public enum enmSecurityStringType { ORACLE, SQL_SERVER, ODBC, DB2, SYBASE, OLEDB };
        /// <summary>
        /// 生成随机密钥
        /// </summary>
        /// <returns></returns>
        public static byte[] CreateKeyBytes(enmSymmetricAlgorithmType enmType)
        {
            SymmetricAlgorithm desCrypto = null;
            switch (enmType)
            {
                case enmSymmetricAlgorithmType.DES:
                    desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
                    return desCrypto.Key;
                case enmSymmetricAlgorithmType.RIJNDAEL:
                    desCrypto = Rijndael.Create();
                    desCrypto.KeySize = 256;
                    return desCrypto.Key;
            }
            return null;
        }
        /// <summary>
        /// 生成随机密钥
        /// </summary>
        /// <returns></returns>
        public static string CreateKeyString(enmSymmetricAlgorithmType enmType)
        {
            return Convert.ToBase64String(clsSymmetricAlgorithm.CreateKeyBytes(enmType));
        }
        /// <summary>
        /// 跟默认密钥加密
        /// </summary>
        /// <param name="strText">明文</param>
        /// <returns></returns>
        public string Encrypt(string strText, enmSymmetricAlgorithmType enmType)
        {
            return this.Encrypt(strText, this.Create(enmType, false));
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="strText">明文</param>
        /// <param name="key">对称加密算法对象</param>
        /// <returns>密文</returns>
        public string Encrypt(string strText, SymmetricAlgorithm key)
        {
            if (string.IsNullOrEmpty(strText) || key == null)
                return null;

            MemoryStream ms = new MemoryStream();
            CryptoStream encStream = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(encStream);
            sw.Write(strText);
            sw.Close();
            encStream.Close();
            byte[] buffer = ms.ToArray();
            ms.Close();
            sw.Dispose();
            ms.Dispose();

            return Convert.ToBase64String(buffer);
        }
        /// <summary>
        /// 跟默认密钥解密
        /// </summary>
        /// <param name="strText">密文</param>
        /// <returns></returns>
        public string Decrypt(string strText, enmSymmetricAlgorithmType enmType)
        {
            return this.Decrypt(strText, this.Create(enmType, false));
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="strText">密文</param>
        /// <param name="key">对称加密算法对象</param>
        /// <returns>明文</returns>
        public string Decrypt(string strText, SymmetricAlgorithm key)
        {
            if (string.IsNullOrEmpty(strText) || key == null)
                return string.Empty;

            MemoryStream ms = new MemoryStream(Convert.FromBase64String(strText));
            CryptoStream encStream = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(encStream);
            string val = sr.ReadToEnd();
            sr.Close();
            encStream.Close();
            ms.Close();
            sr.Dispose();
            ms.Dispose();
            return val;
        }
        /// <summary>
        /// 获取或者设置加密/解密时使用的密钥
        /// </summary>
        public string Key
        {
            set
            {
                if (value != null)
                {
                    byte[] inKey = Convert.FromBase64String(value);
                    int intLength = inKey.Length;
                    if (intLength > 32)
                        Array.ConstrainedCopy(inKey, 0, this.KEY, 0, 32);
                    else
                        Array.ConstrainedCopy(inKey, 0, this.KEY, 0, intLength);
                }
                else
                    new Exception("密钥不可以为空!");
            }
            get
            {
                return Convert.ToBase64String(this.KEY);
            }
        }
        /// <summary>
        /// 生成加密服务对象
        /// </summary>
        /// <param name="isNew">是否生成具备新密钥的加密服务对象；true 为是；false 为否，为否时将按照默认密钥生成对象。</param>
        /// <returns></returns>
        public SymmetricAlgorithm Create(enmSymmetricAlgorithmType enmType, bool blnIsNew)
        {
            SymmetricAlgorithm desProvide = null;
            byte[] byteKey = null;
            switch (enmType)
            {
                case enmSymmetricAlgorithmType.DES:
                    desProvide = new DESCryptoServiceProvider();
                    if (blnIsNew)
                        byteKey = clsSymmetricAlgorithm.CreateKeyBytes(enmType);
                    else
                    {
                        byteKey = new byte[8];
                        Array.ConstrainedCopy(this.KEY, 0, byteKey, 0, 8);
                    }
                    desProvide.IV = byteKey;
                    desProvide.Key = byteKey;
                    break;
                case enmSymmetricAlgorithmType.RIJNDAEL:
                    desProvide = Rijndael.Create();
                    if (blnIsNew)
                    {
                        byte[] byteNewKey = clsSymmetricAlgorithm.CreateKeyBytes(enmType);
                        byteKey = new byte[16];
                        Array.ConstrainedCopy(byteNewKey, 0, byteKey, 0, 16);
                    }
                    else
                    {
                        byteKey = new byte[16];
                        Array.ConstrainedCopy(this.KEY, 0, byteKey, 0, 16);
                    }
                    desProvide.IV = byteKey;
                    desProvide.Key = this.KEY;
                    break;
            }
            return desProvide;
        }
    }
}




//using System;
//using System.IO;
//using System.Security.Cryptography;

//namespace weCare.Core.Utils
//{
//    /// <summary>
//    /// 对称加密算法类
//    /// </summary>
//    public class clsSymmetricAlgorithm
//    {
//        /// <summary>
//        /// 默认密钥
//        /// </summary>
//        private byte[] KEY = new byte[] {   117, 165, 207, 115, 66, 74, 56, 163, 
//                                            132, 149, 3, 129, 37, 16, 85, 245, 
//                                            143, 53, 168, 79, 42, 7, 119, 30, 
//                                            92, 215, 178, 158, 17, 78, 115, 119 };
//        /// <summary>
//        /// 加密算法类型
//        /// </summary>
//        public enum enmSymmetricAlgorithmType { DES, RIJNDAEL };
        
//        /// <summary>
//        /// 生成随机密钥
//        /// </summary>
//        /// <returns></returns>
//        public static byte[] CreateKeyBytes(enmSymmetricAlgorithmType enmType)
//        {
//            SymmetricAlgorithm desCrypto = null;
//            switch (enmType)
//            {
//                case enmSymmetricAlgorithmType.DES:
//                    desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
//                    return desCrypto.Key;
//                case enmSymmetricAlgorithmType.RIJNDAEL:
//                    desCrypto = Rijndael.Create();
//                    desCrypto.KeySize = 256;
//                    return desCrypto.Key;
//            }

//            return null;
//        }

//        /// <summary>
//        /// 生成随机密钥
//        /// </summary>
//        /// <returns></returns>
//        public static string CreateKeyString(enmSymmetricAlgorithmType enmType)
//        {
//            return Convert.ToBase64String(clsSymmetricAlgorithm.CreateKeyBytes(enmType));
//        }

//        /// <summary>
//        /// 跟默认密钥加密
//        /// </summary>
//        /// <param name="strText">明文</param>
//        /// <returns></returns>
//        public string Encrypt(string strText, enmSymmetricAlgorithmType enmType)
//        {
//            return this.Encrypt(strText, this.Create(enmType, false));
//        }

//        /// <summary>
//        /// 加密
//        /// </summary>
//        /// <param name="strText">明文</param>
//        /// <param name="key">对称加密算法对象</param>
//        /// <returns>密文</returns>
//        public string Encrypt(string strText, SymmetricAlgorithm key)
//        {
//            if (string.IsNullOrEmpty(strText) || key == null)
//                return null;

//            MemoryStream ms = new MemoryStream();
//            CryptoStream encStream = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);
//            StreamWriter sw = new StreamWriter(encStream);
//            sw.Write(strText);
//            sw.Close();
//            encStream.Close();
//            byte[] buffer = ms.ToArray();
//            ms.Close();
//            sw.Dispose();
//            ms.Dispose();

//            return Convert.ToBase64String(buffer);
//        }

//        /// <summary>
//        /// 跟默认密钥解密
//        /// </summary>
//        /// <param name="strText">密文</param>
//        /// <returns></returns>
//        public string Decrypt(string strText, enmSymmetricAlgorithmType enmType)
//        {
//            return this.Decrypt(strText, this.Create(enmType, false));
//        }

//        /// <summary>
//        /// 解密
//        /// </summary>
//        /// <param name="strText">密文</param>
//        /// <param name="key">对称加密算法对象</param>
//        /// <returns>明文</returns>
//        public string Decrypt(string strText, SymmetricAlgorithm key)
//        {
//            if (string.IsNullOrEmpty(strText) || key == null)
//                return string.Empty;

//            MemoryStream ms = new MemoryStream(Convert.FromBase64String(strText));
//            CryptoStream encStream = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);
//            StreamReader sr = new StreamReader(encStream);
//            string val = sr.ReadToEnd();
//            sr.Close();
//            encStream.Close();
//            ms.Close();
//            sr.Dispose();
//            ms.Dispose();

//            return val;
//        }

//        /// <summary>
//        /// 获取或者设置加密/解密时使用的密钥
//        /// </summary>
//        public string Key
//        {
//            set
//            {
//                if (value != null)
//                {
//                    byte[] inKey = Convert.FromBase64String(value);
//                    int intLength = inKey.Length;
//                    if (intLength > 32)
//                        Array.ConstrainedCopy(inKey, 0, this.KEY, 0, 32);
//                    else
//                        Array.ConstrainedCopy(inKey, 0, this.KEY, 0, intLength);
//                }
//                else
//                    new Exception("密钥不可以为空!");
//            }
//            get
//            {
//                return Convert.ToBase64String(this.KEY);
//            }
//        }

//        /// <summary>
//        /// 生成加密服务对象
//        /// </summary>
//        /// <param name="isNew">是否生成具备新密钥的加密服务对象；true 为是；false 为否，为否时将按照默认密钥生成对象。</param>
//        /// <returns></returns>
//        public SymmetricAlgorithm Create(enmSymmetricAlgorithmType enmType, bool blnIsNew)
//        {
//            SymmetricAlgorithm desProvide = null;
//            byte[] byteKey = null;
//            switch (enmType)
//            {
//                case enmSymmetricAlgorithmType.DES:
//                    desProvide = new DESCryptoServiceProvider();
//                    if (blnIsNew)
//                        byteKey = clsSymmetricAlgorithm.CreateKeyBytes(enmType);
//                    else
//                    {
//                        byteKey = new byte[8];
//                        Array.ConstrainedCopy(this.KEY, 0, byteKey, 0, 8);
//                    }
//                    desProvide.IV = byteKey;
//                    desProvide.Key = byteKey;
//                    break;
//                case enmSymmetricAlgorithmType.RIJNDAEL:
//                    desProvide = Rijndael.Create();
//                    if (blnIsNew)
//                    {
//                        byte[] byteNewKey = clsSymmetricAlgorithm.CreateKeyBytes(enmType);
//                        byteKey = new byte[16];
//                        Array.ConstrainedCopy(byteNewKey, 0, byteKey, 0, 16);
//                    }
//                    else
//                    {
//                        byteKey = new byte[16];
//                        Array.ConstrainedCopy(this.KEY, 0, byteKey, 0, 16);
//                    }
//                    desProvide.IV = byteKey;
//                    desProvide.Key = this.KEY;
//                    break;
//            }
//            return desProvide;
//        }
//    }

//}
