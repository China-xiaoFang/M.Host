using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M.Model.Entity
{
    /// <summary>
    /// 引导页菜单信息
    /// </summary>
    public class GuidePagesMenuInfo : DefaultEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenuID { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [Required]
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单Url
        /// </summary>
        [Required]
        public string MenuUrl { get; set; }

        /// <summary>
        /// 父级菜单Id
        /// </summary>
        [Required]
        public int ParentId { get; set; } = 0;

        /// <summary>
        /// 菜单排序
        /// </summary>
        [Required]
        public int MenuOrder { get; set; } = 1;
    }
}