using System;

namespace Root.Coding.Code.Framework.E01D
{
    public interface ApiResolverApi_I
    {
        TApi GetApi<TApi>();
        object GetApi(Type type);
    }
}
