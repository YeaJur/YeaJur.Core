#region YeaJur.Core.Models 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：2898b73a-50c1-4adb-8231-a2d44fec871d
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/31 20:13:08
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Models
 * 类名称：MSystemAuthorize
 * 文件名：MSystemAuthorize
 * 文件描述：
 ***/

#endregion


namespace YeaJur.Core.Models
{
    /// <summary>
    /// 系统权限实体类
    /// </summary>
	public class MSystemAuthorize
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
    }
}