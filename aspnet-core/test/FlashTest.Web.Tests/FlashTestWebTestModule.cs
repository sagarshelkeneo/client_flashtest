using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FlashTest.EntityFrameworkCore;
using FlashTest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FlashTest.Web.Tests
{
    [DependsOn(
        typeof(FlashTestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FlashTestWebTestModule : AbpModule
    {
        public FlashTestWebTestModule(FlashTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FlashTestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FlashTestWebMvcModule).Assembly);
        }
    }
}