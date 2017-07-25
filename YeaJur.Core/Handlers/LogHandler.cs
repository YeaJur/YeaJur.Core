#region YeaJur.Core.Handlers 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：f1074bea-deb6-42f5-8251-257f7b5fc0a0
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:14:39
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Handlers
 * 类名称：LogHandler
 * 文件名：LogHandler
 * 文件描述：
 ***/

#endregion

using log4net;
using System;
using System.Threading.Tasks;
using YeaJur.Core.Enums;
using YeaJur.Core.Extensions;

namespace YeaJur.Core.Handlers
{
    /// <summary>
    /// 类
    /// </summary>
	public class LogHandler
    {
        /// <summary>
        /// 日志记录
        /// </summary>
        /// <param name="logType">日志类型</param>
        /// <param name="msg">信息</param>
        /// <param name="ex">异常</param>
        public static void Log(ELogType logType, string msg, Exception ex = null)
        {
            Parallel.Invoke(() =>
            {
                //创建日志记录组件实例
                var log = LogManager.GetLogger(logType.GetStringValue());

                switch (logType)
                {
                    case ELogType.Debug:
                        log.Debug(msg, ex);
                        break;
                    case ELogType.Error:
                        log.Error(msg, ex);
                        break;
                    case ELogType.Info:
                        log.Info(msg, ex);
                        break;
                    case ELogType.Warn:
                        log.Warn(msg, ex);
                        break;
                    case ELogType.Fatal:
                        log.Fatal(msg, ex);
                        break;
                }
            });
        }
    }
}
