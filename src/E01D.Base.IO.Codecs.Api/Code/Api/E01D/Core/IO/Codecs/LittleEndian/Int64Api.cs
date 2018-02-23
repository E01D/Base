using System;
using System.Runtime.CompilerServices;
using Root.Code.Models.E01D.Core.IO;

namespace Root.Code.Api.E01D.Core.IO.Codecs.LittleEndian
{
    public class Int64Api:Codec_I<long>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(Block_I block)
        {
            return Read(block);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(Block_I block, object value)
        {
            Write(block, (long)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        object ObjectCodec_I.Read(byte[] block, int offset)
        {
            return Read(block, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void ObjectCodec_I.Write(byte[] block, int offset, object value)
        {
            Write(block, offset, (long)value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Read(Block_I block)
        {
            return Read(block.Data, block.Position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long Read(byte[] block, int offset)
        {
            offset += 7;

            long msb = block[offset--];
            long mb6 = block[offset--];
            long mb5 = block[offset--];
            long mb4 = block[offset--];
            long mb3 = block[offset--];
            long mb2 = block[offset--];
            long mb1 = block[offset--];
            long lsb = block[offset];

            return (msb << 56) // most significant byte, largest address
                | (mb6 << 48)
                | (mb5 << 40)
                | (mb4 << 32)
                | (mb3 << 24)
                | (mb2 << 16)
                | (mb1 << 8)
                | (lsb);      // least significant byte, smallest address
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(Block_I block, long value)
        {
            Write(block.Data, block.Position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(byte[] block, int offset, long value)
        {
            offset += 7;

            // It is generally faster to substract one each time then to add a fixed value each time as the operation does not require an argument to be passed.
            // In little endian, you store the least significant byte in the smallest address. 

            block[offset--] = (byte)(value >> 56); // most significant byte, largest address
            block[offset--] = (byte)(value >> 48);
            block[offset--] = (byte)(value >> 40);
            block[offset--] = (byte)(value >> 32);
            block[offset--] = (byte)(value >> 24);
            block[offset--] = (byte)(value >> 16);
            block[offset--] = (byte)(value >> 8);
            block[offset] = (byte)(value);    // least significant byte, smallest address




                 
        }
    }
}
