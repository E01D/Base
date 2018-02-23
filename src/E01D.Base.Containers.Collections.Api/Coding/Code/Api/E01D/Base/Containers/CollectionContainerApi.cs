using System;
using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Containers
{
    public class CollectionContainerApi: CollectionContainerApi_I
    {
        public void Enumerate(CollectionContainer_I container, Action<object> action)
        {
            
        }

        public void Enumerate<T>(CollectionContainer_I<T> container, Action<T> action)
        {
            
        }

        public AddResult_I<T> Add<T>(CollectionContainer_I container, T objectToAdd)
        {
            throw new NotImplementedException();
        }

        public RemoveResult_I<T> Remove<T>(CollectionContainer_I container, T objectToRemove)
        {
            throw new NotImplementedException();
        }


        public void Enumerate<T>(CollectionContainer_I container, Action<T> action)
        {
            throw new NotImplementedException();
        }

        public T Current<T>(CollectionContainer_I<T> container, EnumerationState_I state)
        {
            throw new NotImplementedException();
        }

        public T MoveNext<T>(CollectionContainer_I<T> container, EnumerationState_I state)
        {
            throw new NotImplementedException();
        }

        public EnumerationState_I Enumerate<T>(CollectionContainer_I<T> container)
        {
            throw new NotImplementedException();
        }
    }
}
