
using Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries;
using Root.Coding.Code.Models.E01D.Base.Exceptions;


namespace Root.Code.Api.E01D.Core.Collections.Dictionaries
{
    public class KeyCollectionEnumeratorApi
    {
        

        public KeyCollectionEnumerator<TKey, TValue> Create<TKey, TValue>(KeyCollection<TKey, TValue> keyCollection)
        {
            return new KeyCollectionEnumerator<TKey, TValue>()
            {
                Dictionary = keyCollection.Dictionary,
                Version = keyCollection.Dictionary.Version,
                Index = 0,
                Current = default(TKey)
            };
        }

        public void Dispose<TKey, TValue>(KeyCollectionEnumerator<TKey, TValue> enumerator)
        {
            
        }

        public bool MoveNext<TKey, TValue>(KeyCollectionEnumerator<TKey, TValue> enumerator)
        {
            if (enumerator.Version != enumerator.Dictionary.Version)
            {
                throw new Exception("Collection was modified; enumeration operation may not execute.");
            }

            while ((uint)enumerator.Index < (uint)enumerator.Dictionary.Count)
            {
                if (enumerator.Dictionary.Entries[enumerator.Index].HashCode >= 0)
                {
                    enumerator.Current = enumerator.Dictionary.Entries[enumerator.Index].Key;
                    enumerator.Index++;
                    return true;
                }
                enumerator.Index++;
            }
            enumerator.Index = enumerator.Dictionary.Count + 1;
            enumerator.Current = default(TKey);
            return false;
        }

        public TKey EnumeratorCurrent<TKey, TValue>(KeyCollectionEnumerator<TKey, TValue> enumerator)
        {
            if (enumerator.Index == 0 || (enumerator.Index == enumerator.Dictionary.Count + 1))
            {
                throw new Exception("Enumeration has either not started or has already finished.");
            }

            return enumerator.Current;
        }

        public void Reset<TKey, TValue>(KeyCollectionEnumerator<TKey, TValue> enumerator)
        {
            if (enumerator.Version != enumerator.Dictionary.Version)
            {
                throw new Exception("Collection was modified; enumeration operation may not execute.");
            }

            enumerator.Index = 0;
            enumerator.Current = default(TKey);
        }
    }
}
