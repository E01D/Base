namespace Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries
{
    public struct DictionaryEntry<TKey, TValue>: DictionaryEntry_I
    {
        public DictionaryEntry(TKey key, TValue valueX)

        {
            Key = key;
            HashCode = 0;
            Next = 0;
            Value = valueX;
        }

        public int HashCode;    // Lower 31 bits of hash code, -1 if unused
        public int Next;        // Index of next entry, -1 if last
        public TKey Key;           // Key of entry
        public TValue Value;         // Value of entry

        int DictionaryEntry_I.HashCode => HashCode;

        int DictionaryEntry_I.Next => Next;

        object DictionaryEntry_I.Key => Key;

        object DictionaryEntry_I.Value => Value;
    }
}
