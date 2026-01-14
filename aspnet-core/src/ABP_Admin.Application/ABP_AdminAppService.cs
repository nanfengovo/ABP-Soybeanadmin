using System;
using System.Collections.Generic;
using System.Text;
using ABP_Admin.Localization;
using Volo.Abp.Application.Services;

namespace ABP_Admin;

/* Inherit your application services from this class.
 */
public abstract class ABP_AdminAppService : ApplicationService
{
    protected ABP_AdminAppService()
    {
        LocalizationResource = typeof(ABP_AdminResource);
    }
}
