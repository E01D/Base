using Root.Code.Apis.E01D.Core.Collections;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.Collections;

namespace Root.Code.Exts.E01D.Core.Collections
{
    public static class DoubleLinkedListApi
    {
        public static DoubleLinkedListNode<T> AddAfter<T>(this DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node, T value)
        {
            return XDoubleLinkedList.Api.Lists.AddAfter(@this, node, value);
        }

        public static void AddAfter<T>(this DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node, DoubleLinkedListNode<T> newNode)
        {
            XDoubleLinkedList.Api.Lists.AddAfter(@this, node, newNode);
        }

        public static DoubleLinkedListNode<T> AddBefore<T>(this DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node, T value)
        {
            return XDoubleLinkedList.Api.Lists.AddBefore(@this, node, value);
        }

        public static void AddBefore<T>(this DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node, DoubleLinkedListNode<T> newNode)
        {
            XDoubleLinkedList.Api.Lists.AddBefore(@this, node, newNode);
        }

        public static DoubleLinkedListNode<T> AddFirst<T>(this DoubleLinkedList<T> @this, T value)
        {
            return XDoubleLinkedList.Api.Lists.AddFirst(@this, value);
        }

        public static void AddFirst<T>(this DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node)
        {
            XDoubleLinkedList.Api.Lists.AddFirst(@this, node);
        }

        public static DoubleLinkedListNode<T> AddLast<T>(this DoubleLinkedList<T> @this, T value)
        {
            return XDoubleLinkedList.Api.Lists.AddLast(@this, value);
        }

        public static void AddLast<T>(this DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node)
        {
            XDoubleLinkedList.Api.Lists.AddLast(@this, node);
        }

        public static void Clear<T>(this DoubleLinkedList<T> @this)
        {
            XDoubleLinkedList.Api.Lists.Clear(@this);
        }

        public static bool Contains<T>(this DoubleLinkedList<T> @this, T value)
        {
            return XDoubleLinkedList.Api.Lists.Contains(@this, value);
        }

        public static void CopyTo<T>(this DoubleLinkedList<T> @this, T[] array, int index)
        {
            XDoubleLinkedList.Api.Lists.CopyTo(@this, array, index);
        }

        public static DoubleLinkedListNode<T> Find<T>(this DoubleLinkedList<T> @this, T value)
        {
            return XDoubleLinkedList.Api.Lists.Find(@this, value);
        }

        public static DoubleLinkedListNode<T> FindLast<T>(this DoubleLinkedList<T> @this, T value)
        {
            return XDoubleLinkedList.Api.Lists.Find(@this, value);
        }

     

        public static DoubleLinkedListEnumeratorApi<T> GetEnumeratorApi<T>()
        {
            return XDoubleLinkedList.Api.Lists.GetEnumeratorApi<T>();
        }

        public static bool Remove<T>(this DoubleLinkedList<T> @this, T value)
        {
            return XDoubleLinkedList.Api.Lists.Remove(@this, value);
        }

        public static void Remove<T>(this DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node)
        {
            XDoubleLinkedList.Api.Lists.Remove(@this, node);
        }

        public static void RemoveFirst<T>(this DoubleLinkedList<T> @this)
        {
            XDoubleLinkedList.Api.Lists.RemoveFirst(@this);
        }

        public static void RemoveLast<T>(this DoubleLinkedList<T> @this)
        {
            XDoubleLinkedList.Api.Lists.RemoveLast(@this);
        }

       

        public static void ValidateNode<T>(this DoubleLinkedList<T> @this, DoubleLinkedListNode<T> node)
        {
            XDoubleLinkedList.Api.Lists.ValidateNode(@this, node);
        }

        
    }
}
