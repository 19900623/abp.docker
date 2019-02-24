using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Bpo.Controllers
{
    public abstract class BpoControllerBase: AbpController
    {
        protected BpoControllerBase()
        {
            LocalizationSourceName = BpoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
