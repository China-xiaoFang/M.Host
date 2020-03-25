
namespace M.Application.EmailHistory.Dto
{
    /// <summary>
    /// 添加邮件历史信息类
    /// </summary>
    public class createEmailHistoryInfoDto
    {
        /// <summary>
        /// 收件人账号
        /// </summary>
        public string RecipientId { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        public string EmailBody { get; set; }
    }
}
