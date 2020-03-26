using M.Helper.AppConfigurtaion;
using M.Helper.Http;
using M.Helper.String;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace M.Helper.BaiduTranslator
{
    /// <summary>
    /// 百度翻译服务
    /// </summary>
    public class BaiduTranslatorService
    {
        /// <summary>
        /// 百度翻译开发者APPID
        /// </summary>
        protected static string APPID { get; set; } = AppConfigurtaionService.Configuration["BaiduTranslateApiInfo:APPID"];

        /// <summary>
        /// 请求API地址
        /// </summary>
        protected static string Url { get; set; } = AppConfigurtaionService.Configuration["BaiduTranslateApiInfo:Url"];

        /// <summary>
        /// 随机码
        /// </summary>
        protected static string Salt { get; set; } = AppConfigurtaionService.Configuration["BaiduTranslateApiInfo:Salt"];

        /// <summary>
        /// 密钥
        /// </summary>
        protected static string SecretKey { get; set; } = AppConfigurtaionService.Configuration["BaiduTranslateApiInfo:SecretKey"];

        /// <summary>
        /// 原文语言
        /// </summary>
        protected static string From { get; set; } = AppConfigurtaionService.Configuration["BaiduTranslateApiInfo:From"];

        /// <summary>
        /// 译文语言
        /// </summary>
        protected static string To { get; set; } = AppConfigurtaionService.Configuration["BaiduTranslateApiInfo:To"];

        /// <summary>
        /// 参数样板
        /// </summary>
        protected static string Parameter { get; set; } = AppConfigurtaionService.Configuration["BaiduTranslateApiInfo:Parameter"];

        /// <summary>
        /// 签名
        /// APPID+内容+Salt+SecretKey 的MD5值
        /// </summary>
        protected static string Sign { get; set; }

        public static async Task<BaiduTranslatorResultDto> Translator(string content, string from = null, string to = null)
        {
            // 判断翻译语言
            if (from != null) From = from;
            if (to != null) To = to;
            // 签名
            Sign = MD5Service.GenerateMD5(APPID + content + Salt + SecretKey);
            // 参数
            var parameter = string.Format(Parameter, content, From, To, APPID, Salt, Sign);
            // GetAsync请求
            var resultString = await HttpRequestService.HttpGetAsync(Url + "?" + parameter);
            StringBuilder resultStringBuilder = new StringBuilder();
            // 去除转义字符
            //foreach (char c in resultString)
            //{
            //    if (c != '\\') resultStringBuilder.Append(c);
            //}
            // 返回字符串转换为JSON对象
            return JsonConvert.DeserializeObject<BaiduTranslatorResultDto>(resultString);
        }
    }
}