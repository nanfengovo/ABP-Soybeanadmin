using ABP_Admin.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABP_Admin.Permissions;

public class ABP_AdminPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABP_AdminPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABP_AdminPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABP_AdminResource>(name);
    }
}
