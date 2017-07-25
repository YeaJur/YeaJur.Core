#region YeaJur.Core.Handlers 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：6189c995-1ade-42f4-ac80-8472b5329cfa
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:24:28
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Handlers
 * 类名称：DescriptionHandler
 * 文件名：DescriptionHandler
 * 文件描述：
 ***/

#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace YeaJur.Core.Handlers
{
    /// <summary>
    /// 描述特性处理
    /// </summary>
    public static class DescriptionHandler
    {
        /// <summary>
        /// 获取某个类型的所有属性描述
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Dictionary<string, string> GetList<T>()
        {
            PropertyInfo[] peroperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (PropertyInfo property in peroperties)
            {
                object[] objs = property.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (objs.Length > 0)
                {
                    dict.Add(property.Name, ((DescriptionAttribute)objs[0]).Description);
                }
            }
            return dict;
        }

    }
}