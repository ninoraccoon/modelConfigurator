using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using modelConfigurator.Configuration;

namespace modelConfigurator.Web.Host.Startup
{
    [DependsOn(
       typeof(modelConfiguratorWebCoreModule))]
    public class modelConfiguratorWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public modelConfiguratorWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(modelConfiguratorWebHostModule).GetAssembly());
        }
    }
}
