using System.Collections.Generic;
using System.Linq;
using Root.Coding.Code.Models.E01D.Base.Collections.DoubleDictionaries;

namespace Root.Coding.Code.Api.E01D.Base.Collections
{
    public abstract class DoubleDictionaryApi<TId, TKey, T>: DoubleDictionaryApi_I<TId, TKey, T>
    {
        

        public void Add(DoubleDictionary_I<TId, TKey, T> dictionary, T item)
        {
            dictionary.NodesById.Add(GetId(item), item);
            dictionary.NodesByUri.Add(GetKey(item), item);
        }

        public T Get(DoubleDictionary_I<TId, TKey, T> dictionary, TId id)
        {
            if (dictionary.NodesById.TryGetValue(id, out T valueToGet))
            {
                return valueToGet;
            }
            return default(T);
        }

        public T Get(DoubleDictionary_I<TId, TKey, T> dictionary, TKey key)
        {
            if (dictionary.NodesByUri.TryGetValue(key, out T valueToGet))
            {
                return valueToGet;
            }
            return default(T);
        }

        public List<T> GetAll(DoubleDictionary_I<TId, TKey, T> dictionary)
        {
            return dictionary.NodesById.Values.ToList();
        }

        public void Remove(DoubleDictionary_I<TId, TKey, T> dictionary, TKey key)
        {
            var node = Get(dictionary, key);

            dictionary.NodesById.Remove(GetId(node));
            dictionary.NodesByUri.Remove(GetKey(node));
        }

        public void Remove(DoubleDictionary_I<TId, TKey, T> dictionary, TId id)
        {
            var node = Get(dictionary, id);

            dictionary.NodesById.Remove(GetId(node));
            dictionary.NodesByUri.Remove(GetKey(node));
        }

        public abstract TKey GetKey(T item);

        public abstract TId GetId(T item);
    }
}
