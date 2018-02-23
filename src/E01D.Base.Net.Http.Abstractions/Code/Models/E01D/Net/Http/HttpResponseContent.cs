namespace Root.Code.Models.E01D.Net.Http
{
    public class HttpResponseContent
    {
        public string MimeContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ContentAsString { get; set; }

        public byte[] ContentAsRawBytes { get; set; }

        public long ContentLength { get; set; }

        public string ContentEncoding { get; set; }
    }
}
