using Root.Coding.Code.Api.E01D;
using Root.Coding.Code.Api.E01D.Memory;


namespace Root.Coding.Code.Domains.E01D
{
    public static class XMemory
    {
        public static MemoryApi Api { get; set; } = new MemoryApi();

        public static char[] RentBuffer(ArrayPoolApi_I<char> bufferPool, int minSize)
        {
            return Api.Buffers.RentBuffer(bufferPool, minSize);
        }

        public static void ReturnBuffer(ArrayPoolApi_I<char> bufferPool, char[] buffer)
        {
            Api.Buffers.ReturnBuffer(bufferPool, buffer);
        }

        public static char[] EnsureBufferSize(ArrayPoolApi_I<char> bufferPool, int size, char[] buffer)
        {
            return Api.Buffers.EnsureBufferSize(bufferPool, size, buffer);
        }

        public static char[] RentBuffer(int minimumLength)
        {
            return Api.Chars.Rent(minimumLength);
        }

        public static void ReturnBuffer(char[] array)
        {
            Api.Chars.Return(array);
        }
    }
}
