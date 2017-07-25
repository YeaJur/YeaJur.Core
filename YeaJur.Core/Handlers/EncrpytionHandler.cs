#region YeaJur.Core.Handlers 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：6b6f841e-e655-4787-ab74-d3c18409fe12
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:21:46
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Handlers
 * 类名称：EncrpytionHandler
 * 文件名：EncrpytionHandler
 * 文件描述：
 ***/

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace YeaJur.Core.Handlers
{
    /// <summary>
    /// 加密处理类
    /// </summary>
	public class EncrpytionHandler
    {
        /// <summary>
        /// 计算签名算法
        /// </summary>
        /// <param name="params">请求参数集，所有参数必须已转换为字符串类型</param>
        /// <param name="secret">签名密钥</param>
        /// <returns>签名</returns>
        public static string GetMD5String(IDictionary<string, object> parameters, string secret)
        {
            // 先将参数以其参数名的字典序升序进行排序
            IDictionary<string, object> sortedParams = new SortedDictionary<string, object>(parameters);
            IEnumerator<KeyValuePair<string, object>> iterator = sortedParams.GetEnumerator();

            // 遍历排序后的字典，将所有参数按"key=value"格式拼接在一起
            StringBuilder basestring = new StringBuilder();
            while (iterator.MoveNext())
            {
                string key = iterator.Current.Key;
                string value = iterator.Current.Value.ToString();
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    basestring.Append(key).Append("=").Append(value);
                }
            }
            basestring.Append(secret);

            // 使用MD5对待签名串求签
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(basestring.ToString()));

            // 将MD5输出的二进制结果转换为小写的十六进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                string hex = bytes[i].ToString("x");
                if (hex.Length == 1)
                {
                    result.Append("0");
                }
                result.Append(hex);
            }

            return result.ToString();
        }


        /// <summary>
        /// Des加密方法
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Encrypt(string val, string key)
        {
            try
            {

                string tmpKey = key.Replace("-", "").Substring(0, 8);

                DESCryptoServiceProvider provider1 = new DESCryptoServiceProvider()
                {
                    Mode = CipherMode.ECB,
                    Key = Encoding.ASCII.GetBytes(tmpKey),
                    IV = Encoding.ASCII.GetBytes(tmpKey)
                };
                ICryptoTransform transform1 = provider1.CreateEncryptor(provider1.Key, provider1.IV);
                byte[] buffer3 = Encoding.Default.GetBytes(val);
                MemoryStream stream1 = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream1, transform1, CryptoStreamMode.Write);
                stream2.Write(buffer3, 0, buffer3.Length);
                stream2.FlushFinalBlock();
                stream2.Close();
                return Convert.ToBase64String(stream1.ToArray());
            }
            catch (Exception ex)
            {

                return "";
            }
        }

        /// <summary>
        /// Des解密方法
        /// </summary>
        /// <param name="val"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Decrypt(string val, string key)
        {
            try
            {
                string tmpKey = key.Replace("-", "").Substring(0, 8);

                DESCryptoServiceProvider provider1 = new DESCryptoServiceProvider()
                {
                    Mode = CipherMode.ECB,
                    Key = Encoding.ASCII.GetBytes(tmpKey),
                    IV = Encoding.ASCII.GetBytes(tmpKey)
                };
                ICryptoTransform transform1 = provider1.CreateDecryptor(provider1.Key, provider1.IV);
                byte[] buffer3 = Convert.FromBase64String(val);
                MemoryStream stream1 = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream1, transform1, CryptoStreamMode.Write);
                stream2.Write(buffer3, 0, buffer3.Length);
                stream2.FlushFinalBlock();
                stream2.Close();
                return Encoding.Default.GetString(stream1.ToArray());
            }
            catch// (System.Exception ex)
            {
                return "";
            }
        }

    }
}
