using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M.Model.Entity
{
    /// <summary>
    /// 背景图片信息类
    /// </summary>
    public class BackGroundImageInfo : DefaultEntity
    {
        // id Url
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BGId { get; set; }

        /// <summary>
        /// BGUrl
        /// </summary>
        public string BGUrl { get; set; }
    }
}