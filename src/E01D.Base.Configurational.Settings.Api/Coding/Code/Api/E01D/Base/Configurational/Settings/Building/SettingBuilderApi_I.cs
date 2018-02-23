using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational.Settings.Building
{
    public interface SettingBuilderApi_I
    {

        void AddSetting(SettingSourceNode_I node);
        SettingModel Build();
        SettingModel Update();
    }
}
