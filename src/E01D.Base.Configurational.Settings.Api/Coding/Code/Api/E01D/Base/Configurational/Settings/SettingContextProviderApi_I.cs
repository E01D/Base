using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational.Settings
{
    public interface SettingContextProviderApi_I<in TSourceNode, out TSourceContext>
        
    {
        TSourceContext GetContext(SettingModel model, TSourceNode source);
    }
}
