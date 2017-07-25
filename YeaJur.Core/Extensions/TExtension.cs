#region YeaJur.Core.Extensions 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2016
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：60aded8d-1c91-4d47-8fb7-a857420aac3a
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2016/11/11 22:42:04
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core.Extensions
 *	类名称：TExtension
 *	文件名：TExtension
 *	文件描述：
 *
 ***/

#endregion

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace YeaJur.Core.Extensions
{
    //
    // 摘要:
    //     封装 
    /// <summary>
    /// T 类型扩展类
    /// </summary>
    public static class TExtension
    {
        /// <summary>
        /// 将可序列化对象转成Byte数组
        /// </summary>
        /// <param name="obj">对象(对象不能为空)</param>
        /// <returns>返回相关数组</returns>
        public static byte[] ToBytes<T>(this T obj) where T : ISerializable
        {
            if (obj == null)
            {
                var byteArr = new byte[] { };
                return byteArr;
            }
            var ms = new MemoryStream();
            var bf = new BinaryFormatter();
            bf.Serialize(ms, obj);
            ms.Close();
            return ms.ToArray();
        }
    }
}