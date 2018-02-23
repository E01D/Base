using System;

namespace Root.Code.Models.E01D.Core.Collections.Generic
{
    public class List<T>: List_I<T>
    {
        public int Count { get; set; }

        public bool IsFixedSize => false;

        public bool IsReadOnly => false;

        public bool IsSynchronized => false;

        public T[] Items { get; set; } = {};

        public Object SyncRoot { get; set; } = new object();

        public int Version { get; set; }
    }
}
