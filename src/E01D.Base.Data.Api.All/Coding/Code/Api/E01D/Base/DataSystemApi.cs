using System.Collections.Generic;
using E01D.Base.Data.Api.Coding.Code.Api.E01D.Base.Data.Layers;
using Root.Coding.Code.Api.E01D.Base.Data;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class DataSystemApi:DataSystemApi_I
    {
        public LayerApi_I Layers { get; set; }

        public ConfigurationalApi Configurational { get; set; } = new ConfigurationalApi();

        public void LoadApis()
        {    
            XDataBase.LoadApis();
        }

        public object GetApi<T>()
        {
            return XDataBase.GetApi<T>();
        }

        public DataLayerApi_I GetApiForModel<T>()
        {
            return XDataBase.GetApiForModel<T>();
        }
    }

    
}
