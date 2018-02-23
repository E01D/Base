using Root.Code.Models.E01D.Configurational;

namespace Root.Code.Apis.E01D.Configurational
{
    public class BuildingApi
    {
        public ConfigurationBuildContext Build()
        {
            return new ConfigurationBuildContext();
        }

        public ConfigurationBuildContext SetBasePath(ConfigurationBuildContext context, string basePath)
        {
            context.BasePath = basePath;

            return context;
        }
    }
}
