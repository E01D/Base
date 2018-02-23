using System;
using Root.Coding.Code.Models.E01D.Base.Net;

namespace Root.Code.Models.E01D.Net.Http.Base
{
    public class HttpRequestBase<TNetworkClient>: HttpRequestBase<HttpRequestDefinition, TNetworkClient>
    {
        
    }

    public class HttpRequestBase<TDefinition, TNetworkClient> : RequestBase, HttpRequestBase_I<TNetworkClient>
    {
        public Uri AbsoluteUri { get; set; }

        public string Body { get; set; }

        public TDefinition Definition { get; set; }

        object HttpRequestBase_I.NetworkClient
        {
            get
            {
                return NetworkClient;
            }
        }

        public TNetworkClient NetworkClient { get; set; }
    }
}
