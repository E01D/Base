using System;
using System.Collections;
using System.Collections.Generic;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Exts.E01D.Collections
{
    public static class StandardCollectionExts
    {
        public static bool AddDistinct<T>(this IList<T> list, T value)
        {
            return XStandardCollections.Api.AddDistinct(list, value);
        }

        public static bool AddDistinct<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
        {
            return XStandardCollections.Api.AddDistinct(list, value, comparer);
        }

        /// <summary>
        /// Adds the elements of the specified collection to the specified generic <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="initial">The list to add to.</param>
        /// <param name="collection">The collection of elements to add.</param>
        public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
        {
            XStandardCollections.Api.AddRange<T>(initial, collection);
        }

        // this is here because LINQ Bridge doesn't support Contains with IEqualityComparer<T>
        public static bool ContainsValue<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
        {
            return XStandardCollections.Api.ContainsValue(source, value, comparer);
        }

        public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
        {
            return XStandardCollections.Api.AddRangeDistinct(list, values, comparer);
        }

        public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return XStandardCollections.Api.IndexOf(collection, predicate);
        }

        public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer)
        {
            return XStandardCollections.Api.Contains(list, value, comparer);
        }

        public static int IndexOfReference<T>(this List<T> list, T item)
        {
            return XStandardCollections.Api.IndexOfReference(list, item);
        }

#if HAVE_FAST_REVERSE
        // faster reverse in .NET Framework with value types - https://github.com/JamesNK/Newtonsoft.Json/issues/1430
        public static void FastReverse<T>(this List<T> list)
        {
            
        }
#endif
    }
}
