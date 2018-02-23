using System;

namespace Root.Code.Api.E01D.Core.Collections
{
    /// <summary>
    /// Base interface for all collections, defining enumerators, size, and synchronization methods.
    /// </summary>
    public interface CollectionApi_I
    {
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        /// <param name="item"></param>
        void Add<T>(T item);

        /// <summary>
        /// Clears the collection
        /// </summary>
        void Clear();

        /// <summary>
        /// Determines if the collection contains the element.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Contains<T>(T item);

        /// <summary>
        /// Copies a collection into an Array, starting at a particular index into the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        void CopyTo<T>(T[] array, int arrayIndex);

        /// <summary>
        /// Copies a collection into an Array, starting at a particular index into the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        void CopyTo(Array array, int index);


        /// <summary>
        /// Removes an element from the collection
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>

        bool Remove<T>(T item);
        
    }
}
