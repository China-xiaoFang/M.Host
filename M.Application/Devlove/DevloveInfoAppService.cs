using M.Application.Devlove.Dto;
using M.Helper.Model;
using M.Model.Db;
using M.Model.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace M.Application.Devlove
{
    /// <summary>
    /// 表白小工具信息服务
    /// </summary>
    [Route("api/DevloveInfo")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    public class DevloveInfoAppService
    {
        private readonly MChenVipDbContext _context;

        public DevloveInfoAppService(MChenVipDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有表白小工具信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllDevloveInfo")]
        public async Task<GetAllDevloveInfoResultDto> GetAllDevloveInfo()
        {
            var listDto = await _context.DevloveInfo
                .Where(d => d.IsDeleted == 0)
                .ToListAsync();
            return new GetAllDevloveInfoResultDto()
            {
                ResultListDto = listDto,
                Count = listDto.Count()
            };
        }

        /// <summary>
        /// 根据QQ得到表白小工具信息
        /// </summary>
        /// <param name="dLQQ">QQ</param>
        /// <returns></returns>
        [HttpGet("GetDevloveInfoByDLQQ")]
        public async Task<DevloveInfo> GetDevloveInfoByDLQQ(string dLQQ)
        {
            return await _context.DevloveInfo
                .Where(d => d.IsDeleted == 0)
                .FirstOrDefaultAsync(d => d.DLQQ.Equals(dLQQ));
        }

        /// <summary>
        /// 添加表白小工具信息
        /// </summary>
        /// <param name="devloveInfo">表白小工具信息类</param>
        /// <returns></returns>
        [HttpPost("CreateDevloveInfo")]
        public async Task<ResultDto> CreateDevloveInfo(DevloveInfo devloveInfo)
        {
            await _context.DevloveInfo.AddAsync(devloveInfo);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }

        /// <summary>
        /// 修改表白小工具信息
        /// </summary>
        /// <param name="devloveInfo">表白小工具信息类</param>
        /// <returns></returns>
        [HttpPut("UpdateDevloveInfo")]
        public async Task<ResultDto> UpdateDevloveInfo(DevloveInfo devloveInfo)
        {
            _context.DevloveInfo.Update(devloveInfo);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }

        /// <summary>
        /// 删除表白小工具信息
        /// </summary>
        /// <param name="devloveInfo">表白小工具信息类</param>
        /// <returns></returns>
        [HttpDelete("DeleteDevloveInfo")]
        public async Task<ResultDto> DeleteDevloveInfo(DevloveInfo devloveInfo)
        {
            devloveInfo.IsDeleted = 1;
            return await UpdateDevloveInfo(devloveInfo);
        }

        /// <summary>
        /// 彻底删除表白小工具信息
        /// </summary>
        /// <param name="devloveInfo">表白小工具信息类</param>
        /// <returns></returns>
        [HttpDelete("RemoveDevloveInfo")]
        public async Task<ResultDto> RemoveDevloveInfo(DevloveInfo devloveInfo)
        {
            _context.DevloveInfo.Remove(devloveInfo);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }
    }
}
