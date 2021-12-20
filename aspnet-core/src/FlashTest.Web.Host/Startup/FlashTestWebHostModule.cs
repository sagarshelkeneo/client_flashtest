using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlashTest.Configuration;

namespace FlashTest.Web.Host.Startup
{
    [DependsOn(
       typeof(FlashTestWebCoreModule))]
    public class FlashTestWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FlashTestWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FlashTestWebHostModule).GetAssembly());
        }
    }
}
