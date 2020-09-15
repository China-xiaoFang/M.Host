using M.Application.DevLove.Dto;
using M.Helper.Model;
using M.Model.Db;
using M.Model.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace M.Application.DevLove
{
    /// <summary>
    /// 表白小工具信息服务
    /// </summary>
    [Route("api/DevLoveInfo")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    //[Authorize(Roles = "Mr.Fang")]
    //[Authorize(policy: "Admin")]
    public class DevLoveInfoAppService
    {
        private readonly FangHuaHostDbContext _context;

        public DevLoveInfoAppService(FangHuaHostDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有表白小工具信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllDevLoveInfo")]
        public async Task<GetAllDevLoveInfoResultDto> GetAllDevLoveInfo()
        {
            var listDto = await _context.DevLoveInfo
                .Where(d => d.IsDeleted == 0)
                .ToListAsync();
            return new GetAllDevLoveInfoResultDto()
            {
                ResultListDto = ModelBindingService.CopyModelList<DevLoveInfoDto, DevLoveInfo>(listDto),
                Count = listDto.Count()
            };
        }

        /// <summary>
        /// 根据QQ得到表白小工具信息
        /// </summary>
        /// <param name="dLQQ">QQ</param>
        /// <returns></returns>
        [HttpGet("GetDevLoveInfoByDLQQ")]
        public async Task<DevLoveInfoDto> GetDevLoveInfoByDLQQ(string dLQQ)
        {
            var devLoveInfo = await _context.DevLoveInfo
                .Where(d => d.IsDeleted == 0)
                .FirstOrDefaultAsync(d => d.DLQQ.Equals(dLQQ));
            return ModelBindingService.CopyModel<DevLoveInfoDto, DevLoveInfo>(devLoveInfo);
        }

        /// <summary>
        /// 添加表白小工具信息
        /// </summary>
        /// <param name="createDevLoveInfoDto">添加表白小工具信息类</param>
        /// <returns></returns>
        [HttpPost("CreateDevLoveInfo")]
        public async Task<ResultDto> CreateDevLoveInfo(CreateDevLoveInfoDto createDevLoveInfoDto)
        {
            // 判断是否存在该QQ
            var devLoveInfo = await _context.DevLoveInfo
                .Where(d => d.IsDeleted == 0)
                .FirstOrDefaultAsync(d => d.DLQQ.Equals(createDevLoveInfoDto.DLQQ));
            if (devLoveInfo != null)
            {
                // 该QQ账号所绑定的信息已存在
                throw new Exception("The information bound to this QQ account already exists.");
            }
            ModelBindingService.CopyModel(devLoveInfo, createDevLoveInfoDto);
            await _context.DevLoveInfo.AddAsync(devLoveInfo);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }

        /// <summary>
        /// 修改表白小工具信息
        /// </summary>
        /// <param name="updateDevLoveInfoDto">修改表白小工具信息类</param>
        /// <returns></returns>
        [HttpPut("UpdateDevLoveInfo")]
        public async Task<ResultDto> UpdateDevLoveInfo(UpdateDevLoveInfoDto updateDevLoveInfoDto)
        {
            // 查询出原有数据
            var devLoveInfo = await _context.DevLoveInfo
                .FindAsync(updateDevLoveInfoDto.DLId);
            if (devLoveInfo != null)
            {
                // 该QQ账号没有绑定的信息
                throw new Exception("The QQ account has no binding information.");
            }
            ModelBindingService.CopyModel(devLoveInfo, updateDevLoveInfoDto);
            _context.DevLoveInfo.Update(devLoveInfo);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }

        /// <summary>
        /// 删除表白小工具信息
        /// </summary>
        /// <param name="DLId">Id</param>
        /// <returns></returns>
        [HttpDelete("DeleteDevLoveInfo")]
        public async Task<ResultDto> DeleteDevLoveInfo(int DLId)
        {
            var devLoveInfo = await _context.DevLoveInfo
                .FindAsync(DLId);
            devLoveInfo.IsDeleted = 1;
            _context.DevLoveInfo.Update(devLoveInfo);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }

        /// <summary>
        /// 彻底删除表白小工具信息
        /// </summary>
        /// <param name="DLId">Id</param>
        /// <returns></returns>
        [HttpDelete("RemoveDevLoveInfo")]
        public async Task<ResultDto> RemoveDevLoveInfo(int DLId)
        {
            var devLoveInfo = await _context.DevLoveInfo
                .FindAsync(DLId);
            _context.DevLoveInfo.Remove(devLoveInfo);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }
    }
}