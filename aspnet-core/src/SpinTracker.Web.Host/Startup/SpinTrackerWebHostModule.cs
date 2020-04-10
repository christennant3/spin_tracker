using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SpinTracker.Configuration;

namespace SpinTracker.Web.Host.Startup
{
    [DependsOn(
       typeof(SpinTrackerWebCoreModule))]
    public class SpinTrackerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SpinTrackerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SpinTrackerWebHostModule).GetAssembly());
        }
    }
}
