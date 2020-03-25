using M.Helper.Model;
using System.Collections.Generic;

namespace M.Application.DevLove.Dto
{
    /// <summary>
    /// 得到所有表白小工具信息
    /// </summary>
    public class GetAllDevLoveInfoResultDto : ResultDto
    {
        /// <summary>
        /// 返回结果集合
        /// </summary>
        public List<DevLoveInfoDto> ResultListDto { get; set; }

        /// <summary>
        /// 返回结果总数
        /// </summary>
        public int Count { get; set; }
    }
}
