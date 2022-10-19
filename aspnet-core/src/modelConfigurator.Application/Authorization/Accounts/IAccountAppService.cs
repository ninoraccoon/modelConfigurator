using System.Threading.Tasks;
using Abp.Application.Services;
using modelConfigurator.Authorization.Accounts.Dto;

namespace modelConfigurator.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
