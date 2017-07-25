#region YeaJur.Core.Extensions 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2016
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：3d4cc4de-f77a-4d4c-8d89-97a270217976
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2016/11/11 22:28:54
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core.Extensions
 *	类名称：EnumerableExtension
 *	文件名：EnumerableExtension
 *	文件描述：
 *
 ***/

#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace YeaJur.Core.Extensions
{
    //
    // 摘要:
    //     封装 
    public static class EnumerableExtension
    {
        /// <summary>
        /// 集合添加一个对象
        /// </summary> 
        public static IEnumerable<T> Add<T>(this IEnumerable<T> e, T value)
        {
            foreach (var cur in e)
            {
                yield return cur;
            }
            yield return value;
        }

        /// <summary>
        /// 把集合转成DataTable
        /// </summary> 
        public static DataTable ConvertToDataTable<T>(this IEnumerable<T> enumerable)
        {
            var dataTable = new DataTable();
            foreach (PropertyDescriptor pd in TypeDescriptor.GetProperties(typeof (T)))
            {
                dataTable.Columns.Add(pd.Name, pd.PropertyType);
            }
            foreach (var item in enumerable)
            {
                var row = dataTable.NewRow();

                foreach (PropertyDescriptor dp in TypeDescriptor.GetProperties(typeof (T)))
                {
                    row[dp.Name] = dp.GetValue(item);
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
    }
}