using System.Net;

namespace Root.Code.Models.E01D.Net.Http
{
    public class HttpStatus
    {
        /// <summary>
        /// Gets or sets the HTTP status code associated with the http response
        /// </summary>
        public HttpStatusCode Code { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Gets the interrupted value of the http response.
        /// </summary>
        /// <remarks>By default this value is set to none to unknown to indicate that the response has not been requested at all yet.  When the request is made, then 
        /// the response changes to None.</remarks>
        public HttpResponseStatus Value { get; set; } = HttpResponseStatus.Unknown;
    }
}
