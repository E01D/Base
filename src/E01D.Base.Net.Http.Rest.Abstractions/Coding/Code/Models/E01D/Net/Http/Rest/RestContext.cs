using System.Text;
using Root.Code.Api.E01D.Net.Http.Security.Authentication;
using Root.Code.Models.E01D.Net.Http;
using Root.Coding.Code.Models.E01D.Net.Http.Rest.CallComponents;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest
{
    public class RestContext:HttpContext
    {
        /// <summary>
        /// Gets or sets whether to always send multipart form data regardless of whether a file is being uploaded or not.
        /// </summary>
        public bool AlwaysSendMultipartFormData { get; set; }

        /// <summary>
        /// Gets or sets the API that is used to authenticate the http request when it is made.
        /// </summary>
        public AuthenticationApi_I Authentication { get; set; }

        public System.Uri BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the default set of rest call components that have setup to always be passed for each component.
        /// </summary>
        public RestCallComponentContainer DefaultComponents { get; set; } = new RestCallComponentContainer();

        /// <summary>
        /// Gets or sets the encoding used by the http request
        /// </summary>
        public Encoding Encoding { get; set; } = Encoding.UTF8;

        public int TimeoutInMilliseconds { get; set; }

        
    }
}
