using System;
using System.ComponentModel.DataAnnotations;

namespace M.Model
{
    /// <summary>
    /// 默认Entity类
    /// </summary>
    public class DefaultEntity
    {
        /// <summary>
        /// 是否删除 0未删除 1已删除
        /// </summary>
        [Required]
        public int IsDeleted { get; set; } = 0;

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}