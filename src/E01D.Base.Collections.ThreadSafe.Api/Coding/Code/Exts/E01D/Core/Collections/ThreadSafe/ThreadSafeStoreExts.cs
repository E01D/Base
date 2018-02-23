using System;
using System.Collections.Concurrent;
using Root.Coding.Code.Domains.E01D;
using Root.Coding.Code.Models.E01D.Core.Collections.ThreadSafe;

namespace Root.Coding.Code.Exts.E01D.Core.Collections.ThreadSafe
{
    public static class ThreadSafeStoreExts
    {
        public static TValue Get<TKey, TValue>(this ThreadSafeStore<TKey, TValue> store, TKey key)
        {
            return XThreadSafe.Get<TKey, TValue>(store, key);
        }


    }
}

