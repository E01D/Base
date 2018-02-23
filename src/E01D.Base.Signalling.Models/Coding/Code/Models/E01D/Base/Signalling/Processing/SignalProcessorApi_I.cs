namespace Root.Coding.Code.Models.E01D.Base.Signalling.Processing
{
    public interface SignalProcessorApi_I
    {
        object ProcessSignal(SignalProcessorContext_I processorContext, RawSignal rawSignal);
    }
}
