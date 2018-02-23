using Root.Code.Domains.E01D;
using Root.Code.Exts.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections.Generic;
using Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries;
using Root.Coding.Code.Domains.E01D;

namespace Root.Code.Api.E01D.Core.Collections.Dictionaries
{
    public class ValueCollectionApi
    {
        public void Add<TValue>(TValue item)
        {
            throw new System.Exception("Mutating a value collection derived from a dictionary is not allowed."); 
        }

        public ValueCollection<TKey, TValue> Create<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                throw XExceptions.Argument.IsNull(nameof(dictionary));
            }

            var newCollection = new ValueCollection<TKey, TValue> {Dictionary = dictionary};

            return newCollection;
        }

        public void Clear()
        {
            throw new System.Exception("Mutating a value collection derived from a dictionary is not allowed.");
        }

        public bool Contains<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TValue item)
        {
            return dictionary.ContainsValue(item);
        }

        public void CopyTo<TKey, TValue>(ValueCollection<TKey,TValue> collection, TValue[] array, int index)
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

            int count = collection.Dictionary.Count;

            var entries = collection.Dictionary.Entries;

            for (int i = 0; i < count; i++)
            {
                if (entries[i].HashCode >= 0) array[index++] = entries[i].Value;
            }
        }

        public ValueCollectionEnumerator<TKey, TValue> GetEnumerator<TKey, TValue>(ValueCollection<TKey, TValue> valueCollection)
        {
            return XDictionaries.Api.ValueCollectionEnumerators.Create(valueCollection);
        }

        public bool Removed<TValue>(TValue item)
        {
            throw new System.Exception("Mutating a value collection derived from a dictionary is not allowed.");
        }


        
    }
}
