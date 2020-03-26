using M.Application.EmailHistory.Dto;
using M.Helper.AppConfigurtaion;
using M.Helper.Email;
using M.Helper.Model;
using M.Model.Db;
using M.Model.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M.Application.EmailHistory
{
    /// <summary>
    /// 邮件历史信息服务
    /// </summary>
    [Route("api/EmailHistoryInfo")]
    [ApiController]
    //[EnableCors("CustomCorsPolicy")]
    //[Authorize(Roles = "Mr.Fang")]
    //[Authorize(policy: "Mr.Fang")]
    public class EmailHistoryInfoAppService
    {
        // HttpGet 查询  HttpPost 新增  HttpPut 修改  HttpDelete 删除

        private readonly MChenVipDbContext _context;
        private readonly EmailServices _emailServices;

        public EmailHistoryInfoAppService(MChenVipDbContext context)
        {
            _context = context;
            _emailServices = new EmailServices();
        }

        /// <summary>
        /// 得到所有邮件历史信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllEmailHistoryInfo")]
        public async Task<GetAllEmailHistoryResultDto> GetAllEmailHistoryInfo()
        {
            var listDto = await _context.EmailHistoryInfo
                .Where(e => e.IsDeleted == 0)
                .ToListAsync();
            return new GetAllEmailHistoryResultDto()
            {
                // 剔除创建时间和删除状态
                ResultListDto = ModelBindingService.CopyModelList<EmailHistoryInfoDto, EmailHistoryInfo>(listDto),
                Count = listDto.Count()
            };
        }

        /// <summary>
        /// 根据收件人账号得到所有邮件历史信息
        /// </summary>
        /// <param name="recipientId">收件人账号</param>
        /// <returns></returns>
        [HttpGet("GetAllEmailHistoryInfoByRecipientId")]
        public async Task<GetAllEmailHistoryResultDto> GetAllEmailHistoryInfoByRecipientId(string recipientId)
        {
            var listDto = await _context.EmailHistoryInfo
                .Where(e => e.IsDeleted == 0)
                .Where(e => e.RecipientId.Equals(recipientId))
                .ToListAsync();
            return new GetAllEmailHistoryResultDto()
            {
                ResultListDto = ModelBindingService.CopyModelList<EmailHistoryInfoDto, EmailHistoryInfo>(listDto),
                Count = listDto.Count()
            };
        }

        /// <summary>
        /// 根据收件人账号得到最后一个邮件历史信息
        /// </summary>
        /// <param name="recipientId">收件人账号</param>
        /// <returns></returns>
        [HttpGet("GetLastEmailHistoryInfoByRecipientId")]
        public async Task<GetLastEmailHistoryInfoByRecipientIdResultDto> GetLastEmailHistoryInfoByRecipientId(string recipientId)
        {
            var emailhistoryInfo = await _context.EmailHistoryInfo
                .Where(e => e.IsDeleted == 0)
                .OrderByDescending(e => e.CreateTime)
                .FirstOrDefaultAsync(e => e.RecipientId.Equals(recipientId));
            var result = new GetLastEmailHistoryInfoByRecipientIdResultDto();
            ModelBindingService.CopyModel(result.EmailHistoryInfo, emailhistoryInfo);
            // 判断是否为空
            if (emailhistoryInfo == null)
            {
                result.Success = false;
                result.ResultInfo = string.Format("【{0}】账号暂无邮件历史信息，请检查账号是否正确！如账号准确无误，请联系管理员。", recipientId);
                return result;
            }
            // 判断是否过期（10分钟）
            if (emailhistoryInfo.CreateTime.AddMinutes(10) < DateTime.Now)
            {
                result.Success = false;
                result.ResultInfo = string.Format("【{0}】账号验证码已过期，请重新发送！", recipientId);
                result.EmailHistoryInfo = null;
                return result;
            }
            return result;
        }

        /// <summary>
        /// 添加邮件历史信息
        /// </summary>
        /// <param name="createEmailHistoryInfoDto">添加邮件历史信息类</param>
        /// <param name="isSendEmail">是否发送邮件，默认为发送</param>
        /// <returns></returns>
        [HttpPost("CreateEmailHistoryInfo")]
        public async Task<ResultDto> CreateEmailHistoryInfo(createEmailHistoryInfoDto createEmailHistoryInfoDto, bool? isSendEmail = true)
        {
            // 检测邮箱账号为否为QQ邮箱，并且是否正确
            string expression = AppConfigurtaionService.Configuration["EmailServicesStrings:EmailExpression"];
            if (!Regex.IsMatch(createEmailHistoryInfoDto.RecipientId, expression, RegexOptions.Compiled))
            {
                // 请输入正确的QQ邮箱账号
                throw new Exception("Please enter the correct QQ email account.");
            }
            EmailHistoryInfo emailHistory = new EmailHistoryInfo()
            {
                RecipientId = createEmailHistoryInfoDto.RecipientId,
                EmailBody = createEmailHistoryInfoDto.EmailBody
            };
            // 发送QQ邮件
            if (isSendEmail.Value)
            {
                emailHistory.EmailBody = _emailServices.SendRandomCode(emailHistory.RecipientId);
            }
            await _context.EmailHistoryInfo.AddAsync(emailHistory);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }

        /// <summary>
        /// 修改邮件历史信息
        /// </summary>
        /// <param name="updateEmailHistoryInfoDto">添修改件历史信息类</param>
        /// <returns></returns>
        [HttpPut("UpdateEmailHistoryInfo")]
        public async Task<ResultDto> UpdateEmailHistoryInfo(UpdateEmailHistoryInfoDto updateEmailHistoryInfoDto)
        {
            var emailHistory = await _context.EmailHistoryInfo
                .FindAsync(updateEmailHistoryInfoDto.EHID);
            emailHistory.EmailBody = updateEmailHistoryInfoDto.EmailBody;
            _context.EmailHistoryInfo.Update(emailHistory);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }

        /// <summary>
        /// 删除邮件历史信息
        /// </summary>
        /// <param name="EHID">ID</param>
        /// <returns></returns>
        [HttpDelete("DeleteEmailHistoryInfo")]
        public async Task<ResultDto> DeleteEmailHistoryInfo(int EHID)
        {
            var emailHistory = await _context.EmailHistoryInfo
                .FindAsync(EHID);
            emailHistory.IsDeleted = 1;
            _context.EmailHistoryInfo.Update(emailHistory);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }

        /// <summary>
        /// 彻底删除邮件历史信息
        /// </summary>
        /// <param name="EHID">ID</param>
        /// <returns></returns>
        [HttpDelete("RemoveEmailHistoryInfo")]
        public async Task<ResultDto> RemoveEmailHistoryInfo(int EHID)
        {
            var emailHistory = await _context.EmailHistoryInfo
                .FindAsync(EHID);
            _context.EmailHistoryInfo.Remove(emailHistory);
            return new ResultDto()
            {
                Success = await _context.SaveChangesAsync() > 0 ? true : false
            };
        }
    }
}