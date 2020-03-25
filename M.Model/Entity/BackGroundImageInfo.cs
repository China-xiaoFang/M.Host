using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace M.Model.Entity
{
    /// <summary>
    /// 背景图片信息类
    /// </summary>
    public class BackGroundImageInfo
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
