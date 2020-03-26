using M.Helper.AppConfigurtaion;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace M.Helper.JWT
{
    public class JWTService
    {
        public static string IssueJWT(TokenJWT tokenJWT)
        {
            var dateTime = DateTime.UtcNow;
            string iss = AppConfigurtaionService.Configuration["Audience:Issuer"];
            string aud = AppConfigurtaionService.Configuration["Audience:Audience"];
            string secret = AppConfigurtaionService.Configuration["Audience:Secret"];

            // var claims = new Claim[] //old
            var claims = new List<Claim>
                {
                    // 下边为Claim的默认配置
                    new Claim(JwtRegisteredClaimNames.Jti, tokenJWT.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, $"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}"),
                    new Claim(JwtRegisteredClaimNames.Nbf,$"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}") ,
                    // 这个就是过期时间，目前是过期600秒，可自定义，注意JWT有自己的缓冲过期时间
                    new Claim (JwtRegisteredClaimNames.Exp,$"{new DateTimeOffset(DateTime.Now.AddSeconds(600)).ToUnixTimeSeconds()}"),
                    new Claim(JwtRegisteredClaimNames.Iss,iss),
                    new Claim(JwtRegisteredClaimNames.Aud,aud),

                    // new Claim(ClaimTypes.Role,tokenModel.Role),//为了解决一个用户多个角色(比如：Admin,System)，用下边的方法
               };

            // 可以将一个用户的多个角色全部赋予；
            claims.AddRange(tokenJWT.AdminName.Split(',').Select(s => new Claim(ClaimTypes.Role, s)));

            // 秘钥 (SymmetricSecurityKey 对安全性的要求，密钥的长度太短会报出异常)
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwt = new JwtSecurityToken(
                issuer: iss,
                claims: claims,
                signingCredentials: creds);

            var jwtHandler = new JwtSecurityTokenHandler();
            var encodedJwt = jwtHandler.WriteToken(jwt);

            return encodedJwt;
        }
    }

    ///// <summary>
    ///// 令牌
    ///// </summary>
    //public class TokenModelJWT
    //{
    //    /// <summary>
    //    /// Id
    //    /// </summary>
    //    public long Uid { get; set; }

    //    /// <summary>
    //    /// 角色
    //    /// </summary>
    //    public string Role { get; set; }

    //    /// <summary>
    //    /// 职能
    //    /// </summary>
    //    public string Work { get; set; }
    //}
}