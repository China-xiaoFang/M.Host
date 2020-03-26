using M.Helper.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace M.Application.JWT.Dto
{
    public class GetTokenResultDto : ResultDto
    {
        public string JWT { get; set; }
    }
}