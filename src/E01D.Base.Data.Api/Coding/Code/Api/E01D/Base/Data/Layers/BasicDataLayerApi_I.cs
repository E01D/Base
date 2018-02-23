using E01D.Base.Data.Api.Coding.Code.Api.E01D.Base.Data.Layers;
using Root.Coding.Code.Api.E01D.Base.Layers;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Api.E01D.Base.Data.Layers
{
    public interface BasicDataLayerApi_I: BasicLayerApi_I
    {
        
    }

    public interface BasicDataLayerApi_I<T> : BasicLayerApi_I<T>, DataLayerApi_I where T: Poco_I
    {
        void Store(T poco);
    }
}
