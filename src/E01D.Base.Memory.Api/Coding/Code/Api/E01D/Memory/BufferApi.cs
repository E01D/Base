using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root.Coding.Code.Api.E01D.Memory
{
    public class BufferApi
    {
        public char[] RentBuffer(ArrayPoolApi_I<char> bufferPool, int minSize)
        {
            if (bufferPool == null)
            {
                return new char[minSize];
            }

            char[] buffer = bufferPool.Rent(minSize);
            return buffer;
        }

        public void ReturnBuffer(ArrayPoolApi_I<char> bufferPool, char[] buffer)
        {
            bufferPool?.Return(buffer);
        }

        public char[] EnsureBufferSize(ArrayPoolApi_I<char> bufferPool, int size, char[] buffer)
        {
            if (bufferPool == null)
            {
                return new char[size];
            }

            if (buffer != null)
            {
                bufferPool.Return(buffer);
            }

            return bufferPool.Rent(size);
        }
    }
}
