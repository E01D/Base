using System;
using System.Collections.Generic;

namespace Root.Code.Models.E01D.Net.Http.Base
{
    public interface HttpResponseBase_I
    {
        /// <summary>
        /// Gets or sets the cookies of the http response.
        /// </summary>
        IList<HttpCookie> Cookies { get; set; }

        /// <summary>
        /// Gets or sets the URI that handled the response.  
        /// </summary>
        /// <remarks>This can be different from the initial request uri if the server redirected the request to another server endpoint.</remarks>
        Uri RequestHandlerUri { get; set; }
    }
}
