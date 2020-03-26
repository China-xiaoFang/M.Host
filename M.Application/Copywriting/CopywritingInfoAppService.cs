using M.Model.Db;
using M.Model.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.Application.Copywriting
{
    /// <summary>
    /// 文案服务
    /// </summary>
    [Route("api/CopywritingInfoAppService")]
    [ApiController]
    public class CopywritingInfoAppService
    {
        private readonly MChenVipDbContext _context;

        public CopywritingInfoAppService(MChenVipDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有文案
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCopywritingInfo")]
        public async Task<List<CopywritingInfo>> GetAllCopywritingInfo()
        {
            return await _context.CopywritingInfo
                .Where(b => b.IsDeleted == 0)
                .ToListAsync();
        }
    }
}