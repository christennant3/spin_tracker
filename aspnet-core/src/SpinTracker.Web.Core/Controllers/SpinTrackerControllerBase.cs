using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SpinTracker.Controllers
{
    public abstract class SpinTrackerControllerBase: AbpController
    {
        protected SpinTrackerControllerBase()
        {
            LocalizationSourceName = SpinTrackerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
