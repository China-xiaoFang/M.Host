using M.Helper.Model;

namespace M.Application.EmailHistory.Dto
{
    /// <summary>
    /// 根据收件人账号得到最后一个邮件历史信息返回结果
    /// </summary>
    public class GetLastEmailHistoryInfoByRecipientIdResultDto : ResultDto
    {
        /// <summary>
        /// 邮件历史信息
        /// </summary>
        public EmailHistoryInfoDto EmailHistoryInfo { get; set; }
    }
}
