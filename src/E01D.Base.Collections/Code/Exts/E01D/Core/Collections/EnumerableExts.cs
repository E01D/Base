using System;
using System.Collections.Generic;
using Root.Code.Domains.E01D;

namespace Root.Code.Exts.E01D.Core.Collections
{
    public static class EnumerableExts
    {
        public static IEnumerable<T> Inverse<T>(this IEnumerable<T> collection)
        {
            return XCollections.Enumerables.Inverse(collection);
        }

        public static IEnumerable<T> TraverseList<T>(this T root, Func<T, T> getNext) where T : class
        {
            return XCollections.Enumerables.TraverseList(root, getNext);
        }

        public static IEnumerable<T> TraverseTree<T>(this T root, Func<T, IEnumerable<T>> childrenSource)
        {
            return XCollections.Enumerables.TraverseTree(root, childrenSource);
        }

        public static IEnumerable<T> TraverseTreeDepth<T>(this T root, Func<T, IEnumerable<T>> childrenSource)
        {
            return XCollections.Enumerables.TraverseTreeDepth(root, childrenSource);
        }
    }
}
