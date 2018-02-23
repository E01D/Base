namespace Root.Coding.Code.Api.E01D.Core.IO
{
    public class ByteApi
    {
        public byte[] CreateArray()
        {
            return CreateArray(64);
        }

        public byte[] CreateArray(int size)
        {
            var bytes = new byte[size];

            return bytes;
        }
    }
}
