using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Api.E01D.Base.Configurational;
using Root.Coding.Code.Api.E01D.Base.Configurational.Settings;
using Root.Coding.Code.Api.E01D.Base.Configurational.Settings.Building;

namespace Root.Coding.Code.Domains.E01D
{
    public class XFileSettings
    {
        public static FileSettingsApi Api { get; set; } = new FileSettingsApi();


        public static SettingBuilderApi_I SetBasePath(SettingBuilderApi_I builder, DirectoryPath path)
        {
            return Api.SetBasePath(builder, path);
        }
    }
}
