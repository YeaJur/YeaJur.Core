#region YeaJur.Core.Attributes 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：2bcea50e-399f-4df7-bbc1-c961a50d0965
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/31 20:09:01
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Attributes
 * 类名称：LoginAllowViewAttribute
 * 文件名：LoginAllowViewAttribute
 * 文件描述：
 ***/

#endregion

using System;

namespace YeaJur.Core.Attributes
{
    /// <summary>
    /// 代表该方法可以允许登录用户都能访问
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class LoginAllowViewAttribute : Attribute
    {
    }
}