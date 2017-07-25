#region YeaJur.Core.Models 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2017
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：645ef418-0fef-4436-b4be-594c279aa498
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2017/2/25 21:55:04
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core.Models
 *	类名称：MKeyValue
 *	文件名：MKeyValue
 *	文件描述：
 *
 ***/

#endregion

namespace YeaJur.Core.Models
{
    /// <summary>
    /// 键值实体类
    /// </summary>
    public class MKeyValue<TKey, TValue>
    {
        public MKeyValue()
        { }

        public MKeyValue(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// 建
        /// </summary>
        public TKey Key { set; get; }

        /// <summary>
        /// 值
        /// </summary>
        public TValue Value { set; get; }
    }
}
