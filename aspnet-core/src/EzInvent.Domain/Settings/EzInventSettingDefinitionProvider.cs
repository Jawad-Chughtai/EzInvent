using Volo.Abp.Settings;

namespace EzInvent.Settings;

public class EzInventSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EzInventSettings.MySetting1));
    }
}
