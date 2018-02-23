using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Configurational;

namespace Root.Code.Exts.E01D.Configurational
{
    public static class ConfigurationBuildContextExts
    {
        public static ConfigurationBuildContext SetBasePath(this ConfigurationBuildContext context, string basePath)
        {
            return XConfigurational.Api.Building.SetBasePath(context, basePath);
        }
    }
}
