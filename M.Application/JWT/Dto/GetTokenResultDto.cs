using M.Helper.Model;

namespace M.Application.JWT.Dto
{
    public class GetTokenResultDto : ResultDto
    {
        public string JWT { get; set; }
    }
}