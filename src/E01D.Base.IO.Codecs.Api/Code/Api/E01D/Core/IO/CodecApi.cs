using Root.Code.Api.E01D.Core.IO.Codecs;

namespace Root.Code.Api.E01D.Core.IO
{
    public class CodecApi
    {
        public BigEndianCodecApi BigEndian { get; set; } = new BigEndianCodecApi();

        public LittleEndianCodecApi LittleEndian { get; set; } = new LittleEndianCodecApi();

        
    }
}
