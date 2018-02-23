using System.Collections.Generic;
using Root.Code.Models.E01D.Net.Http;

namespace Root.Coding.Code.Models.E01D.Base.Signalling
{
    public class RawSignal
    {
        public System.IO.Stream Body { get; set; }
        public string HttpMethod { get; set; }
        public Dictionary<string, HttpHeader> Headers { get; set; }
    }
}
