using E01D.Base.Data.Api.Coding.Code.Api.E01D.Base.Data.Layers;
using Root.Coding.Code.Api.E01D.Base.Data;

namespace Root.Coding.Code.Api.E01D.Base
{
    public interface DataSystemApi_I
    {
        //DataConnectionApi_I Connections { get; set; }

        LayerApi_I Layers { get; set; }
        ConfigurationalApi Configurational { get; set; }

        void LoadApis();
        object GetApi<T>();
        DataLayerApi_I GetApiForModel<T>();
    }
}
