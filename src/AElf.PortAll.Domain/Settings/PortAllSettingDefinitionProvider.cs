using Volo.Abp.Settings;

namespace AElf.PortAll.Settings
{
    public class PortAllSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PortAllSettings.MySetting1));
        }
    }
}
