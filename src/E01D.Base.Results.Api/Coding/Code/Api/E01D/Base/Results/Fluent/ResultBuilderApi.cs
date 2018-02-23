using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Api.E01D.Base.Results.Fluent
{
    public class ResultBuilderApi: ResultBuilderApi_I
    {
        public TResult Exception<T, TResult, TException>() where TResult : Result_I<T>
        {
            throw new System.NotImplementedException();
        }
    }
}
