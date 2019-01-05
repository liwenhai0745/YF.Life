using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace YF.Life.Settings
{
    public class LifeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LifeSettings.MySetting1));

            //设置默认为中文
            context.Add(
             new SettingDefinition(LocalizationSettingNames.DefaultLanguage, "zh-Hans", isVisibleToClients: true)
         );
        }
    }
}
