using Root.Coding.Code.Api.E01D.Base.Data.Layers;
using Root.Coding.Code.Api.E01D.Base.Layers;

namespace Root.Coding.Code.Api.E01D.Base.Data
{
    public class LayerApi
    {
        public BasicLayerApi_I Basic { get; set; } = new BasicDataLayerApi();
    }
}
