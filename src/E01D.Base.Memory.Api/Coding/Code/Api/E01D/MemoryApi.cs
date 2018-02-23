using Root.Coding.Code.Api.E01D.Memory;

namespace Root.Coding.Code.Api.E01D
{
    public class MemoryApi
    {
        public BufferApi Buffers { get; set; } = new BufferApi();
        public CharArrayPoolApi Chars { get; set; } = new CharArrayPoolApi();
    }
}
