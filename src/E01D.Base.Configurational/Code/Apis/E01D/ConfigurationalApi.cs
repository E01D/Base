using Root.Code.Apis.E01D.Configurational;

namespace Root.Code.Apis.E01D
{
    public class ConfigurationalApi
    {
        public ConfigurationProviderApi ConfigurationProviders { get; set; } = new ConfigurationProviderApi();

        public ConfigurationRootApi ConfigurationRoots { get; set; } = new ConfigurationRootApi();

        //public JsonApi Json { get; set; } = new JsonApi();
        public BuildingApi Building { get; set; }

        
    }
}
