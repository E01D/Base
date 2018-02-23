using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Results.Fluent
{
    public interface ResultBuilderApi_I
    {
        TResult Exception<T, TResult, TException>()
            where TResult : Result_I<T>;
    }
}
