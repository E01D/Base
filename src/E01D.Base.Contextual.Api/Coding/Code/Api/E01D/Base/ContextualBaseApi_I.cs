
namespace Root.Coding.Code.Api.E01D.Base
{
    public interface ContextualBaseApi_I
    {
        object Get();

        T GetAs<T>() where T : class;

        object GetGlobal();

        T GetGlobalAs<T>() where T : class;

    }
}
