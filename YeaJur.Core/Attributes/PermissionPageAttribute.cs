#region YeaJur.Core.Attributes 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：1d7b5ea3-3a37-4e60-825c-913922d3c674
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/31 20:09:24
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Attributes
 * 类名称：PermissionPageAttribute
 * 文件名：PermissionPageAttribute
 * 文件描述：
 ***/

#endregion

using System;

namespace YeaJur.Core.Attributes
{
    /// <summary>
    /// 表示当前Action请求为一个具体的功能页面
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class PermissionPageAttribute : Attribute
    {
    }
}