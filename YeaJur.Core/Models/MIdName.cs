#region YeaJur.Core.Models 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2017
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：b327885f-ecc2-421e-9d8c-4f365147af31
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2017/2/25 21:53:42
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core.Models
 *	类名称：MIdName
 *	文件名：MIdName
 *	文件描述：
 *
 ***/

#endregion

namespace YeaJur.Core.Models
{
    /// <summary>
    /// ID,Name 实体类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MIdName<T>
    {
        /// <summary>
        /// Id
        /// </summary>
        public T Id { set; get; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { set; get; }
    }
}
