using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using YF.Life.Localization.Life;
using Volo.Abp.UI.Navigation;

namespace YF.Life.Menus
{
    public class LifeMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<LifeResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Life.Home", l["Menu:Home"], "/"));
        }
    }
}
