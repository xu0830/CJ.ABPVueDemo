using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CJ.ABPVueDemo.Controllers
{
    public abstract class ABPVueDemoControllerBase: AbpController
    {
        protected ABPVueDemoControllerBase()
        {
            LocalizationSourceName = ABPVueDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
