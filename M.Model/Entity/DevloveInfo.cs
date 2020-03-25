using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M.Model.Entity
{
    /// <summary>
    /// 表白小工具信息类
    /// </summary>
    public class DevloveInfo : DefaultEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DLId { get; set; }

        /// <summary>
        /// 你的名字
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string DLName { get; set; }

        /// <summary>
        /// 爱人的名字
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string DLoveName { get; set; }

        /// <summary>
        /// 想说的话
        /// </summary>
        [Required]
        [MaxLength(128)]
        public string DLInfo { get; set; }

        /// <summary>
        /// 终极表白语
        /// </summary>
        [MaxLength(10)]
        public string DLoveInfo { get; set; } = "我爱你";

        /// <summary>
        /// 年
        /// </summary>
        [Required]
        public string DLYear { get; set; }

        /// <summary>
        /// 月
        /// </summary>
        [Required]
        public string DLMonth { get; set; }

        /// <summary>
        /// 日
        /// </summary>
        [Required]
        public string DLDay { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        [Required]
        public string DLQQ { get; set; }
    }
}
