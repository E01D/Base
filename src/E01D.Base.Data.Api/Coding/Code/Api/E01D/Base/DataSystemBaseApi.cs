using E01D.Base.Data.Api.Coding.Code.Api.E01D.Base.Data.Layers;
using Root.Coding.Code.Api.E01D.Base.Data;
using Root.Coding.Code.Api.E01D.Base.Layers;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Data.Contexts;

namespace Root.Coding.Code.Api.E01D.Base
{
    public class DataSystemBaseApi
    {
        public LayerApi Layers { get; set; } = new LayerApi();

        public void LoadApis()
        {
            var context = XContextual.GetGlobal<DataGlobalContext_I>();

            var dictionary = context.DataApis;

            XApis.Api.LoadApis(typeof(DataLayerApi_I), dictionary);

            foreach (var keyPair in dictionary)
            {
                var value = keyPair.Value;

                var type = value.GetType();

                var interfaces = type.GetInterfaces();

                var apiType = typeof(BasicLayerApi_I<>);

                for (int i = 0; i < interfaces.Length; i++)
                {
                    var interface1 = interfaces[i];

                    if (!interface1.IsGenericType) continue;

                    if (interface1.GetGenericTypeDefinition() == apiType)
                    {
                        var args = interface1.GenericTypeArguments;

                        var modelType = args[0];

                        var modelTypeId = XTypes.GetTypeId(modelType);

                        context.DataApisByModelType.Add(modelTypeId.Value, keyPair.Value);
                    }

                }
            }

            //XApis.LoadAttributedApis(typeof(DataApiAttribute), dictionary);

        }

        public DataLayerApi_I GetApiForModel<T>()
        {
            var context = XContextual.GetGlobal<DataGlobalContext_I>();

            DataLayerApi_I api = null;

            var modelTypeId = XTypes.GetTypeId(typeof(T));

            if (context.DataApisByModelType.TryGetValue(modelTypeId.Value, out object apiObject))
            {
                api = (DataLayerApi_I) apiObject;
            }

            return api;
        }
    }
}
