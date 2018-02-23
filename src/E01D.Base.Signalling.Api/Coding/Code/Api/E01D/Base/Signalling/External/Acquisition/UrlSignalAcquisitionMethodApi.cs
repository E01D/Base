using Root.Coding.Code.Models.E01D.Base.Signalling;
using Root.Coding.Code.Models.E01D.Base.Signalling.Acquisition;

namespace Root.Coding.Code.Api.E01D.Base.Signalling.External.Acquisition
{
    public class UrlSignalAcquisitionMethodApi: SignalAcquisitionMethodApi, SignalAcquisitionMethodApi_I
    {
        public override bool AcquireSignal<TSignal>(RawSignal rawSignal, out TSignal signal)
        {
            signal = default(TSignal);
            return false;
        }
    }
}
