using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SpinTracker.Authorization;

namespace SpinTracker
{
    [DependsOn(
        typeof(SpinTrackerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SpinTrackerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SpinTrackerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SpinTrackerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
