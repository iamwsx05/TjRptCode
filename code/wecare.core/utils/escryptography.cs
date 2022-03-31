using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace weCare.Core.Utils
{
    public class ESCryptography
    {
        /// <summary>
        /// 密钥
        /// </summary>
        private const string KEY = @"1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./";

        /// <summary>
        /// 缺省字符编码
        /// </summary>
        private static Encoding Encoding = Encoding.UTF8;

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="p_strOriginal">原始信息</param>
        /// <returns></returns>
        public static string Encrypt(string p_strOriginal)
        {
            return Encrypt(p_strOriginal, KEY);
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="p_strOriginal">加密信息</param>
        /// <returns></returns>
        public static string Decrypt(string p_strOriginal)
        {
            return Decrypt(p_strOriginal, KEY);
        }

        /// <summary>
        /// 使用给定密钥加密
        /// </summary>
        /// <param name="original">原始文字</param>
        /// <param name="key">密钥</param>
        /// <returns>密文</returns>
        private static string Encrypt(string original, string key)
        {
            byte[] buff = Encoding.GetBytes(original);
            byte[] kb = Encoding.GetBytes(key);
            return Convert.ToBase64String(Encrypt(buff, kb));
        }

        /// <summary>
        /// 使用给定密钥解密
        /// </summary>
        /// <param name="original">密文</param>
        /// <param name="key">密钥</param>
        /// <returns>明文</returns>
        private static string Decrypt(string original, string key)
        {
            return Decrypt(original, key, Encoding);
        }

        /// <summary>
        /// 使用给定密钥解密
        /// </summary>
        /// <param name="encrypted">密文</param>
        /// <param name="key">密钥</param>
        /// <param name="encoding">字符编码方案</param>
        /// <returns>明文</returns>
        private static string Decrypt(string encrypted, string key, Encoding encoding)
        {
            try
            {
                byte[] buff = Convert.FromBase64String(encrypted);
                byte[] kb = System.Text.Encoding.Default.GetBytes(key);
                if (Decrypt(buff, kb) == null)
                    return null;
                else
                    return encoding.GetString(Decrypt(buff, kb));
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 生成MD5摘要
        /// </summary>
        /// <param name="original">数据源</param>
        /// <returns>摘要</returns>
        private static byte[] MakeMD5(byte[] original)
        {
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] keyhash = hashmd5.ComputeHash(original);
            hashmd5 = null;
            return keyhash;
        }

        /// <summary>
        /// 使用给定密钥加密
        /// </summary>
        /// <param name="original">明文</param>
        /// <param name="key">密钥</param>
        /// <returns>密文</returns>
        private static byte[] Encrypt(byte[] original, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;

            return des.CreateEncryptor().TransformFinalBlock(original, 0, original.Length);
        }

        /// <summary>
        /// 使用给定密钥解密数据
        /// </summary>
        /// <param name="encrypted">密文</param>
        /// <param name="key">密钥</param>
        /// <returns>明文</returns>
        private static byte[] Decrypt(byte[] encrypted, byte[] key)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = MakeMD5(key);
            des.Mode = CipherMode.ECB;

            try
            {
                return des.CreateDecryptor().TransformFinalBlock(encrypted, 0, encrypted.Length);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static string EncryptMD5(string original)
        {
            byte[] data = Encoding.Default.GetBytes(original);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            data = md5.ComputeHash(data);
            return BitConverter.ToString(data).Replace("-", "");
        }

        /// <summary>
        /// MD5加密 - 16进制
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static string EncryptMD5X(string original)
        {
            MD5 md5Hash = MD5.Create();
            // 将输入字符串转换为字节数组并计算哈希数据 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(original));
            // 创建一个 Stringbuilder 来收集字节并创建字符串 
            StringBuilder sBuilder = new StringBuilder();
            // 循环遍历哈希数据的每一个字节并格式化为十六进制字符串 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // 返回十六进制字符串 
            return sBuilder.ToString();
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="encodeType">加密采用的编码方式</param>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        public static string EncryptBase64(Encoding encodeType, string original)
        {
            string encode = string.Empty;
            byte[] bytes = encodeType.GetBytes(original);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = original;
            }
            return encode;
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="encodeType">加密采用的编码方式</param>
        /// <param name="result">待解密的密文</param>
        /// <returns></returns>
        public static string DecryptBase64(Encoding encodeType, string result)
        {
            string decode = string.Empty;
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encodeType.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }
    }

    /// <summary>
    /// 随机数
    /// </summary>
    public class RandomMode
    {
        /// <summary>
        /// 生成随机数数组
        /// </summary>
        /// <param name="p_intLen"></param>
        /// <returns></returns>
        public static int[] RandomArr(int p_intLen)
        {
            int[] intArr = new int[p_intLen];
            for (int i = 0; i < p_intLen; i++)
            {
                intArr[i] = i;
            }
            if (p_intLen > 1)
            {
                byte[] data = new byte[8];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetBytes(data);

                //p_intLen--;
                int intIdx = 0;
                int intNum = 0;
                int intMax = 0;
                Random ran = new Random(BitConverter.ToInt32(data, 0));
                for (int i = 0; i < p_intLen; i++)
                {
                    intMax = p_intLen - i;
                    intIdx = ran.Next(0, intMax);
                    intNum = intArr[intIdx];
                    intArr[intIdx] = intArr[intMax - 1];
                    intArr[intMax - 1] = intNum;
                }
                rng = null;
                ran = null;
            }
            return intArr;
        }
    }

    /// <summary>
    /// 数据解、压缩类
    /// </summary>
    public class Compression
    {
        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] Zip(object obj)
        {
            if (obj == null) return null;
            IFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            //序列化
            formatter.Serialize(stream, obj);
            byte[] data = stream.ToArray();
            stream.Close();
            return Compress(data, CompressionMode.Compress);
        }

        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Zip(byte[] data)
        {
            if (data == null) return null;
            return Compress(data, CompressionMode.Compress);
        }

        /// <summary>
        /// 解压缩
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static object UnZip(byte[] data)
        {
            if (data == null) return null;
            try
            {
                IFormatter formatter = new BinaryFormatter();
                MemoryStream stream = new MemoryStream(Compress(data, CompressionMode.Decompress));
                //反序列化
                return formatter.Deserialize(stream);
            }
            catch
            {
                return data;
            }
        }

        /// <summary>
        /// 压缩、解压缩
        /// </summary>
        /// <param name="data"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        private static byte[] Compress(byte[] data, CompressionMode mode)
        {
            DeflateStream zip = null;
            try
            {
                if (mode == CompressionMode.Compress)
                {
                    MemoryStream ms = new MemoryStream();
                    zip = new DeflateStream(ms, mode, true);
                    zip.Write(data, 0, data.Length);
                    zip.Close();
                    return ms.ToArray();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    ms.Write(data, 0, data.Length);
                    ms.Flush();
                    ms.Position = 0;
                    zip = new DeflateStream(ms, mode, true);
                    MemoryStream os = new MemoryStream();
                    int SIZE = 10240;
                    byte[] buf = new byte[SIZE];
                    int offset = 0;
                    int intBytesRead = 0;
                    while (true)
                    {
                        intBytesRead = zip.Read(buf, offset, SIZE);
                        if (intBytesRead == 0)
                        {
                            zip.Close();
                            break;
                        }
                        os.Write(buf, offset, intBytesRead);
                        //offset += intBytesRead; 
                    }
                    //int l = 0;
                    //do
                    //{
                    //    l = zip.Read(buf, 0, SIZE);
                    //    if (l == 0) l = zip.Read(buf, 0, SIZE);
                    //    os.Write(buf, 0, l);
                    //} while (l != 0);
                    buf = null;
                    zip.Close();
                    return os.ToArray();
                }
            }
            catch
            {
                if (zip != null) zip.Close();
                return null;
            }
            finally
            {
                if (zip != null) zip.Close();
            }
        }

    }

}
