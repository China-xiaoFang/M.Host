using M.Application.JWT.Dto;
using M.Helper.AppConfigurtaion;
using M.Helper.Http;
using M.Helper.JWT;
using M.Helper.Swagger;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace M.Application.JWT
{
    /// <summary>
    /// Token服务
    /// </summary>
    [Route("api/JWTAppServicec")]
    [ApiController]
    [HiddenApi]
    public class JWTAppServicec
    {
        /// <summary>
        /// 得到Token
        /// </summary>
        /// <param name="adminName"></param>
        /// <param name="adminPwd"></param>
        /// <returns></returns>
        [HttpGet("GetToken")]
        public async Task<GetTokenResultDto> GetToken(string adminName, string adminPwd)
        {
            string jwtStr = string.Empty;

            // 判断是否为空
            if (string.IsNullOrEmpty(adminName) || string.IsNullOrEmpty(adminPwd))
            {
                // 账号或密码不能为空
                throw new Exception("Account or password cannot be empty.");
            }

            var result = await HttpRequestService.HttpGetAsync(AppConfigurtaionService.Configuration["ProjectInfo:ApiUrl"]
                + string.Format("/api/Admin/IsExistFromToken?adminName={0}&adminPwd={1}", adminName, adminPwd));

            //StringBuilder resultStringBuilder = new StringBuilder();

            // 去除转义字符
            //foreach (char c in result.ToString())
            //{
            //    if (c != '\\') resultStringBuilder.Append(c);
            //}
            // 返回字符串转换为JSON对象
            var admin = JsonConvert.DeserializeObject<Model.Entity.Admin>(result);

            TokenJWT tokenModel = new TokenJWT();
            tokenModel.Id = admin.Id;
            tokenModel.AdminName = admin.AdminName;

            jwtStr = JWTService.IssueJWT(tokenModel);

            return new GetTokenResultDto()
            {
                JWT = "Bearer " + jwtStr,
            };
        }
    }
}