using System;
using Root.Code.Exts.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections;

namespace Root.Code.Api.E01D.Core.Collections
{
    public class ReadOnlyListApi
    {
        public object GetValue<T>(ReadOnlyList<T> list, int index)
        {
            return list.UnderlyingList.GetValue(index);
        }

        public virtual int Add<T>(ReadOnlyList<T> list, Object obj)
        {
            throw new NotSupportedException("NotSupported_ReadOnlyCollection");
        }

        public virtual void Clear<T>(ReadOnlyList<T> list)
        {
            throw new NotSupportedException("NotSupported_ReadOnlyCollection");
        }

        public virtual bool Contains<T>(ReadOnlyList<T> list, Object obj)
        {
            for (int i = 0; i < list.UnderlyingList.Length; i++)
            {
                if (ReferenceEquals(list.UnderlyingList[i], obj)) return true;
            }

            return false;
        }

        public virtual void CopyTo<T>(ReadOnlyList<T> list, Array array, int index)
        {
            list.CopyTo(array, index);
        }

        public virtual System.Collections.IEnumerator GetEnumerator<T>(ReadOnlyList<T> list)
        {
            return list.GetEnumerator();
        }

        public virtual int IndexOf<T>(ReadOnlyList<T> list, Object value)
        {
            return list.IndexOf(value);
        }

        public virtual void Insert<T>(ReadOnlyList<T> list, int index, Object obj)
        {
            throw new NotSupportedException("NotSupported_ReadOnlyCollection");
        }

        public virtual void Remove<T>(ReadOnlyList<T> list, Object value)
        {
            throw new NotSupportedException("NotSupported_ReadOnlyCollection");
        }

        public virtual void RemoveAt<T>(ReadOnlyList<T> list, int index)
        {
            throw new NotSupportedException("NotSupported_ReadOnlyCollection");
        }
    }
}
