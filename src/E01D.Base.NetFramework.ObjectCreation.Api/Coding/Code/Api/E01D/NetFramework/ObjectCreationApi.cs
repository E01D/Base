using Root.Coding.Code.Api.E01D.NetFramework.ObjectCreation;

namespace Root.Coding.Code.Api.E01D.NetFramework
{
    public class ObjectCreationApi
    {
        public ObjectFactoryApi_I Factory { get; set; } = new ObjectFactoryApi();

        public T New<T>()
        {
            var factory = Factory;

            if (factory == null) return default(T);

            return (T)factory?.New(typeof(T));
        }

        public object New(System.Type type)
        {
            return Factory?.New(type);
        }
    }
}
