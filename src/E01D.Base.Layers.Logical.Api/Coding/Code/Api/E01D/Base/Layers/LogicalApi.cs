using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Layers.Logical;
using Root.Coding.Code.Models.E01D.Base.Types;

namespace Root.Coding.Code.Api.E01D.Base.Layers
{
    public class LogicalApi
    {
        public object GetApi<T>()
        {
            var typeId = XTypes.GetTypeId<T>();

            return typeId.Value == 0 ? null : GetApi(typeId);
        }

        public object GetApi(TypeId_I typeId)
        {
            var contextHost = XContextual.GetGlobal<LogicalGlobalContextHost_I>();

            if (typeId.Value == 0) return null;

            if (contextHost.Logical.LogicApis.TryGetValue(typeId.Value, out object logicObject))
            {
                return logicObject;
            }

            return null;

        }
    }
}
