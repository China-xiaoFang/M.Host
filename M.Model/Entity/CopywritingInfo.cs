using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M.Model.Entity
{
    /// <summary>
    /// 文案信息类
    /// </summary>
    public class CopywritingInfo : DefaultEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 文案内容
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }
    }
}