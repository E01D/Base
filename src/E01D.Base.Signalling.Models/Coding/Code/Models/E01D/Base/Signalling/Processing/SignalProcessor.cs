namespace Root.Coding.Code.Models.E01D.Base.Signalling.Processing
{
    public class SignalProcessor
    {
        public string Name { get; set; }

        public bool IsEnabled { get; set; }

        public SignalProcessorApi_I Api { get; set; }
    }
}
