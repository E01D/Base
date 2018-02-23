using Root.Code.Api.E01D.Core.Transceiving.IO;

namespace Root.Code.Api.E01D.Core.Transceiving
{
    public class IOApi
    {
        public BlockStreamApi BlockStreams { get; set; } = new BlockStreamApi();
    }
}
