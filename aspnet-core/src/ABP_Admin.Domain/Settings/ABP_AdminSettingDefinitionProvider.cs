using Volo.Abp.Settings;

namespace ABP_Admin.Settings;

public class ABP_AdminSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABP_AdminSettings.MySetting1));
    }
}
