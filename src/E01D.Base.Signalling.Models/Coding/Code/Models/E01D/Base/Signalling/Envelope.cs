namespace Root.Coding.Code.Models.E01D.Base.Signalling
{
    public class Envelope
    {
        public string Version { get; set; }

        public string Nonce { get; set; }

        public string Created { get; set; }

        public string ContentFormat { get; set; } = "application/json";

        public PayloadObject Object { get; set; }
    }
}
