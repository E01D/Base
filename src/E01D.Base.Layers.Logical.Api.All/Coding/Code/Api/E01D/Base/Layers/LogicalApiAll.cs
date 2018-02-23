using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Layers.Logical;

namespace Root.Coding.Code.Api.E01D.Base.Layers
{
    public class LogicalApiAll
    {
        public object GetApi<T>()
        {
            return XLogicBase.GetApi<T>();
        }
    }
}
