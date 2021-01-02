using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace boilerplate.Controllers
{
    public abstract class boilerplateControllerBase: AbpController
    {
        protected boilerplateControllerBase()
        {
            LocalizationSourceName = boilerplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
