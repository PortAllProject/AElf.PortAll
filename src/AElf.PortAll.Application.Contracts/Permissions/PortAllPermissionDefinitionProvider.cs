using AElf.PortAll.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AElf.PortAll.Permissions
{
    public class PortAllPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(PortAllPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(PortAllPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PortAllResource>(name);
        }
    }
}
