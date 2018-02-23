namespace Root.Coding.Code.Models.E01D.Base.Signalling.Acquisition
{
    public class SignalAcquisitionMethod
    {
        public string Name { get; set; }

        public bool IsEnabled { get; set; }

        public SignalAcquisitionMethodApi_I Api { get; set; }
    }
}
