using Root.Coding.Code.Models.E01D.Base.Signalling;

namespace Root.Coding.Code.Api.E01D.Base.Signalling.External.Processing
{
    public interface SignalProcessorApi_I
    {
        object ProcessSignal(SignalProcessorContext_I processorContext, RawSignal rawSignal);
    }
}
