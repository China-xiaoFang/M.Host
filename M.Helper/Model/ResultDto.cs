using M.Helper.AppConfigurtaion;
using System;

namespace M.Helper.Model
{
    /// <summary>
    /// 通用返回结果类
    /// </summary>
    public class ResultDto
    {
        /// <summary>
        /// 状态
        /// </summary>
        public bool Success { get; set; } = true;

        /// <summary>
        /// 返回信息
        /// </summary>
        public string ResultInfo { get; set; } = "【" + AppConfigurtaionService.Configuration["ProjectInfo:Project_Name"] + "】温馨提示：执行成功！";

        /// <summary>
        /// 状态码
        /// </summary>
        public int StatusCode { get; set; } = 200;

        /// <summary>
        /// 返回时间
        /// </summary>
        public DateTime ResultDateTime { get; set; } = DateTime.Now;
    }
}
