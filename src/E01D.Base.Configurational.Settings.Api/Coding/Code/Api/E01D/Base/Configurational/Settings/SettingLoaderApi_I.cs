using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational.Settings
{
    public interface SettingLoaderApi_I<TSourceContext>
    {
        void Load(TSourceContext source);
    }
}
