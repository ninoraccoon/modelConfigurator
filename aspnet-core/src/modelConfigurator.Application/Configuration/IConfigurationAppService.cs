using System.Threading.Tasks;
using modelConfigurator.Configuration.Dto;

namespace modelConfigurator.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
