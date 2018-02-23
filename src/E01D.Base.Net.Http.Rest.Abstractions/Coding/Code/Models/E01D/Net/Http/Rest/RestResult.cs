using System;
using System.Net;
using Root.Coding.Code.Api.E01D.Base.Containers.Collections;
using Root.Coding.Code.Models.E01D.Base.Errors;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest
{
    public class RestResult<T> : RestResult, RestResult_I<T>
    {   
        public T Data { get; set; }
    }

    public class RestResult:RestResult_I
    {
        public bool Successful { get; set; }
        public string Status { get; set; }
        public long ElapsedMilliseconds { get; set; }
        public CollectionContainer_I<Error_I> Errors { get; set; }
        public string Content { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public Exception Exception { get; set; }
    }
}
