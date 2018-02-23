

using Root.Coding.Code.Models.E01D.Base.Security.Authentication;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest
{
    public class RestClientContext
    {
        public Token BearerToken { get; set; }

        public string Endpoint { get; set; }

        public string LoginResourcePath { get; set; }

    }
}
