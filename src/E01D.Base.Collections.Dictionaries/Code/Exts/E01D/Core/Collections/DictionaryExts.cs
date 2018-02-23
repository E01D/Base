using Root.Code.Domains.E01D;
using Root.Code.Models.E01D.Core.Collections.Generic;

namespace Root.Code.Exts.E01D.Core.Collections
{
    public static class DictionaryExts
    {
        public static void Add<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue valueToAdd)
        {
            XDictionaries.Api.Add(dictionary, key, valueToAdd);
        }

        public static Dictionary<TKey, TValue> Clone<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            return XDictionaries.Api.Clone(dictionary);
        }

        public static bool ContainsKey<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
        {
            return XDictionaries.Api.ContainsKey(dictionary, key);
        }

        public static bool ContainsValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TValue aValue)
        {
            return XDictionaries.Api.ContainsValue(dictionary, aValue);
        }

        public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
        {
            return XDictionaries.Api.GetValue(dictionary, key);
        }

        public static void SetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue valueToSet)
        {
            XDictionaries.Api.SetValue(dictionary, key, valueToSet);
        }

        public static bool TryGetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary,
            TKey key, out TValue value)
        {
            return XDictionaries.Api.TryGetValue(dictionary, key, out value);
        }
    }
}
