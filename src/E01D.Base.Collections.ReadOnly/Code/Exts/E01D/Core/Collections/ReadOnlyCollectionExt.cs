using Root.Code.Domains.E01D.Core.Collections;
using Root.Code.Models.E01D.Core.Collections;

namespace Root.Code.Exts.E01D.Core.Collections
{
    public static class ReadOnlyCollectionExt
    {
        public static T GetItem<T>(this ReadOnlyCollection<T> collection, int index)
        {
            return XReadOnlyCollections.ReadOnlyCollections.GetItem(collection, index);
        }
    }
}
