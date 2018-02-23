using Root.Code.Models.E01D.Net.Http.Standard;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest
{
    public class RestResponse:RestResponse_I
    {
        public string RawContent { get; set; }

        public HttpResponse_I HttpResponse { get; set; }
        public RestRequest_I Request { get; set; }
    }

    public class RestResponse<TResult> : RestResponse_I
    {
        public string RawContent { get; set; }

        public HttpResponse_I HttpResponse { get; set; }
        public RestRequest_I Request { get; set; }
    }
}
