using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using modelConfigurator.Authorization;

namespace modelConfigurator
{
    [DependsOn(
        typeof(modelConfiguratorCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class modelConfiguratorApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<modelConfiguratorAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(modelConfiguratorApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
