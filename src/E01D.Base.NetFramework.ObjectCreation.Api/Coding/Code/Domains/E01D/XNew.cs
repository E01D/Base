using Root.Coding.Code.Api.E01D.NetFramework;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XNew
    {
        public static ObjectCreationApi Api { get; set; } = new ObjectCreationApi();

        public static T New<T>()
        {
            return Api.New<T>();
        }

        public static object New(System.Type type)
        {
            return Api.New(type);
        }
    }
}
