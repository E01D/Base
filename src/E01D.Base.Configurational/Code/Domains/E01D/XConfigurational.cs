using Root.Code.Apis.E01D;
using Root.Code.Models.E01D.Configurational;

namespace Root.Code.Domains.E01D
{
    public class XConfigurational
    {
        public static ConfigurationalApi Api { get; set; } = new ConfigurationalApi();

        


        

        public ConfigurationBuildContext Build()
        {
            return Api.Building.Build();
        }
    }
}
