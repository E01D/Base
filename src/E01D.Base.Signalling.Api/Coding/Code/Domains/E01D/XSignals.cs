using Root.Coding.Code.Api.E01D.Base;
using Root.Coding.Code.Models.E01D.Base.Signalling;

namespace Root.Coding.Code.Domains.E01D
{
    public static class XSignals
    {
        public static SignallingApi_I Api { get; set; } = new SignallingApi();
        

        public static object EnqueueSignal(RawSignal signal)
        {
            return null;


        }
    }
}
