using EzInvent.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EzInvent.Permissions;

public class EzInventPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EzInventPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EzInventPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EzInventResource>(name);
    }
}
