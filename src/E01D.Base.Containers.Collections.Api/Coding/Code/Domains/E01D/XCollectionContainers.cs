using System;
using Root.Coding.Code.Api.E01D.Base.Containers;
using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XCollectionContainers
    {
        public static CollectionContainerApi_I Api { get; set; } = new CollectionContainerApi();

        public static AddResult_I<T> Add<T>(CollectionContainer_I container, T objectToAdd)
        {
            return Api.Add(container, objectToAdd);
        }

        public static void Enumerate(CollectionContainer_I container, Action<object> action)
        {
            Api.Enumerate(container, action);
        }

        public static void Enumerate<T>(CollectionContainer_I container, Action<T> action)
        {
            Api.Enumerate(container, action);
        }

        public static void Enumerate<T>(CollectionContainer_I<T> container, Action<T> action)
        {
            Api.Enumerate(container, action);
        }

        public static RemoveResult_I<T> Remove<T>(CollectionContainer_I container, T objectToRemove)
        {
            return Api.Remove(container, objectToRemove);
        }
    }
}
