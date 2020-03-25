using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace M.Model.Entity
{
    /// <summary>
    /// 访问历史信息类
    /// </summary>
    public class AccessHistoryLog : DefaultEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AHId { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 访问Url
        /// </summary>
        [Required]
        public string Url { get; set; }
    }
}
