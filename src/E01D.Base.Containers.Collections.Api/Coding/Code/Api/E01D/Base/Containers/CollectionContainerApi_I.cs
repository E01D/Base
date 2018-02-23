using System;
using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Containers
{
    public interface CollectionContainerApi_I
    {
        AddResult_I<T> Add<T>(CollectionContainer_I container, T objectToAdd);

        void Enumerate(CollectionContainer_I container, Action<object> action);

        void Enumerate<T>(CollectionContainer_I container, Action<T> action);

        void Enumerate<T>(CollectionContainer_I<T> container, Action<T> action);

        EnumerationState_I Enumerate<T>(CollectionContainer_I<T> container);

        RemoveResult_I<T> Remove<T>(CollectionContainer_I container, T objectToRemove);
        

        T Current<T>(CollectionContainer_I<T> container, EnumerationState_I state);
    }
}
