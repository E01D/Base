using System;
using System.Collections.Generic;
using System.Diagnostics;
using Root.Code.Api.E01D.Core.Collections.Dictionaries;
using Root.Code.Models.E01D.Core.Collections.Generic.Dictionaries;
using Root.Coding.Code.Domains.E01D;


namespace Root.Code.Api.E01D.Core.Collections
{
    public class DictionaryApi
    {
        public HashingApi Hashing { get; set; } = new HashingApi();

        public KeyCollectionApi KeyCollections { get; set; } = new KeyCollectionApi();

        public ValueCollectionApi ValueCollections { get; set; } = new ValueCollectionApi();

        public KeyCollectionEnumeratorApi KeyCollectionEnumerators { get; set; } = new KeyCollectionEnumeratorApi();

        public ValueCollectionEnumeratorApi ValueCollectionEnumerators { get; set; } = new ValueCollectionEnumeratorApi();

        public Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> Create<TKey, TValue>()
        {
            return Create<TKey,TValue>(0, null);
        }

        public Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> Create<TKey, TValue>(int capacity)
        {
            return Create<TKey, TValue>(capacity, null);
        }



        public Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> Create<TKey, TValue>(IEqualityComparer<TKey> comparer)
        {
            return Create<TKey, TValue>(0, comparer);
        }

        public Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> Create<TKey, TValue>(int capacity, IEqualityComparer<TKey> comparer)
        {
            return Create(capacity, comparer, new Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue>());
        }

        public Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> Create<TKey, TValue>(int capacity, IEqualityComparer<TKey> comparer, Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            if (capacity < 0) throw XExceptions.Argument.OutOfRange.CapacityLessThanZero(nameof(capacity));

            if (capacity > 0) Initialize(dictionary, capacity);

            dictionary.Comparer = comparer ?? EqualityComparer<TKey>.Default;

#if FEATURE_RANDOMIZED_STRING_HASHING

            if (HashHelpers.s_UseRandomizedStringHashing && comparer == EqualityComparer<string>.Default)
            {
                this.comparer = (IEqualityComparer<TKey>) NonRandomizedStringEqualityComparer.Default;
            }

#endif // FEATURE_RANDOMIZED_STRING_HASHING

            return dictionary;
        }

        public Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> Create<TKey, TValue>(Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> existingDictionary)
        {
            return Create(existingDictionary, null);
        }

        public Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> Create<TKey, TValue>(Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> existingDictionary, IEqualityComparer<TKey> comparer)
        {
            Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey,TValue> dictionaryNew;

            if (existingDictionary != null)
            {
                dictionaryNew = Create<TKey, TValue>(existingDictionary.Count, comparer);
            }
            else
            {
                dictionaryNew = Create<TKey, TValue>(comparer);
            }

            if (existingDictionary == null)
            {
                throw XExceptions.Argument.IsNull(nameof(existingDictionary));
            }

            // It is likely that the passed-in dictionary is Dictionary<TKey,TValue>. When this is the case,
            // avoid the enumerator allocation and overhead by looping through the entries array directly.
            // We only do this when dictionary is Dictionary<TKey,TValue> and not a subclass, to maintain
            // back-compat with subclasses that may have overridden the enumerator behavior.
            if (existingDictionary.GetType() == typeof(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue>))
            {
                var d = (Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue>)existingDictionary;

                var count = d.Count;

                var entries = d.Entries;

                for (var i = 0; i < count; i++)
                {
                    if (entries[i].HashCode >= 0)
                    {
                        Add(dictionaryNew, entries[i].Key, entries[i].Value);
                    }
                }

                return dictionaryNew;
            }

            throw new System.NotImplementedException();
            //foreach (var pair in existingDictionary)
            //{
            //    Add(dictionaryNew, pair.Key, pair.Value);
            //}

            //return dictionaryNew;
        }

       

        private void Initialize<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, int capacity)
        {
            var size = Hashing.GetPrime(capacity);

            dictionary.Buckets = new int[size];

            for (var i = 0; i < dictionary.Buckets.Length; i++) dictionary.Buckets[i] = -1;

            dictionary.Entries = new DictionaryEntry<TKey,TValue>[size];

            dictionary.FreeList = -1;
        }


