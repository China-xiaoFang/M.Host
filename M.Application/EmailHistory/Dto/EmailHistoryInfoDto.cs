using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M.Application.EmailHistory.Dto
{
    /// <summary>
    /// 邮件历史信息类
    /// </summary>
    public class EmailHistoryInfoDto
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EHID { get; set; }

        /// <summary>
        /// 收件人账号
        /// </summary>
        [Required]
        public string RecipientId { get; set; }

        /// <summary>
        /// 邮件内容
        /// </summary>
        [Required]
        public string EmailBody { get; set; }
    }
}
