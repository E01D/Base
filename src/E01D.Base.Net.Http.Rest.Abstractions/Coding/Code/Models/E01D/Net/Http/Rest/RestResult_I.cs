using System.Net;
using Root.Coding.Code.Models.E01D.Base.Results;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest
{
    public interface RestResult_I<T>:RestResult_I
    {
        T Data { get; set; }
    }

    public interface RestResult_I:Result_I
    {
        string Content { get; set; }

        HttpStatusCode StatusCode { get; set; }
    }
}