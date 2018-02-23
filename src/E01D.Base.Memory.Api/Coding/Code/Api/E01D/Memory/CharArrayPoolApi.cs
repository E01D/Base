namespace Root.Coding.Code.Api.E01D.Memory
{
    public class CharArrayPoolApi: ArrayPoolApi_I<char>
    {
        public char[] Rent(int minimumLength)
        {
            // use System.Buffers shared pool
            return System.Buffers.ArrayPool<char>.Shared.Rent(minimumLength);
        }

        public void Return(char[] array)
        {
            // use System.Buffers shared pool
            System.Buffers.ArrayPool<char>.Shared.Return(array);
        }
    }
}
