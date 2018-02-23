using Root.Code.Models.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections.Generic;
using Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries;

namespace Root.Code.Api.E01D.Core.Collections.Dictionaries
{
    public class EnumeratorApi
    {
        internal const int DictEntry = 1;
        internal const int KeyValuePair = 2;

        public DictionaryEnumerator<TKey, TValue> Create<TKey, TValue>(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
        {
            var enumerator = new DictionaryEnumerator<TKey, TValue>
            {
                Dictionary = dictionary,
                Version = dictionary.Version,
                Index = 0,
                GetEnumeratorRetType = getEnumeratorRetType,
                Current = new KeyValuePair<TKey, TValue>()
            };


            return enumerator;
        }

        public bool MoveNext<TKey, TValue>(DictionaryEnumerator<TKey, TValue> enumerator)
        {
            if (enumerator.Version != enumerator.Dictionary.Version)
            {
                throw new System.Exception("Collection was modified; enumeration operation may not execute.");
            }

            // Use unsigned comparison since we set index to dictionary.count+1 when the enumeration ends.
            // dictionary.count+1 could be negative if dictionary.count is Int32.MaxValue
            while ((uint)enumerator.Index < (uint)enumerator.Dictionary.Count)
            {
                if (enumerator.Dictionary.Entries[enumerator.Index].HashCode >= 0)
                {
                    enumerator.Current = new KeyValuePair<TKey, TValue>(enumerator.Dictionary.Entries[enumerator.Index].Key, enumerator.Dictionary.Entries[enumerator.Index].Value);
                    enumerator.Index++;
                    return true;
                }
                enumerator.Index++;
            }

            enumerator.Index = enumerator.Dictionary.Count + 1;
            enumerator.Current = new KeyValuePair<TKey, TValue>();
            return false;
        }



        public void Dispose<TKey, TValue>(DictionaryEnumerator<TKey, TValue> enumerator)
        {

        }

        public object EnumeratorCurrent<TKey, TValue>(DictionaryEnumerator<TKey, TValue> enumerator)
        {
            
            if (enumerator.Index == 0 || (enumerator.Index == enumerator.Dictionary.Count + 1))
            {
                throw new System.Exception("Enumeration has either not started or has already finished.");
            }

            if (enumerator.GetEnumeratorRetType == DictEntry)
            {
                return new DictionaryEntry<TKey, TValue>(enumerator.Current.Key, enumerator.Current.Value);
            }
            else
            {
                return new KeyValuePair<TKey, TValue>(enumerator.Current.Key, enumerator.Current.Value);
            }
            
        }

        public void Reset<TKey, TValue>(DictionaryEnumerator<TKey, TValue> enumerator)
        {
            if (enumerator.Version != enumerator.Dictionary.Version)
            {
                throw new System.Exception("Collection was modified; enumeration operation may not execute.");
            }

            enumerator.Index = 0;
            enumerator.Current = new KeyValuePair<TKey, TValue>();
        }

        public DictionaryEntry_I DictionaryEnumeratorEntry<TKey, TValue>(DictionaryEnumerator<TKey, TValue> enumerator)
        {
            
            if (enumerator.Index == 0 || (enumerator.Index == enumerator.Dictionary.Count + 1))
            {
                throw new System.Exception("Enumeration has either not started or has already finished.");
            }

            return new DictionaryEntry<TKey, TValue>(enumerator.Current.Key, enumerator.Current.Value);
            
        }



        public object DictionaryEnumeratorKey<TKey, TValue>(DictionaryEnumerator<TKey, TValue> enumerator)
        {
            
            if (enumerator.Index == 0 || (enumerator.Index == enumerator.Dictionary.Count + 1))
            {
                throw new System.Exception("Enumeration has either not started or has already finished.");
            }

            return enumerator.Current.Key;
            
        }

        public object DictionaryEnumeratorValue<TKey, TValue>(DictionaryEnumerator<TKey, TValue> enumerator)
        {
            
            if (enumerator.Index == 0 || (enumerator.Index == enumerator.Dictionary.Count + 1))
            {
                throw new System.Exception("Enumeration has either not started or has already finished.");
            }

            return enumerator.Current.Value;
            
        }
    }
}
