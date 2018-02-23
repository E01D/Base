using Root.Coding.Code.Api.E01D.Base.Containers;
using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Models.E01D.Base.Errors;

namespace Root.Coding.Code.Models.E01D.Base.Results
{
    public class Result<TData> : Result, Result_I<TData>
    {
        public TData Data { get; set; }
    }

    public class Result : Result_I
    {
        public bool Successful { get; set; }

        public string Status { get; set; }

        public long ElapsedMilliseconds { get; set; }

        public CollectionContainer_I<Error_I> Errors { get; set; }
    }

    
}
