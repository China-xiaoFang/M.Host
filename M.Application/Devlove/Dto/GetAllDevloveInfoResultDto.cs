using M.Helper.Model;
using M.Model.Entity;
using System.Collections.Generic;

namespace M.Application.Devlove.Dto
{
    /// <summary>
    /// 得到所有表白小工具信息
    /// </summary>
    public class GetAllDevloveInfoResultDto : ResultDto
    {
        /// <summary>
        /// 返回结果集合
        /// </summary>
        public List<DevloveInfo> ResultListDto { get; set; }

        /// <summary>
        /// 返回结果总数
        /// </summary>
        public int Count { get; set; }
    }
}
