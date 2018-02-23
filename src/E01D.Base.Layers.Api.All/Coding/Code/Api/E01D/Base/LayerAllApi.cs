using Root.Coding.Code.Api.E01D.Base.Layers;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class LayerAllApi
    {
        public ContainerLayersApi Containers => XContainerLayers.Api;
        
    }
}
