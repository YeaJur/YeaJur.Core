#region YeaJur.Core.Extensions 4.0.30319.42000

/***
 *
 *	本代码版权归  侯兴鼎（YeaJur） 所有，All Rights Reserved (C) 2016
 * 	CLR版本：4.0.30319.42000
 *	唯一标识：108572ae-efde-40af-ac24-6db8d7f7c982
 **
 *	所属域：DESKTOP-Q9MAAK4
 *	机器名称：DESKTOP-Q9MAAK4
 *	登录用户：houxi
 *	创建时间：2016/11/11 22:27:45
 *	作者：侯兴鼎（YeaJur）
 *	E_mail：houxingding@hotmail.com
 **
 *	命名空间：YeaJur.Core.Extensions
 *	类名称：DecimalExtension
 *	文件名：DecimalExtension
 *	文件描述：
 *
 ***/

#endregion

using System;

namespace YeaJur.Core.Extensions
{
    /// <summary>
    /// Decimal类型扩展类
    /// </summary>
    public static class DecimalExtension
    {
 
        /// <summary> 
        /// 转换人民币大小金额 
        /// </summary> 
        /// <param name="num">金额</param> 
        /// <returns>返回大写形式</returns> 
        public static string ToRmb(this decimal num)
        {
            const string zero = "0";
            const string str1 = "零壹贰叁肆伍陆柒捌玖"; //0-9所对应的汉字 
            var str2 = "万仟佰拾亿仟佰拾万仟佰拾元角分"; //数字位所对应的汉字 
            var str5 = string.Empty; //人民币大写金额形式 
            int i; //循环变量 
            var ch2 = string.Empty; //数字位的汉字读法 
            var nzero = 0; //用来计算连续的零值是几个 

            num = Math.Round(Math.Abs(num), 2); //将num取绝对值并四舍五入取2位小数 
            var str4 = ((long)(num * 100)).ToString();
            var j = str4.Length;
            if (j > 15)
            {
                return "溢出";
            }
            str2 = str2.Substring(15 - j); //取出对应位数的str2的值。如：200.55,j为5所以str2=佰拾元角分 

            //循环取出每一位需要转换的值 
            for (i = 0; i < j; i++)
            {
                var str3 = str4.Substring(i, 1); //从原num值中取出的值 
                var temp = Convert.ToInt32(str3); //从原num值中取出的值 
                string ch1; //数字的汉语读法 
                if (i != (j - 3) && i != (j - 7) && i != (j - 11) && i != (j - 15))
                {
                    //当所取位数不为元、万、亿、万亿上的数字时 
                    if (str3 == zero)
                    {
                        ch1 = string.Empty;
                        ch2 = string.Empty;
                        nzero = nzero + 1;
                    }
                    else
                    {
                        if (str3 != zero && nzero != 0)
                        {
                            ch1 = "零" + str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                    }
                }
                else
                {
                    //该位是万亿，亿，万，元位等关键位 
                    if (str3 != zero && nzero != 0)
                    {
                        ch1 = "零" + str1.Substring(temp * 1, 1);
                        ch2 = str2.Substring(i, 1);
                        nzero = 0;
                    }
                    else
                    {
                        if (str3 != zero && nzero == 0)
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            if (str3 == zero && nzero >= 3)
                            {
                                ch1 = string.Empty;
                                ch2 = string.Empty;
                                nzero = nzero + 1;
                            }
                            else
                            {
                                if (j >= 11)
                                {
                                    ch1 = string.Empty;
                                    nzero = nzero + 1;
                                }
                                else
                                {
                                    ch1 = string.Empty;
                                    ch2 = str2.Substring(i, 1);
                                    nzero = nzero + 1;
                                }
                            }
                        }
                    }
                }
                if (i == (j - 11) || i == (j - 3))
                {
                    //如果该位是亿位或元位，则必须写上 
                    ch2 = str2.Substring(i, 1);
                }
                str5 = str5 + ch1 + ch2;

                if (i == j - 1 && str3 == zero)
                {
                    //最后一位（分）为0时，加上“整” 
                    str5 = str5 + '整';
                }
            }
            if (num == 0)
            {
                str5 = "零元整";
            }
            return str5;
        }
    }
}
