using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlashTest.Authorization;

namespace FlashTest
{
    [DependsOn(
        typeof(FlashTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FlashTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FlashTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FlashTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
