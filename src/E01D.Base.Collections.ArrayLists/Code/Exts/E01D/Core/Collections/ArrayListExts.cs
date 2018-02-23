using System;
using System.Collections;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.Collections;
using ArrayList = Root.Code.Models.E01D.Core.Collections.ArrayList;

namespace Root.Code.Exts.E01D.Core.Collections
{
    public static class ArrayListExts
    {
        // Adds the given object to the end of this list. The size of the list is
        // increased by one. If required, the capacity of the list is doubled
        // before adding the new element.
        //
        public static int Add(this ArrayList list, Object value)
        {
            return XArrayList.Api.Add(list, value);
        }

        //// Adds the elements of the given collection to the end of this list. If
        //// required, the capacity of the list is increased to twice the previous
        //// capacity or the new size, whichever is larger.
        ////
        //public static void AddRange(this ArrayList list, Collection_I c)
        //{
        //    XCollections.ArrayLists.AddRange(list, c);
        //}


        // Clears the contents of ArrayList.
        public static void Clear(this ArrayList list)
        {
            XArrayList.Api.Clear(list);
        }

        // Clones this ArrayList, doing a shallow copy.  (A copy is made of all
        // Object references in the ArrayList, but the Objects pointed to 
        // are not cloned).
        public static Object Clone(this ArrayList list)
        {
            return XArrayList.Api.Clone(list);
        }


        // Contains returns true if the specified element is in the ArrayList.
        // It does a linear, O(n) search.  Equality is determined by calling
        // item.Equals().
        //
        public static bool Contains(this ArrayList list, Object item)
        {
            return XArrayList.Api.Contains(list, item);
        }

        // Copies this ArrayList into array, which must be of a 
        // compatible array type.  
        //
        public static void CopyTo(this ArrayList list, Array array, int arrayIndex)
        {
            XArrayList.Api.CopyTo(list, array, arrayIndex);
        }

        // Ensures that the capacity of this list is at least the given minimum
        // value. If the currect capacity of the list is less than min, the
        // capacity is increased to twice the current capacity or to min,
        // whichever is larger.
        public static void EnsureCapacity(this ArrayList list, int min)
        {
            XArrayList.Api.EnsureCapacity(list, min);
        }

        // Returns an enumerator for this list with the given
        // permission for removal of elements. If modifications made to the list 
        // while an enumeration is in progress, the MoveNext and 
        // GetObject methods of the enumerator will throw an exception.
        //
        public static IEnumerator GetEnumerator(this ArrayList list)
        {
            return XArrayList.Api.GetEnumerator(list);
        }

        // Returns the index of the first occurrence of a given value in a range of
        // this list. The list is searched forwards from beginning to end.
        // The elements of the list are compared to the given value using the
        // Object.Equals method.
        // 
        // This method uses the Array.IndexOf method to perform the
        // search.
        // 
        public static int IndexOf(this ArrayList list, Object value)
        {
            return XArrayList.Api.IndexOf(list, value);
        }

        // Inserts an element into this list at a given index. The size of the list
        // is increased by one. If required, the capacity of the list is doubled
        // before inserting the new element.
        // 
        public static void Insert(this ArrayList list, int index, Object value)
        {
            XArrayList.Api.Insert(list, index, value);
        }

        //// Inserts the elements of the given collection at a given index. If
        //// required, the capacity of the list is increased to twice the previous
        //// capacity or the new size, whichever is larger.  Ranges may be added
        //// to the end of the list by setting index to the ArrayList's size.
        ////
        //public static void InsertRange(this ArrayList list, int index, Collection_I c)
        //{
        //    XCollections.ArrayLists.InsertRange(list, index, c);
        //}

        // Returns a read-only IList wrapper for the given IList.
        public static List_I ReadOnly(this ArrayList list)
        {
            return XArrayList.Api.ReadOnly(list);
        }

        // Removes the element at the given index. The size of the list is
        // decreased by one.
        // 
        public static void Remove(this ArrayList list, Object obj)
        {
            XArrayList.Api.Remove(list, obj);
        }

        // Removes the element at the given index. The size of the list is
        // decreased by one.
        // 
        public static void RemoveAt(this ArrayList list, int index)
        {
            XArrayList.Api.RemoveAt(list, index);
        }

        // ToArray returns a new array of a particular type containing the contents 
        // of the ArrayList.  This requires copying the ArrayList and potentially
        // downcasting all elements.  This copy may fail and is an O(n) operation.
        // Internally, this implementation calls Array.Copy.
        //
        public static Array ToArray(this ArrayList list, Type type)
        {
            return XArrayList.Api.ToArray(list, type);
        }

        public static Object GetValue(this ArrayList list, int index)
        {
            return XArrayList.Api.GetValue(list, index);
        }

        public static void SetCapacity(this ArrayList list, int newCapacity)
        {
            XArrayList.Api.SetCapacity(list, newCapacity);
        }

        public static void SetValue(this ArrayList list, int index, object newValue)
        {
            XArrayList.Api.SetValue(list, index, newValue);
        }
    }
}
