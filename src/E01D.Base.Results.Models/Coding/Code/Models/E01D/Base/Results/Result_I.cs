using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Models.E01D.Base.Errors;

namespace Root.Coding.Code.Models.E01D.Base.Results
{
    public interface Result_I
    {
        bool Successful { get; set; }

        string Status { get; set; }

        long ElapsedMilliseconds { get; set; }

        CollectionContainer_I<Error_I> Errors { get; set; }
    }

    public interface Result_I<TData>: Result_I
    {
        TData Data { get; set; }
    }
}
