using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Api.E01D.Base.Configurational.Settings.Building;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Configurational.Settings;

namespace Root.Coding.Code.Api.E01D.Base.Configurational.Settings
{
    public class FileSettingsApi
    {
        public SettingBuilderApi_I SetBasePath(SettingBuilderApi_I builder, DirectoryPath path)
        {
            // It cannot get the configuration global context as it would
            // break the pattern of all being  all encompasing.
            var globalContext = XSettings.Api.Contexts.Get();

            globalContext.BasePath = path;



            return builder;
        }
    }
}
