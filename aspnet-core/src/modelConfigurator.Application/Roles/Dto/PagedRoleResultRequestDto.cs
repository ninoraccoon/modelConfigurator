using Abp.Application.Services.Dto;

namespace modelConfigurator.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

