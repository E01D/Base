using System;
using System.Collections.Generic;
using Root.Coding.Code.Exts.E01D.Core.Collections.ThreadSafe;
using Root.Coding.Code.Models.E01D.Core.Collections.ThreadSafe;

namespace Root.Coding.Code.Api.E01D.Json.Collections
{
    public class CachedAttributeGetterApi
    {
        private readonly Dictionary<RuntimeTypeHandle, ThreadSafeStore<object, Attribute>> dictionary = new Dictionary<RuntimeTypeHandle, ThreadSafeStore<object, Attribute>>();

        public T GetAttribute<T>(object type) where T:Attribute
        {
            var tType = typeof(T);

            if (!dictionary.TryGetValue(tType.TypeHandle, out ThreadSafeStore<object, Attribute> threadSafeStore))
            {
                threadSafeStore = new ThreadSafeStore<object, Attribute>();
            }

            return (T)threadSafeStore.Get(type);
        }
    }
}
