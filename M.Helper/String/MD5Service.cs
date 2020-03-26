using System.Security.Cryptography;
using System.Text;

namespace M.Helper.String
{
    /// <summary>
    /// MD5服务
    /// </summary>
    public class MD5Service
    {
        /// <summary>
        /// 生成MD5
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string GenerateMD5(string content)
        {
            using (MD5 mi = MD5.Create())
            {
                byte[] buffer = Encoding.Default.GetBytes(content);
                //开始加密
                byte[] newBuffer = mi.ComputeHash(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}