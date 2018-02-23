using System;
using Root.Coding.Code.Api.E01D.Base.Containers;
using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Models.E01D.Base.Errors;

namespace Root.Coding.Code.Api.E01D.Base.Errors
{
    public class ErrorCollectionApi
    {
        [ContainerAdd]
        public void Add(ErrorCollection_I collection, Error error)
        {
            collection.Items.Add(error);
        }

        [ContainerEnumerate]
        public void Enumerate(ErrorCollection_I errorCollection, Action<Error_I> action)
        {
            for (int i = 0; i < errorCollection.Items.Count; i++)
            {
                action(errorCollection.Items[i]);
            }
        }

        [ContainerAdd]
        public void Remove(ErrorCollection_I collection, Error_I error)
        {
            collection.Items.Add(error);
        }
    }
}
