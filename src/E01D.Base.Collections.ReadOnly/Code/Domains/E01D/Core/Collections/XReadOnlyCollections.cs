using Root.Code.Api.E01D.Core.Collections;

namespace Root.Code.Domains.E01D.Core.Collections
{
    public static class XReadOnlyCollections
    {
         public static ReadOnlyCollectionApi ReadOnlyCollections { get; set; } = new ReadOnlyCollectionApi();

        public static ReadOnlyListApi ReadOnlyLists { get; set; } = new ReadOnlyListApi();
    }
}
