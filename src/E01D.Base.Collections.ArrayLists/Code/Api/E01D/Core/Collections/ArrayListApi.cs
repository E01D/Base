using System;
using System.Collections;
using System.Diagnostics.Contracts;
using Root.Code.Components.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections;
using ArrayList = Root.Code.Models.E01D.Core.Collections.ArrayList;
using Root.Code.Domains.E01D.Core;
using Root.Coding.Code.Domains.E01D.Core;

namespace Root.Code.Api.E01D.Core.Collections
{
    public class ArrayListApi
    {
        public const int _defaultCapacity = 4;

        private static readonly object[] emptyArray = EmptyArray<object>.Value;

        /// <summary>
        /// Constructs a ArrayList. The list is initially empty and has a capacity
        /// of zero. Upon adding the first element to the list the capacity is
        /// increased to _defaultCapacity, and then increased in multiples of two as required.
        /// </summary>
        /// <returns></returns>
        public ArrayList Create()
        {
            var list = new ArrayList
            {
                Items = emptyArray
            };

            return list;
        }

        // Constructs a ArrayList with a given initial capacity. The list is
        // initially empty, but will have room for the given number of elements
        // before any reallocations are required.
        // 
        public ArrayList Create(int capacity)
        {
            var list = new ArrayList();

            if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity), "ArgumentOutOfRange_MustBeNonNegNum", nameof(capacity));
            Contract.EndContractBlock();

            if (capacity == 0)
                list.Items = emptyArray;
            else
                list.Items = new Object[capacity];

