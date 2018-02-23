using System;
using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Exts.E01D.Base.Containers
{
    /// <summary>
    /// Extends the Collection_I interface and exposes extermely low level collection dynamics to the code base without locking in the codebase to an implementation.
    /// </summary>
    public static class CollectionContainerExts
    {
        /// <summary>
        /// Adds the object to the collection.  
        /// </summary>
        /// <remarks>It is up to the collection implementation to determine how this is done.  This method should be used for business logic and not for low level collection access.</remarks>
        public static AddResult_I<T> Add<T>(this CollectionContainer_I<T> container, T objectToAdd)
        {
            return XCollectionContainers.Add(container, objectToAdd);
        }

        /// <summary>
        /// Iterates through all the items in the collection and attempts to cast the items to the type T.  This is an alternative to supporting the for-each statement.
        /// </summary>
        public static void Enumerate(this CollectionContainer_I container, Action<object> action)
        {
            XCollectionContainers.Enumerate(container, action);
        }

        /// <summary>
        /// Iterates through all the items in the collection and attempts to cast the items to the type T.  This is an alternative to supporting the for-each statement.
        /// </summary>
        public static void Enumerate<T>(this CollectionContainer_I container, Action<T> action)
        {
            XCollectionContainers.Enumerate<T>(container, action);
        }

        

        /// <summary>
        /// Iterates through all the items in the collection and attempts to cast the items to the type T.  This is an alternative to supporting the for-each statement.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="container"></param>
        /// <param name="action"></param>
        public static void Enumerate<T>(this CollectionContainer_I<T> container, Action<T> action)
        {
            XCollectionContainers.Enumerate(container, action);
        }

        /// <summary>
        /// Removes the object from the collection.  
        /// </summary>
        /// <remarks>It is up to the collection implementation to determine how this is done.  This method should be used for business logic and not for low level collection access.</remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="container"></param>
        /// <param name="objectToRemove"></param>
        public static RemoveResult_I<T> Remove<T>(this CollectionContainer_I container, T objectToRemove)
        {
            return XCollectionContainers.Remove(container, objectToRemove);
        }
    }
}
