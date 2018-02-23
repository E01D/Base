using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest.CallComponents
{
    public class RestCallComponentContainer
    {
        public Dictionary<string, RestRequestComponent> UrlSegments { get; set; } = new Dictionary<string, RestRequestComponent>();
        
    }
}
