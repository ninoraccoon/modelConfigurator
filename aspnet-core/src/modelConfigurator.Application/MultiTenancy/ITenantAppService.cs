using Abp.Application.Services;
using modelConfigurator.MultiTenancy.Dto;

namespace modelConfigurator.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

