using System.Collections.Generic;

namespace Root.Coding.Code.Models.E01D.Base.Signalling.Configurational
{
    public class SignallingConfiguration
    {
        public List<SignalAcquisitionMethodConfiguration> SignalAcquisitionMethods { get; set; } = new List<SignalAcquisitionMethodConfiguration>();

        public List<SignalProcessorConfiguration> SignalProcessorConfigurations { get; set; } = new List<SignalProcessorConfiguration>();
    }
}
