using Root.Coding.Code.Api.E01D.Base.Layers;
using Root.Coding.Code.Enums.E01D.Base.Data;
using Root.Coding.Code.Models.E01D.Base.Data;
using Root.Coding.Code.Models.E01D.Base.Layers;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Api.E01D.Base.Data.Layers
{
    public class BasicDataLayerApi: BasicLayerApi<DataLayerType>, BasicDataLayerApi_I
    {
        public override bool GetApi<T>(LayerType layerType, out BasicLayerApi_I<T> basicLayer)
        {
            throw new System.Exception("Not implemeted");
        }
    }

    public abstract class BasicDataLayerApi<T>:BasicLayerApi<DataLayerType, T>, BasicDataLayerApi_I<T> where T : Poco_I
    {
        public DataLayerKind Kind => DataLayerKind.Basic;

        public void Store(T poco)
        {
            OnStore(poco);
        }

        public abstract void OnStore(T poco);
    }
}
