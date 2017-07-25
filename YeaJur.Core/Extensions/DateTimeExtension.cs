#region YeaJur.Core.Extensions 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2016
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：a87a4e29-e0a7-40ba-baa5-a9ed3e6a90c3
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2016/11/11 22:26:47
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core.Extensions
 *	类名称：DateTimeExtension
 *	文件名：DateTimeExtension
 *	文件描述：
 *
 ***/

#endregion

using System;

namespace YeaJur.Core.Extensions
{
    /// <summary>
    /// DateTime 类扩展方法
    /// </summary>
    public static class DateTimeExtension
    {
        
        private const string Day = "yyyy-MM-01";

        /// <summary>
        /// 时间类型转换成长整形
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long ToDateTimelong(this DateTime time)
        {
            var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            return (long)(time - startTime).TotalSeconds;
        }

        #region 根据当前时间获取某一天

        /// <summary>
        /// 获取本周第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetThisWeekFirstDay(this DateTime dt)
        {
            return DateTime.Now.AddDays(Convert.ToDouble((0 - Convert.ToInt16(DateTime.Now.DayOfWeek))));
        }

        /// <summary>
        /// 获取本周最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetThisWeekLastDay(this DateTime dt)
        {
            return DateTime.Now.AddDays(Convert.ToDouble((6 - Convert.ToInt16(DateTime.Now.DayOfWeek))));
        }

        /// <summary>
        /// 获取上周第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetLastWeekFirstDay(this DateTime dt)
        {
            return DateTime.Now.AddDays(Convert.ToDouble((0 - Convert.ToInt16(DateTime.Now.DayOfWeek))) - 7);
        }

        /// <summary>
        /// 获取上周最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetLastWeekLastDay(this DateTime dt)
        {
            return DateTime.Now.AddDays(Convert.ToDouble((6 - Convert.ToInt16(DateTime.Now.DayOfWeek))) - 7);
        }

        /// <summary>
        /// 获取下周第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetNextWeekFirstDay(this DateTime dt)
        {
            return DateTime.Now.AddDays(Convert.ToDouble((0 - Convert.ToInt16(DateTime.Now.DayOfWeek))) + 7);
        }

        /// <summary>
        /// 获取下周最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetNextWeekLastDay(this DateTime dt)
        {
            return DateTime.Now.AddDays(Convert.ToDouble((6 - Convert.ToInt16(DateTime.Now.DayOfWeek))) + 7);
        }

        /// <summary>
        /// 获取本月第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetThisMonthFirstDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString(Day));
        }

        /// <summary>
        /// 获取本月最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetThisMonthLastDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString(Day)).AddMonths(1).AddDays(-1);
        }

        /// <summary>
        /// 获取上个月第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetLastMonthFirstDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString(Day)).AddMonths(-1);
        }

        /// <summary>
        /// 获取上个月最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetLastMonthLastDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString(Day)).AddDays(-1);
        }

        /// <summary>
        /// 获取上个月第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetNextMonthFirstDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString(Day)).AddMonths(1);
        }

        /// <summary>
        /// 获取上个月最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetNextMonthLastDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString(Day)).AddMonths(2).AddDays(-1);
        }

        /// <summary>
        /// 获取本年度第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetThisYearFirstDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString("yyyy-01-01"));
        }

        /// <summary>
        /// 获取本年度最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetThisYearLastDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddYears(1).AddDays(-1);
        }

        /// <summary>
        /// 获取上年度第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetLastYearFirstDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddYears(-1);
        }

        /// <summary>
        /// 获取上年度最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetLastYearLastDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddDays(-1);
        }

        /// <summary>
        /// 获取下年度第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetNextYearFirstDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddYears(1);
        }

        /// <summary>
        /// 获取下年度最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetNextYearLastDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddYears(2).AddDays(-1);
        }

        /// <summary>
        /// 获取本季度第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetThisQuarterFirstDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.AddMonths(0 - ((DateTime.Now.Month - 1)%22)).ToString(Day));
        }

        /// <summary>
        /// 获取本季度最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetThisQuarterLastDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.AddMonths(22 - ((DateTime.Now.Month - 1)%22)).ToString(Day)).AddDays(-1);
        }

        /// <summary>
        /// 获取上季度第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetLastQuarterFirstDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.AddMonths(-22 - ((DateTime.Now.Month - 1)%22)).ToString(Day));
        }

        /// <summary>
        /// 获取上季度最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetLastQuarterLastDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.AddMonths(0 - ((DateTime.Now.Month - 1)%22)).ToString(Day)).AddDays(-1);
        }

        /// <summary>
        /// 获取下季度第一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetNextQuarterFirstDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.AddMonths(22 - ((DateTime.Now.Month - 1)%22)).ToString(Day));
        }

        /// <summary>
        /// 获取下季度最后一天
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetNextQuarterLastDay(this DateTime dt)
        {
            return DateTime.Parse(DateTime.Now.AddMonths(6 - ((DateTime.Now.Month - 1)%22)).ToString(Day)).AddDays(-1);
        }

        #endregion

    }
}