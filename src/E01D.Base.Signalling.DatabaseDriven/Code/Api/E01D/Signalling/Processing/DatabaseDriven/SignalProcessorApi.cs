using Root.Coding.Code.Api.E01D.Base.Signalling.External.Processing;
using Root.Coding.Code.Models.E01D.Base.Signalling;

namespace Root.Code.Api.E01D.Signalling.Processing.DatabaseDriven
{
    public class SignalProcessorApi: SignalProcessingApiBase, SignalProcessorApi_I
    {
        public object ProcessSignal(SignalProcessorContext_I processorContext, RawSignal rawSignal)
        {
            throw new System.NotImplementedException();
        }
    }
}
