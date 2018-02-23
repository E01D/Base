namespace Root.Coding.Code.Models.E01D.Net.Http.Rest.Logging
{
    public class RestResponseLogEntry:RestLogEntry
    {
       

        public bool Authenticated { get; set; }

        public string IpAddress { get; set; }

        public string Method { get; set; }

        public string Raw { get; set; }
    }
}