        /// <summary>
        /// Clones a dictionary
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> Clone<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null) return null;

            if (dictionary?.Buckets.Length > 0 && dictionary?.Entries.Length > 0)
            {
                var newDictionary = new Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue>()
                {
                    Buckets = new int[dictionary.Buckets.Length],

                    Entries = new DictionaryEntry<TKey, TValue>[dictionary.Entries.Length],

                    Count = dictionary.Count
                };

                for (var i = 0; i < dictionary.Buckets.Length; i++)
                {
                    newDictionary.Buckets[i] = dictionary.Buckets[i];
                }

                for (var i = 0; i < dictionary.Entries.Length; i++)
                {
                    var newEntry = new DictionaryEntry<TKey, TValue>()
                    {
                        HashCode = newDictionary.Entries[i].HashCode,
                        Next = newDictionary.Entries[i].Next,
                        Key = newDictionary.Entries[i].Key,
                        Value = newDictionary.Entries[i].Value,
                    };

                    newDictionary.Entries[i] = newEntry;
                }

                return newDictionary;
            }
            else
            {
                var newDictionary = new Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue>();

                throw new System.NotImplementedException();

                //foreach (var item in dictionary)
                //{
                //    newDictionary.Add(item.Key, item.Value);
                //}

                //return newDictionary;
            }

            
        }

        public TValue GetValue<TValue,TKey>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key)
        {
            int i = FindEntry(dictionary, key);

            if (i >= 0) return dictionary.Entries[i].Value;

            throw new Exception("KeyNotFound");
        }

        public void SetValue<TValue, TKey>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key,
            TValue xValue)
        {
            Insert(dictionary, key, xValue, false);
        }

        public void Add<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            Insert(dictionary, key, value, true);
        }

        public void Clear<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey,TValue> dictionary)
        {
            if (dictionary.Count > 0)
            {
                for (var i = 0; i < dictionary.Buckets.Length; i++) dictionary.Buckets[i] = -1;

                Array.Clear(dictionary.Entries, 0, dictionary.Count);

                dictionary.FreeList = -1;
                dictionary.Count = 0;
                dictionary.FreeCount = 0;
                dictionary.Version++;
            }
        }

        public bool ContainsKey<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key)
        {
            return FindEntry<TKey, TValue>(dictionary, key) >= 0;
        }

        public bool ContainsValue<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TValue value)
        {
            if (value == null)
            {
                for (var i = 0; i < dictionary.Count; i++)
                {
                    if (dictionary.Entries[i].HashCode >= 0 && dictionary.Entries[i].Value == null) return true;
                }
            }
            else
            {
                var c = EqualityComparer<TValue>.Default;

                for (var i = 0; i < dictionary.Count; i++)
                {
                    if (dictionary.Entries[i].HashCode >= 0 && c.Equals(dictionary.Entries[i].Value, value)) return true;
                }
            }
            return false;
        }

        public void CopyTo<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, Models.E01D.Core.Collections.KeyValuePair<TKey, TValue>[] array, int index)
        {
            if (array == null)
            {
                throw XExceptions.Argument.IsNull(nameof(array));
            }

            if (index < 0 || index > array.Length)
            {
                throw XExceptions.Argument.OutOfRange.NeedNonNegativeNumber();
            }

            if (array.Length - index < dictionary.Count)
            {
                throw XExceptions.Api.Arrays.InsufficientSpaceToCopy();
            }

            var count = dictionary.Count;

            var entries = dictionary.Entries;

            for (var i = 0; i < count; i++)
            {
                if (entries[i].HashCode >= 0)
                {
                    array[index++] = new Models.E01D.Core.Collections.KeyValuePair<TKey, TValue>(entries[i].Key, entries[i].Value);
                }
            }
        }

        public int FindEntry<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key)
        {
            if (key == null)
            {
                throw XExceptions.Argument.IsNull(nameof(key));
            }

            if (dictionary.Buckets != null)
            {
                var hashCode = dictionary.Comparer.GetHashCode(key) & 0x7FFFFFFF;

                for (var i = dictionary.Buckets[hashCode % dictionary.Buckets.Length]; i >= 0; i = dictionary.Entries[i].Next)
                {
                    if (dictionary.Entries[i].HashCode == hashCode && dictionary.Comparer.Equals(dictionary.Entries[i].Key, key)) return i;
                }
            }
            return -1;
        }

        private void Insert<TKey,TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key, TValue value, bool add)
        {
            if (dictionary.Comparer == null)
            {
                Create(0, null, dictionary);
            }

            if (key == null)
            {
                throw XExceptions.Argument.IsNull(nameof(key));
            }

            if (dictionary.Buckets == null) Initialize(dictionary, 0);
            var hashCode = dictionary.Comparer.GetHashCode(key) & 0x7FFFFFFF;
            var targetBucket = hashCode % dictionary.Buckets.Length;

#if FEATURE_RANDOMIZED_STRING_HASHING
            int collisionCount = 0;
#endif

            for (var i = dictionary.Buckets[targetBucket]; i >= 0; i = dictionary.Entries[i].Next)
            {
                if (dictionary.Entries[i].HashCode == hashCode && dictionary.Comparer.Equals(dictionary.Entries[i].Key, key))
                {
                    if (add)
                    {
                        throw XExceptions.Argument.AddingDuplicateWithKey(key);
                    }
                    dictionary.Entries[i].Value = value;
                    dictionary.Version++;
                    return;
                }

#if FEATURE_RANDOMIZED_STRING_HASHING
                collisionCount++;
#endif
            }
            int index;
            if (dictionary.FreeCount > 0)
            {
                index = dictionary.FreeList;
                dictionary.FreeList = dictionary.Entries[index].Next;
                dictionary.FreeCount--;
            }
            else
            {
                if (dictionary.Count == dictionary.Entries.Length)
                {
                    Resize(dictionary);
                    targetBucket = hashCode % dictionary.Buckets.Length;
                }
                index = dictionary.Count;
                dictionary.Count++;
            }

            dictionary.Entries[index].HashCode = hashCode;
            dictionary.Entries[index].Next = dictionary.Buckets[targetBucket];
            dictionary.Entries[index].Key = key;
            dictionary.Entries[index].Value = value;
            dictionary.Buckets[targetBucket] = index;
            dictionary.Version++;

#if FEATURE_RANDOMIZED_STRING_HASHING
            // In case we hit the collision threshold we'll need to switch to the comparer which is using randomized string hashing
            // in this case will be EqualityComparer<string>.Default.
            // Note, randomized string hashing is turned on by default on coreclr so EqualityComparer<string>.Default will 
            // be using randomized string hashing

            if (collisionCount > HashHelpers.HashCollisionThreshold && comparer == NonRandomizedStringEqualityComparer.Default) 
            {
                comparer = (IEqualityComparer<TKey>) EqualityComparer<string>.Default;
                Resize(entries.Length, true);
            }
#endif

        }

        private void Resize<TKey,TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary)
        {
            Resize(dictionary, Hashing.ExpandPrime(dictionary.Count), false);
        }

        private void Resize<TKey,TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, int newSize, bool forceNewHashCodes)
        {
            XDebug.Assert(newSize >= dictionary.Entries.Length);
            var newBuckets = new int[newSize];
            for (var i = 0; i < newBuckets.Length; i++) newBuckets[i] = -1;
            var newEntries = new DictionaryEntry<TKey, TValue>[newSize];
            Array.Copy(dictionary.Entries, 0, newEntries, 0, dictionary.Count);
            if (forceNewHashCodes)
            {
                for (var i = 0; i < dictionary.Count; i++)
                {
                    if (newEntries[i].HashCode != -1)
                    {
                        newEntries[i].HashCode = (dictionary.Comparer.GetHashCode(newEntries[i].Key) & 0x7FFFFFFF);
                    }
                }
            }
            for (var i = 0; i < dictionary.Count; i++)
            {
                if (newEntries[i].HashCode >= 0)
                {
                    var bucket = newEntries[i].HashCode % newSize;
                    newEntries[i].Next = newBuckets[bucket];
                    newBuckets[bucket] = i;
                }
            }

            dictionary.Buckets = newBuckets;

            dictionary.Entries = newEntries;
        }

        public bool Remove<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key)
        {
            if (key == null)
            {
                throw XExceptions.Argument.IsNull(nameof(key));
            }

            if (dictionary.Buckets != null)
            {
                var hashCode = dictionary.Comparer.GetHashCode(key) & 0x7FFFFFFF;
                var bucket = hashCode % dictionary.Buckets.Length;
                var last = -1;
                for (var i = dictionary.Buckets[bucket]; i >= 0; last = i, i = dictionary.Entries[i].Next)
                {
                    if (dictionary.Entries[i].HashCode == hashCode && dictionary.Comparer.Equals(dictionary.Entries[i].Key, key))
                    {
                        if (last < 0)
                        {
                            dictionary.Buckets[bucket] = dictionary.Entries[i].Next;
                        }
                        else
                        {
                            dictionary.Entries[last].Next = dictionary.Entries[i].Next;
                        }
                        dictionary.Entries[i].HashCode = -1;
                        dictionary.Entries[i].Next = dictionary.FreeList;
                        dictionary.Entries[i].Key = default(TKey);
                        dictionary.Entries[i].Value = default(TValue);
                        dictionary.FreeList = i;
                        dictionary.FreeCount++;
                        dictionary.Version++;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool TryGetValue<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key, out TValue value)
        {
            var i = FindEntry(dictionary, key);
            if (i >= 0)
            {
                value = dictionary.Entries[i].Value;
                return true;
            }
            value = default(TValue);
            return false;
        }

        // Method similar to TryGetValue that returns the value instead of putting it in an out param.
        public TValue GetValueOrDefault<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key) => GetValueOrDefault(dictionary, key, default(TValue));

        // Method similar to TryGetValue that returns the value instead of putting it in an out param. If the entry
        // doesn't exist, returns the defaultValue instead.
        public TValue GetValueOrDefault<TKey, TValue>(Root.Code.Models.E01D.Core.Collections.Generic.Dictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
        {
            var i = FindEntry(dictionary, key);
            if (i >= 0)
            {
                return dictionary.Entries[i].Value;
            }
            return defaultValue;
        }
    }
}
