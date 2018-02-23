using Root.Code.Models.E01D.Core.Collections.Generic;

namespace Root.Code.Models.E01D.Core.Collections
{
    public class ReadOnlyCollection<T>
    {
        public List<T> List { get; set; }

        

        public int Count => List?.Count ?? 0;

        public bool IsReadOnly => true;

        public bool IsSynchronized => false;

        public object SyncRoot => List.SyncRoot;

        public bool IsFixedSize => true;


    }
}
