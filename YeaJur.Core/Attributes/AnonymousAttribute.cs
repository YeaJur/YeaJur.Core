#region YeaJur.Core.Attributes 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：0a724d02-361f-4a35-99fc-bdf163659549
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/31 20:08:11
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Attributes
 * 类名称：AnonymousAttribute
 * 文件名：AnonymousAttribute
 * 文件描述：
 ***/

#endregion

using System;

namespace YeaJur.Core.Attributes
{
    /// <summary>
    /// 匿名访问标记
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AnonymousAttribute : Attribute
    {
    }
}
