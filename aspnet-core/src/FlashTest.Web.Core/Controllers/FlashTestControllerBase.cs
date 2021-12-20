using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FlashTest.Controllers
{
    public abstract class FlashTestControllerBase: AbpController
    {
        protected FlashTestControllerBase()
        {
            LocalizationSourceName = FlashTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
