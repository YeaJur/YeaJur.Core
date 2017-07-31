#region YeaJur.Core.Models 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：390506ef-26b6-4768-8a58-8e9e9092c39e
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/31 20:11:48
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Models
 * 类名称：MSystemAction
 * 文件名：MSystemAction
 * 文件描述：
 ***/

#endregion


namespace YeaJur.Core.Models
{
    /// <summary>
    /// MVC控制器action实体类
    /// </summary>
	public class MSystemAction
    {
        /// <summary>
        /// 动作
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// 控制器
        /// </summary>
        public string ControllerName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        public string LinkUrl { get; set; }
    }
}