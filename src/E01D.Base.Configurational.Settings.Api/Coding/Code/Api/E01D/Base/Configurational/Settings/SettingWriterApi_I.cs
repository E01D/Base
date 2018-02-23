using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational.Settings
{
    public interface SettingWriterApi_I<TSource, in TSourceContext>
        where TSourceContext: SettingSourceContext_I<TSource>
    {
        void Write(TSourceContext context, SettingNode_I node);
    }
}
