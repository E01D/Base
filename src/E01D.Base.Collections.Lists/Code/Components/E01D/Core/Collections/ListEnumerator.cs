using System;
using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.Collections.Generic;

namespace Root.Code.Components.E01D.Core.Collections
{
    public class ListEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator
    {
        private List<T> list;
        private int index;
        private int version;
        private T current;

        public ListEnumerator(List<T> list)
        {
            this.list = list;
            index = 0;
            version = list.Version;
            current = default(T);
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {

            List<T> localList = list;

            if (version == localList.Version && ((uint)index < (uint)localList.Count))
            {
                current = localList.Items[index];
                index++;
                return true;
            }
            return MoveNextRare();
        }

        private bool MoveNextRare()
        {
            if (version != list.Version)
            {
                throw XCollections.Exceptions.InvalidOperation.EnumFailedVersion();
            }

            index = list.Count + 1;
            current = default(T);
            return false;
        }

        public T Current
        {
            get
            {
                return current;
            }
        }

        Object System.Collections.IEnumerator.Current
        {
            get
            {
                if (index == 0 || index == list.Count + 1)
                {
                    throw XCollections.Exceptions.InvalidOperation.EnumOperationCantHappen();
                }
                return Current;
            }
        }

        void System.Collections.IEnumerator.Reset()
        {
            if (version != list.Version)
            {
                throw XCollections.Exceptions.InvalidOperation.EnumFailedVersion();
            }

            index = 0;
            current = default(T);
        }

    }
}
