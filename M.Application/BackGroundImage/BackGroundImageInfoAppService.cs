using M.Model.Db;
using M.Model.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.Application.BackGroundImage
{
    /// <summary>
    /// 背景图片服务
    /// </summary>
    [Route("api/BackGroundImageInfoAppService")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    public class BackGroundImageInfoAppService
    {
        private readonly FangHuaHostDbContext _context;

        public BackGroundImageInfoAppService(FangHuaHostDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有背景图片信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllBackGroundImageInfo")]
        public async Task<List<BackGroundImageInfo>> GetAllBackGroundImageInfo()
        {
            return await _context.BackGroundImageInfo
                .Where(b => b.IsDeleted == 0)
                .ToListAsync();
        }
    }
}