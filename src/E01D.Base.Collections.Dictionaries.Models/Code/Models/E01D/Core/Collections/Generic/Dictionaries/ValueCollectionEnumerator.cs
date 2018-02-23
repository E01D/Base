﻿namespace Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries
{
    public class ValueCollectionEnumerator<TKey, TValue>
    {
        public Dictionary<TKey, TValue> Dictionary { get; set; }
        public int Index { get; set; }
        public int Version { get; set; }
        public TValue Current { get; set; }
    }
}
