#region YeaJur.Core.Handlers 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：92e8ec86-1b40-4dcb-8e7c-a129f65ee0d8
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:13:12
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Handlers
 * 类名称：SessionHandler
 * 文件名：SessionHandler
 * 文件描述：
 ***/

#endregion

using System.Web;

namespace YeaJur.Core.Handlers
{
    /// <summary>
    /// Session操作类
    /// </summary>
    public class SessionHandler
    {

        /// <summary>
        /// 通过key获取Session
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static object GetSession(string key)
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session[key] != null)
            {
                return HttpContext.Current.Session[key];
            }
            return null;
        }

        /// <summary>
        /// 增加设置对应key的session值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="args"></param>
        public static void SetSession(string key, object args)
        {
            if (HttpContext.Current.Session != null)
            {
                HttpContext.Current.Session[key] = args;
            }
        }

        /// <summary>
        /// 增加设置对应key的session值
        /// </summary>
        /// <param name="key"></param>
        public static void RemoveSession(string key)
        {
            if (HttpContext.Current.Session != null && HttpContext.Current.Session[key] != null)
            {
                HttpContext.Current.Session.Remove(key);
            }
        }
    }
}
