using System;
using Root.Code.Models.E01D.Core.Collections.Generic;
using Root.Coding.Code.Domains.E01D;

namespace Root.Code.Models.E01D.Core.Collections
{
    public class ReadOnlyList<T>: List_I<T>
    {
        private readonly T[] _list;

        public ReadOnlyList(T[] l)
        {
            _list = l;
        }

        public T[] UnderlyingList => _list;

        public virtual int Count => _list.Length;

        public virtual bool IsReadOnly => true;

        public virtual bool IsFixedSize => true;

        public virtual bool IsSynchronized => false;

        public virtual Object SyncRoot => _list.SyncRoot;

        public T[] Items
        {
            get { return UnderlyingList; }
            set { throw XExceptions.NotSupported.PropertyIsReadOnly();  }
        }
    }
}
