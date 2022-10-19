using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using modelConfigurator.Configuration;
using modelConfigurator.EntityFrameworkCore;
using modelConfigurator.Migrator.DependencyInjection;

namespace modelConfigurator.Migrator
{
    [DependsOn(typeof(modelConfiguratorEntityFrameworkModule))]
    public class modelConfiguratorMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public modelConfiguratorMigratorModule(modelConfiguratorEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(modelConfiguratorMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                modelConfiguratorConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(modelConfiguratorMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
