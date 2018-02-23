using Root.Coding.Code.Enums.E01D.Base.Data;
using Root.Coding.Code.Framework.E01D.Typing;

namespace E01D.Base.Data.Api.Coding.Code.Api.E01D.Base.Data.Layers
{
    [Categorize] // This means that all types that extended from this interface need to be put into a list so they can be found later.
    public interface DataLayerApi_I
    {
        DataLayerKind Kind { get; }
    }

    //[Categorize] // This means that all types that extended from this interface need to be put into a list so they can be found later.
    //public interface BasicDataLayerApi_I:BasicLayerApi_I
    //{
        
    //}

    //[Categorize] // This means that all types that extended from this interface need to be put into a list so they can be found later.
    //public interface BasicDataLayerApi_I<T> : BasicLayerApi_I<T>
    //    where T:Poco_I
    //{

    //}
}
