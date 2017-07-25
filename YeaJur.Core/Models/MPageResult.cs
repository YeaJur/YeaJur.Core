#region YeaJur.Core.Models 4.0

/***
 * 本代码版权归  侯兴鼎（YeaJur）  所有，All Rights Reserved (C) 2017
 * CLR版本：4.0.30319.42000
 * 唯一标识：6624c4aa-3737-45ee-add7-72e7637843ab
 **
 * 所属域：DESKTOP-Q9MAAK4
 * 机器名称：DESKTOP-Q9MAAK4
 * 登录用户：houxi
 * 创建时间：2017/7/25 21:38:58
 * 创建人：侯兴鼎（YeaJur）
 * E_mail：houxingding@hotmail.com
 **
 * 命名空间：YeaJur.Core.Models
 * 类名称：MPageResult
 * 文件名：MPageResult
 * 文件描述：
 ***/

#endregion


namespace YeaJur.Core.Models
{
    /// <summary>
    /// 分页结果
    /// </summary>
    public class MPageResult<T> : MResult<T>
    {
        public MPageResult()
        {
        }

        /// <summary>
        /// 构建返回结果实体，默认为操作成功
        /// </summary>
        /// <param name="msg">操作成功信息</param>
        public MPageResult(string msg, int count)
        {
            IsSuccess = true;
            Msg = msg;
            Total = count;
        }

        /// <summary>
        /// 构建返回结果实体，默认为操作成功
        /// </summary>
        /// <param name="msg">操作信息</param>
        /// <param name="data">返回结果</param>
        public MPageResult(string msg, T data, int count)
        {
            IsSuccess = true;
            Msg = msg;
            Data = data;
            Total = count;
        }

        /// <summary>
        /// 构建返回结果实体
        /// </summary>
        /// <param name="msg">操作结果信息</param>
        /// <param name="data">返回结果</param>
        /// <param name="isSuccess">是否操作成功</param>
        public MPageResult(string msg, T data, bool isSuccess, int count)
        {
            IsSuccess = isSuccess;
            Msg = msg;
            Data = data;
            Total = count;
        }
        /// <summary>
        /// 总条数
        /// </summary>
        public int Total { get; set; }
    }
}