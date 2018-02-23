using System;
using System.Collections.Generic;
using Root.Coding.Code.Models.E01D.Base.Net;

namespace Root.Code.Models.E01D.Net.Http.Base
{
    public abstract class HttpResponseBase<TRequest, TNetworkResponse> : ResponseBase, HttpResponseBase_I
        where TRequest:HttpRequestBase_I
    {
        /// <summary>
        /// Gets or sets the content of the response.
        /// </summary>
        public HttpResponseContent Content { get; set; } = new HttpResponseContent();

        /// <summary>
        /// Gets or sets the cookies of the http response.
        /// </summary>
        public IList<HttpCookie> Cookies { get; set; }

        /// <summary>
        /// Gets or sets the URI that handled the response.  
        /// </summary>
        /// <remarks>This can be different from the initial request uri if the server redirected the request to another server endpoint.</remarks>
        public Uri RequestHandlerUri { get; set; }

        public TNetworkResponse NetworkResponse { get; set; }

        /// <summary>
        /// Gets or sets a protocol version
        /// </summary>
        public System.Version ProtocalVersion { get; set; }

        /// <summary>
        /// Gets or sets the status of the response.
        /// </summary>
        public HttpStatus Status { get; set; } = new HttpStatus();

        /// <summary>
        /// Gets or sets the request associated with this response
        /// </summary>
        public new TRequest Request { get; set; }

        protected override Request_I GetRequest()
        {
            return this.Request;
        }


    }
}
