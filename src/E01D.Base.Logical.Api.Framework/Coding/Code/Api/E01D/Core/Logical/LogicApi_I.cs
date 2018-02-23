using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Api.E01D.Base.Layers;
using Root.Coding.Code.Framework.E01D.Typing;
using Root.Coding.Code.Models.E01D.Base.Pocos;

namespace Root.Coding.Code.Api.E01D.Core.Logical
{
    [Categorize] // This means that all types that extended from this interface need to be put into a list so they can be found later.
    public interface LogicApi_I: BasicLayerApi_I
    {
        
    }

    [Categorize] // This means that all types that extended from this interface need to be put into a list so they can be found later.
    public interface LogicApi_I<T> : BasicLayerApi_I<T>
        where T : Poco_I
    {

    }
}
