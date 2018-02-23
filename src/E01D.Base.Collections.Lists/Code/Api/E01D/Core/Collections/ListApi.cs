using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Root.Code.Components.E01D.Core.Collections;
using Root.Code.Domains.E01D;
using Root.Code.Exts.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections.Generic;
using Root.Coding.Code.Constants.E01D.Base;
using Root.Coding.Code.Domains.E01D;


namespace Root.Code.Api.E01D.Core.Collections
{
    public delegate TResult FuncOut<in T1, T2, out TResult>(T1 arg1, out T2 arg2);

    public class ListApi: ListApi_I
    {
        private const int DefaultCapacity = 4;

        public void Add<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {
            if (list.Count == list.Items.Length) EnsureCapacity(list, list.Count + 1);
            list.Items[list.Count++] = item;
            list.Version++;
        }

        public void AddEnumerable<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, IEnumerable<T> enumerable)
        {
            XDebug.Assert(enumerable != null);
            XDebug.Assert(!(enumerable is Collection_I<T>), "We should have optimized for this beforehand.");

            using (var en = enumerable.GetEnumerator())
            {
                list.Version++; // Even if the enumerable has no items, we can update list.Version.

                while (en.MoveNext())
                {
                    // Capture Current before doing anything else. If this throws
                    // an exception, we want to make a clean break.
                    var current = en.Current;

                    if (list.Count == list.Items.Length)
                    {
                        EnsureCapacity(list, list.Count + 1);
                    }

                    list.Items[list.Count++] = current;
                }
            }
        }

