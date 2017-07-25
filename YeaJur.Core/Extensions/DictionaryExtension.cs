#region YeaJur.Core.Extensions 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2016
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：311c2248-5865-498d-8703-9dba50b57e66
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2016/11/11 22:28:24
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core.Extensions
 *	类名称：DictionaryExtension
 *	文件名：DictionaryExtension
 *	文件描述：
 *
 ***/

#endregion

using System.Collections.Generic;
using System.Text;

namespace YeaJur.Core.Extensions
{

    /// <summary>
    /// Dictionary类型扩展类
    /// </summary>
    public static class DictionaryExtension
    {

        /// <summary>
        /// 字典集合转成无数组的json字符串
        /// </summary>
        /// <param name="list">字典集合</param>
        /// <returns>json字符串</returns>
        public static string ToJson(this Dictionary<string, string> list)
        {
            var json = new StringBuilder("{");
            var prefix = string.Empty;
            foreach (var dict in list)
            {
                json.Append($"{prefix}\"{dict.Key}\":\"{dict.Value}\"");
                prefix = ",";
            }
            json.Append("}");
            return json.ToString();
        }
    }
}