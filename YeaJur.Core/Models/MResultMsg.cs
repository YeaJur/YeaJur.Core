#region YeaJur.Core.Models 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：d825b125-c61e-4943-9f50-76fba08a4630
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:43:06
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Models
 * 类名称：MResultMsg
 * 文件名：MResultMsg
 * 文件描述：
 ***/

#endregion


namespace YeaJur.Core.Models
{
    /// <summary>
    /// 返回结果常用消息
    /// </summary>
	public static class MResultMsg
    {
        /// <summary>
      /// 添加成功
      /// </summary>
        public static readonly string AddSuccess = "添加成功！";

        /// <summary>
        /// 添加失败
        /// </summary>
        public static readonly string AddFail = "添加失败！";

        /// <summary>
        /// 保存成功
        /// </summary>
        public static readonly string SaveSuccess = "保存成功！";

        /// <summary>
        /// 保存失败
        /// </summary>
        public static readonly string SaveFail = "保存失败！";

        /// <summary>
        /// 更新成功
        /// </summary>
        public static readonly string UpdateSuccess = "更新成功！";

        /// <summary>
        /// 更新失败
        /// </summary>
        public static readonly string UpdateFail = "更新失败！";

        /// <summary>
        /// 删除成功
        /// </summary>
        public static readonly string DeleteSuccess = "删除成功！";

        /// <summary>
        /// 删除失败
        /// </summary>
        public static readonly string DeleteFail = "删除失败！";

        /// <summary>
        /// 查询成功
        /// </summary>
        public static readonly string QuerySuccess = "查询成功！";

        /// <summary>
        /// 查询失败
        /// </summary>
        public static readonly string QueryFail = "查询失败！";

        /// <summary>
        /// 安装成功
        /// </summary>
        public static readonly string InstallSuccess = "安装成功！";

        /// <summary>
        /// 安装失败
        /// </summary>
        public static readonly string InstallFail = "安装失败！";

        /// <summary>
        /// 卸载成功
        /// </summary>
        public static readonly string UninstallSuccess = "卸载成功！";

        /// <summary>
        /// 卸载失败
        /// </summary>
        public static readonly string UninstallFail = "卸载失败！";

        /// <summary>
        /// 发送成功
        /// </summary>
        public static readonly string SendSuccess = "发送成功！";

        /// <summary>
        /// 发送失败
        /// </summary>
        public static readonly string SendFail = "发送失败！";

        /// <summary>
        /// 退回成功
        /// </summary>
        public static readonly string FallbackSuccess = "退回成功！";

        /// <summary>
        /// 退回失败
        /// </summary>
        public static readonly string FallbackFail = "退回失败！";

        /// <summary>
        /// 接收成功
        /// </summary>
        public static readonly string ReceiveSuccess = "接收成功！";

        /// <summary>
        /// 接收失败
        /// </summary>
        public static readonly string ReceiveFail = "接收失败！";
        /// <summary>
        /// 参数有误
        /// </summary>
        public static readonly string ParameterError = "参数有误！";
        /// <summary>
        /// 参数信息不全
        /// </summary>
        public static readonly string ParameterMissing = "参数信息不全！";
        /// <summary>
        /// 该账户已存在，不能重复使用
        /// </summary>
        public static readonly string ExsitUser = "该账户已存在，不能重复使用！";
        /// <summary>
        /// 更新的数据不存在
        /// </summary>
        public static readonly string NotExsit = "更新的数据不存在！";
        /// <summary>
        /// 数据为空，不能操作！
        /// </summary>
        public static readonly string DataIsNull = "数据为空，不能操作！";
    }
}