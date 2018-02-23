using System;
using System.Collections.Generic;
using Root.Code.Api.E01D.Core.Collections;
using Root.Code.Components.E01D.Core.Collections;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.Collections.Generic;

namespace Root.Code.Exts.E01D.Core.Collections
{
    public static class ListExt
    {
        public static void Add<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {
            XLists.Api.Add(list, item);
        }

        public static T GetItem<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index)
        {
            return XLists.Api.GetItem(list, index);
        }

        public static T GetItem<T>(this List_I<T> list, int index)
        {
            return XLists.Api.GetItem(list, index);
        }

        public static void AddEnumerable<T>(this Models.E01D.Core.Collections.Generic.List<T> list, IEnumerable<T> enumerable)
        {
            XLists.Api.AddEnumerable(list, enumerable);
        }

        public static void AddRange<T>(this Models.E01D.Core.Collections.Generic.List<T> list, IEnumerable<T> collection)
        {
            XLists.Api.AddRange(list, collection);
        }

        public static int BinarySearch<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {

            return XLists.Api.BinarySearch(list, item);
        }

        public static int BinarySearch<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item, IComparer<T> comparer)
        {

            return XLists.Api.BinarySearch(list, item, comparer);
        }

        public static int BinarySearch<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index, int count, T item, IComparer<T> comparer)
        {
            return XLists.Api.BinarySearch(list, index, count, item, comparer);
        }

        // Clears the contents of List.
        public static void Clear<T>(this Models.E01D.Core.Collections.Generic.List<T> list)
        {
            XLists.Api.Clear(list);
        }

        public static bool Contains<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {
            return XLists.Api.Contains(list, item);
        }

        public static Models.E01D.Core.Collections.Generic.List<T> Copy<T>(this Models.E01D.Core.Collections.Generic.List<T> list)
        {
            return XLists.Api.Copy(list);
        }

        public static void CopyTo<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index, T[] array, int arrayIndex, int count)
        {
            XLists.Api.CopyTo(list, index, array, arrayIndex, count);
        }

        public static void EnsureCapacity<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int min)
        {
            XLists.Api.EnsureCapacity(list, min);
        }

        public static bool Exists<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            return XLists.Api.Exists(list, match);
        }

        public static T Find<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            return XLists.Api.Find(list, match);
        }

        public static Models.E01D.Core.Collections.Generic.List<T> FindAll<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            return XLists.Api.FindAll(list, match);
        }

        public static int FindIndex<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            return XLists.Api.FindIndex(list, match);
        }

        public static int  FindIndex<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int startIndex, Predicate<T> match)
        {
            return XLists.Api.FindIndex(list, startIndex, match);
        }

        public static int FindIndex<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int startIndex, int count, Predicate<T> match)
        {
            return XLists.Api.FindIndex(list, startIndex, count, match);
        }

        public static T FindLast<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            return XLists.Api.FindLast(list, match);
        }

        public static int FindLastIndex<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {

            return XLists.Api.FindLastIndex(list, match);
        }

        public static int  FindLastIndex<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int startIndex, Predicate<T> match)
        {

            return XLists.Api.FindLastIndex(list, startIndex, match);
        }

        public static int  FindLastIndex<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int startIndex, int count, Predicate<T> match)
        {
            return XLists.Api.FindLastIndex(list, startIndex, count, match);
        }

        public static ListEnumerator<T> GetEnumerator<T>(this Models.E01D.Core.Collections.Generic.List<T> list)
        {
            return XLists.Api.GetEnumerator(list);
        }

        

        public static Models.E01D.Core.Collections.Generic.List<T> GetRange<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index, int count)
        {
            return XLists.Api.GetRange(list, index, count);
        }

        // Returns the index of the first occurrence of a given value in a range of
        // this list. The list is searched forwards from beginning to end.
        // The elements of the list are compared to the given value using the
        // Object.Equals method.
        // 
        // This method uses the Array.IndexOf method to perform the
        // search.
        // 
        public static int IndexOf<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {
            return XLists.Api.IndexOf(list, item);
        }

        // Returns the index of the first occurrence of a given value in a range of
        // this list. The list is searched forwards, starting at index
        // index and ending at count number of elements. The
        // elements of the list are compared to the given value using the
        // Object.Equals method.
        // 
        // This method uses the Array.IndexOf method to perform the
        // search.
        // 
        public static int IndexOf<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item, int index)
        {
            return XLists.Api.IndexOf(list, item);
        }

        // Returns the index of the first occurrence of a given value in a range of
        // this list. The list is searched forwards, starting at index
        // index and upto count number of elements. The
        // elements of the list are compared to the given value using the
        // Object.Equals method.
        // 
        // This method uses the Array.IndexOf method to perform the
        // search.
        // 
        public static int IndexOf<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item, int index, int count)
        {
            return XLists.Api.IndexOf(list, item, index, count);
        }

        // Inserts an element into this list at a given index. The size of the list
        // is increased by one. If required, the capacity of the list is doubled
        // before inserting the new element.
        // 
        public static void Insert<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index, T item)
        {
            XLists.Api.Insert(list, index, item);
        }

        // Inserts the elements of the given collection at a given index. If
        // required, the capacity of the list is increased to twice the previous
        // capacity or the new size, whichever is larger.  Ranges may be added
        // to the end of the list by setting index to the List's size.
        //
        public static void InsertRange<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index, IEnumerable<T> collection)
        {
            XLists.Api.InsertRange(list, index, collection);
        }

        public static void Iterate<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Action<T> action)
        {
            XLists.Api.Iterate(list, action);
        }

        public static TOut Iterate<T, TOut>(this Models.E01D.Core.Collections.Generic.List<T> list, FuncOut<T, TOut, bool> action)
        {
            return XLists.Api.Iterate(list, action);
        }

        // Returns the index of the last occurrence of a given value in a range of
        // this list. The list is searched backwards, starting at the end 
        // and ending at the first element in the list. The elements of the list 
        // are compared to the given value using the Object.Equals method.
        // 
        // This method uses the Array.LastIndexOf method to perform the
        // search.
        // 
        public static int LastIndexOf<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {
            return XLists.Api.LastIndexOf(list, item);
        }

        // Returns the index of the last occurrence of a given value in a range of
        // this list. The list is searched backwards, starting at index
        // index and ending at the first element in the list. The 
        // elements of the list are compared to the given value using the 
        // Object.Equals method.
        // 
        // This method uses the Array.LastIndexOf method to perform the
        // search.
        // 
        public static int LastIndexOf<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item, int index)
        {
            return XLists.Api.LastIndexOf(list, item, index);
        }

        // Returns the index of the last occurrence of a given value in a range of
        // this list. The list is searched backwards, starting at index
        // index and upto count elements. The elements of
        // the list are compared to the given value using the Object.Equals
        // method.
        // 
        // This method uses the Array.LastIndexOf method to perform the
        // search.
        // 
        public static int LastIndexOf<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item, int index, int count)
        {
            return XLists.Api.LastIndexOf(list, item, index, count);
        }

        // Removes the element at the given index. The size of the list is
        // decreased by one.
        // 
        public static bool Remove<T>(this Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {
            return XLists.Api.Remove(list, item);
        }

        // This method removes all items which matches the predicate.
        // The complexity is O(n).   
        public static int RemoveAll<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            return XLists.Api.RemoveAll(list, match);
        }

        // Removes the element at the given index. The size of the list is
        // decreased by one.
        // 
        public static void RemoveAt<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index)
        {
            XLists.Api.RemoveAt(list, index);
        }

        // Removes a range of elements from this list.
        // 
        public static void RemoveRange<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index, int count)
        {
            XLists.Api.RemoveRange(list, index, count);
        }

        // Reverses the elements in this list.
        public static void Reverse<T>(this Models.E01D.Core.Collections.Generic.List<T> list)
        {
            XLists.Api.Reverse(list);
        }

        // Reverses the elements in a range of this list. Following a call to this
        // method, an element in the range given by index and count
        // which was previously located at index i will now be located at
        // index index + (index + count - i - 1).
        // 
        public static void Reverse<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index, int count)
        {
            XLists.Api.Reverse(list, index, count);
        }

        // Sorts the elements in this list.  Uses the default comparer and 
        // Array.Sort.
        public static void Sort<T>(this Models.E01D.Core.Collections.Generic.List<T> list)
        {
            XLists.Api.Sort(list);
        }

        // Sorts the elements in this list.  Uses Array.Sort with the
        // provided comparer.
        public static void Sort<T>(this Models.E01D.Core.Collections.Generic.List<T> list, IComparer<T> comparer)
        {
            XLists.Api.Sort(list, comparer);
        }

        // Sorts the elements in a section of this list. The sort compares the
        // elements to each other using the given IComparer interface. If
        // comparer is null, the elements are compared to each other using
        // the IComparable interface, which in that case must be implemented by all
        // elements of the list.
        // 
        // This method uses the Array.Sort method to sort the elements.
        // 
        public static void Sort<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index, int count, IComparer<T> comparer)
        {
            XLists.Api.Sort(list, index, count, comparer);
        }

        public static void Sort<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Comparison<T> comparison)
        {
            XLists.Api.Sort(list, comparison);
        }

        // ToArray returns an array containing the contents of the List.
        // This requires copying the List, which is an O(n) operation.
        public static T[] ToArray<T>(this Models.E01D.Core.Collections.Generic.List<T> list)
        {
            return XLists.Api.ToArray(list);
        }

        public static Models.E01D.Core.Collections.Generic.List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
        {
            return XLists.Api.Create(source);
        }

        public static void TrimExcess<T>(this Models.E01D.Core.Collections.Generic.List<T> list)
        {
            XLists.Api.TrimExcess(list);
        }

        public static bool TrueForAll<T>(this Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            return XLists.Api.TrueForAll(list, match);
        }

        public static void SetItem<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int index, T item)
        {
            XLists.Api.SetItem(list, index, item);
        }

        public static void SetCapacity<T>(this Models.E01D.Core.Collections.Generic.List<T> list, int newCapacity)
        {
            XLists.Api.SetCapacity(list, newCapacity);
        }
    }
}
