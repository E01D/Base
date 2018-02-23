using Root.Code.Models.E01D.Net.Http.Standard;

namespace Root.Coding.Code.Models.E01D.Net.Http.Rest
{
    public class RestRequest:HttpRequest<RestRequestDefinition_I>, RestRequest_I
    {
        public RestContext RestContext { get; set; }

        public RestCallDefinition RestCallDefinition { get; set; }
    }
}
