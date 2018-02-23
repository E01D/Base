using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Root.Code.Components.E01D.Core.Collections;
using Root.Code.Exts.E01D.Core.Collections;

namespace Root.Code.Api.E01D.Core.Collections
{
    public class EnumerableApi
    {
        /// <summary>
        /// Gets an empty enumerable collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public ReadOnlyCollection<T> EmptyList<T>()
        {
            return EmptyEnumerable<T>.EmptyList;
        }

        /// <summary>
        /// Gets an empty enumerable dictionary for comparisions.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public ReadOnlyDictionary<TKey, TValue> EmptyDictionary<TKey, TValue>()
        {
            return EmptyDictionaryEnumerable<TKey, TValue>.EmptyDictionary;
        }

        /// <summary>
        /// Concatinates one more array collections together into a single enumerable collection.  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collections"></param>
        /// <returns>A single enumerable collection.</returns>
        public IEnumerable<T> Concat<T>(params IEnumerable<T>[] collections)
        {
            return collections.SelectMany(e => e);
        }

        /// <summary>
        /// Using a yield return pattern, 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public IEnumerable<T> Concat<T>(IEnumerable<T> @this, params T[] values)
        {
            foreach (var item in @this)
            {
                yield return item;
            }

            foreach (var value in values)
            {
                yield return value;
            }
        }

        public IEnumerable<T> Concat<T>(IEnumerable<T> @this, T value)
        {
            foreach (var item in @this)
                yield return item;
            yield return value;
        }

        public IEnumerable<T> Inverse<T>(IEnumerable<T> collection)
        {
            var list = collection as IList<T>;

            if (list != null)
            {
                // No need to reverse method, just for loop to iterate.
                for (var i = list.Count - 1; i >= 0; i--)
                {
                    yield return list[i];
                }
            }
            
            foreach (var item in collection.Reverse())
            {
                yield return item;
            }
            
        }

        public IEnumerable<T> TraverseList<T>(T root, Func<T, T> getNext) where T : class
        {
            for (var current = root; current != null; current = getNext(current))
            {
                yield return current;
            }
        }

        public IEnumerable<T> TraverseTree<T>(T root, Func<T, IEnumerable<T>> getChildren)
        {
            return TraverseTreeDepth(root, getChildren);
        }

        public IEnumerable<T> TraverseTreeDepth<T>(T root, Func<T, IEnumerable<T>> getChildren)
        {
            var stack = new Stack<T>();

            stack.Push(root);

            while (stack.Count != 0)
            {
                var item = stack.Pop();

                yield return item;

                foreach (var child in getChildren(item).Inverse())
                    stack.Push(child);
            }
        }
    }
}
