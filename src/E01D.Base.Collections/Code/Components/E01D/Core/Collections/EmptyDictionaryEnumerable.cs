using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Root.Code.Components.E01D.Core.Collections
{
    public static class EmptyDictionaryEnumerable<TKey, TValue>
    {
        private static volatile ReadOnlyDictionary<TKey, TValue> _Value;

        public static ReadOnlyDictionary<TKey, TValue> EmptyDictionary => _Value ?? (_Value = new ReadOnlyDictionary<TKey, TValue>(new SortedList<TKey, TValue>()));
    }
}
