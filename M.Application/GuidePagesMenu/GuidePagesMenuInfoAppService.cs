using M.Model.Db;
using M.Model.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.Application.GuidePagesMenu
{
    /// <summary>
    /// 引导页菜单服务
    /// </summary>
    [Route("api/GuidePagesMenuInfoAppService")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    public class GuidePagesMenuInfoAppService
    {
        private readonly FangHuaHostDbContext _context;

        public GuidePagesMenuInfoAppService(FangHuaHostDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有菜单信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGuidePagesMenuInfo")]
        public async Task<List<GuidePagesMenuInfo>> GetAllGuidePagesMenuInfo()
        {
            return await _context.GuidePagesMenuInfo
                .Where(b => b.IsDeleted == 0 && b.ParentId == 0)
                .ToListAsync();
        }
    }
}