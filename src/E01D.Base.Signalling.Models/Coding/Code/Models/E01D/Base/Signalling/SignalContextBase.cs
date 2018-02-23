using System.Collections.Generic;
using Root.Code.Models.E01D.Net.Http;

namespace Root.Coding.Code.Models.E01D.Base.Signalling
{
    public class SignalContextBase
    {
        /// <summary>
        /// Gets or sets the http body that was included in the web request.
        /// </summary>
        public string HttpBody { get; set; }

        public Dictionary<string, HttpHeader> HttpHeaders { get; set; }
    }
}
