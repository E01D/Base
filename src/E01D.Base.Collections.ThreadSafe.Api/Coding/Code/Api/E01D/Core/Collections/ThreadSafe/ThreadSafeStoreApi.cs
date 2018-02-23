using System;
using System.Collections.Concurrent;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Core.Collections.ThreadSafe;

namespace Root.Coding.Code.Api.E01D.Core.Collections.ThreadSafe
{
    public class ThreadSafeStoreApi
    {

        public ThreadSafeStore<TKey, TValue> ThreadSafeStore<TKey, TValue>(Func<TKey, TValue> creator)
        {

            XValidation.ArgumentNotNull(creator, nameof(creator));

            return new Models.E01D.Core.Collections.ThreadSafe.ThreadSafeStore<TKey, TValue>()
            {
                Creator = creator,
//#if HAVE_CONCURRENT_DICTIONARY
                InternalStore = new ConcurrentDictionary<TKey, TValue>()
//#else
//                InternalStore = new Dictionary<TKey, TValue>();
//                Lock = new object();
//#endif
            };
        }

        public TValue Get<TKey, TValue>(ThreadSafeStore<TKey, TValue> store, TKey key)
        {
//#if HAVE_CONCURRENT_DICTIONARY
            return store.InternalStore.GetOrAdd(key, store.Creator);
//#else
//            TValue value;
//            if (!store.InternalStore.TryGetValue(key, out value))
//            {
//                return AddValue(key);
//            }

//            return value;
//#endif
        }

//#if !HAVE_CONCURRENT_DICTIONARY
//        private TValue AddValue(ThreadSafeStore<TKey, TValue> store, TKey key)
//        {
//            TValue value = store.Creator(key);

//            lock (_lock)
//            {
//                if (store.InternalStore == null)
//                {
//                    store.InternalStore = new Dictionary<TKey, TValue>();
//                    store.InternalStore[key] = value;
//                }
//                else
//                {
//                    // double check locking
//                    TValue checkValue;
//                    if (store.InternalStore.TryGetValue(key, out checkValue))
//                    {
//                        return checkValue;
//                    }

//                    Dictionary<TKey, TValue> newStore = new Dictionary<TKey, TValue>(_store);
//                    newStore[key] = value;

//#if HAVE_MEMORY_BARRIER
//                    Thread.MemoryBarrier();
//#endif
//                    store.InternalStore = newStore;
//                }

//                return value;
//            }
//        }
//#endif
    }
}

