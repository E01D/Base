using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Root.Code.Enums.E01D.Net.Http;
using Root.Code.Models.E01D.Core.Collections.Generic;
using HttpWebRequest = Root.Code.Models.E01D.Net.Http.Web.HttpWebRequest;

namespace Root.Code.Models.E01D.Net.Http
{
    public class HttpRequestDefinition: HttpRequestDefinition_I
    {
        


        public bool AllowAutoRedirect { get; set; }

        /// <summary>
        /// Gets or sets whether to always send multipart form data regardless of whether a file is being uploaded or not.
        /// </summary>
        public bool AlwaysSendMultipartFormData { get; set; }

        /// <summary>
        /// Gets or sets the API type that is used to authenticate the http request when it is made.
        /// </summary>
        public HttpAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the type of data decompression that is used.
        /// </summary>
        public DecompressionMethods AutomaticDecompression { get; set; } = DecompressionMethods.Deflate | DecompressionMethods.GZip | DecompressionMethods.None;

        /// <summary>
        /// Gets or sets the cache policy for this request definition.
        /// </summary>
        public RequestCachePolicy CachePolicy { get; set; }

        public ICredentials Credentials { get; set; }

        /// <summary>
        /// Gets or sets the X509 certificate collection
        /// </summary>
        public X509CertificateCollection ClientCertificates { get; set; }

        /// <summary>
        /// Gets or sets the System.NET cookie container that is used to house the cookies.
        /// </summary>
        public List_I<HttpCookie> Cookies { get; } = new List<HttpCookie>();

        /// <summary>
        /// Gets or sets the context associated 
        /// </summary>
        public HttpContext HttpContext { get; set; }

        /// <summary>
        /// Gets or sets controlled header  
        /// </summary>
        public Dictionary<string, Action<HttpWebRequest, string>> ControlledHeaders = new Dictionary<string, Action<HttpWebRequest, string>>();

        /// <summary>
        /// Gets or sets the encoding used by the http request
        /// </summary>
        public Encoding Encoding { get; set; } = Encoding.UTF8;

        public Uri Endpoint { get; set; } 

        /// <summary>
        /// Gets or sets whether 100-continue behavior is used or not.  This is turned off by default.
        /// </summary>
        public bool Expect100Continue { get; set; }

        /// <summary>
        /// Gets or sets the full url of the http request definition
        /// </summary>
        public Uri FullUrl { get; set; }

        public List_I<HttpHeader> Headers { get; } = new List<HttpHeader>();

        public int? MaximumAutomaticRedirections { get; set; }

        /// <summary>
        /// Gets or sets the HTTP method that should be invoked.
        /// </summary>
        public HttpMethodType MethodType { get; set; }

        /// <summary>
        /// Gets or sets the read-write timeout.  If no timeout is set, then the underlying read-write timeout value of the web request is used.
        /// </summary>
        public int? ReadWriteTimeout { get; set; }

        /// <summary>
        /// Gets or sets the response stream writer.  By default, the response is handled in memory, but for longer responses, or for responses that always need to be
        /// directed to a stream (e.g. file or crypto), then this should be set.
        /// </summary>
        public Action<Stream> ResponseStreamWriter { get; set; }

        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets whether pre-authentication is used.
        /// </summary>
        public bool PreAuthenticate { get; set; }

        /// <summary>
        /// Gets or sets the web proxy.
        /// </summary>
        public IWebProxy Proxy { get; set; }

        /// <summary>
        /// Gets or sets whether the credentials under which the user is running should be sent by default to the server.  This is turned off by default.
        /// </summary>
        public bool SendProcessCredentialsByDefault { get; set; }

        /// <summary>
        /// Gets or sets the server certificate validation callback.
        /// </summary>
        public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; set; }

        /// <summary>
        /// Gets or sets the default timeout value.  If no value is specified, the default value provided by the underlying web request is used.
        /// </summary>
        public int? Timeout { get; set; }

        public bool UseDefaultCredentials { get; set; }

        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets whether async callbacks should use the same synchronization context as the caller.  This is turned off by default.
        /// </summary>
        public bool UseTPLSynchronizationContext { get; set; }
        

        

        
        
        
        
        
        
    }
}
