using YF.Life.Localization.Life;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace YF.Life.Pages
{
    public abstract class LifePageModelBase : AbpPageModel
    {
        protected LifePageModelBase()
        {
            LocalizationResourceType = typeof(LifeResource);
        }
    }
}