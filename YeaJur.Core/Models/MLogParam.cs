#region YeaJur.Core.Models 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2017
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：b3f65385-7300-4ea0-bb8c-6a019aa2c512
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2017/4/7 20:34:05
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core.Models
 *	类名称：MLogParam
 *	文件名：MLogParam
 *	文件描述：
 *
 ***/

#endregion

using YeaJur.Core.Enums;

namespace YeaJur.Core.Models
{
    /// <summary>
    /// 日志参数
    /// </summary>
    public class MLogParam
    {
        /// <summary>
        /// 日志类型
        /// 常规日志，只设置 Debug\Info级别
        /// 异常类日志,只设置 Warn\Error\Fatal级别
        /// </summary>
        public ELogType Log { get; set; }

        /// <summary>
        /// 操作前日志信息
        /// </summary>
        public string BeforeMsg { get; set; }
        /// <summary>
        /// 操作前日志信息
        /// </summary>
        public string AfterMsg { get; set; }
    }
}
