using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root.Coding.Code.Models.E01D.Base.Collections.DoubleDictionaries;

namespace Root.Coding.Code.Api.E01D.Base.Collections
{
    public interface DoubleDictionaryApi_I<TId, TKey, T>
    {
        void Add(DoubleDictionary_I<TId, TKey, T> dictionary, T item);

        T Get(DoubleDictionary_I<TId, TKey, T> dictionary, TId id);

        T Get(DoubleDictionary_I<TId, TKey, T> dictionary, TKey key);

        List<T> GetAll(DoubleDictionary_I<TId, TKey, T> dictionary);

        void Remove(DoubleDictionary_I<TId, TKey, T> dictionary, TKey key);

        void Remove(DoubleDictionary_I<TId, TKey, T> dictionary, TId id);
    }
}
