using System;
using System.Text;
using System.Text.RegularExpressions;

namespace M.Helper.String
{
    /// <summary>
    /// Unicode字符服务
    /// </summary>
    public static class UnicodeStringService
    {
        /// <summary>
        /// Unicode编码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EnUnicode(this string str)
        {
            StringBuilder strResult = new StringBuilder();
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    strResult.Append("\\u");
                    strResult.Append(((int)str[i]).ToString("x"));
                }
            }
            return strResult.ToString();
        }

        /// <summary>
        /// Unicode解码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DeUnicode(this
            string str)
        {
            //最直接的方法Regex.Unescape(str);
            Regex reg = new Regex(@"(?i)\\[uU]([0-9a-f]{4})");
            return reg.Replace(str, delegate (Match m) { return ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString(); });
        }

        #region 以淘汰
        /// <summary>
        /// 把中文字符串转换为Unicode串
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string ToUnicode(string content)
        {
            string tmp = "";
            foreach (var c in content)
            {
                // 将中文字符转化为Unicode串
                if (IsChinese(c)) tmp += "\\u" + ToString(c, 16);
                else tmp += c;
            }
            return tmp;
        }

        /// <summary>
        /// 把Unicode串转换为中文字符串
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string ToChinese(string content)
        {
            string tmp = "";
            Regex regex = new Regex("\\\\u[0-9a-fA-F]{4}", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(tmp);
            foreach (Match match in matches)
            {
                // 获取16进制串
                string hexStr = match.Value.Substring("\\u".Length);
                string c = ToChar(match.Value, 16).ToString();
                tmp = tmp.Replace(match.Value, c);
            }
            return tmp;
        }

        /// <summary>
        /// 判断字符是否为中文字符
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsChinese(char c)
        {
            // 中文字符范围
            return 0x4e00 <= c && c <= 0x9fbb;
        }

        /// <summary>
        /// 把数值转换为radix进制表示的字符串
        /// </summary>
        /// <param name="num"></param>
        /// <param name="radix"></param>
        /// <returns></returns>
        public static string ToString(int num, int radix = 10)
        {
            string str = "";
            while (num > 0)
            {
                // 取余数
                int remainder = num % radix;
                // 取商
                num /= radix;
                str = ToChar(remainder) + str;
            }
            return str;
        }

        /// <summary>
        /// 将数值转换为字符
        /// 将数值n转化为字符，0 <= n <= 35，依次转化为字符0-9a-z;
        /// 最大可表示36进制数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static char ToChar(int n)
        {
            n %= 36;
            if (n < 10) n += '0';
            else n += 'a' - 10;
            return (char)n;
        }

        /// <summary>
        /// 将字符转换为数值
        /// 将字符0-9a-z依次转化为数值0-35
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int ToInt(char c)
        {
            if (c > '9') return c - 'a' + 10;
            else return c - '0';
        }

        /// <summary>
        /// 将字符串radix进制的串str转化为字符
        /// </summary>
        /// <param name="str"></param>
        /// <param name="radix"></param>
        /// <returns></returns>
        public static char ToChar(string str, int radix)
        {
            int n = 0;
            foreach (char c in str)
            {
                n = n * radix + ToInt(c);
            }
            return (char)n;
        }
        #endregion
    }
}
