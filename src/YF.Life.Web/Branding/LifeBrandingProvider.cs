using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace YF.Life.Branding
{
    [Dependency(ReplaceServices = true)]
    public class LifeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Life";

    }
}
