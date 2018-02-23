using Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries;
using Root.Coding.Code.Models.E01D.Base.Exceptions;

namespace Root.Code.Api.E01D.Core.Collections.Dictionaries
{
    public class ValueCollectionEnumeratorApi
    {
        public ValueCollectionEnumerator<TKey, TValue> Create<TKey, TValue>(ValueCollection<TKey, TValue> valueCollection)
        {
            return new ValueCollectionEnumerator<TKey, TValue>()
            {
                Dictionary = valueCollection.Dictionary,
                Version = valueCollection.Dictionary.Version,
                Index = 0,
                Current = default(TValue)
            };
        }

        public void Dispose<TKey, TValue>(ValueCollectionEnumerator<TKey, TValue> enumerator)
        {

        }

        public bool MoveNext<TKey, TValue>(ValueCollectionEnumerator<TKey, TValue> enumerator)
        {
            if (enumerator.Version != enumerator.Dictionary.Version)
            {
                throw new Exception("Collection was modified; enumeration operation may not execute.");
            }

            while ((uint)enumerator.Index < (uint)enumerator.Dictionary.Count)
            {
                if (enumerator.Dictionary.Entries[enumerator.Index].HashCode >= 0)
                {
                    enumerator.Current = enumerator.Dictionary.Entries[enumerator.Index].Value;
                    enumerator.Index++;
                    return true;
                }
                enumerator.Index++;
            }
            enumerator.Index = enumerator.Dictionary.Count + 1;
            enumerator.Current = default(TValue);
            return false;
        }

        public TValue EnumeratorCurrent<TKey, TValue>(ValueCollectionEnumerator<TKey, TValue> enumerator)
        {
            if (enumerator.Index == 0 || (enumerator.Index == enumerator.Dictionary.Count + 1))
            {
                throw new Exception("Enumeration has either not started or has already finished.");
            }

            return enumerator.Current;
        }

        public void Reset<TKey, TValue>(ValueCollectionEnumerator<TKey, TValue> enumerator)
        {
            if (enumerator.Version != enumerator.Dictionary.Version)
            {
                throw new Exception("Collection was modified; enumeration operation may not execute.");
            }

            enumerator.Index = 0;
            enumerator.Current = default(TValue);
        }
    }
}
