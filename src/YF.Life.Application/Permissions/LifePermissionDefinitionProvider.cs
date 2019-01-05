using YF.Life.Localization.Life;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace YF.Life.Permissions
{
    public class LifePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LifePermissions.GroupName);

            //Define your own permissions here. Examaple:
            //myGroup.AddPermission(LifePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LifeResource>(name);
        }
    }
}
