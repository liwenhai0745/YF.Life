using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using YF.Life.Localization.Life;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace YF.Life.Pages
{
    public abstract class LifePageBase : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<LifeResource> L { get; set; }
    }
}
