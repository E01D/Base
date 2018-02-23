using Root.Coding.Code.Api.E01D.Collections;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XStandardCollections
    {
        public static StandardCollectionApi Api { get; set; } = new StandardCollectionApi();

        public static T[] ArrayEmpty<T>()
        {
            return Api.ArrayEmpty<T>();
        }
    }
}
