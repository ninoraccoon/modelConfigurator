using System.Threading.Tasks;
using Abp.Application.Services;
using modelConfigurator.Sessions.Dto;

namespace modelConfigurator.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
