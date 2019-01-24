using Abp.Application.Services.Dto;

namespace CJ.ABPVueDemo.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

