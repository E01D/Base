using Root.Code.Models.E01D.Net.Http.Standard;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest
{
    public interface RestResponse_I
    {
        /// <summary>
        /// Gets the raw content of the response.
        /// </summary>
        string RawContent { get; }

        HttpResponse_I HttpResponse { get;  }
    }
}
