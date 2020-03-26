using M.Helper.Model;
using System.Collections.Generic;

namespace M.Application.EmailHistory.Dto
{
    /// <summary>
    /// 得到所有邮件历史信息返回结果
    /// </summary>
    public class GetAllEmailHistoryResultDto : ResultDto
    {
        /// <summary>
        /// 返回结果集合
        /// </summary>
        public List<EmailHistoryInfoDto> ResultListDto { get; set; }

        /// <summary>
        /// 返回结果总数
        /// </summary>
        public int Count { get; set; }
    }
}