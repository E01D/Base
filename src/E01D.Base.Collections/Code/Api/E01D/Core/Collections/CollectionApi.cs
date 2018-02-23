using Root.Code.Models.E01D.Core.Collections;

namespace Root.Code.Api.E01D.Core.Collections
{
    public class CollectionApi
    {
        public object GetSyncRoot(Collection_I collection)
        {
            // syncroot should not ever be null.
            return collection.SyncRoot;

        }
    }
}
