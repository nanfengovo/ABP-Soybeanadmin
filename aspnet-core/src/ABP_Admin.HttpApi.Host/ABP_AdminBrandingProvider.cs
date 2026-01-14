using Microsoft.Extensions.Localization;
using ABP_Admin.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABP_Admin;

[Dependency(ReplaceServices = true)]
public class ABP_AdminBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ABP_AdminResource> _localizer;

    public ABP_AdminBrandingProvider(IStringLocalizer<ABP_AdminResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
