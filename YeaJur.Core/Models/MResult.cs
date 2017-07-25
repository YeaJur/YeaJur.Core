#region YeaJur.Core.Models 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：9f86d5ca-03dd-4c31-bf5e-5a041ca19df6
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:35:19
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Models
 * 类名称：MResult
 * 文件名：MResult
 * 文件描述：
 ***/

#endregion


namespace YeaJur.Core.Models
{
    /// <summary>
    /// 添加、修改、删除、获取全部列表处理结果实体类
    /// </summary>
    /// <typeparam name="T">返回数据类型</typeparam>
    public class MResult<T>
    {
        public MResult()
        {
        }

        /// <summary>
        /// 构建返回结果实体，默认为操作成功
        /// </summary>
        /// <param name="msg">操作成功信息</param>
        public MResult(string msg)
        {
            IsSuccess = true;
            Msg = msg;
        }

        /// <summary>
        /// 构建返回结果实体，默认为操作成功
        /// </summary>
        /// <param name="msg">操作信息</param>
        /// <param name="data">返回结果</param>
        public MResult(string msg, T data)
        {
            IsSuccess = true;
            Msg = msg;
            Data = data;
        }

        /// <summary>
        /// 构建返回结果实体
        /// </summary>
        /// <param name="msg">操作结果信息</param>
        /// <param name="data">返回结果</param>
        /// <param name="isSuccess">是否操作成功</param>
        public MResult(string msg, T data, bool isSuccess)
        {
            IsSuccess = isSuccess;
            Msg = msg;
            Data = data;
        }

        /// <summary>
        /// 操作成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 操作结果信息
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 操作结果数据
        /// </summary>
        public T Data { get; set; }
    }
}