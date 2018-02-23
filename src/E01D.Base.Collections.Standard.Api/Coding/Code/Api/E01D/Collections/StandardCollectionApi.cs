using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Root.Coding.Code.Api.E01D.Collections.Standard;
using Root.Coding.Code.Domains.E01D;



namespace Root.Coding.Code.Api.E01D.Collections
{
    public class StandardCollectionApi
    {

        public BidirectionalDictionaryApi BidirectionalDictionaries { get; set; } = new BidirectionalDictionaryApi();

        /// <summary>
        /// Determines whether the collection is <c>null</c> or empty.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns>
        /// 	<c>true</c> if the collection is <c>null</c> or empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsNullOrEmpty<T>(ICollection<T> collection)
        {
            if (collection != null)
            {
                return (collection.Count == 0);
            }
            return true;
        }

        /// <summary>
        /// Adds the elements of the specified collection to the specified generic <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="initial">The list to add to.</param>
        /// <param name="collection">The collection of elements to add.</param>
        public void AddRange<T>(IList<T> initial, IEnumerable<T> collection)
        {
            if (initial == null)
            {
                throw new ArgumentNullException(nameof(initial));
            }

            if (collection == null)
            {
                return;
            }

            foreach (T value in collection)
            {
                initial.Add(value);
            }
        }


        //public static void AddRange<T>(this IList<T> initial, IEnumerable collection)
        //{
        //    ValidationUtils.ArgumentNotNull(initial, nameof(initial));

        //    // because earlier versions of .NET didn't support covariant generics
        //    initial.AddRange(collection.Cast<T>());
        //}

        



        public ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
        {
            Type genericConstructorArgument = typeof(IList<>).MakeGenericType(collectionItemType);

            return ResolveEnumerableCollectionConstructor(collectionType, collectionItemType, genericConstructorArgument);
        }

        public ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
        {
            Type genericEnumerable = typeof(IEnumerable<>).MakeGenericType(collectionItemType);
            ConstructorInfo match = null;

            foreach (ConstructorInfo constructor in collectionType.GetConstructors(BindingFlags.Public | BindingFlags.Instance))
            {
                IList<ParameterInfo> parameters = constructor.GetParameters();

                if (parameters.Count == 1)
                {
                    Type parameterType = parameters[0].ParameterType;

                    if (genericEnumerable == parameterType)
                    {
                        // exact match
                        match = constructor;
                        break;
                    }

                    // in case we can't find an exact match, use first inexact
                    if (match == null)
                    {
                        if (parameterType.IsAssignableFrom(constructorArgumentType))
                        {
                            match = constructor;
                        }
                    }
                }
            }

            return match;
        }

        public bool AddDistinct<T>(IList<T> list, T value)
        {
            return AddDistinct(list, value, EqualityComparer<T>.Default);
        }

        public bool AddDistinct<T>(IList<T> list, T value, IEqualityComparer<T> comparer)
        {
            if (ContainsValue(list, value, comparer))
            {
                return false;
            }

            list.Add(value);
            return true;
        }

        // this is here because LINQ Bridge doesn't support Contains with IEqualityComparer<T>
        public bool ContainsValue<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
        {
            if (comparer == null)
            {
                comparer = EqualityComparer<TSource>.Default;
            }

            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            foreach (TSource local in source)
            {
                if (comparer.Equals(local, value))
                {
                    return true;
                }
            }

            return false;
        }

        public bool AddRangeDistinct<T>(IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
        {
            bool allAdded = true;
            foreach (T value in values)
            {
                if (!AddDistinct(list, value, comparer))
                {
                    allAdded = false;
                }
            }

            return allAdded;
        }

        public int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate)
        {
            int index = 0;
            foreach (T value in collection)
            {
                if (predicate(value))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public bool Contains<T>(List<T> list, T value, IEqualityComparer comparer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (comparer.Equals(value, list[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOfReference<T>(List<T> list, T item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (ReferenceEquals(item, list[i]))
                {
                    return i;
                }
            }
            return -1;
        }


        // faster reverse in .NET Framework with value types - https://github.com/JamesNK/Newtonsoft.Json/issues/1430
        public void FastReverse<T>(List<T> list)
        {
            int i = 0;
            int j = list.Count - 1;
            while (i < j)
            {
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
                i++;
                j--;
            }
        }


        private IList<int> GetDimensions(IList values, int dimensionsCount)
        {
            IList<int> dimensions = new List<int>();

            IList currentArray = values;
            while (true)
            {
                dimensions.Add(currentArray.Count);

                // don't keep calculating dimensions for arrays inside the value array
                if (dimensions.Count == dimensionsCount)
                {
                    break;
                }

                if (currentArray.Count == 0)
                {
                    break;
                }

                object v = currentArray[0];
                IList list = v as IList;
                if (list != null)
                {
                    currentArray = list;
                }
                else
                {
                    break;
                }
            }

            return dimensions;
        }

        private void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
        {
            int dimension = indices.Length;
            if (dimension == multidimensionalArray.Rank)
            {
                multidimensionalArray.SetValue(JaggedArrayGetValue(values, indices), indices);
                return;
            }

            int dimensionLength = multidimensionalArray.GetLength(dimension);
            IList list = (IList)JaggedArrayGetValue(values, indices);
            int currentValuesLength = list.Count;
            if (currentValuesLength != dimensionLength)
            {
                throw new Exception("Cannot deserialize non-cubical array as multidimensional array.");
            }

            int[] newIndices = new int[dimension + 1];
            for (int i = 0; i < dimension; i++)
            {
                newIndices[i] = indices[i];
            }

            for (int i = 0; i < multidimensionalArray.GetLength(dimension); i++)
            {
                newIndices[dimension] = i;
                CopyFromJaggedToMultidimensionalArray(values, multidimensionalArray, newIndices);
            }
        }

        private object JaggedArrayGetValue(IList values, int[] indices)
        {
            IList currentList = values;
            for (int i = 0; i < indices.Length; i++)
            {
                int index = indices[i];
                if (i == indices.Length - 1)
                {
                    return currentList[index];
                }
                else
                {
                    currentList = (IList)currentList[index];
                }
            }
            return currentList;
        }

        public Array ToMultidimensionalArray(IList values, Type type, int rank)
        {
            IList<int> dimensions = GetDimensions(values, rank);

            while (dimensions.Count < rank)
            {
                dimensions.Add(0);
            }

            Array multidimensionalArray = Array.CreateInstance(type, dimensions.ToArray());
            CopyFromJaggedToMultidimensionalArray(values, multidimensionalArray, ArrayEmpty<int>());

            return multidimensionalArray;
        }

        // 4.6 has Array.Empty<T> to return a cached empty array. Lacking that in other
        // frameworks, Enumerable.Empty<T> happens to be implemented as a cached empty
        // array in all versions (in .NET Core the same instance as Array.Empty<T>).
        // This includes the internal Linq bridge for 2.0.
        // Since this method is simple and only 11 bytes long in a release build it's
        // pretty much guaranteed to be inlined, giving us fast access of that cached
        // array. With 4.5 and up we use AggressiveInlining just to be sure, so it's
        // effectively the same as calling Array.Empty<T> even when not available.

        [MethodImpl(MethodImplOptions.AggressiveInlining)]

        public T[] ArrayEmpty<T>()
        {
            T[] array = Enumerable.Empty<T>() as T[];
            XDebug.Assert(array != null);
            // Defensively guard against a version of Linq where Enumerable.Empty<T> doesn't
            // return an array, but throw in debug versions so a better strategy can be
            // used if that ever happens.
            return array ?? new T[0];
        }
    }
}
