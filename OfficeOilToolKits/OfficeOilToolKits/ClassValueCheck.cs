using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;  //正则表达式

namespace OfficeOilToolKits
{
    class ClassValueCheck
    {
        /// <summary>
        /// 判断文本是否是数字
        /// </summary>
        /// <param name="text">要判断的文本</param>
        /// <returns>返回判断结果</returns>
        public static bool IsNumberic(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            Regex rex = new Regex(@"^[+-]?\d*[.]?\d*$");
            return rex.IsMatch(text);
        }

        /// <summary>
        /// 从文本中提取数字
        /// </summary>
        /// <param name="strText">文本</param>
        /// <returns>返回文本型数字</returns>
        public static string GetNumberFromString(string strText)
        {
            //替换掉非数字和非小数点的文本
            string strResult = Regex.Replace(strText, @"[^\d\.]", "");
            //判断是否是数字，不是数字再替换掉小数点
            if (!IsNumberic(strResult))
                strResult = Regex.Replace(strResult, @"\.", "");

            return strResult;
        }

        /// <summary>
        /// 从文本中提取字母
        /// </summary>
        /// <param name="strText">文本</param>
        /// <returns>返回结果</returns>
        public static string GetEnglishCharFromString(String strText)
        {
            //替换掉非字母的文本
            string strResult = Regex.Replace(strText, @"[^{a-z}{A-Z}]", "");
            return strResult;
        }

        /// <summary>
        /// 提取文本和小数点
        /// </summary>
        /// <param name="strText">文本</param>
        /// <returns>返回结果</returns>
        public static string GetTextAndPointFromString(string strText)
        {
            //替换掉数字的文本
            string strResult = Regex.Replace(strText, @"[\d]", "");
            return strResult;
        }

        /// <summary>
        /// 提取文本（不包括小数点）
        /// </summary>
        /// <param name="strText">文本</param>
        /// <returns>返回结果</returns>
        public static string GetTextNoPointFromString(string strText)
        {
            //替换掉数字和小数点
            string strResult = Regex.Replace(strText, @"[\d\.]", "");
            return strResult;
        }

        /// <summary>
        /// 提取汉字
        /// </summary>
        /// <param name="strText">文本</param>
        /// <returns>返回结果</returns>
        public static string GetChineseCharFromString(string strText)
        {
            //替换掉数字和小数点
            string strResult = Regex.Replace(strText, @"[^\u4e00-\u9fa5]", "");
            return strResult;
        }
    }
}
