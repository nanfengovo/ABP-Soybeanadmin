using ABP_Admin.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABP_Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABP_AdminController : AbpControllerBase
{
    protected ABP_AdminController()
    {
        LocalizationResource = typeof(ABP_AdminResource);
    }
}
