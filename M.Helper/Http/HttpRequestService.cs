using M.Helper.String;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace M.Helper.Http
{
    /// <summary>
    /// Http请求服务
    /// </summary>
    public class HttpRequestService
    {
        /// <summary>
        /// GET同步请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="headers">头部信息</param>
        /// <returns></returns>
        public static string HttpGet(string url, Dictionary<string, string> headers = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }
                HttpResponseMessage httpResponseMessage = httpClient.GetAsync(url).Result;
                return httpResponseMessage.Content.ReadAsStringAsync().Result;
            }
        }

        /// <summary>
        /// GET异步请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="headers">头部信息</param>
        /// <returns></returns>
        public static async Task<string> HttpGetAsync(string url, Dictionary<string, string> headers = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
                return UnicodeStringService.DeUnicode(await httpResponseMessage.Content.ReadAsStringAsync());
            }
        }

        /// <summary>
        /// POST同步请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="postData">数据</param>
        /// <param name="contentType">类型</param>
        /// <param name="timeOut">响应时间</param>
        /// <param name="headers">头部信息</param>
        /// <returns></returns>
        public static string HttpPost(string url, string postData = null, string contentType = null,
            int timeOut = 30, Dictionary<string, string> headers = null)
        {
            postData = postData ?? "";
            using (HttpClient httpClient = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }
                using (HttpContent httpContent = new StringContent(postData, Encoding.UTF8))
                {
                    if (contentType != null)
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                    }
                    HttpResponseMessage httpResponseMessage = httpClient.PostAsync(url, httpContent).Result;
                    return httpResponseMessage.Content.ReadAsStringAsync().Result;
                }
            }
        }

        /// <summary>
        /// POST异步请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="postData">数据</param>
        /// <param name="contentType">类型</param>
        /// <param name="timeOut">响应时间</param>
        /// <param name="headers">头部信息</param>
        /// <returns></returns>
        public static async Task<string> HttpPostAsync(string url, string postData = null, string contentType = null,
           int timeOut = 30, Dictionary<string, string> headers = null)
        {
            postData = postData ?? "";
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = new TimeSpan(0, 0, timeOut);
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }
                using (HttpContent httpContent = new StringContent(postData, Encoding.UTF8))
                {
                    if (contentType != null)
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                    }
                    HttpResponseMessage httpResponseMessage = await httpClient.PostAsync(url, httpContent);
                    return await httpResponseMessage.Content.ReadAsStringAsync();
                }
            }
        }
    }
}