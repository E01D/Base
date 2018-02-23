using System;
using Root.Code.Models.E01D.Core.Collections.Generic;
using Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries;

namespace Root.Code.Api.E01D.Core.Collections
{
    public interface DictionaryApi_I
    {
        // Returns whether this dictionary contains a particular key.
        //
        bool Contains(Object key);

        // Adds a key-value pair to the dictionary.
        // 
        void Add(Object key, Object value);

        // Removes all pairs from the dictionary.
        void Clear();

        // Returns an IDictionaryEnumerator for this dictionary.
        DictionaryEnumerator_I GetEnumerator<TKey,TValue>(Dictionary<TKey, TValue> dictionary);

        // Removes a particular key from the dictionary.
        //
        void Remove(Object key);
    }
}
