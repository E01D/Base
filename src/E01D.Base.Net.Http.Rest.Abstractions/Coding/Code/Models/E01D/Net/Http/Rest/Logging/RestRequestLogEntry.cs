namespace Root.Coding.Code.Models.E01D.Net.Http.Rest.Logging
{
    public class RestRequestLogEntry: RestLogEntry
    {
        

        

        public bool Authenticated { get; set; }

        public string IpAddress { get; set; }

        public string Resource { get; set; }

        public string Method { get; set; }

        public string Body { get; set; }

    }
}
