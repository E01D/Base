using System.Collections.ObjectModel;

namespace Root.Code.Components.E01D.Core.Collections
{
    public static class EmptyEnumerable<T>
    {
        private static volatile ReadOnlyCollection<T> _emptyList;

        public static ReadOnlyCollection<T> EmptyList => _emptyList ?? (_emptyList = new ReadOnlyCollection<T>(new T[0]));
    }
}
