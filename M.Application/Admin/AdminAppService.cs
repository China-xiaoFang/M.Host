using M.Helper.Swagger;
using M.Model.Db;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace M.Application.Admin
{
    [Route("api/Admin")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    [HiddenApi]
    public class AdminAppService
    {
        private readonly FangHuaHostDbContext _context;

        public AdminAppService(FangHuaHostDbContext context)
        {
            _context = context;
        }

        [HttpGet("IsExistFromToken")]
        public async Task<Model.Entity.Admin> IsExistFromToken(string adminName, string adminPwd)
        {
            // 判断是否为空
            if (string.IsNullOrEmpty(adminName) || string.IsNullOrEmpty(adminPwd))
            {
                // 账号或密码不能为空
                throw new Exception("Account or password cannot be empty.");
            }
            // 判断是否正确
            var result = await _context.Admin
                .FirstOrDefaultAsync(a => a.AdminName.Equals(adminName) &&
                a.AdminPwd.Equals(adminPwd) &&
                a.IsDeleted == 0);
            if (result != null)
                return result;
            else
                // 账号或密码错误
                throw new Exception("Incorrect username or password.");
        }
    }
}