using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Api.E01D.Core.Collections.ThreadSafe;
using Root.Coding.Code.Models.E01D.Core.Collections.ThreadSafe;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XThreadSafe
    {
        public static ThreadSafeStoreApi Api { get; set; } = new ThreadSafeStoreApi();

        public static ThreadSafeStore<TKey, TValue> ThreadSafeStore<TKey, TValue>(Func<TKey, TValue> creator)
        {
            return XThreadSafe.Api.ThreadSafeStore(creator);

        }

        public static TValue Get<TKey, TValue>(ThreadSafeStore<TKey, TValue> store, TKey key)
        {
            return XThreadSafe.Api.Get(store, key);
        }
    }
}
