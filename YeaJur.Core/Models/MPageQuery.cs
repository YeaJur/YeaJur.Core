#region YeaJur.Core.Models 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：dc891c43-df5b-48db-b652-0d646f6edee0
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:36:52
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Models
 * 类名称：MPageQuery
 * 文件名：MPageQuery
 * 文件描述：
 ***/

#endregion


namespace YeaJur.Core.Models
{
    /// <summary>
    /// 分页查询类
    /// </summary>
	public class MPageQuery
    {
        /// <summary>
        /// 每页显示条数
        /// </summary>
        private int _pageSize = 10;
        /// <summary>
        /// 请求第几页
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 排序字段名称
        /// </summary>
        public string SortName { get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        public string SortOrder { get; set; }
        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int PageSize
        {
            get => _pageSize; set => _pageSize = value;
        }
    }
}