        public void AddRange<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, IEnumerable<T> collection)
        {
            InsertRange(list, list.Count, collection);
        }

        

        public int BinarySearch<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {

            return BinarySearch(list, 0, list.Count, item, null);
        }

        public int BinarySearch<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item, IComparer<T> comparer)
        {

            return BinarySearch(list, 0, list.Count, item, comparer);
        }

        // Searches a section of the list for a given element using a binary search
        // algorithm. Elements of the list are compared to the search value using
        // the given IComparer interface. If comparer is null, elements of
        // the list are compared to the search value using the IComparable
        // interface, which in that case must be implemented by all elements of the
        // list and the given search value. This method assumes that the given
        // section of the list is already sorted; if this is not the case, the
        // result will be incorrect.
        //
        // The method returns the index of the given value in the list. If the
        // list does not contain the given value, the method returns a negative
        // integer. The bitwise complement operator (~) can be applied to a
        // negative result to produce the index of the first element (if any) that
        // is larger than the given search value. This is also the index at which
        // the search value should be inserted into the list in order for the list
        // to remain sorted.
        // 
        // The method uses the Array.BinarySearch method to perform the
        // search.
        // 
        public int BinarySearch<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index, int count, T item, IComparer<T> comparer)
        {
            if (index < 0)
            {
                throw XExceptions.Argument.OutOfRange.NeedNonNegativeNumber(nameof(index));
            }

            if (count < 0)
            {
                throw XExceptions.Argument.OutOfRange.NeedNonNegativeNumber(nameof(count));
            }

            if (list.Count - index < count)
            {
                throw XExceptions.Argument.InvalidOffsetLength(nameof(count));
            }

            return Array.BinarySearch(list.Items, index, count, item, comparer);
        }

        public int Capacity<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list)
        {
            return list.Items?.Length ?? 0;
        }


        // Clears the contents of List.
        public void Clear<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list)
        {
            if (list.Count > 0)
            {
                Array.Clear(list.Items, 0, list.Count); // Don't need to doc this but we clear the elements so that the gc can reclaim the references.

                list.Count = 0;
            }

            list.Version++;
        }

        // Contains returns true if the specified element is in the List.
        // It does a linear, O(n) search.  Equality is determined by calling
        // EqualityComparer<T>.Default.Equals().

        public bool Contains<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {
            // PERF: IndexOf calls Array.IndexOf, which internally
            // calls EqualityComparer<T>.Default.IndexOf, which
            // is specialized for different types. This
            // boosts performance since instead of making a
            // virtual method call each iteration of the loop,
            // via EqualityComparer<T>.Default.Equals, we
            // only make one virtual call to EqualityComparer.IndexOf.

            return list.Count != 0 && IndexOf(list, item) != -1;
        }

        public Root.Code.Models.E01D.Core.Collections.Generic.List<T> Copy<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list)
        {
            var newList = Create<T>();

            list.Iterate(x => newList.Add(x));

            return newList;
        }

        // Copies a section of this list to the given array at the given index.
        // 
        // The method uses the Array.Copy method to copy the elements.
        // 
        public void CopyTo<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index, T[] array, int arrayIndex, int count)
        {
            if (list.Count - index < count)
            {
                XExceptions.Argument.InvalidOffsetLength(nameof(index));
            }

            Contract.EndContractBlock();

            // Delegate rest of error checking to Array.Copy.
            Array.Copy(list.Items, index, array, arrayIndex, count);
        }

        public void CopyTo<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T[] array, int arrayIndex)
        {
            // Delegate rest of error checking to Array.Copy.
            Array.Copy(list.Items, 0, array, arrayIndex, list.Count);
        }

        /// <summary>
        /// Creates a new List. The list is initially empty and has a capacity
        /// of zero. Upon adding the first element to the list the capacity is
        /// increased to _defaultCapacity, and then increased in multiples of two
        /// as required.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Root.Code.Models.E01D.Core.Collections.Generic.List<T> Create<T>()
        {
            var list = new Root.Code.Models.E01D.Core.Collections.Generic.List<T>()
            {
                Items = EmptyArray<T>.Value
            };

            return list;
        }

        // Constructs a List with a given initial capacity. The list is
        // initially empty, but will have room for the given number of elements
        // before any reallocations are required.
        // 
        public Root.Code.Models.E01D.Core.Collections.Generic.List<T> Create<T>(int capacity)
        {
            if (capacity < 0) throw XExceptions.Argument.NonNegativeNumberRequired(nameof(capacity));

            Contract.EndContractBlock();

            var list = new Root.Code.Models.E01D.Core.Collections.Generic.List<T>();

            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (capacity == 0)
            {
                list.Items = EmptyArray<T>.Value;
            }
            else
            {
                list.Items = new T[capacity];
            }

            return list;
        }

        // Constructs a List, copying the contents of the given collection. The
        // size and capacity of the new list will both be equal to the size of the
        // given collection.
        // 
        public Root.Code.Models.E01D.Core.Collections.Generic.List<T> Create<T>(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw XExceptions.Argument.IsNull(nameof(collection));
            }

            var list = new Root.Code.Models.E01D.Core.Collections.Generic.List<T>();

            var c = collection as Collection_I<T>;

            if (c != null && c.Count == 0)
            {
                list.Items = EmptyArray<T>.Value;  
            }
            else
            {
                list.Count = 0;
                list.Items = EmptyArray<T>.Value;

                AddEnumerable(list, collection);
            }

            return list;
        }

        // Ensures that the capacity of this list is at least the given minimum
        // value. If the current capacity of the list is less than min, the
        // capacity is increased to twice the current capacity or to min,
        // whichever is larger.
        public void EnsureCapacity<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int min)
        {
            if (list.Items.Length < min)
            {
                var newCapacity = list.Items.Length == 0 ? DefaultCapacity : list.Items.Length * 2;

                // Allow the list to grow to maximum possible capacity (~2G elements) before encountering overflow.
                // Note that this check works even when list.Items.Length overflowed thanks to the (uint) cast
                if ((uint)newCapacity > ArrayConsts.MaxArrayLength) newCapacity = ArrayConsts.MaxArrayLength;

                if (newCapacity < min) newCapacity = min;

                SetCapacity(list, newCapacity);

            }
        }

        public bool Exists<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            return FindIndex(list, match) != -1;
        }

        public T Find<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            if (match == null)
            {
                throw XExceptions.Argument.IsNull(nameof(match));
            }

            Contract.EndContractBlock();

            for (var i = 0; i < list.Count; i++)
            {
                if (match(list.Items[i]))
                {
                    return list.Items[i];
                }
            }
            return default(T);
        }

        public Root.Code.Models.E01D.Core.Collections.Generic.List<T> FindAll<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            if (match == null)
            {
                throw XExceptions.Argument.IsNull(nameof(match));
            }

            var newList = new Root.Code.Models.E01D.Core.Collections.Generic.List<T>();

            for (var i = 0; i < list.Count; i++)
            {
                if (match(list.Items[i]))
                {
                    newList.Add(list.Items[i]);
                }
            }
            return newList;
        }

        public int FindIndex<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {

            return FindIndex(list, 0, list.Count, match);
        }

        public int FindIndex<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int startIndex, Predicate<T> match)
        {

            return FindIndex(list, startIndex, list.Count - startIndex, match);
        }

        public int FindIndex<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int startIndex, int count, Predicate<T> match)
        {
            if ((uint)startIndex > (uint)list.Count)
            {
                throw XExceptions.Argument.OutOfRange.Index(nameof(startIndex));
            }

            if (count < 0 || startIndex > list.Count - count)
            {
                throw XExceptions.Argument.OutOfRange.Count(nameof(count));

            }

            if (match == null)
            {
                throw XExceptions.Argument.IsNull(nameof(match));
            }

            Contract.Ensures(Contract.Result<int>() >= -1);
            Contract.Ensures(Contract.Result<int>() < startIndex + count);
            Contract.EndContractBlock();

            var endIndex = startIndex + count;
            for (var i = startIndex; i < endIndex; i++)
            {
                if (match(list.Items[i])) return i;
            }
            return -1;
        }

        public T FindLast<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            if (match == null)
            {
                throw XExceptions.Argument.IsNull(nameof(match));
            }
            Contract.EndContractBlock();

            for (var i = list.Count - 1; i >= 0; i--)
            {
                if (match(list.Items[i]))
                {
                    return list.Items[i];
                }
            }
            return default(T);
        }

        public int FindLastIndex<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {

            return FindLastIndex(list, list.Count - 1, list.Count, match);
        }

        public int FindLastIndex<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int startIndex, Predicate<T> match)
        {

            return FindLastIndex(list, startIndex, startIndex + 1, match);
        }

        public int FindLastIndex<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int startIndex, int count, Predicate<T> match)
        {
            if (match == null)
            {
                throw XExceptions.Argument.IsNull(nameof(match));
            }

            Contract.Ensures(Contract.Result<int>() >= -1);
            Contract.Ensures(Contract.Result<int>() <= startIndex);
            Contract.EndContractBlock();

            if (list.Count == 0)
            {
                // Special case for 0 length List
                if (startIndex != -1)
                {
                    throw XExceptions.Argument.OutOfRange.Index(nameof(startIndex));
                }
            }
            else
            {
                // Make sure we're not out of range            
                if ((uint)startIndex >= (uint)list.Count)
                {
                    throw XExceptions.Argument.OutOfRange.Index(nameof(startIndex));
                }
            }

            // 2nd have of this also catches when startIndex == MAXINT, so MAXINT - 0 + 1 == -1, which is < 0.
            if (count < 0 || startIndex - count + 1 < 0)
            {
                throw XExceptions.Argument.OutOfRange.Count(nameof(startIndex));
            }

            var endIndex = startIndex - count;
            for (var i = startIndex; i > endIndex; i--)
            {
                if (match(list.Items[i]))
                {
                    return i;
                }
            }
            return -1;
        }


        public ListEnumerator<T> GetEnumerator<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list)
        {
            return new ListEnumerator<T>(list);
        }


        public T GetItem<T>(List_I<T> list, int index)
        {
            if ((uint)index >= (uint)list.Count)
            {
                throw XExceptions.Argument.OutOfRange.Index(nameof(index));
            }

            Contract.EndContractBlock();

            return list.Items[index];
        }

      

        
        public Root.Code.Models.E01D.Core.Collections.Generic.List<T> GetRange<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index, int count)
        {
            if (index < 0)
            {
                throw XExceptions.Argument.OutOfRange.NeedNonNegativeNumber(nameof(index));
            }

            if (count < 0)
            {
                throw XExceptions.Argument.OutOfRange.Count(nameof(count));
            }

            if (list.Count - index < count)
            {
                throw XExceptions.Argument.InvalidOffsetLength(nameof(index));
            }
            Contract.Ensures(Contract.Result<Root.Code.Models.E01D.Core.Collections.Generic.List<T>>() != null);
            Contract.EndContractBlock();

            var newList = Create<T>(count);

            Array.Copy(list.Items, index, newList.Items, 0, count);

            newList.Count = count;
            return list;
        }

        // Returns the index of the first occurrence of a given value in a range of
        // this list. The list is searched forwards from beginning to end.
        // The elements of the list are compared to the given value using the
        // Object.Equals method.
        // 
        // This method uses the Array.IndexOf method to perform the
        // search.
        // 
        public int IndexOf<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {
            Contract.Ensures(Contract.Result<int>() >= -1);
            Contract.Ensures(Contract.Result<int>() < list.Count);
            return Array.IndexOf(list.Items, item, 0, list.Count);
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
        public int IndexOf<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item, int index)
        {
            if (index > list.Count)
            {
                throw XExceptions.Argument.OutOfRange.Index(nameof(index));
            }

            return Array.IndexOf(list.Items, item, index, list.Count - index);
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
        public int IndexOf<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item, int index, int count)
        {
            if (index > list.Count)
            {
                throw XExceptions.Argument.OutOfRange.Index(nameof(index));
            }

            if (count < 0 || index > list.Count - count)
            {
                throw XExceptions.Argument.OutOfRange.Count(nameof(count));
            }

            return Array.IndexOf(list.Items, item, index, count);
        }

        // Inserts an element into this list at a given index. The size of the list
        // is increased by one. If required, the capacity of the list is doubled
        // before inserting the new element.
        // 
        public void Insert<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index, T item)
        {
            // Note that insertions at the end are legal.
            if ((uint)index > (uint)list.Count)
            {
                throw XExceptions.Argument.OutOfRange.ListInsert(nameof(index));
            }

            Contract.EndContractBlock();

            if (list.Count == list.Items.Length) EnsureCapacity(list, list.Count + 1);

            if (index < list.Count)
            {
                Array.Copy(list.Items, index, list.Items, index + 1, list.Count - index);
            }

            list.Items[index] = item;
            list.Count++;
            list.Version++;
        }

        // Inserts the elements of the given collection at a given index. If
        // required, the capacity of the list is increased to twice the previous
        // capacity or the new size, whichever is larger.  Ranges may be added
        // to the end of the list by setting index to the List's size.
        //
        public void InsertRange<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index, IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw XExceptions.Argument.IsNull(nameof(collection));
            }

            if ((uint)index > (uint)list.Count)
            {
                throw XExceptions.Argument.OutOfRange.Index(nameof(index));
            }

            Contract.EndContractBlock();

            var c = collection as Collection_I<T>;

            if (c != null)
            {    // if collection is ICollection<T>
                var count = c.Count;
                if (count > 0)
                {
                    EnsureCapacity(list, list.Count + count);
                    if (index < list.Count)
                    {
                        Array.Copy(list.Items, index, list.Items, index + count, list.Count - index);
                    }

                    // If we're inserting a List into itself, we want to be able to deal with that.
                    if (list == c)
                    {
                        // Copy first part of list.Items to insert location
                        Array.Copy(list.Items, 0, list.Items, index, index);
                        // Copy last part of list.Items back to inserted location
                        Array.Copy(list.Items, index + count, list.Items, index * 2, list.Count - index);
                    }
                    else
                    {
                        c.CopyTo(list.Items, index);
                    }
                    list.Count += count;
                }
            }
            else if (index < list.Count)
            {
                // We're inserting a lazy enumerable. Call Insert on each of the constituent items.
                using (var en = collection.GetEnumerator())
                {
                    while (en.MoveNext())
                    {
                        Insert(list, index++, en.Current);
                    }
                }
            }
            else
            {
                // We're adding a lazy enumerable because the index is at the end of this list.
                AddEnumerable(list, collection);
            }
            list.Version++;
        }

        public void Iterate<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Action<T> action)
        {
            for (var i = 0; i < list.Count; i++)
            {
                var item = list.GetItem(i);

                action(item);
            }
        }

        public TOut Iterate<T, TOut>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, FuncOut<T, TOut, bool> action)
        {
            TOut result = default(TOut);

            for (var i = 0; i < list.Count; i++)
            {
                var item = list.GetItem(i);

                if (action(item, out result))
                {
                    return result;
                };
            }

            return result;
        }

        // Returns the index of the last occurrence of a given value in a range of
        // this list. The list is searched backwards, starting at the end 
        // and ending at the first element in the list. The elements of the list 
        // are compared to the given value using the Object.Equals method.
        // 
        // This method uses the Array.LastIndexOf method to perform the
        // search.
        // 
        public int LastIndexOf<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {

            if (list.Count == 0)
            {  // Special case for empty list
                return -1;
            }
            else
            {
                return LastIndexOf(list, item, list.Count - 1, list.Count);
            }
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
        public int LastIndexOf<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item, int index)
        {
            if (index >= list.Count)
            {
                throw XExceptions.Argument.OutOfRange.Index(nameof(index));
            }

            return LastIndexOf(list, item, index, index + 1);
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
        public int LastIndexOf<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item, int index, int count)
        {
            if ((list.Count != 0) && (index < 0))
            {
                throw XExceptions.Argument.OutOfRange.NeedNonNegativeNumber(nameof(index));
            }

            if ((list.Count != 0) && (count < 0))
            {
                throw XExceptions.Argument.OutOfRange.Count(nameof(count));
            }
          

            if (list.Count == 0)
            {  // Special case for empty list
                return -1;
            }

            if (index >= list.Count)
            {
                throw XExceptions.Argument.OutOfRange.BiggerThanCollection(nameof(index));
            }

            if (count > index + 1)
            {
                throw XExceptions.Argument.OutOfRange.BiggerThanCollection(nameof(index));
            }

            return Array.LastIndexOf(list.Items, item, index, count);
        }

        // Removes the element at the given index. The size of the list is
        // decreased by one.
        // 
        public bool Remove<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, T item)
        {
            var index = IndexOf(list, item);
            if (index >= 0)
            {
                RemoveAt(list, index);
                return true;
            }

            return false;
        }

        // This method removes all items which matches the predicate.
        // The complexity is O(n).   
        public int RemoveAll<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            if (match == null)
            {
                throw XExceptions.Argument.IsNull(nameof(match));
            }

            var freeIndex = 0;   // the first free slot in items array

            // Find the first item which needs to be removed.
            while (freeIndex < list.Count && !match(list.Items[freeIndex])) freeIndex++;
            if (freeIndex >= list.Count) return 0;

            var current = freeIndex + 1;
            while (current < list.Count)
            {
                // Find the first item which needs to be kept.
                while (current < list.Count && match(list.Items[current])) current++;

                if (current < list.Count)
                {
                    // copy item to the free slot.
                    list.Items[freeIndex++] = list.Items[current++];
                }
            }

            Array.Clear(list.Items, freeIndex, list.Count - freeIndex);
            var result = list.Count - freeIndex;
            list.Count = freeIndex;
            list.Version++;
            return result;
        }

        // Removes the element at the given index. The size of the list is
        // decreased by one.
        // 
        public void RemoveAt<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index)
        {
            if ((uint)index >= (uint)list.Count)
            {
                   throw XExceptions.Argument.OutOfRange.Index(nameof(index));
            }
            Contract.EndContractBlock();
            list.Count--;
            if (index < list.Count)
            {
                Array.Copy(list.Items, index + 1, list.Items, index, list.Count - index);
            }
            list.Items[list.Count] = default(T);
            list.Version++;
        }

        // Removes a range of elements from this list.
        // 
        public void RemoveRange<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index, int count)
        {
            if (index < 0)
            {
                throw XExceptions.Argument.OutOfRange.NeedNonNegativeNumber(nameof(index));
            }

            if (count < 0)
            {
                throw XExceptions.Argument.OutOfRange.Count(nameof(count));
            }

            if (list.Count - index < count)
            {
                throw XExceptions.Argument.InvalidOffsetLength(nameof(index));
            }
            Contract.EndContractBlock();

            if (count <= 0) return;

            list.Count -= count;
            if (index < list.Count)
            {
                Array.Copy(list.Items, index + count, list.Items, index, list.Count - index);
            }
            Array.Clear(list.Items, list.Count, count);
            list.Version++;
        }

        // Reverses the elements in this list.
        public void Reverse<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list)
        {
            Reverse(list, 0, list.Count);
        }

        // Reverses the elements in a range of this list. Following a call to this
        // method, an element in the range given by index and count
        // which was previously located at index i will now be located at
        // index index + (index + count - i - 1).
        // 
        public void Reverse<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index, int count)
        {
            if (index < 0)
            {
                throw XExceptions.Argument.OutOfRange.NeedNonNegativeNumber(nameof(index));
            }

            if (count < 0)
            {
                throw XExceptions.Argument.OutOfRange.Count(nameof(count));
            }

            if (list.Count - index < count)
            {
                throw XExceptions.Argument.InvalidOffsetLength(nameof(count));
            }

            Contract.EndContractBlock();

            if (count > 1)
            {
                Array.Reverse(list.Items, index, count);
            }
            list.Version++;
        }

        // Sorts the elements in this list.  Uses the default comparer and 
        // Array.Sort.
        public void Sort<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list)
        {
            Sort(list, 0, list.Count, null);
        }

        // Sorts the elements in this list.  Uses Array.Sort with the
        // provided comparer.
        public void Sort<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, IComparer<T> comparer)
        {
            Sort(list, 0, list.Count, comparer);
        }

        // Sorts the elements in a section of this list. The sort compares the
        // elements to each other using the given IComparer interface. If
        // comparer is null, the elements are compared to each other using
        // the IComparable interface, which in that case must be implemented by all
        // elements of the list.
        // 
        // This method uses the Array.Sort method to sort the elements.
        // 
        public void Sort<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index, int count, IComparer<T> comparer)
        {
            if (index < 0)
            {
                throw XExceptions.Argument.OutOfRange.NeedNonNegativeNumber(nameof(index));
            }

            if (count < 0)
            {
                throw XExceptions.Argument.OutOfRange.Count(nameof(count));
            }

            if (list.Count - index < count)
            {
                throw XExceptions.Argument.InvalidOffsetLength(nameof(count));
            }

            Contract.EndContractBlock();

            if (count > 1)
            {
                Array.Sort(list.Items, index, count, comparer);
            }
            list.Version++;
        }

        public void Sort<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Comparison<T> comparison)
        {
            if (comparison == null)
            {
                throw XExceptions.Argument.IsNull(nameof(comparison));
            }
            Contract.EndContractBlock();

            if (list.Count > 1)
            {
                XCollections.Sorting.Sort(list.Items, 0, list.Count, comparison);
            }
            list.Version++;
        }

        // ToArray returns an array containing the contents of the List.
        // This requires copying the List, which is an O(n) operation.
        public T[] ToArray<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list)
        {
            if (list.Count == 0)
            {
                return EmptyArray<T>.Value;
            }

            var array = new T[list.Count];

            Array.Copy(list.Items, 0, array, 0, list.Count);

            return array;
        }

        // Sets the capacity of this list to the size of the list. This method can
        // be used to minimize a list's memory overhead once it is known that no
        // new elements will be added to the list. To completely clear a list and
        // release all memory referenced by the list, execute the following
        // statements:
        // 
        // list.Clear();
        // list.TrimExcess();
        // 
        public void TrimExcess<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list)
        {
            var threshold = (int)(((double)list.Items.Length) * 0.9);
            if (list.Count < threshold)
            {
                SetCapacity(list, list.Count);

            }
        }

        public bool TrueForAll<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, Predicate<T> match)
        {
            if (match == null)
            {
                throw XExceptions.Argument.IsNull(nameof(match));
            }
            Contract.EndContractBlock();

            for (var i = 0; i < list.Count; i++)
            {
                if (!match(list.Items[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public void SetItem<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int index, T item)
        {
            if ((uint)index >= (uint)list.Count)
            {
                throw XExceptions.Argument.OutOfRange.Index(nameof(index));
            }
            Contract.EndContractBlock();

            list.Items[index] = item;

            list.Version++;
        }

        public void SetCapacity<T>(Root.Code.Models.E01D.Core.Collections.Generic.List<T> list, int newCapacity)
        {
            if (newCapacity < list.Count)
            {
                throw XExceptions.Argument.OutOfRange.SmallCapacity(nameof(newCapacity));
            }

            Contract.EndContractBlock();

            if (newCapacity != list.Items.Length)
            {
                if (newCapacity > 0)
                {
                    var newItems = new T[newCapacity];

                    if (list.Count > 0)
                    {
                        Array.Copy(list.Items, 0L, newItems, 0, list.Count);
                    }
                    list.Items = newItems;
                }
                else
                {
                    list.Items = EmptyArray<T>.Value;
                }
            }
        }


        
    }
}
