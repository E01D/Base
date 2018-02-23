using Root.Code.Exts.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections.Generic;

namespace Root.Code.Api.E01D.Core.Collections
{
    public class ReadOnlyCollectionApi
    {
        public ReadOnlyCollection<T> Create<T>(List<T> list)
        {
            var roc = new ReadOnlyCollection<T>()
            {
                List = list
            };

            return roc;
        }

        public T GetItem<T>(ReadOnlyCollection<T> collection, int index)
        {
            return collection.List.GetItem(index);
        }

        public bool Contains<T>(ReadOnlyCollection<T> collection, T value)
        {
            return collection.List.Contains(value);
        }

        public void CopyTo<T>(ReadOnlyCollection<T> collection, T[] array, int index)
        {
            collection.List.CopyTo(array, index);
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator<T>(ReadOnlyCollection<T> collection)
        {
            return collection.List.GetEnumerator();
        }

        public int IndexOf<T>(ReadOnlyCollection<T> collection, T value)
        {
            return collection.List.IndexOf(value);
        }

        


    }
}
