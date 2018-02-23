using Root.Code.Models.E01D.Core.IO;
using Root.Coding.Code.Api.E01D.Base.Configurational;
using Root.Coding.Code.Api.E01D.Base.Configurational.Settings.Building;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Base.Configurational.Settings.Files
{
    public static class FileSettingBuilderExts
    {
        public static SettingBuilderApi_I SetBasePath(this SettingBuilderApi_I builder, DirectoryPath path)
        {
            return XFileSettings.SetBasePath(builder, path);
        }
    }
}
