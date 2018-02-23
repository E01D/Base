using System;
using Root.Coding.Code.Models.E01D.Base.Net;

namespace Root.Code.Models.E01D.Net.Http.Base
{
    public interface HttpRequestBase_I<TDefinition, TNetworkClient> : HttpRequestBase_I<TNetworkClient>
    {
        TDefinition Definition { get; set; }
    }

    public interface HttpRequestBase_I<TNetworkClient> : HttpRequestBase_I
    {
        new TNetworkClient NetworkClient { get; set; }

        
    }

    public interface HttpRequestBase_I:Request_I
    {
        object NetworkClient { get; }

        Uri AbsoluteUri { get; set; }

        string Body { get; set; }
    }
}
