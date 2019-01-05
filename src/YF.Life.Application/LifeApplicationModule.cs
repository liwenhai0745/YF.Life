using YF.Life.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace YF.Life
{
    [DependsOn(
        typeof(LifeDomainModule),
        typeof(AbpIdentityApplicationModule))]
    public class LifeApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<LifePermissionDefinitionProvider>();
            });

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<LifeApplicationAutoMapperProfile>();
            });
        }
    }
}
