using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Domains.E01D;

namespace Root.Coding.Code.Models.E01D.Core.Collections.ThreadSafe
{
    public class ThreadSafeStore<TKey, TValue>
    {
        
        
//#if HAVE_CONCURRENT_DICTIONARY
        public ConcurrentDictionary<TKey, TValue> InternalStore { get; set; }
//#else
//        private readonly object Lock = new object();
//        private Dictionary<TKey, TValue> InternalStore;
//#endif
        public Func<TKey, TValue> Creator { get; set; }

        public ThreadSafeStore()
        {
        }

        
    }
}

