using System;
using System.Collections;
using Root.Code.Domains.E01D;
using Root.Code.Domains.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections;

namespace Root.Code.Exts.E01D.Core.Collections
{
    public static class ReadOnlyListExts
    {
        public static int Add<T>(this ReadOnlyList<T> list, Object obj)
        {
            return XReadOnlyCollections.ReadOnlyLists.Add(list, obj);
        }

        public static void Clear<T>(this ReadOnlyList<T> list)
        {
            XReadOnlyCollections.ReadOnlyLists.Clear(list);
        }

        public static bool Contains<T>(this ReadOnlyList<T> list, Object obj)
        {
            return XReadOnlyCollections.ReadOnlyLists.Contains(list, obj);
        }

        public static void CopyTo<T>(this ReadOnlyList<T> list, Array array, int index)
        {
            XReadOnlyCollections.ReadOnlyLists.CopyTo(list, array, index);
        }

        public static IEnumerator GetEnumerator<T>(this ReadOnlyList<T> list)
        {
            return XReadOnlyCollections.ReadOnlyLists.GetEnumerator(list);
        }

        public static int IndexOf<T>(this ReadOnlyList<T> list, Object value)
        {
            return XReadOnlyCollections.ReadOnlyLists.IndexOf(list, value);
        }

        public static void Insert<T>(this ReadOnlyList<T> list, int index, Object obj)
        {
            throw new NotSupportedException(XCollections.GetResourceString("NotSupported_ReadOnlyCollection"));
        }

        public static void Remove<T>(this ReadOnlyList<T> list, Object value)
        {
            throw new NotSupportedException(XCollections.GetResourceString("NotSupported_ReadOnlyCollection"));
        }

        public static void RemoveAt<T>(this ReadOnlyList<T> list, int index)
        {
            throw new NotSupportedException(XCollections.GetResourceString("NotSupported_ReadOnlyCollection"));
        }
    }
}
