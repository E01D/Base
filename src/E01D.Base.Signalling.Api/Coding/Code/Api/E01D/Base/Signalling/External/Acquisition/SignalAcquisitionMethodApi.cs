using Root.Coding.Code.Models.E01D.Base.Signalling;

namespace Root.Coding.Code.Api.E01D.Base.Signalling.External.Acquisition
{
    public abstract class SignalAcquisitionMethodApi
    {
        public abstract bool AcquireSignal<TSignal>(RawSignal rawSignal, out TSignal signal);
    }
}
