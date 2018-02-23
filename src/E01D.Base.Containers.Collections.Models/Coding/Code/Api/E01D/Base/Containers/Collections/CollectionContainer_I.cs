using Root.Coding.Code.Api.E01D.Base.Containers;

namespace Root.Coding.Code.Api.E01D.Base.Containers.Collections
{
    public interface CollectionContainer_I:Container_I
    {
    }

    public interface CollectionContainer_I<T> : Container_I<T>, CollectionContainer_I
    {
    }
}
