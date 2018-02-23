namespace Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries
{
    public class DictionaryEnumerator<TKey,TValue>
    {
        public Dictionary<TKey, TValue> Dictionary { get; set; }
        public int Version { get; set; }
        public int Index { get; set; }
        public KeyValuePair<TKey, TValue> Current { get; set; }
        public int GetEnumeratorRetType { get; set; } // What should Enumerator.Current return?
    }
}
