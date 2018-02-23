using System;
using System.Diagnostics;

namespace Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries
{
    
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public sealed class ValueCollection<TKey, TValue> : Collection_I<TValue>, Collection_I
    {
        public Dictionary<TKey, TValue> Dictionary { get; set; }

       

        public int Count => Dictionary.Count;

        bool Collection_I<TValue>.IsReadOnly => true;

    
        bool Collection_I.IsSynchronized => false;

        Object Collection_I.SyncRoot => Dictionary.SyncRoot;
    }
}
