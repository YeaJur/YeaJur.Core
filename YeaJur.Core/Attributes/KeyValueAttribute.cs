#region YeaJur.Core..Attributes 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2016
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：96972b9c-2190-4087-81af-a1287765ba96
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2016/3/3 21:29:58
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core..Attributes
 *	类名称：KeyValueAttribute
 *	文件名：KeyValueAttribute
 *	文件描述：
 *
 ***/

#endregion

using System;

namespace YeaJur.Core.Attributes
{

    /// <summary>
    /// 键值对
    /// </summary>
    public class KeyValueAttribute : Attribute
    {
        /// <summary>
        /// 键值同
        /// </summary>
        /// <param name="value">键值</param>
        public KeyValueAttribute(object value)
        {
            Key = value;
            Value = value;
        }

        /// <summary>
        /// 键值异
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public KeyValueAttribute(object key, object value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// 值
        /// </summary>
        public object Value { get; }

        /// <summary>
        /// 键
        /// </summary>
        public object Key { get; }
    }
}