using System;
using System.Diagnostics;

namespace Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries
{
    
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public class KeyCollection<TKey, TValue> : Collection_I, Collection_I<TKey>
    {
        public Dictionary<TKey, TValue> Dictionary { get; set; }

       

        public int Count => Dictionary.Count;

        public bool IsReadOnly => true;

      

        bool Collection_I.IsSynchronized => false;

        Object Collection_I.SyncRoot => Dictionary.SyncRoot;
    }

}
