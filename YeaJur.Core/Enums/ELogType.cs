#region YeaJur.Core.Enums 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：161db8c6-14e3-49c1-8a50-7e45fa496f2b
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:32:53
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Enums
 * 类名称：ELogType
 * 文件名：ELogType
 * 文件描述：
 ***/

#endregion

using YeaJur.Core.Attributes;

namespace YeaJur.Core.Enums
{
    /// <summary>
    /// 日志枚举类
    /// </summary>
    public enum ELogType
    {
        /// <summary>
        /// 调试信息
        /// </summary>
        [KeyValue("Debug", "LogDebug")]
        Debug,

        /// <summary>
        /// 常规信息
        /// </summary>
        [KeyValue("Info", "LogInfo")]
        Info,

        /// <summary>
        /// 警告信息
        /// </summary>
        [KeyValue("Warn", "LogWarn")]
        Warn,

        /// <summary>
        /// 错误信息
        /// </summary>
        [KeyValue("Error", "LogError")]
        Error,

        /// <summary>
        /// 致命错误
        /// </summary>
        [KeyValue("Fatal", "LogFatal")]
        Fatal
    }
}