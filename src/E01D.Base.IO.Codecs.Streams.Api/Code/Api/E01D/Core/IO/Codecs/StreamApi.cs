using Root.Code.Api.E01D.Core.IO.Codecs.Streams;

namespace Root.Code.Api.E01D.Core.IO.Codecs
{
    public class StreamApi
    {
        public BlockStreamApi BlockStreams { get; set; } = new BlockStreamApi();

        public ByteStreamApi Bytes { get; set; } = new ByteStreamApi();
        
    }
}
