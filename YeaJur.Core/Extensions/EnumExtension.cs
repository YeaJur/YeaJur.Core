#region YeaJur.Core.Extensions 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2016
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：ea4f7530-642b-4e24-9376-079a38eb7aa1
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2016/11/11 22:30:03
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core.Extensions
 *	类名称：EnumExtension
 *	文件名：EnumExtension
 *	文件描述：
 *
 ***/

#endregion

using System;
using YeaJur.Core.Attributes;

namespace YeaJur.Core.Extensions
{

    /// <summary>
    /// Enum 类型扩展类
    /// </summary>
    public static class EnumExtension
    {

        #region Object

        /// <summary>
        /// 获取值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object GetValue(this Enum value)
        {
            object output = null;
            var type = value.GetType();

            var fi = type.GetField(value.ToString());
            var attrs = fi.GetCustomAttributes(typeof(KeyValueAttribute), false) as KeyValueAttribute[];
            if (attrs != null && attrs.Length > 0)
            {
                output = attrs[0].Value;
            }

            return output;
        }

        /// <summary>
        /// 获取键
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object GetKey(this Enum value)
        {
            object output = null;
            var type = value.GetType();

            var fi = type.GetField(value.ToString());
            var attrs = fi.GetCustomAttributes(typeof(KeyValueAttribute), false) as KeyValueAttribute[];
            if (attrs != null && attrs.Length > 0)
            {
                output = attrs[0].Key;
            }

            return output;
        }
     
        #endregion

        #region string

        /// <summary>
        /// 获取字符串值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetStringValue(this Enum value)
        {
            return GetValue(value).ToString();
        }

        /// <summary>
        /// 获取字符串键
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetStringKey(this Enum value)
        {
            return GetKey(value).ToString();
        }

        #endregion

        #region Int

        /// <summary>
        /// 获取Int值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int GetIntValue(this Enum value)
        {
            return (int) GetValue(value);
        }

        /// <summary>
        /// 获取Int键
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int GetIntKey(this Enum value)
        {
            return (int) GetKey(value);
        }

        #endregion

        #region bool

        /// <summary>
        /// 获取Int值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool GetBoolValue(this Enum value)
        {
            return (bool)GetValue(value);
        }

        /// <summary>
        /// 获取Int键
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool GetBoolKey(this Enum value)
        {
            return (bool)GetKey(value);
        }

        #endregion

    }
}