            return list;
        }

    

        // Adds the given object to the end of this list. The size of the list is
        // increased by one. If required, the capacity of the list is doubled
        // before adding the new element.
        //
        public virtual int Add(ArrayList list, Object value)
        {
            Contract.Ensures(Contract.Result<int>() >= 0);
            if (list.Count == list.Items.Length) EnsureCapacity(list, list.Count + 1);
            list.Items[list.Count] = value;
            list.Version++;
            return list.Count++;
        }

        


        // Clears the contents of ArrayList.
        public virtual void Clear(ArrayList list)
        {
            if (list.Count > 0)
            {
                Array.Clear(list.Items, 0, list.Count); // Don't need to doc this but we clear the elements so that the gc can reclaim the references.
                list.Count = 0;
            }

            list.Version++;
        }

        // Clones this ArrayList, doing a shallow copy.  (A copy is made of all
        // Object references in the ArrayList, but the Objects pointed to 
        // are not cloned).
        public virtual Object Clone(ArrayList list)
        {
            Contract.Ensures(Contract.Result<Object>() != null);

            var la = Create(list.Count);
            la.Count = list.Count;
            la.Version = list.Version;
            Array.Copy(list.Items, 0, la.Items, 0, list.Count);
            return la;
        }


        // Contains returns true if the specified element is in the ArrayList.
        // It does a linear, O(n) search.  Equality is determined by calling
        // item.Equals().
        //
        public virtual bool Contains(ArrayList list, Object item)
        {
            if (item == null)
            {
                for (var i = 0; i < list.Count; i++)
                    if (list.Items[i] == null)
                        return true;
                return false;
            }
            else
            {
                for (var i = 0; i < list.Count; i++)
                    if ((list.Items[i] != null) && (list.Items[i].Equals(item)))
                        return true;
                return false;
            }
        }

        // Copies this ArrayList into array, which must be of a 
        // compatible array type.  
        //
        public virtual void CopyTo(ArrayList list, Array array, int arrayIndex)
        {
            if ((array != null) && (array.Rank != 1))
                throw new ArgumentException("Arg_RankMultiDimNotSupported");
            Contract.EndContractBlock();
            // Delegate rest of error checking to Array.Copy.
            Array.Copy(list.Items, 0, array, arrayIndex, list.Count);
        }

        // Ensures that the capacity of this list is at least the given minimum
        // value. If the currect capacity of the list is less than min, the
        // capacity is increased to twice the current capacity or to min,
        // whichever is larger.
        public void EnsureCapacity(ArrayList list, int min)
        {
            if (list.Items.Length < min)
            {
                var newCapacity = list.Items.Length == 0 ? _defaultCapacity : list.Items.Length * 2;
                // Allow the list to grow to maximum possible capacity (~2G elements) before encountering overflow.
                // Note that this check works even when list.Items.Length overflowed thanks to the (uint) cast
                if ((uint)newCapacity > XBase.Api.Arrays.MaxArrayLength) newCapacity = XBase.Api.Arrays.MaxArrayLength;
                if (newCapacity < min) newCapacity = min;
                list.Capacity = newCapacity;
            }
        }

        // Returns an enumerator for this list with the given
        // permission for removal of elements. If modifications made to the list 
        // while an enumeration is in progress, the MoveNext and 
        // GetObject methods of the enumerator will throw an exception.
        //
        public virtual IEnumerator GetEnumerator(ArrayList list)
        {
            Contract.Ensures(Contract.Result<IEnumerator>() != null);

            return new ArrayListEnumeratorSimple(list);
        }

        // Returns the index of the first occurrence of a given value in a range of
        // this list. The list is searched forwards from beginning to end.
        // The elements of the list are compared to the given value using the
        // Object.Equals method.
        // 
        // This method uses the Array.IndexOf method to perform the
        // search.
        // 
        public virtual int IndexOf(ArrayList list, Object value)
        {
            Contract.Ensures(Contract.Result<int>() < list.Count);

            return Array.IndexOf((Array)list.Items, value, 0, list.Count);
        }

        // Inserts an element into this list at a given index. The size of the list
        // is increased by one. If required, the capacity of the list is doubled
        // before inserting the new element.
        // 
        public virtual void Insert(ArrayList list, int index, Object value)
        {
            // Note that insertions at the end are legal.
            if (index < 0 || index > list.Count) throw new ArgumentOutOfRangeException(nameof(index), "ArgumentOutOfRange_ArrayListInsert");
            //Contract.Ensures(Count == Contract.OldValue(Count) + 1);
            Contract.EndContractBlock();

            if (list.Count == list.Items.Length) EnsureCapacity(list, list.Count + 1);
            if (index < list.Count)
            {
                Array.Copy(list.Items, index, list.Items, index + 1, list.Count - index);
            }
            list.Items[index] = value;
            list.Count++;
            list.Version++;
        }

        

        // Returns a read-only IList wrapper for the given IList.
        public List_I ReadOnly(ArrayList list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));
            Contract.Ensures(Contract.Result<IList>() != null);
            Contract.EndContractBlock();

            return new ReadOnlyList<object>(list.Items);
        }

        // Removes the element at the given index. The size of the list is
        // decreased by one.
        // 
        public virtual void Remove(ArrayList list, Object obj)
        {
            Contract.Ensures(list.Count >= 0);

            var index = IndexOf(list, obj);

            if (index >= 0)
            {
                RemoveAt(list, index);
            }
        }

        // Removes the element at the given index. The size of the list is
        // decreased by one.
        // 
        public virtual void RemoveAt(ArrayList list, int index)
        {
            if (index < 0 || index >= list.Count) throw new ArgumentOutOfRangeException(nameof(index), "ArgumentOutOfRange_Index");

            Contract.Ensures(list.Count >= 0);
            //Contract.Ensures(Count == Contract.OldValue(Count) - 1);
            Contract.EndContractBlock();

            list.Count--;

            if (index < list.Count)
            {
                Array.Copy(list.Items, index + 1, list.Items, index, list.Count - index);
            }

            list.Items[list.Count] = null;

            list.Version++;
        }

        // ToArray returns a new array of a particular type containing the contents 
        // of the ArrayList.  This requires copying the ArrayList and potentially
        // downcasting all elements.  This copy may fail and is an O(n) operation.
        // Internally, this implementation calls Array.Copy.
        //
        public virtual Array ToArray(ArrayList list, Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));
            Contract.Ensures(Contract.Result<Array>() != null);
            Contract.EndContractBlock();

            var array  = Array.CreateInstance(type, list.Count);
            Array.Copy(list.Items, 0, array, 0, list.Count);
            return array;
        }

        public virtual Object GetValue(ArrayList list, int index)
        {
            
            if (index < 0 || index >= list.Count) throw new ArgumentOutOfRangeException(nameof(index), "ArgumentOutOfRange_Index");

            Contract.EndContractBlock();

            return list.Items[index];
            
        }

        public void SetCapacity(ArrayList list, int newCapacity)
        {
            if (newCapacity < list.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(newCapacity), "ArgumentOutOfRange_SmallCapacity");
            }
            Contract.Ensures(list.Capacity >= 0);

            Contract.EndContractBlock();
            // We don't want to update the version number when we change the capacity.
            // Some existing applications have dependency on this.
            if (newCapacity != list.Items.Length)
            {
                if (newCapacity > 0)
                {
                    var newItems = new Object[newCapacity];

                    if (list.Count > 0)
                    {
                        Array.Copy(list.Items, 0, newItems, 0, list.Count);
                    }
                    list.Items = newItems;
                }
                else
                {
                    list.Items = new Object[_defaultCapacity];
                }
            }
        }

        public virtual void SetValue(ArrayList list, int index, object newValue)
        {  
            if (index < 0 || index >= list.Count) throw new ArgumentOutOfRangeException(nameof(index), "ArgumentOutOfRange_Index");

            Contract.EndContractBlock();

            list.Items[index] = newValue;

            list.Version++;
        }
    }
}
