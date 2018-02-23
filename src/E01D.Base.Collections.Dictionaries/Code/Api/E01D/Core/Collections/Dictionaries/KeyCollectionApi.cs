using Root.Code.Domains.E01D;

using Root.Code.Exts.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Base.Exceptions;


namespace Root.Code.Api.E01D.Core.Collections.Dictionaries
{
    public class KeyCollectionApi
    {
        public void Add<TKey, TValue>(TKey item)
        {
            throw new Exception("Mutating a key collection derived from a dictionary is not allowed.");
        }

        public void Clear<TKey, TValue>(KeyCollection<TKey, TValue> collection)
        {
            throw new Exception("Mutating a key collection derived from a dictionary is not allowed.");
        }

        public bool Contains<TKey, TValue>(KeyCollection<TKey, TValue> collection, TKey key)
        {
            return collection.Dictionary.ContainsKey(key);
        }

        public void CopyTo<TKey, TValue>(KeyCollection<TKey, TValue> collection, TKey[] array, int index)
        {
            if (array == null)
            {
                throw XExceptions.Argument.IsNull(nameof(array));
            }

            if (index < 0 || index > array.Length)
            {
                throw XExceptions.Argument.NonNegativeNumberRequired();
            }

            if (array.Length - index < collection.Dictionary.Count)
            {
                throw XExceptions.Argument.ArrayPlusOffTooSmall();
            }

            var count = collection.Dictionary.Count;

            var entries = collection.Dictionary.Entries;

            for (var i = 0; i < count; i++)
            {
                if (entries[i].HashCode >= 0) array[index++] = entries[i].Key;
            }
        }

        public KeyCollection<TKey,TValue> Create<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                throw XExceptions.Argument.IsNull(nameof(dictionary));
            }

            var collection = new KeyCollection<TKey, TValue>
            {
                Dictionary = dictionary
            };

            return collection;
        }

        public KeyCollectionEnumerator<TKey, TValue> GetEnumerator<TKey, TValue>(KeyCollection<TKey, TValue> keyCollection)
        {
            return XDictionaries.Api.KeyCollectionEnumerators.Create(keyCollection);
        }

        public bool Remove<TKey>(TKey item)
        {
            throw new Exception("Mutating a key collection derived from a dictionary is not allowed.");
        }

        
    }
}
