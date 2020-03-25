using System.ComponentModel.DataAnnotations;

namespace M.Application.EmailHistory.Dto
{
    /// <summary>
    /// 修改邮件历史信息类
    /// </summary>
    public class UpdateEmailHistoryInfoDto
    {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public int EHID { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        [Required]
        public string EmailBody { get; set; }
    }
}
