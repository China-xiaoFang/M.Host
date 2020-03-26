using M.Helper.AppConfigurtaion;
using M.Helper.BaiduTranslator;
using M.Helper.Log;
using M.Helper.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace M.Helper.Middleware
{
    /// <summary>
    /// 全局异常捕获中间件
    /// </summary>
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public ExceptionHandlerMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _requestDelegate(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext httpContext, Exception e)
        {
            if (e == null) return;
            LogHelper.Error(e.Source, e.GetBaseException().ToString());
            await WriteExceptionAsync(httpContext, e).ConfigureAwait(false);
        }

        private static async Task WriteExceptionAsync(HttpContext httpContext, Exception e)
        {
            if (e is UnauthorizedAccessException)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            }
            else if (e is Exception)
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            httpContext.Response.ContentType = "application/json";
            // 把异常信息通过百度翻译再返回出去
            var resultDto = await BaiduTranslatorService.Translator(e.GetBaseException().Message);
            // 异常信息返回格式 [zh]：中文 [en]英文
            await httpContext.Response
                .WriteAsync(JsonConvert.SerializeObject(new ResultDto()
                {
                    Success = false,
                    ResultInfo = string.Format("【{0}】温馨提示：[{1}]：{2} [{3}]：{4}",
                        AppConfigurtaionService.Configuration["ProjectInfo:Project_Name"],
                        resultDto.To, resultDto.Trans_Result[0].Dst, resultDto.From, resultDto.Trans_Result[0].Src),
                    StatusCode = httpContext.Response.StatusCode
                })).ConfigureAwait(false);
        }
    }
}