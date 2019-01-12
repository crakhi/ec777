using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace com.empower.Controllers
{
    public abstract class empowerControllerBase: AbpController
    {
        protected empowerControllerBase()
        {
            LocalizationSourceName = empowerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
