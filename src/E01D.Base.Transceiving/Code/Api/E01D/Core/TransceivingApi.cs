
using Root.Code.Api.E01D.Core.Transceiving;
using IOApi = Root.Coding.Code.Api.E01D.Core.IOApi;

namespace Root.Code.Api.E01D.Core
{
    public class TransceivingApi
    {
        public IOApi IO { get; set; } = new IOApi();

        public TranceiverApi Transceivers { get; set; } = new TranceiverApi();
    }
}
