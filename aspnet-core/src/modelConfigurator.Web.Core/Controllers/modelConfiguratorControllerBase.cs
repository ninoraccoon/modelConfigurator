using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace modelConfigurator.Controllers
{
    public abstract class modelConfiguratorControllerBase: AbpController
    {
        protected modelConfiguratorControllerBase()
        {
            LocalizationSourceName = modelConfiguratorConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
